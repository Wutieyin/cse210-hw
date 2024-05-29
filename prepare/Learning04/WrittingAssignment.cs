public class WrittingAssignment : Assignment
{
    private string _title;


public WrittingAssignment(string studentName, string topic, string title) : base(studentName, topic)
{
    _title = title;
}

    public string GetWrittingInformation()
    {
        string studentName = GetStudentName();
        return $"Title: {_title} by {studentName}";
    }
}