#pragma checksum "D:\SchoolBoard\SchoolBoard.MVC\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9f3e110ada9f69066b07f3c6fb08e738cb3d493"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
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
#line 1 "D:\SchoolBoard\SchoolBoard.MVC\Views\_ViewImports.cshtml"
using SchoolBoard.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SchoolBoard\SchoolBoard.MVC\Views\_ViewImports.cshtml"
using SchoolBoard.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9f3e110ada9f69066b07f3c6fb08e738cb3d493", @"/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb4652b2b3890ce474051464f6b98c8f5eae9cb2", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SchoolBoard.Models.PostModels.PostIndexModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 3 "D:\SchoolBoard\SchoolBoard.MVC\Views\Post\Index.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div style=\"color: ghostwhite\">\r\n    Author: ");
#nullable restore
#line 6 "D:\SchoolBoard\SchoolBoard.MVC\Views\Post\Index.cshtml"
       Write(Model.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    Created: ");
#nullable restore
#line 7 "D:\SchoolBoard\SchoolBoard.MVC\Views\Post\Index.cshtml"
        Write(Model.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div style=\"color: ghostwhite\">\r\n    ");
#nullable restore
#line 11 "D:\SchoolBoard\SchoolBoard.MVC\Views\Post\Index.cshtml"
Write(Model.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 14 "D:\SchoolBoard\SchoolBoard.MVC\Views\Post\Index.cshtml"
 if (Model.Replies.Any())
{
    foreach (var reply in Model.Replies)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"color: ghostwhite\">\r\n            Author: ");
#nullable restore
#line 19 "D:\SchoolBoard\SchoolBoard.MVC\Views\Post\Index.cshtml"
               Write(reply.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            Created: ");
#nullable restore
#line 20 "D:\SchoolBoard\SchoolBoard.MVC\Views\Post\Index.cshtml"
                Write(reply.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div style=\"color: ghostwhite\">\r\n            ");
#nullable restore
#line 24 "D:\SchoolBoard\SchoolBoard.MVC\Views\Post\Index.cshtml"
       Write(reply.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 26 "D:\SchoolBoard\SchoolBoard.MVC\Views\Post\Index.cshtml"
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolBoard.Models.PostModels.PostIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
