using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;

Console.WriteLine("Hello, World!");

var speechConfig = SpeechConfig.FromSubscription("", "centralus");

async static Task AudioFromic(SpeechConfig speechConfig)
{
    using var audioConfig = AudioConfig.FromDefaultMicrophoneInput();
    using var recognizer = new SpeechRecognizer(speechConfig, "es-MX", audioConfig);
    
    Console.WriteLine("Speak into your microphone.");
    var result = await recognizer.RecognizeOnceAsync();
    Console.WriteLine(result.Text);
}
