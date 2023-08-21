using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Await_DotNet_PrototypeVersion_2.Areas.Identity;

public class User : IdentityUser
{
    public string CompanyName { get; set; }

}

