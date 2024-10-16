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
        public string hide { get; set; }
        public string notHide { get; set; }
        [BindProperty]
        public string msg { get; set; }
        [BindProperty]
        public int param { get; set; }
        [BindProperty]
        public string replace { get; set; }
        [BindProperty]
        public string selected { get; set; }


        public void OnGet(int param)
        {
             
            ServiceReference2.Service1Client srv = new ServiceReference2.Service1Client();
            list = srv.GetStudentListById(param);
            cityList = srv.GetCityList();
            srv.Close();
        }
    }
}
