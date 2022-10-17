using LoL.Stats.Domain.PreProcessing.Champions;
using LoL.Stats.Domain.PreProcessing.Items;

namespace LoL.Stats.Application.PreProcessors
{
    public interface IStaticInfoHandler
    {
        ChampionsInfo ChampionsInfo { get; set; }

        ItemsInfo ItemsInfo { get; set; }

        public void LoadChampionsInfo(string file);

        public void LoadItemsInfo(string file);

        public ChampionMetadata GetChampionInfo(string name);

        public ItemMetadata GetItemInfo(int id);
    }
}
