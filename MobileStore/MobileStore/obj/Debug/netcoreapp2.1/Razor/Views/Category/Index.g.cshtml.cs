#pragma checksum "C:\Users\Twisted\Desktop\MobileStore\MobileStore\MobileStore\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edbe354db73264b5a6a79a5cc724d568462e8714"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/Index.cshtml", typeof(AspNetCore.Views_Category_Index))]
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
#line 1 "C:\Users\Twisted\Desktop\MobileStore\MobileStore\MobileStore\Views\_ViewImports.cshtml"
using MobileStore.Data.Models;

#line default
#line hidden
#line 2 "C:\Users\Twisted\Desktop\MobileStore\MobileStore\MobileStore\Views\_ViewImports.cshtml"
using MobileStore.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edbe354db73264b5a6a79a5cc724d568462e8714", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"902549fe59b03c0028cd5b1c653277144bffd696", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/style/categories.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/style/categories_responsive.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("newsletter_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("newsletter_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 23, true);
            WriteLiteral("    <!--Categories-->\r\n");
            EndContext();
            BeginContext(23, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8ef05e90fb104f029d3c8123038d18ba", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            BeginContext(92, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(94, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "616fd915aceb47bc8c7f9151ce0dd585", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(174, 12729, true);
            WriteLiteral(@"

<div class=""super_container"">

    <!-- Home -->

    <div class=""home"">
        <div class=""home_container"">
            <div class=""home_background"" style=""background-image:url(../images/categories.jpg)""></div>
            <div class=""home_content_container"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col"">
                            <div class=""home_content"">
                                <div class=""home_title"">Smart Phones<span>.</span></div>
                                <div class=""home_text""><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam a ultricies metus. Sed nec molestie eros. Sed viverra velit venenatis fermentum luctus.</p></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Products -->

    <div class=""products"">
        <div class=""container"">
    ");
            WriteLiteral(@"        <div class=""row"">
                <div class=""col"">

                    <!-- Product Sorting -->
                    <h3 class=""text-secondary"">Apple</h3>
                    <div class=""sorting_bar d-flex flex-md-row flex-column align-items-md-center justify-content-md-start"">
                        <div class=""results"">Showing <span>12</span> results</div>
                        <div class=""sorting_container ml-md-auto"">
                            <div class=""sorting"">
                                <ul class=""item_sorting"">
                                    <li>
                                        <span class=""sorting_text"">Sort by</span>
                                        <i class=""fa fa-chevron-down"" aria-hidden=""true""></i>
                                        <ul>
                                            <li class=""product_sorting_btn"" data-isotope-option='{ ""sortBy"": ""original-order"" }'><span>Default</span></li>
                                            <l");
            WriteLiteral(@"i class=""product_sorting_btn"" data-isotope-option='{ ""sortBy"": ""price"" }'><span>Price</span></li>
                                            <li class=""product_sorting_btn"" data-isotope-option='{ ""sortBy"": ""stars"" }'><span>Name</span></li>
                                        </ul>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col"">

                    <div class=""product_grid"">

                        <!-- Product -->
                        <div class=""product"">
                            <div class=""product_image""><img src=""../images/product_1.jpg"" alt=""""></div>
                            <div class=""product_extra product_new""><a href=""categories.html"">New</a></div>
                            <div class=""product_content"">
                                <");
            WriteLiteral(@"div class=""product_title""><a href=""product.html"">Smart Phone</a></div>
                                <div class=""product_price"">$670</div>
                            </div>
                        </div>

                        <!-- Product -->
                        <div class=""product"">
                            <div class=""product_image""><img src=""../images/product_2.jpg"" alt=""""></div>
                            <div class=""product_extra product_sale""><a href=""categories.html"">Sale</a></div>
                            <div class=""product_content"">
                                <div class=""product_title""><a href=""product.html"">Smart Phone</a></div>
                                <div class=""product_price"">$520</div>
                            </div>
                        </div>

                        <!-- Product -->
                        <div class=""product"">
                            <div class=""product_image""><img src=""../images/product_3.jpg"" alt=""""></div>
        ");
            WriteLiteral(@"                    <div class=""product_content"">
                                <div class=""product_title""><a href=""product.html"">Smart Phone</a></div>
                                <div class=""product_price"">$710</div>
                            </div>
                        </div>

                        <!-- Product -->
                        <div class=""product"">
                            <div class=""product_image""><img src=""../images/product_4.jpg"" alt=""""></div>
                            <div class=""product_content"">
                                <div class=""product_title""><a href=""product.html"">Smart Phone</a></div>
                                <div class=""product_price"">$330</div>
                            </div>
                        </div>

                        <!-- Product -->
                        <div class=""product"">
                            <div class=""product_image""><img src=""../images/product_5.jpg"" alt=""""></div>
                            <div c");
            WriteLiteral(@"lass=""product_content"">
                                <div class=""product_title""><a href=""product.html"">Smart Phone</a></div>
                                <div class=""product_price"">$170</div>
                            </div>
                        </div>

                        <!-- Product -->
                        <div class=""product"">
                            <div class=""product_image""><img src=""../images/product_6.jpg"" alt=""""></div>
                            <div class=""product_extra product_hot""><a href=""categories.html"">Hot</a></div>
                            <div class=""product_content"">
                                <div class=""product_title""><a href=""product.html"">Smart Phone</a></div>
                                <div class=""product_price"">$240</div>
                            </div>
                        </div>

                        <!-- Product -->
                        <div class=""product"">
                            <div class=""product_image""><i");
            WriteLiteral(@"mg src=""../images/product_7.jpg"" alt=""""></div>
                            <div class=""product_content"">
                                <div class=""product_title""><a href=""product.html"">Smart Phone</a></div>
                                <div class=""product_price"">$70</div>
                            </div>
                        </div>

                        <!-- Product -->
                        <div class=""product"">
                            <div class=""product_image""><img src=""../images/product_8.jpg"" alt=""""></div>
                            <div class=""product_extra product_sale""><a href=""categories.html"">Hot</a></div>
                            <div class=""product_content"">
                                <div class=""product_title""><a href=""product.html"">Smart Phone</a></div>
                                <div class=""product_price"">$490</div>
                            </div>
                        </div>

                        <!-- Product -->
                      ");
            WriteLiteral(@"  <div class=""product"">
                            <div class=""product_image""><img src=""../images/product_9.jpg"" alt=""""></div>
                            <div class=""product_extra product_sale""><a href=""categories.html"">Hot</a></div>
                            <div class=""product_content"">
                                <div class=""product_title""><a href=""product.html"">Smart Phone</a></div>
                                <div class=""product_price"">$410</div>
                            </div>
                        </div>

                        <!-- Product -->
                        <div class=""product"">
                            <div class=""product_image""><img src=""images/product_10.jpg"" alt=""""></div>
                            <div class=""product_extra product_sale""><a href=""categories.html"">Hot</a></div>
                            <div class=""product_content"">
                                <div class=""product_title""><a href=""product.html"">Smart Phone</a></div>
               ");
            WriteLiteral(@"                 <div class=""product_price"">$365</div>
                            </div>
                        </div>

                        <!-- Product -->
                        <div class=""product"">
                            <div class=""product_image""><img src=""../images/product_11.jpg"" alt=""""></div>
                            <div class=""product_extra product_sale""><a href=""categories.html"">Hot</a></div>
                            <div class=""product_content"">
                                <div class=""product_title""><a href=""product.html"">Smart Phone</a></div>
                                <div class=""product_price"">$195</div>
                            </div>
                        </div>

                        <!-- Product -->
                        <div class=""product"">
                            <div class=""product_image""><img src=""../images/product_12.jpg"" alt=""""></div>
                            <div class=""product_extra product_sale""><a href=""categories.html"">");
            WriteLiteral(@"Hot</a></div>
                            <div class=""product_content"">
                                <div class=""product_title""><a href=""product.html"">Smart Phone</a></div>
                                <div class=""product_price"">$580</div>
                            </div>
                        </div>

                    </div>
                    <div class=""product_pagination"">
                        <ul>
                            <li class=""active""><a href=""#"">01.</a></li>
                            <li><a href=""#"">02.</a></li>
                            <li><a href=""#"">03.</a></li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""text-center"">
            </div>
        </div>
    </div>

    <!-- Icon Boxes -->

    <div class=""icon_boxes"">
        <div class=""container"">
            <div class=""row icon_box_row"">

                <!-- Icon Box -->
                <div class=""col-lg-4 ico");
            WriteLiteral(@"n_box_col"">
                    <div class=""icon_box"">
                        <div class=""icon_box_image""><img src=""../images/icon_1.svg"" alt=""""></div>
                        <div class=""icon_box_title"">Free Shipping Worldwide</div>
                        <div class=""icon_box_text"">
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam a ultricies metus. Sed nec molestie.</p>
                        </div>
                    </div>
                </div>

                <!-- Icon Box -->
                <div class=""col-lg-4 icon_box_col"">
                    <div class=""icon_box"">
                        <div class=""icon_box_image""><img src=""../images/icon_2.svg"" alt=""""></div>
                        <div class=""icon_box_title"">Free Returns</div>
                        <div class=""icon_box_text"">
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam a ultricies metus. Sed nec molestie.</p>
                ");
            WriteLiteral(@"        </div>
                    </div>
                </div>

                <!-- Icon Box -->
                <div class=""col-lg-4 icon_box_col"">
                    <div class=""icon_box"">
                        <div class=""icon_box_image""><img src=""../images/icon_3.svg"" alt=""""></div>
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
                </div>
            </div>
            <div class=""row"">
                <div class=""col");
            WriteLiteral(@"-lg-8 offset-lg-2"">
                    <div class=""newsletter_content text-center"">
                        <div class=""newsletter_title"">Subscribe to our newsletter</div>
                        <div class=""newsletter_text""><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam a ultricies metus. Sed nec molestie eros</p></div>
                        <div class=""newsletter_form_container"">
                            ");
            EndContext();
            BeginContext(12903, 307, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6acbfb557b55439ba5d1ba1dfa5021ca", async() => {
                BeginContext(12965, 238, true);
                WriteLiteral("\r\n                                <input type=\"email\" class=\"newsletter_input\" required=\"required\">\r\n                                <button class=\"newsletter_button trans_200\"><span>Subscribe</span></button>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(13210, 142, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
