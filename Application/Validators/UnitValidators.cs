using Application.DTOs;
using Domain;
using FluentValidation;

namespace Application.Validators;

public class UnitValidators : AbstractValidator<Unit>
{
    public UnitValidators()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
        RuleFor(x=> x.Faction).NotEmpty().WithMessage("Faction is required");
    }
}

public class PostBoxValidator : AbstractValidator<UnitDTO>
{
    public PostBoxValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
        RuleFor(x => x.Faction).NotEmpty().WithMessage("Faction is required");
    }
}