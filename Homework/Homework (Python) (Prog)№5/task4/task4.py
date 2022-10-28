# 4. Реализуйте RLE алгоритм: реализуйте модуль сжатия и восстановления данных. 
# Входные и выходные данные хранятся в отдельных текстовых файлах.
# Пример: aaaaaaabbbbbbccccccccc => 7a6b9c и 11a3b7c => aaaaaaaaaaabbbccccccc

path = "text.txt"
with open(path, 'r', encoding= 'utf_8') as data:
    some_text = (data.read())

def rle(text):
    result = ''
    next_char = ''
    count = 1
    if not text: return ''
    for char in text:
        if char != next_char:
            if next_char:
                result += str(count) + next_char
            count = 1
            next_char = char
        else:
            count += 1
    result += str(count) + next_char
    return result

with open("result.txt", 'w') as w:
    str(w.write(rle(some_text)))