#pragma checksum "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Shared\Layout\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00c2f3930babc0b0f01057b7890c87bc95761649"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Layout__Layout), @"mvc.1.0.view", @"/Views/Shared/Layout/_Layout.cshtml")]
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
#line 1 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Shared\Layout\_Layout.cshtml"
using Abp.Configuration.Startup;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Shared\Layout\_Layout.cshtml"
using Abp.Web.Mvc.Alerts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Shared\Layout\_Layout.cshtml"
using Abp.Web.Security.AntiForgery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Shared\Layout\_Layout.cshtml"
using SchoolManage.Web.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00c2f3930babc0b0f01057b7890c87bc95761649", @"/Views/Shared/Layout/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e567d3dc16a19f83c999bc6edc5402b9752ca5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Layout__Layout : SchoolManage.Web.Views.SchoolManageRazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 10 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Shared\Layout\_Layout.cshtml"
  
    AbpAntiForgeryManager.SetCookie(Context);

    var pageTitle = !string.IsNullOrWhiteSpace(ViewBag.Title) ? ViewBag.Title + " / " : "";
    pageTitle += "SchoolManage";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html");
            BeginWriteAttribute("lang", " lang=\"", 550, "\"", 594, 1);
#nullable restore
#line 17 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Shared\Layout\_Layout.cshtml"
WriteAttributeValue("", 557, LanguageManager.CurrentLanguage.Name, 557, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00c2f3930babc0b0f01057b7890c87bc957616495208", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n    <meta http-equiv=\"x-ua-compatible\" content=\"ie=edge\">\n\n    <title>");
#nullable restore
#line 23 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Shared\Layout\_Layout.cshtml"
      Write(pageTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\n\n    ");
#nullable restore
#line 25 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Shared\Layout\_Layout.cshtml"
Write(await Html.PartialAsync("_Styles.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    ");
#nullable restore
#line 26 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Shared\Layout\_Layout.cshtml"
Write(RenderSection("styles", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00c2f3930babc0b0f01057b7890c87bc957616497191", async() => {
                WriteLiteral("\n    <div class=\"wrapper\">\n        ");
#nullable restore
#line 30 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Shared\Layout\_Layout.cshtml"
   Write(await Html.PartialAsync("_Header.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        ");
#nullable restore
#line 31 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Shared\Layout\_Layout.cshtml"
   Write(await Html.PartialAsync("_SideBar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <div class=\"content-wrapper\">\n            ");
#nullable restore
#line 33 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Shared\Layout\_Layout.cshtml"
       Write(await Html.PartialAsync("_Alerts.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            ");
#nullable restore
#line 34 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Shared\Layout\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n        ");
#nullable restore
#line 36 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Shared\Layout\_Layout.cshtml"
   Write(await Html.PartialAsync("_Footer.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </div>\n\n    ");
#nullable restore
#line 39 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Shared\Layout\_Layout.cshtml"
Write(await Html.PartialAsync("_Scripts.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    ");
#nullable restore
#line 40 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Shared\Layout\_Layout.cshtml"
Write(RenderSection("scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    ");
#nullable restore
#line 41 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Shared\Layout\_Layout.cshtml"
Write(WebResourceManager.RenderScripts());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ILanguageManager LanguageManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAlertManager AlertManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWebResourceManager WebResourceManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IMultiTenancyConfig MultiTenancyConfig { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAbpAntiForgeryManager AbpAntiForgeryManager { get; private set; }
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
