import textwrap

string = raw_input()
length = int(raw_input())

print(textwrap.fill(string, length))