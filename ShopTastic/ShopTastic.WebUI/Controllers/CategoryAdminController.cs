using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopTastic.WebUI.Controllers
{

    [Authorize(Roles = "Admin")]
    public class CategoryAdminController
    {
    }
}