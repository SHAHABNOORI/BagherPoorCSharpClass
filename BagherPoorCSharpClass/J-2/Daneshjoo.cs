namespace J_2
{
    public class Daneshjoo
    {
        public Daneshjoo()
        {
            
        }

        public Daneshjoo(string firstName, string lastName, string melliCode)
        {
            FirstName = firstName;
            LastName = lastName;
            MelliCode = melliCode;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MelliCode { get; set; }
    }
}