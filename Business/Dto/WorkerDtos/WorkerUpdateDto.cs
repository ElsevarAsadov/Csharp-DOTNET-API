using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace Api.Business.DTO.WorkerDtos
{
    public class WorkerUpdateDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public double Salary { get; set; }
        public string SocialMediaUrl { get; set; }
        public List<int> ProfessionIds { get; set; }
        public IFormFile ImgFile { get; set; }
    }

    public class WorkerUpdateDtoValidator : AbstractValidator<WorkerUpdateDto>
    {
        public WorkerUpdateDtoValidator()
        {
            RuleFor(worker => worker.FullName)
               .NotEmpty()
               .NotNull()
               .MaximumLength(50)
               .MinimumLength(5);


            RuleFor(worker => worker.Description)
               .NotEmpty()
               .NotNull()
               .MaximumLength(100)
               .MinimumLength(5);


            RuleFor(worker => worker.SocialMediaUrl)
               .NotEmpty()
               .NotNull()
               .MaximumLength(150)
               .MinimumLength(10);

            RuleFor(worker => worker.Salary)
               .NotEmpty()
               .NotNull()
               .GreaterThan(0);

            RuleFor(worker => worker.ImgFile)
             .NotEmpty()
             .NotNull();

            RuleFor(worker => worker.Id)
            .NotEmpty()
            .NotNull()
            .GreaterThanOrEqualTo(1);
        }
    }
}
