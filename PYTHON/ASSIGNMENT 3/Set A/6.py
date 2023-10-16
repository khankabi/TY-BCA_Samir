#write a python program to check if the given key already exisits in a dictionary.
dicx={ 1:10,2:20,3:30,4:40,5:50}
def is_key_present(x):
    try:
        if x in dicx:
            print("Key is present in the dictionary")
        elif x not in dicx:
            print("Key is not present in the dictionary")
        else:
            print("Wrong input")
    except:
        print("there is someking of error")
is_key_present(5)
is_key_present(6)
is_key_present("c")




