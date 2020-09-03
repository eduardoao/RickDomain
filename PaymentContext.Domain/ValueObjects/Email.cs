using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
  public class Email: ValueObject
  {
    public Email(string email)
    {
      EmailAddress = email;  

      AddNotifications(new Contract()
      .Requires()
      .IsEmail(EmailAddress, "Email.Address", "Campo e-mail está inválido!"));   
    }

    public string EmailAddress { get; private set; }   


    public override string ToString()
    {
      return $"{EmailAddress}";
    }

    public bool IsValid()
    {
        return true;
    }

  }
}