using StaticSample;

namespace ExtensionMethodSample
{
    public static class CalculatorExtensions
    {
        public static string ConcatStrings(this CalculatorVersionTwo calculator, string firstString, string secondString)
        {
            return firstString + secondString;
        }
    }
}