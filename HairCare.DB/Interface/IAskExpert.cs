using HairCare.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haircare.DB.Interface
{
    public interface IAskExpert : IBaseEntity
    {
        [Required(ErrorMessage = "Adını Soyadını girmelisin!")]
        string SenderFullName { get; set; }

        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi girmelisin!")]
        [Required(ErrorMessage = "E-posta adresini girmelisin!")]
        string SenderEmail { get; set; }

        [Required(ErrorMessage = "Sorunu girmelisin!")]
        string Question { get; set; }
    }
}