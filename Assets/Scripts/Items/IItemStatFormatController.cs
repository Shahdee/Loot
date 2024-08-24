
public interface IItemStatFormatController
{
    string[] GetItemStatsFormatted(int[] stats);

    string[] GetComparedItemStatsFormatted(int[] equippedStats, int[] lootedStats);
}
