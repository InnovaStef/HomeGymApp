#pragma checksum "D:\ProyectInnovaSoft\gymencasa.app.presentacion\Pages\Usuarios\ConsultaU.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d6a823ab7ba11572e7da98999a456cd1276a209"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GymEnCasa.App.Presentacion.Pages.Usuarios.Pages_Usuarios_ConsultaU), @"mvc.1.0.razor-page", @"/Pages/Usuarios/ConsultaU.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Usuarios/ConsultaU.cshtml", typeof(GymEnCasa.App.Presentacion.Pages.Usuarios.Pages_Usuarios_ConsultaU), null)]
namespace GymEnCasa.App.Presentacion.Pages.Usuarios
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\ProyectInnovaSoft\gymencasa.app.presentacion\Pages\_ViewImports.cshtml"
using GymEnCasa.App.Presentacion;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d6a823ab7ba11572e7da98999a456cd1276a209", @"/Pages/Usuarios/ConsultaU.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86bf3f15c00edba4b629826e30229dcd5bfb7ed7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Usuarios_ConsultaU : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\ProyectInnovaSoft\gymencasa.app.presentacion\Pages\Usuarios\ConsultaU.cshtml"
  
 ViewData["Title"] = "Nuevo Usuario";

#line default
#line hidden
            BeginContext(104, 392, true);
            WriteLiteral(@"
<h2 class=""text-info"" style=""text-align:center;"">Lista Usuarios </h2>
<div class=""border"">
    <table class=""table"">
        <tr>
            <td>Correo </td>
            <td>Contraseña</td>
            <td>Nombre</td>
            <td>Apellidos</td>
            <td>Teléfono</td>
            <td>Género</td>
            <td>Dirección</td>
            <td>ObjetivoPersonal</td>
        </tr>
");
            EndContext();
#line 20 "D:\ProyectInnovaSoft\gymencasa.app.presentacion\Pages\Usuarios\ConsultaU.cshtml"
         foreach (var U in Model.listaUsuario)
        {

#line default
#line hidden
            BeginContext(553, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(591, 8, false);
#line 23 "D:\ProyectInnovaSoft\gymencasa.app.presentacion\Pages\Usuarios\ConsultaU.cshtml"
               Write(U.Correo);

#line default
#line hidden
            EndContext();
            BeginContext(599, 27, true);
            WriteLiteral(" </td>\n                <td>");
            EndContext();
            BeginContext(627, 12, false);
#line 24 "D:\ProyectInnovaSoft\gymencasa.app.presentacion\Pages\Usuarios\ConsultaU.cshtml"
               Write(U.Contrasena);

#line default
#line hidden
            EndContext();
            BeginContext(639, 27, true);
            WriteLiteral(" </td>\n                <td>");
            EndContext();
            BeginContext(667, 8, false);
#line 25 "D:\ProyectInnovaSoft\gymencasa.app.presentacion\Pages\Usuarios\ConsultaU.cshtml"
               Write(U.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(675, 27, true);
            WriteLiteral(" </td>\n                <td>");
            EndContext();
            BeginContext(703, 11, false);
#line 26 "D:\ProyectInnovaSoft\gymencasa.app.presentacion\Pages\Usuarios\ConsultaU.cshtml"
               Write(U.Apellidos);

#line default
#line hidden
            EndContext();
            BeginContext(714, 27, true);
            WriteLiteral(" </td>\n                <td>");
            EndContext();
            BeginContext(742, 10, false);
#line 27 "D:\ProyectInnovaSoft\gymencasa.app.presentacion\Pages\Usuarios\ConsultaU.cshtml"
               Write(U.Telefono);

#line default
#line hidden
            EndContext();
            BeginContext(752, 27, true);
            WriteLiteral(" </td>\n                <td>");
            EndContext();
            BeginContext(780, 8, false);
#line 28 "D:\ProyectInnovaSoft\gymencasa.app.presentacion\Pages\Usuarios\ConsultaU.cshtml"
               Write(U.Genero);

#line default
#line hidden
            EndContext();
            BeginContext(788, 27, true);
            WriteLiteral(" </td>\n                <td>");
            EndContext();
            BeginContext(816, 11, false);
#line 29 "D:\ProyectInnovaSoft\gymencasa.app.presentacion\Pages\Usuarios\ConsultaU.cshtml"
               Write(U.Direccion);

#line default
#line hidden
            EndContext();
            BeginContext(827, 27, true);
            WriteLiteral(" </td>\n                <td>");
            EndContext();
            BeginContext(855, 18, false);
#line 30 "D:\ProyectInnovaSoft\gymencasa.app.presentacion\Pages\Usuarios\ConsultaU.cshtml"
               Write(U.ObjetivoPersonal);

#line default
#line hidden
            EndContext();
            BeginContext(873, 25, true);
            WriteLiteral(" </td>\n            </tr>\n");
            EndContext();
#line 32 "D:\ProyectInnovaSoft\gymencasa.app.presentacion\Pages\Usuarios\ConsultaU.cshtml"
        }

#line default
#line hidden
            BeginContext(908, 20, true);
            WriteLiteral("    </table>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GymEnCasa.App.Presentacion.Pages.ConsultaUModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GymEnCasa.App.Presentacion.Pages.ConsultaUModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GymEnCasa.App.Presentacion.Pages.ConsultaUModel>)PageContext?.ViewData;
        public GymEnCasa.App.Presentacion.Pages.ConsultaUModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
