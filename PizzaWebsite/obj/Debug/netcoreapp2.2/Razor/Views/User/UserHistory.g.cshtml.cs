#pragma checksum "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\User\UserHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "025b003d60ac0048aa6626dc144bbafdb557b874"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserHistory), @"mvc.1.0.view", @"/Views/User/UserHistory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/UserHistory.cshtml", typeof(AspNetCore.Views_User_UserHistory))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"025b003d60ac0048aa6626dc144bbafdb557b874", @"/Views/User/UserHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09a9b8f841a4bea81607ef531e86e869b618f30c", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PizzaWebsite.Models.OrderModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\User\UserHistory.cshtml"
  
    ViewData["Title"] = "UserHistory";

#line default
#line hidden
            BeginContext(101, 23, true);
            WriteLiteral("\r\n<h1>User History for ");
            EndContext();
            BeginContext(125, 20, false);
#line 7 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\User\UserHistory.cshtml"
                Write(ViewData["username"]);

#line default
#line hidden
            EndContext();
            BeginContext(145, 104, true);
            WriteLiteral("</h1>\r\n\r\n<p>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(250, 44, false);
#line 15 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\User\UserHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(294, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(350, 43, false);
#line 18 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\User\UserHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderID));

#line default
#line hidden
            EndContext();
            BeginContext(393, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(449, 50, false);
#line 21 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\User\UserHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderTotalCost));

#line default
#line hidden
            EndContext();
            BeginContext(499, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(555, 49, false);
#line 24 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\User\UserHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(604, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 30 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\User\UserHistory.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(722, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(771, 43, false);
#line 33 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\User\UserHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
            EndContext();
            BeginContext(814, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(870, 42, false);
#line 36 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\User\UserHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderID));

#line default
#line hidden
            EndContext();
            BeginContext(912, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(968, 49, false);
#line 39 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\User\UserHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderTotalCost));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1073, 48, false);
#line 42 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\User\UserHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1121, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\User\UserHistory.cshtml"
}

#line default
#line hidden
            BeginContext(1160, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PizzaWebsite.Models.OrderModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
