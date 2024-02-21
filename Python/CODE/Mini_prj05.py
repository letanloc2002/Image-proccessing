import cv2                      # thư viện xử lý ảnh
from PIL import Image           #thư viện hỗ trợ xử lý ảnh PILLOW hỗ trợ nhiều dạng ảnh
import numpy as np              #thư viện toán học
import matplotlib.pyplot as plt # thư viện vẽ biểu đồ


def ChuyenDoiAnhMauRGBSangAnhMucXamLuminance(imgPIL):
    luminance =  Image.new(imgPIL.mode,imgPIL.size)

    width=luminance.size[0]
    height=luminance.size[1]
    #đọc điểm ảnh dùng 2 vòng for để đọc tát cả các điểm ảnh
    for x in range(width):
        for y in range(height):
            #lấy giá trị điểm ảnh tại (x,y)
            R,G,B=imgPIL.getpixel((x,y))
    
            
            gray2=np.uint8(0.2126*R+0.7152*G+0.0722*B)
            
            #gán giá trị vừa tính cho ảnh xám
            luminance.putpixel((x,y),(gray2,gray2,gray2))
            
    return luminance


# tính histogram
def TinhHistogram(HinhXamPIL):
    #khai báo mảng có 256 phần tử
    his= np.zeros(256)
    # kích thước ảnh
    w=HinhXamPIL.size[0]
    h=HinhXamPIL.size[1]
    for x in range(w):
        for y in range(h):
            #lấy giá trị xám tại điểm (x,y):
            gR, gG, gB= HinhXamPIL.getpixel((x,y))
            #giá trị gray cũng chính là thứ tự phần tử thứ gray
            his[gR]+=1
    return his 

# vẽ biểu đồ histogram\

def VeBieuDoHistogram(his):
    w = 5
    h = 4
    plt.figure('biểu đồ histogram ảnh xám',figsize=(((w,h))),dpi=100)
    trucX=np.zeros(256)
    trucX=np.linspace(0,256,256)#(set trục X:linspace(min, max, khoảng cách))
    plt.plot(trucX,his,color='orange')
    plt.title('Biểu đồ histogram')
    plt.xlabel('giá trị mức xám')
    plt.ylabel('số điểm cùng mwucs gái trị xám')
    plt.show()

filehinh=r'bird_small.jpg'
img=cv2.imread(filehinh,cv2.IMREAD_COLOR)

#đọc ảnh màu dùng thư viện PIL. Ảnh PIL này ta sẽ dùng để
# thực hiện  các tác vụ xử lý  và tính toán  thay vì dùng OpenCV
imgPIL= Image.open(filehinh)


HinhXamPIL= ChuyenDoiAnhMauRGBSangAnhMucXamLuminance(imgPIL)

#tính histogram
his= TinhHistogram(HinhXamPIL)
#chuyển ảnh PIL sang OpenCV
HinhXamCV=np.array(HinhXamPIL)
cv2.imshow('Anh muc xam',HinhXamCV)
#vẽ biểu đồ
VeBieuDoHistogram(his)

cv2.waitKey(0)
cv2.destroyAllWindows()
