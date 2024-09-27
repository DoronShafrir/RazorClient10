using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;

namespace RazorCLient.Pages
{
    public class LecturersModel : PageModel
    {
        public LecturerList list { get; set; }
        public Lecturer lecturer { get; set; }

        [BindProperty]
        public string lecturerID { get; set; }
        [BindProperty]
        public string firstName { get; set; }
        [BindProperty]
        public string lastName { get; set; }





        public void OnGet()
        {


            Service1Client srv = new Service1Client();
            list = srv.GetLecturertList();
            srv.Close();

        }
        public IActionResult OnPostSelectAll(string studentID)
        {
            ServiceReference1.Service1Client srv = new ServiceReference1.Service1Client();
            list = srv.GetLecturertList();
            srv.Close();
            return Page();

        }

        public IActionResult OnPostSearchById(string lecturerID)
        {
            if (!String.IsNullOrEmpty(lecturerID))
            {
                int id = int.Parse(lecturerID);
                Service1Client srv = new Service1Client();
                list = srv.GetLecturertListById(id);
                srv.Close();
                return Page();

            }
            return Page();
        }

        public IActionResult OnPostSearchByName(string firstName, string lastName)
        {
            if (!String.IsNullOrEmpty(firstName) &&
                !String.IsNullOrEmpty(lastName))
            {

                Service1Client srv = new Service1Client();
                list = srv.GetLecturertListByName(firstName, lastName);
                srv.Close();
                return Page();

            }
            return Page();
        }


    }
}
