
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Model
{
    public sealed class ConfigurationManager
    {
        private static readonly Lazy<ConfigurationManager> instance = new Lazy<ConfigurationManager>(() => new ConfigurationManager());
        // Private constructor to prevent instantiation from outside
        private ConfigurationManager()
        {
        }
        public static ConfigurationManager Instance
        {
            get
            {
                return instance.Value;
            }
        }
        // Example method to demonstrate functionality
        public void DisplayConfiguration()
        {
            Console.WriteLine("Configuration settings displayed.");
        }
    }
}

