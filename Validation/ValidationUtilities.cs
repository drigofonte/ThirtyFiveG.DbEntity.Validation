using System.Text.RegularExpressions;

namespace ThirtyFiveG.Validation
{
    public static class ValidationUtilities
    {
        public const string WildcardCharacter = "*";

        public static bool Matches(string patternToMatch, string propertyPath)
        {
            Regex regex = new Regex(patternToMatch);
            return regex.Match(propertyPath).Success;
        }

        public static bool Matches(string patternToMatch, IValidationResult result)
        {
            return Matches(patternToMatch, result.PropertyPath);
        }
    }
}
