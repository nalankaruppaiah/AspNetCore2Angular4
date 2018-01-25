using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PetQuote.Models.ViewModel;

namespace PetQuote.AppServices
{
    public class QuotesService: IQuoteService
    {
        #region public property
        public Task<List<PetDetail>> GetPetBreed(int petType)
        {
            Task<List<PetDetail>> result = Task.Run(() =>
            {
                var petDetails = new List<PetDetail>();
                var petDetailsStub = getPetDetails();

                petDetails.AddRange(petDetailsStub.FindAll(x => x.PetType == (PetType)petType));
                return petDetails;
            });

            return result;
        }

        public Task<bool> GetQuote(Quote quote)
        {
            Task<bool> result = Task.Run(() =>
            {
                try
                {
                    return true;
                }
                catch { return false; }
            });
            return result;
        }

        public Task<List<PetAge>> GetPetAges()
        {
            Task<List<PetAge>> result = Task.Run(() =>
            {
                var ageList = new List<PetAge>();

                ageList.Add(new PetAge { Id = 1, Age = "0 - 7 weeks old" });
                ageList.Add(new PetAge { Id = 2, Age = "8 weeks to 12 months old" });
                ageList.Add(new PetAge { Id = 3, Age = "1 year old" });
                ageList.Add(new PetAge { Id = 4, Age = "2 years old" });
                ageList.Add(new PetAge { Id = 5, Age = "3 years old" });
                ageList.Add(new PetAge { Id = 6, Age = "4 years old" });
                ageList.Add(new PetAge { Id = 7, Age = "5 years old" });
                ageList.Add(new PetAge { Id = 8, Age = "6 years old" });
                ageList.Add(new PetAge { Id = 9, Age = "7 years old" });
                ageList.Add(new PetAge { Id = 10, Age = "8 years old" });
                ageList.Add(new PetAge { Id = 11, Age = "9 years old" });
                ageList.Add(new PetAge { Id = 12, Age = "10 years old" });
                ageList.Add(new PetAge { Id = 13, Age = "11 years old" });
                ageList.Add(new PetAge { Id = 14, Age = "12 years old" });
                ageList.Add(new PetAge { Id = 15, Age = "13 years old" });

                return ageList;
            });

            //Could use stub service to mock the data.
            return result;
        }

        #endregion

        #region private property

        private List<PetDetail> getPetDetails()
        {
            var petList = new List<PetDetail>();

            //cat details
            petList.Add(new PetDetail { PetId = 1, BreedName = "Mixed Breed(Cat)", PetType = PetType.Cat });
            petList.Add(new PetDetail { PetId = 2, BreedName = "Abyssinian", PetType = PetType.Cat });
            petList.Add(new PetDetail { PetId = 3, BreedName = "American Bobtail", PetType = PetType.Cat });
            petList.Add(new PetDetail { PetId = 4, BreedName = "Chartreux", PetType = PetType.Cat });
            petList.Add(new PetDetail { PetId = 5, BreedName = "American Shorthair", PetType = PetType.Cat });
            petList.Add(new PetDetail { PetId = 6, BreedName = "American Wirehair", PetType = PetType.Cat });
            petList.Add(new PetDetail { PetId = 7, BreedName = "Domestic Mediumhair", PetType = PetType.Cat });
            petList.Add(new PetDetail { PetId = 8, BreedName = "Domestic Shorthair", PetType = PetType.Cat });
            petList.Add(new PetDetail { PetId = 9, BreedName = "Donskoy", PetType = PetType.Cat });
            petList.Add(new PetDetail { PetId = 10, BreedName = "Egyptian Mau", PetType = PetType.Cat });


            //dog details
            petList.Add(new PetDetail { PetId = 11, BreedName = "Affenpinscher", PetType = PetType.Dog });
            petList.Add(new PetDetail { PetId = 12, BreedName = "Alaskan Klee Kai", PetType = PetType.Dog });
            petList.Add(new PetDetail { PetId = 13, BreedName = "American Foxhound", PetType = PetType.Dog });
            petList.Add(new PetDetail { PetId = 14, BreedName = "Anatolian Shepherd", PetType = PetType.Dog });
            petList.Add(new PetDetail { PetId = 15, BreedName = "Australian Cattle Dog", PetType = PetType.Dog });
            petList.Add(new PetDetail { PetId = 16, BreedName = "Australian Kelpie", PetType = PetType.Dog });
            petList.Add(new PetDetail { PetId = 17, BreedName = "Airedale Terrier", PetType = PetType.Dog });
            petList.Add(new PetDetail { PetId = 18, BreedName = "Basenji", PetType = PetType.Dog });
            petList.Add(new PetDetail { PetId = 19, BreedName = "Bavarian Mountain Hound", PetType = PetType.Dog });
            petList.Add(new PetDetail { PetId = 20, BreedName = "Belgian Malinois", PetType = PetType.Dog });
            petList.Add(new PetDetail { PetId = 21, BreedName = "Berger Picard", PetType = PetType.Dog });
            petList.Add(new PetDetail { PetId = 22, BreedName = "Black and Tan Coonhound", PetType = PetType.Dog });
            petList.Add(new PetDetail { PetId = 23, BreedName = "Boykin Spaniel", PetType = PetType.Dog });
            petList.Add(new PetDetail { PetId = 24, BreedName = "Chesapeake Bay Retriever", PetType = PetType.Dog });

            return petList;
        }
        #endregion
    }
}
