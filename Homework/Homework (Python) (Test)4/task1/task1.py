# Вычислить число c заданной точностью *d*
# Пример:
# при d = 0.001, π = 3.141
# при d = 0.1, π = 3.1
# при d = 0.00001, π = 3.14154
# d от 0.1 до 0.0000000001

from math import acos

def countNumberAfterDot(x):
    stingx = str(x)
    count = 0
    for i in stingx:
        count += 1
        if i == ".":
            count = 0
    return count+2
number = float(input("Введите число c заданной точностью 'от 0.1 до 0.0000000001': "))
count = countNumberAfterDot(number)
pi = round(2 * acos(0.0), 11)
print(f'{str(pi)[:count]}')
