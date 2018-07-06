using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SportsStore.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage ="이름을 입력해주세요.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="첫번째 주소를 입력해주세요.")]
        [Display(Name ="라인 1")]
        public string Line1 { get; set; }
        [Display(Name = "라인 2")]
        public string Line2 { get; set; }
        [Display(Name = "라인 3")]
        public string Line3 { get; set; }

        [Required(ErrorMessage ="도시명을 입력해주세요.")]
        public string City { get; set; }

        [Required(ErrorMessage ="상태를 입력해주세요.")]
        public string State { get; set; }

        public string Zip { get; set; }

        [Required(ErrorMessage ="국가를 입력해주세요.")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }
    }
}
