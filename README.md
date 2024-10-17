# Sentimentalist

Sentimentalist is a simple C# console application that uses the `VaderSharp2` library to perform sentiment analysis on a given text. The application analyzes the text and provides scores for positive, negative, and neutral sentiments.

## Features

- Analyzes text for sentiment using the VaderSharp2 library.
- Outputs positive, negative, and neutral sentiment scores.
- Easy to use and extend.

## Prerequisites

- .NET Framework 4.8
- Visual Studio or any other compatible IDE

## Getting Started

### Clone the Repository

### Open the Project

1. Open Visual Studio.
2. Select `File` -> `Open` -> `Project/Solution`.
3. Navigate to the cloned repository folder and select `Sentimentalist.sln`.

### Build and Run

1. Build the solution by selecting `Build` -> `Build Solution` or pressing `Ctrl+Shift+B`.
2. Run the application by selecting `Debug` -> `Start Debugging` or pressing `F5`.

### Usage

1. The application will prompt you to enter text for sentiment analysis.
2. Enter the text and press `Enter`.
3. The application will output the positive, negative, and neutral sentiment scores.

### Example
```csharp
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
```

## Code Explanation

The main logic of the application is in the `Program.cs` file:
The output to the console:

```csharp
Console output:  

Positive sentiment score: 0.388
Negative sentiment score: 0.267
Neutral sentiment score: 0.345
```
	
## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Acknowledgements

- [VaderSharp2](https://github.com/codingupastorm/vadersharp) - A C# implementation of the VADER sentiment analysis tool.
