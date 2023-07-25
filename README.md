# LecturesNotes
DotNet and C# lecture notes and samples 

## 1. Introduction to Programming with .Net and C#
### 1.1. What is .NET?
- .NET is a platform for building, deploying, and running Web Services and applications.
- .NET Framework provides the necessary compile-time and run-time foundation to build and run any language that conforms to the Common Language Specification (CLS).
- .NET Framework is a software framework developed by Microsoft that runs primarily on Microsoft Windows. It includes a large class library named Framework Class Library (FCL) and provides language interoperability (each language can use code written in other languages) across several programming languages. Programs written for .NET Framework execute in a software environment (as contrasted to hardware environment) named Common Language Runtime (CLR), an application virtual machine that provides services such as security, memory management, and exception handling. (As such, computer code written using .NET Framework is called "managed code".) FCL and CLR together constitute .NET Framework.
- .NET Framework's Base Class Library provides user interface, data access, database connectivity, cryptography, web application development, numeric algorithms, and network communications. Programmers produce software by combining their own source code with .NET Framework and other libraries. .NET Framework is intended to be used by most new applications created for the Windows platform. Microsoft also produces an integrated development environment largely for .NET software called Visual Studio.

### 1.2. What is .Net 7.0?
- .NET 7.0 is the next major release of .NET Core following 6.0. It will include new features and improvements for building high-performance, cross-platform web, cloud, and desktop applications with .NET. We'll continue to update this page with more details as we get closer to the release.

### 1.3. What is CLR?
- The Common Language Runtime (CLR) is the virtual machine component of the .NET framework. It manages the execution of .NET programs and provides various useful services for those programs.
- The CLR provides additional services including memory management, type safety, exception handling, garbage collection, security and thread management. All programs written for the .NET framework, regardless of programming language, are executed by the CLR. All versions of the .NET framework include CLR.

### 1.4. What is CTS?
- The Common Type System (CTS) is a standard that specifies how type definitions and specific values of types are represented in computer memory. It is intended to allow programs written in different programming languages to easily share information. The CTS specification is owned and maintained by Microsoft. It is a constituent standard of Common Language Infrastructure (CLI).

### 1.5. What is IL?
- Intermediate language (IL) is the language used in .NET. All .NET source code is compiled to IL. IL is then converted to machine code at the point where the software is installed, or at run-time by a Just-In-Time (JIT) compiler. IL is similar to Java bytecode and is processed by the Common Language Runtime (CLR).
- IL is a stack-based language (like the Java Virtual Machine (JVM)) that uses a stack to pass parameters to methods and to hold local variables. The stack is also used to evaluate expressions. IL is an object-oriented language that supports inheritance, interfaces, and polymorphism. It is also a structured language that supports loops, conditionals, and structured exception handling.
- IL is a platform-independent language. The same IL code can be run on any system that has a .NET runtime installed. This is similar to Java bytecode, which can be run on any system that has a JVM installed.

### 1.6. What is JIT?
- Just-in-time (JIT) compilation, also known as dynamic translation, is compilation done during execution of a program – at run time – rather than prior to execution. Most often this consists of translation to machine code, which is then executed directly, but can also refer to translation to another format.
- A system implementing a JIT compiler typically continuously analyses the code being executed and identifies parts of the code where the speedup gained from compilation or recompilation would outweigh the overhead of compiling that code.

### 1.7. What is Lowering in C#?
- Lowering is the process of converting a high-level language construct into a lower-level one. For example, a C# foreach loop is lowered into a while loop. The lowering process is performed by the compiler.
- The lowering process is performed by the compiler. The compiler converts the C# code into IL code. The IL code is then converted into machine code by the JIT compiler.

### 1.8. What is Boxing and Unboxing?
- Boxing is the process of converting a value type to the type object or to any interface type implemented by this value type. When the CLR boxes a value type, it wraps the value inside a System.Object and stores it on the managed heap. Unboxing extracts the value type from the object. Boxing is implicit; unboxing is explicit. The concept of boxing and unboxing underlies the C# unified view of the type system in which a value of any type can be treated as an object.
- Boxing is used to store value types in the garbage-collected heap. Boxing is an implicit conversion of a value type to the type object or to any interface type implemented by this value type. Boxing a value type allocates an object instance on the heap and copies the value into the new object.

### 1.9. What is Garbage Collection?
- Garbage collection (GC) is a form of automatic memory management. The garbage collector, or just collector, attempts to reclaim garbage, or memory occupied by objects that are no longer in use by the program. Garbage collection was invented by John McCarthy around 1959 to solve the problems of manual memory management in his language Lisp. Garbage collection is essentially the opposite of manual memory management, which requires the programmer to specify which objects to deallocate and return to the memory system. Garbage collection is enabled by default in .NET Framework applications. It is also possible to explicitly control the lifetime of an object by implementing the IDisposable interface and manually freeing the object when finished with it. This is not required for memory management as the garbage collector will automatically free the object when it determines that the object is no longer reachable by the application.

### 1.10. What is Managed Code?
- Managed code is computer program code that requires and will execute only under the management of a Common Language Runtime virtual machine (resulting in bytecode). It is contrasted with native code or machine code, which is produced by a compiler specific to the hardware architecture (CPU) in question, and run directly by the operating system. The term was coined by Microsoft as a buzzword in 2000 when they launched the .NET Framework to emphasize the fact that the code had to be managed by the common language runtime (CLR). The term is now used more widely, including for Java bytecode.

### 1.11. What is Unmanaged Code in C#?
- Unmanaged code is code which is executed directly by the CPU. It is code that is not managed by the .NET Framework Common Language Runtime (CLR). Unmanaged code is typically written in a language such as C or C++. Unmanaged code is compiled to machine code. It is not compiled to IL code.

### 1.12. What is Strongly Typed Language?
- A strongly typed language is a programming language that is more likely to generate errors if data does not closely match an expected type. Strong typing is a feature of many programming languages that enables more secure code by ensuring that data is in the expected format. Strongly typed languages include Java, C, C++, Ada, Delphi, Pascal, Haskell, ML, OCaml, Smalltalk, Swift, Rust, Scala, Common Lisp, Fortran, and Visual Basic .NET.

### 1.13. What is Weakly Typed Language?
- A weakly typed language is a programming language that does not require a variable to be defined as a specific data type. Weak typing allows a variable to be initially assigned one data type and later re-assigned a value of a different type. Weakly typed languages include Perl, JavaScript, Visual Basic, and PHP.

## 2. Basic C# Syntax
### 2.1. What is C#?
- C# (pronounced "C sharp") is a high-level, statically typed, multi-paradigm programming language developed by Microsoft. C# was designed by Anders Hejlsberg, and its development team is currently led by Mads Torgersen. C# is a general-purpose, object-oriented programming language. Its development team is led by Anders Hejlsberg. The most recent version is C# 11.0.

### 2.2. What is C# used for?
- C# is used to develop web apps, desktop apps, mobile apps, games and much more. C# is a general-purpose programming language developed by Microsoft. C# can be used to create various types of applications, such as web, windows, console applications or other types of applications using Visual studio.

### 2.3. What is the difference between C# and .NET?
- C# is a programming language. .NET is a framework. C# is a programming language. .NET is a framework that supports many programming languages. C# is one of the languages that .NET supports. C# is a programming language. .NET is a framework that supports many programming languages. C# is one of the languages that .NET supports.

### 2.4. C# Variables
- A variable is a name given to a storage location that is used to store values of various data types. In C#, all the variables must be declared before use. The declaration of a variable is done by specifying the data type followed by the name of the variable. The syntax of declaring a variable is as follows −
```csharp
<datatype> <variable_name>;
```
- The following example declares a variable named counter of type int −
```csharp
int counter;
```
- The following example declares a variable named counter of type int and initializes it with value 0 −
```csharp
int counter = 0;
```
- The following example declares a variable named counter of type int and initializes it with value 0. The variable is declared as static, which means it is a class variable and not an instance variable −
```csharp
static int counter = 0;
```
- The following example declares a variable named counter of type int and initializes it with value 0. The variable is declared as static, which means it is a class variable and not an instance variable. The variable is also declared as readonly, which means it can be assigned a value only once −
```csharp
static readonly int counter = 0;
```
- The following example declares a variable named counter of type int and initializes it with value 0. The variable is declared as static, which means it is a class variable and not an instance variable. The variable is also declared as readonly, which means it can be assigned a value only once. The variable is also declared as volatile, which means it is a volatile variable −
```csharp
static readonly volatile int counter = 0;
```
- The following example declares a variable named counter of type int and initializes it with value 0. The variable is declared as static, which means it is a class variable and not an instance variable. The variable is also declared as readonly, which means it can be assigned a value only once. The variable is also declared as volatile, which means it is a volatile variable. The variable is also declared as unsafe, which means it is an unsafe variable −
```csharp
static readonly volatile unsafe int counter = 0;
```
- The following example declares a variable named counter of type int and initializes it with value 0. The variable is declared as static, which means it is a class variable and not an instance variable. The variable is also declared as readonly, which means it can be assigned a value only once. The variable is also declared as volatile, which means it is a volatile variable. The variable is also declared as unsafe, which means it is an unsafe variable. The variable is also declared as fixed, which means it is a fixed variable −
```csharp
static readonly volatile unsafe fixed int counter = 0;
```
- The following example declares a variable named counter of type int and initializes it with value 0. The variable is declared as static, which means it is a class variable and not an instance variable. The variable is also declared as readonly, which means it can be assigned a value only once. The variable is also declared as volatile, which means it is a volatile variable. The variable is also declared as unsafe, which means it is an unsafe variable. The variable is also declared as fixed, which means it is a fixed variable. The variable is also declared as extern, which means it is an external variable −
```csharp
static readonly volatile unsafe fixed extern int counter = 0;
```
- The following example declares a variable named counter of type int and initializes it with value 0. The variable is declared as static, which means it is a class variable and not an instance variable. The variable is also declared as readonly, which means it can be assigned a value only once. The variable is also declared as volatile, which means it is a volatile variable. The variable is also declared as unsafe, which means it is an unsafe variable. The variable is also declared as fixed, which means it is a fixed variable. The variable is also declared as extern, which means it is an external variable. The variable is also declared as const, which means it is a constant variable −
```csharp
static readonly volatile unsafe fixed extern const int counter = 0;
```
#### 2.4.1. C# Variable Types
- C# supports the following types of variables −
  - Value types
  - Reference types
  - Pointer types
- The following table lists the variable types −
| Type | Description | Size | Range |
| --- | --- | --- | --- |
| bool | Represents a Boolean value. | 1 byte | True or false |
| byte | Represents an unsigned byte. | 1 byte | 0 to 255 |
| char | Represents a Unicode character. | 2 bytes | U +0000 to U +ffff |
| decimal | Represents a decimal value. | 16 bytes | (+ or -)1.0 x 10e-28 to 7.9 x 10e28 |
| double | Represents a double-precision floating-point value. | 8 bytes | (+ or -)5.0 x 10e-324 to 1.7 x 10e308 |
| float | Represents a single-precision floating-point value. | 4 bytes | -3.4 x 10e38 to + 3.4 x 10e38 |
| int | Represents a signed 32-bit integer. | 4 bytes | -2,147,483,648 to 2,147,483,647 |
| long | Represents a signed 64-bit integer. | 8 bytes | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 |
| sbyte | Represents a signed byte. | 1 byte | -128 to 127 |
| short | Represents a signed 16-bit integer. | 2 bytes | -32,768 to 32,767 |
| uint | Represents an unsigned 32-bit integer. | 4 bytes | 0 to 4,294,967,295 |
| ulong | Represents an unsigned 64-bit integer. | 8 bytes | 0 to 18,446,744,073,709,551,615 |
| ushort | Represents an unsigned 16-bit integer. | 2 bytes | 0 to 65,535 |

#### 2.4.2. C# Value Types
- A value type holds the data within its own memory allocation. It means the variables of these data types directly contain values. The value types directly contain data. Some examples are int, char, and float, which stores numbers, alphabets, and floating point numbers, respectively. When you declare an int type, the system allocates memory to store the value.
- The following example declares a variable named counter of type int and initializes it with value 0 −
```csharp
int counter = 0;
```
#### 2.4.3. C# Reference Types
- A reference type contains a pointer to another memory location that holds the data. Reference types don't store the value directly. Instead, they store the address where the value is being stored. In other words, a reference type contains a pointer to another memory location that holds the data.
- The following example declares a variable named counter of type object and initializes it with value 0 −
```csharp
object counter = 0;
```
#### 2.4.4. C# Pointer Types
- A pointer is a variable that holds the address of another variable. Unlike other variables that hold values of a certain type, pointer holds the address of a variable. For example, an integer variable holds (or you can say stores) an integer value, however an integer pointer holds the address of a integer variable. The pointer variables are declared using * operator. However, the pointer variable must be declared before you can store any variable address in it. The general syntax of a pointer variable declaration is −
```csharp
type *var-name;
```
- Here, type is the pointer's base type; it must be a valid C# type and var-name is the name of the pointer variable. The asterisk * used to declare a pointer is the same asterisk used for multiplication. However, in this statement the asterisk is being used to designate a variable as a pointer. Following are the valid pointer declaration −
```csharp
int    *ip;    /* pointer to an integer */
double *dp;    /* pointer to a double */
float  *fp;    /* pointer to a float */
char   *ch     /* pointer to a character */
```
- The actual data type of the value of all pointers, whether integer, float, character, or otherwise, is the same, a long hexadecimal number that represents a memory address. The only difference between pointers of different data types is the data type of the variable or constant that the pointer points to.

#### 2.4.5. C# Constants
- Constants refer to fixed values that the program may not alter during its execution. These fixed values are also called literals. Constants can be of any of the basic data types like an integer constant, a floating constant, a character constant, or a string literal. There are enumeration constants as well. Constants are treated just like regular variables except that their values cannot be modified after their definition.
- The following example declares a constant named counter of type int and initializes it with value 0 −
```csharp
const int counter = 0;
```
#### 2.4.7. C# Modifiers
- Modifiers are keywords that you add to those definitions to change their meanings. The C# language has the following modifiers −
  - Access Modifiers − default, public, protected, internal, private
  - Non-access Modifiers − abstract, sealed, static, unsafe, virtual, volatile, override
- The following table lists the modifiers −
| Modifier | Description |
| --- | --- |
|default|The default keyword is the default access modifier. If no access modifier is specified for a class, struct, interface, or member, then the default access modifier is used. The default access modifier for classes and structs is internal. The default access modifier for interfaces members is public. |
|public|The public keyword is an access modifier for types and type members. Public access is the most permissive access level. There are no restrictions on accessing public members. |
|protected|The protected keyword is a member access modifier. A protected member is accessible within its class and by derived class instances. |
|internal|The internal keyword is an access modifier for types and type members. Internal types or members are accessible only within files in the same assembly. |
|private|The private keyword is a member access modifier. Private access is the least permissive access level. Private members are accessible only within the body of the class or the struct in which they are declared. |

### 2.5. C# Operators
- Operators are symbols that tell the compiler to perform specific mathematical or logical manipulations. C# language is rich in built-in operators and provides the following types of operators −
  - Arithmetic Operators
  - Relational Operators
  - Logical Operators
  - Bitwise Operators
  - Assignment Operators
  - Misc Operators
- The following table lists the operators supported by the C# language −
| Category | Operator | Description |
| --- | --- | --- |
| Arithmetic Operators | + | Adds two operands |
| | - | Subtracts second operand from the first |
| | * | Multiplies both operands |
| | / | Divides numerator by de-numerator |
| | % | Modulus Operator and remainder of after an integer division |
| | ++ | Increment operator increases integer value by one |
| | -- | Decrement operator decreases integer value by one |
| Relational Operators | == | Checks if the values of two operands are equal or not, if yes then condition becomes true. |
| | != | Checks if the values of two operands are equal or not, if values are not equal then condition becomes true. |
| | > | Checks if the value of left operand is greater than the value of right operand, if yes then condition becomes true. |
| | < | Checks if the value of left operand is less than the value of right operand, if yes then condition becomes true. |
| | >= | Checks if the value of left operand is greater than or equal to the value of right operand, if yes then condition becomes true. |
| | <= | Checks if the value of left operand is less than or equal to the value of right operand, if yes then condition becomes true. |
| Logical Operators | && | Called Logical AND operator. If both the operands are non-zero, then condition becomes true. |
| | \|\| | Called Logical OR Operator. If any of the two operands is non-zero, then condition becomes true. |
| | ! | Called Logical NOT Operator. Use to reverses the logical state of its operand. If a condition is true then Logical NOT operator will make false. |
| Bitwise Operators | & | Binary AND Operator copies a bit to the result if it exists in both operands. |
| | \| | Binary OR Operator copies a bit if it exists in either operand. |
| | ^ | Binary XOR Operator copies the bit if it is set in one operand but not both. |
| | ~ | Binary Ones Complement Operator is unary and has the effect of 'flipping' bits. |
| | << | Binary Left Shift Operator. The left operands value is moved left by the number of bits specified by the right operand. |
| | >> | Binary Right Shift Operator. The left operands value is moved right by the number of bits specified by the right operand. |
| Assignment Operators | = | Simple assignment operator, Assigns values from right side operands to left side operand |
| | += | Add AND assignment operator, It adds right operand to the left operand and assign the result to left operand |
| | -= | Subtract AND assignment operator, It subtracts right operand from the left operand and assign the result to left operand |
| | *= | Multiply AND assignment operator, It multiplies right operand with the left operand and assign the result to left operand |
| | /= | Divide AND assignment operator, It divides left operand with the right operand and assign the result to left operand |
| | %= | Modulus AND assignment operator, It takes modulus using two operands and assign the result to left operand |
| | <<= | Left shift AND assignment operator |
| | >>= | Right shift AND assignment operator |
| | &= | Bitwise AND assignment operator |
| | ^= | bitwise exclusive OR and assignment operator |
| | \|= | bitwise inclusive OR and assignment operator |
| Misc Operators | sizeof | Returns the size of a data type |
| | typeof | Returns the type of a class |
| | & | Returns the address of a variable |

### 2.6. C# Decision Making
- Decision making structures require that the programmer specifies one or more conditions to be evaluated or tested by the program, along with a statement or statements to be executed if the condition is determined to be true, and optionally, other statements to be executed if the condition is determined to be false.

#### 2.6.1. C# if Statement
- An if statement consists of a Boolean expression followed by one or more statements.
- Syntax
```csharp
if(Boolean_expression) {
   /* statement(s) will execute if the Boolean expression is true */
}
```
- If the Boolean expression evaluates to true, then the block of code inside the if statement will be executed. If not, the first set of code after the end of the if statement (after the closing curly brace) will be executed.
- The following example demonstrates the if statement −
```csharp
int x = 10;
if(x < 20) {
   Console.WriteLine("x is less than 20");
}
```
#### 2.6.2. C# if...else Statement
- An if statement can be followed by an optional else statement, which executes when the Boolean expression is false.
- Syntax
```csharp
if(Boolean_expression) {
   /* Executes when the Boolean expression is true */
} else {
   /* Executes when the Boolean expression is false */
}
```
- If the Boolean expression evaluates to true, then the if block of code will be executed, otherwise else block of code will be executed.
- The following example demonstrates the if...else statement −
```csharp
int x = 30;
if(x < 20) {
   Console.WriteLine("x is less than 20");
} else {
   Console.WriteLine("x is greater than 20");
}
```
#### 2.6.3. C# nested if...else Statement
- You can use one if or else if statement inside another if or else if statement(s).
- Syntax
```csharp
if(Boolean_expression 1) {
   /* Executes when the Boolean expression 1 is true */
   if(Boolean_expression 2) {
      /* Executes when the Boolean expression 2 is true */
   }
}
```
- If the Boolean expression 1 evaluates to true, then the block of code inside the if statement will be executed. If Boolean expression 1 evaluates to false, then the first set of code after the end of the if statement (after the closing curly brace) will be executed.
- If Boolean expression 1 evaluates to true and Boolean expression 2 evaluates to false, then the block of code inside the else statement will be executed.
- The following example demonstrates the nested if...else statement −
```csharp
int x = 30;
int y = 10;
if(x == 30) {
   if(y == 10) {
      Console.WriteLine("X = 30 and Y = 10");
   }
}
```
#### 2.6.4. C# switch Statement
- A switch statement allows a variable to be tested for equality against a list of values. Each value is called a case, and the variable being switched on is checked for each case.
- Syntax
```csharp
switch(expression) {
   case constant-expression  :
      statement(s);
      break; /* optional */
   case constant-expression  :
      statement(s);
      break; /* optional */
  
   /* you can have any number of case statements */
   default : /* Optional */
      statement(s);
}
```
- The following rules apply to a switch statement −
  - The expression used in a switch statement must have an integral or enumerated type, or be of a class type in which the class has a single conversion function to an integral or enumerated type.
  - You can have any number of case statements within a switch. Each case is followed by the value to be compared to and a colon.
  - The constant-expression for a case must be the same data type as the variable in the switch, and it must be a constant or a literal.
  - When the variable being switched on is equal to a case, the statements following that case will execute until a break statement is reached.
  - When a break statement is reached, the switch terminates, and the flow of control jumps to the next line following the switch statement.
  - Not every case needs to contain a break. If no break appears, the flow of control will fall through to subsequent cases until a break is reached.
  - A switch statement can have an optional default case, which must appear at the end of the switch. The default case can be used for performing a task when none of the cases is true. No break is needed in the default case.
- The following example demonstrates the switch statement −
```csharp
char grade = 'B';
switch(grade) {
   case 'A' :
      Console.WriteLine("Excellent!");
      break;
   case 'B' :
   case 'C' :
      Console.WriteLine("Well done");
      break;
   case 'D' :
      Console.WriteLine("You passed");
      break;
   case 'F' :
      Console.WriteLine("Better try again");
      break;
   default :
      Console.WriteLine("Invalid grade");
      break;
}
Console.WriteLine("Your grade is  {0}", grade);
```
- When the above code is compiled and executed, it produces the following result −
```csharp
Well done
Your grade is B
```
#### 2.6.5. C# nested switch Statement
- You can use one switch statement inside another switch statement(s).
- Syntax
```csharp
switch(ch1) {
   case 'A':
      Console.WriteLine("This A is part of outer switch");
      switch(ch2) {
         case 'A':
            Console.WriteLine("This A is part of inner switch");
            break;
         case 'B': /* no break statement in this case */
            Console.WriteLine("This B is part of inner switch");
            break;
      }
      break;
   case 'B': /* no break statement in this case */
      Console.WriteLine("This B is part of outer switch");
      break;
}
```

#### 2.6.6. C# if...else if...else Statement
- An if statement can be followed by an optional else if...else statement, which is very useful to test various conditions using single if...else if statement.
- When using if, else if, else statements there are few points to keep in mind −
  - An if can have zero or one else's and it must come after any else if's.
  - An if can have zero to many else if's and they must come before the else.
  - Once an else if succeeds, none of the remaining else if's or else's will be tested.
- Syntax
```csharp
if(Boolean_expression 1) {
   /* Executes when the Boolean expression 1 is true */
} else if( Boolean_expression 2) {
   /* Executes when the Boolean expression 2 is true */
} else if( Boolean_expression 3) {
   /* Executes when the Boolean expression 3 is true */
} else {
   /* Executes when the none of the above condition is true */
}
```
- The following example demonstrates the if...else if...else statement −
```csharp
int x = 30;
if( x == 10 ) {
   Console.WriteLine("Value of x is 10");
} else if( x == 20 ) {
   Console.WriteLine("Value of x is 20");
} else if( x == 30 ) {
   Console.WriteLine("Value of x is 30");
} else {
   Console.WriteLine("None of the values is matching");
}
```
- When the above code is compiled and executed, it produces the following result −
```csharp
Value of x is 30
```

### 2.7. C# Loops
- Loops are used to execute a set of statements repeatedly until a particular condition is satisfied. In programming, loops are used to repeat a block of code until a specified condition is met.
- C# provides following types of loops to handle looping requirements. Click the following links to check their detail.
  - while loop
  - for loop
  - do...while loop
  - nested loops
- The following table lists the loop control statements supported by C# language −
| Control Statement | Description |
| --- | --- |
| break statement | Terminates the loop or switch statement and transfers execution to the statement immediately following the loop or switch. |
| continue statement | Causes the loop to skip the remainder of its body and immediately retest its condition prior to reiterating. |
| goto statement | Transfers control to the labeled statement. NEVER USE|
| return statement | Terminates the execution of a method and returns control to the calling method. |

#### 2.7.1. C# while Loop
- A while loop statement repeatedly executes a target statement as long as a given condition is true.
- Syntax
```csharp
while(condition) {
   statement(s);
}
```
- Here, statement(s) may be a single statement or a block of statements. The condition may be any expression, and true is any nonzero value. The loop iterates while the condition is true.
- When the condition becomes false, program control passes to the line immediately following the loop.
- The following example demonstrates the while loop −
```csharp
int a = 10;
while(a < 15) {
   Console.WriteLine("value of a: {0}", a);
   a++;
}
```
- When the above code is compiled and executed, it produces the following result −
```csharp
value of a: 10
value of a: 11
value of a: 12
value of a: 13
value of a: 14
```
#### 2.7.2. C# for Loop
- A for loop is a repetition control structure that allows you to efficiently write a loop that needs to execute a specific number of times.
- Syntax
```csharp
for(initialization; condition; increment) {
   statement(s);
}
```
- Here is the flow of control in a for loop −
  - The initialization step is executed first, and only once. This step allows you to declare and initialize any loop control variables. You are not required to put a statement here, as long as a semicolon appears.
  - Next, the condition is evaluated. If it is true, the body of the loop is executed. If it is false, the body of the loop does not execute and flow of control jumps to the next statement past the for loop.
  - After the body of the for loop executes, the flow of control jumps back up to the increment statement. This statement allows you to update any loop control variables. This statement can be left blank, as long as a semicolon appears after the condition.
  - The condition is now evaluated again. If it is true, the loop executes and the process repeats itself (body of loop, then increment step, and then again condition). After the condition becomes false, the for loop terminates.
- The following example demonstrates the for loop −
```csharp
for(int a = 10; a < 15; a = a + 1) {
   Console.WriteLine("value of a: {0}", a);
}
```
- When the above code is compiled and executed, it produces the following result −
```csharp
value of a: 10
value of a: 11
value of a: 12
value of a: 13
value of a: 14
```

#### 2.7.3. C# do...while Loop
- A do...while loop is similar to a while loop, except that a do...while loop is guaranteed to execute at least one time.
- Syntax
```csharp
do {
   statement(s);
} while( condition );
```
- Notice that the conditional expression appears at the end of the loop, so the statement(s) in the loop execute once before the condition is tested.
- If the condition is true, the flow of control jumps back up to do, and the statement(s) in the loop execute again. This process repeats until the given condition becomes false.
- The following example demonstrates the do...while loop −
```csharp
int a = 10;
do {
   Console.WriteLine("value of a: {0}", a);
   a = a + 1;
} while(a < 15);
```
- When the above code is compiled and executed, it produces the following result −
```csharp
value of a: 10
value of a: 11
value of a: 12
value of a: 13
value of a: 14
```

#### 2.7.4. C# nested loops
- C# allows to use one loop inside another loop. Following section shows few examples to illustrate the concept.
- Syntax
```csharp
for(initialization; condition; increment) {
   for(initialization; condition; increment) {
      statement(s);
   }
   statement(s);
}
```
- The following example demonstrates the nested loop −
```csharp
for(int a = 1; a <= 3; a++) {
   for(int b = 1; b <= 3; b++) {
      Console.WriteLine("value of a: {0}, value of b: {1}", a, b);
   }
}
```
- When the above code is compiled and executed, it produces the following result −
```csharp
value of a: 1, value of b: 1
value of a: 1, value of b: 2
value of a: 1, value of b: 3
value of a: 2, value of b: 1
value of a: 2, value of b: 2
value of a: 2, value of b: 3
value of a: 3, value of b: 1
value of a: 3, value of b: 2
value of a: 3, value of b: 3
```

### 2.8. C# Arrays
- An array stores a fixed-size sequential collection of elements of the same type. An array is used to store a collection of data, but it is often more useful to think of an array as a collection of variables of the same type.
- Instead of declaring individual variables, such as number0, number1, ..., and number99, you declare one array variable such as numbers and use numbers[0], numbers[1], and ..., numbers[99] to represent individual variables. A specific element in an array is accessed by an index.
- All arrays consist of contiguous memory locations. The lowest address corresponds to the first element and the highest address to the last element.
- The following example declares an array of integers named numbers, initializes the array with three values, and prints the array values to the console −
```csharp
int[] numbers = new int[3];
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[1]);
Console.WriteLine(numbers[2]);
```
- When the above code is compiled and executed, it produces the following result −
```csharp
1
2
3
```
#### 2.8.1. C# Array Types
- C# provides many data types. However, each variable in C# must be a specific type, which determines the size and layout of the variable's memory; the range of values that can be stored within that memory; and the set of operations that can be applied to the variable.
- C# provides the following types of arrays −
  - Single Dimensional Array
  - Multidimensional Array
  - Jagged Array
- The following table lists the important properties of the Array class −
| Property | Description |
| --- | --- |
| IsFixedSize | Gets a value indicating whether the Array has a fixed size. |
| IsReadOnly | Gets a value indicating whether the Array is read-only. |
| Length | Gets a 32-bit integer that represents the total number of elements in all the dimensions of the Array. |
| LongLength | Gets a 64-bit integer that represents the total number of elements in all the dimensions of the Array. |
| Rank | Gets the rank (number of dimensions) of the Array. |
| SyncRoot | Gets an object that can be used to synchronize access to the Array. |

#### 2.8.2. C# Single Dimensional Array
- A single-dimensional array is a sequential list of items. Each item is assigned a unique index value. The following example declares a single-dimensional array of five integers −
```csharp
int[] numbers = new int[5];
```
- The following example declares a single-dimensional array of five integers and initializes the second element in the array with value 10 −
```csharp
int[] numbers = new int[5];
numbers[1] = 10;
```
- The following example declares a single-dimensional array of five integers and initializes the array with values 1, 2, 3, 4, and 5 −
```csharp
int[] numbers = new int[5] {1, 2, 3, 4, 5};
```
- The following example declares a single-dimensional array of five integers and initializes the array with values 1, 2, 3, 4, and 5. The size of the array is determined by the number of values provided between braces and separated by commas −
```csharp
int[] numbers = new int[] {1, 2, 3, 4, 5};
```

#### 2.8.3. C# Multidimensional Array
- A multidimensional array is an array containing one or more arrays. C# supports multidimensional arrays that contain two or three dimensions.
- The following example declares a two-dimensional array of four rows and two columns −
```csharp
int[,] numbers = new int[4, 2];
```
- The following example declares a two-dimensional array of four rows and two columns and initializes the array with the values 1, 2, 3, and 4 −
```csharp
int[,] numbers = new int[4, 2] { {0, 0}, {1, 2}, {2, 4}, {3, 6} };
```
- The following example declares a two-dimensional array of four rows and two columns and initializes the array with the values 1, 2, 3, and 4. The size of the array is determined by the number of values provided between braces and separated by commas −
```csharp
int[,] numbers = new int[,] { {0, 0}, {1, 2}, {2, 4}, {3, 6} };
```

#### 2.8.4. C# Jagged Array
- A jagged array is an array of arrays, and therefore its elements are reference types and are initialized to null. The following example declares a jagged array of three rows and initializes the first row with three integers, the second row with two integers, and the third row with one integer −
```csharp
int[][] numbers = new int[3][];
numbers[0] = new int[3] {1, 2, 3};
numbers[1] = new int[2] {4, 5};
numbers[2] = new int[1] {6};
```

### 2.9. C# Strings
- A string is an object of type String whose value is text. Internally, the text is stored as a sequential read-only collection of Char objects. There is no null-terminating character at the end of a C# string; therefore a C# string can contain any number of embedded null characters ('\0').
- The String class provides members for comparing strings, testing strings for equality, finding characters or substrings in a string, modifying a string, extracting substrings from a string, combining strings, formatting values, copying a string, and normalizing a string.
- C# strings are immutable. This means that once a string is created, it is not possible to modify it. However, you can perform various operation on a string −
  - String Length
  - String Concatenation
  - String Format
  - String Escape Characters
  - Verbatim String
  - String Methods
- The following example demonstrates the various operations on a string −
```csharp

string fname, lname;
fname = "Jane";
lname = "Doe";

string fullname = fname + lname;
Console.WriteLine("Full Name: {0}", fullname);

string fullname2 = string.Concat(fname, lname);
Console.WriteLine("Full Name: {0}", fullname2);

string[] sarray = new string[3];
sarray[0] = "Hello";
sarray[1] = "From";
sarray[2] = "World";

string message = string.Join(" ", sarray);
Console.WriteLine("Message: {0}", message);

### 2.10. C# Structures
- A structure is a value type data type. It helps you to make a single variable hold related data of various data types. The struct keyword is used for creating a structure.
- The following example demonstrates how to use structure in a program −
```csharp

struct Books {
   public string title;
   public string author;
   public string subject;
   public int book_id;
};

   public static void Main(string[] args) {
      Books Book1;   /* Declare Book1 of type Book */
      Books Book2;   /* Declare Book2 of type Book */
 
      /* book 1 specification */
      Book1.title = "C Programming";
      Book1.author = "Nuha Ali"; 
      Book1.subject = "C Programming Tutorial";
      Book1.book_id = 6495407;

      /* book 2 specification */
      Book2.title = "Telecom Billing";
      Book2.author = "Zara Ali";
      Book2.subject =  "Telecom Billing Tutorial";
      Book2.book_id = 6495700;
 
      /* print Book1 info */
      Console.WriteLine( "Book 1 title : {0}", Book1.title);
      Console.WriteLine("Book 1 author : {0}", Book1.author);
      Console.WriteLine("Book 1 subject : {0}", Book1.subject);
      Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

      /* print Book2 info */
      Console.WriteLine("Book 2 title : {0}", Book2.title);
      Console.WriteLine("Book 2 author : {0}", Book2.author);
      Console.WriteLine("Book 2 subject : {0}", Book2.subject);
      Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);
      Console.ReadKey();
   }
```

### 2.11. C# Enums
- An enum is a value type with a set of related named constants often referred to as an enumerator list. The enum keyword is used to declare an enumeration.
- By default, the first enumerator has the value 0, and the value of each successive enumerator is increased by 1.
- The following example shows how to use enums in a program −
```csharp
enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

class Program {
   static void Main(string[] args) {
      int WeekdayStart = (int)Days.Mon;
      int WeekdayEnd = (int)Days.Fri;
      Console.WriteLine("Monday: {0}", WeekdayStart);
      Console.WriteLine("Friday: {0}", WeekdayEnd);
      Console.ReadKey();
   }
}
```

### 2.11.1. C# Enums Flags
- The FlagsAttribute indicates that an enumeration can be treated as a bit field; that is, a set of flags.
- The following example shows how to use enums flags in a program −
```csharp

[Flag]
enum Days { Sun = 1, Mon = 2, Tue = 4, Wed = 8, Thu = 16, Fri = 32, Sat = 64 };

class Program {
   static void Main(string[] args) {
      Days workingDays = Days.Mon | Days.Tue | Days.Wed | Days.Thu | Days.Fri;
      Console.WriteLine(workingDays);
      Console.ReadKey();
   }
}
```

### 2.12. C# Preprocessors
- The C# preprocessor directives are used to provide additional information to the compiler to help in compilation of the code. The compiler directives begin with # symbol. The C# preprocessor does not have a separate preprocessor, but the directives are processed as if there was one.
- The following table lists the preprocessor directives −
| Directive | Description |
| --- | --- |
| #define | Defines a sequence of characters, called symbol. |
| #undef | Undefines a symbol. |
| #if | Evaluates a symbol or symbols. |
| #else | Specifies an alternative for #if directive. |
| #elif | Specifies a new condition if the previous condition was false. |
| #endif | Specifies the end of #if directive. |
| #line | Lets you modify the compiler's line number and (optionally) the file name output for errors and warnings. |
| #error | Generates a compiler error when the specified conditional directive evaluates to true. |
| #warning | Generates a compiler warning when the specified conditional directive evaluates to true. |
| #region | Lets you specify a block of code that you can expand or collapse when using the outlining feature of the Visual Studio Code Editor. |
| #endregion | Marks the end of a #region block. |

### 2.13. C# Namespaces
- Namespaces are used to organize your program into a hierarchy of logical groups. The using keyword is used for including the namespaces in the program. The namespaces in C# are used to organize too many classes so that it can be easy to handle the application.
- The following example demonstrates how to use namespaces in a program −
```csharp
using System;

namespace first_space {
   class namespace_cl {
      public void func() {
         Console.WriteLine("Inside first_space");
      }
   }
}

namespace second_space {
   class namespace_cl {
      public void func() {
         Console.WriteLine("Inside second_space");
      }
   }
}

class TestClass {
   static void Main(string[] args) {
      first_space.namespace_cl fc = new first_space.namespace_cl();
      second_space.namespace_cl sc = new second_space.namespace_cl();
      fc.func();
      sc.func();
      Console.ReadKey();
   }
}
```

### 2.14. C# Functions
- A function is a group of statements that together perform a task. Every C# program has at least one function, which is Main(), and all the most trivial programs can define additional functions.
- You can divide up your code into separate functions. How you divide up your code among different functions is up to you, but logically the division usually is such that each function performs a specific task.
- A function declaration tells the compiler about a function's name, return type, and parameters. A function definition provides the actual body of the function.
- The C# standard library provides numerous built-in functions that your program can call. For example, function Console.WriteLine() to print a message on the console.
- To use a function, you will have to call that function to perform the defined task.
- Following is the syntax to define a function in C# −
```csharp
return_type function_name( parameter list ) {
   body of the function
}
```

#### 2.14.1. C# Function Parameters
- Parameters are used to pass values or variable references to methods. The parameters are declared in the method declaration. The parameters are always passed by value. However, if you want to pass a parameter by reference, then you need to use the ref keyword.
- The following example demonstrates how to use parameters in a function −
```csharp
using System;

namespace CalculatorApplication {
    public static void Add(int a, int b) 
    {
        int sum = a + b;
        Console.WriteLine("Sum of {0} and {1} is {2}", a, b, sum);
        Console.ReadKey();
    }

    public static void Main(string[] args)
    {
        int a = 10;
        int b = 20;
        Add(a, b);
    }
}
```

#### 2.14.2. C# Function Return Values
- A function can return a value to the class that called it. You use the return keyword for this purpose. The type of value that your function returns must match the return type of the function as declared in the function definition.
- The following example demonstrates how to use return values in a function −
```csharp
using System;

namespace CalculatorApplication {
    public static int Add(int a, int b) 
    {
        int sum = a + b;
        return sum;
    }

    public static void Main(string[] args)
    {
        int a = 10;
        int b = 20;
        int sum = Add(a, b);
        Console.WriteLine("Sum of {0} and {1} is {2}", a, b, sum);
        Console.ReadKey();
    }
}
```

#### 2.14.3. C# Function Scope
- The scope of a variable is the part of the program that can refer to that variable by name. Variables declared inside a function are not accessible from outside the function. Hence, they have a local scope.
- The following example demonstrates how to use scope in a function −
```csharp
using System;

namespace CalculatorApplication {
    public static void Add(int a, int b) 
    {
        int sum = a + b;
        Console.WriteLine("Sum of {0} and {1} is {2}", a, b, sum);
        Console.ReadKey();
    }

    public static void Main(string[] args)
    {
        int a = 10;
        int b = 20;
        Add(a, b);
        Console.WriteLine("Sum of {0} and {1} is {2}", a, b, sum);
    }
}
```

#### 2.14.4. C# Function Recursion
- Recursion is the process of repeating items in a self-similar way. In programming languages, if a program allows you to call a function inside the same function, then it is called a recursive call of the function.
- The following example demonstrates how to use recursion in a function −
```csharp
using System;

namespace CalculatorApplication {
    public static int factorial(int num) 
    {
        /* local variable declaration */
        int result;

        if (num == 1) 
        {
            return 1;
        }
        else 
        {
            result = factorial(num - 1) * num;
            return result;
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(factorial(6));
        Console.WriteLine(factorial(7));
        Console.WriteLine(factorial(8));
        Console.ReadKey();
    }
}
```

#### 2.14.5. C# Function Optional Parameters
- C# allows you to assign default values to function parameters. If the function is called without passing value for these parameters, the default value gets assigned to the parameter.
- The following example demonstrates how to use optional parameters in a function −
```csharp
using System;

namespace CalculatorApplication {
    public static int Add(int a = 1, int b = 2) 
    {
        int sum = a + b;
        return sum;
    }

    public static void Main(string[] args)
    {
        int sum = Add(10, 20);
        Console.WriteLine("Sum: {0}", sum);
        Console.ReadKey();
    }
}
```

#### 2.14.6. C# Function Named Arguments
- C# allows you to pass arguments to a function in a named form. While calling the function, you can specify the argument name along with the value. This way, you can make the arguments to function more meaningful.
- The following example demonstrates how to use named arguments in a function −
```csharp
using System;

namespace CalculatorApplication {
    public static int Add(int num1, int num2) 
    {
        int sum = num1 + num2;
        return sum;
    }

    public static void Main(string[] args)
    {
        int sum = Add(num2: 20, num1: 10);
        Console.WriteLine("Sum: {0}", sum);
        Console.ReadKey();
    }
}
```

#### 2.14.7. C# Function Overloading
- C# allows you to define two or more functions with the same name, but with different parameters. This concept is known as function overloading and is quite useful in many situations.
- The following example demonstrates how to use function overloading in a program −
```csharp
using System;

namespace CalculatorApplication {
    public static int Add(int num1, int num2) 
    {
        return num1 + num2;
    }

    public static int Add(int num1, int num2, int num3) 
    {
        return num1 + num2 + num3;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Add(10, 20));
        Console.WriteLine(Add(10, 20, 30));
        Console.ReadKey();
    }
}
```

#### 2.14.8. C# Function Params
- C# allows you to pass a variable number of arguments to a function. The params keyword is used to specify a parameter array which allows you to pass an arbitrary number of arguments to a function.
- The following example demonstrates how to use params in a function −
```csharp
using System;

namespace CalculatorApplication {
    public static int Add(params int[] arr) 
    {
        int sum = 0;
        foreach (int i in arr) 
        {
            sum += i;
        }
        return sum;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Add(1, 2, 3, 4, 5));
        Console.WriteLine(Add(10, 20, 30));
        Console.ReadKey();
    }
}
```

#### 2.14.9. C# Function ref Keyword
- C# allows you to pass a variable by reference to a function. The ref keyword is used for this purpose. The ref keyword passes the reference of a variable in the memory to the function.
- The following example demonstrates how to use ref in a function −
```csharp
using System;

namespace CalculatorApplication {
    public static void Swap(ref int x, ref int y) 
    {
        int temp;

        temp = x;
        x = y;
        y = temp;
    }

    public static void Main(string[] args)
    {
        int a = 100;
        int b = 200;

        Console.WriteLine("Before swap, value of a : {0}", a);
        Console.WriteLine("Before swap, value of b : {0}", b);

        Swap(ref a, ref b);

        Console.WriteLine("After swap, value of a : {0}", a);
        Console.WriteLine("After swap, value of b : {0}", b);

        Console.ReadKey();
    }
}
```

#### 2.14.10. C# Function out Keyword
- C# allows you to return a value through a parameter of the function. The out keyword is used for this purpose. The out keyword passes the reference of a variable in the memory to the function.
- The following example demonstrates how to use out in a function −
```csharp
using System;

namespace CalculatorApplication {
    public static void getValue(out int x) 
    {
        int temp = 5;
        x = temp;
    }

    public static void Main(string[] args)
    {
        int a = 100;

        Console.WriteLine("Before method call, value of a : {0}", a);
        getValue(out a);
        Console.WriteLine("After method call, value of a : {0}", a);

        Console.ReadKey();
    }
}
```

#### 2.14.11. C# Function In Keyword
- C# allows you to pass a variable by reference to a function. The in keyword is used for this purpose. The in keyword passes the reference of a variable in the memory to the function.
- The following example demonstrates how to use in in a function −
```csharp
using System;

namespace CalculatorApplication {
    public static void getValue(in int x) 
    {
        Console.WriteLine("Value of x: {0}", x);
    }

    public static void Main(string[] args)
    {
        int a = 100;

        Console.WriteLine("Before method call, value of a : {0}", a);
        getValue(in a);
        Console.WriteLine("After method call, value of a : {0}", a);

        Console.ReadKey();
    }
}
```

#### 2.14.12. C# Function Delegates
- A delegate is a type that represents references to methods with a particular parameter list and return type. When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type.
- You can invoke (or call) the method through the delegate instance.
- Delegates are used to pass methods as arguments to other methods. Event handlers are nothing more than methods that are invoked through delegates. You create a custom method, and a class such as a windows control can call your method when a certain event occurs. The following example demonstrates how to use delegates in a program −
```csharp
using System;

namespace CalculatorApplication {
    public delegate int NumberChanger(int n);

    class TestDelegate {
        static int num = 10;

        public static int AddNum(int p) 
        {
            num += p;
            return num;
        }

        public static int MultNum(int q) 
        {
            num *= q;
            return num;
        }

        public static int getNum() 
        {
            return num;
        }

        public static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
    }
}
```

#### 2.14.13. C# Function Anonymous Methods
- Anonymous methods are the methods without a name, just the body. The anonymous methods can be assigned to a delegate variable of compatible signature.
- The following example demonstrates how to use anonymous methods in a program −
```csharp
using System;

namespace CalculatorApplication {
    public delegate void Print(int value);

    class TestDelegate {
        static void Main(string[] args)
        {
            // Print delegate points to PrintNumber
            Print printDel = PrintNumber;

            printDel(100000);
            printDel(200);

            // Print delegate points to PrintMoney
            printDel = PrintMoney;

            printDel(10000);
            printDel(20000);

            Console.ReadKey();
        }

        public static void PrintNumber(int num) 
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money) 
        {
            Console.WriteLine("Money: {0:C}", money);
        }
    }
}
```

#### 2.14.14. C# Operator Overloading
- C# allows you to specify the meaning of operators when applied to instances of a class or struct. This ability is called operator overloading. Operator overloading is syntactic sugar for a function call.
- The following example demonstrates how to use operator overloading in a program −
```csharp
using System;

public static int operator +(int a, int b) 
{
    return a + b;
}

class TestOperator {
    static void Main(string[] args)
    {
        int a = 10;
        int b = 20;
        int c;

        c = a + b;
        Console.WriteLine("c = {0}", c);
        Console.ReadKey();
    }
}
```

#### 2.14.15. C# Function Extension Methods
- C# allows you to add methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type. This process is called extending a type.
- The following example demonstrates how to use extension methods in a program −
```csharp
using System;

namespace ExtensionMethodApplication {
    public static class MyExtension {
        public static int Sub(this int i, int j) 
        {
            return i - j;
        }
    }

    class ExtensionDemo {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 15;
            int k = i.Sub(j);
            Console.WriteLine("i - j = {0}", k);
            Console.ReadKey();
        }
    }
}
```

#### 2.14.16. C# Function Lambda Expressions
- Lambda expressions are anonymous functions. These functions are mostly used as arguments to other functions. The lambda expression is mostly used to create delegates in LINQ.
- The following example demonstrates how to use lambda expressions in a program −
```csharp
using System;

namespace LambdaExpressionApplication {
    class Test {
        static void Main(string[] args)
        {
            // lambda expression
            Func<int, int> square = x => x * x;

            // invoke delegate and print the output
            Console.WriteLine(square(5));
            Console.ReadKey();
        }
    }
}
```

#### 2.14.17. C# Events
- An event is a notification sent by an object to signal the occurrence of an action. The action could be caused by user interaction, such as a mouse click, or it could be triggered by some other program logic.
- The object that raises the event is called the event sender. The event sender doesn't know which object or method will receive (handle) the events it raises. The event is typically a member of the event sender; for example, the Click event is a member of the Button class, and the PropertyChanged event is a member of the Employee class.
- The following example demonstrates how to use events in a program −
```csharp
using System;

namespace CalculatorApplication {
    public delegate string MyDel(string str);

    class EventProgram {
        event MyDel MyEvent;

        public EventProgram() 
        {
            this.MyEvent += new MyDel(this.WelcomeUser);
        }

        public string WelcomeUser(string username) 
        {
            return "Welcome " + username;
        }

        static void Main(string[] args)
        {
            EventProgram obj1 = new EventProgram();
            string result = obj1.MyEvent("Tutorials Point");
            Console.WriteLine(result);
        }
    }
}
```

### 2.15. C# Nullable Types
- C# provides a special data types, the nullable types, to which you can assign normal range of values as well as null values.
- For example, you can store any value from -2,147,483,648 to 2,147,483,647 or null in a Nullable<Int32> variable.
- The following example demonstrates how to use nullable types in a program −
```csharp
using System;

namespace CalculatorApplication {
    class NullablesAtShow {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 45;

            double? num3 = new double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            // display the values
            Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}",
                num1, num2, num3, num4);
            Console.WriteLine("A Nullable boolean value: {0}", boolval);
            Console.ReadLine();
        }
    }
}
```

### 2.16. C# Dynamic Types
- C# provides another data type called dynamic type. The dynamic type variables are similar to object type variables. The difference between object and dynamic types is that the object type variables are resolved at compile time, whereas the dynamic type variables are resolved at run time.

#### 2.16.1. C# Dynamic Type Variables

- The dynamic type variables are declared with the keyword dynamic. The following example demonstrates how to use dynamic type variables in a program −
```csharp

using System;

namespace CalculatorApplication {
    class DynamicTest {
        static void Main(string[] args)
        {
            dynamic d = 20;   // d is dynamic type
            Console.WriteLine(d);
            Console.WriteLine(d.GetType());

            d = "A string here";   // d is still dynamic type
            Console.WriteLine(d);
            Console.WriteLine(d.GetType());

            Console.ReadKey();
        }
    }
}
```

### 2.17. C# var Keyword
- The var keyword instructs the compiler to infer the type of the variable from the expression on the right side of the initialization statement. The inferred type may be a built-in type, an anonymous type, a user-defined type, or a type defined in the .NET Framework class library.
- The following example demonstrates how to use var keyword in a program −
```csharp
using System;

namespace CalculatorApplication {
    class VarTest {
        static void Main(string[] args)
        {
            var i = 5;
            var s = "Hello World";
            Console.WriteLine("i: {0}, s: {1}", i, s);
        }
    }
}
```

### 2.18. C# Constants
- Constants are expressions with a fixed value. Constants can be of any of the basic data types like an integer constant, a floating constant, a character constant, or a string literal. There are enumeration constants as well.
- Constants are treated just like regular variables except that their values cannot be modified after their definition.
- The following example demonstrates how to use constants in a program −
```csharp
using System;

namespace CalculatorApplication {
    class Program {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            double r;
            Console.WriteLine("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            Console.ReadLine();
        }
    }
}
```

### 2.19 C# Statics
- The static keyword is used to declare a static member. If we declare a static member, it belongs to the type itself rather than to a specific object. It means that only one instance of a static member exists, even if you create multiple instances of the class. It will be shared by all objects.
- The following example demonstrates how to use statics in a program −
```csharp
using System;

namespace CalculatorApplication {
    class StaticVar {
        public static int num;
        public void count() 
        {
            num++;
        }
        public int getNum() 
        {
            return num;
        }
    }

    class StaticTester {
        static void Main(string[] args)
        {
            StaticVar s = new StaticVar();
            s.count();
            s.count();
            s.count();
            Console.WriteLine("Variable num: {0}", s.getNum());
            Console.ReadKey();
        }
    }
}
```


## 3. C# Basic Syntax
- C# is a case-sensitive, strongly-typed language. The following table lists the keywords that are reserved by C#. These reserved keywords may not be used as identifiers in your program unless they include @ as a prefix. For example, @if is a valid identifier, but if is not because if is a keyword.

| abstract | as | base | bool | break | byte | case | catch | char | checked | class | const | continue | decimal | default | delegate | do | double | else | enum | event | explicit | extern | false | finally | fixed | float | for | foreach | goto | if | implicit | in | int | interface | internal | is | lock | long | namespace | new | null | object | operator | out | override | params | private | protected | public | readonly | ref | return | sbyte | sealed | short | sizeof | stackalloc | static | string | struct | switch | this | throw | true | try | typeof | uint | ulong | unchecked | unsafe | ushort | using | virtual | void | volatile | while |

### 3.1. C# Identifiers
- A C# identifier is a name used to identify a class, variable, function, or any other user-defined item. An identifier starts with a letter A to Z or a to z or an underscore (_) followed by zero or more letters, underscores, and digits (0 to 9).
- C# does not allow punctuation characters such as @, $, and % within identifiers. C# is a case-sensitive programming language. Thus, Manpower and manpower are two different identifiers in C#.
- Here are some examples of acceptable identifiers −
```csharp
mohd       zara    abc   move_name  a_123
myname50   _temp   j     a23b9      retVal
```

### 3.2. C# Keywords
- The following list shows the reserved words in C#. These reserved words may not be used as constant or variable or any other identifier names.
```csharp
abstract   as         base       bool       break      byte
case       catch      char       checked    class      const
continue   decimal    default    delegate   do         double
else       enum       event      explicit   extern     false
finally    fixed      float      for        foreach    goto
if         implicit   in         int        interface  internal
is         lock       long       namespace  new        null
object     operator   out        override   params     private
protected  public     readonly   ref        return     sbyte
sealed     short      sizeof     stackalloc static     string
struct     switch     this       throw      true       try
typeof     uint       ulong      unchecked  unsafe     ushort
using      virtual    void       volatile   while
```

### 3.3. C# Literals
- A literal is a source code representation of a fixed value. They are represented directly in the code without any computation.
- Literals can be assigned to any numeric type. Some literals have suffixes that specify the type of the literal. The following table shows examples of literals −
| Literal | Type | Example |
| --- | --- | --- |
| Integer | int | 0, 117, -345, 12345 |
| Floating-point | double | 0.0, -117.76, 14.56e12 |
| Boolean | bool | true, false |
| Character | char | 'A', '\x0041', '\u0041' |
| String | string | "Hello, World!" |
| Object | object | null |

### 3.4. C# Comments
- Comments are used to include additional information about the code, such as a description of the method, its purpose etc. It is also used to prevent the execution of certain lines of code.
- C# supports single-line and multi-line comments. All characters available inside any comment are ignored by C# compiler.
- The following example shows how to use comments in C# −
```csharp
using System;

namespace HelloWorldApplication {
   class HelloWorld {
      static void Main(string[] args) {
         /* my first program in C# */
         Console.WriteLine("Hello World");
         Console.ReadKey();
      }
   }
}
```

## 4. C# Classes and Objects
- C# is an object-oriented programming language. In Object-Oriented Programming methodology, a program consists of various objects that interact with each other by means of actions. The actions that an object may take are called methods. Objects of the same kind are said to have the same type or, more often, are said to be in the same class.
- The process of creating an object from a class is called instantiation. You can create as many objects as you need of a particular class. An object is also called an instance of a class and the process of creating this object is called instantiation.

### 4.1. C# Classes
- A class is a user-defined blueprint or prototype from which objects are created. It represents the set of properties or methods that are common to all objects of one type.

#### 4.1.1. Declaring Classes
- Classes are declared by using the class keyword followed by a unique identifier, as shown in the following example −
```csharp
class ClassName {
   // class members
}
```

#### 4.1.2. Class Members
- A class can contain any of the following members −
  - Fields
  - Constructors
  - Destructors
  - Constants
  - Properties
  - Indexers
  - Methods
  - Operators
  - Events
  - Nested Types

#### 4.1.3. Creating Objects
- When a class is defined, only the specification for the object is defined; no memory or storage is allocated. To use the data and access functions defined in the class, you need to create objects.
- An object is also called an instance of a class and the process of creating this object is called instantiation.
- When an object of a class is created, the class is said to be instantiated. All the instances share the attributes and the behavior of the class. But the values of those attributes, i.e. the state are unique for each object. A single class may have any number of instances.
- The following example demonstrates how to create an object of class Employee −
```csharp
Employee Object1 = new Employee();
```

#### 4.1.4. new Keyword
- The new keyword is used to create an object of a class. When you create an object, you are creating an instance of a class, therefore "instantiating" a class.
- The new operator instantiates a class by allocating memory for a new object and returning a reference to that memory. This reference is then stored in the variable.
- The following statements are equivalent −
```csharp
Object1 = new Employee();
Object2 = new Employee();
```

#### 4.1.5. Accessing Attributes

Cont...


<sub><sup>Prepared with the help of CoPilot</sup></sub>