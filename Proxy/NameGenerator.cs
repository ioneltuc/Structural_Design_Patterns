namespace TMPS_lab2.Proxy
{
    public static class NameGenerator
    {
        public static string GenerateName(int nameLength)
        {
            Random random = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
            string[] vowels = { "a", "e", "i", "o", "u" };
            string name = String.Empty;

            name += consonants[random.Next(consonants.Length)].ToUpper();
            name += vowels[random.Next(vowels.Length)];

            int actualNameLength = 2;

            while (actualNameLength < nameLength)
            {
                name += consonants[random.Next(consonants.Length)];
                name += vowels[random.Next(vowels.Length)];
                actualNameLength += 2;
            }

            return name;
        }
    }
}