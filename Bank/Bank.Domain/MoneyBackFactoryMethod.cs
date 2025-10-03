namespace Bank.Domain
{
    /// <summary>
    /// Fábrica para crear instancias de tarjetas MoneyBack.
    /// </summary>
    public class MoneyBackFactoryMethod : CreditCardFactoryMethod
    {
        /// <summary>
        /// Crea una instancia de una tarjeta MoneyBack.
        /// </summary>
        /// <returns>Una instancia de ICreditCard.</returns>
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new MoneyBack();
            return product;
        }
    }
}