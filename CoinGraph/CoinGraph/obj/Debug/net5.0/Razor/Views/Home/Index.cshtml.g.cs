#pragma checksum "C:\Users\denis\OneDrive\Documents\Diplom CoinGraph\CoinGraph\CoinGraph\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83731c956c3aed892e62646d10c355f384dc0256"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\denis\OneDrive\Documents\Diplom CoinGraph\CoinGraph\CoinGraph\Views\_ViewImports.cshtml"
using CoinGraph;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\denis\OneDrive\Documents\Diplom CoinGraph\CoinGraph\CoinGraph\Views\_ViewImports.cshtml"
using CoinGraph.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83731c956c3aed892e62646d10c355f384dc0256", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"653f09aefa6a63e712acf8735e0986c70bf45208", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\denis\OneDrive\Documents\Diplom CoinGraph\CoinGraph\CoinGraph\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""tradingview-widget-container"">
  <div id=""tradingview_52421""></div>
  <div class=""tradingview-widget-copyright"">
  <a href=""https://ru.tradingview.com/symbols/BTCUSDT/?exchange=BINANCE"" rel=""noopener"" target=""_blank"">
  <span class=""blue-text"">
  </span>
  </a> 
  </div>
  <script type=""text/javascript"" src=""https://s3.tradingview.com/tv.js"">
  </script>
  <script type=""text/javascript"">
  new TradingView.MediumWidget(
  {
  ""symbols"": [
    [
      ""BTC/USDT"",
      ""BINANCE:BTCUSDT|ALL""
    ],
    [
      ""SOL/USDT"",
      ""BINANCE:SOLUSDT|ALL""
    ],
    [
      ""MATIC/USDT"",
      ""BINANCE:MATICUSDT|ALL""
    ],
    [
      ""AVAX/USDT"",
      ""BINANCE:AVAXUSDT|ALL""
    ],
    [
      ""ATOM/USDT"",
      ""BINANCE:ATOMUSDT|ALL""
    ],
    [
      ""ADA/USDT"",
      ""BINANCE:ADAUSDT|ALL""
    ],
    [
      ""SHIB/USDT"",
      ""BINANCE:SHIBUSDT|ALL""
    ],
    [
      ""XRP/USDT"",
      ""BINANCE:XRPUSDT|ALL""
    ],
    [
      ""DOGE/USDT"",
      ""BINANCE:");
            WriteLiteral(@"DOGEUSDT|ALL""
    ],
    [
      ""LTC/USDT"",
      ""BINANCE:LTCUSDT|ALL""
    ],
    [
      ""GALA/USDT"",
      ""BINANCE:GALAUSDT|ALL""
    ]
  ],
  ""chartOnly"": false,
  ""width"": 1110,
  ""height"": 400,
  ""locale"": ""ru"",
  ""colorTheme"": ""dark"",
  ""autosize"": false,
  ""showVolume"": false,
  ""hideDateRanges"": false,
  ""scalePosition"": ""right"",
  ""scaleMode"": ""Normal"",
  ""fontFamily"": ""Arial, sans-serif"",
  ""noTimeScale"": false,
  ""valuesTracking"": ""2"",
  ""chartType"": ""candlesticks"",
  ""fontColor"": ""rgba(255, 255, 255, 1)"",
  ""gridLineColor"": ""rgba(255, 255, 255, 0.06)"",
  ""backgroundColor"": ""#131722"",
  ""upColor"": ""#22ab94"",
  ""downColor"": ""#f7525f"",
  ""borderUpColor"": ""#22ab94"",
  ""borderDownColor"": ""#f7525f"",
  ""wickUpColor"": ""#22ab94"",
  ""wickDownColor"": ""#f7525f"",
  ""container_id"": ""tradingview_52421""
}
  );
  </script>
</div>
<crypto-converter-widget shadow symbol live background-color=""#131722"" border-radius=""0.00rem"" fiat=""united-states-dollar"" crypto=""bitcoin"" amount");
            WriteLiteral("=\"1\" font-family=\"Arial, sans-serif\" decimal-places=\"2\">\r\n\r\n</crypto-converter-widget>\r\n<a>\r\n CoinGraph\r\n</a>\r\n<script async src=\"https://cdn.jsdelivr.net/gh/dejurin/crypto-converter-widget@1.5.2/dist/latest.min.js\">\r\n    </script>\r\n");
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
