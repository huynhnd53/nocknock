#pragma checksum "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66430a62b1d60e14490376fb68421c3872881eca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_SearchByKey), @"mvc.1.0.view", @"/Views/Search/SearchByKey.cshtml")]
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
#nullable restore
#line 1 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
using static DataLibrary.BusinessRule.FollowProcessor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
using static DataLibrary.BusinessRule.ReactionProcessor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66430a62b1d60e14490376fb68421c3872881eca", @"/Views/Search/SearchByKey.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68296fcad83d6278540d58756b812845f630759d", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_SearchByKey : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
  
    Layout = "_Layout3";
    ViewBag.Title = "Search Page";

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
  
    var post = ViewData["ListPost"] as List<NockNock.Models.PostModel>;
    var profile = ViewData["ListProfile"] as List<DataLibrary.Models.ProfileModel>;
    var key = ViewData["textSearch"] as string;
    var profileid = Context.Session.GetString("profileid") as string;
    var username = Context.Session.GetString("username") as string;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"main-content\">\r\n    <div class=\"content-wrapper\">\r\n        <h1>Results for \'");
#nullable restore
#line 18 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                    Write(key);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'</h1>\r\n        <div class=\"search-area\">\r\n            <!--Search header: Top, People, Posts-->\r\n            <div class=\"search-header\">\r\n                <ul>\r\n                    <li class=\"current\"><a");
            BeginWriteAttribute("href", " href=\"", 870, "\"", 912, 2);
            WriteAttributeValue("", 877, "/Search/SearchByKey?textSearch=", 877, 31, true);
#nullable restore
#line 23 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
WriteAttributeValue("", 908, key, 908, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Top</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 954, "\"", 1003, 2);
            WriteAttributeValue("", 961, "/Search/SearchProfileByKey?textSearch=", 961, 38, true);
#nullable restore
#line 24 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
WriteAttributeValue("", 999, key, 999, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">People</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1048, "\"", 1094, 2);
            WriteAttributeValue("", 1055, "/Search/SearchPostByKey?textSearch=", 1055, 35, true);
#nullable restore
#line 25 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
WriteAttributeValue("", 1090, key, 1090, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Posts</a></li>\r\n                </ul>\r\n            </div>\r\n            <div class=\"search-result-all\">\r\n                <!--People result-->\r\n                <div class=\"people-result\">\r\n                    <p class=\"result-header\">People</p>\r\n");
#nullable restore
#line 32 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                      
                        if (profile.Count == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>No people found!</p>\r\n");
#nullable restore
#line 36 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                        }
                        else
                        {
                            int count = 0;
                            foreach (var item in profile)
                            {

                                bool check = isFollowing(Convert.ToInt32(profileid), item.ProfileID);


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"profile\">\r\n                                    <div class=\"profile-img-wrapper\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "66430a62b1d60e14490376fb68421c3872881eca8884", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1952, "~/img/", 1952, 6, true);
#nullable restore
#line 46 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
AddHtmlAttributeValue("", 1958, item.ProfilePhoto, 1958, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                                    <div class=\"people-profile-info\">\r\n                                        <a class=\"profile-name\"");
            BeginWriteAttribute("href", " href=\"", 2127, "\"", 2173, 2);
            WriteAttributeValue("", 2134, "/Profile/ViewProfile?id=", 2134, 24, true);
#nullable restore
#line 48 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
WriteAttributeValue("", 2158, item.ProfileID, 2158, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 48 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                                                                                                          Write(item.ProfileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        <p class=\"follower\">");
#nullable restore
#line 49 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                                                       Write(item.Follower);

#line default
#line hidden
#nullable disable
            WriteLiteral(" followers</p>\r\n                                    </div>\r\n");
#nullable restore
#line 51 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                                      
                                        if (check)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"following-button\">\r\n                                                <input type=\"button\" value=\"Following\">\r\n                                            </div>\r\n");
#nullable restore
#line 57 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"follow-button\">\r\n                                                <input type=\"button\" value=\"Follow\">\r\n                                            </div>\r\n");
#nullable restore
#line 63 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n");
#nullable restore
#line 66 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                                            count++;
                                            if (count == 3)
                                            {
                                                break;
                                            }
                                        }
                                        if (profile.Count > 3)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"viewall\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3657, "\"", 3706, 2);
            WriteAttributeValue("", 3664, "/Search/SearchProfileByKey?textSearch=", 3664, 38, true);
#nullable restore
#line 75 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
WriteAttributeValue("", 3702, key, 3702, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View all</a>\r\n                                </div>\r\n");
#nullable restore
#line 77 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                            }

                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <!--Post result-->\r\n                <div class=\"post-result\">\r\n                    <p class=\"result-header\">Posts</p>\r\n");
#nullable restore
#line 86 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                      
                        if (post.Count == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>No posts found</p>\r\n");
#nullable restore
#line 90 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                        }
                        else
                        {
                            int count = 0;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                             foreach (var item in post)
                            {
                                string shortDate = item.PostDate.ToShortDateString();
                                bool check = checkLike(username, item.PostID);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"feed-post\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4591, "\"", 4651, 3);
            WriteAttributeValue("", 4601, "window.location=\'/Home/ViewDetail?id=", 4601, 37, true);
#nullable restore
#line 98 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
WriteAttributeValue("", 4638, item.PostID, 4638, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4650, "\'", 4650, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"feed-profile\">\r\n                                        <div class=\"profile\">\r\n                                            <div class=\"profile-img-wrapper\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "66430a62b1d60e14490376fb68421c3872881eca17625", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4869, "~/img/", 4869, 6, true);
#nullable restore
#line 101 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
AddHtmlAttributeValue("", 4875, item.ProfileImage, 4875, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                                            <div class=\"feed-title-info\">\r\n                                                <a class=\"profile-name\"");
            BeginWriteAttribute("href", " href=\"", 5056, "\"", 5109, 2);
            WriteAttributeValue("", 5063, "/Profile/ViewProfile?profileid=", 5063, 31, true);
#nullable restore
#line 103 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
WriteAttributeValue("", 5094, item.ProfileID, 5094, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 103 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                                                                                                                         Write(item.ProfileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                <p class=\"time\">");
#nullable restore
#line 104 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                                                           Write(shortDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"feed-content\">\r\n                                        ");
#nullable restore
#line 109 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                                   Write(item.PostContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"feed-reaction\">\r\n");
#nullable restore
#line 112 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                                          
                                            if (check)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"like\"><i class=\"fa fa-heart\" style=\"color: red;\" aria-hidden=\"true\"></i>(");
#nullable restore
#line 115 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                                                                                                                                Write(item.NoOfLikes);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</div>\r\n");
#nullable restore
#line 116 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"like\"><i class=\"fa fa-heart-o\" aria-hidden=\"true\"></i>(");
#nullable restore
#line 119 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                                                                                                              Write(item.NoOfLikes);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</div>\r\n");
#nullable restore
#line 120 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"comment\"><i class=\"fa fa-comment-o\" aria-hidden=\"true\"></i> (");
#nullable restore
#line 122 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                                                                                                            Write(item.NoOfCmts);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 125 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                                                count++;
                                                if (count == 4)
                                                {
                                                    break;
                                                }
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                                             
                            if (post.Count > 4)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"viewall\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 6992, "\"", 7038, 2);
            WriteAttributeValue("", 6999, "/Search/SearchPostByKey?textSearch=", 6999, 35, true);
#nullable restore
#line 134 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
WriteAttributeValue("", 7034, key, 7034, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View all</a>\r\n                                </div>\r\n");
#nullable restore
#line 136 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Search\SearchByKey.cshtml"
                            }
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
