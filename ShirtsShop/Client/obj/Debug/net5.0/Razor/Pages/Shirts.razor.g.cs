#pragma checksum "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4f6ca0866cb7dc7d8ffffb506a08a0eac48e1267206f2481a663fccecf866e94"
// <auto-generated/>
#pragma warning disable 1591
namespace ShirtsShop.Client.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using ShirtsShop.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using ShirtsShop.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using ShirtsShop.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using ShirtsShop.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/shirts")]
    public partial class Shirts : global::Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "class", "btn btn-primary");
            __builder.AddAttribute(2, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                                          (() => OpenAddShirtDialog())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Add");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.AddMarkupContent(5, "<h3>Shirts</h3>");
#nullable restore
#line 10 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
 if (ShirtService.Shirts.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<span>Loading Shirts...</span>");
#nullable restore
#line 13 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "<thead><tr><th>Color</th>\r\n                <th>Text on Shirt</th>\r\n                <th>Size</th></tr></thead>\r\n        ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 25 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
             foreach (var shirt in ShirtService.Shirts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
#nullable restore
#line 28 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
__builder.AddContent(13, shirt.Color);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
#nullable restore
#line 29 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
__builder.AddContent(16, shirt.Text);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
#nullable restore
#line 30 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
__builder.AddContent(19, shirt.Size.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-primary");
            __builder.AddAttribute(24, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                                                              (() => OpenEditShirtDialog(shirt.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "td");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", "btn btn-primary");
            __builder.AddAttribute(30, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                                                              (() => DeleteShirt(shirt.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "style", "margin-bottom: 20px;");
            __builder.OpenComponent<global::ShirtsShop.Client.Shared.Dialog>(34);
            __builder.AddAttribute(35, "IsOpen", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 44 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                     isAddEditDialogOpen

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(36, "Shirt", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::ShirtsShop.Shared.Shirt>(
#nullable restore
#line 44 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                                                  editedShirt

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(37, "Sizes", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.List<ShirtsShop.Shared.Size>>(
#nullable restore
#line 44 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                                                                       ShirtService.Sizes

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(38, "SizeId", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 44 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                                                                                                      sizeId

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(39, "OnClose", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Boolean>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Boolean>(this, 
#nullable restore
#line 44 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                                                                                                                        CloseAddEditDialog

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(40, "OnSubmitShirt", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::ShirtsShop.Shared.Shirt>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::ShirtsShop.Shared.Shirt>(this, 
#nullable restore
#line 44 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                                                                                                                                                            SaveShirt

#line default
#line hidden
#nullable disable
            ))));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
       


    bool isAddEditDialogOpen = false;
    ShirtsShop.Shared.Shirt editedShirt = new ShirtsShop.Shared.Shirt();
    int sizeId = 1;

    protected override async Task OnInitializedAsync()
    {
        await ShirtService.GetShirts();
        ShirtService.OnChange += StateHasChanged;
    }

    void OpenAddShirtDialog()
    {
        editedShirt = new ShirtsShop.Shared.Shirt();
        editedShirt.Size = new ShirtsShop.Shared.Size();

        isAddEditDialogOpen = true;
        sizeId = 1;
        StateHasChanged();
    }

    void OpenEditShirtDialog(int id)
    {
        JSRuntime.InvokeVoidAsync("console.log", "OpenEditShirtDialog called");
        editedShirt = ShirtService.Shirts.Find(s => s.Id == id);
        isAddEditDialogOpen = true;
        sizeId = editedShirt.SizeId;
        StateHasChanged();
    }

    void CloseAddEditDialog(bool isClosed)
    {
        isAddEditDialogOpen = false;
        StateHasChanged();
    }

    async Task SaveShirt(Shirt shirt)
    {
        if (shirt.Id == 0)
        {
            await ShirtService.CreateShirt(shirt);
        }
        else
        {
            await ShirtService.UpdateShirt(shirt, shirt.Id);
        }
        await ShirtService.GetShirts();

        isAddEditDialogOpen = false;
    }

    void DeleteShirt(int ShirtId)
    {
        ShirtService.DeleteShirt(ShirtId);
    }

    public void Dispose()
    {
        ShirtService.OnChange -= StateHasChanged;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IShirtService ShirtService { get; set; }
    }
}
#pragma warning restore 1591
