# Даны два файла, в каждом из которых находится запись многочлена.
# Задача - сформировать файл, содержащий сумму многочленов.
# Пример двух заданных многочленов:
# 23x⁹ - 16x⁸ + 3x⁷ + 15x⁴ - 2x³ + x² + 20 = 0
# 17x⁹ + 15x⁸ - 8x⁷ + 15x⁶ - 10x⁴ + 7x³ - 13x¹ + 33 = 0
# Результат:
# 40x⁹ - x⁸ -5x⁷ + 15x⁶ +5x⁴ + 5x³ + x² - 13x¹ + 53 = 0

# - 16x**9 + 88x**6 + 72x**11 + 64x**15 + 12x**13 + 42x**5 - 38x**4 - 58x**3 + x**22 - 64x**1 - 31 = 0
# 72x**10 + 61x**23 - x**25 - 38x**5 - 94x**4 + 61x**3 - 73x**2 + 86x**1 - 25 = 0


from dataclasses import replace
def GetDict (x):
    i = -4
    dictFirst = {}
    while i > -(len(x)):
        pow = int(x[i])
        dictFirst[pow] = int(x[i-1])
        i-= 2
    return dictFirst
def ReplaceValue(x):
    x = x.replace('- ', '-').replace('+ ', '+').replace('**', ' ').replace('-x', '-1').replace('+x', '+1').replace('*x', '').replace('x', '')
    b = x.split(" ")
    return b
def FindMaxValueKey(list):
    temp = 1
    i = -4
    while i > -(len(list)):
        if temp < int(list[i]):
            temp = int(list[i])
        i-=2
    return temp
with open ('first.txt') as f:
    stringFirst = str(f.readline())
with open ('second.txt') as s:
    stringSecond = str(s.readline())
a = ReplaceValue(stringFirst)
b = ReplaceValue(stringSecond)
dictFirst = GetDict(a)
dictSecond = GetDict(b)
dictFinal = {}
maxI = FindMaxValueKey(a)
maxIn = FindMaxValueKey(b)
if maxIn > maxI: maxI = maxIn
for i in range(1,maxI+1):
    dictFinal[i] = dictFirst.get(i,0) + dictSecond.get(i,0)
stringFinal = ""
i = maxI
count = 1
while i != 0:
    if dictFinal[i] != 0 and count == 1 and dictFinal[i] != 1 and dictFinal[i] != -1:
        stringFinal += f"{(dictFinal[i])}x**{i} "
        count+=1
    elif dictFinal[i] == 1 and count == 1:
        stringFinal += f"x**{i} "
        count+=1
    elif dictFinal[i] == -1:
        stringFinal += f"- x**{i} "
        count+=1
    elif dictFinal[i] == 1:
        stringFinal += f"+ x**{i} "
        count+=1
    elif dictFinal[i] != 0 and dictFinal[i] < 0 :
        stringFinal += f"- {abs(dictFinal[i])}x**{i} "
    elif dictFinal[i] != 0 and dictFinal[i] > 0 :
        stringFinal += f"+ {abs(dictFinal[i])}x**{i} "
    i-=1
c = int(a[-3])+int(b[-3])
if c < 0: stringFinal += f"- {abs(c)}"
else: stringFinal += f"+ {abs(c)}"
stringFinal += " = 0"
with open ('result.txt', 'w') as w:
    str(w.write(stringFinal))
