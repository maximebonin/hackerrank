string = raw_input().strip()

alphanum = False
alpha = False
digits = False
lowercase = False
uppercase = False

for x in range(len(string)):
    sampleCharacter = string[x]
    
    if alphanum == False:
        if sampleCharacter.isalnum():
            alphanum = True
    
    if alpha == False:
        if sampleCharacter.isalpha():
            alpha = True
            
    if digits == False:
        if sampleCharacter.isdigit():
            digits = True
            
    if lowercase == False:
        if sampleCharacter.islower():
            lowercase = True
            
    if uppercase == False:
        if sampleCharacter.isupper():
            uppercase = True
            
def printAnswer(param):
    if param:
        print("True")
    else :
        print("False")
        
printAnswer(alphanum)
printAnswer(alpha)
printAnswer(digits)
printAnswer(lowercase)
printAnswer(uppercase)