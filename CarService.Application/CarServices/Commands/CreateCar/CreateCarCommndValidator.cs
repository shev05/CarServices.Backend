
using FluentValidation;

namespace CarServices.Application.CarServices.Commands.CreateCar
{
    public class CreateCarCommndValidator : AbstractValidator<CreateCarCommand>
    {
        public CreateCarCommndValidator() {
            RuleFor(createCarCommand => createCarCommand.Mark)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(createCarCommand => createCarCommand.Model)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(createCarCommand => createCarCommand.ServiceId)
                .NotEqual(Guid.Empty);

            RuleFor(createCarCommand => createCarCommand.Year_car)
                .InclusiveBetween(1900, DateTime.UtcNow.Year);

            RuleFor(createCarCommand => createCarCommand.Cost_car)
                .GreaterThan(0);
                    }
    }
}
