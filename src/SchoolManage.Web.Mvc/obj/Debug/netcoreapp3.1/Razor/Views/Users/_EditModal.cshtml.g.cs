#pragma checksum "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49b74b112f746d5e79c44358b75c51cf094fbe5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users__EditModal), @"mvc.1.0.view", @"/Views/Users/_EditModal.cshtml")]
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
#line 1 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
using Abp.Authorization.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
using SchoolManage.Web.Models.Common.Modals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
using SchoolManage.Web.Models.Users;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49b74b112f746d5e79c44358b75c51cf094fbe5c", @"/Views/Users/_EditModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e567d3dc16a19f83c999bc6edc5402b9752ca5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Users__EditModal : SchoolManage.Web.Views.SchoolManageRazorPage<EditUserModalViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("UserEditForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Users/_EditModal.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("EditUser"))));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49b74b112f746d5e79c44358b75c51cf094fbe5c5984", async() => {
                WriteLiteral("\n    <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 375, "\"", 397, 1);
#nullable restore
#line 10 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 383, Model.User.Id, 383, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n    <div class=\"modal-body\">\n        <ul class=\"nav nav-tabs\" role=\"tablist\">\n            <li class=\"nav-item\">\n                <a class=\"nav-link active\" data-toggle=\"tab\" role=\"tab\" href=\"#edit-user-details\">");
#nullable restore
#line 14 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                                             Write(L("UserDetails"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\n            </li>\n            <li class=\"nav-item\">\n                <a class=\"nav-link\" data-toggle=\"tab\" role=\"tab\" href=\"#edit-user-roles\">");
#nullable restore
#line 17 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                                    Write(L("UserRoles"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a>
            </li>
        </ul>
        <div class=""tab-content mt-4"">
            <div role=""tabpanel"" class=""tab-pane container active"" id=""edit-user-details"">
                <div class=""form-group row required"">
                    <label class=""col-md-3 col-form-label"" for=""username"">");
#nullable restore
#line 23 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                     Write(L("UserName"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n                    <div class=\"col-md-9\">\n                        <input id=\"username\" type=\"text\" class=\"form-control\" name=\"UserName\"");
                BeginWriteAttribute("value", " value=\"", 1244, "\"", 1272, 1);
#nullable restore
#line 25 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 1252, Model.User.UserName, 1252, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 1282, "\"", 1324, 1);
#nullable restore
#line 25 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 1294, AbpUserBase.MaxUserNameLength, 1294, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" minlength=\"2\">\n                    </div>\n                </div>\n                <div class=\"form-group row required\">\n                    <label class=\"col-md-3 col-form-label\" for=\"name\">");
#nullable restore
#line 29 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                 Write(L("Name"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n                    <div class=\"col-md-9\">\n                        <input id=\"name\" type=\"text\" class=\"form-control\" name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 1662, "\"", 1686, 1);
#nullable restore
#line 31 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 1670, Model.User.Name, 1670, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 1696, "\"", 1734, 1);
#nullable restore
#line 31 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 1708, AbpUserBase.MaxNameLength, 1708, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    </div>\n                </div>\n                <div class=\"form-group row required\">\n                    <label class=\"col-md-3 col-form-label\" for=\"surname\">");
#nullable restore
#line 35 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                    Write(L("Surname"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n                    <div class=\"col-md-9\">\n                        <input id=\"surname\" type=\"text\" class=\"form-control\" name=\"Surname\"");
                BeginWriteAttribute("value", " value=\"", 2070, "\"", 2097, 1);
#nullable restore
#line 37 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 2078, Model.User.Surname, 2078, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 2107, "\"", 2148, 1);
#nullable restore
#line 37 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 2119, AbpUserBase.MaxSurnameLength, 2119, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    </div>\n                </div>\n                <div class=\"form-group row required\">\n                    <label class=\"col-md-3 col-form-label\" for=\"email\">");
#nullable restore
#line 41 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                  Write(L("EmailAddress"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n                    <div class=\"col-md-9\">\n                        <input id=\"email\" type=\"email\" class=\"form-control\" name=\"EmailAddress\"");
                BeginWriteAttribute("value", " value=\"", 2491, "\"", 2523, 1);
#nullable restore
#line 43 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 2499, Model.User.EmailAddress, 2499, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 2533, "\"", 2579, 1);
#nullable restore
#line 43 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 2545, AbpUserBase.MaxEmailAddressLength, 2545, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    </div>\n                </div>\n                <div class=\"form-group row\">\n                    <label class=\"col-md-3 col-form-label\" for=\"IsActive\">");
#nullable restore
#line 47 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                     Write(L("IsActive"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n                    <div class=\"col-md-9\">\n                        <input id=\"IsActive\" type=\"checkbox\" name=\"IsActive\" value=\"true\" ");
#nullable restore
#line 49 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                                      Write(Model.User.IsActive ? "checked" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" />\n                    </div>\n                </div>\n            </div>\n            <div role=\"tabpanel\" class=\"tab-pane container\" id=\"edit-user-roles\">\n                <div class=\"row\">\n");
#nullable restore
#line 55 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
                     foreach (var role in Model.Roles)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"col-md-6\">\n                            <input type=\"checkbox\" name=\"role\"");
                BeginWriteAttribute("value", " value=\"", 3321, "\"", 3349, 1);
#nullable restore
#line 58 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 3329, role.NormalizedName, 3329, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 3350, "\"", 3375, 1);
#nullable restore
#line 58 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 3358, role.Description, 3358, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"filled-in\"");
                BeginWriteAttribute("id", " id=\"", 3394, "\"", 3418, 1);
#nullable restore
#line 58 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 3399, $"role{role.Id}", 3399, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 58 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                                                                                                             Write(Model.UserIsInRole(role) ? "checked" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" />\n                            <label");
                BeginWriteAttribute("for", " for=\"", 3502, "\"", 3527, 1);
#nullable restore
#line 59 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 3508, $"role{role.Id}", 3508, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 3528, "\"", 3553, 1);
#nullable restore
#line 59 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 3536, role.DisplayName, 3536, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 59 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                                  Write(role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n                        </div>\n");
#nullable restore
#line 61 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n    ");
#nullable restore
#line 66 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/Modals/_ModalFooterWithSaveAndCancel.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49b74b112f746d5e79c44358b75c51cf094fbe5c20247", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 69 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Users\_EditModal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EditUserModalViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
