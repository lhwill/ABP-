#pragma checksum "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_CreateModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c985b7cff2fe8d40c2d5e032485e18bc123178fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tenants__CreateModal), @"mvc.1.0.view", @"/Views/Tenants/_CreateModal.cshtml")]
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
#line 1 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
using Abp.Authorization.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
using Abp.MultiTenancy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
using SchoolManage.MultiTenancy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
using SchoolManage.Web.Models.Common.Modals;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c985b7cff2fe8d40c2d5e032485e18bc123178fe", @"/Views/Tenants/_CreateModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e567d3dc16a19f83c999bc6edc5402b9752ca5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Tenants__CreateModal : SchoolManage.Web.Views.SchoolManageRazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("tenantCreateForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"modal fade\" id=\"TenantCreateModal\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"TenantCreateModalLabel\" data-backdrop=\"static\">\n    <div class=\"modal-dialog modal-lg\" role=\"document\">\n        <div class=\"modal-content\">\n            ");
#nullable restore
#line 11 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
       Write(await Html.PartialAsync("~/Views/Shared/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("CreateNewTenant"))));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c985b7cff2fe8d40c2d5e032485e18bc123178fe5929", async() => {
                WriteLiteral("\n                <div class=\"modal-body\">\n                    <div class=\"form-group row required\">\n                        <label class=\"col-md-3 col-form-label\">");
#nullable restore
#line 15 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
                                                          Write(L("TenancyName"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n                        <div class=\"col-md-9\">\n                            <input type=\"text\" name=\"TenancyName\" class=\"form-control\" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 928, "\"", 975, 1);
#nullable restore
#line 17 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
WriteAttributeValue("", 940, AbpTenantBase.MaxTenancyNameLength, 940, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" minlength=\"2\">\n                        </div>\n                    </div>\n                    <div class=\"form-group row required\">\n                        <label class=\"col-md-3 col-form-label\">");
#nullable restore
#line 21 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
                                                          Write(L("Name"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n                        <div class=\"col-md-9\">\n                            <input type=\"text\" name=\"Name\" class=\"form-control\" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 1325, "\"", 1358, 1);
#nullable restore
#line 23 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
WriteAttributeValue("", 1337, Tenant.MaxNameLength, 1337, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                        </div>\n                    </div>\n                    <div class=\"form-group row required\">\n                        <label class=\"col-md-3 col-form-label\">");
#nullable restore
#line 27 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
                                                          Write(L("AdminEmailAddress"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n                        <div class=\"col-md-9\">\n                            <input type=\"email\" name=\"AdminEmailAddress\" class=\"form-control\" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 1721, "\"", 1767, 1);
#nullable restore
#line 29 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
WriteAttributeValue("", 1733, AbpUserBase.MaxEmailAddressLength, 1733, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                        </div>\n                    </div>\n                    <div class=\"form-group row\">\n                        <label class=\"col-md-3 col-form-label\">");
#nullable restore
#line 33 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
                                                          Write(L("DatabaseConnectionString"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" (");
#nullable restore
#line 33 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
                                                                                          Write(L("Optional"));

#line default
#line hidden
#nullable disable
                WriteLiteral(")</label>\n                        <div class=\"col-md-9\">\n                            <input type=\"text\" name=\"ConnectionString\" class=\"form-control\"");
                BeginWriteAttribute("maxlength", " maxlength=\"", 2134, "\"", 2186, 1);
#nullable restore
#line 35 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
WriteAttributeValue("", 2146, AbpTenantBase.MaxConnectionStringLength, 2146, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                        </div>\n                    </div>\n                    <div class=\"form-group row\">\n                        <label class=\"col-md-3 col-form-label\" for=\"CreateTenantIsActive\">");
#nullable restore
#line 39 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
                                                                                     Write(L("IsActive"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                        <div class=""col-md-9"">
                            <input id=""CreateTenantIsActive"" type=""checkbox"" name=""IsActive"" value=""true"" checked />
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <div class=""col-md-3"">
                        </div>
                        <div class=""col-md-9"">
                            <p>");
#nullable restore
#line 48 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
                          Write(L("DefaultPasswordIs", SchoolManage.Authorization.Users.User.DefaultPassword));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                        </div>\n                    </div>\n                </div>\n                ");
#nullable restore
#line 52 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
           Write(await Html.PartialAsync("~/Views/Shared/Modals/_ModalFooterWithSaveAndCancel.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            ");
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
            WriteLiteral("\n        </div>\n    </div>\n</div>\n");
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
