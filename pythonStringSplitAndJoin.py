string = raw_input()

a = string.split(" ")

finalString = ""

length = len(a)

for x in range (length -1):
    finalString += a[x]
    finalString += "-"
    
finalString += a[len(a)-1] #the last item-word

print(finalString)