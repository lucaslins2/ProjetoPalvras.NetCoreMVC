#pragma checksum "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3abf7b6f2201708e9b8b626005898619aa704544"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Palavra_Cadastrar), @"mvc.1.0.view", @"/Views/Palavra/Cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Palavra/Cadastrar.cshtml", typeof(AspNetCore.Views_Palavra_Cadastrar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3abf7b6f2201708e9b8b626005898619aa704544", @"/Views/Palavra/Cadastrar.cshtml")]
    public class Views_Palavra_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Site01.Models.Palavra>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Cadastrar.cshtml"
  
    //Layout  = "_Layout";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 6 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Cadastrar.cshtml"
  
    ViewBag.Title = "Palavra - Cadastrar";

#line default
#line hidden
            BeginContext(155, 56, true);
            WriteLiteral("\n<form method=\"post\">\n    <input type=\"hidden\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 211, "\"", 228, 1);
#line 11 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Cadastrar.cshtml"
WriteAttributeValue("", 219, Model.Id, 219, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(229, 110, true);
            WriteLiteral(" />\n    <div class=\"form-group\">\n        <label for=\"nome\">Nome</label>\n        <input type=\"text\" name=\"nome\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 339, "\"", 358, 1);
#line 14 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Cadastrar.cshtml"
WriteAttributeValue("", 347, Model.Nome, 347, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(359, 73, true);
            WriteLiteral(" class=\"form-control\" id=\"nome\" placeholder=\"Digite o seu nome\">\n        ");
            EndContext();
            BeginContext(433, 30, false);
#line 15 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Cadastrar.cshtml"
   Write(Html.ValidationMessage("nome"));

#line default
#line hidden
            EndContext();
            BeginContext(463, 133, true);
            WriteLiteral("\n    </div>\n    <div class=\"form-group\">\n        <label for=\"nivel\">Nível</label>\n        <select name=\"nivel\" class=\"form-control\">\n");
            EndContext();
#line 20 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Cadastrar.cshtml"
             foreach (var nivel in ViewBag.Nivel)
            {
                

#line default
#line hidden
#line 22 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Cadastrar.cshtml"
                 if (nivel.Id == Model.Nivel)
                {

#line default
#line hidden
            BeginContext(724, 27, true);
            WriteLiteral("                    <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 751, "\"", 768, 1);
#line 24 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Cadastrar.cshtml"
WriteAttributeValue("", 759, nivel.Id, 759, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(769, 10, true);
            WriteLiteral(" selected>");
            EndContext();
            BeginContext(780, 10, false);
#line 24 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Cadastrar.cshtml"
                                                  Write(nivel.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(790, 10, true);
            WriteLiteral("</option>\n");
            EndContext();
#line 25 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Cadastrar.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(857, 27, true);
            WriteLiteral("                    <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 884, "\"", 901, 1);
#line 28 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Cadastrar.cshtml"
WriteAttributeValue("", 892, nivel.Id, 892, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(902, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(904, 10, false);
#line 28 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Cadastrar.cshtml"
                                         Write(nivel.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(914, 10, true);
            WriteLiteral("</option>\n");
            EndContext();
#line 29 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Cadastrar.cshtml"
                }

#line default
#line hidden
#line 29 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Cadastrar.cshtml"
                 

            }

#line default
#line hidden
            BeginContext(957, 69, true);
            WriteLiteral("        </select>\n        <!--<input type=\"text\" name=\"nivel\" value=\"");
            EndContext();
            BeginContext(1027, 11, false);
#line 33 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Cadastrar.cshtml"
                                              Write(Model.Nivel);

#line default
#line hidden
            EndContext();
            BeginContext(1038, 110, true);
            WriteLiteral("\" class=\"form-control\" id=\"nivel\" placeholder=\"Digite o nível: 1 - Fácil, 2 - Médio, 3 - Difícil\">-->\n        ");
            EndContext();
            BeginContext(1149, 31, false);
#line 34 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Palavra\Cadastrar.cshtml"
   Write(Html.ValidationMessage("nivel"));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 85, true);
            WriteLiteral("\n    </div>\n    <button type=\"submit\" class=\"btn btn-primary\">Salvar</button>\n</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Site01.Models.Palavra> Html { get; private set; }
    }
}
#pragma warning restore 1591
