#pragma checksum "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Filtry\Zakaz4iki.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92fc9a4c1bb331daec48a402917b7a923b793250"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BD_Wholesale_warehouse.Pages.Filtry.Pages_Filtry_Zakaz4iki), @"mvc.1.0.razor-page", @"/Pages/Filtry/Zakaz4iki.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92fc9a4c1bb331daec48a402917b7a923b793250", @"/Pages/Filtry/Zakaz4iki.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8cc65e5c89ada9aae912bc597a4690aac9a7ccb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Filtry_Zakaz4iki : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Заказчики</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 11 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Filtry\Zakaz4iki.cshtml"
           Write(Html.DisplayNameFor(model => model.Customers[0].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Filtry\Zakaz4iki.cshtml"
           Write(Html.DisplayNameFor(model => model.Customers[0].ProductID1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Filtry\Zakaz4iki.cshtml"
           Write(Html.DisplayNameFor(model => model.Customers[0].ProductID2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Filtry\Zakaz4iki.cshtml"
           Write(Html.DisplayNameFor(model => model.Customers[0].ProductID3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Filtry\Zakaz4iki.cshtml"
         foreach (var item in Model.Customers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Filtry\Zakaz4iki.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Filtry\Zakaz4iki.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductID1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Filtry\Zakaz4iki.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductID2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Filtry\Zakaz4iki.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductID3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Filtry\Zakaz4iki.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BD_Wholesale_warehouse.Pages.Filtry.Zakaz4iki> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BD_Wholesale_warehouse.Pages.Filtry.Zakaz4iki> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BD_Wholesale_warehouse.Pages.Filtry.Zakaz4iki>)PageContext?.ViewData;
        public BD_Wholesale_warehouse.Pages.Filtry.Zakaz4iki Model => ViewData.Model;
    }
}
#pragma warning restore 1591
