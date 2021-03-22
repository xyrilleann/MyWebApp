#pragma checksum "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00fb97059058f54f6a5623b582770a24eacfcf30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Authors_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Authors/Index.cshtml")]
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
#line 2 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00fb97059058f54f6a5623b582770a24eacfcf30", @"/Areas/Manage/Views/Authors/Index.cshtml")]
    public class Areas_Manage_Views_Authors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppXyrilleFirstSem.Web.Areas.Manage.ViewModels.Authors.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/authors/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg-3 btn-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Author Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
  
    Layout = "~/areas/manage/views/shared/_managelayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h1>Index</h1>


<div class=""row"">
    <div class=""col-lg-5"">
        <div class=""input-group mt-5"">
            <div class=""input-group-prepend"">
                <span class=""input-group-text"" id=""inputGroup-sizing-sm"">Authors</span>
            </div>
            <select class=""form-control"" aria-label=""Small"" aria-describedby=""inputGroup-sizing-sm"" id=""searchStatus"" onchange=""searchTrigger()"" placeholder=""Author Status"">
");
#nullable restore
#line 19 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                  
                    foreach (AuthorStatus authorStatus in Model.AuthorStatuses)
                    {
                        if (Model.AuthorStatus == authorStatus)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 974, "\"", 995, 1);
#nullable restore
#line 24 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
WriteAttributeValue("", 982, authorStatus, 982, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 24 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                                                              Write(authorStatus.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 25 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1160, "\"", 1181, 1);
#nullable restore
#line 28 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
WriteAttributeValue("", 1168, authorStatus, 1168, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                                                     Write(authorStatus.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 29 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
    </div>

    <div class=""col-lg-3 "">
        <div class=""input-group mt-5"">
            <input type=""text"" id=""searchKeyword"" placeholder=""search research"" class=""form-control"" aria-label=""search research"" aria-describedby=""basic-addon2""");
            BeginWriteAttribute("value", " value=\"", 1570, "\"", 1599, 1);
#nullable restore
#line 38 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
WriteAttributeValue("", 1578, Model.Author.Keyword, 1578, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""input-group-append"">
                <span class=""input-group-text"" id=""basic-addon2""><a href=""#"" onclick=""searchTrigger()""><i class=""fa fa-search"" aria-hidden=""true""></i></a></span>
            </div>
        </div>
    </div>

    <div class=""col-lg-3"">
        <div class=""table-responsive table--no-card m-b-30 mt-md-5"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00fb97059058f54f6a5623b582770a24eacfcf309145", async() => {
                WriteLiteral("\r\n                <i class=\"fa fa-plus\"></i>&nbsp;\r\n                <span>Create Research</span>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<hr />\r\n\r\n\r\n");
#nullable restore
#line 57 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
 if (Model.Author.Items.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-borderless table-striped table-hover"">
        <thead>
            <tr class=""table-info"">
                <th>Name</th>
                <th>Status</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 68 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
              
                foreach (Author author in Model.Author.Items)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 72 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                       Write(author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 73 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                       Write(author.AuthorStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00fb97059058f54f6a5623b582770a24eacfcf3012068", async() => {
                WriteLiteral("<button type=\"button\" class=\"btn\"><i class=\"fas fa-info\"></i></button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2814, "~/manage/authors/details/", 2814, 25, true);
#nullable restore
#line 75 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
AddHtmlAttributeValue("", 2839, author.Id, 2839, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2989, "\"", 3048, 6);
            WriteAttributeValue("", 2999, "confirmDeleteAuthor(\'", 2999, 21, true);
#nullable restore
#line 76 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
WriteAttributeValue("", 3020, author.Id, 3020, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3030, "\',", 3030, 2, true);
            WriteAttributeValue(" ", 3032, "\'", 3033, 2, true);
#nullable restore
#line 76 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
WriteAttributeValue("", 3034, author.Name, 3034, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3046, "\')", 3046, 2, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Delete Author\"><button type=\"button\" class=\"btn\"><i class=\"fas fa-times\"></i></button></a>\r\n");
#nullable restore
#line 77 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                              
                                if (author.IsPublished)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"list-inline-item\"><a href=\"#\" title=\"Unpublish\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3367, "\"", 3422, 5);
            WriteAttributeValue("", 3377, "confirmUnpublish(\'", 3377, 18, true);
#nullable restore
#line 80 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
WriteAttributeValue("", 3395, author.Id, 3395, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3405, "\',\'", 3405, 3, true);
#nullable restore
#line 80 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
WriteAttributeValue("", 3408, author.Name, 3408, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3420, "\')", 3420, 2, true);
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn-danger form-control-sm\"><i class=\"fas fa-window-close\"></i></button></a></li>\r\n");
#nullable restore
#line 81 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"list-inline-item\"><a href=\"#\" title=\"Publish\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3722, "\"", 3775, 5);
            WriteAttributeValue("", 3732, "confirmPublish(\'", 3732, 16, true);
#nullable restore
#line 84 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
WriteAttributeValue("", 3748, author.Id, 3748, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3758, "\',\'", 3758, 3, true);
#nullable restore
#line 84 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
WriteAttributeValue("", 3761, author.Name, 3761, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3773, "\')", 3773, 2, true);
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn-success form-control-sm\"><i class=\"fas fa-check-square\"></i></button></a></li>\r\n");
#nullable restore
#line 85 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 91 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
        <tfoot>
            <tr>
                <td colspan=""4"">
                    <nav aria-label=""Page navigation example"">
                        <ul class=""pagination"">
                            <li class=""page-item""><span class=""form-control-plaintext"">Page&nbsp;&nbsp;&nbsp;</span></li>
                            <li class=""page-item""><input type=""number""");
            BeginWriteAttribute("value", " value=\"", 4431, "\"", 4462, 1);
#nullable restore
#line 100 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
WriteAttributeValue("", 4439, Model.Author.PageIndex, 4439, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" style=\"width:50px;\"");
            BeginWriteAttribute("onKeydown", " onKeydown=\"", 4504, "\"", 4773, 18);
            WriteAttributeValue("", 4516, "javascript:", 4516, 11, true);
            WriteAttributeValue(" ", 4527, "if(event.keyCode", 4528, 17, true);
            WriteAttributeValue(" ", 4544, "==", 4545, 3, true);
            WriteAttributeValue(" ", 4547, "13", 4548, 3, true);
            WriteAttributeValue(" ", 4550, "&&", 4551, 3, true);
            WriteAttributeValue(" ", 4553, "isNaN(parseInt($(this).val()))==false)", 4554, 39, true);
            WriteAttributeValue(" ", 4592, "window.location=\'/manage/authors/index?pageIndex=\'", 4593, 51, true);
            WriteAttributeValue(" ", 4643, "+", 4644, 2, true);
            WriteAttributeValue(" ", 4645, "(isNaN(parseInt($(this).val()))", 4646, 32, true);
            WriteAttributeValue(" ", 4677, "?", 4678, 2, true);
            WriteAttributeValue(" ", 4679, "1", 4680, 2, true);
            WriteAttributeValue(" ", 4681, ":", 4682, 2, true);
            WriteAttributeValue(" ", 4683, "parseInt($(this).val()))", 4684, 25, true);
            WriteAttributeValue(" ", 4708, "+", 4709, 2, true);
            WriteAttributeValue(" ", 4710, "\'&keyword=", 4711, 11, true);
#nullable restore
#line 100 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
WriteAttributeValue("", 4721, Model.Author.Keyword, 4721, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4744, "&status=", 4744, 8, true);
#nullable restore
#line 100 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
WriteAttributeValue("", 4752, Model.AuthorStatus, 4752, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></li>\r\n                            <li class=\"page-item\"><span class=\"form-control-plaintext\">&nbsp;&nbsp;&nbsp;of ");
#nullable restore
#line 101 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                                                                                                       Write(Model.Author.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;&nbsp;</span></li>\r\n");
#nullable restore
#line 102 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                              
                                var prev = Model.Author.PageIndex - 1;
                                if (prev > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00fb97059058f54f6a5623b582770a24eacfcf3022202", async() => {
                WriteLiteral("<span aria-hidden=\"true\">&laquo;</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5218, "~/manage/authors/index?keyword=", 5218, 31, true);
#nullable restore
#line 106 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
AddHtmlAttributeValue("", 5249, Model.Author.Keyword, 5249, 21, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5270, "&status=", 5270, 8, true);
#nullable restore
#line 106 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
AddHtmlAttributeValue("", 5278, Model.AuthorStatus, 5278, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5297, "&pageSize=", 5297, 10, true);
#nullable restore
#line 106 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
AddHtmlAttributeValue("", 5307, Model.Author.PageSize, 5307, 22, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5329, "&pageIndex=", 5329, 11, true);
#nullable restore
#line 106 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
AddHtmlAttributeValue("", 5340, prev, 5340, 5, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 107 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link\" href=\"#\">");
#nullable restore
#line 109 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                                                                            Write(Model.Author.PageIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 110 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                              
                                var next = Model.Author.PageIndex + 1;
                                if (next <= Model.Author.PageCount)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00fb97059058f54f6a5623b582770a24eacfcf3026190", async() => {
                WriteLiteral("<span aria-hidden=\"true\">&raquo;</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5872, "~/manage/authors/index?keyword=", 5872, 31, true);
#nullable restore
#line 114 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
AddHtmlAttributeValue("", 5903, Model.Author.Keyword, 5903, 21, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5924, "&status=", 5924, 8, true);
#nullable restore
#line 114 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
AddHtmlAttributeValue("", 5932, Model.AuthorStatus, 5932, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5951, "&pageSize=", 5951, 10, true);
#nullable restore
#line 114 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
AddHtmlAttributeValue("", 5961, Model.Author.PageSize, 5961, 22, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5983, "&pageIndex=", 5983, 11, true);
#nullable restore
#line 114 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
AddHtmlAttributeValue("", 5994, next, 5994, 5, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 115 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </nav>\r\n                </td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
#nullable restore
#line 123 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>0 search results.</p>\r\n");
#nullable restore
#line 127 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Model Delete-->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-delete-author"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Delete Author</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to delete <span id=""modal-delete-author-name""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <a href=""#"" id=""modal-delete-author-confirm""><button type=""button"" class=""btn btn-primary"">Delete Author</button></a>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>




<!--MODAL Unpublish-->
<div class=""modal");
            WriteLiteral(@""" tabindex=""-1"" role=""dialog"" id=""modal-unpublish"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Unpublish Post</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to unpublish <span id=""modal-unpublish-name""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" id=""modal-unpublish-button"">Yes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">No</button>
            </div>
        </div>
    </div>
</div>

<!--MODAL Publish-->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-publish"">
    <div class=""modal-dialog"" role=""");
            WriteLiteral(@"document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Publish Post</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to publish <span id=""modal-publish-name""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" id=""modal-publish-button"">Yes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">No</button>
            </div>
        </div>
    </div>
</div>



<script type=""text/javascript"">

    ////////////////////UNPUBLISH/////////////////////////////////////////////////////////////////
    function confirmUnpublish(id, name) {
        $(""#modal-unpublish-name"").html(n");
            WriteLiteral(@"ame);
        $(""#modal-unpublish-button"").attr(""onclick"", ""UnpublishAuthor('"" + id + ""')"");
        $(""#modal-unpublish"").modal(""show"");
    }
    function UnpublishAuthor(id) {
        $.ajax({
            type: ""POST"",
            url: ""/manage/authors/unpublish"",
            data: { id: id },
            success: function (data) {
                location.reload();
            },
            error: function (xhr) {
                var response = JSON.parse(xhr.responseText);
                alert(""Error Occured : "" + response.errors[0]);
                location.reload();
            }
        });
    }


    //////////////////PUBLISH///////////////////////////////////////////////////////////////////////
    function confirmPublish(id, name) {
        $(""#modal-publish-name"").html(name);
        $(""#modal-publish-button"").attr(""onclick"", ""PublishAuthor('"" + id + ""')"");
        $(""#modal-publish"").modal(""show"");
    }
    function PublishAuthor(id) {
        $.ajax({
          ");
            WriteLiteral(@"  type: ""POST"",
            url: ""/manage/authors/publish"",
            data: { id: id },
            success: function (data) {
                location.reload();
            },
            error: function (xhr) {
                var response = JSON.parse(xhr.responseText);
                alert(""Error Occured : "" + response.errors[0]);
                location.reload();
            }
        });
    }

    function confirmDeleteResearch(authorId, Name) {
        $(""#modal-delete-author-name"").html(Name);
        $(""#modal-delete-author-confirm"").attr(""href"", ""/manage/authors/delete/"" + authorId);
        $(""#modal-delete-author"").modal(""show"");
    }

    $(""#searchKeyword"").keyup(function (event) {
        if (event.keyCode === 13) {
            searchTrigger();
        }
    });

    function searchTrigger() {
        window.location = ""/manage/authors/index?pageIndex=1&keyword="" + $(""#searchKeyword"").val() + ""&status="" + $(""#searchStatus"").val();
    }


</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppXyrilleFirstSem.Web.Areas.Manage.ViewModels.Authors.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
