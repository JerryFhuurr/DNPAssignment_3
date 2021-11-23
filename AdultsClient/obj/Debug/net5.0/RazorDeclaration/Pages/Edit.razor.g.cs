// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AdultsClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\fhuur\OneDrive\DNPSolutions\DNPAssignment2\AdultsClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fhuur\OneDrive\DNPSolutions\DNPAssignment2\AdultsClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fhuur\OneDrive\DNPSolutions\DNPAssignment2\AdultsClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fhuur\OneDrive\DNPSolutions\DNPAssignment2\AdultsClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fhuur\OneDrive\DNPSolutions\DNPAssignment2\AdultsClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\fhuur\OneDrive\DNPSolutions\DNPAssignment2\AdultsClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\fhuur\OneDrive\DNPSolutions\DNPAssignment2\AdultsClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\fhuur\OneDrive\DNPSolutions\DNPAssignment2\AdultsClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\fhuur\OneDrive\DNPSolutions\DNPAssignment2\AdultsClient\_Imports.razor"
using AdultsClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\fhuur\OneDrive\DNPSolutions\DNPAssignment2\AdultsClient\_Imports.razor"
using AdultsClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fhuur\OneDrive\DNPSolutions\DNPAssignment2\AdultsClient\Pages\Edit.razor"
using AdultsClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fhuur\OneDrive\DNPSolutions\DNPAssignment2\AdultsClient\Pages\Edit.razor"
using AdultsClient.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\fhuur\OneDrive\DNPSolutions\DNPAssignment2\AdultsClient\Pages\Edit.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fhuur\OneDrive\DNPSolutions\DNPAssignment2\AdultsClient\Pages\Edit.razor"
           [Authorize(Policy = "SecurityLevel2")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Edit/{Id:int}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "C:\Users\fhuur\OneDrive\DNPSolutions\DNPAssignment2\AdultsClient\Pages\Edit.razor"
       

    [Parameter]
    public int Id { get; set; }

    private Adult adultToEdit;
    private Job jobToEdit;

    protected override async Task OnInitializedAsync()
    {
        adultToEdit = await familiesService.GetAsync(Id);
        jobToEdit = adultToEdit.Job;
    }

    private void Save()
    {
        adultToEdit.Job = jobToEdit;
        familiesService.UpdateAsync(adultToEdit);
        NavigationManager.NavigateTo("/Adults");
    }

    private void Back()
    {
        NavigationManager.NavigateTo("/Adults");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamiliesService familiesService { get; set; }
    }
}
#pragma warning restore 1591
