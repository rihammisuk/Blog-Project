#pragma checksum "D:\Blog.Web\Blog.Web\Areas\Admin\Views\Shared\_ActionMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae2180a90ea38c3eea51967bd5d0f1a6d37a1f54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__ActionMessage), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_ActionMessage.cshtml")]
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
#line 1 "D:\Blog.Web\Blog.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Blog.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Blog.Web\Blog.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Blog.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Blog.Web\Blog.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Blog.Web.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae2180a90ea38c3eea51967bd5d0f1a6d37a1f54", @"/Areas/Admin/Views/Shared/_ActionMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b661171f7a41b9c382a6bf063bce08bbba68933", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__ActionMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResponseModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Blog.Web\Blog.Web\Areas\Admin\Views\Shared\_ActionMessage.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 56, "\"", 108, 3);
            WriteAttributeValue("", 64, "alert", 64, 5, true);
            WriteAttributeValue(" ", 69, "alert-dismissible", 70, 18, true);
#nullable restore
#line 5 "D:\Blog.Web\Blog.Web\Areas\Admin\Views\Shared\_ActionMessage.cshtml"
WriteAttributeValue(" ", 87, Model.StyleCssClass, 88, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button>\r\n        <h5><i");
            BeginWriteAttribute("class", " class=\"", 228, "\"", 264, 3);
            WriteAttributeValue("", 236, "icon", 236, 4, true);
            WriteAttributeValue(" ", 240, "fas", 241, 4, true);
#nullable restore
#line 7 "D:\Blog.Web\Blog.Web\Areas\Admin\Views\Shared\_ActionMessage.cshtml"
WriteAttributeValue(" ", 244, Model.IconCssClass, 245, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> ");
#nullable restore
#line 7 "D:\Blog.Web\Blog.Web\Areas\Admin\Views\Shared\_ActionMessage.cshtml"
                                                    Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        ");
#nullable restore
#line 8 "D:\Blog.Web\Blog.Web\Areas\Admin\Views\Shared\_ActionMessage.cshtml"
   Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 10 "D:\Blog.Web\Blog.Web\Areas\Admin\Views\Shared\_ActionMessage.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResponseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
