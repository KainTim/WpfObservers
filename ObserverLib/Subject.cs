namespace ObserverLib;

public abstract class Subject
{
  private List<Observer> _observers = [];
  public void Attach(Observer observer)
  {
    _observers.Add(observer);
  }
  public void Detach(Observer observer)
  {
    _observers.Remove(observer);
  }
  public void Notify()
  {
    _observers.ForEach(observer => observer.Update());
  }
}
