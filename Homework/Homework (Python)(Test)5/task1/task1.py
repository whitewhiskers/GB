# 2. Создайте программу для игры с конфетами человек против человека.
# Правила: На столе лежит 2021 конфета. Играют два игрока делая ход друг после друга.
# Первый ход определяется жеребьёвкой. За один ход можно забрать не более чем 28 конфет.
# Все конфеты оппонента достаются сделавшему последний ход.
# Сколько конфет нужно взять первому игроку, чтобы забрать все конфеты у своего конкурента?
# a) Добавьте игру против бота
# b) Подумайте как наделить бота 'интеллектом'


import os
from random import randint


def randomCoin():
    num = randint(1, 2)
    if num == 2:
        return True
    else:
        return False


def PlayerChoice(count):
    print("\nТвой ход:")
    print(f"Осталось -> {count}")
    while True:
        try:
            while True:
                num = int(input("Сколько конфет возьмешь?: "))
                if 1 > num or num > 28:
                    print("\nСтолько нельзя, не жульничай!\n")
                    continue
                else:
                    count -= num
                    clear()
                    return count
        except Exception as error:
            continue


def BotChoiceEz(count):
    print("\nХод противника")
    print(f"Осталось -> {count}")
    if count > 28:
        num = randint(1, 28)
        print(f"Я возьму {num}")
        count -= num
        return count
    else:
        num = count
        print(f"Я возьму {num}")
        count -= num
        return count


def BotChoiceHard(count):
    print("\nХод противника")
    print(f"Осталось -> {count}")
    if count > 28:
        num = (count % 28) - 1
        if num == 0:
            num = 27
        elif num == -1:
            num = 28
        print(f"Я возьму {num}")
        count -= num
        return count
    else:
        num = count
        print(f"Я возьму {num}")
        count -= num
        return count


def SwapTurn(turnNow):
    if turnNow == False:
        turnNow = True
    else:
        turnNow = False
    return turnNow


def clear(): return os.system('cls')


clear()
countSweets = 2021
checkReady = False
while True:
    try:
        answer1 = input("Давай сыграем в игру? (Y/N): ")
        if answer1 == 'Y' or answer1 == "y":
            checkReady = True
            break
        elif answer1 == 'N' or answer1 == "n":
            answer1 = input("Может все таки сыграем? (Y/N): ")
            if answer1 == 'Y' or answer1 == "y":
                checkReady = True
                break
            else:
                exit()
        else:
            continue
    except Exception as error:
        continue
while True:
    try:
        difficult = int(input("Выберите сложность (1 - eazy / 2 - hard): "))
        if difficult == 1 or difficult == 2:
            break
        else:
            continue
    except Exception as error:
        continue

while checkReady:
    clear()
    print("Правила:")
    print(f"На столе лежит {countSweets} конфет. Играют два игрока делая ход друг после друга.\nПервый ход определяется жеребьёвкой. За один ход можно забрать не более чем 28 конфет.\nВсе конфеты оппонента достаются сделавшему последний ход. ")
    print("Подкинем монетку!....", end='')
    if randomCoin() == True:
        print('Выпал - Орел, Твой ход!')
        turn = True
    else:
        print('Выпала - Решка, Я хожу!')
        turn = False
    while countSweets > 0:
        if turn == True:
            countSweets = PlayerChoice(countSweets)
        elif turn == False and difficult == 1:
            countSweets = BotChoiceEz(countSweets)
        elif turn == False and difficult == 2:
            countSweets = BotChoiceHard(countSweets)
        turn = SwapTurn(turn)
    if turn == False:
        print("Поздравляю ты победил!!Все конфеты твои!!")
    else:
        print("Ты проиграл, ничего повезет в следующий раз!")
    checkReady = False
