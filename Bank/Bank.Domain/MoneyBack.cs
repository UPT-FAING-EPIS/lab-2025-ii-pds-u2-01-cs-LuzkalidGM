namespace Bank.Domain
{
    /// <summary>
    /// Representa una tarjeta de crédito MoneyBack.
    /// </summary>
    public class MoneyBack : ICreditCard
    {
        /// <summary>
        /// Obtiene el tipo de tarjeta.
        /// </summary>
        /// <returns>El tipo de tarjeta como cadena.</returns>
        public string GetCardType()
        {
            return "MoneyBack";
        }

        /// <summary>
        /// Obtiene el límite de crédito de la tarjeta.
        /// </summary>
        /// <returns>El límite de crédito.</returns>
        public int GetCreditLimit()
        {
            return 15000;
        }

        /// <summary>
        /// Obtiene el cargo anual de la tarjeta.
        /// </summary>
        /// <returns>El cargo anual.</returns>
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}