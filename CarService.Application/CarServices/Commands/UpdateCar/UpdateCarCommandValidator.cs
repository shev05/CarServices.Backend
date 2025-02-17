using FluentValidation;

namespace CarServices.Application.CarServices.Commands.UpdateCar
{
    public class UpdateCarCommandValidator : AbstractValidator<UpdateCarCommand>
    {
        public UpdateCarCommandValidator() {
            RuleFor(updateCarCommand => updateCarCommand.Id)
                .NotEqual(Guid.Empty);

            RuleFor(updateCarCommand => updateCarCommand.ServiceId)
                .NotEqual(Guid.Empty);

            RuleFor(updateCarCommand => updateCarCommand.Mark)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(updateCarCommand => updateCarCommand.Model)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(updateCarCommand => updateCarCommand.Year_car)
                .InclusiveBetween(1900, DateTime.UtcNow.Year);

            RuleFor(updateCarCommand => updateCarCommand.Cost_car)
                .GreaterThan(0);
        }
    }
}
