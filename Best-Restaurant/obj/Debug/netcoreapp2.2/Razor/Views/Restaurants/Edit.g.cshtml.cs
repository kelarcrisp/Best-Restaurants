#pragma checksum "/Users/Guest/Desktop/Best-Restaurant/Best-Restaurant/Views/Restaurants/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35d59fab459350f09f8aeabddc712bfc5d644aff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Edit), @"mvc.1.0.view", @"/Views/Restaurants/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurants/Edit.cshtml", typeof(AspNetCore.Views_Restaurants_Edit))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35d59fab459350f09f8aeabddc712bfc5d644aff", @"/Views/Restaurants/Edit.cshtml")]
    public class Views_Restaurants_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurant.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/Guest/Desktop/Best-Restaurant/Best-Restaurant/Views/Restaurants/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(28, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(69, 20, true);
            WriteLiteral("\n<h3>edit the list: ");
            EndContext();
            BeginContext(90, 36, false);
#line 8 "/Users/Guest/Desktop/Best-Restaurant/Best-Restaurant/Views/Restaurants/Edit.cshtml"
              Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(126, 7, true);
            WriteLiteral("</h3>\n\n");
            EndContext();
#line 10 "/Users/Guest/Desktop/Best-Restaurant/Best-Restaurant/Views/Restaurants/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(166, 43, false);
#line 12 "/Users/Guest/Desktop/Best-Restaurant/Best-Restaurant/Views/Restaurants/Edit.cshtml"
Write(Html.HiddenFor(model => model.idRestaurant));

#line default
#line hidden
            EndContext();
            BeginContext(216, 34, false);
#line 14 "/Users/Guest/Desktop/Best-Restaurant/Best-Restaurant/Views/Restaurants/Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(257, 35, false);
#line 15 "/Users/Guest/Desktop/Best-Restaurant/Best-Restaurant/Views/Restaurants/Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(300, 38, false);
#line 17 "/Users/Guest/Desktop/Best-Restaurant/Best-Restaurant/Views/Restaurants/Edit.cshtml"
Write(Html.LabelFor(model => model.BestFood));

#line default
#line hidden
            EndContext();
            BeginContext(345, 39, false);
#line 18 "/Users/Guest/Desktop/Best-Restaurant/Best-Restaurant/Views/Restaurants/Edit.cshtml"
Write(Html.EditorFor(model => model.BestFood));

#line default
#line hidden
            EndContext();
            BeginContext(386, 44, true);
            WriteLiteral("     <input type =\"submit\" value =\"Save\" />\n");
            EndContext();
#line 21 "/Users/Guest/Desktop/Best-Restaurant/Best-Restaurant/Views/Restaurants/Edit.cshtml"

}

#line default
#line hidden
            BeginContext(433, 5, true);
            WriteLiteral("\n<p> ");
            EndContext();
            BeginContext(439, 40, false);
#line 24 "/Users/Guest/Desktop/Best-Restaurant/Best-Restaurant/Views/Restaurants/Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(479, 4, true);
            WriteLiteral("</p>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurant.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
