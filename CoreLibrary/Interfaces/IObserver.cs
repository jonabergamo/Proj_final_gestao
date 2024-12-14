using CoreLibrary.Entities;

/// <summary>
/// Interface para implementar o padrão Observer.
/// Define um contrato para classes que desejam observar mudanças em objetos observáveis.
/// </summary>
public interface IObserver
{
    /// <summary>
    /// Método chamado quando o objeto observado sofre uma alteração.
    /// </summary>
    /// <param name="monster">O monstro cujo estado foi alterado.</param>
    void Update(Monster monster);
}

/// <summary>
/// Interface para implementar o padrão Observer em objetos observáveis.
/// Define um contrato para classes que podem ser observadas por IObserver.
/// </summary>
public interface IObservable
{
    /// <summary>
    /// Adiciona um observador à lista de observadores do objeto.
    /// </summary>
    /// <param name="observer">O observador a ser adicionado.</param>
    void AddObserver(IObserver observer);

    /// <summary>
    /// Remove um observador da lista de observadores do objeto.
    /// </summary>
    /// <param name="observer">O observador a ser removido.</param>
    void RemoveObserver(IObserver observer);

    /// <summary>
    /// Notifica todos os observadores sobre uma alteração no estado do objeto.
    /// </summary>
    void NotifyObservers();
}
