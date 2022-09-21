using BusinessLogic.BusinessModels;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Logics
{
    public class PetLogic
    {
        private readonly IPetStorage petStorage;

        public PetLogic(IPetStorage petStorage)
        {
            this.petStorage = petStorage;
        }

        public List<PetViewModel> Search(PetBindingModel model)
        {
            return petStorage.GetFiltredList(model);
        }

        public List<PetViewModel> Read(PetBindingModel model)
        {
            if(model == null)
            {
                return petStorage.GetFullList();
            }else if(model.Id.HasValue){
                return new List<PetViewModel>
                {
                    petStorage.GetElement(model)
                };
            }
            return new List<PetViewModel>();
        }

        public void CreateOrUpdate(PetBindingModel model)
        {
            var pet = petStorage.GetElement(new PetBindingModel
            {
                Id = model.Id
            });

            if(pet != null && pet.Id != model.Id)
            {
                throw new Exception("Pet already created");
            }

            if (model.Id.HasValue)
            {
                petStorage.Update(model);
            }
            else
            {
                petStorage.Insert(model);
            }
        }
        public void Delete(PetBindingModel model)
        {
            var pet = petStorage.GetElement(new PetBindingModel
            {
                Id = model.Id
            });

            if(pet == null)
            {
                throw new Exception("Pet not found!");
            }

            petStorage.Delete(model);
        }
    }
}
