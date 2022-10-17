using LoL.Stats.Domain.PreProcessing.Champions;
using LoL.Stats.Domain.PreProcessing.Items;
using System.Text.Json;

namespace LoL.Stats.Application.PreProcessors
{
    public class StaticInfoHandler : IStaticInfoHandler
    {
        public ChampionsInfo ChampionsInfo { get; set; }
        public ItemsInfo ItemsInfo { get; set; }

        public void LoadChampionsInfo(string file)
        {
            string json = File.ReadAllText(file);
            ChampionsInfo = JsonSerializer.Deserialize<ChampionsInfo>(json);
        }

        public void LoadItemsInfo(string file)
        {
            string json = File.ReadAllText(file);
            ItemsInfo = JsonSerializer.Deserialize<ItemsInfo>(json);
        }

        public ChampionMetadata GetChampionInfo(string name)
        {
            if (ChampionsInfo == null || ChampionsInfo.Champions == null || !ChampionsInfo.Champions.ContainsKey(name))
            {
                return null;
            }

            return ChampionsInfo.Champions[name];
        }

        public ItemMetadata GetItemInfo(int id)
        {
            string itemId = id.ToString();
            if (ItemsInfo == null || ItemsInfo.Items == null || !ItemsInfo.Items.ContainsKey(itemId))
            {
                return null;
            }

            return ItemsInfo.Items[itemId];
        }
    }
}
