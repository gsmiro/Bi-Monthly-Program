namespace mitlist.Data;

public class Assignment
{
    public String Assigned { get; set; }
    public String Theme { get; set; }
}

public class Demonstration
{
    public String Assigned { get; set; }
    public String Helper { get; set; }
}

public class Meeting
{
    public int OpeningSong { get; set; }
    public String OpeningPrayer { get; set; }
    public String ClosingPrayer { get; set; }
    public String[] Attendants { get; set; }
    public String ChairMan { get; set; }
    public String Treasures { get; set; }
    public String Gems { get; set; }
    public String Reading { get; set; }
    public Demonstration[] ApplyYouself { get; set; }
    public Assignment Talk { get; set; }
    public Assignment[] LifeAndMinistry { get; set; }
    public String BibleStudy { get; set; }
    public String Reader { get; set; }
    public int EndingSong { get; set; }
}

public class MeetingService
{
    public Task<Meeting> GetMeetingAsync()
    {
        return null;
    }
}