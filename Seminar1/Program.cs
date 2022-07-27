string text = String.Empty;

int count = 50;
string[] letters = {"o", "c", "e", "p"};

Random random = new Random();
for (int id = 1; id <= count; id++)
{
    int number = random.Next(100, 1000);
    string letter = letters[random.Next(letters.Length)];
    text += $"{id};\t{letter}{number}{letter}{letter}{" "}{11}\n";
}

// System.Console.WriteLine(text);
File.WriteAllText("output.csv", text);