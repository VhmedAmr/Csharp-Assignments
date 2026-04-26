namespace Advanced1;

class Program
{
    static void Main(string[] args)
    {
        //Answers below
    }

#region Q1: What is a generic class? Why use generics?
/* * A generic class is a blueprint that allows you to define a class with placeholders (type parameters) 
 * for the data types it stores or uses. 
 * Why use them?
 * 1. Type Safety: Catch type errors at compile-time rather than runtime.
 * 2. Reusability: Write code once and use it with any data type.
 * 3. Performance: Avoids boxing/unboxing overhead when using value types.
 */
#endregion

#region Q2: Write a generic class Container<T> with Add and Get methods.
public class Container<T>
{
    private T _item;
    public void Add(T item) => _item = item;
    public T Get() => _item;
}
#endregion

#region Q3: What are multiple type parameters? Write Pair<TKey, TValue>.
/* Multiple type parameters allow a generic type to handle more than one flexible type at once. */
public class Pair<TKey, TValue>
{
    public TKey Key { get; set; }
    public TValue Value { get; set; }
}
#endregion

#region Q4: What is a generic method? Write Swap<T> method.
/* A generic method is a method declared with type parameters, independent of whether the class is generic. */
public class Utils
{
    public static void Swap<T>(ref T lhs, ref T rhs)
    {
        T temp = lhs;
        lhs = rhs;
        rhs = temp;
    }
}
#endregion

#region Q5: Write a generic method FindMax<T> that finds maximum value.
public class MathUtils
{
    public static T FindMax<T>(T val1, T val2) where T : IComparable<T>
    {
        return val1.CompareTo(val2) > 0 ? val1 : val2;
    }
}
#endregion

#region Q6: What is a generic interface? Write IRepository<T>.
public interface IRepository<T>
{
    void Add(T entity);
    T GetById(int id);
    IEnumerable<T> GetAll();
}
#endregion

#region Q7: What is the 'struct' constraint? Write an example.
/* The 'struct' constraint limits the type argument to non-nullable value types. */
public class ValueHolder<T> where T : struct
{
    public T Data { get; set; }
}
#endregion

#region Q8: What is the 'class' constraint? Write an example.
/* The 'class' constraint limits the type argument to reference types. */
public class ReferenceHolder<T> where T : class
{
    public T Data { get; set; }
}
#endregion

#region Q9: What is the 'new()' constraint? Write an example.
/* Specifies that a type argument must have a public parameterless constructor. */
public class Factory<T> where T : new()
{
    public T CreateInstance() => new T();
}
#endregion

#region Q10: What is the interface constraint? Write an example.
public class Processor<T> where T : IDisposable
{
    public void CleanUp(T item) => item.Dispose();
}
#endregion

#region Q11: What is the base class constraint? Write an example.
public class BaseEntity { public int Id { get; set; } }
public class EntityHandler<T> where T : BaseEntity 
{
    public int GetId(T entity) => entity.Id;
}
#endregion

#region Q12: How do you apply multiple constraints? Write an example.
public class AdvancedContainer<T> where T : class, IComparable<T>, new()
{
    // T must be a reference type, implement IComparable, and have a parameterless constructor
}
#endregion

#region Q13: What does the 'default' keyword do in generics?
/* It returns the default value of a type: 'null' for reference types and '0' for value types. */
#endregion

#region Q14: Write a SafeList<T> that returns default when the index is invalid.
public class SafeList<T>
{
    private List<T> _items = new List<T>();
    public T GetItem(int index)
    {
        if (index < 0 || index >= _items.Count) return default(T);
        return _items[index];
    }
}
#endregion

#region Q15: What is covariance? Explain the 'out' keyword.
/* Covariance allows using a more derived type than specified. 'out' marks type as output only. */
public interface ICovariant<out T> { T Get(); }
#endregion

#region Q16: What is contravariance? Explain the 'in' keyword.
/* Contravariance allows using a more generic type than specified. 'in' marks type as input only. */
public interface IContravariant<in T> { void Set(T item); }
#endregion

#region Q17: What is the difference between covariance and contravariance?
/* * Covariance (out): Generic<Derived> -> Generic<Base>. (Return types)
 * Contravariance (in): Generic<Base> -> Generic<Derived>. (Parameters)
 */
#endregion

#region Q18: How do static members work in generic types?
/* Static fields are unique to each closed type (e.g., MyClass<int> vs MyClass<string>). */
#endregion

#region Q19: How can you inherit from a generic class?
public class SpecializedContainer : Container<int> { } // Inheritance with fixed type
#endregion

#region Q20: Complete Exercise - Create a generic Cache<TKey, TValue>
public class CacheItem<TValue>
{
    public TValue Value { get; set; }
    public DateTime Expiry { get; set; }
}

public class Cache<TKey, TValue>
{
    private readonly Dictionary<TKey, CacheItem<TValue>> _store = new();

    public void Add(TKey key, TValue value, TimeSpan lifespan)
    {
        _store[key] = new CacheItem<TValue> 
        { 
            Value = value, 
            Expiry = DateTime.Now.Add(lifespan) 
        };
    }

    public TValue Get(TKey key)
    {
        if (Contains(key)) return _store[key].Value;
        return default;
    }

    public bool Contains(TKey key)
    {
        if (!_store.ContainsKey(key)) return false;
        if (DateTime.Now > _store[key].Expiry)
        {
            _store.Remove(key);
            return false;
        }
        return true;
    }

    public void Remove(TKey key) => _store.Remove(key);
}
#endregion
    
}