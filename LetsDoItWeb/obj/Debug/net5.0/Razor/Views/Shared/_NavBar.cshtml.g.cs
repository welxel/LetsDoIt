#pragma checksum "C:\Users\dbhsoft\source\repos\LetsDoItWeb\LetsDoItWeb\Views\Shared\_NavBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94d393c58b03afccf9c3fcd3661ed1694dcded8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NavBar), @"mvc.1.0.view", @"/Views/Shared/_NavBar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94d393c58b03afccf9c3fcd3661ed1694dcded8d", @"/Views/Shared/_NavBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac22b10155b7cfd6f51cfa46e77579b56864b7d0", @"/_ViewImports.cshtml")]
    public class Views_Shared__NavBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("animation__wobble"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("AdminLTELogo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/AdminLTELogo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<nav class=""main-header navbar navbar-expand navbar-white navbar-light"">
    <!-- Left navbar links -->
    <ul class=""navbar-nav"">
        <li class=""nav-item"">
            <a class=""nav-link"" data-widget=""pushmenu"" href=""#"" role=""button""><i class=""fas fa-bars""></i></a>
        </li>
        <li class=""nav-item d-none d-sm-inline-block"">
            <a href=""/Todo/Index"" class=""nav-link"">Home</a>
        </li>
        <li class=""nav-item d-none d-sm-inline-block"">
            <a href=""/Contact/Index"" class=""nav-link"">Contact</a>
        </li>
    </ul>

    <!-- Right navbar links -->
    <ul class=""navbar-nav ml-auto"">
        <!-- Navbar Search -->
        <!--<li class=""nav-item"">
            <a class=""nav-link"" data-widget=""navbar-search"" href=""#"" role=""button"">
                <i class=""fas fa-search""></i>
            </a>
            <div class=""navbar-search-block"">
                <form class=""form-inline"">
                    <div class=""input-group input-group-sm"">
                        <input cl");
            WriteLiteral(@"ass=""form-control form-control-navbar"" type=""search"" placeholder=""Search"" aria-label=""Search"">
                        <div class=""input-group-append"">
                            <button class=""btn btn-navbar"" type=""submit"">
                                <i class=""fas fa-search""></i>
                            </button>
                            <button class=""btn btn-navbar"" type=""button"" data-widget=""navbar-search"">
                                <i class=""fas fa-times""></i>
                            </button>
                        </div>
                    </div>
                </form>
            </div>
        </li>-->
        
        <div class=""preloader flex-column justify-content-center align-items-center"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "94d393c58b03afccf9c3fcd3661ed1694dcded8d6900", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>

        <!-- Messages Dropdown Menu -->
        <!-- Notifications Dropdown Menu -->
        <li class=""nav-item dropdown"">
            <a class=""nav-link"" data-toggle=""dropdown"" href=""#"">
                <i class=""fas fa-user-friends""></i>
                <div id=""request-count"">

                </div>
            </a>
            <div id=""test"" class=""dropdown-menu dropdown-menu-lg dropdown-menu-right"">


            </div>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-widget=""fullscreen"" href=""#"" role=""button"">
                <i class=""fas fa-expand-arrows-alt""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-widget=""control-sidebar"" data-slide=""true"" href=""#"" role=""button"">
                <i class=""fas fa-th-large""></i>
            </a>
        </li>
    </ul>
</nav>

<script>

    function yourfoo() {
        var html = '';
        var html2 = '';
        $.ajax({
            url: ""/UserList/GetFr");
            WriteLiteral(@"iendRequest"",
            type: ""get"",
            success: function (data, textStatus, jqXHR) {
                html += '<span class=""dropdown-item dropdown-header"">' + data.length + ' Friend Request</span>';
                html2 += '     <span class=""badge badge-warning navbar-badge"">' + data.length +'</span><div class=""dropdown-divider""></div>';
                for(var key in data) {
                    var value = data[key];
                    html += '<a onclick=""Save(' + value.id + ')"" href=""#"" class=""dropdown-item""><i class=""fas fa-user-plus""></i>  ' + value.user.userName + ' ' + 'want to add you  ' + '<span class=""float-right text-muted text-sm"">' + value.createdDate  + '</span></a>';
                }
                $(""#test"").append(html);
                $(""#request-count"").append(html2);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert(errorThrown);

            }
        });
    }
    yourfoo();

    function Save(idUser) {
        Ans('Wonder");
            WriteLiteral(@"full!! Some one want to be friend with you :) ', 'Are you add friend?', function () {

                $.ajax({
                    url: ""/UserList/SuccesFriend/"" + idUser,
                    type: ""post"",
                    success: function (data, textStatus, jqXHR) {
                        showMessage('Added', true);
                        setTimeout(reflesh, 1900);    
                 
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                        alert(errorThrown);

                    }
                });
            },function() {
                $.ajax({
                    url: ""/UserList/ErrorFriend/"" + idUser,
                    type: ""post"",
                    success: function (data, textStatus, jqXHR) {
                        showMessage('Deleted', true);
                        setTimeout(reflesh, 1900);    
                 
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
            ");
            WriteLiteral(@"            alert(errorThrown);

                    }
                });
            }
        );
    }

    function reflesh() {
        window.location.reload();
    }

    function Ans(title,message,run,test) {


        swalWithBootstrapButtons.fire({
            title: title,
            text: message,
            icon: 'warning',
            showCancelButton: true,
            confirmButtonText: 'Yes',
            cancelButtonText: 'No',
            reverseButtons: true
        }).then((result) => {
            if (result.isConfirmed) {
                run();
            } else if (result.dismiss === Swal.DismissReason.cancel) {
                test();
                //swalWithBootstrapButtons.fire(
                //    'Delete',
                //    'Friend request is delete',
                //    'error'
                //);
            }
        })

    }


</script> ");
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
