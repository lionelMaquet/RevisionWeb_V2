#pragma checksum "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f32ec97bb66dff5fad2f0b49ec31afd45fcc1916"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f32ec97bb66dff5fad2f0b49ec31afd45fcc1916", @"/Pages/Answers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db6c5a839106a8194a761e1c181b5264a7088a47", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Answers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("previous_question_image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/previous.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("next_question_image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/next.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("add_answer_form add_element_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<a");
            BeginWriteAttribute("href", " href=\"", 59, "\"", 95, 2);
            WriteAttributeValue("", 66, "answers?qid=", 66, 12, true);
#nullable restore
#line 6 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
WriteAttributeValue("", 78, Model.previousId, 78, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f32ec97bb66dff5fad2f0b49ec31afd45fcc19166096", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</a>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 179, "\"", 211, 2);
            WriteAttributeValue("", 186, "answers?qid=", 186, 12, true);
#nullable restore
#line 9 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
WriteAttributeValue("", 198, Model.nextId, 198, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f32ec97bb66dff5fad2f0b49ec31afd45fcc19167653", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</a>\r\n\r\n<div class=\"center\">\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 315, "\"", 353, 2);
            WriteAttributeValue("", 322, "questions?sid=", 322, 14, true);
#nullable restore
#line 14 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
WriteAttributeValue("", 336, Model.subject.Id, 336, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Back to questions</a>\r\n\r\n    <h5>");
#nullable restore
#line 16 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
   Write(Model.subject.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <h2>");
#nullable restore
#line 17 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
   Write(Model.question.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <div class=\"answers_container\">\r\n");
#nullable restore
#line 19 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
         if (Model.question.Answers.Count > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
             foreach (var a in Model.question.Answers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button class=\"answer\" data-isRightAnswer=\'");
#nullable restore
#line 23 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
                                                      Write(a.IsRightAnswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' data-details=\'");
#nullable restore
#line 23 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
                                                                                      Write(a.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'>");
#nullable restore
#line 23 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
                                                                                                  Write(a.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 24 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>There\'s no answer yet.</p>\r\n");
#nullable restore
#line 29 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div class=\"details_container\">\r\n        <p><span id=\"trueOrNot\"></span> <span id=\"answerDetails\"></span></p>\r\n    </div>\r\n\r\n");
#nullable restore
#line 36 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
     if (Model.isOwnUserQuestion == true && Model.shouldShowForm == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f32ec97bb66dff5fad2f0b49ec31afd45fcc191612287", async() => {
                WriteLiteral("\r\n\r\n            <input type=\"hidden\" name=\"qid\"");
                BeginWriteAttribute("value", " value=\"", 1186, "\"", 1204, 1);
#nullable restore
#line 40 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
WriteAttributeValue("", 1194, Model.qid, 1194, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
            <div>
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
            </div>


            <input type=""submit"" class=""AddElementButton"" value=""Ajouter proposition"">
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 61 "C:\Users\lione\Desktop\Side Projects\RevisionWebV2\Pages\Answers.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $('.answer').click(function () {
            $('#trueOrNot').removeClass(""wrong_answer"")
            $('#trueOrNot').removeClass(""right_answer"")


            if (this.getAttribute('data-isRightAnswer') == ""True"") {
                $('#trueOrNot').text(""Great! Right answer."")
                $('#trueOrNot').addClass(""right_answer"")
            }
            else {
                $('#trueOrNot').text(""Oops! Wrong answer."")
                $('#trueOrNot').addClass(""wrong_answer"")
            }

            $('#answerDetails').text(this.getAttribute(""data-details""))

        })

    </script>
");
            }
            );
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
