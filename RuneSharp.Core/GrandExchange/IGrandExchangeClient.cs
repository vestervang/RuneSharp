using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using RestEase;

namespace RuneSharp.Core.GrandExchange
{
    public interface IGrandExchangeClient
    {
        [Path("geRoute")] 
        string GrandExchangeRoute { get; set; }
        
        [Get("/m={geRoute}/api/catalogue/detail.json")]
        Task<Response<Item>> GetItemAsync([Query("item")] int itemId);
        
        [Get("/m={geRoute}/obj_big.gif")]
        Task<Stream> GetItemImageAsync([Query("id")] int itemId);
        
        [Get("/m={geRoute}/obj_sprite.gif")]
        Task<Stream> GetItemSpriteAsync([Query("id")] int itemId);
        
        [Get("/m={geRoute}/api/graph/{id}.json")]
        Task<Response<ItemGraphData>> GetItemGraphDataAsync([Path("id")] int itemId);

        [Get("/m={geRoute}/api/catalogue/items.json")]
        Task<Response<Item[]>> GetItemList([Query("category", Format = "d")] ItemCategory categoryId, [Query("alpha")] char alpha,  [Query("page")]int page = 1);

        [Get("/m={geRoute}/api/catalogue/category.json")]
        Task<Response<AlphaList>> GetCategory([Query("category", Format = "d")] ItemCategory categoryId);
    }
}