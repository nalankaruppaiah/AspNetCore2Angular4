namespace PetQuote.Models.ViewModel
{
    public class PetDetail
    {
        public string BreedName { get; set; }

        public int PetId { get; set; }

        public PetType PetType { get; set; }
    }

    public enum PetType
    {
        None = 0,
        Cat = 1,
        Dog = 2
    }
}
