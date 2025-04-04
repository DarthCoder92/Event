public class AttendanceTrackerService
{
    private readonly Dictionary<int, List<string>> _attendance = new();

    // Add a participant to an event
    public void RegisterAttendance(int eventId, string participantName)
    {
        if (!_attendance.ContainsKey(eventId))
        {
            _attendance[eventId] = new List<string>();
        }

        _attendance[eventId].Add(participantName);
    }

    // Get the list of participants for an event
    public List<string> GetAttendance(int eventId)
    {
        return _attendance.ContainsKey(eventId) ? _attendance[eventId] : new List<string>();
    }

    // Get the total number of participants for an event
    public int GetAttendanceCount(int eventId)
    {
        return _attendance.ContainsKey(eventId) ? _attendance[eventId].Count : 0;
    }
}