using Google.Cloud.Language.V1;
using System;
using System.IO;

namespace GoogleNLP
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = LanguageServiceClient.Create();

            // Loop through input, generating output JSON files.
            while (true)
            {
                Console.Write("Input >");

                var text = Console.ReadLine().Trim();

                var document = new Document()
                {
                    Content = text,
                    Type = Document.Types.Type.PlainText
                };

                var response = client.AnalyzeSyntax(document);

                using (var writer = new StreamWriter($"..\\..\\..\\AnalysedJson\\{text}.json", false))
                {
                    writer.Write(response.Tokens);
                }


            }
        }



    }
}
