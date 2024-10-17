using System;
using VaderSharp2;

namespace Sentimentalist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sentimentAnalyzer = new SentimentIntensityAnalyzer();
            string text = "It is terrible, I love it!"; // Ambiguous text            
            var results = sentimentAnalyzer.PolarityScores(text);
            Console.WriteLine("Positive sentiment score: " + results.Positive);
            Console.WriteLine("Negative sentiment score: " + results.Negative);
            Console.WriteLine("Neutral sentiment score: " + results.Neutral);
        }
    }
}
