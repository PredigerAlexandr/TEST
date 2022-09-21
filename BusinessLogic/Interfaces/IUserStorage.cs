using BusinessLogic.BusinessModels;
using BusinessLogic.ViewModels;
using System.Collections.Generic;

namespace BusinessLogic.Interfaces
{
    public interface IUserStorage
    {
        List<UserViewModel> GetFullList();
        UserViewModel GetElement(UserBindingModel model);
        List<UserViewModel> GetFiltredList(UserBindingModel model);

        void Insert(UserBindingModel model);
        void Update(UserBindingModel model);
        void Delete(UserBindingModel model);
    }
}
