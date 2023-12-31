// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ShirtsShop.Client.Shared
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
    public partial class Dialog : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Shared\Dialog.razor"
       
    [Parameter]
    public bool IsOpen { get; set; }

    [Parameter]
    public Shirt Shirt { get; set; }

    [Parameter]
    public List<Size> Sizes { get; set; }

    [Parameter]
    public int SizeId {get; set;}

    [Parameter]
    public EventCallback<bool> OnClose { get; set; }

    [Parameter]
    public EventCallback<Shirt> OnSubmitShirt { get; set; }


    private string DialogTitle => Shirt.Id == 0 ? "Add Shirt" : "Edit Shirt";

    private string SubmitButtonText => Shirt.Id == 0 ? "Add" : "Update";

    protected override async Task OnInitializedAsync()
    {
        await ShirtService.GetSizes();
    }

    private void HandleSubmit()
    {
        if (Shirt.Id == 0)
            Shirt.Size = null;
        else Shirt.Size = new Size();
        Shirt.SizeId = SizeId;
        OnSubmitShirt.InvokeAsync(Shirt);
        OnClose.InvokeAsync(false);
    }

    private void Cancel()
    {
        OnClose.InvokeAsync(false);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IShirtService ShirtService { get; set; }
    }
}
#pragma warning restore 1591
