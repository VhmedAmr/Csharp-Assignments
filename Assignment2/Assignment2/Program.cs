namespace Assignment2;

class Program
{
    static void Main(string[] args)
    {
        #region Q1
        //Q1
        double d = 9.99;
        int x = (int)d; //9
        Console.WriteLine(x);
        // it will print 9 because you made an explicit type casting from double into int
        #endregion
        
        #region Q2
        int n = 5;
        double d2 = (double)n / 2;
        Console.WriteLine(d2);
        #endregion

        #region Q3

        Console.WriteLine("Type your age?");
        int Age =  int.Parse(Console.ReadLine());

        #endregion
        
        #region Q4  
        
        //string s = "12a";
        //int y = int.Parse(s);
        //Console.WriteLine(y);
        
        //it will through an exception because you are converting string into int
        
        #endregion
        
        #region Q5
            
        //changed the variables letters to not make errors
            string s = "12";
            bool y = int.TryParse(s, out int result);
            Console.WriteLine(y);
            if (y == true)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        
        #endregion

        #region  Q6

        object o = 10;
        int a = (int)o;
        Console.WriteLine(a + 1);

        // it will print 11 but this will cause unboxin and its not preferred to use
        #endregion

        #region Q7

        try
        {
            object c = 10;
            long v = (long)c;
            Console.WriteLine(v);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error");
        }
        
        // it will cause error because when you unbox a variable you need to cast it 
        // to the same data type as it is boxed to, here the 10 is int and you are
        // trying to cast it into long so it will cause an error

        #endregion

        #region Q8

        try
        {
            object b = 10;
            int i = (int)b;
            Console.WriteLine(i);
        }
        catch (Exception e)
        {
            Console.WriteLine(-1);
        }
        

        #endregion

        #region Q9

        string? name = null;
        Console.WriteLine(name?.Length);
        
        //it will print null because the name is null and you are trying to reach its length
        //normally it will throw and error but you had added a null operator to prevent this
        #endregion

        #region Q10

        string? name2 = null;
        int length = name2?.Length ?? 0;
        // it will print 0 
        //first it will assign name2 with null
        // then it will assign length with name2 value if name2 is not null,
        // and if name2 = null it will assign length with 0
        // so here name2 = null so length will print 0
        #endregion

        #region Q11
        //string? s = null;
        //int x = int.Parse(s ?? "0");
        //Console.WriteLine(x);

        string? u = null;
        int resultt;
        if (!int.TryParse(u, out int p))
        {
            resultt = 0;
        }
        else
        {
            resultt = p;
        }
        
        //the original code have some logical errors but it will run succefully but try to add a wrong string
        //and it will throw an error
        //so the code i typed is more safe
        
        
        #endregion

        #region Q12

        //string? ss = null;
        //Console.WriteLine(ss!.Length);
        // by adding ! you are telling the compiler to be mute if there is an error
        // so now there is an error to fix it just add ? instead of the !
        
        string? ss = null;
        Console.WriteLine(ss?.Length);

        #endregion

        #region Q13

        string? s2 = null;
        int x2 = Convert.ToInt32(s2);
        Console.WriteLine(x2);
        // it will print 0 because convert function check for null first if there is it turns it into 0
        #endregion

        #region Q14

        //string? s = null;
        // A
        // int a = int.Parse(s);
        // B
        //int b = Convert.ToInt32(s);
        //Console.WriteLine(b);
        
        // in A it will throw an Error because parse dosn't treat null like convert function
        // so it cant convert null into numbers
        // but Convert method checks for nulls when it see null it give the variable a value of 0
        // instead of throwing errors

        #endregion

        #region Q15

        string? user = null;
        string printingName = user?.ToUpper() ?? "Guest";
        Console.WriteLine(printingName);

        #endregion
    }
}