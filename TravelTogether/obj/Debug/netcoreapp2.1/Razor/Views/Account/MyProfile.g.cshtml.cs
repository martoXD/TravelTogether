#pragma checksum "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "961c23b63abd89612f048d35512ee605be9bccee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_MyProfile), @"mvc.1.0.view", @"/Views/Account/MyProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/MyProfile.cshtml", typeof(AspNetCore.Views_Account_MyProfile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"961c23b63abd89612f048d35512ee605be9bccee", @"/Views/Account/MyProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2d83fd1a6542178c0a656bbc030257f9883046d", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_MyProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelTogether.ViewModels.Account.MyProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/myProfile.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/default_icon.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
  
    ViewData["Title"] = "MyProfile";
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
                BeginContext(178, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3f077051fd6c4ecb9a296ce46440d892", async() => {
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
                BeginContext(246, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(251, 94, true);
            WriteLiteral("\r\n<div class=\"container emp-profile\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n");
            EndContext();
#line 15 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
             if (Model.ProfileImageId == null)
            {

#line default
#line hidden
            BeginContext(408, 63, true);
            WriteLiteral("                <div class=\"profile-img\">\r\n                    ");
            EndContext();
            BeginContext(471, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "726bb703a6ee45bc9b2849e3f563b562", async() => {
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
            BeginContext(517, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 20 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(591, 67, true);
            WriteLiteral("                <div class=\"profile-img\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 658, "\"", 686, 1);
#line 24 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
WriteAttributeValue("", 664, Model.ProfileImageSrc, 664, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(687, 36, true);
            WriteLiteral(" alt=\"\" />\r\n                </div>\r\n");
            EndContext();
#line 26 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
            }

#line default
#line hidden
            BeginContext(738, 149, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-md-6 my_profile_headers\">\r\n            <div class=\"profile-head\">\r\n                <h5>\r\n                    ");
            EndContext();
            BeginContext(888, 15, false);
#line 31 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
               Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(903, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(905, 14, false);
#line 31 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
                                Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(919, 125, true);
            WriteLiteral("\r\n                </h5>\r\n                <div class=\"my_aboutMeDescription_profile\">\r\n                    <h3>About me</h3>\r\n");
            EndContext();
#line 35 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
                     if (Model.AboutMeDescription is null)
                    {

#line default
#line hidden
            BeginContext(1127, 46, true);
            WriteLiteral("                        <p>- - Empty - -</p>\r\n");
            EndContext();
#line 38 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1245, 27, true);
            WriteLiteral("                        <p>");
            EndContext();
            BeginContext(1273, 24, false);
#line 41 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
                      Write(Model.AboutMeDescription);

#line default
#line hidden
            EndContext();
            BeginContext(1297, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 42 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
                    }

#line default
#line hidden
            BeginContext(1326, 664, true);
            WriteLiteral(@"                </div>
                <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                    <li class=""nav-item"">
                        <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#home"" role=""tab"" aria-controls=""home"" aria-selected=""true"">Profile</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#profile"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">Images</a>
                    </li>
                </ul>
            </div>
        </div>
        <div class=""col-md-2"">
            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1990, "\"", 2028, 2);
            WriteAttributeValue("", 1997, "/Account/Edit?id=", 1997, 17, true);
#line 55 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
WriteAttributeValue("", 2014, this.Model.Id, 2014, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2029, 682, true);
            WriteLiteral(@" class=""profile-edit-btn"" name=""btnAddMore"">
                Edit Profile
            </a>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-4"">
        </div>
        <div class=""col-md-8"">
            <div class=""tab-content profile-tab"" id=""myTabContent"">
                <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label class=""my_label_myProfile"">Username</label>
                        </div>
                        <div class=""col-md-6"">
                            <p>");
            EndContext();
            BeginContext(2712, 14, false);
#line 71 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
                          Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(2726, 346, true);
            WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label class=""my_label_myProfile"">First Name</label>
                        </div>
                        <div class=""col-md-6"">
                            <p>");
            EndContext();
            BeginContext(3073, 15, false);
#line 79 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
                          Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(3088, 345, true);
            WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label class=""my_label_myProfile"">Last Name</label>
                        </div>
                        <div class=""col-md-6"">
                            <p>");
            EndContext();
            BeginContext(3434, 14, false);
#line 87 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
                          Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(3448, 343, true);
            WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label class=""my_label_myProfile"">Country</label>
                        </div>
                        <div class=""col-md-6"">
                            <p>");
            EndContext();
            BeginContext(3792, 13, false);
#line 95 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
                          Write(Model.Country);

#line default
#line hidden
            EndContext();
            BeginContext(3805, 340, true);
            WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label class=""my_label_myProfile"">City</label>
                        </div>
                        <div class=""col-md-6"">
                            <p>");
            EndContext();
            BeginContext(4146, 10, false);
#line 103 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
                          Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(4156, 308, true);
            WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label class=""my_label_myProfile"">Age</label>
                        </div>
                        <div class=""col-md-6"">
");
            EndContext();
#line 111 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
                             if (Model.Age == 0)
                            {

#line default
#line hidden
            BeginContext(4545, 54, true);
            WriteLiteral("                                <p>- - Empty - -</p>\r\n");
            EndContext();
#line 114 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(4695, 35, true);
            WriteLiteral("                                <p>");
            EndContext();
            BeginContext(4731, 9, false);
#line 117 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
                              Write(Model.Age);

#line default
#line hidden
            EndContext();
            BeginContext(4740, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 118 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
                            }

#line default
#line hidden
            BeginContext(4777, 336, true);
            WriteLiteral(@"                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label class=""my_label_myProfile"">Gender</label>
                        </div>
                        <div class=""col-md-6"">
                            <p>");
            EndContext();
            BeginContext(5114, 23, false);
#line 126 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
                          Write(Model.Gender.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(5137, 233, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"tab-pane fade\" id=\"profile\" role=\"tabpanel\" aria-labelledby=\"profile-tab\">\r\n                    <div class=\"row\">\r\n");
            EndContext();
#line 132 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
                         if (Model.Images != null)
                        {
                            

#line default
#line hidden
#line 134 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
                             foreach (var image in Model.Images)
                            {

#line default
#line hidden
            BeginContext(5546, 132, true);
            WriteLiteral("                                <div class=\"col-md-2\">\r\n                                    <img class=\"ui tiny image my_userImages\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5678, "\"", 5702, 1);
#line 137 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
WriteAttributeValue("", 5684, image.ImageSource, 5684, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5703, 45, true);
            WriteLiteral(" />\r\n                                </div>\r\n");
            EndContext();
#line 139 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
                            }

#line default
#line hidden
#line 139 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\MyProfile.cshtml"
                             
                        }

#line default
#line hidden
            BeginContext(5806, 108, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravelTogether.ViewModels.Account.MyProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
