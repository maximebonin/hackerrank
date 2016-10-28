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

# DOSHI's answer
# He slices the string into a substring 
# of the length of the given substring
# and compares it with the substring



A = raw_input().strip()
x = raw_input().strip()

count = 0
for i in range(len(A) - len(x) + 1):
    if A[i:i+len(x)] == x:
        count += 1
print count