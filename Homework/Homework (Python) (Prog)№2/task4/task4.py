# Задайте список из N элементов, заполненных числами из промежутка [-N, N]. 
# Найдите произведение элементов на указанных позициях. 
# Позиции хранятся в файле file.txt в одной строке одно число.

list = []
num = int(input("Введите число: "))
i = -num
while i!= num +1:
    list.append (i)
    i+=1
print (f"Список из N элементов в промежутке [-N;N] -> {list}")
list2 = []
data = open('file.txt', 'r')
for line in data:
    list2.append(int(line))
print (f"Список из текстого файла -> {list2}")
data.close()
j = 0
multi = 1
lenght = len(list2)
while j != lenght:
    multi *= int(list[list2[j]])
    j+=1
print(f"Произведение элеметов на позициях(индексах) из файла ->  {multi}")