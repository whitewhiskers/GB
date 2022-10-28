# Напишите программу, которая будет
# преобразовывать десятичное число в двоичное.
# Пример:
# - 45 -> 101101
# - 3 -> 11
# - 2 -> 10

number = int(input("Введите десятичное число: "))
num = number
decimal = []
div = 0
while number != 0:
    div = int(number % 2)
    number = int(number / 2)
    decimal.append(div)
list = list(reversed(decimal))
i = 0
print(f"Ваше число {num} в двоичной системе => ", end = "")
while i < len(list):
    print (list[i], end='')
    i+= 1