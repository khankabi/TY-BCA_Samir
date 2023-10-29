# Write a Python class which has two methods get_String and print_String. get_String accept a string from the user and print_String print the string in upper case. Further modify the program to reverse a string word by word and print it in lower case. [25 M]
class str_mod:
    def get_string(self):
        self.str=input("Enter Your Name: ")

    def put_string(self):
        s=self.str
        print("String in Upper Case: " , s.upper())

        #String Reverse logic
        words = s.split(' ')
        string =[]
        for word in words:
            string.insert(0, word)

        print("String in Reverse & Lower case:"," ".join(string))

obj1=str_mod()
obj1.get_string()
obj1.put_string()