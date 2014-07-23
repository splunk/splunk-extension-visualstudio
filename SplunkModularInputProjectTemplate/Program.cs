using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Splunk.ModularInputs;

namespace $safeprojectname$
{
    public class Program : ModularInput
    {
        /// <summary>
        /// Main method which dispatches to ModularInput.Run&lt;T&gt;.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>An exit code.</returns>
        public static int Main(string[] args)
        {
            return Run<Program>(args);
        }

        /// <summary>
        /// Define a Scheme instance that describes this modular input's behavior. The scheme
        /// will be serialized to XML and printed to stdout when this program is invoked with
        /// the sole argument <tt>--scheme</tt>, which Splunk does when starting up and each time
        /// the app containing the modular input is enabled.
        /// </summary>
        /// <remarks>
        /// You must define a Title, Description, and a list of Arguments. Each argument
        /// you list here must also be specified in
        /// <tt>$safeprojectname$\README\inputs.conf.spec</tt>.
        /// </remarks>
        public override Scheme Scheme
        {
            get {
                return new Scheme
                {$if$ ($generateExampleImplementation$ == true)
                    Title = "Random numbers",
                    Description = "Generate random numbers in the specified range",
                    Arguments = new List<Argument>
                    {
                            new Argument
                            {
                                Name = "min",
                                Description = "Generated value should be at least min",
                                DataType = DataType.Number,
                                RequiredOnCreate = true
                            },
                            new Argument
                            {
                                Name = "max",
                                Description = "Generated value should be less than max",
                                DataType = DataType.Number,
                                RequiredOnCreate = true
                            }
                    }$endif$
                };

            }
        }
           
        /// <summary>
        /// Check that the values of arguments specified for a newly created or edited instance of
        /// this modular input are valid. If they are valid, set <tt>errorMessage</tt> to <tt>""</tt>
        /// and return <tt>true</tt>. Otherwise, set <tt>errorMessage</tt> to an informative explanation 
        /// of what makes the arguments invalid and return <tt>false</tt>.
        /// </summary>
        /// <param name="validation">a Validation object specifying the new argument values.</param>
        /// <param name="errorMessage">an output parameter to pass back an error message.</param>
        /// <returns><tt>true</tt> if the arguments are valid and <tt>false</tt> otherwise.</returns>
        public override bool Validate(Validation validation, out string errorMessage)
        {$if$ ($generateExampleImplementation$ == true)
            double min = validation.Parameters["min"].ToDouble();
            double max = validation.Parameters["max"].ToDouble();

            if (min >= max) {
                errorMessage = "min must be less than max.";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }$endif$$if$ ($generateExampleImplementation$ == false)
			errorMessage = "";
			return true;$endif$
        }

        /// <summary>
        /// Write events to Splunk from this modular input.
        /// </summary>
        /// <remarks>
        /// This function will be invoked once for each instance of the modular input, though that invocation
        /// may or may not be in separate processes, depending on how the modular input is configured. It should
        /// extract the arguments it needs from <tt>inputDefinition</tt>, then write events to <tt>eventWriter</tt>
        /// (which is thread safe).
        /// </remarks>
        /// <param name="inputDefinition">a specification of this instance of the modular input.</param>
        /// <param name="eventWriter">an object that handles writing events to Splunk.</param>
        public override async Task StreamEventsAsync(InputDefinition inputDefinition, EventWriter eventWriter)
        {$if$ ($generateExampleImplementation$ == true)
            double min = inputDefinition.Parameters["min"].ToDouble();
            double max = inputDefinition.Parameters["max"].ToDouble();

            Random rnd = new Random();

            while (true)
            {
                await Task.Delay(1000);
                await eventWriter.QueueEventForWriting(new Event
                {
                    Stanza = inputDefinition.Name,
                    Data = "number=" + (rnd.NextDouble() * (max - min) + min)
                });
            }$endif$
        }
    }
}
