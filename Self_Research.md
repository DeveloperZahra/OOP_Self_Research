﻿# 🧠 Difference between data type and data structure

|Data Types|	Data Structures|
|----------|-------------------|
|Data Type is the kind or form of a variable which is being used throughout the program. It defines that the particular variable will assign the values of the given data type only|	Data Structure is the collection of different kinds of data. That entire data can be represented using an object and can be used throughout the entire program.|
|Implementation through Data Types is a form of abstract implementation|	Implementation through Data Structures is called concrete implementation|
|Can hold values and not data, so it is data less|	Can hold different kind and types of data within one single object|
|Values can directly be assigned to the data type variables	|The data is assigned to the data structure object using some set of algorithms and operations like push, pop and so on.|
|No problem of time complexity	| Time complexity comes into play when working with data structures|

## 📌 Types of Data Type:

There are 5 common data types namely:

✅ Integer: Whole numbers (e.g., 1, 2, 3)

✅ Float: Decimal numbers (e.g., 3.14, -0.5)

✅ Character: Single characters (e.g., ‘a’, ‘B’)

✅ String: Sequences of characters (e.g., ‘hello’, ‘goodbye’)

✅ Boolean: Logical values (true or false)

## 📌 Types of Data Structure:

Data structures are categorized based on their organization, accessibility, and manipulation of data. They are broadly classified into 2 types:

## 1. Linear Data Structure
A linear data structure is a type of data structure where the elements are arranged sequentially. In a linear structure, each element is connected to its previous and next elements and stored in a single, continuous sequence. This structure allows for easy traversal, insertion, and deletion of elements. The linear data structure is further classified into two types:

⭐ **Static:**  In a linear data structure, a static refers to a data structure with a fixed size and memory allocation at compile time. It can be represented as: 

⭐ **Arrays:**  A collection of elements of the same data type stored in contiguous memory locations.

⭐ **Dynamic:** The dynamic refers to a data structure with a variable size and memory allocation at runtime. It can be represented as: 

⭐ **Linked Lists:**  A sequence of nodes, each containing a value and a reference (i.e., a ‘link’) to the next node.

⭐ **Stack:** A Last-In-First-Out (LIFO) data structure, where elements are added and removed from the top.

⭐ **Queue:**  A First-In-First-Out (FIFO) data structure, where elements are added to the end and removed from the front.

## 2. Non-Linear Data Structure
A non-linear data structure is a type of data structure where the elements are not stored sequentially. It allows for more complex relationships between elements. In these structures, each element can be connected to multiple elements, and there is no single ‘next’ or ‘previous’ element in a simple sequence. The non-linear data structure is classified into two types:

⭐ **Trees:** A hierarchical structure where each node has a finite number of child nodes. It can be represented as:

⭐ **Binary Trees:** There are only two children per node (left and right).

⭐ **Balanced Trees:** Trees that maintain a balance between the height of the left and right subtrees.

⭐ **AVL Trees:** A self-balancing binary search tree.

⭐ **B-Trees:** A multi-level index that balances search, insertion, and deletion operations.

⭐ **Heaps:** Tree-based data structure that satisfies the heap property.

⭐ **Graphs:** A graph is a non-linear collection of nodes connected by edges. It can be represented as:

⭐ **Directed Graphs:** Edges have direction and represent a one-way relationship.

⭐ **Undirected Graphs:** Edges are bidirectional and represent a two-way relationship.



## 📌 When to Use Data Types vs Data Structures:

Understanding when to use data types and data structures is key for managing efficient and optimized code.

⭐ Data types are ideal when you are dealing with simple values like numbers or text. 
For example, if you need to store a user's age, you will use an integer data type.

⭐ Data structures are required to store or manipulate multiple values efficiently. 
For example, if you need to keep track of a list of students, a data structure like an array or linked list would be more suitable.

-------------------------

# 🧠 Introduction of Object Oriented Programming

Object-Oriented Programming or OOPs refers to languages that use 
objects in programming. Object-oriented programming aims to implement
real-world entities like inheritance, hiding, polymorphism, etc in programming.
The main aim of OOP is to bind together the data and the functions
that operate on them so that no other part
of the code can access this data except that function.

## 📌 OOPs Concepts

![](image/OOP.jfif)

## 📌 Why do we need object-oriented programming:

⭐ To make the development and maintenance of projects more effortless. 

⭐ To provide the feature of data hiding that is good for security concerns. 

⭐ We can solve real-world problems if we are using object-oriented programming. 

⭐It ensures code reusability. 

⭐It lets us write generic code: which will work with a range of data, so we don't have to write basic stuff over and over again.


![](image/ClassConceptsObjectOrientedProgramming.webp)

------------------------------------------
# 🧠 What are get and set in C#?

In C#, get and set are called accessors, and they are part of a property.
A property is a way to control access to the fields of a class.

✅ **get:** Returns the value of the property (read access).

✅ **set:** Assigns a new value to the property (write access).

## 📌 Syntax Example (Auto-Implemented Property):

       public class Car
     {
    public string Model { get; set; }  // Auto property
     }

This is called an auto-implemented property.
You don't need to write a private field — C# handles that automatically

## 📌 Custom Property Example:
```sql
private int _speed;

public int Speed
{
    get { return _speed; }
    set
    {
        if (value > 0)
            _speed = value;
        else
            _speed = 0;
    }
}
```
Here:

get returns _speed

set adds a condition to make sure the value is not negative.

## 💎 More Property Examples

**1. Read-only Property** 

```sql

public string Brand { get; } = "Toyota";

```
You can only read this value. It can't be changed after initialization.

**2. Write-only Property**

```sql
private string password;
public string Password
{
    set { password = value; }  // Only sets the value
}
```
You can set the value, but not read it outside the class.

**3. Computed Property**

```sql
private double radius;

public double Area
{
    get { return Math.PI * radius * radius; }  // Calculate value dynamically
}
```
Useful when the property is calculated based on other fields.

# 🌟 Benefits of using Properties with get and set

| Feature             | Description                                                                |
| ------------------- | -------------------------------------------------------------------------- |
| ✅ **Encapsulation** | You can hide internal data and only expose what's needed.                  |
| ✅ **Validation**    | You can check or limit values inside `set` to ensure correctness.          |
| ✅ **Flexibility**   | You can later change how a value is stored without affecting outside code. |
| ✅ **Debugging**     | Easier to trace and debug because logic is inside `get`/`set`.             |
| ✅ **Security**      | Prevent direct access to fields and protect sensitive data.                |

-------
## 🧠 What is a Static Constructor?
A static constructor is a special constructor that is used to initialize static members (fields or properties) of a class.
It runs once only, automatically, before the first object is created or any static member is accessed.


## 📌 Key Rules: 

✅ It has no parameters.

✅ It cannot be called manually.

✅ It runs only once per class, not per object.

------------

## 🧠 What are Static Fields?
A static field belongs to the class itself, not to any specific object.
This means all instances of the class share the same static field.


## 📌  Syntax & Example:

```sql 
public class Car
{
    // Static fields (shared across all objects)
    public static int MaxSpeed;
    public static string DefaultFuelType;

    // Instance fields (specific to each object)
    public string Model { get; set; }
    public int Speed { get; set; }

    // Static constructor
    static Car()
    {
        MaxSpeed = 180;
        DefaultFuelType = "Petrol";
        Console.WriteLine("Static constructor called.");
    }

    // Regular constructor
    public Car(string model, int speed)
    {
        Model = model;
        Speed = speed > MaxSpeed ? MaxSpeed : speed;
    }
}
``` 
## 📌 Usage in Main:

```sql 
class Program
{
    static void Main()
    {
        Car car1 = new Car("Toyota", 150);
        Car car2 = new Car("BMW", 250);  // Speed will be limited to 180
    }
}
```
## ⌛ Output:

```sql 
Static constructor called.
```
💡 (Only appears once, even if many objects are created)

-----------

## 💎 When to Use Static Fields and Static Constructors?

📌 **Use Static Fields when:**

⭐ You need shared configuration or counters across all objects.

⭐ Example: MaxAllowedSpeed, TotalUserCount, or database connection strings

📌 **Use Static Constructors when:**  

⭐ You want to initialize static fields once.

⭐ You want automatic setup before using the class

📌 **Benefits**

| Feature              | Description                                                             |
| -------------------- | ----------------------------------------------------------------------- |
| ✅ **Shared data**    | Same static field value shared by all objects.                          |
| ✅ **One-time setup** | Static constructor is perfect for setup like configurations or caching. |
| ✅ **Performance**    | Efficient since static constructor runs only once.                      |
| ✅ **Encapsulation**  | Hides setup logic inside the static constructor.                        |


⚠️ **Important Notes** 

⭐ You cannot access this in a static constructor because it’s not tied to any object.

⭐ You cannot have more than one static constructor in a class.

⭐ Static members can also be accessed without creating an object:

```sql 
Console.WriteLine(Car.MaxSpeed);  // Access static field directly
```

## 🧠 What is a Constructor?

A constructor is a special method in a class that is automatically called when an object of the class is created. It is used to initialize objects.


**1. Default Constructor:**

⭐ Definition: A constructor that takes no parameters.

⭐ Used for: Giving default values to fields.
 
⭐ Example:

```sql 
class Person
{
    public string name;

    public Person()  // Default constructor
    {
        name = "Unknown";
    }
}
```


**2. Parameterized Constructor:** 

⭐ Definition: A constructor that accepts arguments (parameters).

⭐ Used for: Initializing fields with specific values during object creation.

⭐ Example:
```sql 
class Person
{
    public string name;

    public Person(string n)  // Parameterized constructor
    {
        name = n;
    }
}

```
**3. Copy Constructor:** 

⭐ Definition: A constructor that creates a new object by copying values from another object.

⭐ Used for: Duplicating objects.

⭐ Example:

```sql 
class Person
{
    public string name;

    public Person(string n)
    {
        name = n;
    }

    public Person(Person p)  // Copy constructor
    {
        name = p.name;
    }
}
```
**4. Static Constructor:**

⭐ Definition: A constructor declared using the static keyword.

⭐ Used for: Initializing static fields. It runs only once, when the class is first loaded.

⭐ Example:

```sql 
class Person
{
    static string greeting;

    static Person()  // Static constructor
    {
        greeting = "Hello!";
    }
}
```


## 🧠 Summary of Constructor Types in C#

| **Constructor Type**          | **Accepts Parameters?** | **Purpose**                                             | **Notes**                                                                          |
| ----------------------------- | ----------------------- | ------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| **Default Constructor**       | ❌ No                    | Initializes default values                              | Called automatically when no parameters are passed                                 |
| **Parameterized Constructor** | ✅ Yes                   | Allows setting custom values during object creation     | Flexible and commonly used                                                         |
| **Copy Constructor**          | ✅ Yes (an object)       | Creates a new object by copying another object’s values | Useful for creating independent duplicates                                         |
| **Static Constructor**        | ❌ No                    | Initializes static members (shared across all objects)  | Called once automatically, before any object is created or static members accessed |

---------------------------------------------

# 💎 Inheritance in C# 

Inheritance is a fundamental concept in object-oriented programming that allows a child class to inherit the properties from the superclass. The new class inherits the properties and methods of the existing class and can also add new properties and methods of its own. Inheritance promotes code reuse, simplifies code maintenance, and improves code organization

## 🧠  Syntax:

```sql
class derived-class : parent-class  
{  
     // methods and fields  
}
```
📌 **Derived Class:** The class that inherits the other class is known as a subclass(or a derived class, extended class, or child class). The subclass can add its fields and methods in addition to the superclass properties.
📌 **Parent Class:** The class whose features are inherited is known as a superclass (or a base class or a parent class).

## 🧠 Types of Inheritance:

In C#, there are mainly 4 types of inheritance which are described below:

**1. Single Inheritance:** A derived class that inherits from only one base class.
**2. Multi-level Inheritance:**  A derived class that inherits from a base class and the derived class itself becomes the base class for another derived class.

**3. Hierarchical Inheritance:**  A base class that serves as a parent class for two or more derived classes.

**4. Multiple Inheritance:** A derived class that inherits from two or more base classes (Using Interface).

**5. Hybrid Inheritance:** A Hybrid Inheritance is a mix of two or more inheritances.


## 🧠 Advantages & Disadvantages of Inheritance:

|Advantages of Inheritance| Disadvantages of Inheritance|
|-------------------------|-----------------------------|
|Code Reusability: Inheritance allows us to reuse existing code by inheriting properties and methods from an existing class.|Tight Coupling: Inheritance creates a tight coupling between the base class and the derived class, which can make the code more difficult to maintain.|
|Code Maintenance: Inheritance makes code maintenance easier by allowing us to modify the base class and have the changes automatically reflected in the derived classes.|Complexity: Inheritance can increase the complexity of the code by introducing additional levels of abstraction.|
|Code Organization: Inheritance improves code organization by grouping related classes together in a hierarchical structure.|Fragility: Inheritance can make the code more fragile by creating dependencies between the base class and the derived class.|

## 🧠 Difference between virtual and override in C#:

| Keyword        | Meaning                                                                    | When to use it?                                                                                  |
| -------------- | -------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------ |
| **`virtual`**  | Allows a method to be *overridden* by derived classes.                     | Use it in the **base class** when you want to allow child classes to change the method behavior. |
| **`override`** | Used to **change the behavior** of a `virtual` method from the base class. | Use it in the **derived class** when you want to replace the base class implementation.          |

## 🧠 Example:

```sql
class Payment
{
    public virtual void ProcessPayment()
    {
        Console.WriteLine("Processing general payment...");
    }
}

class CreditCardPayment : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine("Processing credit card payment...");
    }
}

class CashPayment : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine("Processing cash payment...");
    }
}

``` 




