#pragma checksum "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d81d862e25b0f0739b6e5ac9fee87b728bedf65b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Soldier_All), @"mvc.1.0.view", @"/Views/Soldier/All.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d81d862e25b0f0739b6e5ac9fee87b728bedf65b", @"/Views/Soldier/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"539ad4111112420b1b7a20e986b3b68300bce587", @"/Views/_ViewImports.cshtml")]
    public class Views_Soldier_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JumpLog.Models.Soldier>>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d81d862e25b0f0739b6e5ac9fee87b728bedf65b3157", async() => {
                WriteLiteral(@"

    <div class=""section tracker text-center"">
        <h1>All Soldiers</h1>
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
#nullable restore
#line 25 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/All.cshtml"
              
                int count = 0;
                foreach (var soldier in Model)
                {
                

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\n                    <td scope=\"col\">");
#nullable restore
#line 31 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/All.cshtml"
                               Write(soldier.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 32 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/All.cshtml"
                               Write(soldier.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 33 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/All.cshtml"
                               Write(soldier.Rank);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 34 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/All.cshtml"
                               Write(soldier.DodId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 35 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/All.cshtml"
                               Write(soldier.Ssn);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 36 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/All.cshtml"
                               Write(soldier.Company);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 37 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/All.cshtml"
                               Write(soldier.Platoon);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 38 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/All.cshtml"
                               Write(soldier.DateArrived.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 39 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/All.cshtml"
                               Write(Html.ActionLink($"Edit", "Edit", new { id = count }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 40 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/All.cshtml"
                               Write(Html.ActionLink($"Delete", "Delete", new { id = count }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 42 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/All.cshtml"
                    count++;
                }
             

#line default
#line hidden
#nullable disable
                WriteLiteral("             </tbody>\n            </table>\n\n        <!-- using HTML helpers for links -->\n        ");
#nullable restore
#line 49 "/Users/josh/Library/Mobile Documents/com~apple~CloudDocs/MSSA/CSC395/JumpLog/JumpLog/Views/Soldier/All.cshtml"
   Write(Html.ActionLink("Add New Soldier", "Add", new { id = 3 }));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JumpLog.Models.Soldier>> Html { get; private set; }
    }
}
#pragma warning restore 1591
