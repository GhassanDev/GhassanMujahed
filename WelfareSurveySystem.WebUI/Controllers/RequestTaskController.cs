using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WelfareSurveySystem.Domain.DataRepositories;
using WelfareSurveySystem.Domain.Entities;
using WelfareSurveySystem.WebUI.Models;

namespace WelfareSurveySystem.WebUI.Controllers
{

    public class RequestTaskController : Controller
    {
        //comment
        private ITaskRequestRepository taskRequestRepository;
        private readonly IEmployeeRepository empRepo;

        public RequestTaskController(ITaskRequestRepository taskRequestRepository, IEmployeeRepository empRepo)
        {

            //return View();
            this.taskRequestRepository = taskRequestRepository;
            this.empRepo = empRepo;
        }
       // [Authorize(Roles = "resercher")]
        public IActionResult MyTasks()
        {
            // TODO:
            // get the current user login id
            // get the service number from login id

            // Data Layer
            // Add repository for TaskRequest

            // get the current login employee branch
            // get all the tasks for that branch
            // create MyTasksViewModel and fill into this
            // return that MyTasksViewModel to view



            string serviceNo = User.Identity.Name;
            // get the branch from service no
            string currentUserBranch = empRepo.GetAllEmployees().Where(e => e.ServiceNo == serviceNo).FirstOrDefault()?.Branch;


            List<TaskRequest> tasks = taskRequestRepository.GetAllTaskByBranchID(currentUserBranch);

            //var formname = tasks

            // convert TaskRequest Domain Model to RequestTaskViewModel
            var tasksVM = from t in tasks
                          select new RequestTaskViewModel
                          {
                              FormName = t.WelfareForm.FormName,
                              FromServiceNo = t.FromServiceNo,
                              ServiceNo = t.WelfareForm.ServiceNo,
                              TaskRequestID = t.TaskRequestID
                          };

            ViewBag.Branch = currentUserBranch;
            return View(tasksVM.ToList());
        }

       // [Authorize(Roles = "requester")]
        public IActionResult MyRequests()
        {



            // TODO:
            // get the current user login id
            // get the service number from login id
            string logedinUserServiceNo = "123";
            // Data Layer
            // Add repository for TaskRequest

            // 
            // get all the tasks for that  from service number
            // create MyRequestViewModel and fill into this
            // return that MyRequestViewModel to view
            return View();
        }

        public IActionResult Details(string serviceNo)
        {
            var details = empRepo.GetEmployeeDetails(serviceNo).FirstOrDefault();
            //childrens = new List<Children>().ToList<Person>();
            return View(details);
        }
    }
}
