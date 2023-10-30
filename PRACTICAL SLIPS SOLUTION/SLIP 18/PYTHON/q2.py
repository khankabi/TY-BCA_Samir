# Write a python script to define the class person having members name, address. Create a subclass called Employee with members staffed salary. Create 'n' objects of the Employee class and display all the details of the employee.
class Person:
  def __init__(self, name, address):
    self.name = name
    self.address = address

class Employee(Person):
  def __init__(self, name, address, salary):
    super().__init__(name, address)
    self.salary = salary

def main():
  n = int(input("Enter the number of employees: "))
  employees = []
  for i in range(n):
    name = input("Enter the name of the employee: ")
    address = input("Enter the address of the employee: ")
    salary = int(input("Enter the salary of the employee: "))
    employees.append(Employee(name, address, salary))

  for employee in employees:
    print("Employee Name:", employee.name)
    print("Employee Address:", employee.address)
    print("Employee Salary:", employee.salary)

if __name__ == "__main__":
  main()
