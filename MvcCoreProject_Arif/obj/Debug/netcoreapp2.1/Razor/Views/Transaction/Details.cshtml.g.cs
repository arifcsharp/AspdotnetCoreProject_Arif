#pragma checksum "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0315701bdcdb88e8a2d9fad8594458ea8fe7e3b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction_Details), @"mvc.1.0.view", @"/Views/Transaction/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transaction/Details.cshtml", typeof(AspNetCore.Views_Transaction_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0315701bdcdb88e8a2d9fad8594458ea8fe7e3b2", @"/Views/Transaction/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7630c34f7623444a1875035f612d7f4bcfb9a53d", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcCoreProject_Arif.Models.Transaction>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(87, 126, true);
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>Transaction</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(214, 49, false);
#line 14 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AccountNumber));

#line default
#line hidden
            EndContext();
            BeginContext(263, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(324, 45, false);
#line 17 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.AccountNumber));

#line default
#line hidden
            EndContext();
            BeginContext(369, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(429, 51, false);
#line 20 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BeneficiaryName));

#line default
#line hidden
            EndContext();
            BeginContext(480, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(541, 47, false);
#line 23 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.BeneficiaryName));

#line default
#line hidden
            EndContext();
            BeginContext(588, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(648, 44, false);
#line 26 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BankName));

#line default
#line hidden
            EndContext();
            BeginContext(692, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(753, 40, false);
#line 29 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.BankName));

#line default
#line hidden
            EndContext();
            BeginContext(793, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(853, 45, false);
#line 32 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SWIFTCode));

#line default
#line hidden
            EndContext();
            BeginContext(898, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(959, 41, false);
#line 35 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.SWIFTCode));

#line default
#line hidden
            EndContext();
            BeginContext(1000, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1060, 42, false);
#line 38 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1102, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1163, 38, false);
#line 41 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1201, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1261, 40, false);
#line 44 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1301, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1362, 36, false);
#line 47 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1398, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1440, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e98194e44ee64323ba0d74dd760e21c8", async() => {
                BeginContext(1497, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\arifb\Desktop\1257095\MvcCoreProject_Arif\MvcCoreProject_Arif\Views\Transaction\Details.cshtml"
                           WriteLiteral(Model.TransactionId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1505, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1512, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f453328c4714f82a44788849d7a1e1d", async() => {
                BeginContext(1534, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1550, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcCoreProject_Arif.Models.Transaction> Html { get; private set; }
    }
}
#pragma warning restore 1591
