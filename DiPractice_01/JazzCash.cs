namespace FCIT.BITF24A.Web.DiPractice_01
{
    public class JazzCash : IPaymentMethod
    {
        public string Pay(int amount)
        {
            return "Jazz Cash deducted Rs." + amount;
        }
    }
}
