using Microsoft.EntityFrameworkCore;
using WelfareSurveySystem.Domain.DataRepositories;
using WelfareSurveySystem.Domain.Entities;

namespace WelfareSurveySystem.Data
{
    public class TaskRequestRepository : ITaskRequestRepository
    {
        private WelfareSurveySystemDBContext db;// = new WelfareSurveySystemDBContext();

        public TaskRequestRepository(WelfareSurveySystemDBContext db)
        {
            this.db = db;
        }

        public List<TaskRequest> GetAllTaskByBranchID(string branch)
        {
            return db.TaskRequests.Include("WelfareForm").Where(t => t.Branch == branch).ToList();
        }
    }
}
