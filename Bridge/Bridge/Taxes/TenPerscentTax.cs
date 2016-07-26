namespace Bridge
{
    public class TenPerscentTax : ITax
    {
        public string Name { get; private set; }
        public TenPerscentTax()
        {
            Name = nameof(TenPerscentTax);
        }

        public decimal CalculateTax(decimal taxableAmount)
        {
            return taxableAmount * 0.1m;
        }
    }
}