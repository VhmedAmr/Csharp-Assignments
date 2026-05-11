namespace Advanced3;

public class Exercise1
{
    public static List<int> Grades = [85, 92, 78, 95, 88, 70, 100, 65];
    public void PrintGrades()
    {
        foreach (var grade in Grades)
        {
            Console.WriteLine(grade);
        }
    }

    public void CountGradesList()
    {
        int Count = Grades.Count;
        Console.WriteLine(Count);
    }
    
    public void FirstAndLastGrade()
    {
        Console.WriteLine(Grades[0]);
        Console.WriteLine(Grades[7]);
    }

    public void SortedGrades()
    {
        Grades.Sort();
        Console.WriteLine($"sorted in asc : {string.Join(", ", Grades)}");
        
    }

    public void FindGrade()
    {
        int grade = Grades.Find(x => x > 90);
        Console.WriteLine(grade);
    }
    
    public void FindAllGrades()
    {
        List<int> grades = Grades.FindAll(x => x < 75);
        Console.WriteLine(String.Join(", ", grades));
    }

    public void RemoveFailures()
    {
        Grades.RemoveAll(x => x < 75);
        Console.WriteLine($"After Removing Failures: {String.Join(", ", Grades)}");
    }

    public void GradesCheck()
    {
        bool check = Grades.Contains(100);
        Console.WriteLine(check);
    }

    public void StringList()
    {
        List<string> GradesString = new();
        foreach (var grade in Grades)
        {
            string gradeString = "Grade " + grade;
            GradesString.Add(gradeString);
        }
        Console.WriteLine(String.Join(", ", GradesString));
    }

}