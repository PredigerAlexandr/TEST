using System;

namespace BusinessLogic.BusinessModels
{
    public class UserBindingModel
    {
        public int? Id { get; set; }

        public int PetId { get; set; }

        public string Name { get; set; }

        public DateTime DateBorn { get; set; }

        public int Age { get; set; }
    }
}
