# dotnet-test-one
.NET Test Part One

## Instructions:
  
- Create a Console Application.
- Copy the following code to your Main method.

```csharp
static void Main(string[] args)
{
    /* Expected output:
        SquarePantsMeme - Rate: 5 - (c) InterWebz
        SquarePantsMeme - Rate: 5
        SquarePantsMeme - Rate: 5
        VideoMeme - Length: 1:00 - Rate: 4
        VideoMeme - Length: 1:00 - Rate: 4 - (c) InterWebz
        1:00
    */

    var list = new List<IMeme>()
    {
        new SquarePantsMeme(5) as ImageMeme,
        new VideoMeme { Rate = 4 },
    };

    Console.WriteLine(MemeFormatter.GetMemeData(list.First(), true));

    foreach (var item in list)
    {
        switch (item)
        {
            case ImageMeme image:
                Console.WriteLine(image);
                Console.WriteLine(image.GetData(true));
                break;
            case VideoMeme video:
                Console.WriteLine(video);
                Console.WriteLine(video.GetData(true));
                Console.WriteLine(video.Length);
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    Console.ReadLine();
}
```
- Generate the necessary code (using the OOP principles) to execute the previous code correctly.
