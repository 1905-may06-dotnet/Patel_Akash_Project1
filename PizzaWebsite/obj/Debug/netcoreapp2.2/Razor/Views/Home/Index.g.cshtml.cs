#pragma checksum "C:\Users\Akash\Desktop\Project1\Patel_Akash_Project1\PizzaWebsite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "074740e9cad033f1f6c0208463b751091b5aad42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Akash\Desktop\Project1\Patel_Akash_Project1\PizzaWebsite\Views\_ViewImports.cshtml"
using PizzaWebsite;

#line default
#line hidden
#line 2 "C:\Users\Akash\Desktop\Project1\Patel_Akash_Project1\PizzaWebsite\Views\_ViewImports.cshtml"
using PizzaWebsite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"074740e9cad033f1f6c0208463b751091b5aad42", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09a9b8f841a4bea81607ef531e86e869b618f30c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Akash\Desktop\Project1\Patel_Akash_Project1\PizzaWebsite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 113, true);
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Welcome to the PizzaBox Website</h1>\r\n        <h2>");
            EndContext();
            BeginContext(159, 41, false);
#line 7 "C:\Users\Akash\Desktop\Project1\Patel_Akash_Project1\PizzaWebsite\Views\Home\Index.cshtml"
       Write(Html.ActionLink("Login", "Login", "User"));

#line default
#line hidden
            EndContext();
            BeginContext(200, 19, true);
            WriteLiteral("</h2>\r\n        <h2>");
            EndContext();
            BeginContext(220, 47, false);
#line 8 "C:\Users\Akash\Desktop\Project1\Patel_Akash_Project1\PizzaWebsite\Views\Home\Index.cshtml"
       Write(Html.ActionLink("Register", "Register", "User"));

#line default
#line hidden
            EndContext();
            BeginContext(267, 19, true);
            WriteLiteral("</h2>\r\n        <h2>");
            EndContext();
            BeginContext(287, 52, false);
#line 9 "C:\Users\Akash\Desktop\Project1\Patel_Akash_Project1\PizzaWebsite\Views\Home\Index.cshtml"
       Write(Html.ActionLink("Admin Login", "AdminLogin", "User"));

#line default
#line hidden
            EndContext();
            BeginContext(339, 387, true);
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
