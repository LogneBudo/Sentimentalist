using System;
using VaderSharp2;

namespace Sentimentalist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnalyzeSentiment();
            //or
            PerformSentimentAnalysisFromUserInput();
        }
        /// <summary>
        /// Perform sentiment analysis based on user input.
        /// </summary>
        private static void PerformSentimentAnalysisFromUserInput
            ()
        {
            try
            {
                var sentimentAnalyzer = new SentimentIntensityAnalyzer();
                Console.WriteLine("Enter text for sentiment analysis:");
                string text = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(text))
                {
                    Console.WriteLine("No text provided. Exiting.");
                    return;
                }

                var results = sentimentAnalyzer.PolarityScores(text);
                Console.WriteLine("Positive sentiment score: " + results.Positive);
                Console.WriteLine("Negative sentiment score: " + results.Negative);
                Console.WriteLine("Neutral sentiment score: " + results.Neutral);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        /// <summary>
        /// Analyze sentiment of a fixed text.
        /// </summary>
        private static void AnalyzeSentiment()
        {
            // Create an instance of the SentimentIntensityAnalyzer f
            var sentimentAnalyzer = new SentimentIntensityAnalyzer();
            // The text to be analyzed for sentiment
            string text = "It is terrible, I love it!"; // Ambiguous text
            // Get the sentiment scores for the provided text
            var results = sentimentAnalyzer.PolarityScores(text);
            // Print the positvie sentiment scores
            Console.WriteLine("Positive sentiment score: " + results.Positive);
            // Print the negative sentiment scores
            Console.WriteLine("Negative sentiment score: " + results.Negative);
            // Print the neutral sentiment scores
            Console.WriteLine("Neutral sentiment score: " + results.Neutral);
        }
    }
}
