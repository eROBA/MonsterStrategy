namespace MonsterStrategy
{
    /// <summary>
    /// Schnittstelle der sich die verschiedenen Angriffsarten
    /// mit ihrer speziellen Methode "Angreifen" anschließen.
    /// </summary>
    public interface IAngriffsart
    {
        void Angreifen();
    }
}