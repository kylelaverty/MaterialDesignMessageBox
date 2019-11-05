namespace MaterialDesignMessageBox
{
    internal static class StringExtensions
    {
        internal static string TryAddKeyboardAccellerator(this string input)
        {
            // This is the WPF accellerator symbol
            const string accellerator = "_"; 

            // If it already contains an accellerator, do nothing
            if (input.Contains(accellerator))
            {
                return input;
            }
            else
            {
                return accellerator + input;
            }
        }
    }
}
