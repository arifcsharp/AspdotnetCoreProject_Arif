#pragma checksum "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45a8c795ac47398cd446b50ef82903674bfff7a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction__ViewAll), @"mvc.1.0.view", @"/Views/Transaction/_ViewAll.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transaction/_ViewAll.cshtml", typeof(AspNetCore.Views_Transaction__ViewAll))]
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
#line 1 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\_ViewImports.cshtml"
using MvcCoreProject_Arif;

#line default
#line hidden
#line 2 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\_ViewImports.cshtml"
using MvcCoreProject_Arif.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45a8c795ac47398cd446b50ef82903674bfff7a3", @"/Views/Transaction/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7630c34f7623444a1875035f612d7f4bcfb9a53d", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcCoreProject_Arif.Models.Transaction>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryAjaxDelete(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 303, true);
            WriteLiteral(@"
    <div class=""col-md-10 offset-md-2"">

        <h1 class=""text-center""><i class=""fas fa-comments-dollar text-success""></i> Transaction History</h1>


        <table class=""table"">
            <thead class=""thead-light"">
                <tr>
                    <th>
                        ");
            EndContext();
            BeginContext(364, 49, false);
#line 12 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\_ViewAll.cshtml"
                   Write(Html.DisplayNameFor(model => model.AccountNumber));

#line default
#line hidden
            EndContext();
            BeginContext(413, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(493, 51, false);
#line 15 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\_ViewAll.cshtml"
                   Write(Html.DisplayNameFor(model => model.BeneficiaryName));

#line default
#line hidden
            EndContext();
            BeginContext(544, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(624, 44, false);
#line 18 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\_ViewAll.cshtml"
                   Write(Html.DisplayNameFor(model => model.BankName));

#line default
#line hidden
            EndContext();
            BeginContext(668, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(748, 40, false);
#line 21 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\_ViewAll.cshtml"
                   Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(788, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(868, 42, false);
#line 24 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\_ViewAll.cshtml"
                   Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(910, 81, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 991, "\"", 1100, 4);
            WriteAttributeValue("", 1001, "showInPopup(\'", 1001, 13, true);
#line 27 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\_ViewAll.cshtml"
WriteAttributeValue("", 1014, Url.Action("AddOrEdit","Transaction",null,Context.Request.Scheme), 1014, 66, false);

#line default
#line hidden
            WriteAttributeValue("", 1080, "\',\'New", 1080, 6, true);
            WriteAttributeValue(" ", 1086, "Transaction\')", 1087, 14, true);
            EndWriteAttribute();
            BeginContext(1101, 180, true);
            WriteLiteral(" class=\"btn btn-success text-white\"><i class=\"fas fa-random\"></i> New Transaction</a>\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 32 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\_ViewAll.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1346, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1419, 48, false);
#line 36 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AccountNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1467, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1547, 50, false);
#line 39 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.BeneficiaryName));

#line default
#line hidden
            EndContext();
            BeginContext(1597, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1677, 43, false);
#line 42 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.BankName));

#line default
#line hidden
            EndContext();
            BeginContext(1720, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1800, 39, false);
#line 45 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1839, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1919, 41, false);
#line 48 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1960, 114, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <div>\r\n                            ");
            EndContext();
            BeginContext(2074, 589, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7089c19cc8f24f47aa88eb0b3773459a", async() => {
                BeginContext(2194, 36, true);
                WriteLiteral("\r\n                                <a");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 2230, "\"", 2365, 4);
                WriteAttributeValue("", 2240, "showInPopup(\'", 2240, 13, true);
#line 53 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\_ViewAll.cshtml"
WriteAttributeValue("", 2253, Url.Action("AddOrEdit","Transaction",new {id=item.TransactionId},Context.Request.Scheme), 2253, 89, false);

#line default
#line hidden
                WriteAttributeValue("", 2342, "\',\'Update", 2342, 9, true);
                WriteAttributeValue(" ", 2351, "Transaction\')", 2352, 14, true);
                EndWriteAttribute();
                BeginContext(2366, 111, true);
                WriteLiteral(" class=\"btn btn-info text-white\"><i class=\"fas fa-pencil-alt\"></i> Edit</a>\r\n\r\n                                ");
                EndContext();
                BeginContext(2477, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "55fa4bac4a0040b890bc734667b7b58a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 55 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\_ViewAll.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.TransactionId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2530, 126, true);
                WriteLiteral("\r\n                                <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger \" />\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\_ViewAll.cshtml"
                                                        WriteLiteral(item.TransactionId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2663, 84, true);
            WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 61 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\_ViewAll.cshtml"
                }

#line default
#line hidden
            BeginContext(2766, 50, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcCoreProject_Arif.Models.Transaction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
