
import cv2                      # thư viện xử lý ảnh
from PIL import Image           #thư viện hỗ trợ xử lý ảnh PILLOW hỗ trợ nhiều dạng ảnh
import numpy as np              #thư viện toán học
import matplotlib.pyplot as plt # thư viện vẽ biểu đồ

# tính histogram
def TinhHistogram(imgPIL):
    #khai báo mảng có 256 phần tử
    his= np.zeros((3,256))
    # kích thước ảnh
    w=imgPIL.size[0]
    h=imgPIL.size[1]
    for x in range(w):
        for y in range(h):
            #lấy giá trị xám tại điểm (x,y):
            gR, gG, gB= imgPIL.getpixel((x,y))

            #giá R-G-B cũng chính là giá trị thứ tự R-G-B
            his[0,gR]+=1
            his[1,gG]+=1
            his[2,gB]+=1
    return his 

# vẽ biểu đồ histogram\

def VeBieuDoHistogram(his):
    w = 5
    h = 4
    plt.figure('biểu đồ histogram ảnh xám',figsize=(((w,h))),dpi=100)
    trucX=np.zeros(256)
    trucX=np.linspace(0,256,256)#(set trục X:linspace(min, max, khoảng cách))
    plt.plot(trucX,his[0],color='red')
    plt.plot(trucX,his[1],color='green')
    plt.plot(trucX,his[2],color='blue')
    plt.title('Biểu đồ histogram')
    plt.xlabel('giá trị màu')
    plt.ylabel('số điểm cùng mức giá trị màu')
    plt.show()
filehinh=r'bird_small.jpg'
img=cv2.imread(filehinh,cv2.IMREAD_COLOR)
#đọc ảnh màu dùng thư viện PIL. Ảnh PIL này ta sẽ dùng để
# thực hiện  các tác vụ xử lý  và tính toán  thay vì dùng OpenCV 
imgPIL= Image.open(filehinh)
#tính histogram
his= TinhHistogram(imgPIL)
cv2.imshow('Anh muc xam',img)
#vẽ biểu đồ
VeBieuDoHistogram(his)
cv2.waitKey(0)
cv2.destroyAllWindows()
