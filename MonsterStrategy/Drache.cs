namespace MonsterStrategy
{
    public class Drache : Monster
    {
        public Drache()
        {
            /*Initialisiert das in der Basisklasse definierte Objekt
            mit der für Drachen zutreffenden Angriffsart*/
            Angriff = new AngriffsartFeuer();
        }
    }
}