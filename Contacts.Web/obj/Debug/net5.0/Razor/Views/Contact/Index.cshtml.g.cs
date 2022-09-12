#pragma checksum "C:\Users\Rezov\source\repos\Imenik\Contacts.Web\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70723d8b9d8939b21c61f77aafd960b467d5295f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\Rezov\source\repos\Imenik\Contacts.Web\Views\_ViewImports.cshtml"
using Contact;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rezov\source\repos\Imenik\Contacts.Web\Views\_ViewImports.cshtml"
using Contact.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70723d8b9d8939b21c61f77aafd960b467d5295f", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdf7272f688626f8639d9d2b927c7840b8c0d369", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Services.ContactDto>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Rezov\source\repos\Imenik\Contacts.Web\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Korisnici";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">");
#nullable restore
#line 7 "C:\Users\Rezov\source\repos\Imenik\Contacts.Web\Views\Contact\Index.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70723d8b9d8939b21c61f77aafd960b467d5295f3935", async() => {
                WriteLiteral("Dodaj novog korisnika");
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
            WriteLiteral(@"
</p>
<table class=""table table-bordered"">
    <thead class=""thead-dark"">
        <tr>
            <th>
                Ime
            </th>
            <th>
                Prezime
            </th>
            <th>
                Telefonski broj
            </th>
            <th>
                Email
            </th>
            <th>
                Datum kreiranja
            </th>
            <th>
                Vrijeme kreiranja
            </th>
            <th>
                Datum promjene
            </th>
            
            <th>
                Ažuriraj
            </th>
            <th>
                Briši
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 46 "C:\Users\Rezov\source\repos\Imenik\Contacts.Web\Views\Contact\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\Rezov\source\repos\Imenik\Contacts.Web\Views\Contact\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\Rezov\source\repos\Imenik\Contacts.Web\Views\Contact\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\Rezov\source\repos\Imenik\Contacts.Web\Views\Contact\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TelephoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\Rezov\source\repos\Imenik\Contacts.Web\Views\Contact\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "C:\Users\Rezov\source\repos\Imenik\Contacts.Web\Views\Contact\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "C:\Users\Rezov\source\repos\Imenik\Contacts.Web\Views\Contact\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TimeCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "C:\Users\Rezov\source\repos\Imenik\Contacts.Web\Views\Contact\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateChanged));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <button>BOK</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 74 "C:\Users\Rezov\source\repos\Imenik\Contacts.Web\Views\Contact\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Services.ContactDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
