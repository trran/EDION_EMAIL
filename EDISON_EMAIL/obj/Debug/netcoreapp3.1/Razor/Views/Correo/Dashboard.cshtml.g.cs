#pragma checksum "C:\Users\HP\source\repos\EDISON_EMAIL\EDISON_EMAIL\Views\Correo\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "869b2ac3c1970494aa7843b7f1102bc26f06a61c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Correo_Dashboard), @"mvc.1.0.view", @"/Views/Correo/Dashboard.cshtml")]
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
#line 1 "C:\Users\HP\source\repos\EDISON_EMAIL\EDISON_EMAIL\Views\_ViewImports.cshtml"
using EDISON_EMAIL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\EDISON_EMAIL\EDISON_EMAIL\Views\_ViewImports.cshtml"
using EDISON_EMAIL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"869b2ac3c1970494aa7843b7f1102bc26f06a61c", @"/Views/Correo/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9569f3bea97cae1e6b79dd1f6c4b70097d95f7f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Correo_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\HP\source\repos\EDISON_EMAIL\EDISON_EMAIL\Views\Correo\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "869b2ac3c1970494aa7843b7f1102bc26f06a61c3521", async() => {
                WriteLiteral(@"
    <title>Dashboard</title>
    <script src=""https://code.jquery.com/jquery-3.5.1.js"" integrity=""sha256-QWo7LDvxbWT2tbbQ97B53yJnYU3WhH/C8ycbRAkjPDc="" crossorigin=""anonymous""></script>
    <script src=""//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/alertify.min.js""></script>
    <!-- CSS -->
    <link rel=""stylesheet"" href=""//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/css/alertify.min.css"" />
    <!-- Default theme -->
    <link rel=""stylesheet"" href=""//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/css/themes/default.min.css"" />
    <!-- Semantic UI theme -->
    <link rel=""stylesheet"" href=""//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/css/themes/semantic.min.css"" />
    <!-- Bootstrap theme -->
    <link rel=""stylesheet"" href=""//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/css/themes/bootstrap.min.css"" />
    <link rel=""stylesheet"" href=""//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/css/alertify.rtl.min.css"" />
    <!-- Default theme -->
    <link rel=""stylesheet"" href=""//cdn.jsdelivr.net/");
                WriteLiteral(@"npm/alertifyjs@1.13.1/build/css/themes/default.rtl.min.css"" />
    <!-- Semantic UI theme -->
    <link rel=""stylesheet"" href=""//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/css/themes/semantic.rtl.min.css"" />
    <!-- Bootstrap theme -->
    <link rel=""stylesheet"" href=""//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/css/themes/bootstrap.rtl.min.css"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "869b2ac3c1970494aa7843b7f1102bc26f06a61c5945", async() => {
                WriteLiteral(@"
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-3"">
                <h2 id=""hola"">
                   
                </h2>
                <ul>
                    <li class=""menu"" onclick=""enviar_correo()"">Enviar Correo</li>
                    <li class=""menu"" onclick=""correos_enviados()"">Enviados</li>
                    <li class=""menu"" onclick=""correos_recibidos()"">Recibidos</li>
                    <li class=""menu"" onclick=""leer_spam()"">Spam</li>
                    <li class=""menu"" onclick=""Cerrar_sesion()"">Cerrar Sesion</li>

                </ul>

            </div>
            <div class=""col-md-9"">
            
                <input type=""hidden"" id=""id_correo""");
                BeginWriteAttribute("value", " value=\"", 2246, "\"", 2276, 1);
#nullable restore
#line 46 "C:\Users\HP\source\repos\EDISON_EMAIL\EDISON_EMAIL\Views\Correo\Dashboard.cshtml"
WriteAttributeValue("", 2254, TempData["id_correo"], 2254, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <h3>Bandeja de correos recibidos</h3><hr />\r\n                <div>\r\n                    <ul id=\"correos\">\r\n\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>
<script>
    

    function Cerrar_sesion() {
        localStorage.clear();
        window.location.href = '/'

    }

    function Redirect_toFile(url) {

        window.location = url;
    }

    function ver_correo_modal(nombre, apellido, nombre_correo, asunto, descripcion, ruta_archivo) {
        let ruta_de_archivo = ""https://localhost:44309/Adjuntos/""+ruta_archivo;
        alertify.alert(""EDISON EMAIL"", `
               <p>Recibido de : <strong>${nombre_correo}</strong></p> 
               <p>Asunto : ${asunto}</p></hr>
               <p>Cuerpo correo: ${descripcion}</p></br>
               <strong>Archivo Adjunto</strong></br>
               <img src=""${ruta_de_archivo}"" width=""150"" />
        `, function () { });
    }
    function enviar_correo() {
        let id_correo = $('#id_correo').val();

        alertify.alert('Enviar correo', `
                <form id='enviar_nuevo_correo' method='post' enctype='multipart/form-data' action='enviar_correos'>
          ");
            WriteLiteral(@"      <input tpye='text' requerid="""" name='titulo' class='form-control' id='asunto' placeholder='asunto del correo'><br/>
                <textarea class='form-control' name='descripcion' requerid="""" id='texto'></textarea><br></hr>
                <p>Destinario</p></br>
                <input type='hidden' name='id_emisor' value=""${localStorage.getItem('id_correo')}"">
                <input type='text' requerid="""" name='correo_resector' class='form-control' id='destinario'/></br>
                <p>Subir archivo</p></br>
                <input type='file' name='file' class='form-control'/>
                <button type='submit' class='btn btn-dark'>Enviar correo</button>
                </form>

         `, function () {



                if ($('#asunto').val() != """" && $('#destinario').val() != """" && $('#texto').val() != """") {
                   /* var formData = new FormData($('#enviar_nuevo_correo')[0]);

                    $.ajax({
                        url: '/Correo/enviar_correos',
            WriteLiteral(@"
                        method:'post',
                        data: {
                            titulo: $('#asunto').val(),
                            descripcion: $('#texto').val(),
                            id_emisor: $('#id_correo').val(),
                            correo_resector: $('#destinario').val()
                        }


                    }).done(data => {

                        alertify.message(data);
                    });
                    */
                } else {

                    alertify.message(""Faltan campos por llenar"");
                }


        });

    }

    function leer_spam() {

        $.ajax({
            url: '/Correo/Correos_Spam',
            type: 'post',
            data: {
                id_correo: localStorage.getItem(""id_correo"")
            }

        }).done(data => {
            let correos = """";
            data.forEach(data => {

                correos += `<li class=""correos"" onclick=""ver_correo_modal('");
            WriteLiteral(@"${data.nombre}','${data.apellido}','${data.correo_emisor}','${data.titulo}','${data.descripcion},'${data.ruta_archivo}')"">""${data.nombre}"" / ${data.titulo} ${data.descripcion}</li><hr/>`;

            });

            $('#correos').html(correos);

        });



    }

    function correos_enviados() {

        $.ajax({
            url: '/Correo/leer_correos',
            type: 'post',
            data: {
                id_correo: localStorage.getItem(""id_correo""),
                config:null
            }

        }).done(data => {
            let correos = """";
            data.forEach(data => {

                correos += `<li class=""correos"" onclick=""ver_correo_modal('${data.nombre}','${data.apellido}','${data.correo_emisor}','${data.titulo}','${data.descripcion}','${data.ruta_archivo}')"">""${data.nombre}"" / ${data.titulo} ${data.descripcion}</li><hr/>`;

            });

            $('#correos').html(correos);

        });


    }

 

    function correos_recibidos(");
            WriteLiteral(@") {

        $.ajax({
            url: '/Correo/leer_correos',
            type: 'post',
            data: {
                id_correo: localStorage.getItem(""id_correo""),
                config:'leer_recibidos'
            }

        }).done(data => {
            let correos = """";
            data.forEach(data => {

                correos += `<li class=""correos"" onclick=""ver_correo_modal('${data.nombre}','${data.apellido}','${data.correo_emisor}','${data.titulo}','${data.descripcion}','${data.ruta_archivo}')"">""${data.nombre}"" / ${data.titulo} ${data.descripcion}</li><hr/>`;


            });

            $('#correos').html(correos);

        });


    }
    $('document').ready(function () {
        if (typeof (Storage) !== ""undefined"") {
            // LocalStorage disponible
        } else {
            // LocalStorage no soportado en este navegador
        }
        if (localStorage.getItem(""nombre"") === null) {

            localStorage.setItem(""nombre"", """);
#nullable restore
#line 217 "C:\Users\HP\source\repos\EDISON_EMAIL\EDISON_EMAIL\Views\Correo\Dashboard.cshtml"
                                       Write(TempData["nombre"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n            localStorage.setItem(\'id_correo\', \"");
#nullable restore
#line 218 "C:\Users\HP\source\repos\EDISON_EMAIL\EDISON_EMAIL\Views\Correo\Dashboard.cshtml"
                                          Write(TempData["id_correo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""");
        }
    
        var nombre = localStorage.getItem(""nombre"");
        var id_correo = localStorage.getItem(""id_correo"");

        $('#hola').html(nombre);
     
        correos_recibidos();


    });

    


</script>
<style>
    ul{
       text-decoration:none;
       list-style:none
    }
    .menu {
        padding: 15px;
        background: #afb1efc7;
        border-radius: 10px;
        margin-top:5px;
        cursor:pointer;
    }

    .correos {
        padding: 5px;
        background: #ffd994;
        border-radius: 5px;
        cursor:pointer;
    }

        .menu:hover {
            background: #8182adc7;
        }



</style>

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