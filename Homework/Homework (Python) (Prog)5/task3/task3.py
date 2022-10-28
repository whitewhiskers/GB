# 3. Создайте программу для игры в 'Крестики-нолики'.
from fileinput import close
import os
from random import randint


def clear(): return os.system('cls')


position = [1, 2, 3, 4, 5, 6, 7, 8, 9]
winCombination = {(1, 2, 3), (4, 5, 6), (7, 8, 9), (1, 4, 7),
                  (2, 5, 8), (3, 6, 9), (1, 5, 9), (3, 5, 7)}


def PrintField(positions):
    print(f" {positions[0]:^3}|{positions[1]:^3}|{positions[2]:^4}")
    print(f"-------------")
    print(f" {positions[3]:^3}|{positions[4]:^3}|{positions[5]:^4}")
    print(f"-------------")
    print(f" {positions[6]:^3}|{positions[7]:^3}|{positions[8]:^4}\n")


def RandomCoin():
    num = randint(1, 2)
    if num == 2:
        return True
    else:
        return False


def ChangeMarks(coin):
    if coin == "X":
        coin = "О"
    else:
        coin = "X"
    return coin


def PlayerTurn(pos, mark):
    print("Ваш ход:")
    while True:
        try:
            number = abs(int(input(f"Куда ставим {mark}?: ")))
            if pos[number-1] == "О" or pos[number-1] == "X":
                print("Клетка занята!")
                continue
            else:
                pos[number-1] = mark
                clear()
                return pos
        except Exception as error:
            continue


def CheckBestTurn(pos):
    if firstturn == 0:
        for n in winCombination:
            if pos[n[0]-1] == pos[n[1]-1] == "X":
                if pos[n[2]-1] != "О":
                    return pos[n[2]-1]
            if pos[n[1]-1] == pos[n[2]-1] == "X":
                if pos[n[0]-1] != "О":
                    return pos[n[0]-1]
            if pos[n[0]-1] == pos[n[2]-1] == "X":
                if pos[n[1]-1] != "О":
                    return pos[n[1]-1]
        for n in winCombination:
            if pos[n[0]-1] == pos[n[1]-1] == "О":
                if pos[n[2]-1] != "X":
                    return pos[n[2]-1]
            if pos[n[1]-1] == pos[n[2]-1] == "О":
                if pos[n[0]-1] != "X":
                    return pos[n[0]-1]
            if pos[n[0]-1] == pos[n[2]-1] == "О":
                if pos[n[1]-1] != "X":
                    return pos[n[1]-1]
    elif firstturn == 1:
        for n in winCombination:
            if pos[n[0]-1] == pos[n[1]-1] == "О":
                if pos[n[2]-1] != "X":
                    return pos[n[2]-1]
            if pos[n[1]-1] == pos[n[2]-1] == "О":
                if pos[n[0]-1] != "X":
                    return pos[n[0]-1]
            if pos[n[0]-1] == pos[n[2]-1] == "О":
                if pos[n[1]-1] != "X":
                    return pos[n[1]-1]
        for n in winCombination:
            if pos[n[0]-1] == pos[n[1]-1] == "X":
                if pos[n[2]-1] != "О":
                    return pos[n[2]-1]
            if pos[n[1]-1] == pos[n[2]-1] == "X":
                if pos[n[0]-1] != "О":
                    return pos[n[0]-1]
            if pos[n[0]-1] == pos[n[2]-1] == "X":
                if pos[n[1]-1] != "О":
                    return pos[n[1]-1]
    return None


def BotTurnHard(pos, mark):
    print("Ход противника:\n")
    while True:
        bestTurn = CheckBestTurn(pos)
        if bestTurn != None:
            pos[bestTurn-1] = mark
            return pos
        else:
            rand = randint(1, 9)
            if rand in pos:
                pos[rand-1] = mark
                return pos


def BotTurnEz(pos, mark):
    print("Ход противника:\n")
    while True:
        rand = randint(1, 9)
        if rand in pos:
            pos[rand-1] = mark
            return pos


clear()
while True:
    try:
        difficult = int(input("Выберите сложность (1 - eazy / 2 - hard): "))
        if difficult == 1 or difficult == 2:
            break
        else:
            continue
    except Exception as error:
        continue
clear()
print("Подкидываем монетку, решаем первый ход")
resultCoin = RandomCoin()
turn = resultCoin
if resultCoin == False:
    print("Увы, вы ходите вторым!\n")
    Mark = "О"
    firstturn = 0
else:
    print("Поздравляю ход за Вами!\n")
    Mark = "X"
    firstturn = 1
    PrintField(position)

for j in range(1, 11):
    close()
    for i in winCombination:
        if position[i[0]-1] == position[i[1]-1] == position[i[2]-1]:
            clear()
            print("Игра окончена\n")
            PrintField(position)
            if (firstturn == 1 and position[i[0]-1] == "X"
                    or firstturn == 0 and position[i[0]-1] == "О"):
                print("Вы победили =)")
                exit()
            else:
                print("Вы проиграли =(")
                exit()
    if j < 10:
        if turn == False:
            turn = True
            Mark = ChangeMarks(Mark)
            if difficult == 1:
                position = BotTurnEz(position, Mark)
            else:
                position = BotTurnHard(position, Mark)
            PrintField(position)
            Mark = ChangeMarks(Mark)
        else:
            turn = False
            position = PlayerTurn(position, Mark)
if turn == False:
    PrintField(position)
print("Ничья =/")
