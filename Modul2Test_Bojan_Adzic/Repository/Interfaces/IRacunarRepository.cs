using Modul2Test_Bojan_Adzic.Models;

namespace Modul2Test_Bojan_Adzic.Repository.Interfaces
{
    public interface IRacunarRepository
    {
        List<Racunar> GetAll();
        Racunar GetOne(int Id);
        void Create(Racunar Racunar);
        void Delete(int Id);
        void Edit(Racunar Racunar);
    }
}
