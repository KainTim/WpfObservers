using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObserverLib;

namespace WpfObservers;

public class ClockSubject : Subject
{
  private DateTime _time = DateTime.Now;

  public DateTime Time
  {
    get { return _time; }
    set
    {
      _time = value;
      Notify();
    }
  }

  internal void Tick()
  {
    Time = Time.AddSeconds(1);
  }
}
