using FluentValidation;
using sparkling_freedom.Model;

namespace sparkling_freedom.Validator
{
    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        {
            RuleFor(t => t.Tipo)
              .NotEmpty()
              .MinimumLength(5)
              .MaximumLength(100);
        }
    }
}
