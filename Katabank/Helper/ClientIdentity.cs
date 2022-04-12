namespace Katabank.Helper
{
    internal class ClientIdentity
    {
        private static int accountNumberSeed = 1234567890;
        public static int GetAccountId()
        {
            return accountNumberSeed++;
        }

    }
}
