import cv2      # thư viện xử lý ảnh
from PIL import Image      #thư viện hỗ trợ xử lý ảnh PILLOW hỗ trợ nhiều dạng ảnh
import numpy as np          #thư viện toán học
import math

# đọc ảnh màu dùng thư viện opencv
filehinh=r'D:\Python\lena_color1.jpg'
img=cv2.imread(filehinh,cv2.IMREAD_COLOR)
#chuyển hình sang thư viện pil
imgPIL= Image.open(filehinh)

#tạo ra biến chưa ảnh xám
imggray =  Image.new(imgPIL.mode,imgPIL.size)
imgboder =  Image.new(imgPIL.mode,imgPIL.size)
nguong=int(input('Nhập giá trị ngưỡng:'))

def detectline(nguong):
    
    #tạo ra ma trận sobel
    matrix_X=np.array([[-1,-2,-1],[0,0,0],[1,2,1]])
    matrix_Y=np.array([[-1,0,1],[-2,0,2],[-1,0,1]])
    #lấy kích thức
    width=imgPIL.size[0]
    height=imgPIL.size[1]

    #dùng vòng FOR để quét và lấy giá trị điểm ảnh
    for x in range(width):
        for y in range(height):
            #lấy giá trị điểm ảnh tại (x,y)
            R,G,B=imgPIL.getpixel((x,y))
            #chuyển màu RGB thàng Gray bằng công thức average
            gray= np.uint8((R+G+B)/3)
            
            #gán giá trị vừa tính cho ảnh xám
            imggray.putpixel((x,y),(gray,gray,gray))      
    #dùng vòng FOR để quét và lấy giá trị màu của điểm ảnh, bỏ viền ngoài vì là mặt nạ 3x3
    for x in range (1,width-1):
        for y in range (1,height-1):
            Gx=0
            Gy=0
            gray=0
            #quét mặt nạ    
            for i in range(x-1,x+2):
                for j in range(y-1,y+2):

                    R,G,B=imggray.getpixel((i,j))

                    Gx += R*matrix_X[i-x+1,j-y+1]
                    Gy += R*matrix_Y[i-x+1,j-y+1]
            #xét với ngưỡng nhập vào, nếu M<= ngưỡng thì điểm ảnh bằng 0, ngược lại bằng 255
            M= abs(Gx)+abs(Gy)
            if(M<=nguong):
                gray=0
            else:
                gray=255
            imgboder.putpixel((x,y),(gray,gray,gray))
    return imgboder

#chuyển về thư viện np để tính toán
anh1= np.array(detectline(nguong))
anh2= np.array(imggray)
cv2.imshow('Hinh Goc', anh2)
cv2.imshow('Anh net',anh1)
# bấm phím bất kỳ để thoát
cv2.waitKey(0)
#giải phóng bộ nhớ
cv2.destroyAllWindows()