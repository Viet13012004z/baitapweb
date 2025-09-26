using System;
using System.Web.UI;
using ScoreLibrary; // namespace chứa ScoreManager

namespace FlappyWebServer1
{
    public partial class api : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request["name"] ?? "Unknown";
            int score = 0;
            int.TryParse(Request["score"], out score);

            ScoreManager manager = new ScoreManager();
            manager.Add(score);

            Response.ContentType = "application/json";
            Response.Write($"{{\"name\":\"{name}\",\"score\":{manager.Score}}}");
            Response.End();
        }
    }
}
