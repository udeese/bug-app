using BugApp.Models;

namespace BugApp.ViewModels;

public class BugPageViewModel
{
    public List<Bug> Bugs { get; set; } = [];
    public int AvailableBugsCount { get; set; }
}
