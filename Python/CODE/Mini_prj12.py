import cv2      # thư viện xử lý ảnh
from PIL import Image      #thư viện hỗ trợ xử lý ảnh PILLOW hỗ trợ nhiều dạng ảnh
import numpy as np          #thư viện toán học

# đọc ảnh màu dùng thư viện opencv
filehinh=r'D:\Python\bird_small.jpg'
img=cv2.imread(filehinh,cv2.IMREAD_COLOR)
#lấy kích thước ảnh
imgPIL= Image.open(filehinh)

sharpe =  Image.new(imgPIL.mode,imgPIL.size)

matrix=np.array([[0,-1,0],[-1,4,-1],[0,-1,0]])

width=sharpe.size[0]
height=sharpe.size[1]

for x in range (1,width-1):
    for y in range (1,height-1):
        Rs=0
        Gs=0
        Bs=0    
        for i in range(x-1,x+2):
            for j in range(y-1,y+2):

                R,G,B=imgPIL.getpixel((i,j))

                Rs += R*matrix[i-x+1,j-y+1]
                Gs += G*matrix[i-x+1,j-y+1]
                Bs += B*matrix[i-x+1,j-y+1]
        R1,G1,B1=imgPIL.getpixel((x,y))
        sharpeR=R1+Rs
        sharpeG=G1+Gs
        sharpeB=B1+Bs

        if(sharpeR<0):
            sharpeR=0
        elif(sharpeR>255):
            sharpeR=255

        if(sharpeG<0):
            sharpeG=0
        elif(sharpeG>255):
            sharpeG=255
        
        if(sharpeB<0):
            sharpeB=0
        elif(sharpeB>255):
            sharpeB=255

        sharpe.putpixel((x,y),(sharpeB,sharpeG,sharpeR))
anh1= np.array(sharpe)
cv2.imshow('Hinh Goc', img)
cv2.imshow('Anh net',anh1)
# bấm phím bất kỳ để thoát
cv2.waitKey(0)
#giải phóng bộ nhớ
cv2.destroyAllWindows()