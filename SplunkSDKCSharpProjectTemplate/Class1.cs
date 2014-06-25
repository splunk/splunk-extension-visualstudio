using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Splunk.Client;

// This is a template for new users of the Splunk SDK for Java.
// The code below connects to a Splunk instance, runs a search,
// and prints out the results in a crude form.
namespace $safeprojectname$
{
	public class Class1
	{
        static void Main(string[] args)
        {
            using (var service = new Service(Scheme.Https, "localhost", 8089))
            {
                Run(service).Wait();
            }
        }


        static async Task Run(Service service)
        {
            //// Login
            await service.LoginAsync("admin", "changeme");

            var query = "search index=_internal | head 5";
            var args = new JobArgs {
                	// For a full list of options, see:
	            	//
		            //     http://docs.splunk.com/Documentation/Splunk/latest/RESTAPI/RESTsearch#POST_search.2Fjobs

		            EarliestTime = "now-1w",
                    LatestTime = "now"
            };

            using (SearchResultStream resultStream = await service.SearchOneshotAsync(query, args))
            {
                foreach (SearchResult result in resultStream)
                {
                    Console.WriteLine(result);
                }
            }
        }
	}
}
