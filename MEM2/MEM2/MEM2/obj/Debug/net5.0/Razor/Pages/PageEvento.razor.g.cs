#pragma checksum "F:\LI4\MEM2\MEM2\MEM2\Pages\PageEvento.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "033f7fe142ba78d9f49a14da56956c8ace9236cc"
// <auto-generated/>
#pragma warning disable 1591
namespace MEM2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\LI4\MEM2\MEM2\MEM2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\LI4\MEM2\MEM2\MEM2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\LI4\MEM2\MEM2\MEM2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\LI4\MEM2\MEM2\MEM2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\LI4\MEM2\MEM2\MEM2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\LI4\MEM2\MEM2\MEM2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\LI4\MEM2\MEM2\MEM2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\LI4\MEM2\MEM2\MEM2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\LI4\MEM2\MEM2\MEM2\_Imports.razor"
using MEM2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\LI4\MEM2\MEM2\MEM2\_Imports.razor"
using MEM2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\LI4\MEM2\MEM2\MEM2\Pages\PageEvento.razor"
using MEM2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\LI4\MEM2\MEM2\MEM2\Pages\PageEvento.razor"
using MEM2.Data.MEM2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\LI4\MEM2\MEM2\MEM2\Pages\PageEvento.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EventoDetails/{Id}")]
    public partial class PageEvento : OwningComponentBase<EventoService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 11 "F:\LI4\MEM2\MEM2\MEM2\Pages\PageEvento.razor"
      Evento.Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "div_l");
            __builder.OpenElement(5, "p");
            __builder.OpenElement(6, "em");
            __builder.AddMarkupContent(7, "<b>Descrição:</b> ");
            __builder.AddContent(8, 
#nullable restore
#line 14 "F:\LI4\MEM2\MEM2\MEM2\Pages\PageEvento.razor"
                          Evento.Descricao

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "p");
            __builder.OpenElement(11, "em");
            __builder.AddMarkupContent(12, "<b>Categoria:</b> ");
            __builder.AddContent(13, 
#nullable restore
#line 15 "F:\LI4\MEM2\MEM2\MEM2\Pages\PageEvento.razor"
                          Evento.Categoria

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "p");
            __builder.OpenElement(16, "em");
            __builder.AddMarkupContent(17, "<b>Inicio:</b> ");
            __builder.AddContent(18, 
#nullable restore
#line 16 "F:\LI4\MEM2\MEM2\MEM2\Pages\PageEvento.razor"
                       Evento.Inicio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.OpenElement(20, "p");
            __builder.OpenElement(21, "em");
            __builder.AddMarkupContent(22, "<b>Fim:</b> ");
            __builder.AddContent(23, 
#nullable restore
#line 17 "F:\LI4\MEM2\MEM2\MEM2\Pages\PageEvento.razor"
                    Evento.Fim

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n\r\n\r\n\r\n\r\n<div class=\"div_r\" id=\"map\" style=\"height: 700px;width:900px;\"></div>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(25);
            __builder.AddAttribute(26, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 29 "F:\LI4\MEM2\MEM2\MEM2\Pages\PageEvento.razor"
         if (on)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(27, "button");
                __builder2.AddAttribute(28, "class", "btn btn-outline-dark btn-lg ");
                __builder2.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "F:\LI4\MEM2\MEM2\MEM2\Pages\PageEvento.razor"
                                                                   FollowFunction

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(30, "Unfollow");
                __builder2.CloseElement();
#nullable restore
#line 32 "F:\LI4\MEM2\MEM2\MEM2\Pages\PageEvento.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(31, "button");
                __builder2.AddAttribute(32, "class", "btn btn-outline-dark btn-lg  ");
                __builder2.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "F:\LI4\MEM2\MEM2\MEM2\Pages\PageEvento.razor"
                                                                    FollowFunction

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(34, "Follow");
                __builder2.CloseElement();
#nullable restore
#line 36 "F:\LI4\MEM2\MEM2\MEM2\Pages\PageEvento.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n\r\n");
            __builder.AddMarkupContent(36, "<style>\r\n    .div_r {\r\n        float: right;\r\n        \r\n    }\r\n\r\n    .button{\r\n        float:left;\r\n    }\r\n\r\n    .div_l {\r\n        font-family: Lato;\r\n        overflow-wrap: break-word;\r\n        width: 40em;\r\n        float: left;\r\n    }\r\n\r\n\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "F:\LI4\MEM2\MEM2\MEM2\Pages\PageEvento.razor"
      

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }


    [Parameter]
    public string Id { get; set; }

    Evento Evento = new Evento();

    private bool load = false;
    Boolean on;

    protected override async Task OnInitializedAsync()
    {
        Evento = await @Service.GetEvento(int.Parse(Id));
        load = true;

        var user = (await authenticationStateTask).User;

        if (user.Identity.IsAuthenticated)
        {
            bool On = Service.IsFollowing(user.Identity.Name, Evento.Id);
            on = On;
        }
    }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {


        if (load)
        {
            await JS.InvokeVoidAsync("loadBingMap", Evento.Latitude, Evento.Longitude);
            load = false;
        }


    }



    protected async Task FollowFunction()
    {

        var user = (await authenticationStateTask).User;
        Service.SetSeguido(user.Identity.Name, Evento.Id, on);
        on = !on;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
