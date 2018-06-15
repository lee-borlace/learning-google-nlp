using Google.Cloud.Language.V1;
using System;

namespace GoogleNLP
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = LanguageServiceClient.Create();

            while (true)
            {
                Console.Write("Input>");

                var text = Console.ReadLine();

                var document = new Document()
                {
                    Content = text,
                    Type = Document.Types.Type.PlainText
                };

                var response = client.AnalyzeSyntax(document);

                Console.WriteLine(response.Tokens);
            }


        }
    }
}
