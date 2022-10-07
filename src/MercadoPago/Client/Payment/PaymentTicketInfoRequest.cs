namespace MercadoPago.Client.Payment
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Payment's ticket info.
    /// </summary>
    public class PaymentTicketInfoRequest
    {

        /// <summary>
        /// Discounts.
        /// </summary>
        public IList<PaymentDiscountRequest> Discounts { get; set; }

        /// <summary>
        /// Fine.
        /// </summary>
        public PaymentFeeRequest Fine { get; set; }

        /// <summary>
        /// Interest.
        /// </summary>
        public PaymentFeeRequest Interest { get; set; }
    }
}