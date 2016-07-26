namespace Bridge
{
    public class Milk : TaxableProduct
    {
        public Milk(decimal taxableAmount, ITax tax) : base(tax)
        {
            Name = nameof(Milk);
            TaxableAmount = taxableAmount;
        }

        public override decimal CalculateTax() => IsLocal ? 0 : _tax.CalculateTax(TaxableAmount);

        public bool IsLocal { get; set; } = true;
    }
}