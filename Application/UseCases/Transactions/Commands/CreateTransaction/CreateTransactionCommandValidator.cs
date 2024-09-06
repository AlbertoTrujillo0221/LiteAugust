using FluentValidation;

namespace Application.UseCases.Transactions.Commands.CreateTransaction
{
    public class CreateTransactionCommandValidator : AbstractValidator<CreateTransactionCommand>
    {
        public CreateTransactionCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                .NotEmpty()
                .WithMessage("No tiene ID");

            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("Debe tener un mensaje");
        }
    }
}
