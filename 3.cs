Program 3

import re
def validate_password(password):
  if len(password) < 8:
      print("Password Should have atleast 8 characters")
      return False
  if not re.search(r'[A-Z]', password):
      print("Password should have atleast one uppercase letter")
      return False
  if not re.search(r'[a-z]', password):
      print("Password should contain atleast one lowercase letter")
      return False
  if not re.search(r'\d', password):
      print("password should have atleast one digit")
      return False
  if not re.search(r'[!@#$%^&*(),.?":{}|<>]', password):
      
      print("Password should have atleast one special character")
      return False
  return True
password = input("Input your password: ")
if validate_password(password):
    print("Valid Password.")
else:
    print("Password does not meet requirements.")
