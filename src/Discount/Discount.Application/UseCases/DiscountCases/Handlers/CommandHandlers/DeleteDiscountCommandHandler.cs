using Discount.Application.Abstractions;
using Discount.Application.UseCases.DiscountCases.Commands;
using Discount.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Application.UseCases.DiscountCases.Handlers.CommandHandlers
{
    public class DeleteDiscountCommandHandler : IRequestHandler<DeleteDiscountCommand, ResponseModel>
    {
        private readonly IDiscountDbContext _context;

        public DeleteDiscountCommandHandler(IDiscountDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(DeleteDiscountCommand request, CancellationToken cancellationToken)
        {
            var discount = await _context.Discounts.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (discount != null)
            {
                _context.Discounts.Remove(discount);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    Message = $"Discount with given Id: {discount.Id} is succesfully Deleted!",
                    IsSuccess = true,
                    StatusCode = 201
                };
            }

            return new ResponseModel
            {
                Message = $"Discount doesn't exist with given Id:{discount.Id}",
                StatusCode = 400
            };
        }
    }
}
