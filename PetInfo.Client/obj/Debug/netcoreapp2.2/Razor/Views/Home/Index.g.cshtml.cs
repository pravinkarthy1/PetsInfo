#pragma checksum "C:\Users\BCRH64\source\repos\PetInformationClient\PetInfo.Client\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b87aebf13ca726415b8ff697a734bc7beb001427"
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
#line 1 "C:\Users\BCRH64\source\repos\PetInformationClient\PetInfo.Client\Views\_ViewImports.cshtml"
using PetInfo.Client;

#line default
#line hidden
#line 2 "C:\Users\BCRH64\source\repos\PetInformationClient\PetInfo.Client\Views\_ViewImports.cshtml"
using PetInfo.Client.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b87aebf13ca726415b8ff697a734bc7beb001427", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1fb3e2ab0c9893d9734b263d429ebbd66127aa5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PetIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\BCRH64\source\repos\PetInformationClient\PetInfo.Client\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(73, 56, true);
            WriteLiteral("\r\n<div class=\"text-left\">\r\n    <div class=\"container\">\r\n");
            EndContext();
#line 9 "C:\Users\BCRH64\source\repos\PetInformationClient\PetInfo.Client\Views\Home\Index.cshtml"
         foreach (var item in Model.CatInfoList)
        {

#line default
#line hidden
            BeginContext(190, 113, true);
            WriteLiteral("            <ul class=\"list-unstyled\">\r\n                <li>\r\n                    <span class=\"font-weight-bold\">");
            EndContext();
            BeginContext(304, 11, false);
#line 13 "C:\Users\BCRH64\source\repos\PetInformationClient\PetInfo.Client\Views\Home\Index.cshtml"
                                              Write(item.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(315, 65, true);
            WriteLiteral("</span><br/><br/>\r\n                    <ul class=\"bulletstyle\">\r\n");
            EndContext();
#line 15 "C:\Users\BCRH64\source\repos\PetInformationClient\PetInfo.Client\Views\Home\Index.cshtml"
                         foreach (var pet in item.Cats)
                        {


#line default
#line hidden
            BeginContext(466, 32, true);
            WriteLiteral("                            <li>");
            EndContext();
            BeginContext(499, 3, false);
#line 18 "C:\Users\BCRH64\source\repos\PetInformationClient\PetInfo.Client\Views\Home\Index.cshtml"
                           Write(pet);

#line default
#line hidden
            EndContext();
            BeginContext(502, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 19 "C:\Users\BCRH64\source\repos\PetInformationClient\PetInfo.Client\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(536, 74, true);
            WriteLiteral("                    </ul>\r\n                </li>\r\n            </ul><br/>\r\n");
            EndContext();
#line 23 "C:\Users\BCRH64\source\repos\PetInformationClient\PetInfo.Client\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(621, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PetIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591