namespace _012_Exceptions
{
    internal class NotFoundAccountException : ApplicationException
    {
        public Account Account { get; set; }

        public NotFoundAccountException(string message, Account account)
            : base(message)
        {
            this.Account = account;
        }
    }
}
