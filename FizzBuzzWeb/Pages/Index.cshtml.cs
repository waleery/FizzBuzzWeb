﻿using FizzBuzzWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizzBuzzWeb.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public FizzBuzz FizzBuzz { get; set; }
    [BindProperty(SupportsGet = true)]

    public string Name { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        if (string.IsNullOrWhiteSpace(Name))
        {
            Name = "User";
        }
    }
}

