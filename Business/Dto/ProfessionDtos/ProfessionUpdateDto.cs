using FluentValidation;

namespace Api.Business.DTO.ProfessionDtos
{
    public class ProfessionUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class ProfessionUpdateDtoValidator : AbstractValidator<ProfessionUpdateDto>
    {
        public ProfessionUpdateDtoValidator()
        {

            RuleFor(profession => profession.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(50)
                .MinimumLength(10);

            RuleFor(profession => profession.Id)
                 .NotEmpty()
                 .NotNull()
                 .GreaterThanOrEqualTo(1);
        }
    }
}
