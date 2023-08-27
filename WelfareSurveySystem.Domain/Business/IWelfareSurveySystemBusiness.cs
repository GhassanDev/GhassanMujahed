using WelfareSurveySystem.Domain.Entities;

namespace WelfareSurveySystem.Domain.Business
{
    public interface IWelfareSurveySystemBusiness
    {
        //First I add method for initializing the repository:
        //void InitializeRepository(IWelfareSurveyRepository repository);
        //operation Deceased
        void SaveEmployee(Employee employee);
        void DeleteEmployee(int EmployeeID);
        Employee GetEmployee(int EmployeeID);
        List<Employee> GetAllEmployees();
        void EditEmployee(int EmployeeID, Employee employee);

        // TODO
        // add all remaining CRUD operations below

        //operation children
        void SaveChildren(int ChildrenId, Children children);
        void DeleteChildren(int DeceasedID, int ChildrenId);
        void EditChildren(int DeceasedID, int ChildrenId, Children children);
        List<Children> GetChildren(int empID);
        //operation parent
        void SaveParent(int empID, Parent parent);
        void DeleteParent(int DeceasedID, int ParentId);
        void EditParentId(int DeceasedID, int ParentId, Parent parent);
        List<Parent> GetParents(int empID);

        //operation PersonalInfo

        //operation RealEstate
        void SaveRealEstate(int RealEstateId, RealEstate realEstate);
        void DeleteRealEstate(int DeceasedID, int RealEstateId);
        void EditRealEstate(int DeceasedID, int RealEstateId, RealEstate realEstate);
        List<RealEstate> GetAllRealEstate(int empID);

        //operation Resercher
        //void SaveResercher(int ResercherId, Resercher resercher);
        //void DeleteResercher(int DeceasedID, int ResercherId);
        //void EditResercher(int DeceasedID, int ResercherId, Resercher resercher);

        //operation Sibling
        void SaveSibling(int SiblingId, Sibling sibling);
        void DeleteSibling(int DeceasedID, int SiblingId);
        void EditSibling(int DeceasedID, int SiblingId, Sibling sibling);
        List<Sibling> GetSibling(int empID);
        //operation Spouse
        void SaveSpouse(int SpouseId, Spouse spouse);
        void DeleteSpouse(int DeceasedID, int SpouseId);
        void EditSpouse(int DeceasedID, int SpouseId, Spouse spouse);
        List<Spouse> GetSpouse(int empID);

        //void SaveParent(Parent parent);


        //RealEstateType
        List<RealEstateType> GetRealEstateTypesFromDatabase(int RealEstateTypeId);
    }
}
