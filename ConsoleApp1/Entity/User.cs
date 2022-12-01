using ConsoleApp1.Entity;
using ConsoleApp1.Exceptions;
using System.Data;

internal class User
{
    private static int _id=0;
    public int Id 
    {
        get => _id++;
    }
    public List<Status> Statuses { get; set; }
    public string Username { get; set; }
    public User( string username)
    {
        _id++;
        Username = username;
        Statuses = new List<Status>();
    }
    public void SharedStatus(Status status)
    {
        Statuses.Add(status);
    }
    public Status GetStatusById(int? id)
    {
        foreach (var status in Statuses)
        {
            if (status.Id == _id)
            {
                return status;
            }
        }
        return null;
    }
    public List<Status> GetAllStatuses()
    {
        if (Statuses != null)
        {
            return Statuses;
        }
        return null;
    }
    public List<Status> FilterStatusByDate(DateTime date)
    {
        List<Status> CheckStatuses = new();
        CheckStatuses = Statuses.FindAll(status => (status.SharedTime.Ticks - date.Ticks) / 10000000 >= 0);
        if(CheckStatuses.Count == 0)
        {
            throw new NotFoundException("User hec bir status");
        }
        return CheckStatuses;
    }
}
