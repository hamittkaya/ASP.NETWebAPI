#pragma checksum "C:\Users\ceren\Desktop\BlogSite\Blog.WebMvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cb775741762e5ca4770f25a83770dbf3815ac52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Blog.WebMvc.Models.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace Blog.WebMvc.Models.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cb775741762e5ca4770f25a83770dbf3815ac52", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"529e67655c3523d2c7cfa9adfcd9ba1d4331bc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog.WebMvc.Models.ArticleListModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ceren\Desktop\BlogSite\Blog.WebMvc\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\ceren\Desktop\BlogSite\Blog.WebMvc\Views\Home\Index.cshtml"
 foreach (var article in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card mb-4\">\r\n        <img class=\"card-img-top\" src=\"http://placehold.it/750x300\" alt=\"Card image cap\">\r\n        <div class=\"card-body\">\r\n            <h2 class=\"card-title\">");
#nullable restore
#line 12 "C:\Users\ceren\Desktop\BlogSite\Blog.WebMvc\Views\Home\Index.cshtml"
                              Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <p class=\"card-text\">");
#nullable restore
#line 13 "C:\Users\ceren\Desktop\BlogSite\Blog.WebMvc\Views\Home\Index.cshtml"
                            Write(article.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <a href=\"#\" class=\"btn btn-primary\">Read More &rarr;</a>\r\n        </div>\r\n        <div class=\"card-footer text-muted\">\r\n            Posted on ");
#nullable restore
#line 17 "C:\Users\ceren\Desktop\BlogSite\Blog.WebMvc\Views\Home\Index.cshtml"
                 Write(article.PostedTime.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 20 "C:\Users\ceren\Desktop\BlogSite\Blog.WebMvc\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog.WebMvc.Models.ArticleListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
