using GameStore.Domain.Concrete;
using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;

namespace GameStore.Domain.Concrete
{
    public class PaymentOrderProcessor : IPaymentProcessor
    {
        private EmailSettings emailSettings;

        public PaymentOrderProcessor(EmailSettings settings)
        {
            emailSettings = settings;
        }


        public void PaymentOrder(Cart cart, ShippingDetails shippingInfo)
        {
            int a = 5;
            int b = a - 4;
        }
    }
}
