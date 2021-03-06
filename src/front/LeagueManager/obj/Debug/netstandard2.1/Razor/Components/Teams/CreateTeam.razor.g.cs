#pragma checksum "C:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\Components\Teams\CreateTeam.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "514181a9691b5ddb423f13202882acaf40c46403"
// <auto-generated/>
#pragma warning disable 1591
namespace LeagueManager.Components.Teams
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\_Imports.razor"
using LeagueManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\_Imports.razor"
using LeagueManager.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\_Imports.razor"
using LeagueManager.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\_Imports.razor"
using LeagueManager.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\_Imports.razor"
using LeagueManager.Services;

#line default
#line hidden
#nullable disable
    public partial class CreateTeam : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h2>Create a team</h2>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "C:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\Components\Teams\CreateTeam.razor"
                     newTeam

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col");
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "input-group mb-3");
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "type", "text");
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "placeholder", "Name");
                __builder2.AddAttribute(18, "aria-label", "Search Term");
                __builder2.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\Components\Teams\CreateTeam.razor"
                                                                                                           newTeam.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTeam.Name = __value, newTeam.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "row py-1");
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "ml-auto");
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __builder2.OpenElement(29, "button");
                __builder2.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\Components\Teams\CreateTeam.razor"
                                      () => OnSave.InvokeAsync(newTeam)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "type", "button");
                __builder2.AddAttribute(32, "class", "btn btn-danger px-5");
                __builder2.AddMarkupContent(33, "\r\n                        Add +\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\Components\Teams\CreateTeam.razor"
 
    [Parameter]
    public EventCallback<Team> OnSave { get; set; }

    [Parameter]
    public string TeamId { get; set; }

    private Team newTeam = new Team();

    protected override Task OnInitializedAsync()
    {
        return base.OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
