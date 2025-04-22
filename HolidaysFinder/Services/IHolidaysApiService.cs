namespace HolidaysFinder.Services;
public interface IHolidaysApiService
{
    Task<List<HolidayModel>> GetHolidays(string countryCode, int year);
}