import cv2      # thư viện xử lý ảnh
from PIL import Image      #thư viện hỗ trợ xử lý ảnh PILLOW hỗ trợ nhiều dạng ảnh
import numpy as np          #thư viện toán học
import math

#khia báo đường dẫn file
filehinh=r'D:\Python\lena_color1.jpg'
img=cv2.imread(filehinh,cv2.IMREAD_COLOR)

#đọc ảnh màu dùng thư viện PIL. Ảnh PIL này ta sẽ dùng để
# thực hiện  các tác vụ xử lý  và tính toán  thay vì dùng OpenCV
imgPIL= Image.open(filehinh)
 #tạo 1 ảnh có cùng kích thước  và mode  với ảnh imgPIL
 #ảnh này dùng để chứa  kết quả  chuyển đổi RGB sang grayscale
channel_Y =  Image.new(imgPIL.mode,imgPIL.size)
channel_Cb =  Image.new(imgPIL.mode,imgPIL.size)
channel_Cr =  Image.new(imgPIL.mode,imgPIL.size)
channel_YCbCr =  Image.new(imgPIL.mode,imgPIL.size)
# lấy kích thước của ảnh từ imgPIL
width=channel_Y.size[0]
height=channel_Y.size[1]
#đọc điểm ảnh dùng 2 vòng for để đọc tát cả các điểm ảnh

for x in range(width):
    for y in range(height):
        #lấy giá trị điểm ảnh tại (x,y)
        R,G,B=imgPIL.getpixel((x,y))
        #chuyển màu RGB thàng Gray bằng công thức average
        var_Y=16 + (65.738 / 256 * R) + (129.057 / 256) * G + (25.064 / 256) * B
        var_Cb= 128 - (37.945 / 256 * R) - (74.494 / 256) * G + (112.439 / 256) * B
        var_Cr= 128 + (112.439 / 256 * R) - (94.154 / 256) * G - (18.285 / 256) * B
        round_x=np.uint8(var_Y)
        round_y=np.uint8(var_Cb)
        round_z=np.uint8(var_Cr)
            
            #gán giá trị vừa tính cho ảnh xám
        channel_Y.putpixel((x,y),(round_x,round_x,round_x)) 
        channel_Cb.putpixel((x,y),(round_y,round_y,round_y))
        channel_Cr.putpixel((x,y),(round_z,round_z,round_z))
        channel_YCbCr.putpixel((x,y),(round_z,round_y,round_x))
        
#chuyển ảnh từ file PIL sang OpenCV để hiển thị 
anh1= np.array(channel_Y)
anh2= np.array(channel_Cb)
anh3= np.array(channel_Cr)
anh4= np.array(channel_YCbCr)

#hiển thị ảnh dùng thư viện OpenCV
Vert1 = np.concatenate((anh1, anh2), axis = 1)
Vert2 = np.concatenate((anh3, anh4), axis = 1)
vert3 =np.concatenate((Vert1,Vert2),axis=1)
abc=cv2.resize(vert3,(1000,250))
cv2.imshow('anh mau goc', abc)
#cv2.imshow('anh mau goc', img)
#cv2.imshow('anh xam tach bang phuong phap average', anhmucxam)
#cv2.imshow('anh xam tach bang phuong phap lightness', anhmucxam1)
#cv2.imshow('anh xam tach bang phuong phap luminance', anhmucxam2)
cv2.waitKey(0)
cv2.destroyAllWindows()
