#Write a program to illustrate function duck typing.
class Dog:
    def speak(self):
        return "Woof!"

class Cat:
    def speak(self):
        return "Meow!"

class Duck:
    def speak(self):
        return "Quack!"

def animal_sound(animal):
    return animal.speak()

# Instances of different classes
dog = Dog()
cat = Cat()
duck = Duck()

# Illustrating duck typing
print("Dog says:", animal_sound(dog))
print("Cat says:", animal_sound(cat))
print("Duck says:", animal_sound(duck))

