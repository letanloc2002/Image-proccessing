import cv2                      # thư viện xử lý ảnh
from PIL import Image           #thư viện hỗ trợ xử lý ảnh PILLOW hỗ trợ nhiều dạng ảnh
import numpy as np              #thư viện toán học
import matplotlib.pyplot as plt # thư viện vẽ biểu đồ

filehinh=r'bird_small.jpg'
img=cv2.imread(filehinh,cv2.IMREAD_COLOR)
#đọc ảnh màu dùng thư viện PIL. Ảnh PIL này ta sẽ dùng để
# thực hiện  các tác vụ xử lý  và tính toán  thay vì dùng OpenCV
imgPIL= Image.open(filehinh)

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

#Phan doan anh dung Multi Thresolding
def Otsu_Multi_Thresold(imgPILGray):
    #Tinh histogram
    his = TinhHistogram(imgPILGray)

    #Lay kich thuoc cua anh tu imgPILGray
    width = imgPILGray.size[0]
    height = imgPILGray.size[1]
    size = width*height

    #Tao bien de luu nguong
    best_thresold = np.zeros(2)
    best_variance = 0

    #Compute the normalized histogram of the input image
    p = his/size

    #Tim gia tri nguong toi uu nhat
    for k1 in range(256):
        for k2 in range(k1, 256):
            #Compute the cumulative sums P1, P2, P3
            P1 = sum(p[:k1])
            P2 = sum(p[k1:k2]) #k1 --> k2 - 1
            P3 = sum(p[k2:])

            #Compute the cumulative means
            if P1 == 0 or P2 == 0 or P3 == 0:
                continue
            m1 = sum(i*p[i] for i in range(k1))/P1
            m2 = sum(i*p[i] for i in range(k1,k2))/P2
            m3 = sum(i*p[i] for i in range(k2,256))/P3

            #Compute the global intensity mean
            mG = sum(i*p[i] for i in range(256))

            #Compute the global varience
            Variance_G = sum(p[i]*(i - mG)**2 for i in range(256))

            #Variance_B
            Variance_B = P1*(m1 - mG)**2 + P2*(m2 - mG)**2 + P3*(m3 - mG)**2

            #The separability measure
            n = Variance_B/Variance_G

            if Variance_B > best_variance and n > 0.85:
                best_variance = Variance_B
                best_thresold[0] = k1
                best_thresold[1] = k2
                print(n)

    return best_thresold
def PhanDoanAnh(imgPIL, thresold1, thresold2):
    #Tao mot anh co kich thuoc bang anh can phan doan
    AnhDaPhanDoan = Image.new(imgPIL.mode, imgPIL.size)

    #Phan doan
    #Lay kich thuoc cua anh tu imgPIL
    width = imgPIL.size[0]
    height = imgPIL.size[1]

    #Moi anh la mot ma tran 2 chieu nen dung 2 vong for de doc
    #het cac diem anh
    for x in range(width):
        for y in range(height):
            #Lay gia tri cac diem anh tai vi tri (x,y)
            R, G, B = imgPIL.getpixel((x,y))

            #Tinh intensity
            #dung phuong phap luminance
            gray_luminance = np.uint8(0.2126*R + 0.7152*G + 0.0722*B)

            #Phan vung
            if gray_luminance > thresold2:
                R = 0
                G = 0
                B = 0

            if gray_luminance < thresold1:
                R = 255
                G = 255
                B = 255
            if gray_luminance < thresold2 and  gray_luminance > thresold1:
                R = 0
                G = 155
                B = 155
            
            #Gan gia tri muc xam vua tinh cho anh xam
            AnhDaPhanDoan.putpixel((x,y), (B, G, R))

    return AnhDaPhanDoan



HinhXamPIL= ChuyenDoiAnhMauRGBSangAnhMucXamLuminance(imgPIL)
thresold1, thresold2=Otsu_Multi_Thresold(HinhXamPIL)
print(thresold1, thresold2)
AnhphandoanPIL = PhanDoanAnh(HinhXamPIL,thresold1,thresold2)
#tính histogram
his= TinhHistogram(HinhXamPIL)
#chuyển ảnh PIL sang OpenCV
HinhXamCV=np.array(HinhXamPIL)
AnhphandoanCV=np.array(AnhphandoanPIL)
cv2.imshow('Anh muc xam',HinhXamCV)
cv2.imshow('Anh phandoan',AnhphandoanCV)
#vẽ biểu đồ
VeBieuDoHistogram(his)
cv2.waitKey(0)
cv2.destroyAllWindows()