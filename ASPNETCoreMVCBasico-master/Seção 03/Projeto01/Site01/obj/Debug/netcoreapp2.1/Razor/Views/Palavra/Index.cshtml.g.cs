#pragma checksum "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bf65e4262a487e8cd79d3bc6b3a03b32e780d00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Palavra_Index), @"mvc.1.0.view", @"/Views/Palavra/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Palavra/Index.cshtml", typeof(AspNetCore.Views_Palavra_Index))]
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
#line 2 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 3 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Index.cshtml"
using X.PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bf65e4262a487e8cd79d3bc6b3a03b32e780d00", @"/Views/Palavra/Index.cshtml")]
    public class Views_Palavra_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<Site01.Models.Palavra>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(102, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 5 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Index.cshtml"
  
    //Layout  = "_Layout";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 9 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Index.cshtml"
  
    ViewBag.Title = "Palavra - Listagem";

#line default
#line hidden
#line 12 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Index.cshtml"
 if (TempData["Mensagem"] != null)
{

#line default
#line hidden
            BeginContext(265, 59, true);
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\n        ");
            EndContext();
            BeginContext(325, 20, false);
#line 15 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Index.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(345, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
#line 17 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Index.cshtml"
}

#line default
#line hidden
            BeginContext(359, 171, true);
            WriteLiteral("\n<link href=\"/css/PagedList.css\" rel=\"stylesheet\" type=\"text/css\" />\n\n<a href=\"/palavra/cadastrar\" class=\"btn btn-primary\">Cadastrar</a>\n\n<span><b>Total de registros:</b> ");
            EndContext();
            BeginContext(531, 20, false);
#line 23 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Index.cshtml"
                            Write(Model.TotalItemCount);

#line default
#line hidden
            EndContext();
            BeginContext(551, 266, true);
            WriteLiteral(@"</span>
<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Palavra</th>
            <th scope=""col"">Nível</th>
            <th scope=""col"">Ação</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 34 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Index.cshtml"
         foreach (var palavra in Model)
        {

#line default
#line hidden
            BeginContext(867, 49, true);
            WriteLiteral("            <tr>\n                <th scope=\"row\">");
            EndContext();
            BeginContext(917, 10, false);
#line 37 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Index.cshtml"
                           Write(palavra.Id);

#line default
#line hidden
            EndContext();
            BeginContext(927, 26, true);
            WriteLiteral("</th>\n                <td>");
            EndContext();
            BeginContext(954, 12, false);
#line 38 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Index.cshtml"
               Write(palavra.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(966, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(993, 13, false);
#line 39 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Index.cshtml"
               Write(palavra.Nivel);

#line default
#line hidden
            EndContext();
            BeginContext(1006, 49, true);
            WriteLiteral("</td>\n                <td>\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1055, "\"", 1092, 2);
            WriteAttributeValue("", 1062, "/palavra/atualizar/", 1062, 19, true);
#line 41 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Index.cshtml"
WriteAttributeValue("", 1081, palavra.Id, 1081, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1093, 46, true);
            WriteLiteral(" class=\"btn\">Editar</a>\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1139, "\"", 1174, 2);
            WriteAttributeValue("", 1146, "/palavra/excluir/", 1146, 17, true);
#line 42 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Index.cshtml"
WriteAttributeValue("", 1163, palavra.Id, 1163, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1175, 65, true);
            WriteLiteral(" class=\"btn\">Excluir</a>\n                </td>\n            </tr>\n");
            EndContext();
#line 45 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1250, 23, true);
            WriteLiteral("    </tbody>\n</table>\n\n");
            EndContext();
            BeginContext(1274, 81, false);
#line 49 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<Site01.Models.Palavra>> Html { get; private set; }
    }
}
#pragma warning restore 1591
