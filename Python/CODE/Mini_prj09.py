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
channel_X =  Image.new(imgPIL.mode,imgPIL.size)
channel_Y =  Image.new(imgPIL.mode,imgPIL.size)
channel_Z =  Image.new(imgPIL.mode,imgPIL.size)
channel_XYZ =  Image.new(imgPIL.mode,imgPIL.size)
# lấy kích thước của ảnh từ imgPIL
width=channel_X.size[0]
height=channel_X.size[1]
#đọc điểm ảnh dùng 2 vòng for để đọc tát cả các điểm ảnh

for x in range(width):
    for y in range(height):
        #lấy giá trị điểm ảnh tại (x,y)
        R,G,B=imgPIL.getpixel((x,y))
        #chuyển màu RGB thàng Gray bằng công thức average
        var_x=0.4124564*R+0.3575761*G+0.1804375*B
        var_y=0.2126729*R+0.7151522*G+0.0721750*B
        var_z=0.0193339*R+0.1191920*G+0.9503041*B
        round_x=np.uint8(var_x)
        round_y=np.uint8(var_y)
        round_z=np.uint8(var_z)
            
            #gán giá trị vừa tính cho ảnh xám
        channel_X.putpixel((x,y),(round_x,round_x,round_x))
        channel_Y.putpixel((x,y),(round_y,round_y,round_y))
        channel_Z.putpixel((x,y),(round_z,round_z,round_z))
        channel_XYZ.putpixel((x,y),(round_z,round_y,round_x))
        
#chuyển ảnh từ file PIL sang OpenCV để hiển thị 
anh1= np.array(channel_X)
anh2= np.array(channel_Y)
anh3= np.array(channel_Z)
anh4= np.array(channel_XYZ)

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
