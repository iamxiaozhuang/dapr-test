#pragma checksum "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\Pages\PubSub.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90f0cc532e20f9c009dd337e59a94a1a7b4b87f8"
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
#line 2 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\Pages\PubSub.razor"
using DaprTest1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\Pages\PubSub.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pubsub")]
    public partial class PubSub : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>发布订阅</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates publish and subscrible event.</p>\r\n\r\n");
            __builder.OpenElement(2, "p");
            __builder.AddMarkupContent(3, "编码:");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\Pages\PubSub.razor"
                                eventModel.Code

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => eventModel.Code = __value, eventModel.Code));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, ", 数量:");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\Pages\PubSub.razor"
                                                                                  eventModel.Amount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => eventModel.Amount = __value, eventModel.Amount));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn btn-primary");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\Pages\PubSub.razor"
                                          PublishEvent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(17, "发布事件");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "D:\K8s\Dapr\Test\dapr-test\DaprTest1\Client\Pages\PubSub.razor"
       
    private TestEventModel eventModel = new TestEventModel();
    private async Task PublishEvent() => await Http.PostAsJsonAsync<TestEventModel>("WeatherForecast/PublishTestEvent", eventModel);


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
