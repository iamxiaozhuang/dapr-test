#pragma checksum "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\Pages\StateManage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e597c6f248084ab819101c928ca44cdc363e38a"
// <auto-generated/>
#pragma warning disable 1591
namespace DaprTest1.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\_Imports.razor"
using DaprTest1.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\_Imports.razor"
using DaprTest1.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\Pages\StateManage.razor"
using DaprTest1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\Pages\StateManage.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/statemanage")]
    public partial class StateManage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>????????????</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates storing state.</p>\r\n\r\n");
            __builder.OpenElement(2, "p");
            __builder.AddMarkupContent(3, "?????????: TestStateKey, ????????????");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\Pages\StateManage.razor"
                                                    stateModel.Value

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => stateModel.Value = __value, stateModel.Value));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "class", "btn btn-primary");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\Pages\StateManage.razor"
                                          SaveStateValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(12, "????????????");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn btn-primary");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\Pages\StateManage.razor"
                                          DeleteStateValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(17, "????????????");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "class", "btn btn-primary");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\Pages\StateManage.razor"
                                          GetStateValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "????????????");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "class", "btn btn-primary");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\Pages\StateManage.razor"
                                          GetStateValueFromState

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(27, "????????????[FromState]");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n\r\n");
            __builder.OpenElement(29, "p");
            __builder.AddMarkupContent(30, "?????????????????????: ");
            __builder.AddContent(31, 
#nullable restore
#line 18 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\Pages\StateManage.razor"
             stateValue

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\Pages\StateManage.razor"
       
    private StateModel stateModel = new StateModel() { Key = "TestStateKey" };
    private string stateValue = "";

    private async Task SaveStateValue()
    {
        await Http.PostAsJsonAsync<StateModel>("WeatherForecast/SaveStateValue", stateModel);
    }
    private async Task DeleteStateValue()
    {
        await Http.DeleteAsync("WeatherForecast/DeleteStateValue/" + stateModel.Key);
    }
      private async Task GetStateValue()
    {
        stateValue = await Http.GetStringAsync("WeatherForecast/GetStateValue/" + stateModel.Key);
    }
     private async Task GetStateValueFromState()
    {
        stateValue = await Http.GetStringAsync("WeatherForecast/GetStateValueFromState/" + stateModel.Key);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
