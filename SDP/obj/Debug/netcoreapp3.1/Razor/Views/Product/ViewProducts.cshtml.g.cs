<<<<<<< HEAD
#pragma checksum "G:\SDP\Project\Shop-Management-System\SDP\Views\Product\ViewProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "938631858deeefac1f66eee3fdf2b1d81738009c"
=======
#pragma checksum "D:\sem 6\SDP\project\Shop-Management-System\SDP\Views\Product\ViewProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "938631858deeefac1f66eee3fdf2b1d81738009c"
>>>>>>> 1b2f2c627c97867cb5b7f88578ce1ee8aa731b95
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ViewProducts), @"mvc.1.0.view", @"/Views/Product/ViewProducts.cshtml")]
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
<<<<<<< HEAD
#line 1 "G:\SDP\Project\Shop-Management-System\SDP\Views\_ViewImports.cshtml"
=======
#line 1 "D:\sem 6\SDP\project\Shop-Management-System\SDP\Views\_ViewImports.cshtml"
>>>>>>> 1b2f2c627c97867cb5b7f88578ce1ee8aa731b95
using SDP;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "G:\SDP\Project\Shop-Management-System\SDP\Views\_ViewImports.cshtml"
=======
#line 2 "D:\sem 6\SDP\project\Shop-Management-System\SDP\Views\_ViewImports.cshtml"
>>>>>>> 1b2f2c627c97867cb5b7f88578ce1ee8aa731b95
using SDP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"938631858deeefac1f66eee3fdf2b1d81738009c", @"/Views/Product/ViewProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d05cba2b556eab87c229afa8de49a53b5eb5e26e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ViewProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SDP.Models.product>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
<<<<<<< HEAD
#line 2 "G:\SDP\Project\Shop-Management-System\SDP\Views\Product\ViewProducts.cshtml"
=======
#line 2 "D:\sem 6\SDP\project\Shop-Management-System\SDP\Views\Product\ViewProducts.cshtml"
>>>>>>> 1b2f2c627c97867cb5b7f88578ce1ee8aa731b95
  
    ViewData["Title"] = "ViewProducts";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""breadcumb-area bg-img bg-overlay"" style=""background-image: url(/img/bg-img/breadcumb3.jpg);"">
    <div class=""bradcumbContent"">
        <p>See what’s new</p>
        <h2>Products</h2>
    </div>
</section>
<section class=""events-area section-padding-100"">
    <div class=""container"">
        <div class=""row"">

            <!-- Product Area -->
");
#nullable restore
<<<<<<< HEAD
#line 18 "G:\SDP\Project\Shop-Management-System\SDP\Views\Product\ViewProducts.cshtml"
=======
#line 18 "D:\sem 6\SDP\project\Shop-Management-System\SDP\Views\Product\ViewProducts.cshtml"
>>>>>>> 1b2f2c627c97867cb5b7f88578ce1ee8aa731b95
             foreach (var arr in Model)
                {
                    var photoPath = "~/img/" + (arr.Photopath);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-12 col-md-6 col-lg-4"">
                    <div class=""single-event-area mb-30"">
                        <div class=""event-thumbnail"">
                            <button type=""button"" class=""btn btn-primary btn-lg"" data-toggle=""modal"" data-target=""#modalloginform"" style=""background-color: lightslategray ; border-color: brown"">");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "938631858deeefac1f66eee3fdf2b1d81738009c4363", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "938631858deeefac1f66eee3fdf2b1d81738009c4393", async() => {
>>>>>>> 1b2f2c627c97867cb5b7f88578ce1ee8aa731b95
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 24 "G:\SDP\Project\Shop-Management-System\SDP\Views\Product\ViewProducts.cshtml"
=======
#line 24 "D:\sem 6\SDP\project\Shop-Management-System\SDP\Views\Product\ViewProducts.cshtml"
>>>>>>> 1b2f2c627c97867cb5b7f88578ce1ee8aa731b95
                                                                                                                                                                                                WriteLiteral(photoPath);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
<<<<<<< HEAD
#line 24 "G:\SDP\Project\Shop-Management-System\SDP\Views\Product\ViewProducts.cshtml"
=======
#line 24 "D:\sem 6\SDP\project\Shop-Management-System\SDP\Views\Product\ViewProducts.cshtml"
>>>>>>> 1b2f2c627c97867cb5b7f88578ce1ee8aa731b95
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button>\r\n                        </div>\r\n                        <div class=\"event-text\">\r\n                            <h4>");
#nullable restore
<<<<<<< HEAD
#line 27 "G:\SDP\Project\Shop-Management-System\SDP\Views\Product\ViewProducts.cshtml"
=======
#line 27 "D:\sem 6\SDP\project\Shop-Management-System\SDP\Views\Product\ViewProducts.cshtml"
>>>>>>> 1b2f2c627c97867cb5b7f88578ce1ee8aa731b95
                           Write(Html.DisplayFor(x => arr.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n                            <div class=\"event-meta-data\">\r\n");
            WriteLiteral("                                <a href=\"#\" class=\"event-date\">");
#nullable restore
<<<<<<< HEAD
#line 30 "G:\SDP\Project\Shop-Management-System\SDP\Views\Product\ViewProducts.cshtml"
=======
#line 30 "D:\sem 6\SDP\project\Shop-Management-System\SDP\Views\Product\ViewProducts.cshtml"
>>>>>>> 1b2f2c627c97867cb5b7f88578ce1ee8aa731b95
                                                          Write(Html.DisplayFor(x => arr.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                            </div>\r\n                            <div class=\"event-meta-data\">\r\n                                <a href=\"#\" class=\"event-date\">");
#nullable restore
<<<<<<< HEAD
#line 33 "G:\SDP\Project\Shop-Management-System\SDP\Views\Product\ViewProducts.cshtml"
=======
#line 33 "D:\sem 6\SDP\project\Shop-Management-System\SDP\Views\Product\ViewProducts.cshtml"
>>>>>>> 1b2f2c627c97867cb5b7f88578ce1ee8aa731b95
                                                          Write(Html.DisplayFor(x => arr.originalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                            </div>\r\n                            <div class=\"event-meta-data\">\r\n                                <a href=\"#\" class=\"event-date\">");
#nullable restore
<<<<<<< HEAD
#line 36 "G:\SDP\Project\Shop-Management-System\SDP\Views\Product\ViewProducts.cshtml"
=======
#line 36 "D:\sem 6\SDP\project\Shop-Management-System\SDP\Views\Product\ViewProducts.cshtml"
>>>>>>> 1b2f2c627c97867cb5b7f88578ce1ee8aa731b95
                                                          Write(Html.DisplayFor(x => arr.MRP));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                            </div>\r\n                            <div class=\"event-meta-data\">\r\n                                <p class=\"font-color:white;\">Quantity</p><a href=\"#\" class=\"event-date\">");
#nullable restore
<<<<<<< HEAD
#line 39 "G:\SDP\Project\Shop-Management-System\SDP\Views\Product\ViewProducts.cshtml"
=======
#line 39 "D:\sem 6\SDP\project\Shop-Management-System\SDP\Views\Product\ViewProducts.cshtml"
>>>>>>> 1b2f2c627c97867cb5b7f88578ce1ee8aa731b95
                                                                                                   Write(Html.DisplayFor(x => arr.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                            </div>\r\n");
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
<<<<<<< HEAD
#line 45 "G:\SDP\Project\Shop-Management-System\SDP\Views\Product\ViewProducts.cshtml"
=======
#line 45 "D:\sem 6\SDP\project\Shop-Management-System\SDP\Views\Product\ViewProducts.cshtml"
>>>>>>> 1b2f2c627c97867cb5b7f88578ce1ee8aa731b95
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- Single Event Area -->\r\n\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SDP.Models.product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
