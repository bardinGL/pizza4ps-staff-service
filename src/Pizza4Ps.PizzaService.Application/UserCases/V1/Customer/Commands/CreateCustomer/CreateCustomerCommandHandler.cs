﻿using MediatR;
using Pizza4Ps.PizzaService.Domain.Abstractions.Services;

namespace Pizza4Ps.PizzaService.Application.UserCases.V1.Customer.Commands.CreateCustomer
{
	public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, CreateCustomerCommandResponse>
	{
		private readonly ICustomerService _customerService;

		public CreateCustomerCommandHandler(ICustomerService customerService)
		{
			_customerService = customerService;
		}

		public async Task<CreateCustomerCommandResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
		{
			var result = await _customerService.CreateAsync(request.FullName, request.Phone);
			return new CreateCustomerCommandResponse
			{
				Id = result
			};
		}
	}
}
