#pragma checksum "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Home\CadLogin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df032ac28aa893530c0c241cc403d4ccd9c60f14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CadLogin), @"mvc.1.0.view", @"/Views/Home/CadLogin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CadLogin.cshtml", typeof(AspNetCore.Views_Home_CadLogin))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df032ac28aa893530c0c241cc403d4ccd9c60f14", @"/Views/Home/CadLogin.cshtml")]
    public class Views_Home_CadLogin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Home\CadLogin.cshtml"
  
    ViewData["Title"] = "CadLogin";

#line default
#line hidden
#line 5 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Home\CadLogin.cshtml"
   //Layout  = "_Layout";
                Layout = "~/Views/Shared/_Layout.cshtml"; 
    

#line default
#line hidden
            BeginContext(140, 244, true);
            WriteLiteral("<form method=\"post\" action=\"/home/Cadlogin\">\r\n    <div class=\"form-group\">\r\n        <label for=\"email\">E-mail</label>\r\n        <input type=\"text\" name=\"email\" value=\"\" class=\"form-control\" id=\"email\" placeholder=\"Digite o seu e-mail\">\r\n        ");
            EndContext();
            BeginContext(385, 31, false);
#line 12 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Home\CadLogin.cshtml"
   Write(Html.ValidationMessage("email"));

#line default
#line hidden
            EndContext();
            BeginContext(416, 214, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"senha\">Senha</label>\r\n        <input type=\"password\" name=\"senha\" value=\"\" class=\"form-control\" id=\"senha\" placeholder=\"Digite o sua senha\">\r\n        ");
            EndContext();
            BeginContext(631, 31, false);
#line 17 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Home\CadLogin.cshtml"
   Write(Html.ValidationMessage("senha"));

#line default
#line hidden
            EndContext();
            BeginContext(662, 90, true);
            WriteLiteral("\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Enviar</button>\r\n</form>\r\n");
            EndContext();
            BeginContext(753, 16, false);
#line 21 "C:\Users\Lucas\Desktop\SlidesProvas\ASPNETCoreMVCBasico-master\ASPNETCoreMVCBasico-master\Seção 03\Projeto01\Site01\Views\Home\CadLogin.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(769, 2, true);
            WriteLiteral("\r\n");
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
