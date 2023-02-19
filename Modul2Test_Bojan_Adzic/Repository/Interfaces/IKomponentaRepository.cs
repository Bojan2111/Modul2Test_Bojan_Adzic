using Modul2Test_Bojan_Adzic.Models;

namespace Modul2Test_Bojan_Adzic.Repository.Interfaces
{
    public interface IKomponentaRepository
    {
        List<Komponenta> GetAll(int RacunarId);
        Komponenta GetOne(int Id);
        void Create(Komponenta Komponenta);
        void Delete(int Id);
        void Edit(Komponenta Komponenta);
        List<Komponenta> Ovogodisnje(int RacunarId);
        List<Komponenta> SortImeRastuce(int RacunarId);
        List<Komponenta> SortImeOpadajuce(int RacunarId);
    }
}
