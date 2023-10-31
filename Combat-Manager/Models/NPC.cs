namespace Combat_Manager.Models
{
    public class NPC : Entity
    {
        public int? Attack { get; set; }
        public int? HitPoints { get; set; }
        public int? Parry { get; set; }
        public string Comment { get; set; }
    }
}