Program 8

def encrypt(text, s):
    result = ""
    for i in range(len(text)):
        char = text[i]
        if char.isupper():
            result += chr((ord(char) + s - 65) % 26 + 65)
        # Encrypt lowercase characters
        else:
            result += chr((ord(char) + s - 97) % 26 + 97)
    return result
text = input("Enter the text: ")
s = int(input("Enter the shift between 1 to 25: "))
print("Text: " + text)
print("Shift: " + str(s))
print("Cipher: " + encrypt(text, s))
