#pragma checksum "C:\Users\yogi0000\Source\Repos\angat-yogi\MeroThriftGhar\MeroThriftGhar\MeroThriftGhar\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "040e7b2da518d7d8d966496416c4aa3497968df2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\yogi0000\Source\Repos\angat-yogi\MeroThriftGhar\MeroThriftGhar\MeroThriftGhar\Areas\Admin\Views\_ViewImports.cshtml"
using MeroThriftGhar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yogi0000\Source\Repos\angat-yogi\MeroThriftGhar\MeroThriftGhar\MeroThriftGhar\Areas\Admin\Views\_ViewImports.cshtml"
using MeroThriftGhar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"040e7b2da518d7d8d966496416c4aa3497968df2", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e39dc70ed93846d022ded21eaa68b2e7b1302de7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MeroThriftGhar.Models.ViewModels.CategoryVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Upsert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn border", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn btn-light", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn btn-info active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::MeroThriftGhar.TagHelpers.PageLinkTagHelper __MeroThriftGhar_TagHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\yogi0000\Source\Repos\angat-yogi\MeroThriftGhar\MeroThriftGhar\MeroThriftGhar\Areas\Admin\Views\Category\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-primary\">Category List </h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "040e7b2da518d7d8d966496416c4aa3497968df25871", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i> &nbsp; Create New Category");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<br />\r\n\r\n<div class=\"p-4 border rounded\">\r\n");
#nullable restore
#line 20 "C:\Users\yogi0000\Source\Repos\angat-yogi\MeroThriftGhar\MeroThriftGhar\MeroThriftGhar\Areas\Admin\Views\Category\Index.cshtml"
     if (Model.Categories.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table table-striped border\">\r\n            <tr class=\"table-secondary\">\r\n                <th>\r\n                    Catgeory Name\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n");
#nullable restore
#line 29 "C:\Users\yogi0000\Source\Repos\angat-yogi\MeroThriftGhar\MeroThriftGhar\MeroThriftGhar\Areas\Admin\Views\Category\Index.cshtml"
             foreach (var item in Model.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 33 "C:\Users\yogi0000\Source\Repos\angat-yogi\MeroThriftGhar\MeroThriftGhar\MeroThriftGhar\Areas\Admin\Views\Category\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <div class=\"text-center\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1020, "\"", 1058, 2);
            WriteAttributeValue("", 1027, "/Admin/Category/Upsert/", 1027, 23, true);
#nullable restore
#line 37 "C:\Users\yogi0000\Source\Repos\angat-yogi\MeroThriftGhar\MeroThriftGhar\MeroThriftGhar\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 1050, item.Id, 1050, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success text-white""
                               style=""cursor:pointer"">
                                <i class=""fas fa-edit""></i>
                            </a>
                            &nbsp;
                            <button onclick=Delete(""/Admin/Category/Delete/");
#nullable restore
#line 42 "C:\Users\yogi0000\Source\Repos\angat-yogi\MeroThriftGhar\MeroThriftGhar\MeroThriftGhar\Areas\Admin\Views\Category\Index.cshtml"
                                                                      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""")
                                    class=""btn btn-danger text-white"" style=""cursor:pointer"">
                                <i class=""fas fa-trash-alt""></i>
                            </button>
                        </div>
                    </td>
                </tr>
");
#nullable restore
#line 49 "C:\Users\yogi0000\Source\Repos\angat-yogi\MeroThriftGhar\MeroThriftGhar\MeroThriftGhar\Areas\Admin\Views\Category\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "040e7b2da518d7d8d966496416c4aa3497968df210292", async() => {
            }
            );
            __MeroThriftGhar_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::MeroThriftGhar.TagHelpers.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__MeroThriftGhar_TagHelpers_PageLinkTagHelper);
#nullable restore
#line 51 "C:\Users\yogi0000\Source\Repos\angat-yogi\MeroThriftGhar\MeroThriftGhar\MeroThriftGhar\Areas\Admin\Views\Category\Index.cshtml"
__MeroThriftGhar_TagHelpers_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __MeroThriftGhar_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 51 "C:\Users\yogi0000\Source\Repos\angat-yogi\MeroThriftGhar\MeroThriftGhar\MeroThriftGhar\Areas\Admin\Views\Category\Index.cshtml"
__MeroThriftGhar_TagHelpers_PageLinkTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __MeroThriftGhar_TagHelpers_PageLinkTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __MeroThriftGhar_TagHelpers_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __MeroThriftGhar_TagHelpers_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __MeroThriftGhar_TagHelpers_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <br />\r\n");
#nullable restore
#line 55 "C:\Users\yogi0000\Source\Repos\angat-yogi\MeroThriftGhar\MeroThriftGhar\MeroThriftGhar\Areas\Admin\Views\Category\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p> No Categories Exists.</p>\r\n");
#nullable restore
#line 59 "C:\Users\yogi0000\Source\Repos\angat-yogi\MeroThriftGhar\MeroThriftGhar\MeroThriftGhar\Areas\Admin\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>
        function Delete(url) {
            $.ajax({
                type: 'DELETE',
                url: url,
                success: function (data) {
                    location.reload();
                }
            });
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MeroThriftGhar.Models.ViewModels.CategoryVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
