import cv2
import numpy as np
# 영상처리형 분류 (단일 소스)
def setLabel(image, app_size, shape): # 라벨링 함수
    (text_width, text_height), baseline = cv2.getTextSize(f"{app_size} {shape}", cv2.FONT_HERSHEY_SIMPLEX, 1, 2)
    cv2.rectangle(image, (x-5, y-5+baseline), (x-5+text_width, y-10-text_height), (200,200,200), cv2.FILLED)
    cv2.putText(image, f"{app_size} {shape}", (x-5,y-5), cv2.FONT_HERSHEY_SIMPLEX, 1, (0, 0, 0), 2)

img_color = cv2.imread("test\\test2.jpg", cv2.IMREAD_COLOR)
height, width, channels = img_color.shape
print(height, width, channels)


############### 색상 마스킹 #######################
# hsv = cv2.cvtColor(img_color, cv2.COLOR_BGR2HSV)

# bgr_color = np.uint8([[[112, 190, 233]]]) # 색상은 아직 수동으로 입력 ( 색상 리스트를 만들어서 조건문으로 처리하거나, 이미지 특정 위치에서 색상을 알아내는 방법을 써야할듯(이게 되는지는 모름) )
# hsv_color = cv2.cvtColor(bgr_color,cv2.COLOR_BGR2HSV)
# get_color = hsv_color[0][0][0]
# print(get_color) # bgr에서 hsv로 변환후 색상만 추출

# # hsv 코드 범위
# lower_blue = np.array([get_color-10,50,50])
# upper_blue = np.array([get_color+10,255,255])

# mask = cv2.inRange(hsv, lower_blue, upper_blue)
# res = cv2.bitwise_and(img_color, img_color, mask=mask)

# cv2.imshow('img_color', img_color) #원본
# cv2.waitKey(0)
# cv2.imshow('mask', mask) #마스크
# cv2.waitKey(0)
# cv2.imshow('res', res) #지정한 색상
# cv2.waitKey(0)


# contours, hierarchy = cv2.findContours(mask, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE) #마스크를 이용하여 모양 특정하기
###################################################

############### 영상 처리 부분 #######################
# 트레일러 영역 정의
track_width = 220
track_nx = (width - track_width)/2
track_px = (width + track_width)/2
#

#img_color = cv2.fastNlMeansDenoisingColored(img_color, None, 10, 10, 7, 21) # 원본 노이즈 제거 (카메라 이용 시 이 부분에서 시간이 너무 많이 걸림)
#img_blur = cv2.GaussianBlur(img_color, (9, 9), cv2.BORDER_DEFAULT) # 가우시안 블러
img_blur = cv2.medianBlur(img_color, 9) # 메디안 블러 ( 엣지 정보 보존에 유리 )

imgray = cv2.cvtColor(img_blur, cv2.COLOR_BGR2GRAY) # gray image 획득
#imgray = cv2.medianBlur(imgray, 5) # gray image 노이즈 제거

threshold = cv2.adaptiveThreshold(imgray, 255, cv2.ADAPTIVE_THRESH_MEAN_C, cv2.THRESH_BINARY_INV, 11, 2) # gray image에 threshold 처리

# threshold 이미지 노이즈 제거
kernel = np.ones((2,2), np.uint8)
threshold = cv2.morphologyEx(threshold, cv2.MORPH_OPEN, kernel)
# threshold = cv2.morphologyEx(threshold, cv2.MORPH_CLOSE, kernel)
# threshold = cv2.dilate(threshold, kernel, iterations = 1)
#

contours, hierarchy = cv2.findContours(threshold, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE) # contour 추출

# 트레일러 영역 표시
cv2.line(img_color, (int(track_nx), 0), (int(track_nx), height), (0, 255, 0), 2)
cv2.line(img_color, (int(track_px), 0), (int(track_px), height), (0, 255, 0), 2)

img_contour = np.zeros((height, width, 1), np.uint8)

for idx, cnt in enumerate(contours):
    size = len(cnt)
    shape = ""

    # 간소화된 contour
    epsilon = 0.087 * cv2.arcLength(cnt, True)
    approx = cv2.approxPolyDP(cnt, epsilon, True)
    app_size = len(approx)
    
    if app_size > 2: # 직선 제외
        if size>100: #and size<1500: # contour 사이즈 선택
            x,y,w,h = cv2.boundingRect(cnt) # contour에 사각형 boundary 형성

            if x>(track_nx) and (x+w)<(track_px): # boundary가 중간 영역 내부에 있는 경우만 선택
                img_color = cv2.rectangle(img_color, (x,y), (x+w,y+h), (0,0,255), 2)
                #print("Collect Group : ", size, x, y, w, h)
                #setLabel(img_color, f"{size}", cnt)
                setLabel(threshold, f"{size}", shape)

                #cv2.drawContours(img_color, contours, idx, (255, 0, 0), 1)
                leftmost = tuple(approx[approx[:,:,0].argmin()][0])
                rightmost = tuple(approx[approx[:,:,0].argmax()][0])
                topmost = tuple(approx[approx[:,:,1].argmin()][0])
                bottommost = tuple(approx[approx[:,:,1].argmax()][0])
                most_list = [leftmost, rightmost, topmost, bottommost] # 4방향 끝점

                if app_size == 3:
                    shape = "triangle"
                elif app_size == 4:
                    shape = "rectangle"
                    for idx in range(0, 4):
                        front = idx % 4
                        for rear in range(front+1, 4):
                            if most_list[front]==most_list[rear]:
                                shape = "triangle"
                else:
                    shape = "other"
                
                setLabel(img_color, app_size, shape)

                cv2.circle(img_color, leftmost, 5, (0,0,255), -1)
                cv2.circle(img_color, rightmost, 5, (0,255,0), -1)
                cv2.circle(img_color, topmost, 5, (255,0,0), -1)
                cv2.circle(img_color, bottommost, 5, (0,255,255), -1)
                #cv2.drawContours(img_color, approx, -1, (255, 0, 0), 10) # 간소화된 contour 표시
                cv2.drawContours(img_contour, cnt, -1, (255, 0, 0), 2)
###################################################

cv2.imshow("img_color", img_color)
cv2.imshow("img_blur", img_blur)
cv2.imshow("imgray", imgray)
cv2.imshow("threshold", threshold)
cv2.imshow("contours", img_contour)
cv2.waitKey(0)