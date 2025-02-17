using FluentValidation;

namespace CarServices.Application.CarServices.Commands.DeleteCommand
{
    public class DeleteCarCommandValidator : AbstractValidator<DeleteCarCommand>
    {
        public DeleteCarCommandValidator() {
            RuleFor(deleteCarCommand => deleteCarCommand.Id)
                .NotEqual(Guid.Empty);

            RuleFor(deleteCarCommand => deleteCarCommand.ServiceId)
                .NotEqual(Guid.Empty);
        }
    }
}
