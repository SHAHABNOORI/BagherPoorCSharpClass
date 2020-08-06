namespace ExtensionMethodSample
{
    public static class IntExtensionMethods
    {
        public static bool IsGreaterThan(this int i, int value) => i > value;

        public static bool IsLessThan(this int i, int value) => i < value;
    }
}