public class project {
    public string description;
    public string imageSource;
    public string title {get; set;}

    public project(string description, string src, string title)
    {
        this.description = description;
        this.imageSource = src;
        this.title = title;
    }
}