﻿using MediatR;
using Pizza4Ps.PizzaService.Application.Abstractions.BaseCommand;
using Pizza4Ps.PizzaService.Application.Abstractions.Commands;

namespace Pizza4Ps.PizzaService.Application.UserCases.V1.Product.Commands.SoftDeleteProduct
{
    public class RestoreProductCommand : BaseRestoreCommand<Guid>, IRequest
    {
        public List<Guid> Ids { get; set; }
    }
}
