using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TextBasedRpg
{
    public class Introduction
    {
        public string PlayerName { get; set; }
        public string? Name { get; }

        private static string[] introductionLines=
        {
            "In the mystical land of Eldoria, where magic and might intertwine, peace has reigned for centuries under the watchful eye of the ancient guardians. "+
            "However, a dark shadow now looms over the horizon as the malevolent sorcerer, Malakar, seeks to resurrect an ancient evil long thought vanquished. "+
            "The harmony of Eldoria is threatened, and its fate lies in the hands of a brave soul destined to rise against the encroaching darkness. ",
            "You are {playerName} a young warrior from the tranquil village of Starhaven. "+
            "Raised on tales of heroism and adventure, you have always dreamed of exploring the world beyond the village borders. "+
            "On the eve of your 18th birthday, a mysterious stranger arrives in Starhaven, bearing an urgent message from the High Council of Eldoria. "+
            "The guardians have chosen you, {playerName}, to embark on a perilous quest to thwart Malakar’s sinister plans and restore peace to the land.",
            "Armed with your trusty sword and the blessings of the guardians, you set out on an epic journey across diverse landscapes—from the enchanted forests of Valoria to the treacherous peaks of Mount Obsidian. "+
            "Along the way, you will encounter allies who will aid you in your quest, face formidable foes, and uncover hidden secrets about your own past and the true nature of the ancient evil that threatens Eldoria.",
            "The fate of the realm is in your hands, brave adventurer. "+
            "Will you rise to the challenge and become the hero Eldoria desperately needs? The journey begins now..."
        };

        public Introduction(string playerName)
        {
            PlayerName = playerName;
        }

        public void Story()
        {
            foreach (string line in introductionLines)
            {
                string newLine = line.Replace("{playerName}", PlayerName);
                Console.WriteLine(newLine);
                Console.ReadKey();
            }
        }
    }
}