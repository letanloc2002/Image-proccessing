import cv2      # thư viện xử lý ảnh
from PIL import Image      #thư viện hỗ trợ xử lý ảnh PILLOW hỗ trợ nhiều dạng ảnh
import numpy as np          #thư viện toán học
import math
# đọc ảnh màu dùng thư viện opencv
filehinh=r'D:\Python\lena_color1.jpg'
img=cv2.imread(filehinh,cv2.IMREAD_COLOR)
#lấy kích thước ảnh
imgPIL= Image.open(filehinh)
# khai báo 3 biến để chứa  hình 3 kênh RGB
def smoothimg(point,level):
    smooth =  Image.new(imgPIL.mode,imgPIL.size)
    width=smooth.size[0]
    height=smooth.size[1]
        # mỗi hình là 1 ma trận 2 chiều nên dùng 2 vòng for:
    for x in range (point,width-point):
        for y in range (point,height-point):
            Rs=0
            Gs=0
            Bs=0
            for i in range (x-point,x+1+point):
                for j in range (y-point,y+1+point):
                    #lấy giá trị điểm ảnh tại (x,y)
                    R,G,B=imgPIL.getpixel((i,j))

                    Rs = Rs +R
                    Gs = Gs +G
                    Bs = Bs +B
            K=level*level
            Rs=np.uint16(Rs/K)
            Gs=np.uint16(Gs/K)
            Bs=np.uint16(Bs/K)
            smooth.putpixel((x,y),(Bs,Gs,Rs))
    return smooth

three= np.array(smoothimg(1,3))
five= np.array(smoothimg(2,5))
seven= np.array(smoothimg(3,7))
nine= np.array(smoothimg(4,9))

#five=smoothIMG(2,5)
#seven=smoothIMG(3,7)
#nine=smoothIMG(4,9)
                   
Vert1 = np.concatenate((three, five), axis = 1)
Vert2 = np.concatenate((seven, nine), axis = 1)
vert3 =np.concatenate((Vert1,Vert2),axis=1)
abc=cv2.resize(vert3,(1000,250))
img1=cv2.resize(img,(250,250))
# hiển thị hình dùng opencv
cv2.imshow('Hinh Goc',img1)
cv2.imshow('anh mau goc', abc)

# bấm phím bất kỳ để thoát
cv2.waitKey(0)
#giải phóng bộ nhớ
cv2.destroyAllWindows()
