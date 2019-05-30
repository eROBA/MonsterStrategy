using System.Diagnostics;

namespace MonsterStrategy
{
    /// <summary>
    /// Angriffsart Feuer
    /// </summary>
    public class AngriffsartFeuer : IAngriffsart
    {
        public void Angreifen()
        {
            //Führt den Befehl für den Angriff mit Feuer aus
            Debug.WriteLine("Ich speie Feuer");
        }
    }
}
