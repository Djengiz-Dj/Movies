#pragma checksum "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35de385671b70d115ee91eb757d60b6886998d18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Delete), @"mvc.1.0.view", @"/Views/Movie/Delete.cshtml")]
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
#line 1 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\_ViewImports.cshtml"
using Movies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\_ViewImports.cshtml"
using Movies.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35de385671b70d115ee91eb757d60b6886998d18", @"/Views/Movie/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a18b89cee963ad76943c7d00438584920fea09", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movies.Entities.Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
  
    ViewData["Title"] = "Delete";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-12"">
            <h1 class=""text-center text-capitalize""> Delete Movie</h1>
            <h5>!!! Are You Sure You want to delete Movie itself ? !!!</h5>

        </div>
    </div>
    <hr />
    <table class=""table table-bordered"">
        <tbody>
            <tr>
                <th>
                    ");
#nullable restore
#line 21 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 24 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 29 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 37 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 45 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.DateOfRelease));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayFor(model => model.DateOfRelease));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 53 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Production));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Production));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 61 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 64 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 69 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.MovieType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayFor(model => model.MovieType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 77 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 80 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 85 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Subtitles));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 88 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Subtitles));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 93 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Starring));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 96 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Starring));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 101 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Directore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 104 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Directore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 109 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 112 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 117 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.AgeRestriction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 120 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayFor(model => model.AgeRestriction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 125 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.FilmingLocations));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 128 "C:\Users\lido\Desktop\.Net(Core)\Movies\Movies\Views\Movie\Delete.cshtml"
               Write(Html.DisplayFor(model => model.FilmingLocations));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n\r\n    <div class=\"row mt-3\">\r\n        <div class=\"col-md-12\">\r\n            <button class=\"btn btn-danger\">Delete</button>\r\n        </div>\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35de385671b70d115ee91eb757d60b6886998d1813865", async() => {
                WriteLiteral("-- Back to Movie List --");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movies.Entities.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
