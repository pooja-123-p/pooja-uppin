Program 11

import base64
my_string = "Hello, World!"
encoded_string = base64.b64encode(my_string.encode("utf-8"))
print("encoded string:",encoded_string)
my_string = "SGVsbG8sIFdvcmxkIQ=="
decoded_string = base64.b64decode(my_string)
print("decoded string:",decoded_string.decode("utf-8"))
