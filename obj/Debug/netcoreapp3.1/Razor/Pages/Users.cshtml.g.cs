#pragma checksum "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54e91288f0ef0c87c9e01750e1c8bf56d56d3feb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RevisionWebV2.Pages.Pages_Users), @"mvc.1.0.razor-page", @"/Pages/Users.cshtml")]
namespace RevisionWebV2.Pages
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
#line 1 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\_ViewImports.cshtml"
using RevisionWebV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\_ViewImports.cshtml"
using RevisionWebV2.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54e91288f0ef0c87c9e01750e1c8bf56d56d3feb", @"/Pages/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db6c5a839106a8194a761e1c181b5264a7088a47", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Users : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"center\">\r\n    <h2>Users : </h2>\r\n    <div class=\"list_container\">\r\n");
#nullable restore
#line 9 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Users.cshtml"
         foreach (var u in Model.users)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"list_item\">\r\n                <a class=\"list_item_link\"");
            BeginWriteAttribute("href", " href=\"", 264, "\"", 301, 2);
            WriteAttributeValue("", 271, "/subjects?username=", 271, 19, true);
#nullable restore
#line 12 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Users.cshtml"
WriteAttributeValue("", 290, u.UserName, 290, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Users.cshtml"
                                                                           Write(u.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n");
#nullable restore
#line 14 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Users.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RevisionWebV2.Pages.UsersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RevisionWebV2.Pages.UsersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RevisionWebV2.Pages.UsersModel>)PageContext?.ViewData;
        public RevisionWebV2.Pages.UsersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
