using System.ComponentModel;

namespace WelfareSurveySystem.WebUI.Models
{
    public class RequestTaskViewModel
    {
        [DisplayName("Form Name")]
        public string FormName { get; set; }
        [DisplayName("Task Request ID")]
        public int TaskRequestID { get; set; }
        [DisplayName("From Service Number")]
        public string FromServiceNo { get; set; }
        [DisplayName("Service Number")]
        public string ServiceNo { get; set; }

    }
}
