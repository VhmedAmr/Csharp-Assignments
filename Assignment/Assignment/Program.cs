using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAssignment
{
    class Program
    {
        // Class-level field for scope demonstrations
        static int classField = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║           C# FUNDAMENTALS - ASSIGNMENT WITH ANSWERS                ║");
            Console.WriteLine("║                      20 Questions                                  ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════╝\n");



            #region Question 1: Regions

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 2: REGIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the purpose of #region and #endregion directives in C#? 
            //    How do they help in code organization?
            //
            // ══════════════════════════════════════════════════════════════════════

            // it helps in organizing the code but it doesn't affect the code in compiling, it adds a
            // titles to each part of the code to enhance readability

            #endregion

            #region Question 2: Variable Declaration - Explicit vs Implicit

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 3: VARIABLE DECLARATION - EXPLICIT VS IMPLICIT
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between explicit and implicit variable 
            //    declaration in C#? Provide examples of both.
            //
            // ══════════════════════════════════════════════════════════════════════



            // EXPLICIT DECLARATION 
            // they are the variables that i tell the compiler which type it is
            int number = 15;
            string firstName = "Ahmed";

            // IMPLICIT DECLARATION 
            // they are the variables that i dont tell the compiler the exact type of the variable
            var lastName = "Amr";
            var age = 22;

            #endregion

            #region Question 3: Constants

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CONSTANTS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write the syntax for declaring a constant in C#. Why would you use 
            //    a constant instead of a regular variable?
            //
            // ══════════════════════════════════════════════════════════════════════



            // Constant examples
            const double pi = 3.14;
            // we use it to declare a syntax that will never be changed while using the program

            #endregion

            #region Question 4: Class-level vs Method-level Scope

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CLASS-LEVEL VS METHOD-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the difference between class-level scope and method-level 
            //    scope with examples.
            //
            // ══════════════════════════════════════════════════════════════════════

            int test = 12; // this is a field inside the class level scope

            static void Func()
            {
                int test = 20; // this is the same var but in a Method-Level scope
            }

            #endregion

            #region Question 5: Block-level Scope

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 5: BLOCK-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is block-level scope? Give an example showing a variable that 
            //    is only accessible within a specific block.
            //
            // ══════════════════════════════════════════════════════════════════════

            // a block-level like in for loop or if condition
            if (1 > 0)
            {
                int x = 10;
                Console.WriteLine(x);
            }

            // x = 20;  ERROR because its defined inside the if condition block

            #endregion

            #region Question 6: Variable Lifetime - Local vs Static

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 6: VARIABLE LIFETIME - LOCAL VS STATIC
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable lifetime? Explain the lifetime of local variables 
            //    vs static variables.
            //
            // ══════════════════════════════════════════════════════════════════════

            // Local variables can be assigned and declared inside a method
            // its life time till the close of the method
            int testLocal = 10;

            // static variables life time is till the end of the program
            // and it should be declared out side of any method even the main one
            // static int testStatic = 10;  ERROR


            #endregion

            #region Question 7: Garbage Collector

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 7: GARBAGE COLLECTOR
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the Garbage Collector in C#? How does it affect the 
            //    lifetime of objects?
            //
            // ══════════════════════════════════════════════════════════════════════

            // the garbage collector is a tool to release the memory (Heap) without manual handling

            #endregion

            #region Question 8: Variable Shadowing

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 8: VARIABLE SHADOWING
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable shadowing in C#? Does C# allow shadowing in 
            //    nested blocks within the same method?
            //
            // ══════════════════════════════════════════════════════════════════════


            //     it means when declaring a variable with a desired name outside a scope and then redeclaring the
            //     same variable inside another scope

            int testShadow = 10;

            static void Shadowing()
            {
                int testShadow = 20;
            }

            #endregion

            #region Question 9: C# Naming Rules

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 9: C# NAMING RULES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List five rules that must be followed when naming variables in C#.
            //
            // ══════════════════════════════════════════════════════════════════════

            // 1) Use camelCase Method
            // 2) Don's start with characters like #$%^&*
            // 3) You can use Numbers 
            // 4) You can use letters
            // 5) You can use UnderScores

            #endregion

            #region Question 10: Naming Conventions

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 10: NAMING CONVENTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What naming conventions are recommended for: (a) local variables, 
            //    (b) class names, (c) constants?
            //
            // ══════════════════════════════════════════════════════════════════════

            // a) camelCase
            // b) PascalCase
            // c) PascalCase

            #endregion

            #region Question 11: Error Types

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 11: ERROR TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Compare and contrast syntax errors, runtime errors, and logical 
            //    errors. Provide an example of each.
            //
            // ══════════════════════════════════════════════════════════════════════

            // Syntax errors is like compiler errors they are the errors that the compiler detects before building
            // EX : forgetting a semicolon ;

            // Runtime Errors are the errors that through exceptions after running the compiler
            // EX : Deviding by Zero

            // Logical Errors is the errors in the strucure it seld it doesn't give errors but it
            // doesn't achieve the idea you want
            // EX : Wrong compare or assign

            #endregion

            #region Question 12: Exception Handling Importance

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 12: EXCEPTION HANDLING IMPORTANCE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is exception handling important in C#? What would happen if 
            //    you don't handle exceptions?
            //
            // ══════════════════════════════════════════════════════════════════════

            // Exception handling is very important it catches the error and provide the user a good handeled
            // error preferred as you want, if not handeled it will crash the program with an unhandeled
            // and unexpected error code

            #endregion

            #region Question 13: try-catch-finally

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 13: TRY-CATCH-FINALLY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example demonstrating try-catch-finally. Explain when 
            //    the finally block executes.
            //
            // ══════════════════════════════════════════════════════════════════════

            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(DateTime.Now); // Executes even when there is no exception or even with exception
            }

            #endregion

            #region Question 14: Common Built-in Exceptions

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 14: COMMON BUILT-IN EXCEPTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List and explain five common built-in exceptions in C# with 
            //    scenarios when each would occur.
            //
            // ══════════════════════════════════════════════════════════════════════

            // 1) NullReferenceException
            // 2) FormatException
            // 3) DivideByZeroException
            // 4) IndexOutOfRangeException
            // 5) ArgumentNullException

            #endregion

            #region Question 15: Multiple catch Blocks

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 15: MULTIPLE CATCH BLOCKS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is the order of catch blocks important when handling multiple 
            //    exceptions? Write code showing correct ordering.
            //
            // ══════════════════════════════════════════════════════════════════════

            try
            {
                throw new Exception();
            }
            catch (FormatException)
            {
                Console.WriteLine("Not the expected Format");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't devide by 0");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null Not handeled");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            #endregion

            #region Question 16: throw Keyword

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 16: THROW KEYWORD
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between 'throw' and 'throw ex' when 
            //    re-throwing an exception? Which one preserves the stack trace?
            //
            // ══════════════════════════════════════════════════════════════════════

            //   throw creates an exception from the beginning of the error and throw it to be handeled
            //   with keeping the stack trace

            //   throw ex creates a new exception while not considering the first errors so it dumbs the stack trace

            #endregion

            #region Question 17: Stack and Heap Memory

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 17: STACK AND HEAP MEMORY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the differences between Stack and Heap memory in C#. 
            //    What types of data are stored in each?
            //
            // ══════════════════════════════════════════════════════════════════════

            // The stack keeps its variables data inside the Stack memory
            // EX : variables with int, double, float (Value Types)

            // The heap keeps pointer of the data inside the Heap memory and keeps only the Address inside the stack 
            // EX : variables which is originally a Class like string, and Classes etc.. (Reference Types)

            #endregion

            #region Question 18: Value Types vs Reference Types

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 18: VALUE TYPES VS REFERENCE TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example showing how value types and reference types 
            //    behave differently when assigned to another variable.
            //
            // ══════════════════════════════════════════════════════════════════════

            // Idea : changing in value type Variables doesn't change after bieng assigned to another variable
            //        but changing in reference type Variables does change in the both variables ecause it points
            //        to an address of the old variable not holding data like in value type Variables

            int y = 10;
            Console.WriteLine("Old Y : ", y); //10
            int z = y;
            Console.WriteLine("Old z : ", z); //10
            y++;
            Console.WriteLine(y); //11
            Console.WriteLine(z); // still 10

            string Name = "Ahmed";
            string secondName = Name; //points the same address as Name
            Console.WriteLine("Old Name : ", Name); // prints Ahmed
            Console.WriteLine("Old secondName : ", secondName); // prints Ahmed too
            Name = "Amr";
            Console.WriteLine("New Name : ", Name); // Now it prints Amr
            Console.WriteLine("New secondName : ",
                secondName); // Now it prints Amr too because it points to the same changed Address


            #endregion

            #region Question 19: Object in C#

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 19: OBJECT IN C#
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is 'object' considered the base type of all types in C#? 
            //    What methods does every type inherit from System.Object?
            //
            // ══════════════════════════════════════════════════════════════════════

            // because every single element created in c# it inherits from object class
            // Ex Methods : Equals(), GetHashCode() ...


            #endregion


            // #endregion
        }

    }
}