using System;
using System.ComponentModel;

namespace BusinessLogic.ViewModels
{
    public class UserViewModel
    {
        [DisplayName("Код")]
        public int Id { get; set; }

        [DisplayName("ФИО")]
        public string Name { get; set; }

        [DisplayName("Дата рождения")]
        public DateTime DateBorn { get; set; }

        [DisplayName("Возраст")]
        public int Age { get; set; }
    }
}
