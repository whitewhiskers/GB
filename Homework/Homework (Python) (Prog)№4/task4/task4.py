# Задана натуральная степень k. Сформировать случайным образом
# список коэффициентов (значения от -100 до 100)
# многочлена и записать в файл многочлен степени k
# k - максимальная степень многочлена, следующий степень
# следующего на 1 меньше и так до ноля
# Коэффициенты расставляет random, поэтому при коэффициенте 0 просто
# пропускаем данную итерацию степени

# Пример:
#  k=2 -> 2x² + 4x + 5 = 0 или x² + 5 = 0 или 10x² = 0
#  k=5 -> 3x⁵ + 5x⁴ - 6x³ - 3x = 0


from random import randint
number = int(input("Введите степень: "))
count = number
string = ""
while number != 0:
    rand = randint(-100, 100)
    if count == number:
        string += f"{rand}*x**{number} "
        number -= 1
        continue
    if rand > 0:
        string += f"+ {rand}*x**{number} "
    elif rand < 0:
        string += f"- {abs(rand)}*x**{number} "
    number -= 1
rand = randint(-100, 100)
if rand > 0:
    string += f"+ {rand} = 0"
elif rand < 0:
    string += f"- {abs(rand)} = 0"
else: string += "= 0"

with open ('Complete.txt', 'w') as f:
    f.write(string)
    