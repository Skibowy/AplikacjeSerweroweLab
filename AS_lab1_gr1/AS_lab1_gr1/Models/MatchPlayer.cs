﻿namespace AS_lab1_gr1.Models
{
    public class MatchPlayer
    {
        public int MatchPlayerId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ICollection<MatchEvent> MatchEvents { get; set; }
        public Match Match { get; set; }
        public Position Position { get; set; }
        public Player Player { get; set; }
    }
}
