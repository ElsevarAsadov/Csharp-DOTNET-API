using FluentValidation;

namespace Api.Business.DTO.ProfessionDtos
{
    public class ProfessionCreateDto
    {
        public string Name { get; set; }


    }
    public class ProfessionCreateDtoValidator : AbstractValidator<ProfessionCreateDto>
    {
        public ProfessionCreateDtoValidator()
        {
            RuleFor(profession => profession.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(50)
                .MinimumLength(5);
        }
    }
}
