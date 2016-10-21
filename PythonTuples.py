tup1 = ()

howManyElements = int(raw_input()) #we don't need this data ...

input = raw_input()

listOfInts = input.split()

for number in listOfInts:
    tup1 = tup1 + (int(number),)

print(tup1.__hash__())