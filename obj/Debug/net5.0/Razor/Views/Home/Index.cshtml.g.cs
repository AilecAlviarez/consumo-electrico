#pragma checksum "/home/yoyo/Documentos/code/diego/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc2f0c24cc04f2845fdb316be237d6ba0a2403b9"
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
#line 1 "/home/yoyo/Documentos/code/diego/Views/_ViewImports.cshtml"
using diego;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/yoyo/Documentos/code/diego/Views/_ViewImports.cshtml"
using diego.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc2f0c24cc04f2845fdb316be237d6ba0a2403b9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5346ebd494b519a655ce39a65b400fface027dfc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/yoyo/Documentos/code/diego/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Consumo Electrico</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc2f0c24cc04f2845fdb316be237d6ba0a2403b93685", async() => {
                WriteLiteral(@"
        <div class=""container"">
            <div class=""row"">
                 <h3 class=""h3 text-center"" >Nombre del Cliente</h3>
                   <input type=""text"" class=""form-control"" id=""name"" placeholder=""nombre del cliente"">

            </div>

        </div>
        <div class=""container"">
        <span class=""my-4"">datos mensuales de medicion del Consumo</span>
                    <hr>
        </div>
        
                    
      
        <div class=""container-fluid"">
            <h4>tipo de Comercio</h4>
           <div class=""form-check"">
  <input class=""form-check-input"" type=""radio"" name=""flexRadioDefault"" id=""flexRadioDefault1"">
  <label class=""form-check-label"" for=""flexRadioDefault1"">
    Residencial
  </label>
</div>
<div class=""form-check"">
  <input class=""form-check-input"" type=""radio"" name=""flexRadioDefault"" id=""flexRadioDefault2"" checked>
  <label class=""form-check-label mr-2"" for=""flexRadioDefault2"">
    Comercio
  </label>
</div>

        </div>");
                WriteLiteral(@"
       
          <h3>Lectura Inicial</h3>
        <input class=""form-control form-control-lg"" type=""text"" placeholder=""consumo inicial"" aria-label="".form-control-lg example"">

          <h3>Lectura Final</h3>
          <input class=""form-control form-control-lg"" type=""text"" placeholder=""consumo final"" aria-label="".form-control-lg example"">
        <div class=""container"">
          <h3>Consumo</h3>
          <input class=""form-control form-control-lg"" type=""text"" placeholder=""consumo en vatios"" id=""consumo"" aria-label="".form-control-lg example"">
        </div>
        <button class=""btn btn-info my-5 ml-5 mr-5"">salir</button>
        <button type=""submit"" class=""btn btn-info my-5 ml-5 mr-5"" id=""send_info"">cancelar</button>
        <div class=""container my-2"">
          <div class=""span"" id=""monto""></div>

        </div>

    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <script>
        const nombreCliente=document.getElementById(""name"")
        const boton=document.getElementById(""send_info"")
        const consumo=document.getElementById(""consumo"")
        const comercio=document.getElementById(""flexRadioDefault2"")
        const CONSUMO_RESIDENCIAL=0.3;
        const CONSUMO_COMERCIAL=0.2;
        boton.addEventListener(""click"",(e)=>{
            e.preventDefault();
            //si es false es residencial
            let tipo_comercio=comercio.value=='on'?true:false;
            let objeto={
              name:nombreCliente.value,
              consumo:consumo.value,
              tipo_comercio
              
            }
          
            let tipo =objeto.tipo_comercio?CONSUMO_COMERCIAL:CONSUMO_RESIDENCIAL
            let monto=objeto.consumo*tipo
            const montoDiv=document.getElementById(""monto"")
            montoDiv.innerHTML=monto
            

        })
        
        
    </script>
</div>
");
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
