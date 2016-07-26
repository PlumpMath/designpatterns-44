namespace Bridge
{
    public interface ITax
    {
        string Name { get; }
        decimal CalculateTax(decimal taxableAmount);
    }
}