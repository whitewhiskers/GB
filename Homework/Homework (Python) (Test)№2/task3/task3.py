# Задайте список из n чисел последовательности 
# (1+1/n)^n и выведите на экран их сумму.

num = int(input("Введите число: "))
i = 1
list = []
mult = 1
while i != num + 1:
    mult = round((1+1/i)**i,2)
    list.append(mult)
    i += 1
print (f"Список из {num} чисел -> {list}")
lenght = len(list)
j = 0
sum = 0
while j != lenght:
     sum += list[j]
     j+=1
sum = round(sum,2)
print (f"Сумма всех чисел списка -> {sum}")