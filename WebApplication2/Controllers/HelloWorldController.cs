using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;

public class HelloWorldController : Controller
{
    /**
     * 控制器中的每个 public 方法均可作为 HTTP 终结点调用。 上述示例中，两种方法均返回一个字符串。 请注意每个方法前面的注释。
     *
     * 一个 HTTP 终结点：
     * 是 Web 应用程序中可定向的 URL，如 https://localhost:5001/HelloWorld。
     * 结合以下内容：
     * 所用的协议：HTTPS
     * Web 服务器的网络位置，包括 TCP 端口：localhost:5001。
     * 目标 URI：HelloWorld。
     */
    
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello" + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}