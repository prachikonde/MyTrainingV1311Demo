namespace MyTrainingV1311Demo.MultiTenancy.Payments.Stripe.Dto
{
    public class StripePaymentResultOutput
    {
        public bool PaymentDone { get; set; }
        
        public string CallbackUrl { get; set; }
    }
}
