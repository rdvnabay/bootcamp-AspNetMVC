using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(w => w.FirstName).NotEmpty().WithMessage("Yazar adı giriniz");
            RuleFor(w => w.FirstName).MinimumLength(2).WithMessage("Yazar adı en az 2 karakter olmalı");
            RuleFor(w => w.LastName).NotEmpty().WithMessage("Yazar soyadı giriniz");
            RuleFor(w => w.LastName).MinimumLength(2).WithMessage("Yazar soyad en az 3 karakter olmalı");
            RuleFor(w => w.Email).NotEmpty().WithMessage("Açıklama giriniz");
            RuleFor(w => w.About).Must(AboutInclueAlphaA).WithMessage("Hakkında kısmında a harfi bulunmak zorunda");
        }

        private bool AboutInclueAlphaA(string arg)
        {
            try
            {
                Regex regex = new Regex(@"^(?=.*[a,A])");
                return regex.IsMatch(arg);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
