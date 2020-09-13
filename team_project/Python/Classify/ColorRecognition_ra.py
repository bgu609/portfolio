import cv2
import numpy as np
import os
import serial
import math


# 카메라 사물 인식, 라즈베리파이 구동 버전 (python 3.5v)


def setLabel(image, app_size, shape): # 라벨링 함수
    (text_width, text_height), baseline = cv2.getTextSize("{0} {1}".format(app_size, shape), cv2.FONT_HERSHEY_SIMPLEX, 1, 2)
    cv2.rectangle(image, (x-5, y-5+baseline), (x-5+text_width, y-10-text_height), (200,200,200), cv2.FILLED) # 라벨 배경
    cv2.putText(image, "{0} {1}".format(app_size, shape), (x-5,y-5), cv2.FONT_HERSHEY_SIMPLEX, 1, (0, 0, 0), 2) # 라벨 텍스트


# 아두이노 연결
s_port = '/dev/ttyACM0'  # 포트 설정
brate = 9600  # 시리얼 통신 속도 설정
s_val = serial.Serial(s_port, brate)
print(s_val.name)


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
track_width = 100
track_height = 100
track_nx = (width - track_width)/2
track_px = (width + track_width)/2
track_ny = (height - track_height)/2
track_py = (height + track_height)/2
center_x = int(width/2)
center_y = int(height/2)
#

de_content = '0'
count = 0

avg_b = 0
avg_g = 0
avg_r = 0
avg_h = 0
classify = 0

while True:
    # if s_val.in_waiting != 0:
    #     content = s_val.readline()
    #     de_content = content.decode('utf-8').split('\r')[0]
    #     print(de_content, "type : {0}".format(type(de_content)))

    ret, img_color = cam.read() # 카메라로부터 이미지 획득
    #img_color = cv2.flip(img_color, 0) # 상하반전
    
    #img_color = cv2.fastNlMeansDenoisingColored(img_color, None, 10, 10, 7, 21) # 원본 노이즈 제거 (카메라 이용 시 이 부분에서 처리 시간이 너무 많이 걸림)
    #img_blur = cv2.GaussianBlur(img_color, (9, 9), cv2.BORDER_DEFAULT) # 가우시안 블러 (처리 시간은 해결됐지만 정확도가 떨어짐)
    img_hsv = cv2.cvtColor(img_color, cv2.COLOR_BGR2HSV)

    if img_hsv.item(center_y, center_x, 2) > 100:
        img_blur = cv2.medianBlur(img_color, 3) # 메디안 블러로 ( 엣지 정보 보존에 유리 ) (노이즈 제거 1)
        
        # 트레일러 영역 표시
        cv2.line(img_color, (int(track_nx), int(track_ny)), (int(track_nx), int(track_py)), (0, 255, 0), 2)
        cv2.line(img_color, (int(track_px), int(track_ny)), (int(track_px), int(track_py)), (0, 255, 0), 2)
        cv2.line(img_color, (int(track_nx), int(track_ny)), (int(track_px), int(track_ny)), (0, 255, 0), 2)
        cv2.line(img_color, (int(track_px), int(track_py)), (int(track_nx), int(track_py)), (0, 255, 0), 2)

        b = 0
        g = 0
        r = 0
        h = 0
        s = 0
        v = 0
        axis_count = 0

        for item_y in range(int(track_ny), int(track_py), 4):
            for item_x in range(int(track_nx), int(track_px), 4):
                b += img_blur.item(item_y, item_x, 0)
                g += img_blur.item(item_y, item_x, 1)
                r += img_blur.item(item_y, item_x, 2)
                h += img_hsv.item(item_y, item_x, 0)
                s += img_hsv.item(item_y, item_x, 1)
                v += img_hsv.item(item_y, item_x, 2)
                axis_count += 1

        b = int(b / axis_count)
        g = int(g / axis_count)
        r = int(r / axis_count)
        h = int(h / axis_count) *2 # 0~180 *2
        s = int(s / axis_count)
        v = int(v / axis_count)

        classify += 1
        print("rgb:({0:3d},{1:3d},{2:3d}) hsv:({3:3d},{4:3d},{5:3d}) count({6}) {7:3d}".format(r, g, b, h, s, v, axis_count, classify), end="\r")
        
        avg_b += b
        avg_g += g
        avg_r += r
        avg_h += h

        if classify >= 30:
            avg_b = int(avg_b / classify)
            avg_g = int(avg_g / classify)
            avg_r = int(avg_r / classify)
            avg_h = int(avg_h / classify)
            print("\nrgb:({0:3d},{1:3d},{2:3d}), h:{3:3d}".format(avg_r, avg_g, avg_b, avg_h))
            print("color classify working : {0}".format(classify))
            avg_b = 0
            avg_g = 0
            avg_r = 0
            avg_h = 0
            classify = 0

            sig = 'F'
            s_val.write(sig.encode("utf-8"))
    else:
        print("===[ Not Working ]===", end="\r")
        avg_b = 0
        avg_g = 0
        avg_r = 0
        avg_h = 0
        classify = 0

    cv2.namedWindow("img_color", cv2.WINDOW_NORMAL)
    cv2.imshow("img_color", img_color)
    # cv2.imshow("threshold", threshold)


    k = cv2.waitKey(10) & 0xff # Press 'ESC' for exiting video
    if k == 27:
        break

print("\n [INFO] Exiting Program and Cleanup stuff")
cam.release()
cv2.destroyAllWindows()