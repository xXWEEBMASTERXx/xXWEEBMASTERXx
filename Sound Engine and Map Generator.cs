static void ConsoleDraw(IEnumerable<string> lines, int x, int y)
        {
            if (x > Console.WindowWidth) return;
            if (y > Console.WindowHeight) return;

            var trimLeft = x < 0 ? -x : 0;
            int index = y;

            x = x < 0 ? 0 : x;
            y = y < 0 ? 0 : y;

            var linesToPrint =
                from line in lines
                let currentIndex = index++
                where currentIndex > 0 && currentIndex < Console.WindowHeight
                select new
                {
                    Text = new String(line.Skip(trimLeft).Take(Math.Min(Console.WindowWidth - x, line.Length - trimLeft)).ToArray()),
                    X = x,
                    Y = y++
                };

            Console.Clear();
            foreach (var line in linesToPrint)
            {
                Console.SetCursorPosition(line.X, line.Y);
                Console.Write(line.Text);
            }
        }
        class Sound
        {
            private MediaPlayer music_Player;

            public void Play(string filename)
            {
                music_Player = new MediaPlayer();
                music_Player.Open(new Uri(filename, UriKind.Relative));
                music_Player.Play();
            }
            public void Stop()
            {
                music_Player.Stop();
            }

            public void SetVolume(int volume)
            {
                music_Player.Volume = volume / 100.0f;
            }
        }
        const int MapWidth = 82;
        const int MapHeight = 42;
        const char Wall = '█';
        const char Character = 'H';
        private static void Write(int x, int y, char ch)
        {
            Console.SetCursorPosition(2 * x + 1, y + 1);
            if (ch == Character)
            {
                Console.Write('╠'); Console.Write('╣');
            }
            else
            {
                Console.Write(ch); Console.Write(ch);
            }

        }

        private static void DrawMap(char[,] map)
        {
            for (int x = 0; x < MapWidth; x++)
            {
                for (int y = 0; y < MapHeight; y++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Write(x, y, map[x, y]);
                }
            }
        }

        private static char[,] GenerateMap()
        {
            var map = new char[MapWidth, MapHeight];

            for (int i = 0; i < MapWidth; i++)
            {
                map[i, 0] = Wall;
            }
            for (int i = 0; i < MapWidth; i++)
            {
                map[i, MapHeight - 1] = Wall;
            }
            for (int i = 0; i < MapHeight; i++)
            {
                map[0, i] = Wall;
            }
            for (int i = 0; i < MapHeight; i++)
            {
                map[MapWidth - 1, i] = Wall;
            }
            return map;
        }
        Console.WindowWidth = 160;
        Console.WriteLine("\n\n");
        var maxLength = Title01.Aggregate(0, (max, line) => Math.Max(max, line.Length));
        var x = Console.BufferWidth / 2 - maxLength / 2;
        for (int y = -Title01.Length; y < Console.WindowHeight + Title01.Length; y++)
        {
                ConsoleDraw(Title01, x, y);
                Thread.Sleep(100);
        }
