#pragma checksum "D:\softuni\TravelTogether\TravelTogether\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c5eac5a32e58a37c544d312bb4bce34163d89f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
#line 1 "D:\softuni\TravelTogether\TravelTogether\Views\_ViewImports.cshtml"
using TravelTogether;

#line default
#line hidden
#line 2 "D:\softuni\TravelTogether\TravelTogether\Views\_ViewImports.cshtml"
using TravelTogether.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c5eac5a32e58a37c544d312bb4bce34163d89f3", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fdde90fb5b5e01cdd8c72072593bfca63aaa9ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelTogether.ViewModels.Account.RegisterInputModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Account/Register"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\softuni\TravelTogether\TravelTogether\Views\Account\Register.cshtml"
  
    ViewData["Title"] = "Register";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(154, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Links", async() => {
                BeginContext(171, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(178, 204, true);
            WriteLiteral("\r\n<div class=\"owl\">\r\n    <div class=\"hand\"></div>\r\n    <div class=\"hand hand-r\"></div>\r\n    <div class=\"arms\">\r\n        <div class=\"arm\"></div>\r\n        <div class=\"arm arm-r\"></div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(382, 1832, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "739d14311cdb4b00a4f2489aa0d48333", async() => {
                BeginContext(429, 1417, true);
                WriteLiteral(@"
    <div class=""register-form"">
        <div class=""control"">
            <label for=""username""></label>
            <input id=""username"" placeholder=""Username"" name=""Username"" type=""text"" />           
        </div>
        <div class=""control"">
            <label for=""password""></label>
            <input id=""password"" placeholder=""Password"" name=""Password"" type=""password"" />
        </div>
        <div class=""control"">
            <label for=""confirmPassword""></label>
            <input id=""confirmPassword"" placeholder=""Confirm Password"" name=""ConfirmPassword"" type=""password"" />
        </div>
        <div class=""control"">
            <label for=""firstName""></label>
            <input id=""firstName"" placeholder=""First Name"" name=""FirstName"" type=""text"" />
        </div>
        <div class=""control"">
            <label for=""lastName""></label>
            <input id=""lastName"" placeholder=""Last Name"" name=""LastName"" type=""text"" />
        </div>
        <div class=""control"">
         ");
                WriteLiteral(@"   <label for=""country""></label>
            <input id=""country"" placeholder=""Country"" name=""Country"" type=""text"" />
        </div>
        <div class=""control"">
            <label for=""city""></label>
            <input id=""city"" placeholder=""City"" name=""City"" type=""text"" />
        </div>
        <div class=""control"">
            <span class=""ui grey inverted header"">Male : </span>");
                EndContext();
                BeginContext(1847, 63, false);
#line 51 "D:\softuni\TravelTogether\TravelTogether\Views\Account\Register.cshtml"
                                                           Write(Html.RadioButtonFor(m => m.Gender, "Male", new { id="Gender1"}));

#line default
#line hidden
                EndContext();
                BeginContext(1910, 68, true);
                WriteLiteral("\r\n            <span class=\"ui grey inverted header\">Female : </span>");
                EndContext();
                BeginContext(1979, 68, false);
#line 52 "D:\softuni\TravelTogether\TravelTogether\Views\Account\Register.cshtml"
                                                             Write(Html.RadioButtonFor(m => m.Gender, "Female", new { id = "Gender2" }));

#line default
#line hidden
                EndContext();
                BeginContext(2047, 160, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"control\">\r\n            <button type=\"submit\" class=\"ui secondary button\">Register</button>\r\n        </div>\r\n    </div>  \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2214, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2236, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 61 "D:\softuni\TravelTogether\TravelTogether\Views\Account\Register.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(2306, 95, true);
                WriteLiteral("    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js\"></script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravelTogether.ViewModels.Account.RegisterInputModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
