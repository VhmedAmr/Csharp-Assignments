namespace Advanced3;

class Program
{
    static void Main(string[] args)
    {
        Exercise1 exercise1 = new Exercise1();
        exercise1.PrintGrades();
        exercise1.CountGradesList();
        exercise1.FirstAndLastGrade();
        exercise1.SortedGrades();
        exercise1.FindGrade();
        exercise1.FindAllGrades();
        exercise1.RemoveFailures();
        exercise1.GradesCheck();
        exercise1.StringList();
        
        Exercise2 exercise2 = new Exercise2();
        exercise2.Ex2();
        
        Exercise3 exercise3 = new Exercise3();
        exercise3.Ex3();
        
        Exercise4 exercise4 = new Exercise4();
        exercise4.Ex4();
        
        Exercise5 exercise5 = new Exercise5();
        exercise5.Ex5();
        
        Exercise6 exercise6 = new Exercise6();
        exercise6.Ex6();
    }
}