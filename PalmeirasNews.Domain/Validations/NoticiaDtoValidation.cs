using FluentValidation;
using PalmeirasNews.Domain.DTOs;

namespace PalmeirasNews.Domain.Validations
{
    public class NoticiaDTOValidator : AbstractValidator<NoticiaDTO>
    {
        public NoticiaDTOValidator()
        {
            RuleFor(x => x.Titulo)
                .NotEmpty()
                .NotNull().WithMessage("Titulo deve ser informado!");

            RuleFor(c => c.Noticia)
                .NotEmpty()
                .NotNull().WithMessage("Noticia deve ser informado!");
        }
    }
}
