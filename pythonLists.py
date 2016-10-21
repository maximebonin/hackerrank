howManyInstructions = int(raw_input())
array = list()

for x in range(0,howManyInstructions):
    instruction = raw_input()
    
    splittedStatement = instruction.split()
    firstWord = splittedStatement[0]
   
    if firstWord == 'insert':
        array.insert(int(splittedStatement[1]), int(splittedStatement[2]))
    elif firstWord == 'print':
        print array
    elif firstWord == 'remove':
        array.remove(int(splittedStatement[1]))
    elif firstWord == 'append':
        array.append(int(splittedStatement[1]))
    elif firstWord == 'sort':
        array.sort()
    elif firstWord == 'pop':
        array.pop()
    else:
        array.reverse()