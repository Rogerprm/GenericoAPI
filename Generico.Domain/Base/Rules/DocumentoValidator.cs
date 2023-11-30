using FluentValidation;
using Generico.Domain.Base.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Generico.Domain.Base.Rules
{
    public class DocumentoValidator : AbstractValidator<CpfCnpj>
    {
        // Regex patterns for CPF and CNPJ validation
        private const string CPFPattern = @"^\d{3}\.\d{3}\.\d{3}-\d{2}$";
        private const string CNPJPattern = @"^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$";

        public DocumentoValidator()
        {
            RuleFor(x => x.Valor)
               .NotEmpty()
               .Must(BeADocumentValid).WithMessage("O Documento deve ser....");
        }


        private bool BeADocumentValid(string document) => 
            Regex.IsMatch(document, CPFPattern) && IsValidCPF(document) ||
            Regex.IsMatch(document, CNPJPattern) && IsValidCNPJ(document);


        private bool IsValidCPF(string cpf)
        {
            //validacoes
            return true;
        }

        private bool IsValidCNPJ(string cnpj)
        {
            //validacoes
            return true;
        }
    }
}
