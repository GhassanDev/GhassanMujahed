using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WelfareSurveySystem.Domain.Business;
using WelfareSurveySystem.Domain.Entities;

namespace WelfareSurveySystem.WebUI.Controllers.EmployeesManage
{
    //[Authorize(Roles = "resercher")]

    public class EmployeesPersonalDetailsController : Controller
    {

        private IWelfareSurveySystemBusiness employeesManage;

        public EmployeesPersonalDetailsController(IWelfareSurveySystemBusiness employeesManage)
        {
            this.employeesManage = employeesManage;

        }



        public IActionResult Index(string serviceNo = null)
        {
            Employee emp = null;
            //string message = "Employee not found...";
            if (serviceNo != null)
            {
                //TODO: add GetEmployeeByServiceNo() in Data and Domain Layer
                emp = employeesManage.GetAllEmployees().Where(e => e.ServiceNo.Trim() == serviceNo.Trim()).FirstOrDefault();
                //message = "";
                if (emp == null)
                {
                    TempData["Msg"] = "Employee not found, search again";
                }
            }



            return View(emp);
        }


        // www.sdfsdfsdfsdf.com/EmployeesPersonalDetails/Create
        //EmployeesPersonalDetails

        [HttpGet]
        public IActionResult CreatePersonalDetails()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePersonalDetails(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            employee.SysDate = DateTime.Now;
            employeesManage.SaveEmployee(employee);
            TempData["SuccessMsg"] = $"Employee {employee.FullName} personal details created successfully";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddParents(int empID)
        {
            //ViewBag.Employee = employee;
            //var emp = employeesManage.GetEmployee(id);

            ViewBag.EmployeeID = empID;  //to take same employeeID from create new employee view
            List<Parent> parents = employeesManage.GetParents(empID); // this method

            return View(parents);
        }


        [HttpPost]
        public IActionResult AddParents(Parent parent)
        {
            Employee associatedEmployee = employeesManage.GetEmployee(parent.EmployeeID);

            if (!ModelState.IsValid || associatedEmployee == null)
            {
                TempData["ErrorMsg"] = "Error submitting the form.";
                List<Parent> existingParents = employeesManage.GetParents(parent.EmployeeID);
                return View(existingParents);
            }

            // At this point, the form submission is valid and the associated data exists
            //parent.EmployeeID = empID; // Set the EmployeeID for the Parent

            employeesManage.SaveParent(parent.EmployeeID, parent); // Save parent data to the database

            ViewBag.Msg = parent.Name;

            return View("Index");
        }

        ///////////////////////////////
        [HttpGet]
        public IActionResult AddChildren(int empID)
        {
            //ViewBag.Employee = employee;
            //var emp = employeesManage.GetEmployee(id);

            ViewBag.EmployeeID = empID;  //to take same employeeID from create new employee view
            List<Children> children = employeesManage.GetChildren(empID); // this method

            return View(children);
        }


        [HttpPost]
        public IActionResult AddChildren(Children children)
        {
            Employee associatedEmployee = employeesManage.GetEmployee(children.EmployeeID);

            if (!ModelState.IsValid || associatedEmployee == null)
            {
                TempData["ErrorMsg"] = "Error submitting the form.";
                List<Children> existingChildren = employeesManage.GetChildren(children.EmployeeID);
                return View(existingChildren);
            }

            // At this point, the form submission is valid and the associated data exists
            //parent.EmployeeID = empID; // Set the EmployeeID for the Parent

            employeesManage.SaveChildren(children.EmployeeID, children); // Save parent data to the database

            ViewBag.Msg = children.Name;

            return View("Index");
        }
        //ssssssssssssssssssssssssssssssssssssssssssssssssssssssssss
        [HttpGet]
        public IActionResult AddSpouse(int empID)
        {
            //ViewBag.Employee = employee;
            //var emp = employeesManage.GetEmployee(id);

            ViewBag.EmployeeID = empID;  //to take same employeeID from create new employee view
            List<Spouse> spouse = employeesManage.GetSpouse(empID); // this method

            return View(spouse);
        }


        [HttpPost]
        public IActionResult AddSpouse(Spouse spouse)
        {
            Employee associatedEmployee = employeesManage.GetEmployee(spouse.EmployeeID);

            if (!ModelState.IsValid || associatedEmployee == null)
            {
                TempData["ErrorMsg"] = "Error submitting the form.";
                List<Spouse> existingSpouse = employeesManage.GetSpouse(spouse.EmployeeID);
                return View(existingSpouse);
            }

            // At this point, the form submission is valid and the associated data exists
            //parent.EmployeeID = empID; // Set the EmployeeID for the Parent

            employeesManage.SaveSpouse(spouse.EmployeeID, spouse); // Save parent data to the database

            ViewBag.Msg = spouse.Name;

            return View("Index");
        }
        //siblingggggggggggggggggggggggggg
        [HttpGet]
        public IActionResult AddSibling(int empID)
        {
            //ViewBag.Employee = employee;
            //var emp = employeesManage.GetEmployee(id);

            ViewBag.EmployeeID = empID;  //to take same employeeID from create new employee view
            List<Sibling> sibling = employeesManage.GetSibling(empID); // this method

            return View(sibling);
        }


        [HttpPost]
        public IActionResult AddSibling(Spouse spouse)
        {
            Employee associatedEmployee = employeesManage.GetEmployee(spouse.EmployeeID);

            if (!ModelState.IsValid || associatedEmployee == null)
            {
                TempData["ErrorMsg"] = "Error submitting the form.";
                List<Spouse> existingSpouse = employeesManage.GetSpouse(spouse.EmployeeID);
                return View(existingSpouse);
            }

            // At this point, the form submission is valid and the associated data exists
            //parent.EmployeeID = empID; // Set the EmployeeID for the Parent

            employeesManage.SaveSpouse(spouse.EmployeeID, spouse); // Save parent data to the database

            ViewBag.Msg = spouse.Name;

            return View("Index");

        }
            //RealEstate //////
            [HttpGet]
            public IActionResult AddRealEstate(int empID, int RealEstateTypeId)
            {
                //ViewBag.Employee = employee;
                //var emp = employeesManage.GetEmployee(id);

                ViewBag.EmployeeID = empID;  //to take same employeeID from create new employee view

            int realEstateTypeId = RealEstateTypeId;
            List<RealEstateType> realEstateTypes = employeesManage.GetRealEstateTypesFromDatabase(realEstateTypeId);
            // Pass the SelectList to the view
            ViewBag.RealEstateTypeSelectList = new SelectList(realEstateTypes, "RealEstateTypeId", "RealEstateTypeName");


            List<RealEstate> realEstate = employeesManage.GetAllRealEstate(empID);
            return View(realEstate);
            
            }

        [HttpPost]
        public IActionResult AddRealEstate(RealEstate realEstate)
        { 
            Employee associatedEmployee = employeesManage.GetEmployee(realEstate.EmployeeID);

            if (!ModelState.IsValid || associatedEmployee == null)
            {
                TempData["ErrorMsg"] = "Error submitting the form.";
                List<RealEstate> existingRealEstate= employeesManage.GetAllRealEstate(realEstate.EmployeeID);
                return View(existingRealEstate);              
            }
            employeesManage.SaveRealEstate(realEstate.EmployeeID, realEstate);           
           

            return View("Index");
        }


        }
        }


