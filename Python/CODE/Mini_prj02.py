import cv2              # thư viện xử lý ảnh opencv
import numpy as np      # thư viện toán học
# đọc ảnh màu dùng thư viện opencv
img= cv2.imread('lena.png',cv2.IMREAD_COLOR)
#lấy kích thước ảnh
height,width,channel=img.shape
# khai báo 3 biến để chứa  hình 3 kênh RGB
red= np.zeros((height,width,3),np.uint8)
green= np.zeros((height,width,3),np.uint8)
blue= np.zeros((height,width,3),np.uint8)
# ban đầu set zẻro cho tất cả các điểm ảnh trong cả 3 kênh trong mỗi hình
red[:]=[0,0,0]
green[:]=[0,0,0]
blue[:]=[0,0,0]
# mỗi hình là 1 ma trận 2 chiều nên dùng 2 vòng for:
for x in range (width):
    for y in range (height):
        #lấy giá trị điểm ảnh tại (x,y)
        R= img [y,x,2]
        G= img [y,x,1]
        B= img [y,x,0]
        #thiết lập màu cho các kênh
        red[y,x,2]=R
        green[y,x,1]=G
        blue[y,x,0]=B

# hiển thị hình dùng opencv
#cv2.imshow('hinh goc',img)
#cv2.imshow('kenh red',red)
#cv2.imshow('kenh green',green)
#cv2.imshow('kenh blue',blue)
vert=np.concatenate((img,red),axis=0)
vert1=np.concatenate((blue,green),axis=0)
vert2=np.concatenate((vert,vert1),axis=1)
abc=cv2.resize(vert2,(600,600))
cv2.imshow('RGB',abc)
# bấm phím bất kỳ để thoát
cv2.waitKey(0)
#giải phóng bộ nhớ
cv2.destroyAllWindows()
