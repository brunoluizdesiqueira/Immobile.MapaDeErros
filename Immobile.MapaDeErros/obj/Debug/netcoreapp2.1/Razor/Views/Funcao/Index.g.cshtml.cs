#pragma checksum "/Users/bruno/Projetos/net-core/Immobile.MapaDeErros/Immobile.MapaDeErros/Views/Funcao/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "052685e1f069d0dec9cb1d0341245ef7d6c3a43b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcao_Index), @"mvc.1.0.view", @"/Views/Funcao/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Funcao/Index.cshtml", typeof(AspNetCore.Views_Funcao_Index))]
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
#line 1 "/Users/bruno/Projetos/net-core/Immobile.MapaDeErros/Immobile.MapaDeErros/Views/_ViewImports.cshtml"
using Immobile.MapaDeErros;

#line default
#line hidden
#line 2 "/Users/bruno/Projetos/net-core/Immobile.MapaDeErros/Immobile.MapaDeErros/Views/_ViewImports.cshtml"
using Immobile.MapaDeErros.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"052685e1f069d0dec9cb1d0341245ef7d6c3a43b", @"/Views/Funcao/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e728828ac02d034da914fa21840c31b9e044099f", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Immobile.MapaDeErros.Models.Funcao>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/bruno/Projetos/net-core/Immobile.MapaDeErros/Immobile.MapaDeErros/Views/Funcao/Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(90, 27, true);
            WriteLiteral("\n<h2>Funções</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(118, 39, false);
#line 10 "/Users/bruno/Projetos/net-core/Immobile.MapaDeErros/Immobile.MapaDeErros/Views/Funcao/Index.cshtml"
Write(Html.ActionLink("Criar nova", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(157, 62, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <tr>\n        <th>\n            ");
            EndContext();
            BeginContext(220, 40, false);
#line 15 "/Users/bruno/Projetos/net-core/Immobile.MapaDeErros/Immobile.MapaDeErros/Views/Funcao/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(260, 40, true);
            WriteLiteral("\n        </th>\n        <th>\n            ");
            EndContext();
            BeginContext(301, 42, false);
#line 18 "/Users/bruno/Projetos/net-core/Immobile.MapaDeErros/Immobile.MapaDeErros/Views/Funcao/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(343, 40, true);
            WriteLiteral("\n        </th>\n        <th>\n            ");
            EndContext();
            BeginContext(384, 47, false);
#line 21 "/Users/bruno/Projetos/net-core/Immobile.MapaDeErros/Immobile.MapaDeErros/Views/Funcao/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.DataCriacao));

#line default
#line hidden
            EndContext();
            BeginContext(431, 40, true);
            WriteLiteral("\n        </th>\n        <th>\n            ");
            EndContext();
            BeginContext(472, 48, false);
#line 24 "/Users/bruno/Projetos/net-core/Immobile.MapaDeErros/Immobile.MapaDeErros/Views/Funcao/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.DataAtivacao));

#line default
#line hidden
            EndContext();
            BeginContext(520, 40, true);
            WriteLiteral("\n        </th>\n        <th>\n            ");
            EndContext();
            BeginContext(561, 51, false);
#line 27 "/Users/bruno/Projetos/net-core/Immobile.MapaDeErros/Immobile.MapaDeErros/Views/Funcao/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.DataDesativacao));

#line default
#line hidden
            EndContext();
            BeginContext(612, 45, true);
            WriteLiteral("\n        </th>\n\n        <th></th>\n    </tr>\n\n");
            EndContext();
#line 33 "/Users/bruno/Projetos/net-core/Immobile.MapaDeErros/Immobile.MapaDeErros/Views/Funcao/Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(688, 34, true);
            WriteLiteral("    <tr>\n        <td>\n            ");
            EndContext();
            BeginContext(723, 39, false);
#line 36 "/Users/bruno/Projetos/net-core/Immobile.MapaDeErros/Immobile.MapaDeErros/Views/Funcao/Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(762, 40, true);
            WriteLiteral("\n        </td>\n        <td>\n            ");
            EndContext();
            BeginContext(803, 41, false);
#line 39 "/Users/bruno/Projetos/net-core/Immobile.MapaDeErros/Immobile.MapaDeErros/Views/Funcao/Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(844, 40, true);
            WriteLiteral("\n        </td>\n        <td>\n            ");
            EndContext();
            BeginContext(885, 46, false);
#line 42 "/Users/bruno/Projetos/net-core/Immobile.MapaDeErros/Immobile.MapaDeErros/Views/Funcao/Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.DataCriacao));

#line default
#line hidden
            EndContext();
            BeginContext(931, 40, true);
            WriteLiteral("\n        </td>\n        <td>\n            ");
            EndContext();
            BeginContext(972, 47, false);
#line 45 "/Users/bruno/Projetos/net-core/Immobile.MapaDeErros/Immobile.MapaDeErros/Views/Funcao/Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.DataAtivacao));

#line default
#line hidden
            EndContext();
            BeginContext(1019, 40, true);
            WriteLiteral("\n        </td>\n        <td>\n            ");
            EndContext();
            BeginContext(1060, 50, false);
#line 48 "/Users/bruno/Projetos/net-core/Immobile.MapaDeErros/Immobile.MapaDeErros/Views/Funcao/Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.DataDesativacao));

#line default
#line hidden
            EndContext();
            BeginContext(1110, 40, true);
            WriteLiteral("\n        </td>\n        <td>\n            ");
            EndContext();
            BeginContext(1151, 51, false);
#line 51 "/Users/bruno/Projetos/net-core/Immobile.MapaDeErros/Immobile.MapaDeErros/Views/Funcao/Index.cshtml"
       Write(Html.ActionLink("Edit", "Edit", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1202, 15, true);
            WriteLiteral(" |\n            ");
            EndContext();
            BeginContext(1218, 57, false);
#line 52 "/Users/bruno/Projetos/net-core/Immobile.MapaDeErros/Immobile.MapaDeErros/Views/Funcao/Index.cshtml"
       Write(Html.ActionLink("Details", "Details", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1275, 15, true);
            WriteLiteral(" |\n            ");
            EndContext();
            BeginContext(1291, 55, false);
#line 53 "/Users/bruno/Projetos/net-core/Immobile.MapaDeErros/Immobile.MapaDeErros/Views/Funcao/Index.cshtml"
       Write(Html.ActionLink("Delete", "Delete", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1346, 25, true);
            WriteLiteral("\n        </td>\n    </tr>\n");
            EndContext();
#line 56 "/Users/bruno/Projetos/net-core/Immobile.MapaDeErros/Immobile.MapaDeErros/Views/Funcao/Index.cshtml"
}

#line default
#line hidden
            BeginContext(1373, 10, true);
            WriteLiteral("\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Immobile.MapaDeErros.Models.Funcao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
