#pragma checksum "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Login.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "753cf8edeab6ea55c6ee03ac4c1977face8865fd8a234ee411aee1521a353c42"
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"text-center\">Login</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row justify-content-center");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-4");
            __builder.OpenElement(7, "form");
            __builder.AddAttribute(8, "onsubmit", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.EventArgs>(this, 
#nullable restore
#line 10 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Login.razor"
                             login

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "class", "mt-4");
#nullable restore
#line 11 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Login.razor"
                 if (!string.IsNullOrEmpty(errorMessage))
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "alert alert-danger");
            __builder.AddAttribute(12, "role", "alert");
#nullable restore
#line 14 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Login.razor"
__builder.AddContent(13, errorMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 16 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Login.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "form-group");
            __builder.AddMarkupContent(16, "<label for=\"username\">Username:</label>\r\n                    ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "text");
            __builder.AddAttribute(19, "id", "username");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Login.razor"
                                                            username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group");
            __builder.AddMarkupContent(26, "<label for=\"password\">Password:</label>\r\n                    ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "password");
            __builder.AddAttribute(29, "id", "password");
            __builder.AddAttribute(30, "class", "form-control");
            __builder.AddAttribute(31, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Login.razor"
                                                                password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n                ");
            __builder.AddMarkupContent(34, "<button type=\"submit\" class=\"btn btn-primary\">Login</button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.AddMarkupContent(36, "<p>Don\'t have an account? <a href=\"/register\">Register</a></p>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "D:\2023Z\pamiw\lab6\ShirtsShop\ShirtsShop\Client\Pages\Login.razor"
       
    private string username;
    private string password;
    private string errorMessage;

    private void login()
    {
        bool auth = AuthService.checkAuth(username, password);
        if (auth)
        {
            AuthService.SetAuthentication(true);
            NavigationManager.NavigateTo("/shirts");
        }else
        {
            errorMessage = "Invalid username or password";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthService AuthService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591