using System;
using System.Text.RegularExpressions;
using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Infra.Helpers;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
  public class Document: ValueObject
  {
    public Document(string number, EDocumentType documentType)
    {
      Number = number;
      DocumentType = documentType;

      AddNotifications(new Contract()
      .Requires()
      .IsTrue(IsValid(), "Document.Number", "Documento inválido!")
      );
    }

    public string Number { get; private set; }
    public EDocumentType DocumentType { get; private set; }


    public override string ToString()
    {
      return $"O número do documento é {Number}";
    }

    public bool IsValid()
    {
      if (DocumentType == EDocumentType.CNPJ)      
        return Validation.IsCnpj(Number);  
     
      return Validation.IsCpf(Number);
    }
  }
}