namespace Assignment5;

class Program
{
    static void Main(string[] args)
    {
        // part one questions are answered down
        // part two questions are answered across the whole solution
        Console.WriteLine("Enter Movie Name:");
        string mName = Console.ReadLine();
        Console.WriteLine("Enter Ticket Type:");
        string tType = Console.ReadLine();
        Console.WriteLine("Choose Seat-Row (A,B,C,D,...):");
        char sRow = char.Parse(Console.ReadLine());
        Console.WriteLine("Choose Seat-Number (1,2,3,4,...):");
        int sNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Price:");
        double tPrice = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Discount Amount:");
        double tDiscount = double.Parse(Console.ReadLine());
        
        Ticket ticket = new Ticket(mName,
            (TicketType)Enum.Parse(typeof(TicketType), tType),
            new SeatLocation{SeatRow =  sRow,SeatNumber = sNum},
            tPrice);

        Ticket ticket2 = new Ticket("SuperMan");
        
        ticket.PrintTicket(14, tDiscount);
    }
    
    #region Part1

        #region Q1-StructVsClass
        //here is an example of class with fields and methods
        internal class ExClass
        {
            private int x = 12;
            public int y = 13;

            public int calc(int x, int y)
            {
                return x + y;
            }
            //Class is a reference type
            //Class stores its data in heap
            //Class used for complex uses
        }
                
        //here is an example of a struct
        internal struct ExStruct
        {
            private int x;
            private int y;
                    
            //Struct is a value type
            //Struct stores its data in stack
            //Struct used for simple uses
        }

        #endregion

        #region Q2-PublicVsPrivate

            //Public Access Modifier
            //it can be Accessed any where in the program
            //Ex:
            public int publicVar;

            public void publicMethod()
            {
                publicVar = 1;
            }
            
            //Private Access Modifier
            //it can't be Accessed anwhere except the class or scope its defiened within
            //Ex:
            private int privateVar;

            private void privateMethod()
            {
                privateVar = 2;
            }

        #endregion

        #region Q3-CreateClassLib
        
        //in vs code click create new project then choose class library
        // add the name and everything
        // you need to add the namespace 
        // call the namespace in the console app that have the main method

        #endregion

        #region Q4-WhatAndWhyClassLib
        
        //we use class library to not create alot of classes that have the same
        //date, instead of that we create a class library that holds the redundant
        //data and call its namespace inside every class we need to use our data 
        //indside

        #endregion
        
    #endregion
}