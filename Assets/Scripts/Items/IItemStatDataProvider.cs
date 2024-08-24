
public interface IItemStatDataProvider
{
    int LevelRandomDelta { get; }
    int StatRandomDelta { get; }

    int GetItemSellPrice(EItemType itemType);
    int[] GetItemStats(EItemType itemType);
}
