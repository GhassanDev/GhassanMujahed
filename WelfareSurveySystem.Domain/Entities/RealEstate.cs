namespace WelfareSurveySystem.Domain.Entities
{
    public class RealEstate
    {
        public int RealEstateId { get; set; }
        //public enum RealEstateTypeEnum {House,Land,Farms,Others }
        public int EmployeeID { get; set; }
        public RealEstateType RealEstateType { get; set; }
        //public RealEstateTypeEnum RealEstateType {get; set;}
        public string OwnOrRent { get; set; }
        public int RealEstateNumber { get; set; }
        public string RealEstateDescription { get; set; }

    }
}
