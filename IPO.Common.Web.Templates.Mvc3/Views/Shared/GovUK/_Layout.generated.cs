﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPO.Common.Web.Templates.Mvc3.Views.Shared.GovUK
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    
    #line 1 "..\..\Views\Shared\GovUK\_Layout.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Views\Shared\GovUK\_Layout.cshtml"
    using IPO.Common.Web.Templates.Mvc3.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/GovUK/_Layout.cshtml")]
    public partial class Layout : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Layout()
        {
        }
        public override void Execute()
        {


WriteLiteral(@"
<!DOCTYPE html>
<!--[if lt IE 9]><html class=""lte-ie8"" lang=""en""><![endif]-->
<!--[if gt IE 8]><!--><html lang=""en""><!--<![endif]-->
<head>
    <meta http-equiv=""content-type"" content=""text/html; charset=UTF-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=9; IE=8; IE=7; IE=EDGE"" />

    <title>");


            
            #line 11 "..\..\Views\Shared\GovUK\_Layout.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n\r\n    <script type=\"text/javascript\">\r\n        (function () { if (navig" +
"ator.userAgent.match(/IEMobile\\/10\\.0/)) { var d = document, c = \"appendChild\", " +
"a = d.createElement(\"style\"); a[c](d.createTextNode(\"");


WriteLiteral(@"@-ms-viewport{width:auto!important}"")); d.getElementsByTagName(""head"")[0][c](a); } })();
    </script>
    
    <link href=""/assets/content/themes/base/jquery.ui.all.css"" rel=""stylesheet"" />

    <script src=""/assets/scripts/jquery/jquery-1.7.1.min.js"" type=""text/javascript""></script>
    <script src=""/assets/scripts/jquery/jquery-ui-1.8.20.js""></script>
    <script src=""/assets/scripts/jquery/jquery.unobtrusive-ajax.js""></script>
    <script src=""/assets/scripts/jquery/jquery.validate.js""></script>
    <script src=""/assets/scripts/jquery/jquery.validate.unobtrusive.js""></script>

    <script src=""/__utm.js"" type=""text/javascript""></script>
    <script type=""text/javascript"" src=""/assets/scripts/feedback-dialog.js""></script>
    
    ");


            
            #line 28 "..\..\Views\Shared\GovUK\_Layout.cshtml"
Write(RenderSection("scripts", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n    \r\n    <link href=\"/assets/application.css\" media=\"screen\" rel=\"stylesheet\" " +
"type=\"text/css\" />\r\n     \r\n    <!--[if gt IE 8]><!--><link href=\"/assets/templat" +
"e/stylesheets/govuk-template.css\" media=\"screen\" rel=\"stylesheet\" type=\"text/css" +
"\" /><!--<![endif]-->\r\n    <!--[if IE 6]><link href=\"/assets/template/stylesheets" +
"/govuk-template-ie6.css\" media=\"screen\" rel=\"stylesheet\" type=\"text/css\" /><![en" +
"dif]-->\r\n    <!--[if IE 7]><link href=\"/assets/template/stylesheets/govuk-templa" +
"te-ie7.css\" media=\"screen\" rel=\"stylesheet\" type=\"text/css\" /><![endif]-->\r\n    " +
"<!--[if IE 8]><link href=\"/assets/template/stylesheets/govuk-template-ie8.css\" m" +
"edia=\"screen\" rel=\"stylesheet\" type=\"text/css\" /><![endif]-->\r\n\r\n    <link href=" +
"\"/assets/template/stylesheets/govuk-template-print.css\" media=\"print\" rel=\"style" +
"sheet\" type=\"text/css\" />\r\n\r\n    <!--[if IE 8]>\r\n    <script type=\"text/javascri" +
"pt\">\r\n      (function(){if(window.opera){return;}\r\n          setTimeout(function" +
"() {\r\n              var a = document, g, b = {\r\n                  families: (g =" +
"\r\n                      [\"nta\"]),\r\n                  urls: [\"/assets/template/st" +
"ylesheets/fonts-ie8.css\"]\r\n              },\r\n                  c = \"/assets/temp" +
"late/javascripts/vendor/goog/webfont-debug.js\", d = \"script\",\r\n                 " +
" e = a.createElement(d), f = a.getElementsByTagName(d)[0], h = g.length;\r\n      " +
"        WebFontConfig\r\n                  = { custom: b }, e.src = c, f.parentNod" +
"e.insertBefore(e, f);\r\n              for (; h = h - 1; a.documentElement\r\n      " +
"            .className += \' wf-\' + g[h].replace(/\\s/g, \'\').toLowerCase() + \'-n4-" +
"loading\') ;\r\n          }, 0);\r\n      })()\r\n    </script>\r\n    <![endif]-->\r\n    " +
"<!--[if gte IE 9]><!-->\r\n    <link href=\"/assets/template/stylesheets/fonts.css\"" +
" media=\"all\" rel=\"stylesheet\" type=\"text/css\" />\r\n    <!--<![endif]-->\r\n\r\n    <!" +
"--[if lt IE 9]>\r\n      <script src=\"/assets/template/javascripts/ie.js\" type=\"te" +
"xt/javascript\"></script>\r\n    <![endif]-->\r\n\r\n    <link rel=\"shortcut icon\" href" +
"=\"/assets/template/images/favicon.ico\" type=\"image/x-icon\" />\r\n\r\n    <!-- For th" +
"ird-generation iPad with high-resolution Retina display: -->\r\n    <link rel=\"app" +
"le-touch-icon-precomposed\" sizes=\"144x144\" href=\"/assets/template/images/apple-t" +
"ouch-icon-144x144.png\">\r\n    <!-- For iPhone with high-resolution Retina display" +
": -->\r\n    <link rel=\"apple-touch-icon-precomposed\" sizes=\"114x114\" href=\"/asset" +
"s/template/images/apple-touch-icon-114x114.png\">\r\n    <!-- For first- and second" +
"-generation iPad: -->\r\n    <link rel=\"apple-touch-icon-precomposed\" sizes=\"72x72" +
"\" href=\"/assets/template/images/apple-touch-icon-72x72.png\">\r\n    <!-- For non-R" +
"etina iPhone, iPod Touch, and Android 2.1+ devices: -->\r\n    <link rel=\"apple-to" +
"uch-icon-precomposed\" href=\"/assets/template/images/apple-touch-icon-57x57.png\">" +
"\r\n\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n  " +
"  <meta property=\"og:image\" content=\"/assets/template/images/opengraph-image.png" +
"\">\r\n</head>\r\n\r\n<body class=\"mainstream full-width\">\r\n    <script type=\"text/java" +
"script\">document.body.className = ((document.body.className) ? document.body.cla" +
"ssName + \' js-enabled\' : \'js-enabled\');</script>\r\n\r\n    <div id=\"skiplink-contai" +
"ner\">\r\n      <div>\r\n        <a href=\"#content\" class=\"skiplink\">Skip to main con" +
"tent</a>\r\n      </div>\r\n    </div>\r\n\r\n    <header role=\"banner\" id=\"global-heade" +
"r\">\r\n        <div class=\"header-wrapper\">\r\n            <div class=\"header-global" +
"\">\r\n                <div class=\"header-logo\">\r\n                    <a href=\"http" +
"s://www.gov.uk/\" title=\"Go to the GOV.UK homepage\" id=\"logo\" class=\"content\">\r\n " +
"                       <img src=\"/assets/template/images/gov.uk_logotype_crown.p" +
"ng\"  width=\"35\" height=\"31\" alt=\"\"> GOV.UK\r\n                    </a>\r\n          " +
"      </div>\r\n                <div class=\"headerSection\">\r\n                    ");


            
            #line 99 "..\..\Views\Shared\GovUK\_Layout.cshtml"
               Write(RenderSection("HeaderSection", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </header>\r\n    " +
"<!--end header-->\r\n\r\n    <div id=\"content\" role=\"main\" class=\"group calculator c" +
"alculator-page\">\r\n        \r\n");


            
            #line 108 "..\..\Views\Shared\GovUK\_Layout.cshtml"
         if (ViewBag.ServiceWarningType == ServiceWarningType.Alpha)
        {
            
            
            #line default
            #line hidden
            
            #line 110 "..\..\Views\Shared\GovUK\_Layout.cshtml"
       Write(Html.Partial("~/Views/Shared/GovUK/_AlphaWarning.cshtml"));

            
            #line default
            #line hidden
            
            #line 110 "..\..\Views\Shared\GovUK\_Layout.cshtml"
                                                                      
        }
        else
        {
            
            
            #line default
            #line hidden
            
            #line 114 "..\..\Views\Shared\GovUK\_Layout.cshtml"
       Write(Html.Partial("~/Views/Shared/GovUK/_BetaWarning.cshtml"));

            
            #line default
            #line hidden
            
            #line 114 "..\..\Views\Shared\GovUK\_Layout.cshtml"
                                                                     
        }

            
            #line default
            #line hidden
WriteLiteral("        \r\n        <div id=\"messages\">\r\n            ");


            
            #line 118 "..\..\Views\Shared\GovUK\_Layout.cshtml"
       Write(RenderSection("Messages", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <header class=\"page-header group full-width\">\r\n        " +
"    <div class=\"full-width\">\r\n                <h1>\r\n                    <span>");


            
            #line 123 "..\..\Views\Shared\GovUK\_Layout.cshtml"
                     Write(ViewBag.PageType);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    ");


            
            #line 124 "..\..\Views\Shared\GovUK\_Layout.cshtml"
               Write(ViewBag.PageName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h1>\r\n            </div>\r\n        </header>\r\n        \r\n       " +
" ");


            
            #line 129 "..\..\Views\Shared\GovUK\_Layout.cshtml"
   Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    </div>\r\n\r\n    <footer class=\"group js-footer\" id=\"footer\" role=\"contentin" +
"fo\">\r\n\r\n        <div class=\"footer-wrapper\">\r\n\r\n            <div class=\"footer-m" +
"eta\">\r\n                <div class=\"footer-meta-inner\">\r\n                    <h2 " +
"class=\"visuallyhidden\">Support links</h2>\r\n                    <ul>\r\n           " +
"             <li><a target=\"_blank\" class=\"openDialog buttonLink\" data-dialog-id" +
"=\"feedbackDialog\" data-dialog-title=\"\" href=\"/feedback/1\">Feedback</a></li>\r\n   " +
"                     <li><a target=\"_blank\" href=\"/static/p-renew-online-cookies" +
"\">Cookies</a> <img src=\"/assets/govuk_frontend_toolkit-master/images/external-li" +
"nks/external-link-black-12x12.png\" alt=\"External link\" /></li>\r\n                " +
"        <li><a target=\"_blank\" href=\"/static/p-renew-online-privacy\">Privacy</a>" +
" <img src=\"/assets/govuk_frontend_toolkit-master/images/external-links/external-" +
"link-black-12x12.png\" alt=\"External link\" /></li>\r\n                    </ul>\r\n\r\n" +
"                    <div class=\"open-government-licence\">\r\n                     " +
"   <h2><a href=\"http://www.nationalarchives.gov.uk/doc/open-government-licence/v" +
"ersion/2\">Open Government Licence</a></h2>\r\n                        <p>All conte" +
"nt is available under the <a href=\"http://www.nationalarchives.gov.uk/doc/open-g" +
"overnment-licence/version/2\">Open Government Licence v2.0</a>, except where othe" +
"rwise stated</p>\r\n                    </div>\r\n\r\n                </div>\r\n\r\n      " +
"          <div class=\"copyright\">\r\n                    <a href=\"http://www.natio" +
"nalarchives.gov.uk/information-management/our-services/crown-copyright.htm\">&cop" +
"y; Crown Copyright</a>\r\n                </div>\r\n            </div>\r\n        </di" +
"v>\r\n    </footer>\r\n\r\n    <!--end footer-->\r\n\r\n    <div id=\"global-app-error\" cla" +
"ss=\"app-error hidden\"></div>\r\n\r\n    <script src=\"/assets/template/javascripts/go" +
"vuk-template.js\" type=\"text/javascript\"></script>\r\n\r\n</body>\r\n\r\n</html>\r\n");


        }
    }
}
#pragma warning restore 1591
