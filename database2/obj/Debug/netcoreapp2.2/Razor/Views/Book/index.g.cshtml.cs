#pragma checksum "C:\Users\Lenovo\source\repos\database2\database2\Views\Book\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd3dd91476be6f4c697366753cbb15742c509cc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_index), @"mvc.1.0.view", @"/Views/Book/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/index.cshtml", typeof(AspNetCore.Views_Book_index))]
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
#line 1 "C:\Users\Lenovo\source\repos\database2\database2\Views\_ViewImports.cshtml"
using database2;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\source\repos\database2\database2\Views\_ViewImports.cshtml"
using database2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd3dd91476be6f4c697366753cbb15742c509cc4", @"/Views/Book/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c93cd46084c593113a316e844ce137cdbdfb6ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Lenovo\source\repos\database2\database2\Views\Book\index.cshtml"
  
    ViewData["Title"] = "รายการหนังสือ";

#line default
#line hidden
            BeginContext(68, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(75, 17, false);
#line 6 "C:\Users\Lenovo\source\repos\database2\database2\Views\Book\index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(92, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 7 "C:\Users\Lenovo\source\repos\database2\database2\Views\Book\index.cshtml"
 if (User.Identity.IsAuthenticated)
{


#line default
#line hidden
            BeginContext(141, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd3dd91476be6f4c697366753cbb15742c509cc45361", async() => {
                BeginContext(211, 16, true);
                WriteLiteral("เพิ่มหนังสือไหม่");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(231, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "C:\Users\Lenovo\source\repos\database2\database2\Views\Book\index.cshtml"
}

#line default
#line hidden
            BeginContext(236, 65, true);
            WriteLiteral("\r\n\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(302, 33, false);
#line 18 "C:\Users\Lenovo\source\repos\database2\database2\Views\Book\index.cshtml"
       Write(Html.DisplayNameFor(m => m[0].Id));

#line default
#line hidden
            EndContext();
            BeginContext(335, 45, true);
            WriteLiteral("\r\n        </th>\r\n\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(381, 35, false);
#line 22 "C:\Users\Lenovo\source\repos\database2\database2\Views\Book\index.cshtml"
       Write(Html.DisplayNameFor(m => m[0].Name));

#line default
#line hidden
            EndContext();
            BeginContext(416, 45, true);
            WriteLiteral("\r\n        </th>\r\n\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(462, 36, false);
#line 26 "C:\Users\Lenovo\source\repos\database2\database2\Views\Book\index.cshtml"
       Write(Html.DisplayNameFor(m => m[0].Price));

#line default
#line hidden
            EndContext();
            BeginContext(498, 17, true);
            WriteLiteral("\r\n        </th>\r\n");
            EndContext();
#line 28 "C:\Users\Lenovo\source\repos\database2\database2\Views\Book\index.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
            BeginContext(571, 63, true);
            WriteLiteral("            <th>\r\n                (คำสั่ง)\r\n            </th>\r\n");
            EndContext();
#line 33 "C:\Users\Lenovo\source\repos\database2\database2\Views\Book\index.cshtml"
        }

#line default
#line hidden
            BeginContext(645, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 35 "C:\Users\Lenovo\source\repos\database2\database2\Views\Book\index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(701, 36, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(738, 29, false);
#line 39 "C:\Users\Lenovo\source\repos\database2\database2\Views\Book\index.cshtml"
       Write(Html.DisplayFor(m => m[0].Id));

#line default
#line hidden
            EndContext();
            BeginContext(767, 45, true);
            WriteLiteral("\r\n        </td>\r\n\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(813, 31, false);
#line 43 "C:\Users\Lenovo\source\repos\database2\database2\Views\Book\index.cshtml"
       Write(Html.DisplayFor(m => m[0].Name));

#line default
#line hidden
            EndContext();
            BeginContext(844, 45, true);
            WriteLiteral("\r\n        </td>\r\n\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(890, 32, false);
#line 47 "C:\Users\Lenovo\source\repos\database2\database2\Views\Book\index.cshtml"
       Write(Html.DisplayFor(m => m[0].Price));

#line default
#line hidden
            EndContext();
            BeginContext(922, 17, true);
            WriteLiteral("\r\n        </td>\r\n");
            EndContext();
#line 49 "C:\Users\Lenovo\source\repos\database2\database2\Views\Book\index.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
            BeginContext(995, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(1029, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd3dd91476be6f4c697366753cbb15742c509cc410787", async() => {
                BeginContext(1100, 5, true);
                WriteLiteral("แก้ไข");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\Lenovo\source\repos\database2\database2\Views\Book\index.cshtml"
                                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1109, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1127, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd3dd91476be6f4c697366753cbb15742c509cc413357", async() => {
                BeginContext(1200, 6, true);
                WriteLiteral("ลบทิ้ง");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\Lenovo\source\repos\database2\database2\Views\Book\index.cshtml"
                                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1210, 25, true);
            WriteLiteral("\r\n\r\n\r\n            </td>\r\n");
            EndContext();
#line 57 "C:\Users\Lenovo\source\repos\database2\database2\Views\Book\index.cshtml"

        }

#line default
#line hidden
            BeginContext(1248, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 60 "C:\Users\Lenovo\source\repos\database2\database2\Views\Book\index.cshtml"
        }

#line default
#line hidden
            BeginContext(1274, 12, true);
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
