using System;
using System.IO;

namespace ScoreLibrary
{
    public class ScoreManager
    {
        private readonly string filePath;

        public ScoreManager(string path)
        {
            filePath = path ?? throw new ArgumentNullException(nameof(path));
            var dir = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        public int SaveScore(int score)
        {
            int high = GetHighScore();
            if (score > high)
            {
                File.WriteAllText(filePath, score.ToString());
                high = score;
            }
            return high;
        }

        public int GetHighScore()
        {
            if (!File.Exists(filePath)) return 0;
            var txt = File.ReadAllText(filePath);
            return int.TryParse(txt, out int val) ? val : 0;
        }
    }
}
