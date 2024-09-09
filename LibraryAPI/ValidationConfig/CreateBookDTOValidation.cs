using FluentValidation;
using LibraryAPI.Models;
using LibraryAPI.Models.DTOs;

namespace LibraryAPI.ValidationConfig
{
    public class CreateBookDTOValidation : AbstractValidator<CreateBookDTO>
    {
        public CreateBookDTOValidation()
        {   
            RuleFor(book => book.Title).NotEmpty().MaximumLength(50);
            RuleFor(book => book.Author).NotEmpty().MaximumLength(50);
            RuleFor(book => book.DateOfPublication).NotEmpty();
            RuleFor(book => book.Genre).NotEmpty().MaximumLength(30);
        }
    }
}
