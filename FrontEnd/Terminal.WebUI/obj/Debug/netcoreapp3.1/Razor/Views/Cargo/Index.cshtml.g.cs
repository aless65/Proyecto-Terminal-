#pragma checksum "C:\Users\Chris\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cargo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e1dfeb68360634ce839a496c3bb8bb1dd7fbbce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cargo_Index), @"mvc.1.0.view", @"/Views/Cargo/Index.cshtml")]
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
#line 1 "C:\Users\Chris\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\_ViewImports.cshtml"
using Terminal.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Chris\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\_ViewImports.cshtml"
using Terminal.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e1dfeb68360634ce839a496c3bb8bb1dd7fbbce", @"/Views/Cargo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acbe80c8ae054dc5357aa4687981182e4e6d61f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Cargo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Terminal.WebUI.Models.CargosViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Chris\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cargo\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header""><h1>Cargo</h1></div>
    <div class=""card-body"">

        <p>
            <a onclick=""AbrirModalCreate()"" class=""btn btn-outline-primary"">Nuevo</a>
        </p>
        <table class=""table"" style=""color: black;"">
            <thead>
                <tr>
                    <th>
                        ");
#nullable restore
#line 19 "C:\Users\Chris\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cargo\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.carg_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 22 "C:\Users\Chris\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cargo\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.carg_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>Acciones</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\Chris\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cargo\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 32 "C:\Users\Chris\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cargo\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.carg_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 35 "C:\Users\Chris\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cargo\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.carg_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <a class=\"btn btn-outline-warning Editar\" data-id=\"");
#nullable restore
#line 38 "C:\Users\Chris\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cargo\Index.cshtml"
                                                                          Write(item.carg_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-nombre=\"");
#nullable restore
#line 38 "C:\Users\Chris\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cargo\Index.cshtml"
                                                                                                      Write(item.carg_Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Editar</a>\r\n                            <a class=\"btn btn-outline-dark\">Detalles</a> |\r\n                            <button class=\"btn btn-outline-danger\" id=\"btnEliminar\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1508, "\"", 1543, 3);
            WriteAttributeValue("", 1518, "eliminar(\'", 1518, 10, true);
#nullable restore
#line 40 "C:\Users\Chris\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cargo\Index.cshtml"
WriteAttributeValue("", 1528, item.carg_ID, 1528, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1541, "\')", 1541, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Eliminar</button>\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Chris\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cargo\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 51 "C:\Users\Chris\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cargo\Index.cshtml"
Write(Html.Partial("_Modal_Create", new Terminal.WebUI.Models.CargosViewModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 52 "C:\Users\Chris\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cargo\Index.cshtml"
Write(Html.Partial("_Modal_Edit", new Terminal.WebUI.Models.CargosViewModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\Chris\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cargo\Index.cshtml"
Write(Html.Partial("_Modal_Delete", new Terminal.WebUI.Models.CargosViewModel()));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Terminal.WebUI.Models.CargosViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
