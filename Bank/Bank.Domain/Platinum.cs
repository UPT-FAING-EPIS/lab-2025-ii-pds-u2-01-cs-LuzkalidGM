namespace Bank.Domain
{
    /// <summary>
    /// Representa una tarjeta de crédito Platinum.
    /// </summary>
    public class Platinum : ICreditCard
    {
        /// <summary>
        /// Obtiene el tipo de tarjeta.
        /// </summary>
        /// <returns>El tipo de tarjeta como cadena.</returns>
        public string GetCardType()
        {
            return "Platinum Plus";
        }

        /// <summary>
        /// Obtiene el límite de crédito de la tarjeta.
        /// </summary>
        /// <returns>El límite de crédito.</returns>
        public int GetCreditLimit()
        {
            return 35000;
        }

        /// <summary>
        /// Obtiene el cargo anual de la tarjeta.
        /// </summary>
        /// <returns>El cargo anual.</returns>
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
}