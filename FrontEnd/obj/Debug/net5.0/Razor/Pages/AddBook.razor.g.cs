#pragma checksum "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\Pages\AddBook.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2b5f9ade373facb1cafe0d29afa7e921594f906"
// <auto-generated/>
#pragma warning disable 1591
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
#line 5 "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\Pages\AddBook.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\Pages\AddBook.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddBook")]
    public partial class AddBook : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AddBook</h3>\r\n\r\n");
            __builder.OpenComponent<FrontEnd.Components.FormBook>(1);
            __builder.AddAttribute(2, "PostBook", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<FrontEnd.Models.Book>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<FrontEnd.Models.Book>(this, 
#nullable restore
#line 10 "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\Pages\AddBook.razor"
                     CreateBook

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 12 "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\Pages\AddBook.razor"
 if (isSuccess)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, @"<div class=""toast"" role=""alert"" aria-live=""assertive"" aria-atomic=""true""><div class=""toast-header""><img src=""..."" class=""rounded me-2"" alt=""..."">
        <strong class=""me-auto"">Success</strong>
        <small>20 secs ago</small>
        <button type=""button"" class=""btn-close"" data-bs-dismiss=""toast"" aria-label=""Close""></button></div>
    <div class=""toast-body"">
        Your book it was successfully save
    </div></div>");
#nullable restore
#line 25 "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\Pages\AddBook.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\cristian.gomez\Desktop\ApiBooks\FrontEnd\Pages\AddBook.razor"
       
    bool isSuccess;
    public async Task CreateBook(Book book)
    {

        var response = await client.PostAsJsonAsync($"https://localhost:5002/api/BooksControllers/", book);

        if (response.IsSuccessStatusCode)
        {
            book = await response.Content.ReadFromJsonAsync<Book>();
            isSuccess = true;

        }

    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
