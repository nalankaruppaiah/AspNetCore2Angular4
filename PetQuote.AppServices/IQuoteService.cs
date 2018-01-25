using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PetQuote.Models.ViewModel;

namespace PetQuote.AppServices
{
    public interface IQuoteService : IAppServices
    {
        Task<List<PetDetail>> GetPetBreed(int petType);

        Task<bool> GetQuote(Quote quote);

        Task<List<PetAge>> GetPetAges();
       
    }
}
