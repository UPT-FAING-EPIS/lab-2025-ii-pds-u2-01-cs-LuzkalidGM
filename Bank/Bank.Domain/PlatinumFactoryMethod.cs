namespace Bank.Domain
{
    /// <summary>
    /// Fábrica para crear instancias de tarjetas Platinum.
    /// </summary>
    public class PlatinumFactoryMethod: CreditCardFactoryMethod
    {
        /// <summary>
        /// Crea una instancia de una tarjeta Platinum.
        /// </summary>
        /// <returns>Una instancia de ICreditCard.</returns>
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Platinum();
            return product;
        }
    }
}