#pragma checksum "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cea991adc0c2e6054aa123550426700a91996f3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_BookSummary), @"mvc.1.0.view", @"/Views/Shared/BookSummary.cshtml")]
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
#line 1 "C:\Users\adria\source\repos\BookStore\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adria\source\repos\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adria\source\repos\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\adria\source\repos\BookStore\Views\_ViewImports.cshtml"
using BookStore.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cea991adc0c2e6054aa123550426700a91996f3d", @"/Views/Shared/BookSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0934b47b1fd5ffa9ed20e4349162ffef63aa4f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_BookSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card card-outline-primary p-4 bg-light mb-5\" style=\"margin: 5px;\">\r\n    <h4>\r\n        <span class=\"card-title float-left\">");
#nullable restore
#line 10 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
                                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span class=\"badge badge-light float-right text-secondary\">\r\n            ");
#nullable restore
#line 12 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
       Write(Model.AuthorFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
                              Write(Model.AuthorMiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
                                                      Write(Model.AuthorLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>\r\n    </h4>\r\n    <div class=\"text-info\">\r\n        <p><strong>");
#nullable restore
#line 16 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
              Write(Model.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n        <p>");
#nullable restore
#line 17 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
      Write(Model.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 18 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
      Write(Model.Classificaton);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 19 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
      Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>$");
#nullable restore
#line 20 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
       Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 21 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
      Write(Model.Pages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cea991adc0c2e6054aa123550426700a91996f3d7287", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cea991adc0c2e6054aa123550426700a91996f3d7553", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 25 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BookId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 885, "\"", 940, 1);
#nullable restore
#line 26 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
WriteAttributeValue("", 893, ViewContext.HttpContext.Request.PathAndQuery(), 893, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <span class=\"cart-text p-1\">\r\n            ");
#nullable restore
#line 28 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn-success btn-sm pull-right\" style=\"float:right\">\r\n                Add to Cart\r\n            </button>\r\n        </span>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 24 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
AddHtmlAttributeValue("", 742, Model.BookId, 742, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
