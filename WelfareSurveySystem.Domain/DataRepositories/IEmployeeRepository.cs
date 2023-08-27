using WelfareSurveySystem.Domain.Entities;

namespace WelfareSurveySystem.Domain.DataRepositories
{
    public interface IEmployeeRepository
    {

        //operation Deceased
        void SaveEmployee(Employee employee);
        void DeleteEmployee(int EmployeeID);
        Employee GetEmployee(int EmployeeID);
        List<Employee> GetAllEmployees();
        void EditEmployee(int EmployeeID, Employee employee);

        // TODO
        // add all remaining CRUD operations below

        void SaveChildren(int ChildrenId, Children children);
        void DeleteChildren(int DeceasedID, int ChildrenId);
        void EditChildren(int DeceasedID, int ChildrenId, Children children);
        List<Children> GetChildren(int empID);
        //operation parent
        void SaveParent(Parent parent, int empID);
        void DeleteParent(int DeceasedID, int ParentId);
        void EditParent(int DeceasedID, int ParentId, Parent parent);

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
        void SaveParent(object parentId, Parent parent);
        void SaveParent(Parent parent);
        List<Parent> GetParents(int empID);

        List<Employee> GetEmployeeDetails(string serviceNo);


        //RealEstateType
        List<RealEstateType> GetRealEstateTypesFromDatabase(int RealEstateTypeId);
    }
}
