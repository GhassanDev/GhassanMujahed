using Microsoft.EntityFrameworkCore;
using WelfareSurveySystem.Domain.DataRepositories;
using WelfareSurveySystem.Domain.Entities;

namespace WelfareSurveySystem.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        //private WelfareSurveySystemDBContext db = new WelfareSurveySystemDBContext();
        private WelfareSurveySystemDBContext db;// = new WelfareSurveySystemDBContext();

        public EmployeeRepository(WelfareSurveySystemDBContext db)
        {
            this.db = db;
        }


        //operation children
        public void DeleteChildren(int DeceasedID, int ChildrenId)
        {

            var ChildrendDel = db.Childrens.Find(ChildrenId);

            db.Childrens.Remove(ChildrendDel);

            db.SaveChanges();
        }
        public void EditChildren(int DeceasedID, int ChildrenId, Children children)
        {
            db.Entry(children).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            db.SaveChanges();
        }
        public void SaveChildren(int ChildrenId, Children children)
        {
            db.Childrens.Add(children);
            db.SaveChanges();
        }
        //operation parent
        public void DeleteParent(int DeceasedID, int ParentId)
        {

            var ParentDel = db.Parents.Find(ParentId);

            db.Parents.Remove(ParentDel);
        }

        public void SaveParent(int ParentId, Parent parent)
        {
            SaveParent(ParentId, parent, db);
        }

        public void SaveParent(int ParentId, Parent parent, WelfareSurveySystemDBContext db)
        {
            db.Parents.Add(parent);
            db.SaveChanges();
        }
        public void EditParent(int DeceasedID, int ParentId, Parent parent)
        {
            db.Entry(parent).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            db.SaveChanges();
        }
        //operation PersonalInfo
        //operation RealEstate
        public void DeleteRealEstate(int DeceasedID, int RealEstateId)
        {
            var RealEstateDel = db.RealEstates.Find(RealEstateId);

            db.RealEstates.Remove(RealEstateDel);
        }
         public List<RealEstate> GetAllRealEstate(int empID)
        {
            return db.RealEstates.Where(p => p.EmployeeID == empID).ToList();
        }
        public void SaveRealEstate(int RealEstateId, RealEstate realEstate)
        {
            db.RealEstates.Add(realEstate);
            db.SaveChanges();
        }
        public void EditRealEstate(int DeceasedID, int RealEstateId, RealEstate realEstate)
        {
            db.Entry(realEstate).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            db.SaveChanges();
        }
        //operation Resercher
        //public void DeleteResercher(int DeceasedID, int ResercherId)
        //{
        //    var ResercherDel = db.Reserchers.Find(ResercherId);
        //    db.Reserchers.Remove(ResercherDel);
        //}
        //public void SaveResercher(int ResercherId, Resercher resercher)
        //{
        //    db.Reserchers.Add(resercher);
        //    db.SaveChanges();
        //}
        //public void EditResercher(int DeceasedID, int ResercherId, Resercher resercher)
        //{
        //    db.Entry(resercher).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

        //    db.SaveChanges();
        //}

        //operation Sibling
        public void DeleteSibling(int DeceasedID, int SiblingId)
        {
            var SiblingsDel = db.Siblings.Find(SiblingId);
            db.Siblings.Remove(SiblingsDel);
        }
        public void EditSibling(int DeceasedID, int SiblingId, Sibling sibling)
        {
            db.Entry(sibling).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            db.SaveChanges();
        }
        public void SaveSibling(int SiblingId, Sibling sibling)
        {
            db.Siblings.Add(sibling);
            db.SaveChanges();
        }
        //operation Spouse
        public void DeleteSpouse(int DeceasedID, int SpouseId)
        {
            var SpouseDel = db.Spouses.Find(SpouseId);
            db.Spouses.Remove(SpouseDel);
        }
        public void EditSpouse(int DeceasedID, int SpouseId, Spouse spouse)
        {
            db.Entry(spouse).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            db.SaveChanges();
        }
        public void SaveSpouse(int SpouseId, Spouse spouse)
        {
            db.Spouses.Add(spouse);
            db.SaveChanges();
        }

        public void SaveEmployee(Employee employee)
        {
            //employee.Address = new Address { City = "city", Region = "re", Village = "v1" };
            db.Employees.Add(employee);
            db.SaveChanges();
        }

        void IEmployeeRepository.DeleteEmployee(int employeeID)
        {
            // get the emp to delete from dbset
            var EmployeeDel = db.Employees.Find(employeeID);
            // remove that obj from dbset
            db.Employees.Remove(EmployeeDel);

            db.SaveChanges();
        }

        Employee IEmployeeRepository.GetEmployee(int EmployeeID)
        {
            return db.Employees.Find(EmployeeID);
        }

        List<Employee> IEmployeeRepository.GetAllEmployees()
        {
            return db.Employees.ToList();
        }

        void IEmployeeRepository.EditEmployee(int EmployeeID, Employee employee)
        {
            db.Entry(employee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            db.SaveChanges();
        }

        public void SaveParent(object parentId, Parent parent)
        {
            db.Parents.Add(parent);
            db.SaveChanges();
        }

        public void SaveParent(Parent parent)
        {
            db.Parents.Add(parent);
            db.SaveChanges();
        }

        public void SaveParent(Parent parent, int empID)
        {
            db.Parents.Add(parent);
            db.SaveChanges();
        }

        public List<Parent> GetParents(int empID)
        {
            return db.Parents.Where(p => p.EmployeeID == empID).ToList();

        }

        public List<Children> GetChildren(int empID)
        {
            return db.Childrens.Where(p => p.EmployeeID == empID).ToList();
        }
        public List<Spouse> GetSpouse(int empID)
        {
            return db.Spouses.Where(p => p.EmployeeID == empID).ToList();
        }
        public List<Sibling> GetSibling(int empID)
        {
            return db.Siblings.Where(p => p.EmployeeID == empID).ToList();
        }

        public List<Employee> GetEmployeeDetails(string serviceNo)
        {
            return db.Employees
                .Include("Childrens.Address")
                .Include("Siblings")
                .Include("Parents")
                .Include("Spouses")
                .Include("RealEstates")
                .Include("Documents")
                .Include("Address")
                .Where(e => e.ServiceNo == serviceNo).ToList();
        }
        //TODO : Implement the remaining interface methods


        //RealEstateType
        public List<RealEstateType> GetRealEstateTypesFromDatabase(int RealEstateTypeId)
        {
            return db.RealEstateTypes.Where(p => p.RealEstateTypeId == RealEstateTypeId).ToList();
        }
    }
}
