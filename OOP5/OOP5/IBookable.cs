namespace OOP5;

public interface IBookable
{
    public bool IsBooked { get; }
    void Book();
    void Cancel();
}