Program 12

from cryptography.fernet import Fernet
key=Fernet.generate_key()
fernet = Fernet(key)
msg=input("Enter the Message: ").encode()
encrypted_msg=fernet.encrypt(msg)
decrypted_msg=fernet.decrypt(encrypted_msg)
decrypted_msg=decrypted_msg.decode()
print("Original Message: ", msg.decode())
print("Encrypted Message: ", encrypted_msg)
print("Decrypted Message: ", decrypted_msg)
