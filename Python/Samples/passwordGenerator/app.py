import random

def GeneratePassword():

    lower = "abcdefghijklmnopqrstuvwxyz"
    upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    numbers = "0123456789"
    symbols = "[]{}()*;/,._-"

    all = lower + upper + numbers + symbols

    lenght = 16
    password = "".join(random.sample(all, lenght))
    print(password)