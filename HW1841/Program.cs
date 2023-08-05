using System.Text;

namespace HW1841 {
    public class Program {
        static void Main(string[] args) {

            var _url = "https://www.youtube.com/watch?v=n463CVaPIQE";
            var _send = new Send();
            var _getInfo = new GetInfoCommand(_url);
            var _path = "video.mp4";
            var _downloadV = new DownloadCommand(_url, _path);

            _send.SetCommand(_getInfo);
            _send.Run();
            _send.SetCommand(_downloadV);
            _send.Run();

            Console.OutputEncoding = Encoding.UTF8;
            Console.ReadKey();
        }
    }
}