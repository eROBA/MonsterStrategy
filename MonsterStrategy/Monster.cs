using System.Diagnostics;

namespace MonsterStrategy
{
    //Abstrakte Basisklasse für verschiedene Arten von Monstern
    public abstract class Monster
    {
        /// <summary>
        /// Definiert ein Objekt durch welches eine Angriffsart festgelegt wird
        /// </summary>
        public IAngriffsart Angriff;
        /// <summary>
        /// Methode die das Laufen beschreibt
        /// </summary>
        public void Laufen()
        {
            Debug.WriteLine("Ich kann laufen");
        }
        /// <summary>
        /// Methode die das Schwimmen beschreibt
        /// </summary>
        public void Schwimmen()
        {
            Debug.WriteLine("Ich kann schwimmen");
        }
        /// <summary>
        /// Methode die das Angreifen beschreibt
        /// </summary>
        public void Angreifen()
        {
            //Ruft auf dem Objekt der Angriffsart den Befehl (die Methode) zum Angreifen auf
            Angriff.Angreifen();
        }
    }
}
