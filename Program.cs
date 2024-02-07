using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var morseAlphabet = new Dictionary<char, string>
{
    {'A', ".-"},
    {'B', "-..."},
    {'C', "-.-."},
    {'D', "-.."},
    {'E', "."},
    {'F', "..-."},
    {'G', "--."},
    {'H', "...."},
    {'I', ".."},
    {'J', ".---"},
    {'K', "-.-"},
    {'L', ".-.."},
    {'M', "--"},
    {'N', "-."},
    {'O', "---"},
    {'P', ".--."},
    {'Q', "--.-"},
    {'R', ".-."},
    {'S', "..."},
    {'T', "-"},
    {'U', "..-"},
    {'V', "...-"},
    {'W', ".--"},
    {'X', "-..-"},
    {'Y', "-.--"},
    {'Z', "--.."}
};

app.MapGet("/", () => GetMorseAlphabet());
app.MapGet("/kryptera/{text}", (string text) => KrypteraMorse(text));
app.MapGet("/avkryptera/{morseCode}", (string morseCode) => AvkrypteraMorse(morseCode, morseAlphabet));


string GetMorseAlphabet()
{
    return JsonSerializer.Serialize(morseAlphabet);
}

string KrypteraMorse(string text)
{
    text = text.ToUpper();
    var encryptedText = new List<string>();

    foreach (char character in text)
    {
        if (morseAlphabet.ContainsKey(character))
        {
            encryptedText.Add(morseAlphabet[character]);
        }
        else if (character == ' ')
        {
            encryptedText.Add(" "); // space between words
        }
    }

    return string.Join(" ", encryptedText);
}

string AvkrypteraMorse(string morseCode, Dictionary<char, string> morseAlphabet)
{
    var morseWords = morseCode.Split(' ');

    var decryptedText = new List<char>();

    foreach (var morseWord in morseWords)
    {
        if (morseWord == "")
        {
            decryptedText.Add(' '); // space between words
            continue;
        }

        foreach (var (key, value) in morseAlphabet)
        {
            if (value == morseWord)
            {
                decryptedText.Add(key);
                break;
            }
        }
    }

    return new string(decryptedText.ToArray());
}


app.Run();

