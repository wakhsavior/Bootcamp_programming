from turtle import *
from random import randint
import time

finish = 200
colormode(255)

t1 = Turtle()   # Создали объект класса черепахи
t1.shape("turtle")   # Определили форму черепашки
t1.color("red")     # Определили цвет черепашки
t1.penup()  # Поднимаем черепашку чтобы не рисовала
t1.goto(-200, 20)     # перемещаем черепашку
t1.pendown()          # Опускаю чтобы могла рисовать
t1.speed(3)

t2 = Turtle()   # Создали объект класса черепахи
t2.shape("turtle")   # Определили форму черепашки
t2.color("blue")     # Определили цвет черепашки
t2.penup()  # Поднимаем черепашку чтобы не рисовала
t2.goto(-200, -20)     # перемещаем черепашку
t2.pendown()          # Опускаю чтобы могла рисовать
t2.speed(3)


t3 = Turtle()   # Создали объект класса черепахи
t3.shape("turtle")   # Определили форму черепашки
t3.color(randint(0,255),randint(0,255),randint(0,255))     # Определили цвет черепашки
t3.penup()  # Поднимаем черепашку чтобы не рисовала
t3.goto(-200, 0)     # перемещаем черепашку
t3.pendown()          # Опускаю чтобы могла рисовать
t3.speed(3)


def razmetka():         # Функция рисует разметку поля
    t = Turtle()
    t.speed(0)
    for i in range(1, 21):
        t.penup()
        t.goto(-200+i*20, 100)
        t.pendown()
        t.goto(-200+i*20, -100)
    t.hideturtle()


def catch1(x, y):
    t1.write("Ouch!", font=('Arial', 14, 'normal'))
    t1.fd(randint(10, 15))


def catch2(x, y):
    t2.write("Мне больно!", font=('Arial', 14, 'normal'))
    t2.fd(randint(10, 15))


razmetka()
t1.onclick(catch1)
t2.onclick(catch2)

while t1.xcor() < finish and t2.xcor() < finish and t3.xcor() < finish :
    t1.forward(randint(2, 7))    # Смещение черепахи на случайное число
    t2.forward(randint(2, 7))    # Смещение черепахи на случайное число
    t3.forward(randint(2, 7)) 
time.sleep(3)
