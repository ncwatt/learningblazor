#pragma checksum "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4351232930e2674534e3a5aa8d58786ceac2f747"
// <auto-generated/>
#pragma warning disable 1591
namespace PizzaPlace.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\_Imports.razor"
using PizzaPlace.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\_Imports.razor"
using PizzaPlace.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\_Imports.razor"
using PizzaPlace.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Our selection of pizzas</h1>");
#nullable restore
#line 5 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\Pages\Index.razor"
 foreach (var pizza in State.Menu.Pizzas)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col");
            __builder.AddContent(5, 
#nullable restore
#line 9 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\Pages\Index.razor"
             pizza.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col");
            __builder.AddContent(9, 
#nullable restore
#line 12 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\Pages\Index.razor"
             pizza.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 15 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\Pages\Index.razor"
                       SpicinessImage(pizza.Spiciness)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "alt", 
#nullable restore
#line 15 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\Pages\Index.razor"
                                                              pizza.Spiciness

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "class", "btn btn-success");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\Pages\Index.razor"
                                                        () => AddToBasket(pizza)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Add");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\Pages\Index.razor"
 if (State.Basket.Orders.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "<h1>Your current order</h1>");
#nullable restore
#line 29 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\Pages\Index.razor"
     foreach (var (pizza, pos) in State.Basket.Orders.Select((id, pos) => (State.Menu.GetPizza(id), pos)))
    { 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col");
            __builder.AddContent(28, 
#nullable restore
#line 33 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\Pages\Index.razor"
                 pizza.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col");
            __builder.AddContent(32, 
#nullable restore
#line 36 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\Pages\Index.razor"
                 pizza.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "btn btn-danger");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\Pages\Index.razor"
                                                           () => RemoveFromBasket(pos)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Remove");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "row");
            __builder.AddMarkupContent(42, "<div class=\"col\"> Total:</div>\r\n        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col");
            __builder.AddContent(45, 
#nullable restore
#line 45 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\Pages\Index.razor"
                           State.TotalPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        <div class=\"col\"></div>");
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\Pages\Index.razor"

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(47, "\r\n\r\nWelcome to your new app.\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\nwatt\source\repos\LearningBlazor\PizzaPlace\PizzaPlace\Client\Pages\Index.razor"
       
    private State State { get; } = new State()
    {
        Menu = new Menu
        {
            Pizzas = new List<Pizza>
            {
                new Pizza(1, "Pepperoni", 8.99M, Spiciness.Spicy),
                new Pizza(2, "Margarita", 7.99M, Spiciness.None),
                new Pizza(3, "Diabolo", 9.99M, Spiciness.Hot)
            }
        }
    };

    private string SpicinessImage(Spiciness spiciness) => $"images/{spiciness.ToString().ToLower()}.png";

    public void AddToBasket(Pizza pizza)
    {
        Console.WriteLine($"Added pizza {pizza.Name}");
        State.Basket.Add(pizza.Id);
    }

    public void RemoveFromBasket(int pos)
    {
        Console.WriteLine($"Removing pizza at pos {pos}");
        State.Basket.RemoveAt(pos);
    }

    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
