namespace EugeneAnykey.Utils
{
    internal static class Rand
    {
        static readonly Random rand = new((int)DateTime.Now.Ticks);

        public static int GetInt(int max)
        {
            return rand.Next(max);
        }
    }
}
