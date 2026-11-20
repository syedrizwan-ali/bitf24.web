namespace FCIT.BITF24A.Web.DiPractice_01
{
    public class ApplePay : IPaymentMethod
    {
        public string Pay(int amount)
        {
            return "Apple Pay deducted Rs." + amount;
        }
    }
}
