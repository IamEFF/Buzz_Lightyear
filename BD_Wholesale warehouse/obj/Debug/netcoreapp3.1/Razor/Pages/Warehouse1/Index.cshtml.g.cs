#pragma checksum "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84b0c2cbb1d2b24b760f87a1007ca9d4398d4c56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BD_Wholesale_warehouse.Pages.Warehouse1.Pages_Warehouse1_Index), @"mvc.1.0.razor-page", @"/Pages/Warehouse1/Index.cshtml")]
namespace BD_Wholesale_warehouse.Pages.Warehouse1
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84b0c2cbb1d2b24b760f87a1007ca9d4398d4c56", @"/Pages/Warehouse1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8cc65e5c89ada9aae912bc597a4690aac9a7ccb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Warehouse1_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Таблица склада</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84b0c2cbb1d2b24b760f87a1007ca9d4398d4c564455", async() => {
                WriteLiteral("Добавить");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Warehouse[0].Receipt_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Warehouse[0].Order_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Warehouse[0].Departure_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Warehouse[0].Product_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Warehouse[0].Supplier_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Warehouse[0].CustomerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Warehouse[0].Delivery_method));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Warehouse[0].Volume));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Warehouse[0].Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Warehouse[0].Staff_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 50 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
 foreach (var item in Model.Warehouse) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Receipt_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Order_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Departure_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 62 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
                  
                    try
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
                   Write(Model.Product.First(r => r.ID - 1 == item.ProductID).Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
                                                                                  
                    }
                    catch
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p> данных нет </p>\r\n");
#nullable restore
#line 70 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 75 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
                  
                    try
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
                   Write(Model.Suppliers.First(r => r.ID - 1 == item.SupplierID).Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
                                                                                     
                    }
                    catch
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p> данных нет </p>\r\n");
#nullable restore
#line 83 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 88 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
                  
                    try
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
                   Write(Model.Customers.First(r => r.ID - 1 == item.CustomerID).Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
                                                                                     
                    }
                    catch
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p> данных нет </p>\r\n");
#nullable restore
#line 96 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 101 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Delivery_method));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 104 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Volume));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 107 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 110 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
                  
                    try
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
                   Write(Model.Staff.First(r => r.ID - 3 == item.StaffID).Full_name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
                                                                                   
                    }
                    catch
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p> данных нет </p>\r\n");
#nullable restore
#line 118 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84b0c2cbb1d2b24b760f87a1007ca9d4398d4c5616172", async() => {
                WriteLiteral("Редактировать");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 123 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
                                       WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84b0c2cbb1d2b24b760f87a1007ca9d4398d4c5618351", async() => {
                WriteLiteral("Подробности");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 124 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
                                          WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84b0c2cbb1d2b24b760f87a1007ca9d4398d4c5620531", async() => {
                WriteLiteral("Удалить");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 125 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
                                         WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 128 "C:\Users\Андрей\source\repos\BD\BD_Wholesale warehouse\Pages\Warehouse1\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BD_Wholesale_warehouse.Pages.Warehouse1.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BD_Wholesale_warehouse.Pages.Warehouse1.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BD_Wholesale_warehouse.Pages.Warehouse1.IndexModel>)PageContext?.ViewData;
        public BD_Wholesale_warehouse.Pages.Warehouse1.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591