namespace ThirtyFiveG.Validation
{
    public class ValidationResult : IValidationResult
    {
        #region Constructor
        public ValidationResult(string propertyName, string propertyPath, string message, ValidationResultType type)
        {
            PropertyName = propertyName;
            PropertyPath = propertyPath;
            Message = message;
            Type = type;
        }
        #endregion

        #region Public properties
        public string Message { get; private set; }
        public string PropertyName { get; private set; }
        public string PropertyPath { get; private set; }
        public ValidationResultType Type { get; private set; }
        #endregion
    }
}