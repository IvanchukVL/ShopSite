#pragma checksum "C:\Baza\ShopSite\ShopSite\Views\Shared\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3a9966e25533cb9e15f056287e56f5b15eef6bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Menu), @"mvc.1.0.view", @"/Views/Shared/Menu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Menu.cshtml", typeof(AspNetCore.Views_Shared_Menu))]
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
#line 1 "C:\Baza\ShopSite\ShopSite\Views\_ViewImports.cshtml"
using ShopSite;

#line default
#line hidden
#line 2 "C:\Baza\ShopSite\ShopSite\Views\_ViewImports.cshtml"
using ShopSite.Models;

#line default
#line hidden
#line 1 "C:\Baza\ShopSite\ShopSite\Views\Shared\Menu.cshtml"
using DBShopSite.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3a9966e25533cb9e15f056287e56f5b15eef6bd", @"/Views/Shared/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b2a7d324a545e72f1631ccfe0d1cab1100ed7ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Menu>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 17, true);
            WriteLiteral("<h2>Main12</h2>\r\n");
            EndContext();
            BeginContext(65, 24, false);
#line 4 "C:\Baza\ShopSite\ShopSite\Views\Shared\Menu.cshtml"
Write(Model.Count().ToString());

#line default
#line hidden
            EndContext();
            BeginContext(89, 174, true);
            WriteLiteral("\r\n\r\n<nav class=\"navbar navbar-inverse\" role=\"navigation\">\r\n    <div class=\"collapse navbar-collapse\" id=\"bs-example-navbar-collapse-1\">\r\n        <ul class=\"nav navbar-nav\">\r\n");
            EndContext();
#line 9 "C:\Baza\ShopSite\ShopSite\Views\Shared\Menu.cshtml"
             foreach (var mi in Model.Where(p => p.ParentId == 0))
            {

#line default
#line hidden
            BeginContext(346, 61, true);
            WriteLiteral("                <li class=\"dropdown\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 407, "\"", 446, 1);
#line 12 "C:\Baza\ShopSite\ShopSite\Views\Shared\Menu.cshtml"
WriteAttributeValue("", 414, Url.Action(mi.Command, "Pages"), 414, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(447, 59, true);
            WriteLiteral(" data-toggle=\"dropdown\" title=\"\">\r\n                        ");
            EndContext();
            BeginContext(507, 7, false);
#line 13 "C:\Baza\ShopSite\ShopSite\Views\Shared\Menu.cshtml"
                   Write(mi.Name);

#line default
#line hidden
            EndContext();
            BeginContext(514, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "C:\Baza\ShopSite\ShopSite\Views\Shared\Menu.cshtml"
                         if (mi.Name == "Катушки")
                        {

#line default
#line hidden
            BeginContext(595, 57, true);
            WriteLiteral("                            <span class=\"caret\"></span>\r\n");
            EndContext();
#line 17 "C:\Baza\ShopSite\ShopSite\Views\Shared\Menu.cshtml"
                        }

#line default
#line hidden
            BeginContext(679, 86, true);
            WriteLiteral("                    </a>\r\n                    <ul class=\"dropdown-menu\" role=\"menu\">\r\n");
            EndContext();
#line 20 "C:\Baza\ShopSite\ShopSite\Views\Shared\Menu.cshtml"
                         foreach (var i in Model.Where(p => p.ParentId == mi.Id))
                        {

#line default
#line hidden
            BeginContext(875, 34, true);
            WriteLiteral("                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 909, "\"", 946, 1);
#line 22 "C:\Baza\ShopSite\ShopSite\Views\Shared\Menu.cshtml"
WriteAttributeValue("", 916, Url.Action(i.Command,"Pages"), 916, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(947, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(949, 6, false);
#line 22 "C:\Baza\ShopSite\ShopSite\Views\Shared\Menu.cshtml"
                                                                    Write(i.Name);

#line default
#line hidden
            EndContext();
            BeginContext(955, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 23 "C:\Baza\ShopSite\ShopSite\Views\Shared\Menu.cshtml"
                        }

#line default
#line hidden
            BeginContext(993, 50, true);
            WriteLiteral("                    </ul>\r\n                </li>\r\n");
            EndContext();
#line 26 "C:\Baza\ShopSite\ShopSite\Views\Shared\Menu.cshtml"
            }

#line default
#line hidden
            BeginContext(1058, 37, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n</nav>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Menu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
