import cv2      # thư viện xử lý ảnh
from PIL import Image      #thư viện hỗ trợ xử lý ảnh PILLOW hỗ trợ nhiều dạng ảnh
import numpy as np          #thư viện toán học

#khia báo đường dẫn file
filehinh=r'bird_small.jpg'
img=cv2.imread(filehinh,cv2.IMREAD_COLOR)

#đọc ảnh màu dùng thư viện PIL. Ảnh PIL này ta sẽ dùng để
# thực hiện  các tác vụ xử lý  và tính toán  thay vì dùng OpenCV
imgPIL= Image.open(filehinh)
 #tạo 1 ảnh có cùng kích thước  và mode  với ảnh imgPIL
 #ảnh này dùng để chứa  kết quả  chuyển đổi RGB sang grayscale
average =  Image.new(imgPIL.mode,imgPIL.size)
lightness =  Image.new(imgPIL.mode,imgPIL.size)
luminance =  Image.new(imgPIL.mode,imgPIL.size)
binary =  Image.new(imgPIL.mode,imgPIL.size)
# lấy kích thước của ảnh từ imgPIL
width=average.size[0]
height=average.size[1]
#đọc điểm ảnh dùng 2 vòng for để đọc tát cả các điểm ảnh
for x in range(width):
    for y in range(height):
        #lấy giá trị điểm ảnh tại (x,y)
        R,G,B=imgPIL.getpixel((x,y))
        #chuyển màu RGB thàng Gray bằng công thức average
        gray= np.uint8((R+G+B)/3)
        
        #gán giá trị vừa tính cho ảnh xám
        average.putpixel((x,y),(gray,gray,gray))
         #chuyển màu RGB thàng Gray bằng công thức average
        MIN=min(R,G,B)
        MAX=max(R,G,B)
        gray1=np.uint8((MIN+MAX)/2)
        
        #gán giá trị vừa tính cho ảnh xám
        lightness.putpixel((x,y),(gray1,gray1,gray1))
        #chuyển màu RGB thàng Gray bằng công thức average
        
        gray2=np.uint8(0.2126*R+0.7152*G+0.0722*B)
        
        #gán giá trị vừa tính cho ảnh xám
        luminance.putpixel((x,y),(gray2,gray2,gray2))
        # lấy giá trị ảnh binary
        
        if gray2 < 100:
            nhiphan=0
        else:
            nhiphan=255
        #gán
        binary.putpixel((x,y),(nhiphan,nhiphan,nhiphan))
       
       
#chuyển ảnh từ file PIL sang OpenCV để hiển thị 
anhmucxam= np.array(average)
anhmucxam1= np.array(lightness)
anhmucxam2= np.array(luminance)
anhmucxam3= np.array(binary)

#hiển thị ảnh dùng thư viện OpenCV
Vert1 = np.concatenate((img, anhmucxam), axis = 0)
Vert2 = np.concatenate((anhmucxam1, anhmucxam2), axis = 0)
vert3 =np.concatenate((Vert1,Vert2),axis=1)
cv2.imshow('anh mau goc', vert3)
#cv2.imshow('anh mau goc', anhmucxam3)
#cv2.imshow('anh xam tach bang phuong phap average', anhmucxam)
cv2.imshow('anh xam tach bang phuong phap lightness', anhmucxam3)
#cv2.imshow('anh xam tach bang phuong phap luminance', anhmucxam2)
cv2.waitKey(0)
cv2.destroyAllWindows()
