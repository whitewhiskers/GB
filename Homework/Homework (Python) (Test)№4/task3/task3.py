# Задайте последовательность цифр. Напишите программу, 
# которая выведет список неповторяющихся элементов
# исходной последовательности.
# Пример:
# 47756688399943 -> [5]
# 1113384455229 -> [8,9]
# 1115566773322 -> []

number = input("Введите последовательность цифр: ")
listFirst = []
listSecond = []
for i in number:
    listFirst.append(int(i))
for f in range(0,10):
    if listFirst.count(f) == 1:
        listSecond.append(f)
print(listSecond)