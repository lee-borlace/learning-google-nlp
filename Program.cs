using Google.Cloud.Language.V1;
using System;

namespace GoogleNLP
{
    class Program
    {
        static void Main(string[] args)
        {
            // The text to analyze.
            //string text = "the dog chased the cat";
            string text = "the man hungrily ate the delicious hamburger with a fork";

            var client = LanguageServiceClient.Create();

            var document = new Document()
            {
                Content = text,
                Type = Document.Types.Type.PlainText
            };

            var response = client.AnalyzeSyntax(document);




        }
    }
}
