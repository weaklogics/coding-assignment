using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Assignment.Utility
{
   
        //Microsoft.Extensions.Configuration
        //Microsoft.Extensions.Configuration.FileExtension
        //Microst.extensions.Configuration.json
        internal static class DbConUtil
        {
            private static IConfiguration _iconfiguration;
            //create a constructor
            static DbConUtil()
            {
                GetAppSettingsFile();
            }

            private static void GetAppSettingsFile()
            {
                var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json");
                _iconfiguration = builder.Build();

            }

            public static string GetConnectionString()
            {
                return _iconfiguration.GetConnectionString("LocalConnectionString");
            }
        }
    }

