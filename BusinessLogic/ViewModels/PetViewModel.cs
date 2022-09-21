using System.ComponentModel;

namespace BusinessLogic.ViewModels
{
    public class PetViewModel
    {     
        [DisplayName("Код")]
        public int Id { get; set; }

        [DisplayName("Кличка")]
        public string Name { get; set; }
    }
}
