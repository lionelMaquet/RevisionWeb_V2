#pragma checksum "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62e62656d8c1af0818bd934f0f64f14c3ca0e278"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RevisionWebV2.Pages.Pages_Answers), @"mvc.1.0.razor-page", @"/Pages/Answers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62e62656d8c1af0818bd934f0f64f14c3ca0e278", @"/Pages/Answers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db6c5a839106a8194a761e1c181b5264a7088a47", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Answers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("add_answer_form add_element_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"center\">\r\n\r\n\r\n    <h2>");
#nullable restore
#line 9 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
   Write(Model.question.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n    <div class=\"answers_container\">\r\n");
#nullable restore
#line 13 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
         foreach (var a in Model.question.Answers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"answer\">");
#nullable restore
#line 15 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
                              Write(a.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 16 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n");
#nullable restore
#line 20 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
     if (Model.isOwnUserQuestion == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62e62656d8c1af0818bd934f0f64f14c3ca0e2785371", async() => {
                WriteLiteral("\r\n\r\n            <input type=\"hidden\" name=\"qid\"");
                BeginWriteAttribute("value", " value=\"", 470, "\"", 488, 1);
#nullable restore
#line 24 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
WriteAttributeValue("", 478, Model.qid, 478, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
            <div>
                <label for=""title"">Proposition</label>
                <input type=""text"" name=""title"">
            </div>

            <div>
                <label for=""details"">Details</label>
                <input type=""text"" name=""details"">
            </div>

            <div>
                <label for=""isRightAnswer"">Is it the right answer ?</label>
                <input type=""checkbox"" name=""isRightAnswer"" />
            </div>


            <input type=""submit"" class=""AddElementButton"" value=""Ajouter proposition"">
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RevisionWebV2.Pages.AnswersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RevisionWebV2.Pages.AnswersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RevisionWebV2.Pages.AnswersModel>)PageContext?.ViewData;
        public RevisionWebV2.Pages.AnswersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
