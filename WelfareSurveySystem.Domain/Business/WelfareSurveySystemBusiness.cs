using WelfareSurveySystem.Domain.DataRepositories;
using WelfareSurveySystem.Domain.Entities;

namespace WelfareSurveySystem.Domain.Business
{
    public class WelfareSurveySystemBusiness : IWelfareSurveySystemBusiness
    {

        //========================================================================
        private readonly IEmployeeRepository repo;

        public int ParentId { get; private set; }

        //use some Ioc (Invertion of Control) to inject the depandancy object(obove one)
        public WelfareSurveySystemBusiness(IEmployeeRepository repository)
        {
            this.repo = repository;
        }
        //==========================================================================



        //operation Deceased
        public void SaveEmployee(Employee employee)
        {
            repo.SaveEmployee(employee);
        }

        public void DeleteEmployee(int EmployeeID)
        {
            repo.DeleteEmployee(EmployeeID);
        }

        public Employee GetEmployee(int EmployeeID)
        {
            return repo.GetEmployee(EmployeeID);
        }

        public List<Employee> GetAllEmployees()
        {
            return repo.GetAllEmployees();
        }

        public void EditEmployee(int EmployeeID, Employee employee)
        {
            repo.EditEmployee(EmployeeID, employee);
        }
        //operation children

        public void SaveChildren(int ChildrenId, Children children)
        {
            repo.SaveChildren(ChildrenId, children);
        }

        public void DeleteChildren(int DeceasedID, int ChildrenId)
        {
            repo.DeleteChildren(DeceasedID, ChildrenId);
        }

        public void EditChildren(int DeceasedID, int ChildrenId, Children children)
        {
            repo.EditChildren(DeceasedID, ChildrenId, children);
        }
        //operation parent

        public void SaveParent(int ParentId, Parent parent)
        {
            repo.SaveParent(ParentId, parent);
        }

        public void DeleteParent(int DeceasedID, int ParentId)
        {
            repo.DeleteParent(DeceasedID, ParentId);
        }

        public void EditParentId(int DeceasedID, int ParentId, Parent parent)
        {
            repo.EditParent(DeceasedID, ParentId, parent);
        }
        //operation PersonalInfo

        //operation RealEstate

        public void SaveRealEstate(int RealEstateId, RealEstate realEstate)
        {
            repo.SaveRealEstate(RealEstateId, realEstate);
        }

        public void DeleteRealEstate(int DeceasedID, int RealEstateId)
        {
            repo.DeleteRealEstate(DeceasedID, RealEstateId);
        }

        public void EditRealEstate(int DeceasedID, int RealEstateId, RealEstate realEstate)
        {
            repo.EditRealEstate(DeceasedID, RealEstateId, realEstate);
        }

        public List<RealEstate> GetAllRealEstate(int empID)
        {
            List<RealEstate> realEstate = repo.GetAllRealEstate(empID);
            return(realEstate);
            
        }
        //operation Resercher

        //public void SaveResercher(int ResercherId, Resercher resercher)
        //{
        //    repo.SaveResercher(ResercherId, resercher);
        //}

        //public void DeleteResercher(int DeceasedID, int ResercherId)
        //{
        //    repo.DeleteResercher(DeceasedID, ResercherId);
        //}

        //public void EditResercher(int DeceasedID, int ResercherId, Resercher resercher)
        //{
        //    repo.EditResercher(DeceasedID, ResercherId, resercher);
        //}
        //operation Sibling

        public void SaveSibling(int SiblingId, Sibling sibling)
        {
            repo.SaveSibling(SiblingId, sibling);
        }

        public void DeleteSibling(int DeceasedID, int SiblingId)
        {
            repo.DeleteSibling(DeceasedID, SiblingId);
        }

        public void EditSibling(int DeceasedID, int SiblingId, Sibling sibling)
        {
            repo.EditSibling(DeceasedID, SiblingId, sibling);
        }
        //operation Spouse
        public void SaveSpouse(int SpouseId, Spouse spouse)
        {
            repo.SaveSpouse(SpouseId, spouse);
        }

        public void DeleteSpouse(int DeceasedID, int SpouseId)
        {
            repo.DeleteSpouse(DeceasedID, SpouseId);
        }

        public void EditSpouse(int DeceasedID, int SpouseId, Spouse spouse)
        {
            repo.EditSpouse(DeceasedID, SpouseId, spouse);
        }

        public List<Parent> GetParents(int empID)
        {
            //throw new NotImplementedException();
            //TODO:
            List<Parent> parents = repo.GetParents(empID);

            return parents;
        }

        public void SaveParent(Parent parent)
        {
            repo.SaveParent(ParentId, parent);
        }

        public List<Children> GetChildren(int empID)
        {
            List<Children> Childrens = repo.GetChildren(empID);

            return Childrens;
        }

        public List<Spouse> GetSpouse(int empID)
        {
            List<Spouse> Spouses = repo.GetSpouse(empID);

            return Spouses;
        }

        public List<Sibling> GetSibling(int empID)
        {
            List<Sibling> Siblings = repo.GetSibling(empID);

            return Siblings;
        }

        public List<RealEstateType> GetRealEstateTypesFromDatabase(int RealEstateTypeId)
        {
            List<RealEstateType> realEstateTypes = repo.GetRealEstateTypesFromDatabase(RealEstateTypeId);
            return realEstateTypes;
        }
    }
}