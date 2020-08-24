using System;
using TechTalk.SpecFlow;

namespace Specs.Support
{
    [Binding]
    public class TemplateArgumentsTransformation
    {
        [StepArgumentTransformation]
        public string HandleTemplateArguments(string arg)
        {
            var value = arg;

            if (arg.StartsWith("{") && arg.EndsWith("}"))
            {
                var variableName = arg.Trim('{', '}');
                var variableValue = Environment.GetEnvironmentVariable(variableName);

                if (variableValue != null)
                    value = variableValue;
            }

            return value;
        }
    }
}
