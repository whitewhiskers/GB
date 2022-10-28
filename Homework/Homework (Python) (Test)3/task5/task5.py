# Задайте число.
#  Составьте список чисел Фибоначчи, в том числе для отрицательных индексов.
# Пример:
# - для k = 8 список будет выглядеть так:
# [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21] [Негафибоначчи

num = int(input("Введите число: ")) 
y = 1
z = -1
i = 0
sum = 0
listfib = [0]
if num >= 1:
  listfib.append(1)
  listfib = list(reversed(listfib))
  listfib.append(1)
if num >= 2:
  listfib.append(1)
  listfib = list(reversed(listfib))
  listfib.append(-1)
while i < num - 2:
    sum = y-z
    listfib.append(sum)
    y = z
    z = sum
    i += 1
listfib = list(reversed(listfib))
y = 1
z = 1
i = 0
while i < num - 2:
    sum = y+z
    listfib.append(sum)
    y = z
    z = sum
    i += 1
print(listfib)