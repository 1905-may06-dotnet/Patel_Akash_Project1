#pragma checksum "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\Order\UserPreset.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27f0b9d7ec7008adb9041b38c8dcfc00d68c99ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_UserPreset), @"mvc.1.0.view", @"/Views/Order/UserPreset.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/UserPreset.cshtml", typeof(AspNetCore.Views_Order_UserPreset))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27f0b9d7ec7008adb9041b38c8dcfc00d68c99ee", @"/Views/Order/UserPreset.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09a9b8f841a4bea81607ef531e86e869b618f30c", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_UserPreset : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaWebsite.Models.PizzaModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "LargeVeg", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "SmallPizza", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_self"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\Order\UserPreset.cshtml"
  
    ViewData["Title"] = "Preset Pizza";

#line default
#line hidden
            BeginContext(88, 7, false);
#line 5 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\Order\UserPreset.cshtml"
Write(ViewBag);

#line default
#line hidden
            EndContext();
            BeginContext(95, 5, true);
            WriteLiteral(";\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(118, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\Order\UserPreset.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
            BeginContext(191, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 13 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\Order\UserPreset.cshtml"
  
    ViewData["Title"] = "UserPreset";

#line default
#line hidden
            BeginContext(243, 35, true);
            WriteLiteral("\r\n<h1>Order a Preset Pizza</h1>\r\n\r\n");
            EndContext();
            BeginContext(278, 385, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27f0b9d7ec7008adb9041b38c8dcfc00d68c99ee5901", async() => {
                BeginContext(313, 60, true);
                WriteLiteral("\r\n    <p>Pizza Name</p>\r\n    <select name=\"Pizza\">\r\n        ");
                EndContext();
                BeginContext(373, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27f0b9d7ec7008adb9041b38c8dcfc00d68c99ee6347", async() => {
                    BeginContext(398, 16, true);
                    WriteLiteral("5ToppingLargeVeg");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(423, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(433, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27f0b9d7ec7008adb9041b38c8dcfc00d68c99ee7828", async() => {
                    BeginContext(460, 18, true);
                    WriteLiteral("2ToppingSmallPizza");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(487, 169, true);
                WriteLiteral("\r\n    </select>\r\n    <br><br>\r\n    <p>Pizza Quantity</p>\r\n    <input type=\"number\" max=\"100\" min=\"1\" />\r\n    <br><br>\r\n    <input type=\"submit\" value=\"Add Pizza(s)\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(663, 48, true);
            WriteLiteral("\r\n<p>Your current total cost is \" \".</p>\r\n\r\n<h2>");
            EndContext();
            BeginContext(712, 56, false);
#line 33 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\Order\UserPreset.cshtml"
Write(Html.ActionLink("Order More?", "CustomOrPreset", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(768, 11, true);
            WriteLiteral("</h2>\r\n<h2>");
            EndContext();
            BeginContext(780, 54, false);
#line 34 "C:\Revature\Patel_Akash_Project0\PizzaWebsite\Views\Order\UserPreset.cshtml"
Write(Html.ActionLink("Finish Order", "UserPreview", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(834, 7, true);
            WriteLiteral("</h2>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaWebsite.Models.PizzaModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
