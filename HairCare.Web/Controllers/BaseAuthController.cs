﻿using HairCare.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HairCare.Web.Controllers
{
    [AuthAttribute]
    public class BaseAuthController : BaseController
    {

	}
}