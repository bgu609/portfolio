from PIL import Image
import os, glob, numpy as np
from sklearn.model_selection import train_test_split

if __name__ == "__main__":
    sample_folder = "samples"
    routes = glob.glob(sample_folder + "\\*")
    categories = list()

    for idx, category in enumerate(routes):
        name = category.split("\\")[1]
        categories.append(name)

    print(categories)
    nb_classes = len(categories)

    image_w = 64
    image_h = 64
    # pixels = image_h * image_w * 3

    X = []
    y = []

    for idx, name in enumerate(categories):
        label = [0 for i in range(nb_classes)] # Label 리스트를 카테고리 길이만큼 생성 후 0으로 초기화
        label[idx] = 1 # Label 리스트를 binary처럼 사용, 길이가 3인 경우 각각 [1,0,0] [0,1,0] [0,0,1] 생성

        category_route = routes[idx]
        print(f"{label} : {category_route}")

        file_route = category_route + "\\output" + "\\*"
        files = glob.glob(file_route) # 확장자 상관없이 모든 파일 목록을 불러왔음
        print(len(files))

        for i, file in enumerate(files):
            image = Image.open(file)
            image = image.resize((image_w, image_h))
            data = np.asarray(image)

            X.append(data)
            y.append(label)

    X = np.array(X)
    y = np.array(y)

    X_train, X_test, y_train, y_test = train_test_split(X, y)
    xy = (X_train, X_test, y_train, y_test)
    np.save("numpy_data\\multi_image_data.npy", xy)

    print("ok", len(y))

    # 아래는 예시
    # for idx, cat in enumerate(categories):
        
    #     #one-hot 돌리기.
    #     label = [0 for i in range(nb_classes)]
    #     label[idx] = 1

    #     image_dir = caltech_dir + "/" + cat
    #     files = glob.glob(image_dir+"/*.jpg")
    #     print(cat, " 파일 길이 : ", len(files))
    #     for i, f in enumerate(files):
    #         img = Image.open(f)
    #         img = img.convert("RGB")
    #         img = img.resize((image_w, image_h))
    #         data = np.asarray(img)

    #         X.append(data)
    #         y.append(label)

    #         if i % 700 == 0:
    #             print(cat, " : ", f)



    # X = np.array(X)
    # y = np.array(y)
    # #1 0 0 0 이면 airplanes
    # #0 1 0 0 이면 buddha 이런식


    # X_train, X_test, y_train, y_test = train_test_split(X, y)
    # xy = (X_train, X_test, y_train, y_test)
    # np.save("./numpy_data/multi_image_data.npy", xy)

    # print("ok", len(y))