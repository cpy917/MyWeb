using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using week15.Models;

namespace week15.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    private static List<Announcement> announcements = new List<Announcement>
    {
        new Announcement { Id = 6, Title = "小破網站上線啦", Content = "我還在探索自己想走的路，但透過網站慢慢記錄學到的東西、做過的作品，讓我更清楚自己的樣子。這裡會一直更新，感謝你來過！", PostDate = DateTime.Now.AddDays(-20) },
        new Announcement { Id = 5, Title = "深夜不睡的產物：新靈感爆發", Content = "昨天凌晨三點邊突然冒出一個專題點子,希望老師會喜歡。", PostDate = DateTime.Now.AddDays(-15) },
        new Announcement { Id = 4, Title = "持續更新中", Content = "調整了一些排版，讓版面看起來更清爽，也幫公告加了點顏色 ～如果有跑版或奇怪的地方，請悄悄告訴我！。", PostDate = DateTime.Now.AddDays(-13) },
         new Announcement { Id = 3, Title = "暑假任務！", Content = "暑假要跟一群小夥伴去印尼教機器人，懷會順便去玩，總共一個月，有點緊張但也超期待，希望我去那邊有東西可以吃。", PostDate = DateTime.Now.AddDays(-8) },
        new Announcement { Id = 2, Title = "攝影作品集更新中", Content = "最近剛交完攝影課期末作業，打算慢慢把其中幾張整理上來。每張照片背後都有一點故事，敬請期待～！", PostDate = DateTime.Now.AddDays(-7) },
        new Announcement { Id = 1, Title = "期末爆炸中", Content = "最近忙著趕報告、拍攝、熬夜剪影片（還有偶爾焦慮發呆），網站更新暫時變慢一點點！等我撐過期末週，一定會回來整理新內容～", PostDate = DateTime.Now.AddDays(-1) }
    };
    public IActionResult Index()
    {
        return View(announcements);
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Lovesong()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult Project()
    {
        return View();
    }
    public IActionResult Video()
    {
        return View();
    }
    public IActionResult Photo()
    {
        return View();
    }
    public IActionResult Else()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
