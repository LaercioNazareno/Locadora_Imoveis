#pragma checksum "/home/laercio/Projetos/Dotnet/Locadora_Imoveis/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ac8285389bea2ad026764180f2ebc41669d917e"
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
#line 1 "/home/laercio/Projetos/Dotnet/Locadora_Imoveis/Views/_ViewImports.cshtml"
using locadora;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/laercio/Projetos/Dotnet/Locadora_Imoveis/Views/_ViewImports.cshtml"
using locadora.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ac8285389bea2ad026764180f2ebc41669d917e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c7ca848994b0f7fe189c23b80695b3ff9669f65", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/laercio/Projetos/Dotnet/Locadora_Imoveis/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Bem vindo</h1>
    <p>Esse é um aplicativo de gestão de Imobiliaria.</p>
    <div>
        <p>
            Para realizar esse projeto, utilizei o dotnet com a versão 5.0 para implementar as seguintes funcionalidades:
        </p>
        <p>Gestão de Clientes</p>
        <p>Gestão de Cobrnças</p>
        <p>Gestão de Imoveis</p>
        <p>Gestão dos Contratos<p>
    </div>
    <div>
        <p>
            No processo de desenvolvimento utilizei o Padrão de Projeto, Injeção de Independêcia com o EntityFramework. Para a modelagem do <br/>
            banco de dados utilizei uma técnica de code first, assim a modelagem do banco de dados é o reflexo do diagrama de classes,<br/>
            a documentação está disponivel no projeto. A instancia do banco está publicada na Azure assim como esse projeto. 
        </p>
        <p>
            O codigo fonte está disponivel no <a href=""https://github.com/LaercioNazareno/Locadora_Imoveis"">GitHub<");
            WriteLiteral("/a>\r\n        </p>\r\n    </div>\r\n</div>\r\n");
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
