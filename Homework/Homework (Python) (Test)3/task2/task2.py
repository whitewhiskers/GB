# Напишите программу, которая
# найдёт произведение пар чисел списка.
# Парой считаем первый и последний элемент, второй и предпоследний и т.д.
# Пример:
# - [2, 3, 4, 5, 6] => [12, 15, 16];
# - [2, 3, 5, 6] => [12, 15]

def getListFromUser():
    list = []
    stringInput = input('Введите список чисел через пробел: ')
    stringInput = stringInput.split(" ")
    for i in stringInput:
        if i != "":
            list.append(int(i))
    return list
list = getListFromUser()


print(f'{list} => ', end = "")
i = 0
g = -1
mult = 1
finalList = []

if len(list) % 2 == 0:
    while i < int(len(list)/2):
        mult = list[i] * list[g]
        finalList.append(mult)
        i += 1
        g -= 1
else:
    while i < int(len(list)/2):
        mult = list[i] * list[g]
        finalList.append(mult)
        i += 1
        g -= 1
    mult = list[i] * list[g]
    finalList.append(mult)

print(f"{finalList} <- 'Произведение пар чисел'")