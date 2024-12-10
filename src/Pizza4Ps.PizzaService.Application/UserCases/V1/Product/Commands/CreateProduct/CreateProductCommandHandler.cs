﻿using AutoMapper;
using MediatR;
using Pizza4Ps.PizzaService.Application.UserCases.V1.Product.Commands.Create;
using Pizza4Ps.PizzaService.Domain.Abstractions.Services;
using Pizza4Ps.PizzaService.Domain.Services;

namespace Pizza4Ps.PizzaService.Application.UserCases.V1.Product.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;

        public CreateProductCommandHandler(IMapper mapper
            , IProductService productService)
        {
            _mapper = mapper;
            _productService = productService;
        }

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var result = await _productService.CreateAsync(request.Name, request.Price, request.Description, request.CategoryId);
            return new CreateProductCommandResponse
            {
                Id = result
            };
        }
    }
}
