#pragma checksum "C:\Users\Alexander Heim\Documents\Schule\4AHWII\SWP\Vogt\Razer\MeineSeite\Heim_ArtistsWebsite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee9231cf9da61662ab125f2ff59f5535a24aedbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Alexander Heim\Documents\Schule\4AHWII\SWP\Vogt\Razer\MeineSeite\Heim_ArtistsWebsite\Views\_ViewImports.cshtml"
using Heim_ArtistsWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alexander Heim\Documents\Schule\4AHWII\SWP\Vogt\Razer\MeineSeite\Heim_ArtistsWebsite\Views\_ViewImports.cshtml"
using Heim_ArtistsWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee9231cf9da61662ab125f2ff59f5535a24aedbc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b27b92e9ce0677f48641d15f4b2d6ea5e284a06c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Article>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alexander Heim\Documents\Schule\4AHWII\SWP\Vogt\Razer\MeineSeite\Heim_ArtistsWebsite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Artwork";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"article_headdiv\">\r\n    ");
#nullable restore
#line 8 "C:\Users\Alexander Heim\Documents\Schule\4AHWII\SWP\Vogt\Razer\MeineSeite\Heim_ArtistsWebsite\Views\Home\Index.cshtml"
Write(Model.Html_text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Article> Html { get; private set; }
    }
}
#pragma warning restore 1591
