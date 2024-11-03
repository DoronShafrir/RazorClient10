using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference2;

namespace RazorCLient.Pages
{
    public class StudentUpdateModel : PageModel
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
        [BindProperty]
        public string msg { get; set; }
        [BindProperty]
        public int param { get; set; }
        


        public void OnGet(int param)
        {
             
            ServiceReference2.Service1Client srv = new ServiceReference2.Service1Client();
            TempData["param"] = param.ToString();
            list = srv.GetStudentListById(param);
            cityList = srv.GetCityList();
            srv.Close();
        }


        public IActionResult OnPostUpdateStudent(string FName, string LName, String Phone, int cities)
        {
            param = int.Parse(TempData["param"].ToString());
            int done = -1;
            if (!String.IsNullOrEmpty(FName) && !String.IsNullOrEmpty(LName) && cities != 0)
            {

                city.Id = cities;
                student = new Student()
                {
                    Id = param,
                    Fname = FName,
                    Lname = LName,
                    City = city,

                };

                if (!String.IsNullOrEmpty(Phone)) student.Phone = int.Parse(Phone);

                Service1Client srv = new Service1Client();
                done = srv.GetUpdateStudent(student);
                list = srv.GetStudentListById(param);
                cityList = srv.GetCityList();
                srv.Close();
                if (done == 0) msg = "Student added succesfuly";
            }

            else
            {
                msg = "fields cannot stay empty";
                Service1Client srv = new Service1Client();
                list = srv.GetStudentListById(param);
                cityList = srv.GetCityList();
                srv.Close();
            }

            return Page();

        }
    }
}
