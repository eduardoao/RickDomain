using System;
using System.Diagnostics;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
  public class CrediCardPayment : Payment
  {
    public CrediCardPayment(string cardHolderName,
                            string cardLastNumber,
                            string lAstTransactionNumber,
                            DateTime paidDate,
                            DateTime expireDate,
                            decimal total,
                            decimal totalPaid,
                            string payer,
                            Document document,
                            Address address,
                            Email email) :base(
                              paidDate,
                              expireDate, 
                              total,
                              totalPaid,
                              payer,
                              document,
                              address,
                              email)
    {
      CardHolderName = cardHolderName;
      CardLastNumber = cardLastNumber;
      LAstTransactionNumber = lAstTransactionNumber;
    }

    public string CardHolderName { get; set; }
    public string CardLastNumber { get; set; }
    public string LAstTransactionNumber { get; set; }

    private string GetDebuggerDisplay()
    {
      return ToString();
    }
  }
}