namespace InterfaceSample
{
    public class KarmandHesabdari : Person, IKarmand, IPerson
    {
        public string FullName { get; set; }

        public string MelliCode { get; set; }

        public void Register()
        {
            throw new System.NotImplementedException();
        }

        public override void SayHello()
        {
            throw new System.NotImplementedException();
        }
    }
}