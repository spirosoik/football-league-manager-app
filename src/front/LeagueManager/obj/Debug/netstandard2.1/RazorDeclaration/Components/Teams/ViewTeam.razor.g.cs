#pragma checksum "c:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\Components\Teams\ViewTeam.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01c6dc7962aebe900b5197ef35b3e2715f9bbb6a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LeagueManager.Components.Teams
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\_Imports.razor"
using LeagueManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\_Imports.razor"
using LeagueManager.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\_Imports.razor"
using LeagueManager.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\_Imports.razor"
using LeagueManager.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\_Imports.razor"
using LeagueManager.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/teams/{TeamId}")]
    public partial class ViewTeam : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "c:\Users\jeast\source\Github\league-manager\football-league-manager-app\src\front\LeagueManager\Components\Teams\ViewTeam.razor"
       
    [Parameter]
    public string TeamId { get; set; }

    private Team teamData { get; set; }

    protected override async Task OnInitializedAsync()
    {
        state.OnChange += StateHasChanged;

        teamData = await state.GetSpecific(this.TeamId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TeamState state { get; set; }
    }
}
#pragma warning restore 1591