#pragma checksum "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_EditModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4af0b0f322a5d0904a82457e118bfffff5acf4cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tenants__EditModal), @"mvc.1.0.view", @"/Views/Tenants/_EditModal.cshtml")]
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
#line 1 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_EditModal.cshtml"
using SchoolManage.MultiTenancy.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_EditModal.cshtml"
using SchoolManage.Web.Models.Common.Modals;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4af0b0f322a5d0904a82457e118bfffff5acf4cd", @"/Views/Tenants/_EditModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e567d3dc16a19f83c999bc6edc5402b9752ca5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Tenants__EditModal : SchoolManage.Web.Views.SchoolManageRazorPage<TenantDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("TenantEditForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Tenants/_EditModal.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_EditModal.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_EditModal.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("EditTenant"))));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4af0b0f322a5d0904a82457e118bfffff5acf4cd5775", async() => {
                WriteLiteral("\n    <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 335, "\"", 352, 1);
#nullable restore
#line 9 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_EditModal.cshtml"
WriteAttributeValue("", 343, Model.Id, 343, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n    <div class=\"modal-body\">\n        <div class=\"form-group row required\">\n            <label class=\"col-md-3 col-form-label\" for=\"tenancy-name\">");
#nullable restore
#line 12 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_EditModal.cshtml"
                                                                 Write(L("TenancyName"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n            <div class=\"col-md-9\">\n                <input id=\"tenancy-name\" type=\"text\" class=\"form-control\" name=\"TenancyName\"");
                BeginWriteAttribute("value", " value=\"", 655, "\"", 681, 1);
#nullable restore
#line 14 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_EditModal.cshtml"
WriteAttributeValue("", 663, Model.TenancyName, 663, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required maxlength=\"64\" minlength=\"2\">\n            </div>\n        </div>\n        <div class=\"form-group row required\">\n            <label class=\"col-md-3 col-form-label\" for=\"name\">");
#nullable restore
#line 18 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_EditModal.cshtml"
                                                         Write(L("Name"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n            <div class=\"col-md-9\">\n                <input id=\"name\" type=\"text\" class=\"form-control\" name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 995, "\"", 1014, 1);
#nullable restore
#line 20 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_EditModal.cshtml"
WriteAttributeValue("", 1003, Model.Name, 1003, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required maxlength=\"128\">\n            </div>\n        </div>\n        <div class=\"form-group row\">\n            <label class=\"col-md-3 col-form-label\" for=\"isactive\">");
#nullable restore
#line 24 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_EditModal.cshtml"
                                                             Write(L("IsActive"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n            <div class=\"col-md-9\">\n                <input id=\"isactive\" type=\"checkbox\" name=\"IsActive\" value=\"true\" ");
#nullable restore
#line 26 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_EditModal.cshtml"
                                                                              Write(Model.IsActive ? "checked" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" />\n            </div>\n        </div>\n    </div>\n    ");
#nullable restore
#line 30 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_EditModal.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4af0b0f322a5d0904a82457e118bfffff5acf4cd11108", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 33 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Tenants\_EditModal.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TenantDto> Html { get; private set; }
    }
}
#pragma warning restore 1591