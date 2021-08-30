// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\Pages\StateManage - Copy.razor"
using DaprTest1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\Pages\StateManage - Copy.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/statemanage")]
    public partial class StateManage___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\Pages\StateManage - Copy.razor"
       
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
