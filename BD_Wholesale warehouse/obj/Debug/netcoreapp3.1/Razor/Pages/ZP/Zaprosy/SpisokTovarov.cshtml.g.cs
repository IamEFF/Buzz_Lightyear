#pragma checksum "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\ZP\Zaprosy\SpisokTovarov.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aef8849133b88acdf3b135b344c2a5441f8a5ffb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BD_Wholesale_warehouse.Pages.ZP.Zaprosy.Pages_ZP_Zaprosy_SpisokTovarov), @"mvc.1.0.razor-page", @"/Pages/ZP/Zaprosy/SpisokTovarov.cshtml")]
namespace BD_Wholesale_warehouse.Pages.ZP.Zaprosy
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aef8849133b88acdf3b135b344c2a5441f8a5ffb", @"/Pages/ZP/Zaprosy/SpisokTovarov.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8cc65e5c89ada9aae912bc597a4690aac9a7ccb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ZP_Zaprosy_SpisokTovarov : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <h1>Товары</h1>\r\n");
            WriteLiteral("    <p>\r\n    </p>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 13 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\ZP\Zaprosy\SpisokTovarov.cshtml"
               Write(Html.DisplayNameFor(model => model.Product[0].Product_type_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 17 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\ZP\Zaprosy\SpisokTovarov.cshtml"
               Write(Html.DisplayNameFor(model => model.Product[0].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\ZP\Zaprosy\SpisokTovarov.cshtml"
             foreach (var item in Model.Product)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n");
#nullable restore
#line 28 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\ZP\Zaprosy\SpisokTovarov.cshtml"
                      
                        try
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\ZP\Zaprosy\SpisokTovarov.cshtml"
                       Write(Model.Product_type.First(r => r.ID == item.Product_typeID).Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\ZP\Zaprosy\SpisokTovarov.cshtml"
                                                                                            
                        }
                        catch
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p> данных нет </p>\r\n");
#nullable restore
#line 36 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\ZP\Zaprosy\SpisokTovarov.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\ZP\Zaprosy\SpisokTovarov.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 45 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\ZP\Zaprosy\SpisokTovarov.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BD_Wholesale_warehouse.Pages.ZP.Zaprosy.SpisokTovarov> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BD_Wholesale_warehouse.Pages.ZP.Zaprosy.SpisokTovarov> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BD_Wholesale_warehouse.Pages.ZP.Zaprosy.SpisokTovarov>)PageContext?.ViewData;
        public BD_Wholesale_warehouse.Pages.ZP.Zaprosy.SpisokTovarov Model => ViewData.Model;
    }
}
#pragma warning restore 1591
