#pragma checksum "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\CatagoryProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71e37bb76313f73b7178cb495d0a14f38040ce9a"
// <auto-generated/>
#pragma warning disable 1591
namespace Estore.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Estore.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Estore.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\CatagoryProduct.razor"
using Estore.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\CatagoryProduct.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\CatagoryProduct.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\CatagoryProduct.razor"
using Estore.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\CatagoryProduct.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/catagoryproduct/{Catagoryproduct}")]
    public partial class CatagoryProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section class=""hero-slider""><div class=""single-slider""><div class=""container""><div class=""row no-gutters""><div class=""col-lg-9 offset-lg-3 col-12""><div class=""text-inner""><div class=""row""><div class=""col-lg-7 col-12""><div class=""hero-text""><h1><span>Welcome To   </span>Estore</h1>
                                    <p>Pakistan's best online shopping store with 1+ million  <br>  products at resounding discounts  with cash on delivery (COD).</p>
                                    <div class=""button""><a href=""/shopview"" class=""btn"">Shop Now!</a></div></div></div></div></div></div></div></div></div></section>
");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-lg-12 col-md-12 col-12");
            __builder.OpenElement(3, "h2");
            __builder.AddContent(4, 
#nullable restore
#line 35 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\CatagoryProduct.razor"
         Catagory.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
#nullable restore
#line 39 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\CatagoryProduct.razor"
         if (ProductList == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<p>No Product is Found</p>");
#nullable restore
#line 42 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\CatagoryProduct.razor"
        }
        else
        {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\CatagoryProduct.razor"
         foreach (Product SingleProduct in ProductList)
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\CatagoryProduct.razor"
             if (@getcatagoryarray(SingleProduct.CatagoryID).Contains(Catagoryproduct))
            {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-lg-3 col-md-4 col-12");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "single-product");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "product-img");
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "href", "product-details.html");
            __builder.OpenElement(17, "img");
            __builder.AddAttribute(18, "class", "default-img");
            __builder.AddAttribute(19, "src", 
#nullable restore
#line 55 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\CatagoryProduct.razor"
                                                               SingleProduct.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "alt", "#");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                                ");
            __builder.OpenElement(22, "img");
            __builder.AddAttribute(23, "class", "hover-img");
            __builder.AddAttribute(24, "src", 
#nullable restore
#line 56 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\CatagoryProduct.razor"
                                                             SingleProduct.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "alt", "#");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "button-head");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "product-action");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "data-toggle", "modal");
            __builder.AddAttribute(33, "data-target", "#exampleModal");
            __builder.AddAttribute(34, "title", "Quick View");
            __builder.AddAttribute(35, "href", "/singleproductdetail/" + (
#nullable restore
#line 60 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\CatagoryProduct.razor"
                                                                                                                                      SingleProduct.ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "<i class=\" ti-eye\"></i>");
            __builder.AddMarkupContent(37, "<span>Quick Shop</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                                ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "product-action-2");
            __builder.OpenElement(41, "a");
            __builder.AddAttribute(42, "title", "Add to cart");
            __builder.AddAttribute(43, "href", "/singleproductdetail/" + (
#nullable restore
#line 65 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\CatagoryProduct.razor"
                                                                                       SingleProduct.ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, "View Product ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "product-content");
            __builder.OpenElement(48, "h3");
            __builder.OpenElement(49, "a");
            __builder.AddAttribute(50, "href", "/singleproductdetail/" + (
#nullable restore
#line 70 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\CatagoryProduct.razor"
                                                               SingleProduct.ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, 
#nullable restore
#line 70 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\CatagoryProduct.razor"
                                                                                  SingleProduct.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "product-price");
            __builder.OpenElement(55, "span");
            __builder.AddContent(56, "PKr ");
            __builder.AddContent(57, 
#nullable restore
#line 72 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\CatagoryProduct.razor"
                                           SingleProduct.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 77 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\CatagoryProduct.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\CatagoryProduct.razor"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\CatagoryProduct.razor"
         
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\CatagoryProduct.razor"
            
    [Parameter]

    public string Catagoryproduct { get; set; }
    string currentuserid = "";
    Catagory Catagory = new Catagory();


    Estore.Shared.Models.Shop[] ShopList;
    Estore.Shared.Models.Catagory[] CatagoriesList;
    Estore.Shared.Models.Product[] ProductList;
    protected override async Task OnInitializedAsync()
    {

        try
        {
            ProductList = await Http.GetFromJsonAsync<Estore.Shared.Models.Product[]>
("/api/Products/Index");
            Catagory = await Http.GetFromJsonAsync<Catagory>
("/api/Catagories/Details/" + Convert.ToInt32(Catagoryproduct));

            CurrentUser userdata = await authStateProvider.GetCurrentUser();
            currentuserid = userdata.Claims["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"].ToString();

        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }


    }
    public string[] getcatagoryarray(String catagory_id)
    {
        string[] catagoryarray = catagory_id.Split(",");
        return catagoryarray;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomStateProvider authStateProvider { get; set; }
    }
}
#pragma warning restore 1591