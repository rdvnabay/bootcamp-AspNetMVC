using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Kategori adı giriniz");
            RuleFor(c => c.Name).MinimumLength(3).WithMessage("Kategori adı en az 3 karakter olmalı");
            RuleFor(c => c.Description).NotEmpty().WithMessage("Açıklama giriniz");
        }
    }
}
