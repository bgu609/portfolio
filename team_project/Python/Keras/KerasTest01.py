from PIL import Image
import os, glob, numpy as np
from keras.models import load_model

caltech_dir = "test"
image_w = 64
image_h = 64

pixels = image_h * image_w * 3

X = []
filenames = []
files = glob.glob(caltech_dir+"\\*.*")
for i, f in enumerate(files):
    img = Image.open(f)
    img = img.resize((image_w, image_h))
    data = np.asarray(img)
    filenames.append(f)
    X.append(data)

X = np.array(X)
model = load_model('model\\multi_img_classification.model')

prediction = model.predict(X)
np.set_printoptions(formatter={'float': lambda x: "{0:0.3f}".format(x)})
cnt = 0

route = "samples"
category_route = glob.glob(route + "\\*")
categories = list()

for idx, category in enumerate(category_route):
    name = category.split("\\")[1]
    categories.append(name)
print(categories)

for i in prediction:
    max_idx = i.argmax()  # 예측 레이블
    print(i, " ", max_idx)
    print("해당 "+filenames[cnt].split("\\")[1]+"이미지는 "+categories[max_idx]+"로 추정됩니다.")
    cnt += 1