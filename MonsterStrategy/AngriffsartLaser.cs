using System.Diagnostics;

namespace MonsterStrategy
{
    /// <summary>
    /// Angriffsart Laser
    /// </summary>
    public class AngriffsartLaser : IAngriffsart
    {
        /// <summary>
        /// Angriffsart Laser
        /// </summary>
        public void Angreifen()
        {
            //Führt den Befehl für den Angriff mit Laserstrahl aus
            Debug.WriteLine("Ich schieße mit Laser");
        }
    }
}
