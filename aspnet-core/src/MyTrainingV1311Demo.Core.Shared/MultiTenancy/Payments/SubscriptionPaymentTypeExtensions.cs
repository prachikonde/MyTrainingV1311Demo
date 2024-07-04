namespace MyTrainingV1311Demo.MultiTenancy.Payments
{
    public static class SubscriptionPaymentTypeExtensions
    {
        public static bool IsRecurring(this SubscriptionPaymentType subscriptionPaymentType)
        {
            return subscriptionPaymentType != SubscriptionPaymentType.Manual;
        }
    }
}