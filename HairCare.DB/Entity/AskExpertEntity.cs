using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairCare.DB;
using Haircare.DB.Interface;
using System.ComponentModel.DataAnnotations;

namespace HairCare.DB
{
    [MetadataType(typeof(IAskExpert))]
    public partial class AskExpert : BaseEntity<AskExpert>, IAskExpert
    {

    }
}
