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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Register.razor"
       
    private bool registration = true;
    private bool emailVer = true;
    private bool usernameVer = true;
    private string email;
    private string username;
    private string password;

    private void register()
    {
        emailVer = AuthService.checkEmail(email);
        if (emailVer){
            usernameVer = AuthService.checkUsername(username);
            if (usernameVer){
                registration = AuthService.Register(email,username,password);
                if (registration){NavigationManager.NavigateTo("/shirts");}
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthService AuthService { get; set; }
    }
}
#pragma warning restore 1591