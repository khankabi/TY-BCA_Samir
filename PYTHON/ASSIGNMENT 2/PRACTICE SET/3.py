#write a python program to count vowels and consonants in a string.
org_str = input("Enter a String : ")
vowels = 0
consonents = 0
special = 0
number = 0
for alphabet in org_str:
    if alphabet in ['a','e','i','o','u','A','E','I','O','U']:
        vowels+=1
    elif alphabet in('&','_','*','@','!','#','^'):
        special+=1
    elif alphabet in ('1','2','3','4','5','6','7','8','9','0'):
        number+=1
    else:
        consonents+=1
print(f"Vowels = {vowels} \n Consonents = {consonents} \n Special character = {special} \n Number = {number}")

