#pragma checksum "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\User\UserOption.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a52779e13be3642b32f8e22aa39efc6c97d5163"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserOption), @"mvc.1.0.view", @"/Views/User/UserOption.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/UserOption.cshtml", typeof(AspNetCore.Views_User_UserOption))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\_ViewImports.cshtml"
using PizzaWebsite;

#line default
#line hidden
#line 2 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\_ViewImports.cshtml"
using PizzaWebsite.Models;

#line default
#line hidden
#line 1 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\User\UserOption.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 2 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\User\UserOption.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#line 3 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\User\UserOption.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a52779e13be3642b32f8e22aa39efc6c97d5163", @"/Views/User/UserOption.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09a9b8f841a4bea81607ef531e86e869b618f30c", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserOption : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaWebsite.Models.UserModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(115, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\User\UserOption.cshtml"
  
    ViewData["Title"] = "UserOptions";

#line default
#line hidden
            BeginContext(202, 56, true);
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Hi ");
            EndContext();
            BeginContext(259, 20, false);
#line 10 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\User\UserOption.cshtml"
                        Write(ViewData["username"]);

#line default
#line hidden
            EndContext();
            BeginContext(279, 43, true);
            WriteLiteral(", What would you like to do?</h1>\r\n    <h2>");
            EndContext();
            BeginContext(323, 61, false);
#line 11 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\User\UserOption.cshtml"
   Write(Html.ActionLink("Show Locations", "UserLocation", "Location"));

#line default
#line hidden
            EndContext();
            BeginContext(384, 15, true);
            WriteLiteral("</h2>\r\n    <h2>");
            EndContext();
            BeginContext(400, 43, false);
#line 12 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\User\UserOption.cshtml"
   Write(Html.ActionLink("Log Out", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(443, 15, true);
            WriteLiteral("</h2>\r\n    <h2>");
            EndContext();
            BeginContext(459, 54, false);
#line 13 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\User\UserOption.cshtml"
   Write(Html.ActionLink("View History", "UserHistory", "User"));

#line default
#line hidden
            EndContext();
            BeginContext(513, 379, true);
            WriteLiteral(@"</h2>
    <!--
     This is the card coded way of creating a link in HTML to another page without using razor syntax

     <a class=""nav-link text-dark"" asp-area="""" asp-controller=""Home"" asp-action=""Login""><button>Login</button></a>
     <a class=""nav-link text-dark"" asp-area="""" asp-controller=""Home"" asp-action=""Register""><button>Register</button></a>

    -->
</div>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaWebsite.Models.UserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
