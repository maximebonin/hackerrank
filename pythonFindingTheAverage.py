n = int(raw_input())

classroom = []

for x in range(n):
    stringInput = raw_input()
    splittedInput = stringInput.split(" ")
    name = splittedInput[0]
    firstGrade = float(splittedInput[1])
    secondGrade = float(splittedInput[2])
    thirdGrade = float(splittedInput[3])
    
    studentInfo = list()
    studentInfo.append(name)
    studentInfo.append(firstGrade)
    studentInfo.append(secondGrade)
    studentInfo.append(thirdGrade)
    
    classroom.append(studentInfo)
    
chosenName = raw_input()
average = 0.0

for x in classroom:
    if x[0] == chosenName:
        sum = x[1]+x[2]+x[3]
        average = sum / 3.0
                
print(format(average, '.2f'))