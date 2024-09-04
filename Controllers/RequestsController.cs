using Microsoft.AspNetCore.Mvc;
using SchoolProject.Data;
using SchoolProject.Models;

namespace SchoolProject.Controllers
{
    public class RequestsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RequestsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //postcreate
        public async Task<IActionResult> Create(AddNurseRequestDto nurseRequest)
        {
                var request1  = new NurseRequest()
            {
                PatientType = nurseRequest.PatientType,
                PortalType = nurseRequest.PortalType,
                Remark = nurseRequest.Remark,
                StartPoint = nurseRequest.StartPoint,
                EndPoint = nurseRequest.EndPoint
            };

               var request2 = new Patient()
            {
                Qn = nurseRequest.Qn
            };
          
            await _context.NurseRequests.AddAsync(request1);  
            await _context.NurseRequests.AddAsync(request2);
            await _context.SaveChangesAsync();


            return RedirectToAction("Index");
        }
    }
}