# 1) Для натурального n создать словарь индекс-значение, 
# состоящий из элементов последовательности 3n + 1.
# Пример:
# Для n = 6: {1: 4, 2: 7, 3: 10, 4: 13, 5: 16, 6: 19}


number = int(input('Введите число n: '))
i = 1
print(f"Для n = {number}: "'{',end="")
while (i < number+1):
    if i < number:
        result = 3*i+1
        print (f"{i}: {result}, ",end="")
        i += 1
    else:
        result = 3*i+1
        print (f"{i}: {result}",end="")
        i += 1
print("}",end="")
