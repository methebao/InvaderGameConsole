namespace InvaderGameConsole
{
    class InvaderGameConsoleException : System.Exception
    {
        public InvaderGameConsoleException()
        {
        }
        
        public InvaderGameConsoleException(string message) : base(message)
        {
        }
    }
    
    class OutOfBoundsException : InvaderGameConsoleException
    {
        public OutOfBoundsException()
        {
        }
        
        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
}