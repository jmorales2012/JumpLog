#pragma checksum "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3851ebc19e366d2a3b1e3fda0bb77c0848cbf736"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Soldier_Show), @"mvc.1.0.view", @"/Views/Soldier/Show.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3851ebc19e366d2a3b1e3fda0bb77c0848cbf736", @"/Views/Soldier/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"539ad4111112420b1b7a20e986b3b68300bce587", @"/Views/_ViewImports.cshtml")]
    public class Views_Soldier_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JumpLog.Models.Soldier>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3851ebc19e366d2a3b1e3fda0bb77c0848cbf7363149", async() => {
                WriteLiteral(@"

    <div class=""section tracker text-center"">
        <h1>Current Soldier</h1>
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">Last</th>
                    <th scope=""col"">First</th>
                    <th scope=""col"">Rank</th>
                    <th scope=""col"">DOD ID</th>
                    <th scope=""col"">SSN</th>
                    <th scope=""col"">Company</th>
                    <th scope=""col"">Platoon</th>
                    <th scope=""col"">Date Arrived</th>
                </tr>
            </thead>

            <tbody>
");
                WriteLiteral("                <tr>\n                    <td scope=\"col\">");
#nullable restore
#line 27 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/Show.cshtml"
                               Write(Model.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 28 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/Show.cshtml"
                               Write(Model.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 29 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/Show.cshtml"
                               Write(Model.Rank);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 30 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/Show.cshtml"
                               Write(Model.DodId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 31 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/Show.cshtml"
                               Write(Model.Ssn);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 32 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/Show.cshtml"
                               Write(Model.Company);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 33 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/Show.cshtml"
                               Write(Model.Platoon);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 34 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/Show.cshtml"
                               Write(Model.DateArrived.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 35 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/Show.cshtml"
                               Write(Html.ActionLink($"Edit", "Edit", new { id = ViewBag.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 36 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/Show.cshtml"
                               Write(Html.ActionLink($"Delete", "Delete", new { id = ViewBag.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                </tr>\n            </tbody>\n        </table>\n\n        <!-- using HTML helpers for links -->\n        ");
#nullable restore
#line 42 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/Show.cshtml"
   Write(Html.ActionLink("Add New Soldier", "Add"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        ");
#nullable restore
#line 43 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/Show.cshtml"
   Write(Html.ActionLink("View All Soldiers", "All"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JumpLog.Models.Soldier> Html { get; private set; }
    }
}
#pragma warning restore 1591