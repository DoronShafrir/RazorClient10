using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;
using System.Security.Cryptography.X509Certificates;

namespace RazorCLient.Pages
{
    public class IndexModel : PageModel
    {
        //public StudentList list { get; set; }


        //public Student student { get; set; }


        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {


            ServiceReference1.Service1Client srv = new ServiceReference1.Service1Client();
            //list = srv.GetStudentList();
            srv.Close();


        }
    }
}
