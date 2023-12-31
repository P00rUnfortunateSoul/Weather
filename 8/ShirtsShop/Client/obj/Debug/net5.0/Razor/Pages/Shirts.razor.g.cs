#pragma checksum "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "453dafe119aa0ab6bed410ef9b590880124b5f4d0837e23f53d57cf268885d52"
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
#line 1 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using ShirtsShop.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using ShirtsShop.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using ShirtsShop.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using ShirtsShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/shirts")]
    public partial class Shirts : global::Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
 if(AuthService.IsAuthenticated){


#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
#nullable restore
#line 14 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
             if (AuthService.Role == "admin"){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-primary");
            __builder.AddAttribute(8, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                                                          (() => OpenAddShirtDialog())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Add");
            __builder.CloseElement();
#nullable restore
#line 16 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<h3>Shirts</h3>");
#nullable restore
#line 19 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
             if (ShirtService.Shirts.Count == 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<span>Loading Shirts...</span>");
#nullable restore
#line 22 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table");
            __builder.AddMarkupContent(14, "<thead><tr><th>Color</th>\r\n                            <th>Text on Shirt</th>\r\n                            <th>Size</th></tr></thead>\r\n                    ");
            __builder.OpenElement(15, "tbody");
#nullable restore
#line 34 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                         foreach (var shirt in ShirtService.Shirts)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "tr");
            __builder.OpenElement(17, "td");
#nullable restore
#line 37 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
__builder.AddContent(18, shirt.Color);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                            ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 38 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
__builder.AddContent(21, shirt.Text);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.OpenElement(23, "td");
#nullable restore
#line 39 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
__builder.AddContent(24, shirt.Size.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 40 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                             if (AuthService.Role == "admin"){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "td");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "btn btn-primary");
            __builder.AddAttribute(28, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                                                                              (() => OpenEditShirtDialog(shirt.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                                ");
            __builder.OpenElement(31, "td");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "btn btn-primary");
            __builder.AddAttribute(34, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                                                                              (() => DeleteShirt(shirt.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 49 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "style", "margin-bottom: 20px;");
            __builder.OpenComponent<global::ShirtsShop.Client.Shared.Dialog>(38);
            __builder.AddAttribute(39, "IsOpen", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 55 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                                 isAddEditDialogOpen

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(40, "Shirt", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::ShirtsShop.Shared.Shirt>(
#nullable restore
#line 55 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                                                              editedShirt

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(41, "Sizes", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.List<ShirtsShop.Shared.Size>>(
#nullable restore
#line 55 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                                                                                   ShirtService.Sizes

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(42, "SizeId", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 55 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                                                                                                                  sizeId

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(43, "OnClose", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Boolean>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Boolean>(this, 
#nullable restore
#line 55 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                                                                                                                                    CloseAddEditDialog

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(44, "OnSubmitShirt", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::ShirtsShop.Shared.Shirt>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::ShirtsShop.Shared.Shirt>(this, 
#nullable restore
#line 55 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                                                                                                                                                                        SaveShirt

#line default
#line hidden
#nullable disable
            ))));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col-md-4");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "class", "btn btn-primary float-right mt-2");
            __builder.AddAttribute(50, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                                                                       (()=>logout())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, "Logout");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"

} else {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(52, "<p>You are not authorized to view this page. Please log in.</p>\r\n    ");
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
                      (()=>GoToLogin())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(55, "Login");
            __builder.CloseElement();
#nullable restore
#line 67 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Shirts.razor"
       


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

    private void GoToLogin(){
        NavigationManager.NavigateTo("/login");
    }
    private void logout(){
        AuthService.SetAuthentication(false);
        NavigationManager.NavigateTo("/login");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthService AuthService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IShirtService ShirtService { get; set; }
    }
}
#pragma warning restore 1591
