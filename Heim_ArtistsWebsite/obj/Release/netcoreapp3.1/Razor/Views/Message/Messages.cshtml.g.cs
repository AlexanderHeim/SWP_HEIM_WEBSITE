#pragma checksum "C:\Users\Alexander Heim\Documents\Schule\4AHWII\SWP\Vogt\Razer\MeineSeite\Heim_ArtistsWebsite\Views\Message\Messages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6800f82af9257fdf66c8df7445d6692a54311094"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_Messages), @"mvc.1.0.view", @"/Views/Message/Messages.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6800f82af9257fdf66c8df7445d6692a54311094", @"/Views/Message/Messages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b27b92e9ce0677f48641d15f4b2d6ea5e284a06c", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_Messages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Alexander Heim\Documents\Schule\4AHWII\SWP\Vogt\Razer\MeineSeite\Heim_ArtistsWebsite\Views\Message\Messages.cshtml"
  
    ViewData["Title"] = "Messages";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Alexander Heim\Documents\Schule\4AHWII\SWP\Vogt\Razer\MeineSeite\Heim_ArtistsWebsite\Views\Message\Messages.cshtml"
 foreach (var message in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"message\">\r\n        <h3>");
#nullable restore
#line 9 "C:\Users\Alexander Heim\Documents\Schule\4AHWII\SWP\Vogt\Razer\MeineSeite\Heim_ArtistsWebsite\Views\Message\Messages.cshtml"
       Write(message.Sender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p>");
#nullable restore
#line 10 "C:\Users\Alexander Heim\Documents\Schule\4AHWII\SWP\Vogt\Razer\MeineSeite\Heim_ArtistsWebsite\Views\Message\Messages.cshtml"
      Write(message.MessageText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 12 "C:\Users\Alexander Heim\Documents\Schule\4AHWII\SWP\Vogt\Razer\MeineSeite\Heim_ArtistsWebsite\Views\Message\Messages.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591