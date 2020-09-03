using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
  public class Name: ValueObject
  {
    public Name(string firstName, string lastName)
    {
      FirstName = firstName;
      LastName = lastName;

      AddNotifications(new Contract()
      .Requires()
      .HasMinLen(FirstName, 3 ,"Name.FirstName",  "Nome deve conter ao menos três caracteres")
      .HasMinLen(LastName, 3 ,"Name.LastName",    "Sobernome deve conter ao menos três caracteres")
      .HasMaxLen(LastName, 40 ,"Name.LastName",   "Sobrenome não deve conter mais do que quarenta caracteres")
      .HasMaxLen(FirstName, 40 ,"Name.FirstName", "Nome não deve conter mais do que quarenta caracteres")
      );
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }


    public override string ToString()
    {
      return $"{FirstName} {LastName}";
    }

    public bool IsValid()
    {
        return true;
    }


  }
}