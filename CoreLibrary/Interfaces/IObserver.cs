using CoreLibrary.Entities;

public interface IObserver
{
    void Update(Monster monster);
}

public interface IObservable
{
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}
