namespace FCIT.BITF24A.Web.DiPractice_01
{
    public class EasyPaisa : IPaymentMethod
    {
        public string Pay(int amount)
        {
            return "EasyPaisa deducted Rs." + amount;
        }
    }
}
