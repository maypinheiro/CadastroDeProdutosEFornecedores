using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace DevIO.Business.Models.Fornecedores.Validacoes
{
    class FornecedorValidation : AbstractValidator<Fornecedor>
    {
        // Instalamos o Fluent
        //Install-Package FluentValidation -Version 9.2.2

        public FornecedorValidation()
        {
            RuleFor(f => f.Nome).NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2,200)
                .WithMessage("O campo {PropertyName} precisa ter entre{MinLength} e {MaxLength} caracteres");
        }

    }
}
