using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace DevIO.Business.Models.Produtos.Validations
{
    class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(x => x.Nome)
                 .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                 .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(x => x.Descrição)
                 .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                 .Length(2, 1000).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(x => x.Valor)
                .GreaterThan(0)
                .WithMessage("O campo {PropertyName} precisa ser maior que {ComparisonVaue}");

        }
    }
}
