#pragma checksum "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0de726c928c24ebed5fedbe199e13c60d75a8c17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Profile.cshtml", typeof(AspNetCore.Views_Account_Profile))]
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
#line 1 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\_ViewImports.cshtml"
using TravelTogether;

#line default
#line hidden
#line 2 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\_ViewImports.cshtml"
using TravelTogether.Models;

#line default
#line hidden
#line 3 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\_ViewImports.cshtml"
using TravelTogether.ViewModels.Trips;

#line default
#line hidden
#line 4 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 5 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 6 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0de726c928c24ebed5fedbe199e13c60d75a8c17", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2d83fd1a6542178c0a656bbc030257f9883046d", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelTogether.ViewModels.Account.UserProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/profile.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/profile.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Profile.cshtml"
  
    ViewData["Title"] = "Profile";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(155, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Links", async() => {
                BeginContext(172, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(178, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "70f4b6b47a4b417fb009c0a08a8022fc", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(244, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(249, 269, true);
            WriteLiteral(@"
<div class=""row my_profile_row"">
    <div class=""col-md-6 d-flex justify-content-center"">
        <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">

            <!-- Wrapper for slides -->
            <div class=""carousel-inner"" role=""listbox"">
");
            EndContext();
#line 18 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Profile.cshtml"
                   int i = 0; 

#line default
#line hidden
            BeginContext(551, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 19 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Profile.cshtml"
                 foreach (var image in Model.Images)
                {
                    i++;
                    var active = i == 1 ? "active" : "";

#line default
#line hidden
            BeginContext(708, 24, true);
            WriteLiteral("                    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 732, "\"", 761, 2);
            WriteAttributeValue("", 740, "carousel-item", 740, 13, true);
#line 23 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Profile.cshtml"
WriteAttributeValue(" ", 753, active, 754, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(762, 31, true);
            WriteLiteral(">\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 793, "\"", 817, 1);
#line 24 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Profile.cshtml"
WriteAttributeValue("", 799, image.ImageSource, 799, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(818, 70, true);
            WriteLiteral(" alt=\"Image\" width=\"600\" height=\"400\" />\r\n                    </div>\r\n");
            EndContext();
#line 26 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Profile.cshtml"
                }

#line default
#line hidden
            BeginContext(907, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 27 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Profile.cshtml"
                 if (Model.Images.Count == 0)
                {

#line default
#line hidden
            BeginContext(973, 84, true);
            WriteLiteral("                    <div class=\"carousel-item active\">\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1057, "\"", 1085, 1);
#line 30 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Profile.cshtml"
WriteAttributeValue("", 1063, Model.DefaultImageSrc, 1063, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1086, 70, true);
            WriteLiteral(" alt=\"Image\" width=\"600\" height=\"400\" />\r\n                    </div>\r\n");
            EndContext();
#line 32 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Profile.cshtml"
                }

#line default
#line hidden
            BeginContext(1175, 626, true);
            WriteLiteral(@"            </div>

            <!-- Left and right controls -->
            <a class=""left carousel-control"" href=""#myCarousel"" data-slide=""prev"">
                <span class=""glyphicon glyphicon-chevron-left""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""right carousel-control"" href=""#myCarousel"" data-slide=""next"">
                <span class=""glyphicon glyphicon-chevron-right""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>
    </div>
    <div class=""col-md-6 details"">
        <blockquote>
            <h5>");
            EndContext();
            BeginContext(1802, 15, false);
#line 48 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Profile.cshtml"
           Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1817, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1819, 14, false);
#line 48 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Profile.cshtml"
                            Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1833, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(1836, 14, false);
#line 48 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Profile.cshtml"
                                             Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1850, 34, true);
            WriteLiteral(")</h5>\r\n            <h5>About Me: ");
            EndContext();
            BeginContext(1885, 24, false);
#line 49 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Profile.cshtml"
                     Write(Model.AboutMeDescription);

#line default
#line hidden
            EndContext();
            BeginContext(1909, 93, true);
            WriteLiteral("</h5>\r\n            <small>\r\n                <cite title=\"Source Title\">\r\n                    ");
            EndContext();
            BeginContext(2003, 13, false);
#line 52 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Profile.cshtml"
               Write(Model.Country);

#line default
#line hidden
            EndContext();
            BeginContext(2016, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(2019, 10, false);
#line 52 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Profile.cshtml"
                               Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(2029, 102, true);
            WriteLiteral("\r\n                </cite>\r\n            </small>\r\n        </blockquote>\r\n        <p>\r\n            Age: ");
            EndContext();
            BeginContext(2132, 9, false);
#line 57 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Profile.cshtml"
            Write(Model.Age);

#line default
#line hidden
            EndContext();
            BeginContext(2141, 26, true);
            WriteLiteral("<br>\r\n            Gender: ");
            EndContext();
            BeginContext(2168, 12, false);
#line 58 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Profile.cshtml"
               Write(Model.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(2180, 42, true);
            WriteLiteral("<br>\r\n        </p>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2239, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2245, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a3fc7bcbd434717ab1dd4dfb96008ac", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2307, 2, true);
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravelTogether.ViewModels.Account.UserProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
