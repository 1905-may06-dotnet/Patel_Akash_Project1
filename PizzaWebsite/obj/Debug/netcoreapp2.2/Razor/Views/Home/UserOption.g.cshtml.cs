#pragma checksum "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\Home\UserOption.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7be64318360a518c9833a7b32c96d4e3c8b0dff2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserOption), @"mvc.1.0.view", @"/Views/Home/UserOption.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UserOption.cshtml", typeof(AspNetCore.Views_Home_UserOption))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7be64318360a518c9833a7b32c96d4e3c8b0dff2", @"/Views/Home/UserOption.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09a9b8f841a4bea81607ef531e86e869b618f30c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserOption : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\Home\UserOption.cshtml"
  
    ViewData["Title"] = "User Options Page";
    String username = "";

#line default
#line hidden
            BeginContext(75, 30, true);
            WriteLiteral(" <!-- get the user\'s name-->\r\n");
            EndContext();
            BeginContext(108, 58, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Hi ");
            EndContext();
            BeginContext(167, 8, false);
#line 7 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\Home\UserOption.cshtml"
                        Write(username);

#line default
#line hidden
            EndContext();
            BeginContext(175, 44, true);
            WriteLiteral(" , What would you like to do?</h1>\r\n    <h2>");
            EndContext();
            BeginContext(220, 57, false);
#line 8 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\Home\UserOption.cshtml"
   Write(Html.ActionLink("Show Locations", "UserLocation", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(277, 15, true);
            WriteLiteral("</h2>\r\n    <h2>");
            EndContext();
            BeginContext(293, 43, false);
#line 9 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\Home\UserOption.cshtml"
   Write(Html.ActionLink("Log Out", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(336, 15, true);
            WriteLiteral("</h2>\r\n    <h2>");
            EndContext();
            BeginContext(352, 54, false);
#line 10 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\Home\UserOption.cshtml"
   Write(Html.ActionLink("View History", "UserHistory", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(406, 379, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591