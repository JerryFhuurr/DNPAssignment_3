#pragma checksum "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3508e5402175a1de545168f8b7d1e0cacffa23e1"
// <auto-generated/>
#pragma warning disable 1591
namespace AdultsClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\_Imports.razor"
using AdultsClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\_Imports.razor"
using AdultsClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor"
using AdultsClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor"
using AdultsClient.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor"
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
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Edit adult with id: ");
            __builder.AddContent(2, 
#nullable restore
#line 11 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor"
                         Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor"
 if (adultToEdit == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<em>Adult not found!</em>");
#nullable restore
#line 17 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 20 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor"
                      adultToEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 20 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor"
                                                   Save

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-row");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(12, "<label for=\"firstName\" class=\"form-check-label\">First name </label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "id", "firstName");
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "placeholder", "George");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor"
                                                                                                 adultToEdit.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.FirstName = __value, adultToEdit.FirstName))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultToEdit.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(23, "<label for=\"lastName\" class=\"form-check-label\">Last name </label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "id", "lastName");
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "placeholder", "Black");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor"
                                                                                               adultToEdit.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.LastName = __value, adultToEdit.LastName))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultToEdit.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-row");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(36, "<label for=\"job\" class=\"form-check-label\">Job Title </label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(37);
                __builder2.AddAttribute(38, "id", "job");
                __builder2.AddAttribute(39, "class", "form-control");
                __builder2.AddAttribute(40, "placeholder", "Student intern");
                __builder2.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor"
                                                                                                   jobToEdit.JobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => jobToEdit.JobTitle = __value, jobToEdit.JobTitle))));
                __builder2.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => jobToEdit.JobTitle));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(47, "<label for=\"salary\" class=\"form-check-label\">Salary </label>\r\n                ");
                __Blazor.AdultsClient.Pages.Edit.TypeInference.CreateInputNumber_0(__builder2, 48, 49, "salary", 50, "form-control", 51, "Per Year", 52, 
#nullable restore
#line 43 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor"
                                                                                                  jobToEdit.Salary

#line default
#line hidden
#nullable disable
                , 53, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => jobToEdit.Salary = __value, jobToEdit.Salary)), 54, () => jobToEdit.Salary);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-row");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(60, "<label for=\"hairColour\" class=\"form-check-label\">Hair colour </label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(61);
                __builder2.AddAttribute(62, "id", "hairColour");
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddAttribute(64, "placeholder", "Black");
                __builder2.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor"
                                                                                                 adultToEdit.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.HairColor = __value, adultToEdit.HairColor))));
                __builder2.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultToEdit.HairColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n            ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(71, "<label for=\"eyeColour\" class=\"form-check-label\">Eye colour </label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(72);
                __builder2.AddAttribute(73, "id", "eyeColour");
                __builder2.AddAttribute(74, "class", "form-control");
                __builder2.AddAttribute(75, "placeholder", "Blue");
                __builder2.AddAttribute(76, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor"
                                                                                               adultToEdit.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.EyeColor = __value, adultToEdit.EyeColor))));
                __builder2.AddAttribute(78, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultToEdit.EyeColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n            ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(82, "<label for=\"age\" class=\"form-check-label\">Age </label>\r\n                ");
                __Blazor.AdultsClient.Pages.Edit.TypeInference.CreateInputNumber_1(__builder2, 83, 84, "age", 85, "form-control", 86, "years", 87, 
#nullable restore
#line 57 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor"
                                                                                            adultToEdit.Age

#line default
#line hidden
#nullable disable
                , 88, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.Age = __value, adultToEdit.Age)), 89, () => adultToEdit.Age);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n        ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "form-row");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(95, "<label for=\"weight\" class=\"form-check-label\">Weight </label>\r\n                ");
                __Blazor.AdultsClient.Pages.Edit.TypeInference.CreateInputNumber_2(__builder2, 96, 97, "weight", 98, "form-control", 99, "kg", 100, 
#nullable restore
#line 63 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor"
                                                                                            adultToEdit.Weight

#line default
#line hidden
#nullable disable
                , 101, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.Weight = __value, adultToEdit.Weight)), 102, () => adultToEdit.Weight);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n            ");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(106, "<label for=\"height\" class=\"form-check-label\">Height </label>\r\n                ");
                __Blazor.AdultsClient.Pages.Edit.TypeInference.CreateInputNumber_3(__builder2, 107, 108, "height", 109, "form-control", 110, "cm", 111, 
#nullable restore
#line 67 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor"
                                                                                            adultToEdit.Height

#line default
#line hidden
#nullable disable
                , 112, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.Height = __value, adultToEdit.Height)), 113, () => adultToEdit.Height);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n            ");
                __builder2.OpenElement(115, "div");
                __builder2.AddAttribute(116, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(117, "<label for=\"sex\" class=\"form-check-label\">Sex </label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(118);
                __builder2.AddAttribute(119, "id", "sex");
                __builder2.AddAttribute(120, "class", "form-control");
                __builder2.AddAttribute(121, "placeholder", "whatever you want");
                __builder2.AddAttribute(122, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 71 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor"
                                                                                                      adultToEdit.Sex

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(123, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.Sex = __value, adultToEdit.Sex))));
                __builder2.AddAttribute(124, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultToEdit.Sex));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(125, "\r\n\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(126);
                __builder2.CloseComponent();
                __builder2.AddContent(127, " ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(128);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(129, "\r\n        ");
                __builder2.OpenElement(130, "div");
                __builder2.AddAttribute(131, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(132, "<p class=\"actions\"><button class=\"btn btn-outline-dark\" type=\"submit\">Edit</button></p>\r\n            ");
                __builder2.OpenElement(133, "p");
                __builder2.AddAttribute(134, "class", "actions");
                __builder2.OpenElement(135, "button");
                __builder2.AddAttribute(136, "class", "btn btn-outline-dark");
                __builder2.AddAttribute(137, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor"
                                                               Back

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(138, "Back");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 90 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "C:\Users\janad\OneDrive\Adam\Dokumenty\VIA\3rd semester\DNP1x\intro\DNP1Assignment2\DNPAssignment2\AdultsClient\Pages\Edit.razor"
       

    [Parameter]
    public int Id { get; set; }

    private Adult adultToEdit;
    private Job jobToEdit;

    protected override async Task OnInitializedAsync()
    {
        adultToEdit = await familiesService.GetAsync(Id);
        jobToEdit = adultToEdit.JobTitle;
    }

    private void Save()
    {
        adultToEdit.JobTitle = jobToEdit;
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
namespace __Blazor.AdultsClient.Pages.Edit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591