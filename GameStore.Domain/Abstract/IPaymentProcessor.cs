using GameStore.Domain.Entities;

namespace GameStore.Domain.Abstract
{
    public interface IPaymentProcessor
    {
        void PaymentOrder(Cart cart, ShippingDetails shippingDetails);// оплата товара
    }
}
