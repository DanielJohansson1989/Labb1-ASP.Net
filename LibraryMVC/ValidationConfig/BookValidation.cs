using FluentValidation;
using LibraryAPI.Models;

namespace LibraryMVC.ValidationConfig
{
    public class BookValidation : AbstractValidator<Book>
    {
        public BookValidation()
        {
            RuleFor(book => book.Title).NotEmpty().MaximumLength(50);
            RuleFor(book => book.Author).NotEmpty().MaximumLength(50);
            RuleFor(book => book.DateOfPublication).NotEmpty();
            RuleFor(book => book.Genre).NotEmpty().MaximumLength(30);
        }
    }
}
