using System;
using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels;

public class PieListViewModel
{
  public IEnumerable<Pie> Pies { get; set; }
  public string? CurrentCategory { get; set; }

  public PieListViewModel(IEnumerable<Pie> pies, string? currentCategory)
  {
    Pies = pies;
    CurrentCategory = currentCategory;
  }
}
