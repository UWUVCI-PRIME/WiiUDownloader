using System.IO;
using System.Net.Http;
using System.Net;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //try
            //{

            //    HttpClient client = new HttpClient();
            //    var stream = client.GetStreamAsync("http://ccs.cdn.c.shop.nintendowifi.net/ccs/download/00050000101a2000/00000000.h3").Result;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            runtest();
        }

        public async void runtest()
        {
            await Downloader.DownloadAsync(new TitleData("00050000101a2000", "1337ae64db3aa371b4af685593805733"), "output");
        }
    }
}