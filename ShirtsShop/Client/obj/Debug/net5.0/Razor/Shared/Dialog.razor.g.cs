#pragma checksum "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Shared\Dialog.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "13c038499ca749a9fbbab0fad0d4ed5d713ab174640c729a11a8a6e57213360b"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal");
            __builder.AddAttribute(2, "tabindex", "-1");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddAttribute(4, "style", "display:" + " " + (
#nullable restore
#line 3 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Shared\Dialog.razor"
                                                                 IsOpen ? "block" : "none"

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "modal-dialog");
            __builder.AddAttribute(7, "role", "document");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-content");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-header");
            __builder.OpenElement(12, "h5");
            __builder.AddAttribute(13, "class", "modal-title");
#nullable restore
#line 7 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Shared\Dialog.razor"
__builder.AddContent(14, DialogTitle);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "class", "close");
            __builder.AddAttribute(19, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Shared\Dialog.razor"
                                                              Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "modal-body");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(24);
            __builder.AddAttribute(25, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 13 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Shared\Dialog.razor"
                                 Shirt

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(26, "OnSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Shared\Dialog.razor"
                                                  HandleSubmit

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(27, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group");
                __builder2.AddMarkupContent(30, "<label>Color</label>\r\n                        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "class", (object)("form-control"));
                __builder2.AddAttribute(33, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 16 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Shared\Dialog.razor"
                                                Shirt.Color

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(34, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Shirt.Color = __value, Shirt.Color)))));
                __builder2.AddAttribute(35, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Shirt.Color)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                    ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddMarkupContent(39, "<label>Text on Shirt</label>\r\n                        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(40);
                __builder2.AddAttribute(41, "class", (object)("form-control"));
                __builder2.AddAttribute(42, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 20 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Shared\Dialog.razor"
                                                Shirt.Text

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(43, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Shirt.Text = __value, Shirt.Text)))));
                __builder2.AddAttribute(44, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Shirt.Text)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                    ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-group");
                __builder2.AddMarkupContent(48, "<label>Size</label>\r\n                        ");
                global::__Blazor.ShirtsShop.Client.Shared.Dialog.TypeInference.CreateInputSelect_0(__builder2, 49, 50, "form-control", 51, 
#nullable restore
#line 24 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Shared\Dialog.razor"
                                                  SizeId

#line default
#line hidden
#nullable disable
                , 52, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SizeId = __value, SizeId)), 53, () => SizeId, 54, (__builder3) => {
#nullable restore
#line 25 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Shared\Dialog.razor"
                             foreach (var size in Sizes)
                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(55, "option");
                    __builder3.AddAttribute(56, "value", 
#nullable restore
#line 27 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Shared\Dialog.razor"
                                                size.Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 27 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Shared\Dialog.razor"
__builder3.AddContent(57, size.Name);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 28 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Shared\Dialog.razor"
                            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                    ");
                __builder2.OpenElement(59, "button");
                __builder2.AddAttribute(60, "type", "submit");
                __builder2.AddAttribute(61, "class", "btn btn-primary");
#nullable restore
#line 31 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Shared\Dialog.razor"
__builder2.AddContent(62, SubmitButtonText);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                    ");
                __builder2.OpenElement(64, "button");
                __builder2.AddAttribute(65, "type", "button");
                __builder2.AddAttribute(66, "class", "btn btn-secondary");
                __builder2.AddAttribute(67, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Uliana\source\repos\ShirtsShop\ShirtsShop\Client\Shared\Dialog.razor"
                                                                              Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(68, "Cancel");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
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
namespace __Blazor.ShirtsShop.Client.Shared.Dialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", (object)__arg0);
        __builder.AddAttribute(__seq1, "Value", (object)__arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", (object)__arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", (object)__arg3);
        __builder.AddAttribute(__seq4, "ChildContent", (object)__arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591