#pragma checksum "C:\Users\kbnfs\Downloads\OpenSooq-simulation-main\OpenSooq-simulation-main\OpenSooq1\Areas\Dashboard\Views\Categories\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "94d01e79d3e37052e9f5914ef51c12b59452ad3a7445dc5def426a4681370f78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Areas_Dashboard_Views_Categories_Details), @"mvc.1.0.view", @"/Areas/Dashboard/Views/Categories/Details.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\kbnfs\Downloads\OpenSooq-simulation-main\OpenSooq-simulation-main\OpenSooq1\Areas\Dashboard\Views\_ViewImports.cshtml"
using OpenSooq

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\kbnfs\Downloads\OpenSooq-simulation-main\OpenSooq-simulation-main\OpenSooq1\Areas\Dashboard\Views\_ViewImports.cshtml"
using OpenSooq.Models

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\kbnfs\Downloads\OpenSooq-simulation-main\OpenSooq-simulation-main\OpenSooq1\Areas\Dashboard\Views\_ViewImports.cshtml"
using OpenSooq.Models.ViewModel

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"94d01e79d3e37052e9f5914ef51c12b59452ad3a7445dc5def426a4681370f78", @"/Areas/Dashboard/Views/Categories/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ad6119fac91f731a75bf6353c49c89150b15f0cb49fdcbdff7d2907971468544", @"/Areas/Dashboard/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Areas_Dashboard_Views_Categories_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Users\kbnfs\Downloads\OpenSooq-simulation-main\OpenSooq-simulation-main\OpenSooq1\Areas\Dashboard\Views\Categories\Details.cshtml"
       OpenSooq.Models.Category

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\kbnfs\Downloads\OpenSooq-simulation-main\OpenSooq-simulation-main\OpenSooq1\Areas\Dashboard\Views\Categories\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>Category</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 14 "C:\Users\kbnfs\Downloads\OpenSooq-simulation-main\OpenSooq-simulation-main\OpenSooq1\Areas\Dashboard\Views\Categories\Details.cshtml"
             Html.DisplayNameFor(model => model.CategoryName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 17 "C:\Users\kbnfs\Downloads\OpenSooq-simulation-main\OpenSooq-simulation-main\OpenSooq1\Areas\Dashboard\Views\Categories\Details.cshtml"
             Html.DisplayFor(model => model.CategoryName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 20 "C:\Users\kbnfs\Downloads\OpenSooq-simulation-main\OpenSooq-simulation-main\OpenSooq1\Areas\Dashboard\Views\Categories\Details.cshtml"
             Html.DisplayNameFor(model => model.CategoryImage)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            <img style=\"border-radius:20%;\" width=\"150\" height=\"150\"");
            BeginWriteAttribute("src", " src=", 573, "", 625, 1);
            WriteAttributeValue("", 578, 
#nullable restore
#line 23 "C:\Users\kbnfs\Downloads\OpenSooq-simulation-main\OpenSooq-simulation-main\OpenSooq1\Areas\Dashboard\Views\Categories\Details.cshtml"
                                                                          Url.Content("~/newImg/" + Model.CategoryImage)

#line default
#line hidden
#nullable disable
            , 578, 47, false);
            EndWriteAttribute();
            WriteLiteral(">\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 26 "C:\Users\kbnfs\Downloads\OpenSooq-simulation-main\OpenSooq-simulation-main\OpenSooq1\Areas\Dashboard\Views\Categories\Details.cshtml"
             Html.DisplayNameFor(model => model.CreationDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 29 "C:\Users\kbnfs\Downloads\OpenSooq-simulation-main\OpenSooq-simulation-main\OpenSooq1\Areas\Dashboard\Views\Categories\Details.cshtml"
             Html.DisplayFor(model => model.CreationDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 32 "C:\Users\kbnfs\Downloads\OpenSooq-simulation-main\OpenSooq-simulation-main\OpenSooq1\Areas\Dashboard\Views\Categories\Details.cshtml"
             Html.DisplayNameFor(model => model.IsDeleted)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 35 "C:\Users\kbnfs\Downloads\OpenSooq-simulation-main\OpenSooq-simulation-main\OpenSooq1\Areas\Dashboard\Views\Categories\Details.cshtml"
             Html.DisplayFor(model => model.IsDeleted)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 38 "C:\Users\kbnfs\Downloads\OpenSooq-simulation-main\OpenSooq-simulation-main\OpenSooq1\Areas\Dashboard\Views\Categories\Details.cshtml"
             Html.DisplayNameFor(model => model.IsActive)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 41 "C:\Users\kbnfs\Downloads\OpenSooq-simulation-main\OpenSooq-simulation-main\OpenSooq1\Areas\Dashboard\Views\Categories\Details.cshtml"
             Html.DisplayFor(model => model.IsActive)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94d01e79d3e37052e9f5914ef51c12b59452ad3a7445dc5def426a4681370f789309", async() => {
                WriteLiteral("Edit");
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
            WriteLiteral(
#nullable restore
#line 46 "C:\Users\kbnfs\Downloads\OpenSooq-simulation-main\OpenSooq-simulation-main\OpenSooq1\Areas\Dashboard\Views\Categories\Details.cshtml"
                                        Model.CategoryId

#line default
#line hidden
#nullable disable
            );
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
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94d01e79d3e37052e9f5914ef51c12b59452ad3a7445dc5def426a4681370f7811575", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\n</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OpenSooq.Models.Category> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
