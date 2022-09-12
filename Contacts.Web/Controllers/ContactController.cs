using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Contact.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Threading;
using Services;

namespace Contact.Controllers
{
    public class ContactController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IContactService _contactService;

        public ContactController(IConfiguration configuration, IContactService contactService)
        {
            this._configuration = configuration;
            this._contactService = contactService;
        }

        public IActionResult Index()
        {
            var contacts = _contactService.GetList();
            return View(contacts);
        }
    }
}
