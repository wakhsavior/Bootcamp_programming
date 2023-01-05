import cv2

face_cascades = cv2.CascadeClassifier(cv2.data.haarcascades + "haarcascade_frontalface_default.xml")

# img = cv2.imread('4.jpg')
# img_gray = cv2.cvtColor(img,cv2.COLOR_BGR2GRAY)

# faces = face_cascades.detectMultiScale(img_gray)

# for (x,y,w,h) in faces:
#     cv2.rectangle(img,(x,y),(x+w,y+h),(0,0,255),2)

# img = cv2.resize(img, (1000,500))
# cv2.imshow('Result',img)
# cv2.waitKey(0)

cap = cv2.VideoCapture(0)
while True:
    success, frame = cap.read()
    img_gray = cv2.cvtColor(frame,cv2.COLOR_BGR2GRAY)
    faces = face_cascades.detectMultiScale(img_gray)
    for (x,y,w,h) in faces:
       cv2.rectangle(frame,(x,y),(x+w,y+h),(255,0,0),2)
    cv2.imshow('camera',frame)
    if cv2.waitKey(1) & 0xff == ord('q'):
        break

