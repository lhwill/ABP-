#pragma checksum "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d8fa6c88b7806e43bd00e284e762ac092ff7a89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Home\Index.cshtml"
using SchoolManage.Web.Startup;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d8fa6c88b7806e43bd00e284e762ac092ff7a89", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e567d3dc16a19f83c999bc6edc5402b9752ca5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : SchoolManage.Web.Views.SchoolManageRazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/libs/chartjs/dist/Chart.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Home/Index.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/_Bundles/home-index.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Home\Index.cshtml"
  
    ViewBag.Title = L("HomePage");
    ViewBag.CurrentPageName = PageNames.Home;

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d8fa6c88b7806e43bd00e284e762ac092ff7a895353", async() => {
                    WriteLiteral("\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d8fa6c88b7806e43bd00e284e762ac092ff7a895632", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 9 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Home\Index.cshtml"
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
                    WriteLiteral("\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d8fa6c88b7806e43bd00e284e762ac092ff7a897685", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 10 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Home\Index.cshtml"
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
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d8fa6c88b7806e43bd00e284e762ac092ff7a8910712", async() => {
                    WriteLiteral("\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d8fa6c88b7806e43bd00e284e762ac092ff7a8910992", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 14 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Home\Index.cshtml"
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
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
            WriteLiteral("<div class=\"content-header\">\n    <div class=\"container-fluid\">\n        <div class=\"row mb-2\">\n            <div class=\"col-sm-12\">\n                <h1 class=\"m-0 text-dark\">");
#nullable restore
#line 21 "C:\Users\Will\Desktop\SchoolManage\5.7.0\aspnet-core\src\SchoolManage.Web.Mvc\Views\Home\Index.cshtml"
                                     Write(L("HomePage"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
            </div>
        </div>
    </div>
</div>
<section class=""content"">
    <div class=""container-fluid"">
        <!-- Info boxes -->
        <div class=""row"">
            <div class=""col-12 col-sm-6 col-md-3"">
                <div class=""info-box"">
                    <span class=""info-box-icon bg-info elevation-1""><i class=""fas fa-cog""></i></span>
                    <div class=""info-box-content"">
                        <span class=""info-box-text"">CPU Traffic</span>
                        <span class=""info-box-number"">
                            10
                            <small>%</small>
                        </span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
            </div>
            <!-- /.col -->
            <div class=""col-12 col-sm-6 col-md-3"">
                <div class=""info-box mb-3"">
                    <span class=""info-box-icon bg-danger elevation-1""><i class=""fas fa-thumbs-up""></");
            WriteLiteral(@"i></span>
                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Likes</span>
                        <span class=""info-box-number"">41,410</span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
            </div>
            <!-- /.col -->
            <!-- fix for small devices only -->
            <div class=""clearfix hidden-md-up""></div>
            <div class=""col-12 col-sm-6 col-md-3"">
                <div class=""info-box mb-3"">
                    <span class=""info-box-icon bg-success elevation-1""><i class=""fas fa-shopping-cart""></i></span>
                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Sales</span>
                        <span class=""info-box-number"">760</span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
            </div>
    ");
            WriteLiteral(@"        <!-- /.col -->
            <div class=""col-12 col-sm-6 col-md-3"">
                <div class=""info-box mb-3"">
                    <span class=""info-box-icon bg-warning elevation-1""><i class=""fas fa-users""></i></span>
                    <div class=""info-box-content"">
                        <span class=""info-box-text"">New Members</span>
                        <span class=""info-box-number"">2,000</span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
            </div>
            <!-- /.col -->
        </div>
        <!-- /.row -->
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h5 class=""card-title"">Monthly Recap Report</h5>
                        <div class=""card-tools"">
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                           ");
            WriteLiteral(@"     <i class=""fas fa-minus""></i>
                            </button>
                            <div class=""btn-group"">
                                <button type=""button"" class=""btn btn-tool dropdown-toggle"" data-toggle=""dropdown"">
                                    <i class=""fas fa-wrench""></i>
                                </button>
                                <div class=""dropdown-menu dropdown-menu-right"" role=""menu"">
                                    <a href=""#"" class=""dropdown-item"">Action</a>
                                    <a href=""#"" class=""dropdown-item"">Another action</a>
                                    <a href=""#"" class=""dropdown-item"">Something else here</a>
                                    <a class=""dropdown-divider""></a>
                                    <a href=""#"" class=""dropdown-item"">Separated link</a>
                                </div>
                            </div>
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""");
            WriteLiteral(@"remove"">
                                <i class=""fas fa-times""></i>
                            </button>
                        </div>
                    </div>
                    <!-- /.card-header -->
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col-md-8"">
                                <p class=""text-center"">
                                    <strong>Sales: 1 Jan, 2014 - 30 Jul, 2014</strong>
                                </p>
                                <div class=""chart"">
                                    <div class=""chartjs-size-monitor"">
                                        <div class=""chartjs-size-monitor-expand"">
                                            <div");
            BeginWriteAttribute("class", " class=\"", 5612, "\"", 5620, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\n                                        </div>\n                                        <div class=\"chartjs-size-monitor-shrink\">\n                                            <div");
            BeginWriteAttribute("class", " class=\"", 5806, "\"", 5814, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                        </div>
                                    </div>
                                    <!-- Sales Chart Canvas -->
                                    <canvas id=""salesChart"" height=""360"" style=""height: 180px; display: block; width: 730px;"" width=""1460"" class=""chartjs-render-monitor""></canvas>
                                </div>
                                <!-- /.chart-responsive -->
                            </div>
                            <!-- /.col -->
                            <div class=""col-md-4"">
                                <p class=""text-center"">
                                    <strong>Goal Completion</strong>
                                </p>
                                <div class=""progress-group"">
                                    Add Products to Cart
                                    <span class=""float-right""><b>160</b>/200</span>
                                    <div class=""progress progress-sm"">
                   ");
            WriteLiteral(@"                     <div class=""progress-bar bg-primary"" style=""width: 80%""></div>
                                    </div>
                                </div>
                                <!-- /.progress-group -->
                                <div class=""progress-group"">
                                    Complete Purchase
                                    <span class=""float-right""><b>310</b>/400</span>
                                    <div class=""progress progress-sm"">
                                        <div class=""progress-bar bg-danger"" style=""width: 75%""></div>
                                    </div>
                                </div>
                                <!-- /.progress-group -->
                                <div class=""progress-group"">
                                    <span class=""progress-text"">Visit Premium Page</span>
                                    <span class=""float-right""><b>480</b>/800</span>
                                    <div class=""progr");
            WriteLiteral(@"ess progress-sm"">
                                        <div class=""progress-bar bg-success"" style=""width: 60%""></div>
                                    </div>
                                </div>
                                <!-- /.progress-group -->
                                <div class=""progress-group"">
                                    Send Inquiries
                                    <span class=""float-right""><b>250</b>/500</span>
                                    <div class=""progress progress-sm"">
                                        <div class=""progress-bar bg-warning"" style=""width: 50%""></div>
                                    </div>
                                </div>
                                <!-- /.progress-group -->
                            </div>
                            <!-- /.col -->
                        </div>
                        <!-- /.row -->
                    </div>
                    <!-- ./card-body -->
                    <div class=""card-");
            WriteLiteral(@"footer"">
                        <div class=""row"">
                            <div class=""col-sm-3 col-6"">
                                <div class=""description-block border-right"">
                                    <span class=""description-percentage text-success""><i class=""fas fa-caret-up""></i> 17%</span>
                                    <h5 class=""description-header"">$35,210.43</h5>
                                    <span class=""description-text"">TOTAL REVENUE</span>
                                </div>
                                <!-- /.description-block -->
                            </div>
                            <!-- /.col -->
                            <div class=""col-sm-3 col-6"">
                                <div class=""description-block border-right"">
                                    <span class=""description-percentage text-warning""><i class=""fas fa-caret-left""></i> 0%</span>
                                    <h5 class=""description-header"">$10,390.90</h5>
              ");
            WriteLiteral(@"                      <span class=""description-text"">TOTAL COST</span>
                                </div>
                                <!-- /.description-block -->
                            </div>
                            <!-- /.col -->
                            <div class=""col-sm-3 col-6"">
                                <div class=""description-block border-right"">
                                    <span class=""description-percentage text-success""><i class=""fas fa-caret-up""></i> 20%</span>
                                    <h5 class=""description-header"">$24,813.53</h5>
                                    <span class=""description-text"">TOTAL PROFIT</span>
                                </div>
                                <!-- /.description-block -->
                            </div>
                            <!-- /.col -->
                            <div class=""col-sm-3 col-6"">
                                <div class=""description-block"">
                                    <span c");
            WriteLiteral(@"lass=""description-percentage text-danger""><i class=""fas fa-caret-down""></i> 18%</span>
                                    <h5 class=""description-header"">1200</h5>
                                    <span class=""description-text"">GOAL COMPLETIONS</span>
                                </div>
                                <!-- /.description-block -->
                            </div>
                        </div>
                        <!-- /.row -->
                    </div>
                    <!-- /.card-footer -->
                </div>
                <!-- /.card -->
            </div>
            <!-- /.col -->
        </div>
        <!-- /.row -->
        <!-- Main row -->
        <div class=""row"">
            <!-- Left col -->
            <div class=""col-md-8"">
                <!-- TABLE: LATEST ORDERS -->
                <div class=""card"">
                    <div class=""card-header border-transparent"">
                        <h3 class=""card-title"">Latest Orders</h3>
                        <d");
            WriteLiteral(@"iv class=""card-tools"">
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                                <i class=""fas fa-minus""></i>
                            </button>
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"">
                                <i class=""fas fa-times""></i>
                            </button>
                        </div>
                    </div>
                    <!-- /.card-header -->
                    <div class=""card-body p-0"">
                        <div class=""table-responsive"">
                            <table class=""table m-0"">
                                <thead>
                                    <tr>
                                        <th>Order ID</th>
                                        <th>Item</th>
                                        <th>Status</th>
                                        <th>Popularity</th>
                                    </");
            WriteLiteral(@"tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td><a href=""javascript:;"">OR9842</a></td>
                                        <td>Call of Duty IV</td>
                                        <td><span class=""badge badge-success"">Shipped</span></td>
                                        <td>
                                            <div class=""sparkbar"" data-color=""#00a65a"" data-height=""20"">90,80,90,-70,61,-83,63</div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td><a href=""javascript:;"">OR1848</a></td>
                                        <td>Samsung Smart TV</td>
                                        <td><span class=""badge badge-warning"">Pending</span></td>
                                        <td>
                                            <div clas");
            WriteLiteral(@"s=""sparkbar"" data-color=""#f39c12"" data-height=""20"">90,80,-90,70,61,-83,68</div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td><a href=""javascript:;"">OR7429</a></td>
                                        <td>iPhone 6 Plus</td>
                                        <td><span class=""badge badge-danger"">Delivered</span></td>
                                        <td>
                                            <div class=""sparkbar"" data-color=""#f56954"" data-height=""20"">90,-80,90,70,-61,83,63</div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td><a href=""javascript:;"">OR7429</a></td>
                                        <td>Samsung Smart TV</td>
                                        <td><span class=""badge badge-info"">Processing</span></td>
                ");
            WriteLiteral(@"                        <td>
                                            <div class=""sparkbar"" data-color=""#00c0ef"" data-height=""20"">90,80,-90,70,-61,83,63</div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td><a href=""javascript:;"">OR1848</a></td>
                                        <td>Samsung Smart TV</td>
                                        <td><span class=""badge badge-warning"">Pending</span></td>
                                        <td>
                                            <div class=""sparkbar"" data-color=""#f39c12"" data-height=""20"">90,80,-90,70,61,-83,68</div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td><a href=""javascript:;"">OR7429</a></td>
                                        <td>iPhone 6 Plus</td>
                                 ");
            WriteLiteral(@"       <td><span class=""badge badge-danger"">Delivered</span></td>
                                        <td>
                                            <div class=""sparkbar"" data-color=""#f56954"" data-height=""20"">90,-80,90,70,-61,83,63</div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td><a href=""javascript:;"">OR9842</a></td>
                                        <td>Call of Duty IV</td>
                                        <td><span class=""badge badge-success"">Shipped</span></td>
                                        <td>
                                            <div class=""sparkbar"" data-color=""#00a65a"" data-height=""20"">90,80,90,-70,61,-83,63</div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <!-- /");
            WriteLiteral(@".table-responsive -->
                    </div>
                    <!-- /.card-body -->
                    <div class=""card-footer clearfix"">
                        <a href=""javascript:void(0)"" class=""btn btn-sm btn-info float-left"">Place New Order</a>
                        <a href=""javascript:void(0)"" class=""btn btn-sm btn-secondary float-right"">View All Orders</a>
                    </div>
                    <!-- /.card-footer -->
                </div>
                <!-- /.card -->
            </div>
            <!-- /.col -->
            <div class=""col-md-4"">
                <!-- Info Boxes Style 2 -->
                <div class=""info-box mb-3 bg-warning"">
                    <span class=""info-box-icon""><i class=""fas fa-tag""></i></span>
                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Inventory</span>
                        <span class=""info-box-number"">5,200</span>
                    </div>
                    <!-- /.info-box-content -->
");
            WriteLiteral(@"                </div>
                <!-- /.info-box -->
                <div class=""info-box mb-3 bg-success"">
                    <span class=""info-box-icon""><i class=""fas fa-heart""></i></span>
                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Mentions</span>
                        <span class=""info-box-number"">92,050</span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
                <div class=""info-box mb-3 bg-danger"">
                    <span class=""info-box-icon""><i class=""fas fa-cloud-download-alt""></i></span>
                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Downloads</span>
                        <span class=""info-box-number"">114,381</span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
                <div class=""inf");
            WriteLiteral(@"o-box mb-3 bg-info"">
                    <span class=""info-box-icon""><i class=""fas fa-comment""></i></span>
                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Direct Messages</span>
                        <span class=""info-box-number"">163,921</span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
            </div>
            <!-- /.col -->
        </div>
        <!-- /.row -->
    </div>
</section>
");
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