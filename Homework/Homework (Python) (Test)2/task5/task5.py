from random import randint
list = [1,2,3,4,5,6,7,8]
def shuffle(list2):
  temp_list2 = list2
  lenght = len(temp_list2)
  while lenght > 0:
    lenght -= 1
    i = randint(0, lenght)
    temp_list2[lenght], temp_list2[i] = temp_list2[i], temp_list2[lenght]
  return temp_list2
shuffle(list)
print(list)