#pragma checksum "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8047af4267275970a4f17b022a64856732e1a48e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_ViewProfile), @"mvc.1.0.view", @"/Views/Profile/ViewProfile.cshtml")]
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
#line 1 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
using static DataLibrary.BusinessRule.ReactionProcessor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
using static DataLibrary.BusinessRule.FollowProcessor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
using DataLibrary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8047af4267275970a4f17b022a64856732e1a48e", @"/Views/Profile/ViewProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68296fcad83d6278540d58756b812845f630759d", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_ViewProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NockNock.Models.PostModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
  
    ViewData["Title"] = "ViewProfile";
    Layout = "~/Views/Shared/_ProfileLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
  
    var profile = ViewBag.profile as DataLibrary.Models.ProfileModel;
    int profileid = profile.ProfileID;
    var username = Context.Session.GetString("username");
    var follower = Context.Session.GetString("follower");
    var following = Context.Session.GetString("following");
    var noOfPost = Context.Session.GetString("noOfPosts");
    DataLibrary.Models.ProfileModel pro = SessionHelper.GetObjectFromJson<DataLibrary.Models.ProfileModel>(Context.Session, "profile");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
  
    //if profileid = session.profileid
    if (profileid == pro.ProfileID)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"profile-display\">\r\n            <div class=\"profile\">\r\n                <div>\r\n                    <div class=\"profile-img-wrapper\"><img");
            BeginWriteAttribute("src", " src=\"", 1063, "\"", 1091, 2);
            WriteAttributeValue("", 1069, "/img/", 1069, 5, true);
#nullable restore
#line 28 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
WriteAttributeValue("", 1074, pro.ProfilePhoto, 1074, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1092, "\"", 1098, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                </div>\r\n                <div class=\"profile-display-detail\">\r\n                    <div>\r\n                        <p class=\"profile-name\">");
#nullable restore
#line 32 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                                           Write(pro.ProfileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1328, "\"", 1386, 3);
            WriteAttributeValue("", 1338, "window.location=\'", 1338, 17, true);
#nullable restore
#line 33 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
WriteAttributeValue("", 1355, Url.Action("Edit", "Profile"), 1355, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1385, "\'", 1385, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-cog\" aria-hidden=\"true\"></i> Settings</button>\r\n                    </div>\r\n                    <div class=\"account-detail\">\r\n                        <span>");
#nullable restore
#line 36 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                         Write(noOfPost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> &nbsp; posts\r\n                        <button class=\"modal-btn\">");
#nullable restore
#line 37 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                                             Write(follower);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button> followers\r\n                        <button class=\"modal-btn-2\">");
#nullable restore
#line 38 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                                               Write(following);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button> following\r\n                    </div>\r\n                    <div class=\"profile-description\">\r\n                        ");
#nullable restore
#line 41 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                   Write(pro.Bio);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <!--create new post-->
        <div class=""post-area"">
            <div class=""new-post-title"">
                <p>Create new post</p>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8047af4267275970a4f17b022a64856732e1a48e10088", async() => {
                WriteLiteral("\r\n                <div class=\"new-post\">\r\n                    <div class=\"post-avatar\">\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 2326, "\"", 2354, 2);
                WriteAttributeValue("", 2332, "/img/", 2332, 5, true);
#nullable restore
#line 54 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
WriteAttributeValue("", 2337, pro.ProfilePhoto, 2337, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2355, "\"", 2361, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                    <div class=""post-text"">
                        <textarea name=""status"" rows=""7"" required></textarea>
                    </div>
                    <div class=""create-post"">
                        <input type=""submit"" value=""Post"">
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2152, "/Profile/NewPost?profileid=", 2152, 27, true);
#nullable restore
#line 51 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
AddHtmlAttributeValue("", 2179, pro.ProfileID, 2179, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <h2>My Post</h2>\r\n");
#nullable restore
#line 66 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
    }
    //profileid != session.profileid
    else
    {
        bool isFollow = isFollowing(pro.ProfileID, profile.ProfileID);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"profile-display\">\r\n            <div class=\"profile\">\r\n                <div>\r\n                    <div class=\"profile-img-wrapper\"><img");
            BeginWriteAttribute("src", " src=\"", 3055, "\"", 3087, 2);
            WriteAttributeValue("", 3061, "/img/", 3061, 5, true);
#nullable restore
#line 74 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
WriteAttributeValue("", 3066, profile.ProfilePhoto, 3066, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3088, "\"", 3094, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                </div>\r\n                <div class=\"profile-display-detail\">\r\n                    <div>\r\n\r\n                        <p class=\"profile-name\">");
#nullable restore
#line 79 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                                           Write(profile.ProfileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8047af4267275970a4f17b022a64856732e1a48e14994", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 81 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                              
                                if (isFollow)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"following-button\">\r\n                                        <input type=\"submit\" value=\"Following\">\r\n                                    </div>\r\n");
#nullable restore
#line 87 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"follow-button\">\r\n                                        <input type=\"submit\" value=\"Follow\">\r\n                                    </div>\r\n");
#nullable restore
#line 93 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3323, "/Profile/Follow?id=", 3323, 19, true);
#nullable restore
#line 80 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
AddHtmlAttributeValue("", 3342, profile.ProfileID, 3342, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <button onclick=""window.location=''"" class=""message""><i class=""fa fa-commenting-o"" aria-hidden=""true""></i> Message</button>
                    </div>
                    <div class=""account-detail"">
                        <span>");
#nullable restore
#line 99 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                         Write(profile.NoOfPosts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> &nbsp; followers\r\n                        <button class=\"modal-btn\">");
#nullable restore
#line 100 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                                             Write(profile.Follower);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button> followers\r\n                        <button class=\"modal-btn-2\">");
#nullable restore
#line 101 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                                               Write(profile.Following);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button> following\r\n                    </div>\r\n                    <div class=\"profile-description\">\r\n                        ");
#nullable restore
#line 104 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                   Write(profile.Bio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 110 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr style=\"height:2px;border-width:0;color:gray;background-color:gray\">\r\n<!--new feed-->\r\n");
#nullable restore
#line 115 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
 foreach (var item in Model)
{
    string imgPath = "/img/" + item.ProfileImage;
    string shortDate = item.PostDate.ToShortDateString();
    bool check = checkLike(username, item.PostID);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"feed-post\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5093, "\"", 5153, 3);
            WriteAttributeValue("", 5103, "window.location=\'/Home/ViewDetail?id=", 5103, 37, true);
#nullable restore
#line 120 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
WriteAttributeValue("", 5140, item.PostID, 5140, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5152, "\'", 5152, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"feed-profile\">\r\n            <div class=\"profile\">\r\n                <div class=\"profile-img-wrapper\"><img");
            BeginWriteAttribute("src", " src=\"", 5281, "\"", 5295, 1);
#nullable restore
#line 123 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
WriteAttributeValue("", 5287, imgPath, 5287, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5296, "\"", 5302, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                <div class=\"feed-title-info\">\r\n                    <a class=\"profile-name\"");
            BeginWriteAttribute("href", " href=\"", 5402, "\"", 5455, 2);
            WriteAttributeValue("", 5409, "/Profile/ViewProfile?profileid=", 5409, 31, true);
#nullable restore
#line 125 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
WriteAttributeValue("", 5440, item.ProfileID, 5440, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 125 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                                                                                             Write(item.ProfileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    <p class=\"time\">");
#nullable restore
#line 126 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                               Write(shortDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"feed-content\">\r\n            ");
#nullable restore
#line 131 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
       Write(item.PostContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"feed-reaction\">\r\n");
#nullable restore
#line 134 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
              
                if (check == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"like\"><i style=\"color: red;\" class=\"fa fa-heart\" aria-hidden=\"true\"></i> (");
#nullable restore
#line 137 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                                                                                                     Write(item.NoOfLikes);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</div>\r\n");
#nullable restore
#line 138 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"like\"><i class=\"fa fa-heart-o\" aria-hidden=\"true\"></i> (");
#nullable restore
#line 141 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                                                                                   Write(item.NoOfLikes);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</div>\r\n");
#nullable restore
#line 142 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"comment\"><i class=\"fa fa-comment-o\" aria-hidden=\"true\"></i> (");
#nullable restore
#line 145 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                                                                                Write(item.NoOfCmts);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 148 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 149 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
  
    var followerList = ViewBag.followerlist as List<ProfileModel>;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--POP UP FOLLOWER: only visiable when click button \'Follower\'-->\r\n<div class=\"modal-bg\">\r\n    <div class=\"modal\">\r\n        <h3>Followers</h3>\r\n        <div class=\"people\">\r\n");
#nullable restore
#line 157 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
              
                foreach (var item in followerList)
                {
                    Boolean check = isFollowing(pro.ProfileID, item.ProfileID);

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"mini-profile\">\r\n                            <div>\r\n                                <div class=\"mini-profile-avatar\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 6872, "\"", 6901, 2);
            WriteAttributeValue("", 6878, "/img/", 6878, 5, true);
#nullable restore
#line 164 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
WriteAttributeValue("", 6883, item.ProfilePhoto, 6883, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6902, "\"", 6908, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"profile-info\">\r\n                                <p class=\"profile-name\"><a");
            BeginWriteAttribute("href", " href=\"", 7102, "\"", 7155, 2);
            WriteAttributeValue("", 7109, "/Profile/ViewProfile?profileid=", 7109, 31, true);
#nullable restore
#line 168 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
WriteAttributeValue("", 7140, item.ProfileID, 7140, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 168 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                                                                                                            Write(item.ProfileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                                <p class=\"follower\">");
#nullable restore
#line 169 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                                               Write(item.Follower);

#line default
#line hidden
#nullable disable
            WriteLiteral(" followers</p>\r\n                            </div>\r\n");
#nullable restore
#line 171 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                              
                                //if item's id in list != my session id
                                if (pro.ProfileID != item.ProfileID)
                                {
                                    if (check)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"following-button\">\r\n                                            <input type=\"button\" value=\"Following\">\r\n                                        </div>\r\n");
#nullable restore
#line 180 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"follow-button\">\r\n                                            <input type=\"button\" value=\"Follow\">\r\n                                        </div>\r\n");
#nullable restore
#line 186 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n");
#nullable restore
#line 190 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <span class=\"modal-close\">X</span>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 197 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
  
    var followingList = ViewBag.followinglist as List<ProfileModel>;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--POP UP FOLLOWING: only visiable when click button \'Following\'-->\r\n<div class=\"modal-bg-2\">\r\n    <div class=\"modal-2\">\r\n        <h3>Following</h3>\r\n");
#nullable restore
#line 204 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
          
            foreach (var item in followingList)
            {
                Boolean check = isFollowing(pro.ProfileID, item.ProfileID);

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"people\">\r\n                            <div class=\"mini-profile\">\r\n                                <div>\r\n                                    <div class=\"mini-profile-avatar\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 9005, "\"", 9034, 2);
            WriteAttributeValue("", 9011, "/img/", 9011, 5, true);
#nullable restore
#line 212 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
WriteAttributeValue("", 9016, item.ProfilePhoto, 9016, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 9035, "\"", 9041, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"profile-info\">\r\n                                    <p class=\"profile-name\"><a");
            BeginWriteAttribute("href", " href=\"", 9251, "\"", 9304, 2);
            WriteAttributeValue("", 9258, "/Profile/ViewProfile?profileid=", 9258, 31, true);
#nullable restore
#line 216 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
WriteAttributeValue("", 9289, item.ProfileID, 9289, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 216 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                                                                                                                Write(item.ProfileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                                    <p class=\"follower\">");
#nullable restore
#line 217 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                                                   Write(item.Follower);

#line default
#line hidden
#nullable disable
            WriteLiteral(" followers</p>\r\n                                </div>\r\n");
#nullable restore
#line 219 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                                  
                                    if (pro.ProfileID != item.ProfileID)
                                    {
                                        if (check)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"following-button\">\r\n                                                <input type=\"button\" value=\"Following\">\r\n                                            </div>\r\n");
#nullable restore
#line 227 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"follow-button\">\r\n                                                <input type=\"button\" value=\"Follow\">\r\n                                            </div>\r\n");
#nullable restore
#line 233 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
                                        }
                                    }

                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                </div>\r\n");
#nullable restore
#line 239 "C:\Users\acer\Desktop\SE1406\C#\My NockNock\PRN292_Project-Final\PRN292_Project (3)\PRN292_Project\NockNock\Views\Profile\ViewProfile.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span class=\"modal-close-2\">X</span>\r\n    </div>\r\n</div>\r\n\r\n");
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
