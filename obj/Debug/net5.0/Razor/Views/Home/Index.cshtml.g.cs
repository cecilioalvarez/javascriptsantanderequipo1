<<<<<<< HEAD
#pragma checksum "/Users/cecilioalvarezcaules/Desktop/repositoriocompartido/javascriptsantanderequipo1/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1daf53991bb67ecf668da4807c97c822faf719b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "/Users/cecilioalvarezcaules/Desktop/repositoriocompartido/javascriptsantanderequipo1/Views/_ViewImports.cshtml"
using javascriptsantanderequipo1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/cecilioalvarezcaules/Desktop/repositoriocompartido/javascriptsantanderequipo1/Views/_ViewImports.cshtml"
using javascriptsantanderequipo1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1daf53991bb67ecf668da4807c97c822faf719b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2caaed9aad9894f8145a41d4cd9f8dac35cd16e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/cecilioalvarezcaules/Desktop/repositoriocompartido/javascriptsantanderequipo1/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "/Users/cecilioalvarezcaules/Desktop/repositoriocompartido/javascriptsantanderequipo1/Views/Home/Index.cshtml"
 foreach (var factura in ViewBag.listaFacturas)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 8 "/Users/cecilioalvarezcaules/Desktop/repositoriocompartido/javascriptsantanderequipo1/Views/Home/Index.cshtml"
  Write(factura.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n      <p>");
#nullable restore
#line 9 "/Users/cecilioalvarezcaules/Desktop/repositoriocompartido/javascriptsantanderequipo1/Views/Home/Index.cshtml"
    Write(factura.Concepto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n       <p>");
#nullable restore
#line 10 "/Users/cecilioalvarezcaules/Desktop/repositoriocompartido/javascriptsantanderequipo1/Views/Home/Index.cshtml"
     Write(factura.Importe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 11 "/Users/cecilioalvarezcaules/Desktop/repositoriocompartido/javascriptsantanderequipo1/Views/Home/Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
=======
#pragma checksum "D:\www\frontend\javascriptsantanderequipo1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4a05e4a8156d94c5562f4017957b5c910995bf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "D:\www\frontend\javascriptsantanderequipo1\Views\_ViewImports.cshtml"
using javascriptsantanderequipo1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\www\frontend\javascriptsantanderequipo1\Views\_ViewImports.cshtml"
using javascriptsantanderequipo1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4a05e4a8156d94c5562f4017957b5c910995bf7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2caaed9aad9894f8145a41d4cd9f8dac35cd16e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\www\frontend\javascriptsantanderequipo1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Rama 4";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\www\frontend\javascriptsantanderequipo1\Views\Home\Index.cshtml"
 foreach (var registro in ViewBag.lista)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\www\frontend\javascriptsantanderequipo1\Views\Home\Index.cshtml"
Write(registro);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\r\n");
#nullable restore
#line 10 "D:\www\frontend\javascriptsantanderequipo1\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
>>>>>>> 1bfd56cdfa82095d10f90cd5b9466b7d955dbf2d
