#pragma checksum "/Users/killercomp2.0/Projects/AnimalCrossing/AnimalCrossing/Views/Animal/Thanks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cc0fbd71aeda5c447d0ec7a43aa157e83b876cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Animal_Thanks), @"mvc.1.0.view", @"/Views/Animal/Thanks.cshtml")]
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
#nullable restore
#line 1 "/Users/killercomp2.0/Projects/AnimalCrossing/AnimalCrossing/Views/_ViewImports.cshtml"
using AnimalCrossing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/killercomp2.0/Projects/AnimalCrossing/AnimalCrossing/Views/_ViewImports.cshtml"
using AnimalCrossing.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cc0fbd71aeda5c447d0ec7a43aa157e83b876cf", @"/Views/Animal/Thanks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee175a24fa2d034080536738cfa744fdc95f3e3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Animal_Thanks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cat>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n    ");
#nullable restore
#line 8 "/Users/killercomp2.0/Projects/AnimalCrossing/AnimalCrossing/Views/Animal/Thanks.cshtml"
Write(await Html.PartialAsync("_showCatPartialView", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cat>> Html { get; private set; }
    }
}
#pragma warning restore 1591
