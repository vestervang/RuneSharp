using System;
using System.IO;
using System.Runtime.CompilerServices;
using RuneSharp.RuneScape3.Deserializers;
using RuneSharp.Core.Extensions;
using RuneSharp.Core.Hiscore;
using System.Threading.Tasks;
using RuneSharp.Core;
using RestEase;
using RuneSharp.Core.GrandExchange;

namespace RuneSharp.RuneScape3
{
    public class ApiClient
    {
        internal IApi API { get; }

        public ApiClient()
        {
            API = new RestClient(Config.baseAPIUrl) {ResponseDeserializer = new RS3Deserializer()}
                .For<IApi>();

            API.GrandExchangeRoute = Game.RuneScape3.GetGERoute();
            API.HiscoreRoute = Game.RuneScape3.GetHiscoreRoute();
            API.GameMode = GameMode.Regular.GetRoute();
        }

        public async Task<Player> GetPlayerStats(string displayName, GameMode? gameMode = null)
        {
            if (gameMode != null)
            {
                API.GameMode = gameMode.GetRoute();
            }

            try
            {
                var response = await API.GetPlayerStatsAsync(displayName);
                return response.GetContent();
            }
            catch
            {
                return null;
            }
        }

        public async Task<Item> GetItem(int id)
        {
            try
            {
                var response = await API.GetItemAsync(id);
                return response.GetContent();
            }
            catch
            {
                return null;
            }
        }

        public async Task<Item[]> GetItems(ItemCategory category, char alpha, int page = 1)
        {
            try
            {
                var response = await API.GetItemList(category, alpha, page);
                return response.GetContent();
            }
            catch
            {
                return null;
            }
        }

        public async Task<Stream> GetItemSprite(int id)
        {
            try
            {
                var response = await API.GetItemSpriteAsync(id);
                return response;
            }
            catch
            {
                return null;
            }
        }
        
        public async Task<Stream> GetItemImage(int id)
        {
            try
            {
                var response = await API.GetItemImageAsync(id);
                return response;
            }
            catch
            {
                return null;
            }
        }

        public async Task<ItemGraphData> GetItemGraphData(int id)
        {
            try
            {
                var response = await API.GetItemGraphDataAsync(id);
                return response.GetContent();
            }
            catch
            {
                return null;
            }
        }

        public async Task<AlphaList> GetCategory(ItemCategory category)
        {
            try
            {
                var response = await API.GetCategory(category);
                return response.GetContent();
            }
            catch
            {
                return null;
            }
        }
    }
}