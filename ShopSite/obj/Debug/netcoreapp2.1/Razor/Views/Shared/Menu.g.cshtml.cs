#pragma checksum "C:\Baza\ShopSite\ShopSite\Views\Shared\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f95c03a0feb70c05316a3b42dd2579a34aae291a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f95c03a0feb70c05316a3b42dd2579a34aae291a", @"/Views/Shared/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b2a7d324a545e72f1631ccfe0d1cab1100ed7ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Menu>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 17, true);
            WriteLiteral("<h2>Main12</h2>\r\n");
            EndContext();
            BeginContext(66, 24, false);
#line 4 "C:\Baza\ShopSite\ShopSite\Views\Shared\Menu.cshtml"
Write(Model.Count().ToString());

#line default
#line hidden
            EndContext();
            BeginContext(90, 34, true);
            WriteLiteral("\r\n\r\n<div class=\"menu\">\r\n    <ul>\r\n");
            EndContext();
            BeginContext(689, 19, true);
            WriteLiteral("    </ul>\r\n</div>\r\n");
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
