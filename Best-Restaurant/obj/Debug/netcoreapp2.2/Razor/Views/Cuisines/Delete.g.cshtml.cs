#pragma checksum "/Users/Guest/Desktop/Best-Restaurant/Best-Restaurant/Views/Cuisines/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7fdabaf1c44b71c7a5a457b1c4dcd307f033844"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuisines_Delete), @"mvc.1.0.view", @"/Views/Cuisines/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cuisines/Delete.cshtml", typeof(AspNetCore.Views_Cuisines_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7fdabaf1c44b71c7a5a457b1c4dcd307f033844", @"/Views/Cuisines/Delete.cshtml")]
    public class Views_Cuisines_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurant.Models.Cuisine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/Guest/Desktop/Best-Restaurant/Best-Restaurant/Views/Cuisines/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(28, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(66, 50, true);
            WriteLiteral("<h2>\nAre you sure you want to delete this?\n</h2>\n\n");
            EndContext();
            BeginContext(117, 40, false);
#line 11 "/Users/Guest/Desktop/Best-Restaurant/Best-Restaurant/Views/Cuisines/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(157, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(160, 40, false);
#line 11 "/Users/Guest/Desktop/Best-Restaurant/Best-Restaurant/Views/Cuisines/Delete.cshtml"
                                      Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(200, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 12 "/Users/Guest/Desktop/Best-Restaurant/Best-Restaurant/Views/Cuisines/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(229, 45, true);
            WriteLiteral("    <input type =\"submit\" value= \"Delete\" />\n");
            EndContext();
#line 15 "/Users/Guest/Desktop/Best-Restaurant/Best-Restaurant/Views/Cuisines/Delete.cshtml"

}

#line default
#line hidden
            BeginContext(277, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(279, 40, false);
#line 18 "/Users/Guest/Desktop/Best-Restaurant/Best-Restaurant/Views/Cuisines/Delete.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurant.Models.Cuisine> Html { get; private set; }
    }
}
#pragma warning restore 1591