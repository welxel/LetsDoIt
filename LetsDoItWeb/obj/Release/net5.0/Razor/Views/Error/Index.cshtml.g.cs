#pragma checksum "C:\Users\dbhsoft\source\repos\LetsDoItWeb\LetsDoItWeb\Views\Error\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa5398532dba546aeee708ddd455322e971082bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Error_Index), @"mvc.1.0.view", @"/Views/Error/Index.cshtml")]
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
#line 1 "C:\Users\dbhsoft\source\repos\LetsDoItWeb\LetsDoItWeb\_ViewImports.cshtml"
using LetsDoItWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dbhsoft\source\repos\LetsDoItWeb\LetsDoItWeb\_ViewImports.cshtml"
using Business.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dbhsoft\source\repos\LetsDoItWeb\LetsDoItWeb\_ViewImports.cshtml"
using Business.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa5398532dba546aeee708ddd455322e971082bd", @"/Views/Error/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac22b10155b7cfd6f51cfa46e77579b56864b7d0", @"/_ViewImports.cshtml")]
    public class Views_Error_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\dbhsoft\source\repos\LetsDoItWeb\LetsDoItWeb\Views\Error\Index.cshtml"
   Layout = "../Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"content-wrapper\" style=\"min-height: 1602px;\">\r\n    <!-- Content Header (Page header) -->\r\n    <section class=\"content-header\">\r\n        <div class=\"container-fluid\">\r\n            <div class=\"row mb-2\">\r\n                <div class=\"col-sm-6\">\r\n");
            WriteLiteral(@"                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                    </ol>
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class=""content"">
        <div class=""error-page"">
            <h2 class=""headline text-info"">401</h2>

            <div class=""error-content"">
                <h3><i class=""fas fa-exclamation-triangle text-yellow""></i> Your account don't have authanticataion this page.</h3>
            </div>
        </div>
        <!-- /.error-page -->

    </section>

    <!-- /.content -->
</div>");
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