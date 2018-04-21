namespace GourmetGame.Message
{
    internal class Messages
    {
        private string defaultMessage = "O prato que você pensou é {0}?";
        internal string DefaultMessage { get { return defaultMessage; } private set { DefaultMessage = value; } }

        private string massa = "massa";
        internal string Massa { get { return massa; } private set{ Massa = value;} }
        
        private string lasanha = "lasanha";
        internal string Lasanha { get { return lasanha; } private set { Lasanha = value;} }
        
        private string boloDeChocolate = "Bolo de Chocolate";
        internal string BoloDeChocolate { get { return boloDeChocolate; } private set { BoloDeChocolate = value;} }
        
        private string completeMessage = "Um(a) {0} é ____________ mas um(a) {1} não.";
        internal string CompleteMessage { get{return completeMessage;} private set{CompleteMessage = value;} }
        
        private string ask = "O prato que você pensou é um(a) {0}?";
        internal string Ask { get{return ask;} private set{Ask = value;} }
    }
}
