#pragma checksum "C:\Users\Alexander\Desktop\Website\SWP_HEIM_WEBSITE\Heim_ArtistsWebsite\Views\Article\Articles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ef185ca99701d2ce23b0aa30bd2979b69a6e008"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article_Articles), @"mvc.1.0.view", @"/Views/Article/Articles.cshtml")]
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
#line 1 "C:\Users\Alexander\Desktop\Website\SWP_HEIM_WEBSITE\Heim_ArtistsWebsite\Views\_ViewImports.cshtml"
using Heim_ArtistsWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alexander\Desktop\Website\SWP_HEIM_WEBSITE\Heim_ArtistsWebsite\Views\_ViewImports.cshtml"
using Heim_ArtistsWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ef185ca99701d2ce23b0aa30bd2979b69a6e008", @"/Views/Article/Articles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b27b92e9ce0677f48641d15f4b2d6ea5e284a06c", @"/Views/_ViewImports.cshtml")]
    public class Views_Article_Articles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Article>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alexander\Desktop\Website\SWP_HEIM_WEBSITE\Heim_ArtistsWebsite\Views\Article\Articles.cshtml"
  
    ViewData["Title"] = "Alexander Heim";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"articles\">\r\n");
#nullable restore
#line 8 "C:\Users\Alexander\Desktop\Website\SWP_HEIM_WEBSITE\Heim_ArtistsWebsite\Views\Article\Articles.cshtml"
     foreach (Article article in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"article_link\">\r\n");
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 306, "\"", 352, 2);
            WriteAttributeValue("", 313, "/Article/Article?id=", 313, 20, true);
#nullable restore
#line 12 "C:\Users\Alexander\Desktop\Website\SWP_HEIM_WEBSITE\Heim_ArtistsWebsite\Views\Article\Articles.cshtml"
WriteAttributeValue("", 333, article.Article_id, 333, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "C:\Users\Alexander\Desktop\Website\SWP_HEIM_WEBSITE\Heim_ArtistsWebsite\Views\Article\Articles.cshtml"
                                                     Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Users\Alexander\Desktop\Website\SWP_HEIM_WEBSITE\Heim_ArtistsWebsite\Views\Article\Articles.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591
