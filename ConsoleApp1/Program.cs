using ConsoleApp1.Entity;

Console.WriteLine("Zehmet olmasa");
string username = Console.ReadLine();
User user = new Use mr(username);

Status status1 = new Status("Test title", "test content");
Console.ReadLine();

Status status2 = new Status("Test title2", "test content2");
DateTime date = DateTime.Now;
Console.ReadLine();

Status status3 = new Status("Test title3", "test content3");
user.SharedStatus(status1);
user.SharedStatus(status2);
user.SharedStatus(status3);

List<Status> list = user.FilterStatusByDate(date);

foreach (Status item in list)
{
    item.GetStatusInfo();
}
