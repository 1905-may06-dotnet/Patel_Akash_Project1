#pragma checksum "C:\Users\Akash\Desktop\Project1\Patel_Akash_Project1\PizzaWebsite\Views\Home\UserPreview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32de5bf7fa0adab28e6d77d6f239b3727deda4f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserPreview), @"mvc.1.0.view", @"/Views/Home/UserPreview.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UserPreview.cshtml", typeof(AspNetCore.Views_Home_UserPreview))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32de5bf7fa0adab28e6d77d6f239b3727deda4f2", @"/Views/Home/UserPreview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09a9b8f841a4bea81607ef531e86e869b618f30c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserPreview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Akash\Desktop\Project1\Patel_Akash_Project1\PizzaWebsite\Views\Home\UserPreview.cshtml"
  
    ViewData["Title"] = "UserPreview";

#line default
#line hidden
            BeginContext(49, 71, true);
            WriteLiteral("\r\n<h1>UserPreview</h1>\r\n<p>Your order is \" \" and costs \" \".</p>\r\n\r\n<h2>");
            EndContext();
            BeginContext(121, 54, false);
#line 9 "C:\Users\Akash\Desktop\Project1\Patel_Akash_Project1\PizzaWebsite\Views\Home\UserPreview.cshtml"
Write(Html.ActionLink("Confirm Order", "UserOption", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(175, 13, true);
            WriteLiteral("</h2>\r\n\r\n<h2>");
            EndContext();
            BeginContext(189, 50, false);
#line 11 "C:\Users\Akash\Desktop\Project1\Patel_Akash_Project1\PizzaWebsite\Views\Home\UserPreview.cshtml"
Write(Html.ActionLink("Edit Order", "UserOrder", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(239, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
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
