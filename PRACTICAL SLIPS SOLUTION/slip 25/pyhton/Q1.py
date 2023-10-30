# Write a Python function that accepts a string and calculate the number of upper case letters and lower case letters. Sample String : 'The quick Brow Fox' Expected Output : No. of Upper case characters : 3 No. of Lower case Characters : 12
def count(str):
    uppercase=0
    lowercase=0
    for i in str:
        if i==" " or i==".":
            continue
        elif i.isupper():
            uppercase+=1
        elif i.islower():
            lowercase+=1
    return uppercase,lowercase

str="The quick Brow Fox"
result=count(str)
print("No. of Upper case characters : ",result[0])
print("No. of Lower case Characters : ",result[1])
