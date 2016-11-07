weDontNeedThis = raw_input()
data = raw_input()
splittedData = data.split(" ")
splittedData = set(splittedData)

sum = 0.0

for x in splittedData:
    sum += int(x)

avg = sum / len(splittedData)

print(avg)

    