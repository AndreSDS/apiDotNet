namespace BuberBreakfast.Contracts.Breakfast
{
    public record BreakfastResponse(
        Guid Id,
        string Name,
        string Description,
        DateTime StartDateTIme,
        DateTime EndDateTime,
        DateTime LastModifiedDateTime,
        List<string> Savory,
        List<string> Sweet
    );
}