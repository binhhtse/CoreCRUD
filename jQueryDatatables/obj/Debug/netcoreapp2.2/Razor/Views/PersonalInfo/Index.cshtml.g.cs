#pragma checksum "E:\DemoCore\Datatables-master\Sln.jQueryDatatables\jQueryDatatables\Views\PersonalInfo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12b3cc11ed09ab79ca85ff66ecf2e748a8cefdb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PersonalInfo_Index), @"mvc.1.0.view", @"/Views/PersonalInfo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PersonalInfo/Index.cshtml", typeof(AspNetCore.Views_PersonalInfo_Index))]
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
#line 1 "E:\DemoCore\Datatables-master\Sln.jQueryDatatables\jQueryDatatables\Views\_ViewImports.cshtml"
using jQueryDatatables;

#line default
#line hidden
#line 2 "E:\DemoCore\Datatables-master\Sln.jQueryDatatables\jQueryDatatables\Views\_ViewImports.cshtml"
using jQueryDatatables.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b3cc11ed09ab79ca85ff66ecf2e748a8cefdb3", @"/Views/PersonalInfo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07498f661a61e52a1bd7dded13c8fafbd8e733f4", @"/Views/_ViewImports.cshtml")]
    public class Views_PersonalInfo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/PersonalInfo/PersonalInfo_CRUD.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/PersonalInfo/PersonalInfo_Datatable.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/DataTables/datatables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/DataTables/datatables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1510, true);
            WriteLiteral(@"
<p>
    <div class=""row"">
        <div class=""col-md-8"">
            <button class=""btn btn-primary"" onclick=""AddEditPersonalInfo(0)"">Add New</button>
        </div>
        <div class=""col-md-4 text-right"">
            <a href=""PersonalInfo/ExportAllDatatoCSV"">
                <input type=""button"" id=""btnExportAllDatatoCSV"" class=""btn btn-success"" value=""Export All Data to CSV"" />
            </a>
        </div>
    </div>
</p>



<div class=""container"">
    <div style=""width:100%; margin:0 auto;"">
        <table id=""tblPersonalInfo"" class=""tblCustomTR"" border=""1"" style=""width:100%;"">
            <thead>
                <tr>
                    <th>No</th>
                    <th>First Name</th>
                    <th>Date Of Birth</th>
                    <th>City</th>
                    <th>Country</th>
                    <th>MobileNo</th>
                    <th>Department Name</th>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
        </table>
");
            WriteLiteral(@"    </div>
</div>

<div class=""modal fade"" id=""PersonalInfoFormModel"" role=""dialog"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h3 id=""title"" class=""modal-title"">Add Personal Info</h3>
                <a href=""#"" class=""close"" data-dismiss=""modal"">&times;</a>
            </div>
            <div class=""modal-body"" id=""PersonalInfoFormModelDiv"">
            </div>
        </div>
    </div>
</div>

<br />
");
            EndContext();
#line 51 "E:\DemoCore\Datatables-master\Sln.jQueryDatatables\jQueryDatatables\Views\PersonalInfo\Index.cshtml"
 if (TempData["successAlert"] != null)
{

#line default
#line hidden
            BeginContext(1551, 129, true);
            WriteLiteral("    <div class=\"alert alert-success\">\n        <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">×</a>\n        <p>");
            EndContext();
            BeginContext(1681, 24, false);
#line 55 "E:\DemoCore\Datatables-master\Sln.jQueryDatatables\jQueryDatatables\Views\PersonalInfo\Index.cshtml"
      Write(TempData["successAlert"]);

#line default
#line hidden
            EndContext();
            BeginContext(1705, 16, true);
            WriteLiteral("</p>\n    </div>\n");
            EndContext();
#line 57 "E:\DemoCore\Datatables-master\Sln.jQueryDatatables\jQueryDatatables\Views\PersonalInfo\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1723, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1724, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12b3cc11ed09ab79ca85ff66ecf2e748a8cefdb38171", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1786, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(1802, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12b3cc11ed09ab79ca85ff66ecf2e748a8cefdb39350", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1869, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1870, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "12b3cc11ed09ab79ca85ff66ecf2e748a8cefdb310527", async() => {
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
            EndContext();
            BeginContext(1934, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1935, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12b3cc11ed09ab79ca85ff66ecf2e748a8cefdb311780", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1989, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1990, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12b3cc11ed09ab79ca85ff66ecf2e748a8cefdb312958", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2054, 3, true);
            WriteLiteral("\n\n\n");
            EndContext();
            BeginContext(2075, 756, true);
            WriteLiteral(@"<link href=""https://cdn.datatables.net/buttons/1.5.4/css/buttons.dataTables.min.css"" rel=""stylesheet"" />
<script src=""https://cdn.datatables.net/buttons/1.5.4/js/dataTables.buttons.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.36/pdfmake.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.36/vfs_fonts.js""></script>
<script src=""https://cdn.datatables.net/buttons/1.5.4/js/buttons.html5.min.js""></script>
<script src=""https://cdn.datatables.net/buttons/1.5.6/js/buttons.print.min.js""></script>

<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery-form-validator/2.3.26/jquery.form-validator.min.js""></script>

<style>
    .tblCustomTR tr {
        line-height: 40px;
    }
</style>






");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
