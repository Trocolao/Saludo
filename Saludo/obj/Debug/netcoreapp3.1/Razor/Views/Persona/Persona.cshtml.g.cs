#pragma checksum "C:\Users\cmunozj\source\repos\Saludo\Saludo\Views\Persona\Persona.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fef74352af9e66d817d229dea5fde7acd7c5b92b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persona_Persona), @"mvc.1.0.view", @"/Views/Persona/Persona.cshtml")]
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
#line 1 "C:\Users\cmunozj\source\repos\Saludo\Saludo\Views\_ViewImports.cshtml"
using Saludo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cmunozj\source\repos\Saludo\Saludo\Views\_ViewImports.cshtml"
using Saludo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fef74352af9e66d817d229dea5fde7acd7c5b92b", @"/Views/Persona/Persona.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffd34ba6d6ab101970fd98b4226f7de29c78ac21", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Persona_Persona : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Persona>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\cmunozj\source\repos\Saludo\Saludo\Views\Persona\Persona.cshtml"
 using (Html.BeginForm("Saludo", "Persona", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 12 "C:\Users\cmunozj\source\repos\Saludo\Saludo\Views\Persona\Persona.cshtml"
   Write(Html.LabelFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 13 "C:\Users\cmunozj\source\repos\Saludo\Saludo\Views\Persona\Persona.cshtml"
   Write(Html.TextBoxFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        <input type=\"submit\" value=\"Saludar\" />\r\n    </div>\r\n");
#nullable restore
#line 19 "C:\Users\cmunozj\source\repos\Saludo\Saludo\Views\Persona\Persona.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\cmunozj\source\repos\Saludo\Saludo\Views\Persona\Persona.cshtml"
 if (Model != null && !string.IsNullOrEmpty(Model.Nombre))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ¡Hola, ");
#nullable restore
#line 24 "C:\Users\cmunozj\source\repos\Saludo\Saludo\Views\Persona\Persona.cshtml"
          Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("!\r\n    </div>\r\n");
#nullable restore
#line 26 "C:\Users\cmunozj\source\repos\Saludo\Saludo\Views\Persona\Persona.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Persona> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
