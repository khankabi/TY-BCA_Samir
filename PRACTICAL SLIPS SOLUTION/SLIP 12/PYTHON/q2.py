# Write a python program to count repeated characters in a string. Sample string: 'thequickbrownfoxjumpsoverthelazydog' Expected output: o-4, e-3, u-2, h-2, r-2, t-2
def count_char(str):
    mylist=list()
    for i in str:
        mylist.append(i)
    for j in mylist:
        count=mylist.count(j)
        if count>1:
            print(j," - ",count)
            while count>1:
                mylist.remove(j)
                count=mylist.count(j)
str="thequickbrownfoxjumpsoverthelazydog"
count_char(str)