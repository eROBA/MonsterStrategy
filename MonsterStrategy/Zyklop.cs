namespace MonsterStrategy
{
    public class Zyklop : Monster
    {
        public Zyklop()
        {
            /*Initialisiert das in der Basisklasse definierte Objekt
            mit der für Zyklopen zutreffenden Angriffsart*/
            Angriff = new AngriffsartLaser();
        }
    }
}
