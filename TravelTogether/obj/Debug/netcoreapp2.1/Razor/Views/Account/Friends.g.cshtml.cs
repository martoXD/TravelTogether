#pragma checksum "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Friends.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e9030299f2145d7033bf4e491fee4a298a63bfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Friends), @"mvc.1.0.view", @"/Views/Account/Friends.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Friends.cshtml", typeof(AspNetCore.Views_Account_Friends))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e9030299f2145d7033bf4e491fee4a298a63bfb", @"/Views/Account/Friends.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2d83fd1a6542178c0a656bbc030257f9883046d", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Friends : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TravelTogether.ViewModels.Account.FriendsViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Friends.cshtml"
  
    ViewData["Title"] = "Friends";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(157, 55, true);
            WriteLiteral("<div class=\"row mt-4\">\r\n    <div class=\"col-md-12\">\r\n\r\n");
            EndContext();
#line 10 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Friends.cshtml"
         foreach (var friend in Model)
        {

#line default
#line hidden
            BeginContext(263, 103, true);
            WriteLiteral("            <div class=\"ui massive horizontal divided list ml-4\">\r\n                <div class=\"item\">\r\n");
            EndContext();
#line 14 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Friends.cshtml"
                     if (friend.ProfileImageId == null)
                    {

#line default
#line hidden
            BeginContext(446, 52, true);
            WriteLiteral("                        <img class=\"ui avatar image\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 498, "\"", 527, 1);
#line 16 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Friends.cshtml"
WriteAttributeValue("", 504, friend.DefaultImageSrc, 504, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(528, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 17 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Friends.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(603, 52, true);
            WriteLiteral("                        <img class=\"ui avatar image\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 655, "\"", 684, 1);
#line 20 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Friends.cshtml"
WriteAttributeValue("", 661, friend.ProfileImageSrc, 661, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(685, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 21 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Friends.cshtml"
                    }

#line default
#line hidden
            BeginContext(711, 169, true);
            WriteLiteral("                    <div class=\"content\">\r\n                        <div class=\"header\" style=\"color:rgba(255, 255, 255, 0.87) !important;\">\r\n                            ");
            EndContext();
            BeginContext(881, 15, false);
#line 24 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Friends.cshtml"
                       Write(friend.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(896, 218, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <button class=\"ui button\">\r\n                        Contact\r\n                    </button>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 32 "C:\Users\miangelov\Desktop\TravelTogether\TravelTogether\TravelTogether\Views\Account\Friends.cshtml"
        }

#line default
#line hidden
            BeginContext(1125, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TravelTogether.ViewModels.Account.FriendsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
