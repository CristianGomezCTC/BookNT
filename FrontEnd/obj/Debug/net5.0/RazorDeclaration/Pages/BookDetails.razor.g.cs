// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FrontEnd.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\_Imports.razor"
using FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\_Imports.razor"
using FrontEnd.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\_Imports.razor"
using FrontEnd.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\_Imports.razor"
using FrontEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\_Imports.razor"
using FrontEnd.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\Pages\BookDetails.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\Pages\BookDetails.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Details/{id}")]
    public partial class BookDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\Pages\BookDetails.razor"
       

    [Parameter]
    public string id { get; set; }

    Book book = new Book();

    bool isLoading;


    protected override async Task OnInitializedAsync()
    {

        var response = await client.PostAsJsonAsync($"https://localhost:5002/api/BooksControllers/{id}",id);

        if (response.IsSuccessStatusCode)
        {
            book = await response.Content.ReadFromJsonAsync<Book>();
        }

        isLoading = true;


    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
