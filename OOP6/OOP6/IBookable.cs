namespace OOP6;

public interface IBookable
{
    public bool IsBooked { get; }
    void Book();
    void Cancel();
}