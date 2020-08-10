using Microsoft.AspNetCore.Mvc;
    namespace YourNamespace.Controllers     //be sure to use your own project's namespace!
    {
        public class HomeController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet("")]    //associated route string (exclude the leading /)
            public ViewResult Home()
            {
                return View();
            }

            [HttpGet("projects")]    //associated route string (exclude the leading /)
            public ViewResult Projects()
            {
                return View();
            }

            [HttpGet("contact")]    //associated route string (exclude the leading /)
            public ViewResult Contact()
            {
                return View();
            }
            
        }
    }