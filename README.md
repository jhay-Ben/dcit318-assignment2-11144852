# dcit318-assignment2-11144852

# DCIT 318 Assignment 2 - Object-Oriented Programming in C#
# ID: 11144852

This repository contains solutions for Assignment 2 of the DCIT 318 (Programming II) course.  
The assignment demonstrates three key aspects of Object-Oriented Programming (OOP) in C#:

1. Inheritance and Method Overriding
2. Abstract Classes and Methods
3. Interfaces

Each task is implemented in its own file, and a main menu in `Program.cs` allows the user to choose which task to run.

---

## 1. Inheritance and Method Overriding

- Base Class: `Animal` with a `MakeSound()` method printing `"Some generic sound"`.
- Derived Classes:
  - `Dog` → overrides `MakeSound()` to print `"Bark"`.
  - `Cat` → overrides `MakeSound()` to print `"Meow"`.

Program Flow:
1. User is presented with a menu:
Choose an animal:
Animal
Dog
Cat
2. User selects an option.
3. The chosen object’s `MakeSound()` method runs, demonstrating **method overriding**.

---

## 2. Abstract Classes and Methods

- Abstract Class: `Shape` with an abstract method `GetArea()`.
- Derived Classes:
- `Circle` → implements `GetArea()` to calculate the area of a circle.
- `Rectangle` → implements `GetArea()` to calculate the area of a rectangle.

Program Flow:
1. Prompts user for:
- Circle radius
- Rectangle width and height
2. Calculates and displays the areas of both shapes.

---

## 3. Interfaces

- Interface: `IMovable` with method `Move()`.
- Implementations:
- `Car` → `Move()` prints `"Car is moving"`.
- `Bicycle` → `Move()` prints `"Bicycle is moving"`.

Program Flow:
1. User is presented with a menu:
Choose a vehicle:
Car
Bicycle
2. User selects an option.
3. The chosen object’s `Move()` method runs.

---

## How to Run

1. Clone the repository:
```bash
git clone https://github.com/jhay-Ben/dcit318-assignment2-11144852.git