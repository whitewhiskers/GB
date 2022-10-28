# Напишите программу, удаляющую из текста все слова, содержащие ""абв"".
path = "text.txt"
with open(path) as data:
    text = data.read()
print(text)