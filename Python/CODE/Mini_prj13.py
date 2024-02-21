import cv2      # thư viện xử lý ảnh
from PIL import Image      #thư viện hỗ trợ xử lý ảnh PILLOW hỗ trợ nhiều dạng ảnh
import numpy as np          #thư viện toán học

# đọc ảnh màu dùng thư viện opencv
filehinh=r'bird_small.jpg'
img=cv2.imread(filehinh,cv2.IMREAD_COLOR)
#lấy kích thước ảnh
imgPIL= Image.open(filehinh)
SegImg =  Image.new(imgPIL.mode,imgPIL.size)
width=SegImg.size[0]
height=SegImg.size[1]

x1=int(input('Nhập giá trị X1:'))
x2=int(input('Nhập giá trị X2:'))
y1=int(input('Nhập giá trị Y1:'))
y2=int(input('Nhập giá trị Y2:'))
nguong=int(input('Nhập giá trị ngưỡng:'))

Rs=0
Gs=0
Bs=0

for x in range (x1,x2+1):
    for y in range (y1,y2+1):
        R,G,B=imgPIL.getpixel((x,y))
        Rs+=R
        Gs+=G
        Bs+=B
    #vùng ảnh
size=np.abs(x2-x1)*np.abs(y2-y1)
Rs/=size
Gs/=size
Bs/=size
for x in  range(width):
    for y in range(height):
        R1,G1,B1=imgPIL.getpixel((x,y))
        #áp dụng công thức Euclidean Distance
        D=np.sqrt((R1-Rs)*(R1-Rs)+(G1-Gs)*(G1-Gs)+(B1-Bs)*(B1-Bs))

        #so sánh với giá trị ngưỡng
        if D < nguong:
            B1=255
            G1=255
            R1=255
        
        SegImg.putpixel((x,y),(np.uint8(B1),np.uint8(G1),np.uint8(R1)))
anh1=np.array(SegImg)
cv2.imshow('Hinh Goc', img)
cv2.imshow('Anh net',anh1)
# bấm phím bất kỳ để thoát
cv2.waitKey(0)
#giải phóng bộ nhớ
cv2.destroyAllWindows()
