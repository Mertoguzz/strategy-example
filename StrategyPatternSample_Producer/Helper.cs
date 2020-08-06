using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StrategyPatternSample_Producer
{
    public class Helper
    {

        public  string GetConfig(string rootSection,string subSection="")
        {
            var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("Parameters.json", optional: true, reloadOnChange: true);
            string strConnection = builder.Build().GetSection(rootSection).Value;
            if (!string.IsNullOrEmpty(subSection))
            {
                strConnection= builder.Build().GetSection(rootSection).GetSection(subSection).Value;
            }
            return strConnection;
        }
    }
}
