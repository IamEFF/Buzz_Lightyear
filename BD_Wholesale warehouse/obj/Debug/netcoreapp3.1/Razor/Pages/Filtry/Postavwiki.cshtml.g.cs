#pragma checksum "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Filtry\Postavwiki.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b47e50b4720aed6cff59af6b0d46a234b83849b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BD_Wholesale_warehouse.Pages.Filtry.Pages_Filtry_Postavwiki), @"mvc.1.0.razor-page", @"/Pages/Filtry/Postavwiki.cshtml")]
namespace BD_Wholesale_warehouse.Pages.Filtry
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
#line 1 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\_ViewImports.cshtml"
using BD_Wholesale_warehouse;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b47e50b4720aed6cff59af6b0d46a234b83849b6", @"/Pages/Filtry/Postavwiki.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8cc65e5c89ada9aae912bc597a4690aac9a7ccb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Filtry_Postavwiki : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Поставщики</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Filtry\Postavwiki.cshtml"
           Write(Html.DisplayNameFor(model => model.Suppliers[0].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Filtry\Postavwiki.cshtml"
           Write(Html.DisplayNameFor(model => model.Suppliers[0].ProductID1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Filtry\Postavwiki.cshtml"
           Write(Html.DisplayNameFor(model => model.Suppliers[0].ProductID2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Filtry\Postavwiki.cshtml"
           Write(Html.DisplayNameFor(model => model.Suppliers[0].ProductID3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Filtry\Postavwiki.cshtml"
         foreach (var item in Model.Suppliers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Filtry\Postavwiki.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Filtry\Postavwiki.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductID1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Filtry\Postavwiki.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductID2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Filtry\Postavwiki.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductID3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Filtry\Postavwiki.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BD_Wholesale_warehouse.Pages.Filtry.Postavwiki> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BD_Wholesale_warehouse.Pages.Filtry.Postavwiki> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BD_Wholesale_warehouse.Pages.Filtry.Postavwiki>)PageContext?.ViewData;
        public BD_Wholesale_warehouse.Pages.Filtry.Postavwiki Model => ViewData.Model;
    }
}
#pragma warning restore 1591
