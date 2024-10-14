using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference2;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace RazorCLient.Pages
{
    public class StudentsModel : PageModel
    {
        [BindProperty]
        public string studentID { get; set; }
        public Student student { get; set; } = new Student();
        public StudentList list { get; set; } = new StudentList();
        [BindProperty]
        public CityList cityList { get; set; } = new CityList();
        public City city { get; set; } = new City();
        [BindProperty]
        public string firstName { get; set; }
        [BindProperty]
        public string lastName { get; set; }
        public string hide { get; set; }
        public string notHide { get; set; }
        [BindProperty]
        public string msg { get; set; }
        public string dispalyStatus { get; set; }
        [BindProperty]
        public int studentDelete {  get; set; }



        public void OnGet()
        {
            ServiceReference2.Service1Client srv = new ServiceReference2.Service1Client();
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
            ServiceReference2.Service1Client srv = new ServiceReference2.Service1Client();
            list = srv.GetStudentList();
            srv.Close();
            return Page();

        }

        public IActionResult OnPostSearchById(string studentID)
        {
            if (!String.IsNullOrEmpty(studentID))
            {
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
            if (dispalyStatus == "True")
            {
                Service1Client srv = new Service1Client();
                cityList = srv.GetCityList();
                srv.Close();
                hide = "none"; notHide = "block";
                HttpContext.Session.SetString("InsertStudent", "False");
                OnPostSelectAll();
            }
            else
            {
                hide = "block";
                notHide = "none";
                HttpContext.Session.SetString("InsertStudent", "True");
                OnPostSelectAll();
            }


            return Page();
        }







        public IActionResult OnPostInsertStudent(string FName, string LName, String Phone, int cities)
        {
            int done = -1;
            if (!String.IsNullOrEmpty(FName) && !String.IsNullOrEmpty(LName) && cities != 0)
            {

                city.Id = cities;
                student = new Student()
                {
                    Fname = FName,
                    Lname = LName,
                    City = city,

                };

                if (!String.IsNullOrEmpty(Phone)) student.Phone = int.Parse(Phone);



                Service1Client srv = new Service1Client();
                done = srv.GetInsertStudent(student);
                srv.Close();
                if (done == 0) msg = "Student added succesfuly";
            }

            else
            {
                msg = "fields cannot stay empty";
                Service1Client srv = new Service1Client();
                cityList = srv.GetCityList();
                srv.Close();
            }

            return Page();

        }

        public IActionResult OnPostDeleteStudent(int studentDelete)
        {
            Service1Client srv = new Service1Client();
            srv.GetCreateDeleteByIdSql(studentDelete);
            srv.Close();
            hide = "block";
            notHide = "none";
            HttpContext.Session.SetString("InsertStudent", "True");
            OnPostSelectAll();
            return Page();
        }

          
    }

}
