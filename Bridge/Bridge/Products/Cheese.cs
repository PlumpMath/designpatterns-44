namespace Bridge
{
    public class Cheese : TaxableProduct
    {
        public Cheese(decimal taxableAmount, ITax tax) : base(tax)
        {
            Name = nameof(Cheese);
            TaxableAmount = taxableAmount;
        }

        public override decimal CalculateTax() => IsSmelly ? _tax.CalculateTax(TaxableAmount) : 0;

        public bool IsSmelly { get; set; } = true;
    }
}