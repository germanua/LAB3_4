namespace LAB3_4
{
    public class GasolineEmptyEventArgs : EventArgs
    {
        public GasolineEmptyEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; }
    }
}