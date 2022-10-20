using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_PET.Models
{
    public interface IRepository
    {
        void Add(PetModel petModel);
        void Edit(PetModel petModel);
        void Delete(int id);
        IEnumerable<PetModel> GetAll();
        IEnumerable<PetModel> GetByValue();
    }
}
