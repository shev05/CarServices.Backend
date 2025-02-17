using FluentValidation;

namespace CarServices.Application.CarServices.Queries.GetCarDetails
{
    public class GetCarDetailsQueryValidator : AbstractValidator<GetCarDetailsQuery>
    {
        public GetCarDetailsQueryValidator() {
            RuleFor(getCarDetailsQuery => getCarDetailsQuery.Id)
                .NotEqual(Guid.Empty);

            RuleFor(getCarDetailsQuery => getCarDetailsQuery.ServiceId)
                .NotEqual(Guid.Empty);
        }
    }
}
