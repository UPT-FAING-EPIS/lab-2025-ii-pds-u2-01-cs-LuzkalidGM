namespace Bank.Domain
{
    /// <summary>
    /// Fábrica para crear instancias de tarjetas de crédito basadas en el tipo.
    /// </summary>
    public class CreditCardFactory
    {
        /// <summary>
        /// Obtiene una tarjeta de crédito basada en el tipo especificado.
        /// </summary>
        /// <param name="cardType">El tipo de tarjeta de crédito.</param>
        /// <returns>Una instancia de ICreditCard.</returns>
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard? cardDetails = null;
            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }
            return cardDetails;
        }
    }
}