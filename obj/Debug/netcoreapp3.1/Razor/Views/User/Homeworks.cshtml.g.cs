#pragma checksum "C:\Users\DonEn\Desktop\Git\StudyGroup\Views\User\Homeworks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "639df246be26be8d275aa5ecbe297931bf6e5119"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Homeworks), @"mvc.1.0.view", @"/Views/User/Homeworks.cshtml")]
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
#line 1 "C:\Users\DonEn\Desktop\Git\StudyGroup\Views\_ViewImports.cshtml"
using StudyGroup;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DonEn\Desktop\Git\StudyGroup\Views\User\Homeworks.cshtml"
using StudyGroup.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"639df246be26be8d275aa5ecbe297931bf6e5119", @"/Views/User/Homeworks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a75bc9aaf8afb41446876bcee6ebcc281a3752", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Homeworks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DonEn\Desktop\Git\StudyGroup\Views\User\Homeworks.cshtml"
 foreach (var homework in ViewBag.Homeworks)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\" style=\"width: 18rem;\">\r\n        <img class=\"card-img-top\" src=\"...\" alt=\"Card image cap\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 8 "C:\Users\DonEn\Desktop\Git\StudyGroup\Views\User\Homeworks.cshtml"
                              Write(homework.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">Дата завершения: ");
#nullable restore
#line 9 "C:\Users\DonEn\Desktop\Git\StudyGroup\Views\User\Homeworks.cshtml"
                                             Write(homework.dateEnd);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        </div>\r\n        <ul class=\"list-group list-group-flush\">\r\n            <li class=\"list-group-item\">Оценка:");
#nullable restore
#line 12 "C:\Users\DonEn\Desktop\Git\StudyGroup\Views\User\Homeworks.cshtml"
                                          Write(homework.assessment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        </ul>\r\n        <div class=\"card-body\">\r\n            <a href=\"#\" class=\"card-link\">Открыть </a>\r\n            <a href=\"#\" class=\"card-link\">Задать вопрос</a>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 19 "C:\Users\DonEn\Desktop\Git\StudyGroup\Views\User\Homeworks.cshtml"
    
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
