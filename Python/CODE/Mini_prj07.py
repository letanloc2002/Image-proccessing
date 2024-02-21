import cv2      # thư viện xử lý ảnh
from PIL import Image      #thư viện hỗ trợ xử lý ảnh PILLOW hỗ trợ nhiều dạng ảnh
import numpy as np          #thư viện toán học
import math

#khai báo đường dẫn file
filehinh=r'D:\Python\lena_color1.jpg'
img=cv2.imread(filehinh,cv2.IMREAD_COLOR)

#đọc ảnh màu dùng thư viện PIL. Ảnh PIL này ta sẽ dùng để
# thực hiện  các tác vụ xử lý  và tính toán  thay vì dùng OpenCV
imgPIL= Image.open(filehinh)
 #tạo 1 ảnh có cùng kích thước  và mode  với ảnh imgPIL
 #ảnh này dùng để chứa  kết quả  chuyển đổi RGB sang grayscale
hue =  Image.new(imgPIL.mode,imgPIL.size)
saturation =  Image.new(imgPIL.mode,imgPIL.size)
intensity =  Image.new(imgPIL.mode,imgPIL.size)
hsi =  Image.new(imgPIL.mode,imgPIL.size)
# lấy kích thước của ảnh từ imgPIL
width=hue.size[0]
height=hue.size[1]
#đọc điểm ảnh dùng 2 vòng for để đọc tát cả các điểm ảnh

for x in range(width):
    for y in range(height):
        #lấy giá trị điểm ảnh tại (x,y)
        R,G,B=imgPIL.getpixel((x,y))
        #chuyển hệ màu RGB sang HSI
        t1 = ((R - G) + (R - B)) / 2
        t2 = math.sqrt((R - G) * (R - G) + (R - B) * (R - B))
        theta = math.acos(t1 / t2)
        if B <= G :

            H = theta
        else:
            H = 2 * math.pi - theta
        H = H * 180 / math.pi
        S = (1 - 3 * min(R,G,B)/(R+G+B))*255
        I = (R + G + B) / 3
        
        # đặt lại kiểu dữ liệu là int
        round_H=np.uint8(H)
        round_S=np.uint8(S)
        round_I=np.uint8(I)
            
        #gán giá trị vừa tính cho ảnh xám
        hue.putpixel((x,y),(round_H,round_H,round_H))
        saturation.putpixel((x,y),(round_S,round_S,round_S))
        intensity.putpixel((x,y),(round_I,round_I,round_I))
        hsi.putpixel((x,y),(round_I,round_S,round_H))
        
#chuyển ảnh từ file PIL sang OpenCV để hiển thị 
anh1= np.array(hue)
anh2= np.array(saturation)
anh3= np.array(intensity)
anh4= np.array(hsi)

#hiển thị ảnh dùng thư viện OpenCV
Vert1 = np.concatenate((anh1, anh2), axis = 1)
Vert2 = np.concatenate((anh3, anh4), axis = 1)
vert3 =np.concatenate((Vert1,Vert2),axis=1)
abc=cv2.resize(vert3,(1000,250))
cv2.imshow('anh mau HSI', abc)
#cv2.imshow('anh mau goc', img)
#cv2.imshow('anh xam tach bang phuong phap average', anhmucxam)
#cv2.imshow('anh xam tach bang phuong phap lightness', anhmucxam1)
#cv2.imshow('anh xam tach bang phuong phap luminance', anhmucxam2)
cv2.waitKey(0)
cv2.destroyAllWindows()
