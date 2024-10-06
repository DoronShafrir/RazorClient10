using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace RazorCLient.Pages
{
    public class StudentsModel : PageModel
    {
        [BindProperty]
        public string studentID { get; set; } 
        public StudentList list { get; set; }
        public Student student { get; set; } = new Student();
        [BindProperty]
        public string firstName { get; set; }
        [BindProperty]
        public string lastName { get; set; }
        public string hide { get; set; } 
        public string notHide { get; set; }
       
        public string dispalyStatus { get; set; }

        

        

        public void OnGet()
        {
            ServiceReference1.Service1Client srv = new ServiceReference1.Service1Client();
            list = srv.GetStudentList();
            srv.Close();
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("InsertStudent")))
            {
                HttpContext.Session.SetString("InsertStudent", "True");
                hide = "block";
                notHide = "none";
            }
        }
        public IActionResult OnPostSelectAll()
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

        public IActionResult OnPostAddStudentDisplay()
        {

            dispalyStatus = HttpContext.Session.GetString("InsertStudent");
            if (dispalyStatus == "True") {hide = "none"; notHide = "block"; HttpContext.Session.SetString("InsertStudent","False"); }
            else { hide = "block"; notHide = "none"; HttpContext.Session.SetString("InsertStudent", "True"); OnPostSelectAll(); }


            return Page();
        }
      
    public IActionResult OnPostInsertStudent( string FName, string LName, string CityName, String Phone)
    {
            student = new Student()
            {
                Fname = FName,
                Lname = LName,             
                Phone = int.Parse(Phone)
            };
            ServiceReference1.Service1Client srv = new ServiceReference1.Service1Client();
            int done = srv.GetInsertStudent(student);

            srv.Close();



            return Page();

    }


    }
    
}
