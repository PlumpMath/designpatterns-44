namespace Bridge
{
    public abstract class TaxableProduct
    {
        protected readonly ITax _tax;
        public string Name { get; protected set; }
        public decimal TaxableAmount { get; protected set; }

        public TaxableProduct(ITax tax)
        {
            _tax = tax;
        }

        abstract public decimal CalculateTax();
    }
}