#pragma checksum "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Shared\PhonesSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dc093bfffd5656792d30e0d9bee4da2c5992097"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PhonesSummary), @"mvc.1.0.view", @"/Views/Shared/PhonesSummary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/PhonesSummary.cshtml", typeof(AspNetCore.Views_Shared_PhonesSummary))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dc093bfffd5656792d30e0d9bee4da2c5992097", @"/Views/Shared/PhonesSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"902549fe59b03c0028cd5b1c653277144bffd696", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PhonesSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Phone>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 60, true);
            WriteLiteral("\r\n<div class=\"product\">\r\n    <div class=\"product_image\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 75, "\"", 96, 1);
#line 4 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Shared\PhonesSummary.cshtml"
WriteAttributeValue("", 81, Model.ImageUrl, 81, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(97, 85, true);
            WriteLiteral(" alt=\"\"></div>\r\n    <div class=\"product_extra product_new\"><a href=\"categories.html\">");
            EndContext();
            BeginContext(183, 22, false);
#line 5 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Shared\PhonesSummary.cshtml"
                                                                Write(Model.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(205, 105, true);
            WriteLiteral("</a></div>\r\n    <div class=\"product_content\">\r\n        <div class=\"product_title\"><a href=\"product.html\">");
            EndContext();
            BeginContext(311, 10, false);
#line 7 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Shared\PhonesSummary.cshtml"
                                                     Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(321, 47, true);
            WriteLiteral("</a></div>\r\n        <div class=\"product_price\">");
            EndContext();
            BeginContext(369, 25, false);
#line 8 "C:\Users\User\Documents\GitHub\cellphones-shop\MobileStore\MobileStore\Views\Shared\PhonesSummary.cshtml"
                              Write(Model.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(394, 26, true);
            WriteLiteral("</div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Phone> Html { get; private set; }
    }
}
#pragma warning restore 1591
