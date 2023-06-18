using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;

Console.WriteLine("Welcome, again!");

var speechConfig = SpeechConfig.FromSubscription("", ""); // Replace with your own subscription key and region
// await AudioFromic(speechConfig); // Uncomment to use microphone
// await AudioFromFile(speechConfig); // Uncomment to use audio file

Console.WriteLine("Press any key to exit...");
Console.ReadLine();

async static Task AudioFromic(SpeechConfig speechConfig)
{
    using var audioConfig = AudioConfig.FromDefaultMicrophoneInput();
    using var recognizer = new SpeechRecognizer(speechConfig, "es-MX", audioConfig);
    
    Console.WriteLine("Speak into your microphone.");
    var result = await recognizer.RecognizeOnceAsync();
    Console.WriteLine("You say: " + result.Text);
}

async static Task AudioFromFile(SpeechConfig speechConfig)
{
    using var audioConfig = AudioConfig.FromWavFileInput("audio.wav");
    using var recognizer = new SpeechRecognizer(speechConfig, "es-MX", audioConfig);
    
    Console.WriteLine("Recognizing first result...");
    var result = await recognizer.RecognizeOnceAsync();
    Console.WriteLine("The audio says: " + result.Text);
}
