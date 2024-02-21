import cv2              # thư viện xử lý ảnh opencv
import numpy as np      # thư viện toán học
# đọc ảnh màu dùng thư viện opencv
img= cv2.imread('lena.png',cv2.IMREAD_COLOR)
#lấy kích thước ảnh
height,width,channel=img.shape
# khai báo 3 biến để chứa  hình 3 kênh RGB
cyan= np.zeros((height,width,3),np.uint8)
magenta= np.zeros((height,width,3),np.uint8)
yellow= np.zeros((height,width,3),np.uint8)
black= np.zeros((height,width,3),np.uint8)

# mỗi hình là 1 ma trận 2 chiều nên dùng 2 vòng for:
for x in range (width):
    for y in range (height):
        #lấy giá trị điểm ảnh tại (x,y)
        R= img [y,x,2]
        G= img [y,x,1]
        B= img [y,x,0]
        #thiết lập màu cho các kênh
        cyan[y,x,1]=G
        cyan[y,x,0]=B

        magenta[y,x,2]=R
        magenta[y,x,0]=B

        yellow[y,x,2]=R
        yellow[y,x,1]=G

        k=min(R,G,B)

        black[y,x,2]= k
        black[y,x,1]= k
        black[y,x,0]= k


# hiển thị hình dùng opencv
#cv2.imshow('hinh goc',img)
#cv2.imshow('kenh red',red)
#cv2.imshow('kenh green',green)
#cv2.imshow('kenh blue',blue)
vert=np.concatenate((black,cyan),axis=0)
vert1=np.concatenate((magenta,yellow),axis=0)
vert2=np.concatenate((vert,vert1),axis=1)
abc=cv2.resize(vert2,(500,500))
img1=cv2.resize(img,(400,400))
cv2.imshow('hinh goc',img1)
cv2.imshow('CMYK',abc)
# bấm phím bất kỳ để thoát
cv2.waitKey(0)
#giải phóng bộ nhớ
cv2.destroyAllWindows()
