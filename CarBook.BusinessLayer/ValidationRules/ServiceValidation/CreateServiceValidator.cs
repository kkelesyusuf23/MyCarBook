using CarBook.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.BusinessLayer.ValidationRules.ServiceValidation
{
    public class CreateServiceValidator:AbstractValidator<Service>
    {
        public CreateServiceValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlığı boş geçemezsiniz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanını boş geçemezsiniz.");
            RuleFor(x => x.Icon).NotEmpty().WithMessage("Icon alanını boş geçemezsiniz.");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız");
            RuleFor(x => x.Title).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter girişi yapınız");
            RuleFor(x => x.Description).MinimumLength(30).WithMessage("Lütfen en az 30 karakter girişi yapınız");
            RuleFor(x => x.Description).MaximumLength(200).WithMessage("Lütfen en fazla 200 karakter girişi yapınız");
        }
    }
}
