#pragma checksum "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a963579f3c88958e6b3c9952c874b6355c3d404"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Reward_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Reward/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a963579f3c88958e6b3c9952c874b6355c3d404", @"/Areas/Admin/Views/Reward/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Reward_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mvc.Areas.Admin.Models.RewardViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/../Areas/Admin/assets/js/Reward.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/Layout/_Layout.cshtml";
    var pagination = (Mvc.Models.PaginationModel)ViewData["Pagination"];

#line default
#line hidden
#nullable disable
            DefineSection("js", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a963579f3c88958e6b3c9952c874b6355c3d4043430", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("<div class=\"container-fluid\">\r\n    <!-- DataTales Example -->\r\n");
#nullable restore
#line 12 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
     if (Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""card shadow mb-4"">
            <div class=""card-header py-3"">
                <h6 class=""m-0 font-weight-bold text-primary"">Danh sách khen thưởng</h6>
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>Tên giải thưởng</th>
                                <th>Tên người nhận</th>
                                <th>Tiền thưởng</th>
                                <th>Công cụ</th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <th>Tên giải thưởng</th>
                                <th>Tên người nhận</th>
                                <th>Tiền thưởng</th>
                                <th>Công cụ</th>
  ");
            WriteLiteral("                          </tr>\r\n                        </tfoot>\r\n                        <tbody>\r\n");
#nullable restore
#line 38 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
                             foreach (var item in Model)
                            {
                                var tick = "fa-solid fa-check color-tick";
                                var xmask = "fa-solid fa-xmark color-xmask";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr");
            BeginWriteAttribute("class", " class=\"", 1821, "\"", 1842, 2);
            WriteAttributeValue("", 1829, "item-", 1829, 5, true);
#nullable restore
#line 42 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
WriteAttributeValue("", 1834, item.ID, 1834, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <td>");
#nullable restore
#line 43 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
                                   Write(item.NameReward);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 45 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 47 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
                                   Write(item.Money);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2188, "\"", 2222, 2);
            WriteAttributeValue("", 2195, "/Admin/Reward/Edit/", 2195, 19, true);
#nullable restore
#line 49 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
WriteAttributeValue("", 2214, item.ID, 2214, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-right: 2px\"><i class=\"fa-solid fa-pen color-edit\"></i></a>\r\n                                        <span class=\"_deleteReward\" data-bs-toggle=\"modal\" data-bs-target=\"#deleteReward\" data-id=\"");
#nullable restore
#line 50 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
                                                                                                                              Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" style=\"cursor: pointer; margin-right: 2px\"><i class=\"fa-solid fa-trash color-trash\"></i></span>\r\n                                        <i");
            BeginWriteAttribute("class", " class=\"", 2578, "\"", 2623, 1);
#nullable restore
#line 51 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
WriteAttributeValue("", 2586, item.Status == true ? tick : xmask, 2586, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 54 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
                <div class=""row"" style=""justify-content: space-between;"">
                    <div class=""col-sm-12 col-md-5"">
                        <div class=""dataTables_info"" id=""dataTable_info"" role=""status"" aria-live=""polite"">Showing ");
#nullable restore
#line 60 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
                                                                                                             Write(pagination.Show);

#line default
#line hidden
#nullable disable
            WriteLiteral(" to ");
#nullable restore
#line 60 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
                                                                                                                                 Write(pagination.ShowTo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 60 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
                                                                                                                                                       Write(pagination.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" entries</div>\r\n                    </div>\r\n                    <div class=\"col-md-4\">\r\n                        <div class=\"dataTables_paginate paging_simple_numbers\" id=\"dataTable_paginate\">\r\n                            <ul class=\"pagination\">\r\n");
#nullable restore
#line 65 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
                                 if (pagination.Total > 1)
                                {
                                    var pageDisplay = (int)(pagination.MaxPage);
                                    long totalPage = (long)(pagination.TotalPage);
                                    int currentPage = (int)(pagination.Page);
                                    var start = 1;
                                    var end = totalPage;
                                    var link = "/Admin/Reward";
                                    if (currentPage > 1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"paginate_button page-item previous\" id=\"dataTable_previous\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 4151, "\"", 4185, 3);
#nullable restore
#line 76 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
WriteAttributeValue("", 4158, link, 4158, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4163, "?page=", 4163, 6, true);
#nullable restore
#line 76 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
WriteAttributeValue("", 4169, pagination.Prev, 4169, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTable\" data-dt-idx=\"0\" tabindex=\"0\" class=\"page-link\">Previous</a>\r\n                                        </li>\r\n");
#nullable restore
#line 78 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"paginate_button page-item previous disabled\" id=\"dataTable_previous\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 4609, "\"", 4643, 3);
#nullable restore
#line 82 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
WriteAttributeValue("", 4616, link, 4616, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4621, "?page=", 4621, 6, true);
#nullable restore
#line 82 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
WriteAttributeValue("", 4627, pagination.Prev, 4627, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTable\" data-dt-idx=\"0\" tabindex=\"0\" class=\"page-link\">Previous</a>\r\n                                        </li>\r\n");
#nullable restore
#line 84 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
                                    }
                                    for (int i = start; i <= end; i++)
                                    {
                                        if (currentPage == i)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"paginate_button page-item active\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 5176, "\"", 5196, 3);
#nullable restore
#line 90 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
WriteAttributeValue("", 5183, link, 5183, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5188, "?page=", 5188, 6, true);
#nullable restore
#line 90 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
WriteAttributeValue("", 5194, i, 5194, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTable\" data-dt-idx=\"");
#nullable restore
#line 90 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
                                                                                                          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" tabindex=\"0\" class=\"page-link\">");
#nullable restore
#line 90 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
                                                                                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 92 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"paginate_button page-item \">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 5598, "\"", 5618, 3);
#nullable restore
#line 96 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
WriteAttributeValue("", 5605, link, 5605, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5610, "?page=", 5610, 6, true);
#nullable restore
#line 96 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
WriteAttributeValue("", 5616, i, 5616, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTable\" data-dt-idx=\"");
#nullable restore
#line 96 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
                                                                                                          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" tabindex=\"0\" class=\"page-link\">");
#nullable restore
#line 96 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
                                                                                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 98 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
                                        }
                                    }
                                    if (currentPage < totalPage)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"paginate_button page-item next\" id=\"dataTable_next\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 6091, "\"", 6125, 3);
#nullable restore
#line 103 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
WriteAttributeValue("", 6098, link, 6098, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6103, "?page=", 6103, 6, true);
#nullable restore
#line 103 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
WriteAttributeValue("", 6109, pagination.Next, 6109, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTable\" data-dt-idx=\"");
#nullable restore
#line 103 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
                                                                                                                    Write(pagination.Next);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" tabindex=\"0\" class=\"page-link\">Next</a>\r\n                                        </li>\r\n");
#nullable restore
#line 105 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"paginate_button page-item next disabled\" id=\"dataTable_next\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 6552, "\"", 6586, 3);
#nullable restore
#line 109 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
WriteAttributeValue("", 6559, link, 6559, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6564, "?page=", 6564, 6, true);
#nullable restore
#line 109 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
WriteAttributeValue("", 6570, pagination.Next, 6570, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTable\" data-dt-idx=\"");
#nullable restore
#line 109 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
                                                                                                                    Write(pagination.Next);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" tabindex=\"0\" class=\"page-link\">Next</a>\r\n                                        </li>\r\n");
#nullable restore
#line 111 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 119 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Reward\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<div class=""modal fade"" id=""deleteReward"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h1 class=""modal-title fs-5"" id=""exampleModalLabel"">Modal title</h1>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                Bạn có chắc là muốn xóa nhân viên này?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Quay lại</button>
                <button type=""button"" class=""btn btn-primary btn-submit"">Đồng ý</button>
            </div>
        </div>
    </div>
</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mvc.Areas.Admin.Models.RewardViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
