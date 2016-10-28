string = raw_input()
data = raw_input()

splittedData = data.split(" ")

list = list(string)

list[int(splittedData[0])] = splittedData[1]

string = ''.join(list)

print(string)