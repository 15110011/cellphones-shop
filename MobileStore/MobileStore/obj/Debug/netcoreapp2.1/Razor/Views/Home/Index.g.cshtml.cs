#pragma checksum "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e9a07d7927b4b291d47b4f08f4d5c2fc06e8d46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
using MobileStore;

#line default
#line hidden
#line 2 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\_ViewImports.cshtml"
using MobileStore.Models;

#line default
#line hidden
#line 4 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Home\Index.cshtml"
using MobileStore.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e9a07d7927b4b291d47b4f08f4d5c2fc06e8d46", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"611d1bded60b8664b1f6553bc5f8184ebd154c0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Phone>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("newsletter_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("newsletter_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(107, 8122, true);
            WriteLiteral(@"
<div class=""super_container"">

    <!-- Home -->

    <div class=""home"">
        <div class=""home_slider_container"">

            <!-- Home Slider -->
            <div class=""owl-carousel owl-theme home_slider"">

                <!-- Slider Item -->
                <div class=""owl-item home_slider_item"">
                    <div class=""home_slider_background"" style=""background-image:url(/images/slider1.jpg)""></div>
                    <div class=""home_slider_content_container"">
                        <div class=""container"">
                            <div class=""row"">
                                <div class=""col"">
                                    <div class=""home_slider_content"" data-animation-in=""fadeIn"" data-animation-out=""animate-out fadeOut"">
                                        <div class=""home_slider_title""style=""color:#33304d;"">The real smart phone world!</div>
                                        <div class=""home_slider_subtitle"" style=""color:#33304d;"">
            ");
            WriteLiteral(@"                                Come and get it now.
                                        </div>
                                        <div class=""button button_light home_button"" style=""color:#33304d;""><a href=""#"">Shop Now</a></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <!-- Slider Item -->
                <div class=""owl-item home_slider_item"">
                    <div class=""home_slider_background"" style=""background-image:url(/images/slider2.jpeg)""></div>
                    <div class=""home_slider_content_container"">
                        <div class=""container"">
                            <div class=""row"">
                                <div class=""col"">
                                    <div class=""home_slider_content"" data-animation-in=""fadeIn"" data-animation-out=""animate-out fadeOut"">
               ");
            WriteLiteral(@"                         <div class=""home_slider_title"">Brilliant. In every way</div>
                                        <div class=""home_slider_subtitle"">
                                            Hello world!
                                        </div>
                                        <div class=""button button_light home_button""><a href=""#"">Shop Now</a></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <!-- Slider Item -->
                <div class=""owl-item home_slider_item"">
                    <div class=""home_slider_background"" style=""background-image:url(/images/slider3.jpg)""></div>
                    <div class=""home_slider_content_container"">
                        <div class=""container"">
                            <div class=""row"">
                                <div class=""col"">
           ");
            WriteLiteral(@"                         <div class=""home_slider_content"" data-animation-in=""fadeIn"" data-animation-out=""animate-out fadeOut"">
                                        <div class=""home_slider_title"" style=""color:#33304d;"">So smart and comfort</div>
                                        <div class=""home_slider_subtitle"" style=""color:#33304d;"">
                                            Come and get it now.
                                        </div>
                                        <div class=""button button_light home_button"" style=""color:#33304d;""><a href=""#"">Shop Now</a></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Slider Item -->
                <div class=""owl-item home_slider_item"">
                    <div class=""home_slider_background"" style=""background-image:url(/images/slider4.jpg)""></div>
        ");
            WriteLiteral(@"            <div class=""home_slider_content_container"">
                        <div class=""container"">
                            <div class=""row"">
                                <div class=""col"">
                                    <div class=""home_slider_content"" data-animation-in=""fadeIn"" data-animation-out=""animate-out fadeOut"">
                                        <div class=""home_slider_title"" style=""color:#33304d;"">Profestional</div>
                                        <div class=""home_slider_subtitle"" style=""color:#33304d;"">
                                            Technology in your hand!
                                        </div>
                                        <div class=""button button_light home_button"" style=""color:#33304d;""><a href=""#"">Shop Now</a></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

    ");
            WriteLiteral(@"        </div>

            <!-- Home Slider Dots -->

            <div class=""home_slider_dots_container"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col"">
                            <div class=""home_slider_dots"">
                                <ul id=""home_slider_custom_dots"" class=""home_slider_custom_dots"">
                                    <li class=""home_slider_custom_dot active"">01.</li>
                                    <li class=""home_slider_custom_dot"">02.</li>
                                    <li class=""home_slider_custom_dot"">03.</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <!-- Ads -->

    <div class=""avds"">
        <div class=""avds_container d-flex flex-lg-row flex-column align-items-start justify-content-between"">
            <");
            WriteLiteral(@"div class=""avds_small"">
                <div class=""avds_background"" style=""background-image:url(/images/iphone-banner.jpeg)""></div>
                <div class=""avds_small_inner"">
                    <div class=""avds_discount_container"">
                        <img src=""images/discount.png"" alt="""">
                        <div>
                            <div class=""avds_discount"">
                                <div>20<span>%</span></div>
                                <div>Discount</div>
                            </div>
                        </div>
                    </div>
                    <div class=""avds_small_content"">
                        <div class=""avds_title"">Smart Phones</div>
                        <div class=""avds_link""><a href=""categories.html"">See More</a></div>
                    </div>
                </div>
            </div>
            <div class=""avds_large"">
                <div class=""avds_background"" style=""background-image:url(/images/iphone-camera.");
            WriteLiteral(@"jpg)""></div>
                <div class=""avds_large_container"">
                    <div class=""avds_large_content"">
                        <div class=""avds_title"">Professional Cameras</div>
                        <div class=""avds_text"">
                            <p style=""color: white;"">- Dual 12MP rear cameras</p>
                            <p style=""color: white;"">- 4K video</p>
                            <small>up to 60 fps</small>
                        </div>
                        <div class=""avds_link avds_link_large""><a href=""categories.html"">See More</a></div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Products -->

    <div class=""products"">
        <div class=""container"">
            <hr />
            <h3>New Products</h3>
            <div class=""row"">
                <div class=""col"">
                    <div class=""product_grid"">

");
            EndContext();
#line 168 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Home\Index.cshtml"
                          
                            foreach (var phone in Model)
                            {
                                if (phone.ShortDescription == "New")
                                {

#line default
#line hidden
            BeginContext(8451, 184, true);
            WriteLiteral("                                    <!-- Product -->\r\n                                    <div class=\"product\">\r\n                                        <div class=\"product_image\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 8635, "\"", 8656, 1);
#line 175 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 8641, phone.ImageUrl, 8641, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8657, 301, true);
            WriteLiteral(@" alt=""""></div>
                                        <div class=""product_extra product_new""><a href=""categories.html"">New</a></div>
                                        <div class=""product_content"">
                                            <div class=""product_title""><a href=""product.html"">");
            EndContext();
            BeginContext(8959, 10, false);
#line 178 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Home\Index.cshtml"
                                                                                         Write(phone.Name);

#line default
#line hidden
            EndContext();
            BeginContext(8969, 83, true);
            WriteLiteral("</a></div>\r\n                                            <div class=\"product_price\">");
            EndContext();
            BeginContext(9053, 25, false);
#line 179 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Home\Index.cshtml"
                                                                  Write(phone.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(9078, 100, true);
            WriteLiteral("</div>\r\n                                        </div>\r\n                                    </div>\r\n");
            EndContext();
#line 182 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Home\Index.cshtml"
                                }
                            }
                        

#line default
#line hidden
            BeginContext(9271, 244, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <hr />\r\n            <h3>Sale Products</h3>\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <div class=\"product_grid\">\r\n");
            EndContext();
#line 194 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Home\Index.cshtml"
                          
                            foreach (var phone in Model)
                            {

#line default
#line hidden
            BeginContext(9632, 172, true);
            WriteLiteral("                                <!-- Product -->\r\n                                <div class=\"product\">\r\n                                    <div class=\"product_image\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 9804, "\"", 9825, 1);
#line 199 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 9810, phone.ImageUrl, 9810, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9826, 291, true);
            WriteLiteral(@" alt=""""></div>
                                    <div class=""product_extra product_sale""><a href=""categories.html"">Sale</a></div>
                                    <div class=""product_content"">
                                        <div class=""product_title""><a href=""product.html"">");
            EndContext();
            BeginContext(10118, 10, false);
#line 202 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Home\Index.cshtml"
                                                                                     Write(phone.Name);

#line default
#line hidden
            EndContext();
            BeginContext(10128, 79, true);
            WriteLiteral("</a></div>\r\n                                        <div class=\"product_price\">");
            EndContext();
            BeginContext(10208, 25, false);
#line 203 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Home\Index.cshtml"
                                                              Write(phone.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(10233, 92, true);
            WriteLiteral("</div>\r\n                                    </div>\r\n                                </div>\r\n");
            EndContext();
#line 206 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Home\Index.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(10383, 3600, true);
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Ad -->

    <div class=""avds_xl"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col"">
                    <div class=""avds_xl_container clearfix"">
                        <div class=""avds_xl_background"" style=""background-image:url(/images/banner5.jpeg)""></div>
                        <div class=""avds_xl_content"">
                            <div class=""avds_title"">Amazing Devices</div>
                            <div class=""avds_text"">Come with us. Let's we bring to you the best things.</div>
                            <div class=""avds_link avds_xl_link""><a href=""categories.html"">See More</a></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Icon Boxes -->

    <div class=""icon_boxes"">
        <div class=""container"">
            <div class=""r");
            WriteLiteral(@"ow icon_box_row"">

                <!-- Icon Box -->
                <div class=""col-lg-4 icon_box_col"">
                    <div class=""icon_box"">
                        <div class=""icon_box_image""><img src=""images/icon_1.svg"" alt=""""></div>
                        <div class=""icon_box_title"">Free Shipping Worldwide</div>
                        <div class=""icon_box_text"">
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam a ultricies metus. Sed nec molestie.</p>
                        </div>
                    </div>
                </div>

                <!-- Icon Box -->
                <div class=""col-lg-4 icon_box_col"">
                    <div class=""icon_box"">
                        <div class=""icon_box_image""><img src=""images/icon_2.svg"" alt=""""></div>
                        <div class=""icon_box_title"">Free Returns</div>
                        <div class=""icon_box_text"">
                            <p>Lorem ipsum dolor sit amet, cons");
            WriteLiteral(@"ectetur adipiscing elit. Nullam a ultricies metus. Sed nec molestie.</p>
                        </div>
                    </div>
                </div>

                <!-- Icon Box -->
                <div class=""col-lg-4 icon_box_col"">
                    <div class=""icon_box"">
                        <div class=""icon_box_image""><img src=""images/icon_3.svg"" alt=""""></div>
                        <div class=""icon_box_title"">24h Fast Support</div>
                        <div class=""icon_box_text"">
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam a ultricies metus. Sed nec molestie.</p>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>

    <!-- Newsletter -->

    <div class=""newsletter"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col"">
                    <div class=""newsletter_border""></div>
                </d");
            WriteLiteral(@"iv>
            </div>
            <div class=""row"">
                <div class=""col-lg-8 offset-lg-2"">
                    <div class=""newsletter_content text-center"">
                        <div class=""newsletter_title"">Subscribe to our newsletter</div>
                        <div class=""newsletter_text""><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam a ultricies metus. Sed nec molestie eros</p></div>
                        <div class=""newsletter_form_container"">
                            ");
            EndContext();
            BeginContext(13983, 307, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d09cdb6482fb410a88782ccd98396348", async() => {
                BeginContext(14045, 238, true);
                WriteLiteral("\r\n                                <input type=\"email\" class=\"newsletter_input\" required=\"required\">\r\n                                <button class=\"newsletter_button trans_200\"><span>Subscribe</span></button>\r\n                            ");
                EndContext();
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
            EndContext();
            BeginContext(14290, 140, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Phone>> Html { get; private set; }
    }
}
#pragma warning restore 1591
