# Напишите программу, удаляющую из текста все слова, содержащие ""aба"".

removeText = input("Введите текст для удаления: ")
list = []
text = ""
path = "text.txt"
with open(path, 'r', encoding= 'utf_8') as data:
    text = data.read()
text = text.split()
for word in text:
    if removeText not in word:
        list.append(word)
print(list)