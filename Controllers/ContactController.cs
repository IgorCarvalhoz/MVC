using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Models;
using MVC.Context;

namespace MVC.Controllers
{
    public class ContactController : Controller {
    
        private readonly ContextTable? _context;
    
        public ContactController(ContextTable context)
        {
            _context = context;
        }
        public IActionResult Index(){
        return View();
    }
}
}