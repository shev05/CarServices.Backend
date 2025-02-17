using FluentValidation;

namespace CarServices.Application.CarServices.Queries.GetCarList
{
    public class GetCarListQueryValidator : AbstractValidator<GetCarListQuery>
    {
        public GetCarListQueryValidator() {
            RuleFor(getCarListQuery => getCarListQuery.ServiceId)
                    .NotEqual(Guid.Empty);
        }
    }
}
