namespace ThirtyFiveG.Validation
{
    public interface IValidationResult
    {
        string PropertyName { get; }
        string PropertyPath { get; }
        string Message { get; }
        ValidationResultType Type { get; }
    }
}
