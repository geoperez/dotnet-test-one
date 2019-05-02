
    internal interface IMeme
    {
        string Name { get; }

        int Rate { get; set; }

        string GetData(bool includeWatermark);
    }

    internal static class MemeFormatter
    {
        internal static string GetMemeData(IMeme meme, bool includeWatermark)
        {
            if (meme is VideoMeme video)
                return $"{meme.Name} - Length: {video.Length} - Rate: {meme.Rate}{(includeWatermark ? " - (c) InterWebz" : string.Empty)}";

            return $"{meme.Name} - Rate: {meme.Rate}{(includeWatermark ? " - (c) InterWebz" : string.Empty)}";
        }
    }


    internal abstract class ImageMeme : IMeme
    {
        protected ImageMeme(int rate, string name)
        {
            Rate = rate;
            Name = name;
        }

        public int Rate { get; set; }

        public string Name { get; }

        public string GetData(bool includeWatermark) => GetImageData();

        protected abstract string GetImageData();
    }

    internal sealed class VideoMeme : IMeme
    {
        public string Name => nameof(VideoMeme);

        public int Rate { get; set; }

        public string Length { get; set; } = "1:00";

        public string GetData(bool includeWatermark) => MemeFormatter.GetMemeData(this, includeWatermark);

        public override string ToString() => GetData(false);
    }

    internal class SquarePantsMeme : ImageMeme
    {
        public SquarePantsMeme(int rate) 
            : base(rate, nameof(SquarePantsMeme))
        {
        }

        protected override string GetImageData() => MemeFormatter.GetMemeData(this, false);

        public override string ToString() => GetImageData();
    }
