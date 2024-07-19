using _18_CourseAppEF.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_CourseAppEF.Validator
{
    public class StudentValidator:AbstractValidator<Student>
    {
        //Constructor yapılır ve validation kurallarını yazmaya başlarız.
        public StudentValidator()
        {
            RuleFor(s => s.Name)
                .NotEmpty()
                .WithMessage("Öğrenci adı alanı boş bırakılamaz.")
                .MinimumLength(1)
                .WithMessage("Öğrenci adı 1 karakterden az olamaz");

            RuleFor(s => s.TCNo)
                .NotEmpty()
                .WithMessage("Öğrenci TC alanı boş bırakılamaz.")
                .MinimumLength(11)
                .MaximumLength(11)
                .WithMessage("TC alanı 11 karakter olmalıdır.")
                .Matches("[0-9]")
                .WithMessage("TC alanı rakamlardan oluşmalıdır.");
        }
    }
}
