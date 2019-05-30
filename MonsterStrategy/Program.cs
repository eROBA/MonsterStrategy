namespace MonsterStrategy
{
    /// <summary>
    /// Composition Root.
    /// Erzeugt zwei Typen mit individuell zuweisbaren Angriffsarten
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Zyklop MyZykolp = new Zyklop();
            MyZykolp.Laufen();
            MyZykolp.Schwimmen();
            MyZykolp.Angreifen();

            Drache MyDrache = new Drache();
            MyDrache.Laufen();
            MyDrache.Schwimmen();
            MyDrache.Angreifen();
        }
    }
}
