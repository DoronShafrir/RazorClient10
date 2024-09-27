using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;
using System.Collections.Generic;
using System.Globalization;

namespace RazorCLient.Pages
{
    public class StudentsModel : PageModel
    {
        [BindProperty]
        public string studentID { get; set; }   
        public StudentList list { get; set; }
        public Student student { get; set; } /*= new Student();*/
        [BindProperty]
        public string firstName { get; set; }
        [BindProperty]
        public string lastName { get; set; }

        public void OnGet()
        {
            ServiceReference1.Service1Client srv = new ServiceReference1.Service1Client();
            list = srv.GetStudentList();
            srv.Close();
        }
        public IActionResult OnPostSelectAll(string studentID)
        {
            ServiceReference1.Service1Client srv = new ServiceReference1.Service1Client();
            list = srv.GetStudentList();
            srv.Close();
            return Page();
            
        }

        public IActionResult OnPostSearchById(string studentID)
        {
            if (!String.IsNullOrEmpty(studentID)) { 
            int id = int.Parse(studentID);
            Service1Client srv = new Service1Client();
            list = srv.GetStudentListById(id);
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
                list = srv.GetStudentListByName(firstName, lastName);
                srv.Close();
                return Page();

            }
            return Page();
        }
    }
}
