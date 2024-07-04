namespace MyTrainingV1311Demo.MultiTenancy.Payments.Dto
{
    public class CancelPaymentDto
    {
        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}