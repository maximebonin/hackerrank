string = raw_input()
substring = raw_input()

splittedString = list(string)

counter = 0
rangeX = len(splittedString) - len(substring) + 1

for x in range (rangeX):
    partOfString = ""
    for y in range(len(substring)):
        partOfString += splittedString[x+y]
    if partOfString == substring:
        counter += 1

print(counter)