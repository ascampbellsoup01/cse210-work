public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"The Causes of World War II by {GetStudentName()}";
    }

    public string GetStudentName()
    {
        return _studentName;
    }
}
