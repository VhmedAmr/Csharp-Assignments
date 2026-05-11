namespace Advanced3;

public class Exercise4
{
    HashSet<string> EmailValidator = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

    public void Ex4()
    {
        EmailValidator.Add("ahmed@test.com");
        EmailValidator.Add("AHMED@test.com");
        EmailValidator.Add("sara@test.com");
        EmailValidator.Add("Sara@Test.Com");
        
        Console.WriteLine($"{EmailValidator.Count} email addresses, because hashset doesn't allow duplicates, and now it ignores Capitalization");
        Console.WriteLine($"Stored Emails: {string.Join(", ", EmailValidator)}");
        
        HashSet<int> setA = [1, 2, 3, 4, 5];
        HashSet<int> setB = [4, 5, 6, 7, 8];

        Console.WriteLine($"Set A: {{ {string.Join(", ", setA)} }}");
        Console.WriteLine($"Set B: {{ {string.Join(", ", setB)} }}\n");
        
        
        HashSet<int> unionSet = new HashSet<int>(setA);
        unionSet.UnionWith(setB);
        Console.WriteLine($"UnionWith (A + B): {{ {string.Join(", ", unionSet)} }}");
        
        HashSet<int> intersectSet = new HashSet<int>(setA);
        intersectSet.IntersectWith(setB);
        Console.WriteLine($"IntersectWith (A & B): {{ {string.Join(", ", intersectSet)} }}");
        
        HashSet<int> exceptSet = new HashSet<int>(setA);
        exceptSet.ExceptWith(setB);
        Console.WriteLine($"ExceptWith (A - B): {{ {string.Join(", ", exceptSet)} }}\n");
        
        HashSet<int> checkSet = [1, 2];
        bool isSubset = checkSet.IsSubsetOf(setA);
        Console.WriteLine($"Is {{1, 2}} a subset of Set A? {isSubset}");
    }
}