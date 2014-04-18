using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;
using Splunk;

namespace $safeprojectname$
{
	public class Main
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


            //// Search : Pull model (foreach loop => IEnumerable)
            Job job = await service.StartJobAsync("search index=_internal | head 10");
            SearchResults searchResults;

            using (searchResults = await job.GetSearchResultsAsync())
            {
                int recordNumber = 0;
                try
                {
                    foreach (var record in searchResults)
                    {
                        Console.WriteLine(string.Format("{0:D8}: {1}", ++recordNumber, record));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(string.Format("SearchResults error: {0}", e.Message));
                }
            }
        }
	}
}
