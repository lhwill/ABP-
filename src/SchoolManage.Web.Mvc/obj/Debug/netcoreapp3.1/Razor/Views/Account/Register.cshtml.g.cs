#pragma checksum "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f25bb9238ca9324273d9411479ea59d51228a48c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
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
#line 1 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
using Abp.Authorization.Users;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f25bb9238ca9324273d9411479ea59d51228a48c", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e567d3dc16a19f83c999bc6edc5402b9752ca5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : SchoolManage.Web.Views.SchoolManageRazorPage<SchoolManage.Web.Models.Account.RegisterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Account/Register.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Account/Register.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-flat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("RegisterForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
  
    ViewBag.Title = L("Register");

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f25bb9238ca9324273d9411479ea59d51228a48c7102", async() => {
                    WriteLiteral("\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f25bb9238ca9324273d9411479ea59d51228a48c7381", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 9 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
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
                    WriteLiteral("\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f25bb9238ca9324273d9411479ea59d51228a48c10413", async() => {
                    WriteLiteral("\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f25bb9238ca9324273d9411479ea59d51228a48c10693", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 13 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
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
                    WriteLiteral("\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            WriteLiteral("<h4 class=\"text-center\">");
#nullable restore
#line 16 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
                   Write(L("Register"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f25bb9238ca9324273d9411479ea59d51228a48c14074", async() => {
                WriteLiteral("\n");
#nullable restore
#line 18 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
     if (ViewBag.ErrorMessage != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"alert alert-danger\">\n            <i class=\"fas fa-warning\"></i> ");
#nullable restore
#line 21 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
                                      Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n");
#nullable restore
#line 23 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <input type=\"hidden\" name=\"IsExternalLogin\"");
                BeginWriteAttribute("value", " value=\"", 801, "\"", 842, 1);
#nullable restore
#line 24 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 809, Model.IsExternalLogin.ToString(), 809, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n    <input type=\"hidden\" name=\"ExternalLoginAuthSchema\"");
                BeginWriteAttribute("value", " value=\"", 902, "\"", 940, 1);
#nullable restore
#line 25 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 910, Model.ExternalLoginAuthSchema, 910, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n    <div class=\"input-group mb-3\">\n        <input type=\"text\" name=\"Name\" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1039, "\"", 1063, 1);
#nullable restore
#line 27 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1053, L("Name"), 1053, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1064, "\"", 1083, 1);
#nullable restore
#line 27 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1072, Model.Name, 1072, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 1093, "\"", 1131, 1);
#nullable restore
#line 27 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1105, AbpUserBase.MaxNameLength, 1105, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
        <div class=""input-group-append"">
            <div class=""input-group-text"">
                <span class=""fas fa-arrow-left""></span>
            </div>
        </div>
    </div>
    <div class=""input-group mb-3"">
        <input type=""text"" name=""Surname"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1416, "\"", 1443, 1);
#nullable restore
#line 35 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1430, L("Surname"), 1430, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1444, "\"", 1466, 1);
#nullable restore
#line 35 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1452, Model.Surname, 1452, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 1476, "\"", 1517, 1);
#nullable restore
#line 35 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1488, AbpUserBase.MaxSurnameLength, 1488, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
        <div class=""input-group-append"">
            <div class=""input-group-text"">
                <span class=""fas fa-arrow-left""></span>
            </div>
        </div>
    </div>
    <div class=""input-group mb-3"">
        <input type=""email"" name=""EmailAddress"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1808, "\"", 1840, 1);
#nullable restore
#line 43 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1822, L("EmailAddress"), 1822, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1841, "\"", 1868, 1);
#nullable restore
#line 43 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1849, Model.EmailAddress, 1849, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 1878, "\"", 1924, 1);
#nullable restore
#line 43 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1890, AbpUserBase.MaxEmailAddressLength, 1890, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
        <div class=""input-group-append"">
            <div class=""input-group-text"">
                <span class=""fas fa-envelope""></span>
            </div>
        </div>
    </div>
    <div class=""input-group mb-3"">
        <input type=""text"" name=""UserName"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2208, "\"", 2236, 1);
#nullable restore
#line 51 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2222, L("UserName"), 2222, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2237, "\"", 2260, 1);
#nullable restore
#line 51 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2245, Model.UserName, 2245, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 2270, "\"", 2312, 1);
#nullable restore
#line 51 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2282, AbpUserBase.MaxUserNameLength, 2282, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
        <div class=""input-group-append"">
            <div class=""input-group-text"">
                <span class=""fas fa-user""></span>
            </div>
        </div>
    </div>
    <div class=""input-group mb-3"">
        <input type=""password"" name=""Password"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2596, "\"", 2624, 1);
#nullable restore
#line 59 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2610, L("Password"), 2610, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 2634, "\"", 2681, 1);
#nullable restore
#line 59 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2646, AbpUserBase.MaxPlainPasswordLength, 2646, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n        <div class=\"input-group-append\">\n            <div class=\"input-group-text\">\n                <span class=\"fas fa-lock\"></span>\n            </div>\n        </div>\n    </div>\n    <div class=\"row\">\n        <div class=\"col-8\">\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f25bb9238ca9324273d9411479ea59d51228a48c23544", async() => {
                    WriteLiteral("<i class=\"fa fa-arrow-circle-left\"></i> ");
#nullable restore
#line 68 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
                                                                                                      Write(L("Back"));

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        </div>\n        <div class=\"col-4\">\n            <button type=\"submit\" id=\"RegisterButton\" class=\"btn btn-primary btn-flat float-right\">");
#nullable restore
#line 71 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Account\Register.cshtml"
                                                                                              Write(L("Register"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\n        </div>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolManage.Web.Models.Account.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591