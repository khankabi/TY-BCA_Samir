# Write a Python script using class, which has two methods get_String and print_String.
# get_String accept a string from the user and print_String print the string in upper case.
class str_mod:
    def get_string(self):
        self.str=input("Enter Your Name: ")
    def put_string(self):
        print(self.str.upper())
obj1=str_mod()
obj1.get_string()
obj1.put_string()