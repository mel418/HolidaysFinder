using HolidaysFinder.Services;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    private readonly IHolidaysApiService _holidaysApiService;

    public HomeController(IHolidaysApiService holidaysApiService)
    {
        _holidaysApiService = holidaysApiService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(string countryCode, int year)
    {
        List<HolidayModel> holidays = new List<HolidayModel>();
        holidays = await _holidaysApiService.GetHolidays(countryCode, year);
        return View(holidays);
    }

}
