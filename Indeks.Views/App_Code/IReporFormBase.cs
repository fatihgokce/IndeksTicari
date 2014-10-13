using System;
using System.Collections.Generic;
using System.Text;

namespace Indeks.Views
{
  public interface IReporFormBase
  {
    DateTime startDate { get; set; }
    DateTime endDate { get; set; }
  }
}
