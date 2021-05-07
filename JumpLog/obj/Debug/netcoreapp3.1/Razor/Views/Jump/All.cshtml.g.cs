#pragma checksum "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Jump/All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bdfef535bb68e0239c809e48c90a598281efb8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jump_All), @"mvc.1.0.view", @"/Views/Jump/All.cshtml")]
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
#line 1 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/_ViewImports.cshtml"
using JumpLog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/_ViewImports.cshtml"
using JumpLog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bdfef535bb68e0239c809e48c90a598281efb8a", @"/Views/Jump/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"539ad4111112420b1b7a20e986b3b68300bce587", @"/Views/_ViewImports.cshtml")]
    public class Views_Jump_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JumpLog.Models.Jump>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bdfef535bb68e0239c809e48c90a598281efb8a3139", async() => {
                WriteLiteral(@"

    <div class=""section tracker text-center"">
        <h1>All Jumps</h1>
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">Date</th>
                    <th scope=""col"">Location</th>
                    <th scope=""col"">Aircraft</th>
                </tr>
            </thead>

            <tbody>
");
#nullable restore
#line 20 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Jump/All.cshtml"
              
                int count = 0;
                foreach (var jump in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\n                    <td scope=\"col\">");
#nullable restore
#line 25 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Jump/All.cshtml"
                               Write(jump.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 26 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Jump/All.cshtml"
                               Write(jump.Location);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 27 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Jump/All.cshtml"
                               Write(jump.Aircraft);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 28 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Jump/All.cshtml"
                               Write(Html.ActionLink($"Edit", "Edit", new { id = count }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 29 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Jump/All.cshtml"
                               Write(Html.ActionLink($"Delete", "Delete", new { id = count }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 31 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Jump/All.cshtml"
                    count++;
                }
             

#line default
#line hidden
#nullable disable
                WriteLiteral("             </tbody>\n            </table>\n\n        <!-- using HTML helpers for links -->\n        ");
#nullable restore
#line 38 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Jump/All.cshtml"
   Write(Html.ActionLink("Add New Jump", "Add", new { id = 3 }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </div>\n\n");
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
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JumpLog.Models.Jump>> Html { get; private set; }
    }
}
#pragma warning restore 1591
