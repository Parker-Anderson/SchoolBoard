#pragma checksum "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3641873987da5a115b699062626681317d7adb6b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3641873987da5a115b699062626681317d7adb6b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb4652b2b3890ce474051464f6b98c8f5eae9cb2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SchoolBoard.Models.HomeModels.HomeIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("instructorHomeSearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search SchoolBoard..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"
 if (!User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class="" container body-content"">
        <div class=""row frontPageSplash"">
            <div class=""col-md-6 frontPageCollab"">
                <div class=""frontPageHeading""></div>
                <p style=""font-size: larger"" class=""homeSubHeading"">SchoolBoard is a Hub for Collaboration</p>
            </div>
            <div class=""btn-link"" id=""homeRegBtn"">Educators - Get Started</div>
            <div class=""col-md-6""></div>
        </div>
    </div>
");
#nullable restore
#line 16 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"
 if (User.Identity.IsAuthenticated && User.IsInRole("Instructor"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h2 style=""color:ghostwhite""></h2>
    <div class="" container body-content"">
        <div class=""row frontPageSplash"">
            <div class=""col-md-6 frontPageCollab"">
                <div class=""frontPageHeading""></div>
                <p style=""font-size: larger"" class=""homeSubHeading"">Hi ");
#nullable restore
#line 24 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"
                                                                  Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3641873987da5a115b699062626681317d7adb6b8296", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3641873987da5a115b699062626681317d7adb6b8578", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 27 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchQuery);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-md-6""></div>
        </div>
        <div class=""row instructorHomeContent"">
            <h5 id=""recentActivity"">Recent Activity</h5>
            <table class=""table table-borderless"" id=""latestPostsTable"">
                <tbody>
");
#nullable restore
#line 37 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"
                     foreach (var post in Model.RecentPosts)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <div class=\"studentImg\"");
            BeginWriteAttribute("style", " style=\"", 1759, "\"", 1832, 5);
            WriteAttributeValue("", 1767, "background-image:", 1767, 17, true);
            WriteAttributeValue(" ", 1784, "url(", 1785, 5, true);
#nullable restore
#line 41 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 1789, post.Student.ImgUrl, 1789, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1809, ");", 1809, 2, true);
            WriteAttributeValue(" ", 1811, "background-size=100%", 1812, 21, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                <div class=\"recentPostTitle\">\r\n                                    <span>");
#nullable restore
#line 43 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"
                                     Write(post.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3641873987da5a115b699062626681317d7adb6b13768", async() => {
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 45 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"
                                   Write(post.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"
                                                                                  WriteLiteral(post.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"postSubTitle\">\r\n");
#nullable restore
#line 49 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"
                                     if (post.RepliesCount == 1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>");
#nullable restore
#line 51 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"
                                         Write(post.RepliesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Reply</span>\r\n");
#nullable restore
#line 52 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"
                                     if (post.RepliesCount == 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>No Replies</span>\r\n");
#nullable restore
#line 56 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>");
#nullable restore
#line 59 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"
                                         Write(post.RepliesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Replies</span>\r\n");
#nullable restore
#line 60 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"postUser\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3641873987da5a115b699062626681317d7adb6b18534", async() => {
                WriteLiteral("\r\n                                            ");
#nullable restore
#line 63 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"
                                       Write(post.Author.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"
                                                                                          WriteLiteral(post.AuthorId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </span>\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 69 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 75 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"
Write(Html.ActionLink("Your Courses", "MyCourses", "Course"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"
                                                           

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 79 "D:\SchoolBoard\SchoolBoard.MVC\Views\Home\Index.cshtml"
 if (User.Identity.IsAuthenticated && User.IsInRole("Administrator"))
{
    


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolBoard.Models.HomeModels.HomeIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
