#pragma checksum "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "413fb9bdae8b90e149a0127380746cacbf99da6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_New), @"mvc.1.0.view", @"/Views/Search/New.cshtml")]
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
#line 1 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\_ViewImports.cshtml"
using NockNock;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\_ViewImports.cshtml"
using NockNock.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"413fb9bdae8b90e149a0127380746cacbf99da6a", @"/Views/Search/New.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68296fcad83d6278540d58756b812845f630759d", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NockNock.Models.PostModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\New.cshtml"
  
    Layout = "_Layout3";
    ViewBag.Title = "Search Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 9 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\New.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                Post ID = ");
#nullable restore
#line 13 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\New.cshtml"
                     Write(item.PostID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div>\r\n                    User ID = ");
#nullable restore
#line 15 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\New.cshtml"
                         Write(item.ProfileID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    Post Content = ");
#nullable restore
#line 18 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\New.cshtml"
                              Write(item.PostContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    Date = ");
#nullable restore
#line 21 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\New.cshtml"
                      Write(item.PostDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 24 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\New.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NockNock.Models.PostModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
