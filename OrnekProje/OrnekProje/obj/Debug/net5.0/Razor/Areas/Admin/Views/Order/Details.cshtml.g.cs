#pragma checksum "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5a15b326fa97832be4170427c1d41c268d6eb95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Order_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Order/Details.cshtml")]
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
#line 1 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\_ViewImports.cshtml"
using OrnekProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\_ViewImports.cshtml"
using OrnekProje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5a15b326fa97832be4170427c1d41c268d6eb95", @"/Areas/Admin/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f2999b7df6223c759739c680a5f0b77170cb111", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrnekProje.Models.OrderDetailsVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5a15b326fa97832be4170427c1d41c268d6eb954017", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f5a15b326fa97832be4170427c1d41c268d6eb954279", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 8 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OrderHeader.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6"">
                <div>
                    <dl class=""row"">
                        <dt class=""col-sm-4"">
                            Adı
                        </dt>
                        <dd class=""col-sm-8"">
                            ");
#nullable restore
#line 18 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
                       Write(Model.OrderHeader.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-4\">\r\n                            Soyadı\r\n                        </dt>\r\n                        <dd class=\"col-sm-8\">\r\n                            ");
#nullable restore
#line 24 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
                       Write(Model.OrderHeader.Surname);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-4\">\r\n                            Telefon\r\n                        </dt>\r\n                        <dd class=\"col-sm-8\">\r\n                            ");
#nullable restore
#line 30 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
                       Write(Model.OrderHeader.PhoneNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-4\">\r\n                            Adres\r\n                        </dt>\r\n                        <dd class=\"col-sm-8\">\r\n                            ");
#nullable restore
#line 36 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
                       Write(Model.OrderHeader.Adres);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-4\">\r\n                            Semt\r\n                        </dt>\r\n                        <dd class=\"col-sm-8\">\r\n                            ");
#nullable restore
#line 42 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
                       Write(Model.OrderHeader.Semt);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-4\">\r\n                            Sehir\r\n                        </dt>\r\n                        <dd class=\"col-sm-8\">\r\n                            ");
#nullable restore
#line 48 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
                       Write(Model.OrderHeader.Sehir);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-4\">\r\n                            Posta Kodu\r\n                        </dt>\r\n                        <dd class=\"col-sm-8\">\r\n                            ");
#nullable restore
#line 54 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
                       Write(Model.OrderHeader.PostaKodu);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-4\">\r\n                            Sipariş Tarihi\r\n                        </dt>\r\n                        <dd class=\"col-sm-8\">\r\n                            ");
#nullable restore
#line 60 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
                       Write(Model.OrderHeader.OrderDate.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dd>\r\n                    </dl>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"col-md-6\">\r\n                <div class=\"col-md-12\">\r\n                    <ul class=\"list-group mb-3\">\r\n");
#nullable restore
#line 69 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
                         foreach (var item in Model.OrderDetails)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li class=\"list-group-item d-flex justify-content-between lh-sm\">\r\n                                <div>\r\n                                    <h6 class=\"my-0\">");
#nullable restore
#line 73 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
                                                Write(item.Product.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                                    <small class=\"text-muted\">Adet :");
#nullable restore
#line 74 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
                                                               Write(item.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n                                </div>\r\n                                <span class=\"text-muted\">");
#nullable restore
#line 76 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
                                                     Write((item.Count*item.Product.Price).ToString("0.00"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₺</span>\r\n                            </li>\r\n");
#nullable restore
#line 78 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <li class=""list-group-item d-flex justify-content-between bg-light"">
                            <div class=""text-success"">
                                <h6 class=""my-0"">Toplam Tutar :</h6>
                            </div>
                            <span class=""text-success"">");
#nullable restore
#line 83 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
                                                   Write(Model.OrderHeader.OrderTotal.ToString("0.00"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₺</span>\r\n                        </li>\r\n                    </ul>\r\n");
#nullable restore
#line 86 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
                     if (User.IsInRole(Diger.Role_Admin))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <br />\r\n");
#nullable restore
#line 89 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
                         if (Model.OrderHeader.OrderStatus == Diger.Durum_Onaylandi)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <input type=""submit"" value=""Kargoya Ver""
                                   class=""btn btn-primary form-control""
                                   formaction=""/Admin/Order/KargoyaVer""
                                   formmethod=""post"" />
");
#nullable restore
#line 95 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
                         if (Model.OrderHeader.OrderStatus == Diger.Durum_Beklemede)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <input type=""submit"" value=""Onayla""
                                   class=""btn btn-primary form-control""
                                   formaction=""/Admin/Order/Onaylandi""
                                   formmethod=""post"" />
");
#nullable restore
#line 102 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <label class=\"btn btn-primary form-control\">");
#nullable restore
#line 106 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
                                                               Write(Model.OrderHeader.OrderStatus);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
#nullable restore
#line 107 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Admin\Views\Order\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrnekProje.Models.OrderDetailsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
