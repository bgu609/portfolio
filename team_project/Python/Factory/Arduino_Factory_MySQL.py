import datetime  # 시간 임포트
import time
import serial  # 시리얼 임포트
import pymysql

# 아두이노 연결
ser_port = '/dev/ttyACM1'  # 포트 설정
brate = 9600  # 시리얼 통신 속도 설정
cmd = 'temp'

def setLabel(image, app_size, shape): # 라벨링 함수
    (text_width, text_height), baseline = cv2.getTextSize("{0} {1}".format(app_size, shape), cv2.FONT_HERSHEY_SIMPLEX, 1, 2)
    cv2.rectangle(image, (x-5, y-5+baseline), (x-5+text_width, y-10-text_height), (200,200,200), cv2.FILLED) # 라벨 배경
    cv2.putText(image, "{0} {1}".format(app_size, shape), (x-5,y-5), cv2.FONT_HERSHEY_SIMPLEX, 1, (0, 0, 0), 2) # 라벨 텍스트



# 실시간 비디오 초기화
height = 480
width = 640
cam = cv2.VideoCapture(0)
cam.set(3, width)
cam.set(4, height)

# 인식을 위한 최소 윈도우 사이즈 (얼굴 인식에 필요해서 만든 것일지도)
minW = 0.1*cam.get(3)
minH = 0.1*cam.get(4)

# 트레일러 영역 정의
track_width = 300
track_nx = (width - track_width)/2
track_px = (width + track_width)/2
#

# 시리얼통신 연결
try:
    ser_val = serial.Serial(ser_port, baudrate=brate, timeout=None)
except Exception as e: # 통신 포트 연결 실패시
    error_msg = list(e.args)[0].split(":") # 에러 메세지 파싱
    print(error_msg[0], ", Please Check Your Port Connection of Device")

while True:

    # 입력값
    i = input()
    # 최초 시작
    if i == '1':
        # 아두이노 물품 옮기기 시작
        ser_val.write(b'1')

        # 움직임 센서 read
        if ser_val.in_waiting != 0:
            content = ser_val.readline()
            vals = content.decode('utf-8').replace('/r/n', '')

            if vals == 11:
                # 카메라 모양 판별
                tri_count = 0
                rec_count = 0

                while True:
                    ret, img_color = cam.read() # 카메라로부터 이미지 획득
                    #img_color = cv2.flip(img_color, 0) # 상하반전
                    
                    #img_color = cv2.fastNlMeansDenoisingColored(img_color, None, 10, 10, 7, 21) # 원본 노이즈 제거 (카메라 이용 시 이 부분에서 처리 시간이 너무 많이 걸림)
                    #img_blur = cv2.GaussianBlur(img_color, (9, 9), cv2.BORDER_DEFAULT) # 가우시안 블러 (처리 시간은 해결됐지만 정확도가 떨어짐)
                    img_blur = cv2.medianBlur(img_color, 3) # 메디안 블러로 ( 엣지 정보 보존에 유리 ) (노이즈 제거 1)

                    imgray = cv2.cvtColor(img_blur, cv2.COLOR_BGR2GRAY) # gray image 획득
                    imgray = cv2.medianBlur(imgray, 5) # gray image 메디안 블러 (노이즈 제거 2) (if 2 median, 3 => 5)

                    threshold = cv2.adaptiveThreshold(imgray, 255, cv2.ADAPTIVE_THRESH_MEAN_C, cv2.THRESH_BINARY_INV, 11, 2) # gray image에 threshold 처리
                    # threshold 이미지 노이즈 제거 (노이즈 제거 3)
                    kernel = np.ones((2,2), np.uint8)
                    threshold = cv2.morphologyEx(threshold, cv2.MORPH_OPEN, kernel)
                    threshold = cv2.dilate(threshold, kernel, iterations = 1)
                    ############################################

                    contours, hierarchy = cv2.findContours(threshold, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE) # contour 추출
                    
                    # contour 분석 ######################################
                    for idx, cnt in enumerate(contours):
                        size = len(cnt)
                        shape = ""

                        # 간소화된 contour
                        epsilon = 0.087 * cv2.arcLength(cnt, True)
                        approx = cv2.approxPolyDP(cnt, epsilon, True)
                        app_size = len(approx)
                        
                        if app_size > 2: # 직선 제외
                            if size>200 and size<900: # contour 사이즈 선택
                                x,y,w,h = cv2.boundingRect(cnt) # contour에 사각형 boundary 형성

                                if x>(track_nx) and (x+w)<(track_px): # boundary가 중간 영역 내부에 있는 경우만 선택
                                    img_color = cv2.rectangle(img_color, (x,y), (x+w,y+h), (0,0,255), 2)
                                    print("Collect Group : ", size, x, y, w, h)
                                    #setLabel(img_color, "{}".format(size), shape)
                                    #setLabel(threshold, "{}".format(size), shape)

                                    #cv2.drawContours(img_color, contours, idx, (255, 0, 0), 1)

                                    if app_size == 3:
                                        shape = "triangle"
                                        tri_count += 1
                                    elif app_size == 4:
                                        shape = "rectangle"
                                        rec_count += 1
                                    else:
                                        shape = "other"
                                    
                                    setLabel(img_color, app_size, shape)
                                    setLabel(threshold, app_size, size)
                                    cv2.drawContours(img_color, approx, -1, (255, 0, 0), 10) # 간소화된 contour 표시
                    ###################################################

                    # 트레일러 영역 표시
                    cv2.line(img_color, (int(track_nx), 0), (int(track_nx), height), (0, 255, 0), 2)
                    cv2.line(img_color, (int(track_px), 0), (int(track_px), height), (0, 255, 0), 2)

                    cv2.imshow("img_color", img_color)
                    cv2.imshow("threshold", threshold)

                    if (tri_count + rec_count) == 99:
                        if tri_count > rec_count:
                            ser_val.write(b'3')
                            break
                        elif tri_count < rec_count:
                            ser_val.write(b'4')
                            break
                    elif tri_count == 50:
                        ser_val.write(b'3')
                        break
                    elif rec_count == 50:
                        ser_val.write(b'4')
                        break

    