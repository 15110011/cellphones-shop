#pragma checksum "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Phone\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "decdf21bfba5f5a9b109e38117764612d86a1b3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Phone_List), @"mvc.1.0.view", @"/Views/Phone/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Phone/List.cshtml", typeof(AspNetCore.Views_Phone_List))]
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
#line 1 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Phone\List.cshtml"
using MobileStore.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"decdf21bfba5f5a9b109e38117764612d86a1b3f", @"/Views/Phone/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"611d1bded60b8664b1f6553bc5f8184ebd154c0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Phone_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Phone>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(61, 269, true);
            WriteLiteral(@"
    <div>
        <h2>
            All Phones are show here
        </h2>
    </div>
    <div class=""products"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col"">

                    <div class=""product_grid"">
");
            EndContext();
#line 16 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Phone\List.cshtml"
                          
                            foreach (var phone in Model)
                            {

#line default
#line hidden
            BeginContext(447, 122, true);
            WriteLiteral("                                <div class=\"product\">\r\n                                    <div class=\"product_image\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 569, "\"", 590, 1);
#line 20 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Phone\List.cshtml"
WriteAttributeValue("", 575, phone.ImageUrl, 575, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(591, 117, true);
            WriteLiteral(" alt=\"\"></div>\r\n                                    <div class=\"product_extra product_new\"><a href=\"categories.html\">");
            EndContext();
            BeginContext(709, 22, false);
#line 21 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Phone\List.cshtml"
                                                                                                Write(phone.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(731, 169, true);
            WriteLiteral("</a></div>\r\n                                    <div class=\"product_content\">\r\n                                        <div class=\"product_title\"><a href=\"product.html\">");
            EndContext();
            BeginContext(901, 10, false);
#line 23 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Phone\List.cshtml"
                                                                                     Write(phone.Name);

#line default
#line hidden
            EndContext();
            BeginContext(911, 79, true);
            WriteLiteral("</a></div>\r\n                                        <div class=\"product_price\">");
            EndContext();
            BeginContext(991, 25, false);
#line 24 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Phone\List.cshtml"
                                                              Write(phone.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1016, 92, true);
            WriteLiteral("</div>\r\n                                    </div>\r\n                                </div>\r\n");
            EndContext();
#line 27 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Phone\List.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(1166, 104, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
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
