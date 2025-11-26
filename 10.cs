Program 10

import rsa
def rsa_algo( password) :
   publickey, privatekey= rsa.newkeys(512)
   print("Public key: ",publickey)
   print("Private key:",privatekey)
   message = password.encode ('utf-8')
   ciphertext = rsa.encrypt (message, publickey)
   print("cipher text!", ciphertext)
   decrypted_message= rsa.decrypt (ciphertext , privatekey)
   print("decrypted message", decrypted_message.decode('utf -8'))
password = input ("Input your text")
rsa_algo(password)
