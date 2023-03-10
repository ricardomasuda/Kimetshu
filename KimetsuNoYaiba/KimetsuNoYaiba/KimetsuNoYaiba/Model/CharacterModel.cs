using System.Collections.Generic;
using Newtonsoft.Json;

namespace KimetsuNoYaiba.Model
{
    public class CharacterModel
    {
        public string Name { get; set; }
        public List<string> Gallery { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
        public string Race { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Birthday { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Affiliation { get; set; }
        public string Occupation { get; set; }
        [JsonProperty("combat style")]
        public string CombatStyle { get; set; }
        public string Partners { get; set; }
        public string Status { get; set; }
        public string Relatives { get; set; }
        public string MangaDebut { get; set; }
        public string AnimeDebut { get; set; }
        public string JapaneseVA { get; set; }
        public string EnglishVA { get; set; }
        public string StagePlay { get; set; }
    }
}