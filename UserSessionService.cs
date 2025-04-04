public class UserSessionService
{
    public string? UserName { get; set; }
    public DateTime SessionStartTime { get; private set; }

    public void StartSession(string userName)
    {
        UserName = userName;
        SessionStartTime = DateTime.Now;
    }

    public void EndSession()
    {
        UserName = null;
    }

    public TimeSpan GetSessionDuration()
    {
        return DateTime.Now - SessionStartTime;
    }
}