#pragma checksum "C:\Users\enida\Downloads\eHotelWebAPI-master\Hotel.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "706d78c60f06d9f4c0db748412a8c04d2b7aa5d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\enida\Downloads\eHotelWebAPI-master\Hotel.Web\Views\_ViewImports.cshtml"
using RestaurantReservation.Web;

#line default
#line hidden
#line 2 "C:\Users\enida\Downloads\eHotelWebAPI-master\Hotel.Web\Views\_ViewImports.cshtml"
using RestaurantReservation.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"706d78c60f06d9f4c0db748412a8c04d2b7aa5d6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d093077628846ec6a7ca0fdceb890fa13e3b402", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\enida\Downloads\eHotelWebAPI-master\Hotel.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(42, 1233, true);
            WriteLiteral(@"<h1>Hotel Reservation </h1>
<p>
    Seminarski rad iz predmeta RKS, radi se o Android aplikaciji za rezervaciju soba u Hotelu.
    Kratki opis funkcionalnosti:
    <ul>
        <li>Logiranje/Registracija </li>
        <li>Pregled liste soba</li>
        <li>Pregled detalja o sobi</li>
        <li>Dodavanje nove rezervacije</li>
        <li>Pregled i upravljanje rezervacijama</li>im
    </ul>
    
   
</p>
<h3>Link za download aplikacije:</h3>
<a href=""https://edufit-my.sharepoint.com/personal/enida_obradovic_edu_fit_ba/_layouts/15/onedrive.aspx?id=%2Fpersonal%2Fenida_obradovic_edu_fit_ba%2FDocuments%2Fapp-debug%2Eapk&parent=%2Fpersonal%2Fenida_obradovic_edu_fit_ba%2FDocuments"">Restaurant Reservation apk file</a> <br />
<h3>Link za ulaz u aplikaciju preko online emulatora:</h3>
<a href=""https://appetize.io/app/mkk0yfyyyjhcvuf0b2zrhty7f4?device=nexus5&scale=75&orientation=portrait&osVersion=8.1"">Hotel Reservation Online Emulator</a> <br />
<br />

<h4><strong>Podaci za logiranje:</strong></h4>
<p> Username:Samr");
            WriteLiteral("a</p>\n<p> Password:test</p>\n<br />\n<h4><strong>Sourcecode::</strong></h4>\n<a href=\"https://github.com/enidaobradovic1/eHotelAndroid\">Hotel_Reservation_Android</a> <br />\n<a href=\"\">Hotel_Reservation_WebAPI</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
