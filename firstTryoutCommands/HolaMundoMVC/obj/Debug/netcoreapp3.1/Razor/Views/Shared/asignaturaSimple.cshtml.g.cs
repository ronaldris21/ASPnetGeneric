#pragma checksum "C:\Users\286407\Desktop\ASPnetGeneric\firstTryoutCommands\HolaMundoMVC\Views\Shared\asignaturaSimple.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12c0d9e9a4c48e1cd70649bbe0a7eb1ef18c3540"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_asignaturaSimple), @"mvc.1.0.view", @"/Views/Shared/asignaturaSimple.cshtml")]
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
#line 1 "C:\Users\286407\Desktop\ASPnetGeneric\firstTryoutCommands\HolaMundoMVC\Views\_ViewImports.cshtml"
using HolaMundoMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\286407\Desktop\ASPnetGeneric\firstTryoutCommands\HolaMundoMVC\Views\_ViewImports.cshtml"
using HolaMundoMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12c0d9e9a4c48e1cd70649bbe0a7eb1ef18c3540", @"/Views/Shared/asignaturaSimple.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd844b5729bef53cbee2b226a2f3054d035bc852", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_asignaturaSimple : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Asignatura>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<address>\r\n    <h5><b>Nombre: </b> ");
#nullable restore
#line 4 "C:\Users\286407\Desktop\ASPnetGeneric\firstTryoutCommands\HolaMundoMVC\Views\Shared\asignaturaSimple.cshtml"
                   Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <p><b>Identifier</b> ");
#nullable restore
#line 5 "C:\Users\286407\Desktop\ASPnetGeneric\firstTryoutCommands\HolaMundoMVC\Views\Shared\asignaturaSimple.cshtml"
                    Write(Model.UniqueId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</address>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Asignatura> Html { get; private set; }
    }
}
#pragma warning restore 1591
