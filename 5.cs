Program 5

import re
def check_password_strength(password):
    score = 0
    suggestions = []
    if len(password) >= 8:
       score += 1
    else:
       suggestions.append("Password should be at least 8 characters long")
    if re.search(r"[A-Z]", password):
      score += 1
    else:
      suggestions.append("Password should contain at least one uppercase letter")
    if re.search(r"[a-z]", password):
      score += 1
    else:
      suggestions.append("Password should contain at least one lowercase letter")
    if re.search(r"\d", password):
      score += 1
    else:
       suggestions.append("Password should contain at least one numeric digit")
    if re.search(r"[!_@#$%^&*/(),.?\":{}|<>]", password):
       score += 1
    else:
      suggestions.append("Password should contain at least one special character (!@#$%^&*(),.?\":{}|<>)")
    return score, suggestions
password = input("Input a password: ")
score, suggestions=check_password_strength(password)
print(score)
print(f"Password Score:{score}/5")
if suggestions:
    print("\n Suggestions to improve your password:")
    for suggestion in suggestions:
        print(f"-{suggestion}")
else:
    print("\n your password meets all criteria!")
