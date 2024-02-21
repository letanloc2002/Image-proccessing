import cv2 #Xu li anh
from PIL import Image #Thu vien xu li anh ho tro nhieu loai anh
import numpy as np
import math

def structuring_element(radius):
    #Create a square array with side length 2 * radius + 1
    size = 2*radius + 1
    center = radius
    struct_elem = np.zeros((size, size), dtype=np.uint8)
    list_str = []
    index = 0

    #Set pixels within the radius of the center to 1
    for i in range(size):
        for j in range(size):
            a = i - center
            b = j - center
            if a*a + b*b <= radius*radius:
                struct_elem[i, j] = 1
                index = index + 1 
    list_str = [struct_elem, index]
    print(list_str)
    return list_str

def erotion(imgPIL, radius):
    #Create new image
    erotion_img = Image.new(imgPIL.mode, imgPIL.size)
    #Take image size
    width_img = erotion_img.size[0]
    height_img = erotion_img.size[1]
    list_str = structuring_element(radius)
    index = list_str[1]
    #Iterate over each pixel in the input image
    for width in range(radius, width_img - radius): #maximum is 511 - radius(2) = 509
        for height in range(radius, height_img - radius):
            #Create a maskmatrix
            Rs = 0
            count = 0
            for i in range(width - radius, width + radius + 1): #509 - 2 + 1 + 2
                for j in range(height - radius, height + radius + 1):
                    a = list_str[0]
                    mask = a
                    #Get information R-G-B at the pixel point in mask at postion [i, j]
                    r, g, b = np.uint8(imgPIL.getpixel((i,j))) #.getpixel returns int value
                    Rs = r * mask[i -  (width - radius), j - (height - radius)]
                    #Erosion algorithm
                    if(Rs == 255):
                        count = count + 1
                        if(count == index):
                            erotion_img.putpixel((width, height), (255, 255, 255))
    return erotion_img

def dilation(imgPIL, radius):
    #Create new image
    dilation_img = Image.new(imgPIL.mode, imgPIL.size)
    #Take image size
    width_img = dilation_img.size[0]
    height_img = dilation_img.size[1]
    list_str = structuring_element(radius)

    # Iterate over each pixel in the input image
    for width in range(radius, width_img - radius):
        for height in range(radius, height_img - radius):
            #Create a maskmatrix
            Rs = 0
            for i in range(width - radius, width + radius + 1):
                for j in range(height - radius, height + radius + 1):
                    a = list_str[0]
                    mask = a
                    #Get information R-G-B at the pixel point in mask at postion [i, j]
                    r, g, b = np.uint8(imgPIL.getpixel((i,j))) #.getpixel returns int value
                    Rs = r * mask[i -  (width - radius), j - (height - radius)]
                    #Dilation algorithm
                    if(Rs == 2550):
                        dilation_img.putpixel((width, height), (Rs, Rs, Rs))          
    return dilation_img

def opening(imgPIL, radius):
    opening_img = dilation(erotion(imgPIL, radius), radius)
    return opening_img

def closing(imgPIL, radius):
    opening_img = erotion(dilation(imgPIL, radius), radius)
    return opening_img

def NhanDangDuongBien(imgPIL, nguong):
    #Tao tam anh luu ket qua
    AnhDaNhanDangDuongBien = Image.new(imgPIL.mode, imgPIL.size)

    #Lay kich thuoc anh goc
    width = imgPIL.size[0]
    height = imgPIL.size[1]

    Sober_X = np.array([[-1, -2, -1], [ 0, 0, 0 ],[ 1, 2, 1 ]])
    Sober_Y = np.array([[-1, 0, 1 ], [ -2, 0, 2 ],[ -1, 0, 1 ]])
    
    #Quet diem anh
    for y in range(1, height - 1):
        for x in range(1, width - 1):

            Gradient = np.array([0 , 0])
            for j in range(-1, 2):
                for i in range(-1, 2):
                    #Lay gia tri cac diem anh tai vi tri (x,y)
                    r,g,b = imgPIL.getpixel((x + i,y + j))
                    #Tinh gia tri muc xam theo phuong phap luminance
                    gray = np.uint8(0.2126*r + 0.7152*g + 0.0722*b) 

                    #Tinh gradient
                    Gradient[0] += gray * Sober_X[i + 1, j + 1]
                    Gradient[1] += gray * Sober_Y[i + 1, j + 1]

                    #Tinh M(x,y)
                    M_xy = math.fabs(Gradient[0]) + math.fabs(Gradient[1])

                    #So sanh voi gia tri nguong
                    if (M_xy <= nguong):
                        AnhDaNhanDangDuongBien.putpixel((x, y), (0, 0, 0))
                    else:
                        AnhDaNhanDangDuongBien.putpixel((x, y), (255, 255, 255))
    AnhDaNhanDangDuongBien_CV = np.array(AnhDaNhanDangDuongBien)
    return AnhDaNhanDangDuongBien_CV

#Chuong trinh chinh
#Khai bao duong dan file hinh
filehinh = r'lena_color.jpg'

#Doc anh mau bang thu vien PIL
#Thuc hien cac tac vu xu li tren PIL
imgPIL = Image.open(filehinh)

img_NhanDangDuongBien = NhanDangDuongBien(imgPIL,100)
duongbien = Image.fromarray(img_NhanDangDuongBien)


# Dilate the image using the circle structuring element
dilated_image = np.array(dilation(duongbien, 1))
eroded_image = np.array(erotion(duongbien, 1))
opening_image = np.array(opening(duongbien, 1))
closing_image = np.array(closing(duongbien, 1))

#Đọc ảnh màu dùng thư viện OpenCV
img = cv2.imread(filehinh, cv2.IMREAD_COLOR)
imgCV = np.array(duongbien)

#Show original image
cv2.imshow('Anh goc', img)
cv2.imshow('Anh nhan dang duong bien', imgCV)
cv2.imshow('Dilated Image', dilated_image)
cv2.imshow('Eroded Image', eroded_image)
cv2.imshow('Opening Image', opening_image)
cv2.imshow('Closing Image', closing_image)

#Bam phim bat ki de dong cua so
cv2.waitKey(0)

#Giai phong bo nho
cv2.destroyAllWindows()