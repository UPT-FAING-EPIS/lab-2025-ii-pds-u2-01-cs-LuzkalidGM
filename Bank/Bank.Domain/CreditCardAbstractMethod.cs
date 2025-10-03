namespace Bank.Domain
{
    /// <summary>
    /// Clase abstracta que define el método de fábrica para crear tarjetas de crédito.
    /// </summary>
    public abstract class CreditCardFactoryMethod
    {
        /// <summary>
        /// Método protegido que debe ser implementado para crear un producto.
        /// </summary>
        /// <returns>Una instancia de ICreditCard.</returns>
        protected abstract ICreditCard MakeProduct();

        /// <summary>
        /// Crea un producto utilizando el método de fábrica.
        /// </summary>
        /// <returns>Una instancia de ICreditCard.</returns>
        public ICreditCard CreateProduct()
        {
            ICreditCard creditCard = this.MakeProduct();
            return creditCard;
        }
    }
}