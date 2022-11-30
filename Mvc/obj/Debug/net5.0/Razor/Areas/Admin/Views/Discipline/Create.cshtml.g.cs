#pragma checksum "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdc319549ad0ca752005a7d018249c7e1218a505"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Discipline_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Discipline/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdc319549ad0ca752005a7d018249c7e1218a505", @"/Areas/Admin/Views/Discipline/Create.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Discipline_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mvc.Areas.Admin.Models.DisciplineViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Areas/Admin/Views/Shared/Layout/_Layout.cshtml";
    var typeName = (SelectList)ViewData["ListName"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 11 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Create.cshtml"
         using (Html.BeginForm("", "", FormMethod.Post, new { action = "/Admin/Discipline/Create" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Create.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-horizontal\">\r\n            <h4>Tạo kỉ luật</h4>\r\n            <hr />\r\n            ");
#nullable restore
#line 17 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Create.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 18 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Create.cshtml"
             if (ViewBag.Message != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-danger\">");
#nullable restore
#line 20 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Create.cshtml"
                                           Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 21 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Create.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 23 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Create.cshtml"
           Write(Html.LabelFor(model => model.NameDiscipline, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"form-width-txt\">\r\n                    ");
#nullable restore
#line 25 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Create.cshtml"
               Write(Html.TextBoxFor(model => model.NameDiscipline, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 26 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.NameDiscipline, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 30 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Create.cshtml"
           Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 1384, "\"", 1392, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 32 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Create.cshtml"
               Write(Html.DropDownListFor(model => model.Name, typeName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 33 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 37 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Create.cshtml"
           Write(Html.LabelFor(model => model.Money, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"form-width-txt\">\r\n                    ");
#nullable restore
#line 39 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Create.cshtml"
               Write(Html.TextBoxFor(model => model.Money, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 40 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Money, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 44 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Create.cshtml"
           Write(Html.LabelFor(model => model.Status, htmlAttributes: new { @class = "control-label " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div>\r\n                    ");
#nullable restore
#line 46 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Create.cshtml"
               Write(Html.CheckBoxFor(model => model.Status, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 47 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Status, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
            <div class=""form-group"">
                <div class=""col-md-offset-2"">
                    <input type=""submit"" value=""Thay đổi"" class=""btn btn-success"" />
                </div>
            </div>
        </div>
");
#nullable restore
#line 56 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Create.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mvc.Areas.Admin.Models.DisciplineViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
