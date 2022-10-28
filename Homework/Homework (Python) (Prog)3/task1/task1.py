# Задайте список из нескольких чисел.
#  Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной позиции.
# Пример:
# - [2, 3, 5, 9, 3] -> на нечётных позициях элементы 3 и 9, ответ: 12
def getListFromUser():
    list = []
    stringInput = input('Введите список чисел через пробел: ')
    stringInput = stringInput.split(" ")
    for i in stringInput:
        if i != "":
            list.append(int(i))
    return list
list = getListFromUser()
print(list)
i = 1
sum = 0
while i < len(list):
    sum += list[i]
    i += 2
print(f"Сумма чисел на нечетных позициях -> {sum}")