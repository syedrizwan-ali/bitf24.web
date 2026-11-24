//using FCIT.BITF24A.Web.DiPractice;
//using FCIT.BITF24A.Web.DiPractice_01;
//using FCIT.BITF24A.Web.Models;
//using FCIT.BITF24A.Web.OrmModels;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace FCIT.BITF24A.Web.Controllers
//{
//    public class StudentsController : Controller
//    {
//        private Bitf24DbContext _dbContext;
//        ILogger<StudentsController>  _logger;
//        IPaymentMethod _paymentMethod;

//        public StudentsController(Bitf24DbContext dbContext, 
//            ILogger<StudentsController> logger,
//            [FromKeyedServices("apple")] IPaymentMethod paymentMethod)
//        {
//            _dbContext = dbContext;
//            _logger = logger;
//            _paymentMethod = paymentMethod;
//        }

//        // GET: StudentsController
//        public ActionResult Index()
//        {
//            var list = _dbContext.Students.Select(x => new StudentModel(x)).ToList();

//            var result = _paymentMethod.Pay(200);
//            _logger.LogError(result);

//            return View(list);
//        }

//        // GET: StudentsController/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: StudentsController/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: StudentsController/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(IFormCollection collection)
//        {
//            //try
//            //{
//            //    var student = new StudentModel()
//            //    {
//            //        ID = _data.Count + 1,
//            //        Name = collection["name"],
//            //        RollNumber = collection["RollNumber"],
//            //        CreateOn = DateTime.Now
//            //    };

//            //    _data.Add(student);

//            //    return RedirectToAction(nameof(Index));
//            //}
//            //catch
//            //{
//            //    return View();
//            //}
//            return View();
//        }

//        // GET: StudentsController/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        // POST: StudentsController/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: StudentsController/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: StudentsController/Delete/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Delete(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//}
