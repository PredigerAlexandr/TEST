using BusinessLogic.BusinessModels;
using BusinessLogic.ViewModels;
using System.Collections.Generic;

namespace BusinessLogic.Interfaces
{
    public interface IPetStorage
    {
        List<PetViewModel> GetFullList();
        PetViewModel GetElement(PetBindingModel model);
        List<PetViewModel> GetFiltredList(PetBindingModel model);

        void Insert(PetBindingModel model);
        void Update(PetBindingModel model);
        void Delete(PetBindingModel model);
    }
}
