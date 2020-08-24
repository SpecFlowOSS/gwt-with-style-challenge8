using System;
using TechTalk.SpecFlow;

namespace Specs.Support
{
    [Binding]
    public class TemplateArgumentsTransformation
    {
        [StepArgumentTransformation(@"^\{(.*)\}$")]
        public string HandleTemplateArguments(string placeholderName)
        {
            return Environment.GetEnvironmentVariable(placeholderName) ?? $"{{{placeholderName}}}";

        }
    }
}
