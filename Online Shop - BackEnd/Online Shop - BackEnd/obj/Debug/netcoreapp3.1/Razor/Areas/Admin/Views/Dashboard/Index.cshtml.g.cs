#pragma checksum "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Areas\Admin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a4436692aea3b93eafef986d0ad9de9cbac291f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
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
#line 1 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Areas\Admin\Views\_ViewImports.cshtml"
using Online_Shop___BackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Areas\Admin\Views\_ViewImports.cshtml"
using Online_Shop___BackEnd.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a4436692aea3b93eafef986d0ad9de9cbac291f", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53b4d3ec24aab54a6c9f9243b341d7cf17047bc4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""main-panel"">
    <div class=""content-wrapper"">
        <div class=""row"">
            <div class=""col-md-12 grid-margin"">
                <div class=""d-flex justify-content-between flex-wrap"">
                    <div class=""d-flex align-items-end flex-wrap"">
                        <div class=""me-md-3 me-xl-5"">
                            <h2>Welcome back,</h2>
                            <p class=""mb-md-0"">Your analytics dashboard template.</p>
                        </div>
                        <div class=""d-flex"">
                            <i class=""mdi mdi-home text-muted hover-cursor""></i>
                            <p class=""text-muted mb-0 hover-cursor"">
                                &nbsp;/&nbsp;Dashboard&nbsp;/&nbsp;
                            </p>
                            <p class=""text-primary mb-0 hover-cursor"">Analytics</p>
                        </div>
                    </div>
                    <div class=""d-flex justify-content-between align-items-");
            WriteLiteral(@"end flex-wrap"">
                        <button type=""button""
                                class=""btn btn-light bg-white btn-icon me-3 d-none d-md-block"">
                            <i class=""mdi mdi-download text-muted""></i>
                        </button>
                        <button type=""button""
                                class=""btn btn-light bg-white btn-icon me-3 mt-2 mt-xl-0"">
                            <i class=""mdi mdi-clock-outline text-muted""></i>
                        </button>
                        <button type=""button""
                                class=""btn btn-light bg-white btn-icon me-3 mt-2 mt-xl-0"">
                            <i class=""mdi mdi-plus text-muted""></i>
                        </button>
                        <button class=""btn btn-primary mt-2 mt-xl-0"">
                            Generate report
                        </button>
                    </div>
                </div>
            </div>
        </div>
        <div class=""r");
            WriteLiteral(@"ow"">
            <div class=""col-md-12 grid-margin stretch-card"">
                <div class=""card"">
                    <div class=""card-body dashboard-tabs p-0"">
                        <ul class=""nav nav-tabs px-4"" role=""tablist"">
                            <li class=""nav-item"">
                                <a class=""nav-link active""
                                   id=""overview-tab""
                                   data-bs-toggle=""tab""
                                   href=""#overview""
                                   role=""tab""
                                   aria-controls=""overview""
                                   aria-selected=""true"">Overview</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link""
                                   id=""sales-tab""
                                   data-bs-toggle=""tab""
                                   href=""#sales""
                                   ");
            WriteLiteral(@"role=""tab""
                                   aria-controls=""sales""
                                   aria-selected=""false"">Sales</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link""
                                   id=""purchases-tab""
                                   data-bs-toggle=""tab""
                                   href=""#purchases""
                                   role=""tab""
                                   aria-controls=""purchases""
                                   aria-selected=""false"">Purchases</a>
                            </li>
                        </ul>
                        <div class=""tab-content py-0 px-0"">
                            <div class=""tab-pane fade show active""
                                 id=""overview""
                                 role=""tabpanel""
                                 aria-labelledby=""overview-tab"">
                                <div clas");
            WriteLiteral(@"s=""d-flex flex-wrap justify-content-xl-between"">
                                    <div class=""d-none d-xl-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-calendar-heart icon-lg me-3 text-primary""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Start date</small>
                                            <div class=""dropdown"">
                                                <a class=""btn btn-secondary dropdown-toggle p-0 bg-transparent border-0 text-dark shadow-none font-weight-medium""
                                                   href=""#""
                                                   role=""button""
                                                   id=""dropdownMenuLinkA""
                                                   data-bs-toggle=""dropdown""
                  ");
            WriteLiteral(@"                                 aria-haspopup=""true""
                                                   aria-expanded=""false"">
                                                    <h5 class=""mb-0 d-inline-block"">
                                                        26 Jul 2018
                                                    </h5>
                                                </a>
                                                <div class=""dropdown-menu""
                                                     aria-labelledby=""dropdownMenuLinkA"">
                                                    <a class=""dropdown-item"" href=""#"">12 Aug 2018</a>
                                                    <a class=""dropdown-item"" href=""#"">22 Sep 2018</a>
                                                    <a class=""dropdown-item"" href=""#"">21 Oct 2018</a>
                                                </div>
                                            </div>
                                        </");
            WriteLiteral(@"div>
                                    </div>
                                    <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-currency-usd me-3 icon-lg text-danger""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Revenue</small>
                                            <h5 class=""me-2 mb-0"">$577545</h5>
                                        </div>
                                    </div>
                                    <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-eye me-3 icon-lg text-success""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            ");
            WriteLiteral(@"<small class=""mb-1 text-muted"">Total views</small>
                                            <h5 class=""me-2 mb-0"">9833550</h5>
                                        </div>
                                    </div>
                                    <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-download me-3 icon-lg text-warning""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Downloads</small>
                                            <h5 class=""me-2 mb-0"">2233783</h5>
                                        </div>
                                    </div>
                                    <div class=""d-flex py-3 border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-");
            WriteLiteral(@"flag me-3 icon-lg text-danger""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Flagged</small>
                                            <h5 class=""me-2 mb-0"">3497843</h5>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""tab-pane fade""
                                 id=""sales""
                                 role=""tabpanel""
                                 aria-labelledby=""sales-tab"">
                                <div class=""d-flex flex-wrap justify-content-xl-between"">
                                    <div class=""d-none d-xl-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-calendar-heart icon-lg me-3 text-primary");
            WriteLiteral(@"""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Start date</small>
                                            <div class=""dropdown"">
                                                <a class=""btn btn-secondary dropdown-toggle p-0 bg-transparent border-0 text-dark shadow-none font-weight-medium""
                                                   href=""#""
                                                   role=""button""
                                                   id=""dropdownMenuLinkA""
                                                   data-bs-toggle=""dropdown""
                                                   aria-haspopup=""true""
                                                   aria-expanded=""false"">
                                                    <h5 class=""mb-0 d-inline-block"">
                                                        26 Jul 2018
          ");
            WriteLiteral(@"                                          </h5>
                                                </a>
                                                <div class=""dropdown-menu""
                                                     aria-labelledby=""dropdownMenuLinkA"">
                                                    <a class=""dropdown-item"" href=""#"">12 Aug 2018</a>
                                                    <a class=""dropdown-item"" href=""#"">22 Sep 2018</a>
                                                    <a class=""dropdown-item"" href=""#"">21 Oct 2018</a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-download me-3 icon-lg text-warning""></i>
        ");
            WriteLiteral(@"                                <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Downloads</small>
                                            <h5 class=""me-2 mb-0"">2233783</h5>
                                        </div>
                                    </div>
                                    <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-eye me-3 icon-lg text-success""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Total views</small>
                                            <h5 class=""me-2 mb-0"">9833550</h5>
                                        </div>
                                    </div>
                                    <div class=""d-flex border-md-right f");
            WriteLiteral(@"lex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-currency-usd me-3 icon-lg text-danger""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Revenue</small>
                                            <h5 class=""me-2 mb-0"">$577545</h5>
                                        </div>
                                    </div>
                                    <div class=""d-flex py-3 border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-flag me-3 icon-lg text-danger""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Flagged</small>
                                            <h5 class=""me-2 mb-0"">349");
            WriteLiteral(@"7843</h5>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""tab-pane fade""
                                 id=""purchases""
                                 role=""tabpanel""
                                 aria-labelledby=""purchases-tab"">
                                <div class=""d-flex flex-wrap justify-content-xl-between"">
                                    <div class=""d-none d-xl-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-calendar-heart icon-lg me-3 text-primary""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Start date</small>
                                            <div class=""dropdown"">
                   ");
            WriteLiteral(@"                             <a class=""btn btn-secondary dropdown-toggle p-0 bg-transparent border-0 text-dark shadow-none font-weight-medium""
                                                   href=""#""
                                                   role=""button""
                                                   id=""dropdownMenuLinkA""
                                                   data-bs-toggle=""dropdown""
                                                   aria-haspopup=""true""
                                                   aria-expanded=""false"">
                                                    <h5 class=""mb-0 d-inline-block"">
                                                        26 Jul 2018
                                                    </h5>
                                                </a>
                                                <div class=""dropdown-menu""
                                                     aria-labelledby=""dropdownMenuLinkA"">
                 ");
            WriteLiteral(@"                                   <a class=""dropdown-item"" href=""#"">12 Aug 2018</a>
                                                    <a class=""dropdown-item"" href=""#"">22 Sep 2018</a>
                                                    <a class=""dropdown-item"" href=""#"">21 Oct 2018</a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-currency-usd me-3 icon-lg text-danger""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Revenue</small>
                                            <h5 class=""me-2 mb-0"">$577545</h5>
                       ");
            WriteLiteral(@"                 </div>
                                    </div>
                                    <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-eye me-3 icon-lg text-success""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Total views</small>
                                            <h5 class=""me-2 mb-0"">9833550</h5>
                                        </div>
                                    </div>
                                    <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-download me-3 icon-lg text-warning""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                        ");
            WriteLiteral(@"                    <small class=""mb-1 text-muted"">Downloads</small>
                                            <h5 class=""me-2 mb-0"">2233783</h5>
                                        </div>
                                    </div>
                                    <div class=""d-flex py-3 border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                        <i class=""mdi mdi-flag me-3 icon-lg text-danger""></i>
                                        <div class=""d-flex flex-column justify-content-around"">
                                            <small class=""mb-1 text-muted"">Flagged</small>
                                            <h5 class=""me-2 mb-0"">3497843</h5>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
    ");
            WriteLiteral(@"    </div>
        <div class=""row"">
            <div class=""col-md-7 grid-margin stretch-card"">
                <div class=""card"">
                    <div class=""card-body"">
                        <p class=""card-title"">Cash deposits</p>
                        <p class=""mb-4"">
                            To start a blog, think of a topic about and first
                            brainstorm party is ways to write details
                        </p>
                        <div id=""cash-deposits-chart-legend""
                             class=""d-flex justify-content-center pt-3""></div>
                        <canvas id=""cash-deposits-chart""></canvas>
                    </div>
                </div>
            </div>
            <div class=""col-md-5 grid-margin stretch-card"">
                <div class=""card"">
                    <div class=""card-body"">
                        <p class=""card-title"">Total sales</p>
                        <h1>$ 28835</h1>
                        <h4");
            WriteLiteral(@">Gross sales over the years</h4>
                        <p class=""text-muted"">
                            Today, many people rely on computers to do homework, work,
                            and create or store useful information. Therefore, it is
                            important
                        </p>
                        <div id=""total-sales-chart-legend""></div>
                    </div>
                    <canvas id=""total-sales-chart""></canvas>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12 stretch-card"">
                <div class=""card"">
                    <div class=""card-body"">
                        <p class=""card-title"">Recent Purchases</p>
                        <div class=""table-responsive"">
                            <table id=""recent-purchases-listing"" class=""table"">
                                <thead>
                                    <tr>
                                    ");
            WriteLiteral(@"    <th>Name</th>
                                        <th>Status report</th>
                                        <th>Office</th>
                                        <th>Price</th>
                                        <th>Date</th>
                                        <th>Gross amount</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Jeremy Ortega</td>
                                        <td>Levelled up</td>
                                        <td>Catalinaborough</td>
                                        <td>$790</td>
                                        <td>06 Jan 2018</td>
                                        <td>$2274253</td>
                                    </tr>
                                    <tr>
                                        <td>Alvin Fisher</td>
                          ");
            WriteLiteral(@"              <td>Ui design completed</td>
                                        <td>East Mayra</td>
                                        <td>$23230</td>
                                        <td>18 Jul 2018</td>
                                        <td>$83127</td>
                                    </tr>
                                    <tr>
                                        <td>Emily Cunningham</td>
                                        <td>support</td>
                                        <td>Makennaton</td>
                                        <td>$939</td>
                                        <td>16 Jul 2018</td>
                                        <td>$29177</td>
                                    </tr>
                                    <tr>
                                        <td>Minnie Farmer</td>
                                        <td>support</td>
                                        <td>Agustinaborough</td>
                         ");
            WriteLiteral(@"               <td>$30</td>
                                        <td>30 Apr 2018</td>
                                        <td>$44617</td>
                                    </tr>
                                    <tr>
                                        <td>Betty Hunt</td>
                                        <td>Ui design not completed</td>
                                        <td>Lake Sandrafort</td>
                                        <td>$571</td>
                                        <td>25 Jun 2018</td>
                                        <td>$78952</td>
                                    </tr>
                                    <tr>
                                        <td>Myrtie Lambert</td>
                                        <td>Ui design completed</td>
                                        <td>Cassinbury</td>
                                        <td>$36</td>
                                        <td>05 Nov 2018</td>
                   ");
            WriteLiteral(@"                     <td>$36422</td>
                                    </tr>
                                    <tr>
                                        <td>Jacob Kennedy</td>
                                        <td>New project</td>
                                        <td>Cletaborough</td>
                                        <td>$314</td>
                                        <td>12 Jul 2018</td>
                                        <td>$34167</td>
                                    </tr>
                                    <tr>
                                        <td>Ernest Wade</td>
                                        <td>Levelled up</td>
                                        <td>West Fidelmouth</td>
                                        <td>$484</td>
                                        <td>08 Sep 2018</td>
                                        <td>$50862</td>
                                    </tr>
                                </tbody>
    ");
            WriteLiteral(@"                        </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- content-wrapper ends -->
    <!-- partial:partials/_footer.html -->
    <footer class=""footer"">
        <div class=""d-sm-flex justify-content-center justify-content-sm-between"">
            <span class=""text-muted text-center text-sm-left d-block d-sm-inline-block"">
                Copyright ©
                <a href=""https://www.bootstrapdash.com/"" target=""_blank"">bootstrapdash.com </a>2021
            </span>
            <span class=""float-none float-sm-right d-block mt-1 mt-sm-0 text-center"">
                Only the best
                <a href=""https://www.bootstrapdash.com/"" target=""_blank"">
                    Bootstrap dashboard
                </a>
                templates
            </span>
        </div>
    </footer>
    <!-- partial -->
</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
