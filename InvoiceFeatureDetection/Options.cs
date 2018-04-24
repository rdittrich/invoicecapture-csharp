﻿using CommandLine;
using CommandLine.Text;

namespace InvoiceCapture
{
  public class Options
  {
    [Option('i', "invoiceFolder", Required = true, HelpText = "Folder which contains invoice that shall be processed")]
    public string InvoiceFolder { get; set; }

    [Option('k', "key", Required = true, HelpText = "Your API key token")]
    public string Key { get; set; }

    [HelpOption]
    public string GetUsage()
    {
      return HelpText.AutoBuild(this, current => HelpText.DefaultParsingErrorsHandler(this, current));
    }
  }
}
