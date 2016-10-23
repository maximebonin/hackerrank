howMany = int(raw_input())

stringInput = raw_input()

listNumbers = stringInput.split()

listNumbers = [int(x) for x in listNumbers]

listNumbers.sort()

largestNumber = -99999999
secondLargestNumber = -99999999

for x in listNumbers[::-1]:  # the loop is in reverse order
    if(x >= largestNumber):
        largestNumber = x
    else:
        if(x >= secondLargestNumber):
            secondLargestNumber = x
        else:
            break
            
print(secondLargestNumber)