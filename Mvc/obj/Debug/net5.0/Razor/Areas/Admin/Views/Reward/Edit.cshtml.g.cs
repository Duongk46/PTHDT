#pragma checksum "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9ffe84a972994e48e3694bb7b84d088b36fd007"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Reward_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Reward/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9ffe84a972994e48e3694bb7b84d088b36fd007", @"/Areas/Admin/Views/Reward/Edit.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Reward_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mvc.Areas.Admin.Models.RewardViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Areas/Admin/Views/Shared/Layout/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 10 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
         using (Html.BeginForm("", "", FormMethod.Post, new { action = "/Admin/Reward/Edit" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-horizontal\">\r\n            <h4>Chỉnh sửa khen thưởng</h4>\r\n            <hr />\r\n            ");
#nullable restore
#line 16 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
             if (ViewBag.Message != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-danger\">");
#nullable restore
#line 19 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
                                           Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 20 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
#nullable restore
#line 21 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
       Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 22 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
       Write(Html.HiddenFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 23 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
       Write(Html.HiddenFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 24 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
       Write(Html.HiddenFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 25 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
       Write(Html.HiddenFor(model => model.IDEmployee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 27 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
           Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"form-width-txt\">\r\n                    ");
#nullable restore
#line 29 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
               Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" ,@disabled="disabled"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 30 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 34 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
           Write(Html.LabelFor(model => model.NameReward, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"form-width-txt\">\r\n                    ");
#nullable restore
#line 36 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
               Write(Html.TextBoxFor(model => model.NameReward, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 37 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.NameReward, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 41 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
           Write(Html.LabelFor(model => model.Money, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"form-width-txt\">\r\n                    ");
#nullable restore
#line 43 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
               Write(Html.TextBoxFor(model => model.Money, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 44 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Money, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 48 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
           Write(Html.LabelFor(model => model.Status, htmlAttributes: new { @class = "control-label " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div>\r\n                    ");
#nullable restore
#line 50 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
               Write(Html.CheckBoxFor(model => model.Status, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 51 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
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
#line 60 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mvc.Areas.Admin.Models.RewardViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
