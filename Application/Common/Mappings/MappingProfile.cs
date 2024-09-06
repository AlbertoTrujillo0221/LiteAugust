using Application.UseCases.Transactions.Commands.CreateTransaction;
using AutoMapper;

namespace Application.Common.Mappings;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        this.CreateMap<CreateTransactionCommandModel, CreateTransactionCommand>();
    }
}
