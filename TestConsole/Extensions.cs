namespace TestConsole
{
    public static class Extensions
    {
        public static bool IsYes(this char ch)
        {
            return ch.Equals(Constants.Yes);
        }
    }
}