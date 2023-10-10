using AspLesson8._1.Services;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspLesson8._1.Models
{
    public class Client
    {
        [Required(ErrorMessage = "Вкажіть ім'я")]
        [Display(Name = "Ім'я:")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Вкажіть Прізвище")]
        [Display(Name = "Прізвище:")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Вкажіть Email")]
        [EmailAddress]
        public string Email { get; set; }
        [CheckDate(DayOfWeek.Saturday,DayOfWeek.Sunday)]
        [DataType(DataType.Date)]
        [Display(Name="Виберіть дату відвідування:")]
        [Required(ErrorMessage = "Вкажіть дату")]
        public DateTime DateOfVisit { get; set; }
        [Required]
        [Display(Name="Виберіть курс:")]
        public string Course { get; set; }

    }
   
}
