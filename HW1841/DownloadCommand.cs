
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace HW1841{
    class DownloadCommand : Command {

        public string Url;
        public string OutputFilePath;
        public override void Run() {
            _ = DownloadVideo();
        }
        public async Task DownloadVideo() {
            try {
                var _youtube = new YoutubeClient();
                var _video = await _youtube.Videos.GetAsync(Url);
                var _streamManifest = await _youtube.Videos.Streams.GetManifestAsync(_video.Id);
                var _Info = _streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                Console.WriteLine("Загрузка видео");
                if (_Info != null) {
                    await _youtube.Videos.Streams.DownloadAsync(_Info, OutputFilePath);
                }
                Console.WriteLine("Загрузка завершена");
            }
            catch (Exception _ex) {
                Console.WriteLine(_ex.Message);
            }
        }
        public DownloadCommand(string _url, string _path) {

            Url = _url;
            OutputFilePath = _path;
        }
    }
}
