using System.ComponentModel;
using WelfareSurveySystem.Domain.Entities;

namespace WelfareSurveySystem.WebUI.Models
{
    public class RealEstateTypesViewModel
    {
        [DisplayName("Service Number")]
        public string ServiceNo { get; set; }
        public int RealEstateId { get; set; }
        //public enum RealEstateTypeEnum {House,Land,Farms,Others }
       
        public string OwnOrRent { get; set; }
        public int RealEstateNumber { get; set; }
        public string RealEstateDescription { get; set; }
        //public int RealEstateTypeId { get; set; }
        //public string RealEstateTypeName { get; set; }
    }
}
