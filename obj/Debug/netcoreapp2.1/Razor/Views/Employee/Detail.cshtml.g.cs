#pragma checksum "C:\Users\ug479\source\repos\PayCompute\Views\Employee\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02b239c974352e9f7cb1f35749a8403b673b2615"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Detail), @"mvc.1.0.view", @"/Views/Employee/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Detail.cshtml", typeof(AspNetCore.Views_Employee_Detail))]
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
#line 1 "C:\Users\ug479\source\repos\PayCompute\Views\_ViewImports.cshtml"
using Paycompute;

#line default
#line hidden
#line 2 "C:\Users\ug479\source\repos\PayCompute\Views\_ViewImports.cshtml"
using Paycompute.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02b239c974352e9f7cb1f35749a8403b673b2615", @"/Views/Employee/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d82a17a92ca28dc354efe5ab80300d7aa4b038b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(32, 282, true);
            WriteLiteral(@"


<div class=""col-md-12 grid-margin grid-margin-md-0"">
    <div class=""card "">



        <div class=""card-body"">
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item"">
                        ");
            EndContext();
            BeginContext(314, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "115212a17ded454f95648a5307e9b6bb", async() => {
                BeginContext(358, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(366, 434, true);
            WriteLiteral(@"
                    </li>
                    <li class=""breadcrumb-item active "" aria-current=""page"">
                       Detail Employee
                    </li>

                </ol>

            </nav>

            <br /><br />
            <div class=""wrap d-flex justify-content-start justify-content-sm-center flex-wrap"">
                <img class=""rounded-circle shadow-lg"" style=""width:300px; height:350px;""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 800, "\"", 834, 1);
#line 26 "C:\Users\ug479\source\repos\PayCompute\Views\Employee\Detail.cshtml"
WriteAttributeValue("", 806, Url.Content(Model.ImageURL), 806, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(835, 156, true);
            WriteLiteral(" alt=\"\"/>\r\n                <div class=\"wrap align-items-center ml-5\">\r\n                    <p class=\"font-weight-bold text-success\" style=\"font-size:20px;\">");
            EndContext();
            BeginContext(992, 14, false);
#line 28 "C:\Users\ug479\source\repos\PayCompute\Views\Employee\Detail.cshtml"
                                                                                Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1006, 85, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\" style=\"font-size:20px;\">Role:");
            EndContext();
            BeginContext(1092, 17, false);
#line 29 "C:\Users\ug479\source\repos\PayCompute\Views\Employee\Detail.cshtml"
                                                                          Write(Model.Designation);

#line default
#line hidden
            EndContext();
            BeginContext(1109, 89, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\" style=\"font-size:20px;\">Gender : ");
            EndContext();
            BeginContext(1199, 12, false);
#line 30 "C:\Users\ug479\source\repos\PayCompute\Views\Employee\Detail.cshtml"
                                                                              Write(Model.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(1211, 95, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\" style=\"font-size:20px;\">Date of Birth: ");
            EndContext();
            BeginContext(1307, 32, false);
#line 31 "C:\Users\ug479\source\repos\PayCompute\Views\Employee\Detail.cshtml"
                                                                                    Write(Model.Dob.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1339, 94, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\" style=\"font-size:20px;\"> Employee No: ");
            EndContext();
            BeginContext(1434, 16, false);
#line 32 "C:\Users\ug479\source\repos\PayCompute\Views\Employee\Detail.cshtml"
                                                                                   Write(Model.EmployeeNo);

#line default
#line hidden
            EndContext();
            BeginContext(1450, 85, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\" style=\"font-size:20px;\">N I: ");
            EndContext();
            BeginContext(1536, 23, false);
#line 33 "C:\Users\ug479\source\repos\PayCompute\Views\Employee\Detail.cshtml"
                                                                          Write(Model.NationalInsurance);

#line default
#line hidden
            EndContext();
            BeginContext(1559, 94, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\" style=\"font-size:20px;\">Phone Number: ");
            EndContext();
            BeginContext(1654, 11, false);
#line 34 "C:\Users\ug479\source\repos\PayCompute\Views\Employee\Detail.cshtml"
                                                                                   Write(Model.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1665, 99, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\" style=\"font-size:20px;\"> Email:<a href=\"#\">");
            EndContext();
            BeginContext(1765, 11, false);
#line 35 "C:\Users\ug479\source\repos\PayCompute\Views\Employee\Detail.cshtml"
                                                                                        Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1776, 273, true);
            WriteLiteral(@"</a> </p>

                    <br /><br />
                    <p class=""font-weight-bold"">Pay &amp;Deductions</p>
                    <hr style=""background-color:crimson;"" />
                    <p class=""font-weight-normal"" style=""font-size:20px;""> Payment Method: ");
            EndContext();
            BeginContext(2050, 19, false);
#line 40 "C:\Users\ug479\source\repos\PayCompute\Views\Employee\Detail.cshtml"
                                                                                      Write(Model.PaymentMethod);

#line default
#line hidden
            EndContext();
            BeginContext(2069, 97, true);
            WriteLiteral("</p>\r\n\r\n                    <p class=\"font-weight-normal\" style=\"font-size:20px;\"> Student Loan: ");
            EndContext();
            BeginContext(2167, 17, false);
#line 42 "C:\Users\ug479\source\repos\PayCompute\Views\Employee\Detail.cshtml"
                                                                                    Write(Model.StudentLoan);

#line default
#line hidden
            EndContext();
            BeginContext(2184, 95, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\" style=\"font-size:20px;\"> Union Member: ");
            EndContext();
            BeginContext(2280, 17, false);
#line 43 "C:\Users\ug479\source\repos\PayCompute\Views\Employee\Detail.cshtml"
                                                                                    Write(Model.UnionMember);

#line default
#line hidden
            EndContext();
            BeginContext(2297, 163, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\" style=\"font-size:20px;\"><i class=\"fas fa-envelope\" style=\"margin-right:0.6em; color:cornflowerblue;\"></i><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2460, "\"", 2539, 7);
            WriteAttributeValue("", 2467, "mailto:", 2467, 7, true);
#line 44 "C:\Users\ug479\source\repos\PayCompute\Views\Employee\Detail.cshtml"
WriteAttributeValue("", 2474, Model.Email, 2474, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 2486, "?Subject=Payslip&body=Attached", 2486, 30, true);
            WriteAttributeValue(" ", 2516, "within", 2517, 7, true);
            WriteAttributeValue(" ", 2523, "is", 2524, 3, true);
            WriteAttributeValue(" ", 2526, "your", 2527, 5, true);
            WriteAttributeValue(" ", 2531, "payslip", 2532, 8, true);
            EndWriteAttribute();
            BeginContext(2540, 261, true);
            WriteLiteral(@">Send Payslip</a></p>

                    <br /><br />

                    <p class=""font-weight-bold"">Address </p>
                    <hr style=""background-color:crimson;"" />

                    <p class=""font-weight-normal"" style=""font-size:20px;"">");
            EndContext();
            BeginContext(2802, 13, false);
#line 51 "C:\Users\ug479\source\repos\PayCompute\Views\Employee\Detail.cshtml"
                                                                     Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(2815, 82, true);
            WriteLiteral("</p>\r\n\r\n                    <p class=\"font-weight-normal\" style=\"font-size:20px;\">");
            EndContext();
            BeginContext(2898, 10, false);
#line 53 "C:\Users\ug479\source\repos\PayCompute\Views\Employee\Detail.cshtml"
                                                                     Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(2908, 80, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\" style=\"font-size:20px;\">");
            EndContext();
            BeginContext(2989, 14, false);
#line 54 "C:\Users\ug479\source\repos\PayCompute\Views\Employee\Detail.cshtml"
                                                                     Write(Model.PostCode);

#line default
#line hidden
            EndContext();
            BeginContext(3003, 136, true);
            WriteLiteral("</p>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                </div>\r\n\r\n            </div>\r\n\r\n            \r\n\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3156, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 81 "C:\Users\ug479\source\repos\PayCompute\Views\Employee\Detail.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(3229, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
