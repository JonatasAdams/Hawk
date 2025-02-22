﻿using FluentValidation;
using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hawk.Validator
{
    public class EstoqueValidator : AbstractValidator<Estoque>
    {
        public EstoqueValidator()
        {
            RuleFor(x => x.ProdutoId)
                .NotEmpty()
                .WithMessage("Selecione um produto ");

            RuleFor(x => x.Quantidade)
                .NotEmpty()
                .WithMessage("Informe a quantidae");

        }
    }
}
