namespace Bridge
{
    public class OnePercentTax : ITax
    {
        public string Name { get; private set; }
        public OnePercentTax()
        {
            Name = nameof(OnePercentTax);
        }

        public decimal CalculateTax(decimal taxableAmount)
        {
            return taxableAmount * 0.01m;
        }
    }
}