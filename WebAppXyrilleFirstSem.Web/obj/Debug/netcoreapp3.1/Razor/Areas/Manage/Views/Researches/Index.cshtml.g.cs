#pragma checksum "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e4da64b2f959d3178c7484ecaafc3400206ea60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Researches_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Researches/Index.cshtml")]
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
#line 2 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e4da64b2f959d3178c7484ecaafc3400206ea60", @"/Areas/Manage/Views/Researches/Index.cshtml")]
    public class Areas_Manage_Views_Researches_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppXyrilleFirstSem.Web.Areas.Manage.ViewModels.Researches.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/researches/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg-3 btn-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Research Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
  
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
                <span class=""input-group-text"" id=""inputGroup-sizing-sm"">Researches</span>
            </div>
            <select class=""form-control"" aria-label=""Small"" aria-describedby=""inputGroup-sizing-sm"" id=""searchStatus"" onchange=""searchTrigger()"" placeholder=""Research Status"">
");
#nullable restore
#line 19 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
                  
                    foreach (ResearchStatus researchStatus in Model.ResearchStatuses)
                    {
                        if (Model.ResearchStatus == researchStatus)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 992, "\"", 1015, 1);
#nullable restore
#line 24 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
WriteAttributeValue("", 1000, researchStatus, 1000, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 24 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
                                                                Write(researchStatus.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 25 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1182, "\"", 1205, 1);
#nullable restore
#line 28 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
WriteAttributeValue("", 1190, researchStatus, 1190, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
                                                       Write(researchStatus.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 29 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
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
            BeginWriteAttribute("value", " value=\"", 1596, "\"", 1627, 1);
#nullable restore
#line 38 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
WriteAttributeValue("", 1604, Model.Research.Keyword, 1604, 23, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e4da64b2f959d3178c7484ecaafc3400206ea609233", async() => {
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
#line 57 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
 if (Model.Research.Items.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-borderless table-striped table-hover"">
        <thead>
            <tr class=""table-info"">
                <th>Title</th>
                <th>Content</th>

                <th>Status</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 70 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
              
                foreach (Research research in Model.Research.Items)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 74 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
                       Write(research.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 75 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
                       Write(research.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 76 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
                       Write(research.ResearchStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e4da64b2f959d3178c7484ecaafc3400206ea6012540", async() => {
                WriteLiteral("<button type=\"button\" class=\"btn\"><i class=\"fas fa-info\"></i></button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2949, "~/manage/researches/details/", 2949, 28, true);
#nullable restore
#line 78 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
AddHtmlAttributeValue("", 2977, research.Id, 2977, 12, false);

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
            BeginWriteAttribute("onclick", " onclick=\"", 3131, "\"", 3197, 6);
            WriteAttributeValue("", 3141, "confirmDeleteResearch(\'", 3141, 23, true);
#nullable restore
#line 79 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
WriteAttributeValue("", 3164, research.Id, 3164, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3176, "\',", 3176, 2, true);
            WriteAttributeValue(" ", 3178, "\'", 3179, 2, true);
#nullable restore
#line 79 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
WriteAttributeValue("", 3180, research.Title, 3180, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3195, "\')", 3195, 2, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Delete Research\"><button type=\"button\" class=\"btn\"><i class=\"fas fa-times\"></i></button></a>\r\n");
#nullable restore
#line 80 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
                              
                                if (research.IsPublished)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"list-inline-item\"><a href=\"#\" title=\"Unpublish\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3520, "\"", 3580, 5);
            WriteAttributeValue("", 3530, "confirmUnpublish(\'", 3530, 18, true);
#nullable restore
#line 83 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
WriteAttributeValue("", 3548, research.Id, 3548, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3560, "\',\'", 3560, 3, true);
#nullable restore
#line 83 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
WriteAttributeValue("", 3563, research.Title, 3563, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3578, "\')", 3578, 2, true);
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn-danger form-control-sm\"><i class=\"fas fa-window-close\"></i></button></a></li>\r\n");
#nullable restore
#line 84 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"list-inline-item\"><a href=\"#\" title=\"Publish\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3880, "\"", 3938, 5);
            WriteAttributeValue("", 3890, "confirmPublish(\'", 3890, 16, true);
#nullable restore
#line 87 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
WriteAttributeValue("", 3906, research.Id, 3906, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3918, "\',\'", 3918, 3, true);
#nullable restore
#line 87 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
WriteAttributeValue("", 3921, research.Title, 3921, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3936, "\')", 3936, 2, true);
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn-success form-control-sm\"><i class=\"fas fa-check-square\"></i></button></a></li>\r\n");
#nullable restore
#line 88 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 94 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
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
            BeginWriteAttribute("value", " value=\"", 4594, "\"", 4627, 1);
#nullable restore
#line 103 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
WriteAttributeValue("", 4602, Model.Research.PageIndex, 4602, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" style=\"width:50px;\"");
            BeginWriteAttribute("onKeydown", " onKeydown=\"", 4669, "\"", 4945, 18);
            WriteAttributeValue("", 4681, "javascript:", 4681, 11, true);
            WriteAttributeValue(" ", 4692, "if(event.keyCode", 4693, 17, true);
            WriteAttributeValue(" ", 4709, "==", 4710, 3, true);
            WriteAttributeValue(" ", 4712, "13", 4713, 3, true);
            WriteAttributeValue(" ", 4715, "&&", 4716, 3, true);
            WriteAttributeValue(" ", 4718, "isNaN(parseInt($(this).val()))==false)", 4719, 39, true);
            WriteAttributeValue(" ", 4757, "window.location=\'/manage/researches/index?pageIndex=\'", 4758, 54, true);
            WriteAttributeValue(" ", 4811, "+", 4812, 2, true);
            WriteAttributeValue(" ", 4813, "(isNaN(parseInt($(this).val()))", 4814, 32, true);
            WriteAttributeValue(" ", 4845, "?", 4846, 2, true);
            WriteAttributeValue(" ", 4847, "1", 4848, 2, true);
            WriteAttributeValue(" ", 4849, ":", 4850, 2, true);
            WriteAttributeValue(" ", 4851, "parseInt($(this).val()))", 4852, 25, true);
            WriteAttributeValue(" ", 4876, "+", 4877, 2, true);
            WriteAttributeValue(" ", 4878, "\'&keyword=", 4879, 11, true);
#nullable restore
#line 103 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
WriteAttributeValue("", 4889, Model.Research.Keyword, 4889, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4914, "&status=", 4914, 8, true);
#nullable restore
#line 103 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
WriteAttributeValue("", 4922, Model.ResearchStatus, 4922, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></li>\r\n                            <li class=\"page-item\"><span class=\"form-control-plaintext\">&nbsp;&nbsp;&nbsp;of ");
#nullable restore
#line 104 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
                                                                                                       Write(Model.Research.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;&nbsp;</span></li>\r\n");
#nullable restore
#line 105 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
                              
                                var prev = Model.Research.PageIndex - 1;
                                if (prev > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e4da64b2f959d3178c7484ecaafc3400206ea6022761", async() => {
                WriteLiteral("<span aria-hidden=\"true\">&laquo;</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5394, "~/manage/researches/index?keyword=", 5394, 34, true);
#nullable restore
#line 109 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
AddHtmlAttributeValue("", 5428, Model.Research.Keyword, 5428, 23, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5451, "&status=", 5451, 8, true);
#nullable restore
#line 109 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
AddHtmlAttributeValue("", 5459, Model.ResearchStatus, 5459, 21, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5480, "&pageSize=", 5480, 10, true);
#nullable restore
#line 109 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
AddHtmlAttributeValue("", 5490, Model.Research.PageSize, 5490, 24, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5514, "&pageIndex=", 5514, 11, true);
#nullable restore
#line 109 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
AddHtmlAttributeValue("", 5525, prev, 5525, 5, false);

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
#line 110 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link\" href=\"#\">");
#nullable restore
#line 112 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
                                                                            Write(Model.Research.PageIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 113 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
                              
                                var next = Model.Research.PageIndex + 1;
                                if (next <= Model.Research.PageCount)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e4da64b2f959d3178c7484ecaafc3400206ea6026785", async() => {
                WriteLiteral("<span aria-hidden=\"true\">&raquo;</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6063, "~/manage/researches/index?keyword=", 6063, 34, true);
#nullable restore
#line 117 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
AddHtmlAttributeValue("", 6097, Model.Research.Keyword, 6097, 23, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6120, "&status=", 6120, 8, true);
#nullable restore
#line 117 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
AddHtmlAttributeValue("", 6128, Model.ResearchStatus, 6128, 21, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6149, "&pageSize=", 6149, 10, true);
#nullable restore
#line 117 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
AddHtmlAttributeValue("", 6159, Model.Research.PageSize, 6159, 24, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6183, "&pageIndex=", 6183, 11, true);
#nullable restore
#line 117 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
AddHtmlAttributeValue("", 6194, next, 6194, 5, false);

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
#line 118 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </nav>\r\n                </td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
#nullable restore
#line 126 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>0 search results.</p>\r\n");
#nullable restore
#line 130 "C:\Users\VGD PC 9\source\repos\WebAppXyrilleFirstSem\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Researches\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Model Delete-->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-delete-research"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Delete Research</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to delete <span id=""modal-delete-research-fullname""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <a href=""#"" id=""modal-delete-research-confirm""><button type=""button"" class=""btn btn-primary"">Delete Research</button></a>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>




<!--MODAL Unpublish-->
<di");
            WriteLiteral(@"v class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-unpublish"">
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
    <div class=""modal-");
            WriteLiteral(@"dialog"" role=""document"">
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
        $(""#modal-unpublish");
            WriteLiteral(@"-name"").html(name);
        $(""#modal-unpublish-button"").attr(""onclick"", ""UnpublishResearch('"" + id + ""')"");
        $(""#modal-unpublish"").modal(""show"");
    }
    function UnpublishResearch(id) {
        $.ajax({
            type: ""POST"",
            url: ""/manage/researches/unpublish"",
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
        $(""#modal-publish-button"").attr(""onclick"", ""PublishResearch + id + ""')"");
        $(""#modal-publish"").modal(""show"");
    }
    function PublishResearch(id) {
      ");
            WriteLiteral(@"  $.ajax({
            type: ""POST"",
            url: ""/manage/researches/publish"",
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

    function confirmDeleteResearch(researchId, Name) {
        $(""#modal-delete-research-fullname"").html(Name);
        $(""#modal-delete-research-confirm"").attr(""href"", ""/manage/researches/delete/"" + researchId);
        $(""#modal-delete-research"").modal(""show"");
    }

    $(""#searchKeyword"").keyup(function (event) {
        if (event.keyCode === 13) {
            searchTrigger();
        }
    });

    function searchTrigger() {
        window.location = ""/manage/researches/index?pageIndex=1&keyword="" + $(""#searchKeyword"").val() + ""&status="" + $(""#searchSt");
            WriteLiteral("atus\").val();\r\n    }\r\n\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppXyrilleFirstSem.Web.Areas.Manage.ViewModels.Researches.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591