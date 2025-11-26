Program 2

import random
import string
def generate_password(length=8):
 characters = string.ascii_letters + string.digits + string.punctuation
 password = ''.join(random.choice(characters) for i in range(length))
 return password
password_length = int(input("Input the desired length of your password:")or 8)
password = generate_password(password_length)
print("Generated password is:", password)
