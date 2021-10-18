using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinTraining.Domain;

namespace XamarinTraining.Services
{
    public interface IDataService
    {
        Task<IList<Character>> GetCharactersByNameAsync(string name);
        Task<Character> GetCharacterAsync(int id);
    }
}