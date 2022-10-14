# Задайте список из вещественных чисел.
# Напишите программу, которая найдёт разницу между максимальным и минимальным значением дробной части элементов.
# минимальное значение дробной части отличное от нуля, у целых чисел дробной части нет их в расчет не берем
# *Пример:*
# - [1.1, 1.2, 3.1, 5, 10.01] => 0.19

def getListFromUser():
    list = []
    stringInput = input('Введите список вещественных чисел через пробел: ')
    stringInput = stringInput.split(" ")
    for i in stringInput:
        if i != "" and i.isdigit:
            list.append(float(i))
    return list


def countNumberAfterDot(x):
    stingx = str(x)
    count = 0
    for i in stingx:
        count += 1
        if i == ".":
            count = 0
    return count

def removeIntegerValue(RandomList):
    h = 0
    size = len(RandomList) 
    while h != size:
        if RandomList[h] % 1 == 0:
            RandomList.remove(RandomList[h])
            size-=1
            h-=1
        h+=1
    return RandomList

def FindMaxAndMin(RandomList):
    i = 0
    minimum = RandomList[i] % 1
    maximum = RandomList[i] % 1
    minIndex = 0
    result = 0
    while i < len(RandomList):
        end = RandomList[i] % 1
        if end == 0:
            i += 1
            continue
        elif end > maximum:
            maximum = end
        elif end < minimum:
            minIndex  = i
            minimum = end
        i += 1
    result = (maximum - minimum) % 1
    return result,minIndex

def CopyList(RandomList):
    list1 = []
    i = 0
    while i < len(RandomList):
        list1.append(RandomList[i])
        i+=1
    return list1

list = getListFromUser()
listRevork = CopyList(list)
listRevork = removeIntegerValue(listRevork)
result, minIndex = FindMaxAndMin(listRevork)
j = int(countNumberAfterDot(listRevork[minIndex]))
print(f'{list} => ', end ="")
print (round(result,j))
