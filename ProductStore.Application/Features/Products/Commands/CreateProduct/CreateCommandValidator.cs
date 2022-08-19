using FluentValidation;

namespace ProductStore.Application.Features.Products.Commands.CreateProduct
{
    public class CreateCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);

            RuleFor(p => p.Desciption)
                .NotEmpty()
                .NotNull();

            RuleFor(p => p.CategoryId)
                .NotEmpty()
                .NotNull();
        }
    }
}
