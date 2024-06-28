using System;
using System.Text.Json;
using System.IO;


namespace TextBasedRpg
{
    public class Introduction
    {
        private static string jsonPath = "data/lines.json";
        public string PlayerName { get; set; }

        private string[] introductionLines;
        public Introduction(string playerName)
        {
            PlayerName = playerName;
            AccessJsonLines();
        }

        private void AccessJsonLines(){
            JsonDocument doc = JsonDocument.Parse(File.ReadAllText(jsonPath));
            JsonElement root=doc.RootElement;
            if (root.GetProperty("intro").ValueKind == JsonValueKind.Array)
            {
                JsonElement introElement = root.GetProperty("intro");
                introductionLines = new string[introElement.GetArrayLength()];
            
                int index = 0;
                foreach (JsonElement line in introElement.EnumerateArray())
                {
                    if (line.ValueKind == JsonValueKind.String)
                    {
                        introductionLines[index] = line.GetString();
                    }
                    else
                    {
                        introductionLines[index] = "";
                    }
                    index++;
                }
            } else {
                Console.WriteLine("Error: 'intro' should be an array.");
                Environment.Exit(1);
            }
        }

        public void Story()
        {
            foreach (string line in introductionLines)
            {
                string newLine = line.Replace("{playerName}", PlayerName);
                if(newLine!=""){
                    Console.WriteLine(newLine);
                    Console.ReadKey();
                }
            }
        }
    }
}