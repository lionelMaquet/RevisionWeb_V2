#pragma checksum "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Questions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a6d22f91f2e75e7578454c3d091e5d2ad46c281"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RevisionWebV2.Pages.Pages_Questions), @"mvc.1.0.razor-page", @"/Pages/Questions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a6d22f91f2e75e7578454c3d091e5d2ad46c281", @"/Pages/Questions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db6c5a839106a8194a761e1c181b5264a7088a47", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Questions : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Questions.cshtml"
 foreach (var q in Model.sub.Questions)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 122, "\"", 147, 2);
            WriteAttributeValue("", 129, "/answers?qid=", 129, 13, true);
#nullable restore
#line 9 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Questions.cshtml"
WriteAttributeValue("", 142, q.Id, 142, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 9 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Questions.cshtml"
                                Write(q.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </p>\r\n");
#nullable restore
#line 11 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Questions.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 14 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Questions.cshtml"
 if (Model.isOwnUserSubject == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a6d22f91f2e75e7578454c3d091e5d2ad46c2815058", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 275, "\"", 293, 1);
#nullable restore
#line 17 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Questions.cshtml"
WriteAttributeValue("", 283, Model.sid, 283, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"text\" name=\"title\">\r\n        <input type=\"submit\" class=\"AddElementButton\" value=\"Ajouter question\">\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Questions.cshtml"
}

else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>You are not the owner of this subject. You\'ve got no rights but looking at it.</p>\r\n");
#nullable restore
#line 26 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Questions.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RevisionWebV2.Pages.QuestionsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RevisionWebV2.Pages.QuestionsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RevisionWebV2.Pages.QuestionsModel>)PageContext?.ViewData;
        public RevisionWebV2.Pages.QuestionsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
