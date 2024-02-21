import cv2      # thư viện xử lý ảnh
from PIL import Image      #thư viện hỗ trợ xử lý ảnh PILLOW hỗ trợ nhiều dạng ảnh
import numpy as np          #thư viện toán học

# đọc ảnh màu dùng thư viện opencv
filehinh=r'D:\Python\lena_color1.jpg'
img=cv2.imread(filehinh,cv2.IMREAD_COLOR)
#chuyển hình sang thư viện pil
imgPIL= Image.open(filehinh)

#tạo ra biến chưa ảnh xám
imggray =  Image.new(imgPIL.mode,imgPIL.size)
imgboder =  Image.new(imgPIL.mode,imgPIL.size)
#tạo ra ma trận sobel
matrix_X=np.array([[-1,-2,-1],[0,0,0],[1,2,1]])
matrix_Y=np.array([[-1,0,1],[-2,0,2],[-1,0,1]])
#lấy kích thức
width=imgPIL.size[0]
height=imgPIL.size[1]
nguong=int(input('Nhập giá trị ngưỡng:'))
for x in range(width):
    for y in range(height):
        #lấy giá trị điểm ảnh tại (x,y)
        R,G,B=imgPIL.getpixel((x,y))
        #chuyển màu RGB thàng Gray bằng công thức average
        gray= np.uint8((R+G+B)/3)
        
        #gán giá trị vừa tính cho ảnh xám
        imggray.putpixel((x,y),(gray,gray,gray))      

for x in range (1,width-1):
    for y in range (1,height-1):
        GxR=0
        GyR=0
        GxG=0
        GyG=0
        GxB=0
        GyB=0
        point=0
        R,G,B=imgPIL.getpixel((x,y))    
        for i in range(x-1,x+2):
            for j in range(y-1,y+2):

                R,G,B=imggray.getpixel((i,j))

                GxR += R*matrix_X[i-x+1,j-y+1]
                GyR += R*matrix_Y[i-x+1,j-y+1]
                GxG += G*matrix_X[i-x+1,j-y+1]
                GyG += G*matrix_Y[i-x+1,j-y+1]
                GxB += B*matrix_X[i-x+1,j-y+1]
                GyB += B*matrix_Y[i-x+1,j-y+1]
        Gxx = np.abs(GxR)* np.abs(GxR) + np.abs(GxG)* np.abs(GxG)+ np.abs(GxB) * np.abs(GxB)
        Gyy = np.abs(GyR)* np.abs(GyR) + np.abs(GyG)* np.abs(GyG)+ np.abs(GyB) * np.abs(GyB)
        Gxy = np.abs(GxR)* np.abs(GyR) + np.abs(GxG)* np.abs(GyG)+ np.abs(GxB) * np.abs(GyB)
        theta = 0.5 * np.arctan2((2 * Gxy), (Gxx - Gyy))
        F0 = np.sqrt(0.5 * ((Gxx + Gyy) + (Gxx - Gyy) * np.cos(2 * theta) + 2 * Gxy * np.sin(2 * theta)))

        if(F0<=nguong):
            point=0
        else:
            point=255        

        imgboder.putpixel((x,y),(point,point,point))
anh1= np.array(imgboder)
cv2.imshow('Hinh Goc', img)
cv2.imshow('Anh net',anh1)
# bấm phím bất kỳ để thoát
cv2.waitKey(0)
#giải phóng bộ nhớ
cv2.destroyAllWindows()