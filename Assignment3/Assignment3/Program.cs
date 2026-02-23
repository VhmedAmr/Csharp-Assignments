using System.Text;
using System.Diagnostics;

namespace Assignment3;

class Program
{
    static void Main(string[] args)
    {
        #region Q1
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        string productList = "";
        for (int i = 0; i <= 5000; i++)
        {
            productList += "PROD-" + i + ",";
        }
        
        stopwatch.Stop();
        Console.WriteLine(stopwatch.Elapsed);
        // A - Using normal string will cause creating 5000 new object inside the heap
        // and when editing on them for any reason will create another objects
        
        // B -
        stopwatch.Restart();
        StringBuilder productListBuilder = new StringBuilder();
        for (int i = 0; i <= 5000; i++)
        {
            productListBuilder.Append("PROD-");
            productListBuilder.Append(i);
            productListBuilder.Append(",");
        }
        stopwatch.Stop();
        Console.WriteLine(stopwatch.Elapsed);
        
        // C- Added stop watch to print the difference
        #endregion
        
        #region Q2

        decimal _price = 0;
        int age = 0;
        int day = 7;
        bool std = true;
        if (age < 5)
        {
            _price = 0;
        }
        else if (age >= 5 && age <= 12)
        {
            _price = 30;
        }
        else if (age >= 13 && age <= 59)
        {
            _price = 50;
        }
        else
        {
            _price = 25;
        }

        if ((day == 7 || day == 1) && _price != 0)
        {
            _price = _price + 10;
        }
        if (std && _price != 0)
        {
            _price = _price - (0.20m * _price);
        }
        Console.WriteLine(_price);
        #endregion
        
        #region Q3

        string fileExtension = ".pdf";
        string fileType;

        switch (fileExtension)
        {
            case ".pdf":
                fileType = "PDF Document";
                break;
            case ".docx": 
            case ".doc":
                fileType = "Word Document";
                break;
            case ".xlsx":
            case ".xls":
                fileType = "Excel Spreadsheet";
                break;
            case ".jpg":
            case ".png":
            case ".gif":
                fileType = "Image File";
                break;
            default:
                fileType = "Unkown File Type";
                break;
        }
        
        fileType = fileExtension switch
        {
            ".pdf" => "PDF Document",
            ".docx" or ".doc" => "Word Document",
            ".xlsx" or ".xls" => "Excel Spreadsheet",
            ".jpg" or ".png" or ".gif" => "Image File",
            _ => "Unknown File Type"
        };

        #endregion
        
        #region Q4

        int temprature = 35;
        string weatherAdvice;
        
        weatherAdvice = 
            (temprature < 0) ? "Freezing!" : 
                (temprature < 15) ? "Cold." : 
                    (temprature < 25) ? "Pleasant" :
                        (temprature < 35) ? "Warm" : "Hot";
        Console.WriteLine(weatherAdvice);
        
        // No its less readable, i can choose it only in simple if conditions
        
        #endregion
        
        #region Q5
        
        string _password = "";
        bool hasUpperCase = false;
        bool isValid = true;
        if (_password != "")
        {
            if (_password.Length < 8)
            {
                Console.WriteLine("Password should be 8 characters at least");
            }
            else
            {
                foreach (var charachter in _password)
                {
                    if (charachter == ' ')
                    {
                        Console.WriteLine("No Spaces Allowed");
                        isValid = false;
                    }
                    else
                    {
                        if (char.IsUpper(charachter))
                        {
                            hasUpperCase = true;
                        }
                    }
                }

                if (hasUpperCase && isValid)
                {
                    Console.WriteLine("ALLOWED PASSWORD VERIFIED");
                }
                else if (!hasUpperCase)
                {
                    Console.WriteLine("You need at least one uppercase character");
                }
            }
            
        }
        else
        {
            Console.WriteLine("Please enter a password!");
        }
        
        #endregion
    }
}