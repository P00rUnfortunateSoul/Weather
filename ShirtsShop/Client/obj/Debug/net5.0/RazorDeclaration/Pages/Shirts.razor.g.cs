// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
