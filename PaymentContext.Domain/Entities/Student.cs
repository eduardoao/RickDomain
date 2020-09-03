using System.Collections.Generic;
using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
  public class Student: Entity
  {
    private List<Subscription> _subscriptions;
    public Name Name { get; private set; }
    public Document Document { get; private set; }
    public string Owner { get; set; }
    public Email Email { get; private set; }
    public string Address { get; set; }
    public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

    //Unique entrance point
    public Student(Name name, Document document, Email email)
    {

      Name = name;
      Document = document;
      Email = email;
      _subscriptions = new List<Subscription>();
    }

    public void AddSubscription(Subscription subscription)
    {
      var hasSubScriptionActive = false;

      foreach (var subscriptionItem in Subscriptions)
      {
        if (subscriptionItem.IsActive == true)
          hasSubScriptionActive = false;      
      }

      AddNotifications(new Contract()
      .Requires()
      .IsFalse(hasSubScriptionActive, "Student.Subscriptions", "Existe assinatura ativa")
      );
    }
  }
}