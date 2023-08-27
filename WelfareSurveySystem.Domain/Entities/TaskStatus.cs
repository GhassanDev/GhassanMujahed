namespace WelfareSurveySystem.Domain.Entities
{
    public class TaskStatus
    {
        public int TaskStatusID { get; set; }
        public int TaskRequestID { get; set; }
        public string Status { get; set; }
        public DateTime DateCompleted { get; set; }
        public string CompletedByServiceNo { get; set; }
    }
}
