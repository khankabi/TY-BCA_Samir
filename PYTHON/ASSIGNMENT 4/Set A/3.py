# Define a function that accept two strings as input and find union and intersection of them.
# initializing strings
test_str1 = 'YEWSnationalseniorcollege'
test_str2 = 'nationalurduhighschool'
 
# using naive method to
# get string intersection
def intersection(test_str1,test_str2):
    res = ""
    for i in test_str1:
        if i in test_str2 and not i in res:
            res += i         
# printing intersection
    print ("String intersection is : " + res)

def union(test_str1,test_str2):
    res = ""
    temp = test_str1
    for i in test_str2:
        if i not in temp:
            test_str1 += i         
    # printing result
    print ("The string union is : " + test_str1)


 
# Printing initial strings
print ("The original string 1 is : " + test_str1)
print ("The original string 2 is : " + test_str2)
intersection(test_str1,test_str2)
union(test_str1,test_str2)
 
# using naive method to
# Union Operation in two Strings
