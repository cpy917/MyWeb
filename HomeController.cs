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
        new Announcement { Id = 6, Title = "�p�}�����W�u��", Content = "���٦b�����ۤv�Q�������A���z�L�����C�C�O���Ǩ쪺�F��B���L���@�~�A���ڧ�M���ۤv���ˤl�C�o�̷|�@����s�A�P�§A�ӹL�I", PostDate = DateTime.Now.AddDays(-20) },
        new Announcement { Id = 5, Title = "�`�]���Ϊ������G�s�F�P�z�o", Content = "�Q�ѭ��T�I���M�_�X�@�ӱM�D�I�l,�Ʊ�Ѯv�|���w�C", PostDate = DateTime.Now.AddDays(-15) },
        new Announcement { Id = 4, Title = "�����s��", Content = "�վ�F�@�Ǳƪ��A�������ݰ_�ӧ�M�n�A�]�����i�[�F�I�C�� ��p�G���]���Ω_�Ǫ��a��A�Ю����i�D�ڡI�C", PostDate = DateTime.Now.AddDays(-13) },
         new Announcement { Id = 3, Title = "�������ȡI", Content = "�����n��@�s�p�٦�h�L���о����H�A�h�|���K�h���A�`�@�@�Ӥ�A���I��i���]�W���ݡA�Ʊ�ڥh���䦳�F��i�H�Y�C", PostDate = DateTime.Now.AddDays(-8) },
        new Announcement { Id = 2, Title = "��v�@�~����s��", Content = "�̪��槹��v�Ҵ����@�~�A����C�C��䤤�X�i��z�W�ӡC�C�i�Ӥ��I�᳣���@�I�G�ơA�q�д��ݡ�I", PostDate = DateTime.Now.AddDays(-7) },
        new Announcement { Id = 1, Title = "�����z����", Content = "�̪񦣵ۻ����i�B����B���]�żv���]�٦������J�{�o�b�^�A������s�Ȯ��ܺC�@�I�I�I���ڼ��L�����g�A�@�w�|�^�Ӿ�z�s���e��", PostDate = DateTime.Now.AddDays(-1) }
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
