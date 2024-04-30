using Catalog.Application.Abstractions;
using Catalog.Application.UseCases.CatalogCases.Commands;
using Catalog.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.UseCases.CatalogCases.Handlers.CommandHandlers
{
    public class UpdateCatalogCommandHandler : IRequestHandler<UpdateCatalogCommand, ResponseModel>
    {
        private readonly ICatalogDbContext _context;

        public UpdateCatalogCommandHandler(ICatalogDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(UpdateCatalogCommand request, CancellationToken cancellationToken)
        {
            var catalog = await _context.Catalogs.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (catalog != null)
            {
                catalog.Name = request.Name;
                catalog.Description = request.Description;

                _context.Catalogs.Update(catalog);

                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    StatusCode = 201,
                    Message = $"{catalog.Name} Catalog updated",
                    IsSuccess = true
                };
            }

            return new ResponseModel
            {
                Message = "Catalog is not found",
                StatusCode = 400
            };
        }
    }
}
