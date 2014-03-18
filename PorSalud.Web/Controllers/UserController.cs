using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiniDropbox.Domain.Services;
using PorSalud.Web.Models;

namespace PorSalud.Web.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        private readonly IReadOnlyRepository _readOnlyRepository;
        private readonly IWriteOnlyRepository _writeOnlyRepository;

        public UserController(IReadOnlyRepository readOnlyRepository, IWriteOnlyRepository writeOnlyRepository)
        {
            _readOnlyRepository = readOnlyRepository;
            _writeOnlyRepository = writeOnlyRepository;
        }

        public ActionResult Login()
        {
            return View( new UserLoginModel());
        }

    }
}
