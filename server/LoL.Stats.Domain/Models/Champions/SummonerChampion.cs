namespace LoL.Stats.Domain.Models.Champions
{
    public class SummonerChampion
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Image { get; set; }

        public IEnumerable<Spell> Spells { get; set; }
        public IEnumerable<Item> Items { get; set; }
    }
}
