#pragma checksum "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "874e10721a0c93294bb322d0cdfe43e3c704d1d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShoppingCart/Index.cshtml", typeof(AspNetCore.Views_ShoppingCart_Index))]
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
#line 1 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\_ViewImports.cshtml"
using MobileStore.Data.Models;

#line default
#line hidden
#line 2 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\_ViewImports.cshtml"
using MobileStore.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"874e10721a0c93294bb322d0cdfe43e3c704d1d4", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"902549fe59b03c0028cd5b1c653277144bffd696", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/style/cart.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/style/cart_responsive.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("coupon_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("coupon_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/cart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 14, true);
            WriteLiteral("﻿<!--Cart-->\r\n");
            EndContext();
            BeginContext(44, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5f51df09132e4b65b671f81e36dce466", async() => {
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
            EndContext();
            BeginContext(93, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(95, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "58478407fc464961a9800878988865f9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(155, 1716, true);
            WriteLiteral(@"

<div class=""super_container"">

    <!-- Home -->

    <div class=""home"">
        <div class=""home_container"">
            <div class=""home_background"" style=""background-image:url(../images/cart.jpg)""></div>
            <div class=""home_content_container"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col"">
                            <div class=""home_content"">
                                <div class=""breadcrumbs"">
                                    <ul>
                                        <li><a href=""index.html"">Home</a></li>
                                        <li><a href=""categories.html"">Categories</a></li>
                                        <li>Shopping Cart</li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
  ");
            WriteLiteral(@"  </div>

    <!-- Cart Info -->

    <div class=""cart_info"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col"">
                    <!-- Column Titles -->
                    <div class=""cart_info_columns clearfix"">
                        <div class=""cart_info_col cart_info_col_product"">Product</div>
                        <div class=""cart_info_col cart_info_col_price"">Price</div>
                        <div class=""cart_info_col cart_info_col_quantity"">Quantity</div>
                        <div class=""cart_info_col cart_info_col_total"">Total</div>
                    </div>
                </div>
            </div>

");
            EndContext();
#line 49 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\ShoppingCart\Index.cshtml"
             foreach (var line in Model.ShoppingCart.ShoppingCartItems)
            {

#line default
#line hidden
            BeginContext(1959, 546, true);
            WriteLiteral(@"                <div class=""row cart_items_row"">
                    <div class=""col"">

                        <!-- Cart Item -->
                        <div class=""cart_item d-flex flex-lg-row flex-column align-items-lg-center align-items-start justify-content-start"">
                            <!-- Name -->
                            <div class=""cart_item_product d-flex flex-row align-items-center justify-content-start"">
                                <div class=""cart_item_image"">
                                    <div><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2505, "\"", 2531, 1);
#line 59 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 2511, line.Phone.ImageUrl, 2511, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2532, 204, true);
            WriteLiteral(" alt=\"\"></div>\r\n                                </div>\r\n                                <div class=\"cart_item_name_container\">\r\n                                    <div class=\"cart_item_name\"><a href=\"#\">");
            EndContext();
            BeginContext(2737, 15, false);
#line 62 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\ShoppingCart\Index.cshtml"
                                                                       Write(line.Phone.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2752, 289, true);
            WriteLiteral(@"</a></div>
                                    <div class=""cart_item_edit""><a href=""#"">Edit Product</a></div>
                                </div>
                            </div>
                            <!-- Price -->
                            <div class=""cart_item_price"">");
            EndContext();
            BeginContext(3042, 30, false);
#line 67 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\ShoppingCart\Index.cshtml"
                                                    Write(line.Phone.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(3072, 421, true);
            WriteLiteral(@"</div>
                            <!-- Quantity -->
                            <div class=""cart_item_quantity"">
                                <div class=""product_quantity_container"">
                                    <div class=""product_quantity clearfix"">
                                        <span>Qty</span>
                                        <input id=""quantity_input"" type=""text"" pattern=""[0-9]*""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3493, "\"", 3513, 1);
#line 73 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 3501, line.Amount, 3501, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3514, 717, true);
            WriteLiteral(@">
                                        <div class=""quantity_buttons"">
                                            <div id=""quantity_inc_button"" class=""quantity_inc quantity_control""><i class=""fa fa-chevron-up"" aria-hidden=""true""></i></div>
                                            <div id=""quantity_dec_button"" class=""quantity_dec quantity_control""><i class=""fa fa-chevron-down"" aria-hidden=""true""></i></div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                           
                            <!-- Total -->
                            <div class=""cart_item_total"">");
            EndContext();
            BeginContext(4232, 30, false);
#line 83 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\ShoppingCart\Index.cshtml"
                                                    Write(line.Phone.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(4262, 94, true);
            WriteLiteral("</div>\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 88 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\ShoppingCart\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(4371, 2570, true);
            WriteLiteral(@"            <div class=""row row_cart_buttons"">
                <div class=""col"">
                    <div class=""cart_buttons d-flex flex-lg-row flex-column align-items-start justify-content-start"">
                        <div class=""button continue_shopping_button""><a href=""#"">Continue shopping</a></div>
                        <div class=""cart_buttons_right ml-lg-auto"">
                            <div class=""button clear_cart_button""><a href=""#"">Clear cart</a></div>
                            <div class=""button update_cart_button""><a href=""#"">Update cart</a></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row row_extra"">
                <div class=""col-lg-4"">

                    <!-- Delivery -->
                    <div class=""delivery"">
                        <div class=""section_title"">Shipping method</div>
                        <div class=""section_subtitle"">Select the one you want</div>
            ");
            WriteLiteral(@"            <div class=""delivery_options"">
                            <label class=""delivery_option clearfix"">
                                Next day delivery
                                <input type=""radio"" name=""radio"">
                                <span class=""checkmark""></span>
                                <span class=""delivery_price"">$4.99</span>
                            </label>
                            <label class=""delivery_option clearfix"">
                                Standard delivery
                                <input type=""radio"" name=""radio"">
                                <span class=""checkmark""></span>
                                <span class=""delivery_price"">$1.99</span>
                            </label>
                            <label class=""delivery_option clearfix"">
                                Personal pickup
                                <input type=""radio"" checked=""checked"" name=""radio"">
                                <span class=");
            WriteLiteral(@"""checkmark""></span>
                                <span class=""delivery_price"">Free</span>
                            </label>
                        </div>
                    </div>

                    <!-- Coupon Code -->
                    <div class=""coupon"">
                        <div class=""section_title"">Coupon code</div>
                        <div class=""section_subtitle"">Enter your coupon code</div>
                        <div class=""coupon_form_container"">
                            ");
            EndContext();
            BeginContext(6941, 283, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85321e65dcd34f18abc368ea9b4e4936", async() => {
                BeginContext(6995, 222, true);
                WriteLiteral("\r\n                                <input type=\"text\" class=\"coupon_input\" required=\"required\">\r\n                                <button class=\"button coupon_button\"><span>Apply</span></button>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7224, 680, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>

                <div class=""col-lg-6 offset-lg-2"">
                    <div class=""cart_total"">
                        <div class=""section_title"">Cart total</div>
                        <div class=""section_subtitle"">Final info</div>
                        <div class=""cart_total_container"">
                            <ul>
                                <li class=""d-flex flex-row align-items-center justify-content-start"">
                                    <div class=""cart_total_title"">Subtotal</div>
                                    <div class=""cart_total_value ml-auto"">");
            EndContext();
            BeginContext(7905, 37, false);
#line 150 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\ShoppingCart\Index.cshtml"
                                                                     Write(Model.ShoppingCartTotal.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(7942, 580, true);
            WriteLiteral(@"<div>
</li>
                                <li class=""d-flex flex-row align-items-center justify-content-start"">
                                    <div class=""cart_total_title"">Shipping</div>
                                    <div class=""cart_total_value ml-auto"">Free</div>
                                </li>
                                <li class=""d-flex flex-row align-items-center justify-content-start"">
                                    <div class=""cart_total_title"">Total</div>
                                    <div class=""cart_total_value ml-auto"">");
            EndContext();
            BeginContext(8523, 37, false);
#line 158 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\ShoppingCart\Index.cshtml"
                                                                     Write(Model.ShoppingCartTotal.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(8560, 338, true);
            WriteLiteral(@"</div>
                                </li>
                            </ul>
                        </div>
                        <div class=""button checkout_button""><a href=""#"">Proceed to checkout</a></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!--Cart-->
");
            EndContext();
            BeginContext(8898, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1ee2c5775e5458f8dba6781aa0e1dac", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8934, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591