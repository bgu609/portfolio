import Augmentor
import glob

def amplify(route, num):
    p = Augmentor.Pipeline(route)

    p.rotate(probability=0.7, max_left_rotation=10, max_right_rotation=10)
    p.zoom(probability=0.5, min_factor=1.1, max_factor=1.5)
    p.sample(num*100)
    p.process()

if __name__ == "__main__":
    
    route = "samples"
    category_route = glob.glob(route + "\\*")
    print(category_route)
    
    for idx, category in enumerate(category_route):
        name = category.split("\\")[1]
        print(name)
        
        source = glob.glob(category + "\\*")
        print(len(source))

        amplify(category, len(source)) # 샘플 종류*100 증폭