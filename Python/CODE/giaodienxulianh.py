from tkinter import Tk, Button, Label, Entry, Frame
from tkinter.filedialog import askopenfilename
from PIL import ImageTk, Image

def open_image():
    # Mở hộp thoại lựa chọn tệp
    filepath = askopenfilename(filetypes=[("Image Files", "*.png;*.jpg;*.jpeg")])
    
    if filepath:
        # Hiển thị đường dẫn của hình ảnh được chọn
        path_entry.delete(0, "end")
        path_entry.insert(0, filepath)
        
        # Load hình ảnh từ đường dẫn
        image = Image.open(filepath)
        
        # Thay đổi kích thước hình ảnh (tùy chọn)
        image = image.resize((300, 300))
        
        # Tạo đối tượng ImageTk từ hình ảnh
        img_tk = ImageTk.PhotoImage(image)
        
        # Hiển thị hình ảnh trên giao diện
        image_label.config(image=img_tk)
        image_label.image = img_tk
#def Detect_image():

# Tạo cửa sổ giao diện
window = Tk()
# Đặt kích thước cửa sổ
window.geometry("1000x600")  # Đặt kích thước là 500x400 pixel

# Tạo khung (frame) để chứa hình ảnh
frame = Frame(window, width=310, height=310, borderwidth=2, relief="solid")
frame.pack_propagate(False)  # Ngăn khung co giãn
frame.place(x=20, y=30)

# Tạo khung (frame1) để chứa kết quả
frame1 = Frame(window, width=310, height=310, borderwidth=2, relief="solid")
frame1.pack_propagate(False)  # Ngăn khung co giãn
frame1.place(x=670, y=30)

# Tạo nút "Open Image" và gắn với hàm open_image()
button = Button(window, text="Open Image", command=open_image)
button.pack()
button.place(x=150, y=350)
# Tạo ô hiển thị đường dẫn của hình ảnh
path_entry = Entry(window, width=50)
path_entry.pack()
path_entry.place(x=20, y=10)
# Tạo nhãn để hiển thị hình ảnh
image_label = Label(frame)
image_label.pack()

# Tạo nút "Detect" và gắn với hàm open_image()
button = Button(window, text="Detect Image", width=20, height=3) # cho thêm command là hàm của AI
button.pack()
button.place(x=400, y=150)
# Chạy vòng lặp chính của giao diện
window.mainloop()
