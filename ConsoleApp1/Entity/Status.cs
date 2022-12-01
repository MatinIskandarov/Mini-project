namespace ConsoleApp1.Entity
{
    internal class Status
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime SharedTime { get; set; }
        public Status(string title, string content)
        {
            Title = title;
            Content = content;
            SharedTime = DateTime.Now;
        }
        public void GetStatusInfo()
        {
            Console.WriteLine($"Title:{Title},Content:{Content} {(DateTime.Now.Ticks - SharedTime.Ticks)/10000000} seconds ago");
        }

    }
}
