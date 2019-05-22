using rs_api_interface.RS3;
using rs_api_interface.RS3.Hiscore;
using Xunit;

namespace rs_api_interface.Tests.RS3
{
    public class HiscoreTest
    {


        private readonly HiscoreClient _hiscore;
        public HiscoreTest()
        {
            _hiscore = new HiscoreClient();
        }

        [Fact]
        public void TestGetStats()
        {
            var hiscoreData = HiscoreClient.getStats("vestervang");

            var test = GameMode.Regular;

            var i = 0;
        }
    }
}