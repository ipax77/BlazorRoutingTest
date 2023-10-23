namespace BlazorApp1.Client;

public record TestRecord
{
    public TestRecord() { }
    public TestRecord(string? test1, string? test2)
    {
        Test1 = test1;
        Test2 = test2;
    }
    public string? Test1 { get; set; }
    public string? Test2 { get; set; }
}
