namespace Bank.Domain
{
    /// <summary>
    /// Fábrica para crear instancias de tarjetas Titanium.
    /// </summary>
    public class TitaniumFactoryMethod : CreditCardFactoryMethod
    {
        /// <summary>
        /// Crea una instancia de una tarjeta Titanium.
        /// </summary>
        /// <returns>Una instancia de ICreditCard.</returns>
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Titanium();
            return product;
        }
    }
}