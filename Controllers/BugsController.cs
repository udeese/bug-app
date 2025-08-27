using BugApp.Models;
using Microsoft.AspNetCore.Mvc;

// using BugApp.ViewModels;

namespace BugApp.Controllers;

public class BugsController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        List<Bug> bugs =
        [
            new()
            {
                Id = 1,
                Title = "Beetle",
                Severity = Severity.High,
                IsOpen = true,
                Owner = "Gandalf",
            },
            new()
            {
                Id = 2,
                Title = "Ladybug",
                Severity = Severity.High,
                IsOpen = true,
                Owner = "Frodo",
            },
            new()
            {
                Id = 3,
                Title = "Ant",
                Severity = Severity.High,
                IsOpen = true,
                Owner = "Legolas",
            },
            new()
            {
                Id = 4,
                Title = "Dragonfly",
                Severity = Severity.High,
                IsOpen = true,
                Owner = "Samwise",
            },
            new()
            {
                Id = 5,
                Title = "Bumblebee",
                Severity = Severity.High,
                IsOpen = true,
                Owner = "Aragon",
            },
        ];

        ViewData["Title"] = "Bug Board";
        ViewBag.Subtitle = "Sprint Triage";
        ViewData["OpenCount"] = bugs.Count(bug => bug.IsOpen);
        return View(bugs);
    }
}
