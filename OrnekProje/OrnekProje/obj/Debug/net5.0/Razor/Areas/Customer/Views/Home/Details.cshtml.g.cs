#pragma checksum "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Customer\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f3b86f7af343c4ba5d3cf23db5f4c1798159d3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Details), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Customer\Views\_ViewImports.cshtml"
using OrnekProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Customer\Views\_ViewImports.cshtml"
using OrnekProje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f3b86f7af343c4ba5d3cf23db5f4c1798159d3d", @"/Areas/Customer/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f2999b7df6223c759739c680a5f0b77170cb111", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrnekProje.Models.ShoppingCart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/css/etalage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/js/jquery.etalage.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/js/easyResponsiveTabs.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Customer\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/userlayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5f3b86f7af343c4ba5d3cf23db5f4c1798159d3d6468", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f3b86f7af343c4ba5d3cf23db5f4c1798159d3d7582", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5f3b86f7af343c4ba5d3cf23db5f4c1798159d3d7844", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 8 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Customer\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

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

    <div class=""content details-page"">
        <!---start-product-details--->
        <div class=""product-details"">
            <div class=""wrap"">
                <ul class=""product-head"">
                    <li><a href=""#"">AnaSayfa</a> <span>::</span></li>
                    <li class=""active-page""><a href=""#"">Ürün Detay</a></li>
                    <div class=""clear""> </div>
                </ul>
                <!----details-product-slider--->
                <!-- Include the Etalage files -->
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f3b86f7af343c4ba5d3cf23db5f4c1798159d3d10210", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f3b86f7af343c4ba5d3cf23db5f4c1798159d3d11402", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <!-- Include the Etalage files -->
                <script>
                    jQuery(document).ready(function ($) {

                        $('#etalage').etalage({
                            thumb_image_width: 300,
                            thumb_image_height: 400,
                            source_image_width: 900,
                            source_image_height: 1000,
                            show_hint: true,
                            click_callback: function (image_anchor, instance_id) {
                                alert('Callback example:\nYou clicked on an image with the anchor: ""' + image_anchor + '""\n(in Etalage instance: ""' + instance_id + '"")');
                            }
                        });
                        // This is for the dropdown list example:
                        $('.dropdownlist').change(function () {
                            etalage_show($(this).find('option:selected').attr('class'));
                        });

  ");
                WriteLiteral(@"                  });
                </script>
                <!----//details-product-slider--->
                <div class=""details-left"">
                    <div class=""details-left-slider"">
                        <ul id=""etalage"">
                            <li>
                                <a href=""optionallink.html"">
                                    <img class=""etalage_thumb_image""");
                BeginWriteAttribute("src", " src=\"", 2362, "\"", 2388, 1);
#nullable restore
#line 50 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Customer\Views\Home\Details.cshtml"
WriteAttributeValue("", 2368, Model.Product.Image, 2368, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <img class=\"etalage_source_image\"");
                BeginWriteAttribute("src", " src=\"", 2463, "\"", 2489, 1);
#nullable restore
#line 51 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Customer\Views\Home\Details.cshtml"
WriteAttributeValue("", 2469, Model.Product.Image, 2469, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                </a>\r\n                            </li>\r\n                            <li>\r\n                                <a href=\"optionallink.html\">\r\n                                    <img class=\"etalage_thumb_image\"");
                BeginWriteAttribute("src", " src=\"", 2732, "\"", 2758, 1);
#nullable restore
#line 56 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Customer\Views\Home\Details.cshtml"
WriteAttributeValue("", 2738, Model.Product.Image, 2738, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <img class=\"etalage_source_image\"");
                BeginWriteAttribute("src", " src=\"", 2833, "\"", 2859, 1);
#nullable restore
#line 57 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Customer\Views\Home\Details.cshtml"
WriteAttributeValue("", 2839, Model.Product.Image, 2839, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                </a>\r\n                            </li>\r\n                            <li>\r\n                                <a href=\"optionallink.html\">\r\n                                    <img class=\"etalage_thumb_image\"");
                BeginWriteAttribute("src", " src=\"", 3102, "\"", 3128, 1);
#nullable restore
#line 62 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Customer\Views\Home\Details.cshtml"
WriteAttributeValue("", 3108, Model.Product.Image, 3108, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <img class=\"etalage_source_image\"");
                BeginWriteAttribute("src", " src=\"", 3203, "\"", 3229, 1);
#nullable restore
#line 63 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Customer\Views\Home\Details.cshtml"
WriteAttributeValue("", 3209, Model.Product.Image, 3209, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                </a>\r\n                            </li>\r\n                            <li>\r\n                                <a href=\"optionallink.html\">\r\n                                    <img class=\"etalage_thumb_image\"");
                BeginWriteAttribute("src", " src=\"", 3472, "\"", 3498, 1);
#nullable restore
#line 68 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Customer\Views\Home\Details.cshtml"
WriteAttributeValue("", 3478, Model.Product.Image, 3478, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <img class=\"etalage_source_image\"");
                BeginWriteAttribute("src", " src=\"", 3573, "\"", 3599, 1);
#nullable restore
#line 69 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Customer\Views\Home\Details.cshtml"
WriteAttributeValue("", 3579, Model.Product.Image, 3579, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                </a>
                            </li>


                        </ul>
                    </div>
                    <div class=""details-left-info"">
                        <div class=""details-right-head"">
                            <h1> ");
#nullable restore
#line 78 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Customer\Views\Home\Details.cshtml"
                            Write(Model.Product.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h1>
                            <ul class=""pro-rate"">
                                <li><a class=""product-rate"" href=""#""> <label> </label></a> <span> </span></li>
                                <li><a href=""#"">0 Puanlar (Puan Ekle)</a></li>
                            </ul>
                            <p class=""product-detail-info"">");
#nullable restore
#line 83 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Customer\Views\Home\Details.cshtml"
                                                      Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </p>
                            <a class=""learn-more"" href=""#""><h3>DAHA FAZLA DETAY</h3></a>
                            <div class=""product-more-details"">
                                <ul class=""price-avl"">
                                    <li class=""price""><span>1000₺ </span><label>  ");
#nullable restore
#line 87 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Customer\Views\Home\Details.cshtml"
                                                                             Write(Model.Product.Price.ToString("0.00"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" ₺</label></li>
                                    <li class=""stock""><i>Stokta var</i></li>
                                    <div class=""clear""> </div>
                                </ul>
                                <ul class=""product-colors"">
                                    <h3>mevcut Renkler ::</h3>
                                    <li><a class=""color1"" href=""#""><span> </span></a></li>
                                    <li><a class=""color2"" href=""#""><span> </span></a></li>
                                    <li><a class=""color3"" href=""#""><span> </span></a></li>
                                    <li><a class=""color4"" href=""#""><span> </span></a></li>
                                    <li><a class=""color5"" href=""#""><span> </span></a></li>
                                    <li><a class=""color6"" href=""#""><span> </span></a></li>
                                    <li><a class=""color7"" href=""#""><span> </span></a></li>
                                    <li><a class=""color8""");
                WriteLiteral(@" href=""#""><span> </span></a></li>
                                    <div class=""clear""> </div>
                                </ul>
                                <ul class=""prosuct-qty"">
                                    <span>Miktar:</span>
                                    <select>
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f3b86f7af343c4ba5d3cf23db5f4c1798159d3d21470", async() => {
                    WriteLiteral("1");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f3b86f7af343c4ba5d3cf23db5f4c1798159d3d22520", async() => {
                    WriteLiteral("2");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f3b86f7af343c4ba5d3cf23db5f4c1798159d3d23570", async() => {
                    WriteLiteral("3");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f3b86f7af343c4ba5d3cf23db5f4c1798159d3d24620", async() => {
                    WriteLiteral("4");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f3b86f7af343c4ba5d3cf23db5f4c1798159d3d25670", async() => {
                    WriteLiteral("5");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f3b86f7af343c4ba5d3cf23db5f4c1798159d3d26720", async() => {
                    WriteLiteral("6");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                    </select>\r\n\r\n                                </ul>\r\n\r\n");
#nullable restore
#line 117 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Customer\Views\Home\Details.cshtml"
                                 if (Model.Product.IsStock)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <button type=\"submit\" class=\"btn btn-success \"><i class=\"bi bi-cart4\"></i>Sepete Ekle</button>\r\n");
#nullable restore
#line 120 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Customer\Views\Home\Details.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <label class=\"btn btn-danger form-control\"><i class=\"bi bi-cart4\"></i>Ürün Tükendi</label>\r\n");
#nullable restore
#line 124 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Customer\Views\Home\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </div>
                            <ul class=""product-share"">
                                <h3>Bizi Paylaş</h3>
                                <ul>
                                    <li><a class=""share-face"" href=""#""><span> </span> </a></li>
                                    <li><a class=""share-twitter"" href=""#""><span> </span> </a></li>
                                    <li><a class=""share-google"" href=""#""><span> </span> </a></li>
                                    <li><a class=""share-rss"" href=""#""><span> </span> </a></li>
                                    <div class=""clear""> </div>
                                </ul>
                            </ul>

                        </div>
                    </div>
                </div>
                <div class=""clear""> </div>
            </div>

            <div class=""details-right"">
                <a href=""#"">DAHA FAZLA GÖR</a>
            </div>
            <div class=""clear""> </div>
        <");
                WriteLiteral("/div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!----product-rewies---->\r\n<div class=\"product-reviwes\">\r\n    <div class=\"wrap\">\r\n        <!--vertical Tabs-script-->\r\n        <!---responsive-tabs---->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f3b86f7af343c4ba5d3cf23db5f4c1798159d3d31412", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <script type=""text/javascript"">
            $(document).ready(function () {
                $('#horizontalTab').easyResponsiveTabs({
                    type: 'default', //Types: default, vertical, accordion
                    width: 'auto', //auto or any width like 600px
                    fit: true,   // 100% fit in a container
                    closed: 'accordion', // Start closed if in accordion view
                    activate: function (event) { // Callback function if tab is switched
                        var $tab = $(this);
                        var $info = $('#tabInfo');
                        var $name = $('span', $info);
                        $name.text($tab.text());
                        $info.show();
                    }
                });

                $('#verticalTab').easyResponsiveTabs({
                    type: 'vertical',
                    width: 'auto',
                    fit: true
                });
            });
        </script>");
            WriteLiteral(@"
        <!---//responsive-tabs---->
        <!--//vertical Tabs-script-->
        <!--vertical Tabs-->
        <div id=""verticalTab"">
            <ul class=""resp-tabs-list"">
                <li>Açıklama</li>
                <li>Ürün Etiketleri</li>
                <li>Ürün İncelemleri</li>
            </ul>
            <div class=""resp-tabs-container vertical-tabs"">
                <div>
                    <h3> Detaylar</h3>
                    <p> ");
#nullable restore
#line 190 "C:\Users\user\source\repos\OrnekProje\OrnekProje\Areas\Customer\Views\Home\Details.cshtml"
                   Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n<div class=\"clear\"> </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrnekProje.Models.ShoppingCart> Html { get; private set; }
    }
}
#pragma warning restore 1591
