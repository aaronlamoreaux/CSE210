public class Entry {
    public string _prompt = "";
    public string _date = "";
    public string _message = "";
 
    public Entry()
    {
    }
    
    public void Display() {
        Console.WriteLine($"\r\nDate: {_date} Prompt: {_prompt} Entry: {_message}");
    }
}