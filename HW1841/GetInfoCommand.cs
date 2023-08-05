using YoutubeExplode;

namespace HW1841 {
    class GetInfoCommand : Command {

        public string Url;
        public GetInfoCommand(string _url) {
            Url = _url;
        }
        public override void Run() {

            var _youtube = new YoutubeClient();
            var _video = _youtube.Videos.GetAsync(Url).Result;
            Console.WriteLine($"Название  {_video.Title}");
            Console.WriteLine($"Содержание {_video.Description}");

        }   
    }
}
