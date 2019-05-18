using System;

namespace YouLearn.Domain.Entities
{
    public class Playlist
    {
        public Guid Id { get; set; }
        public Usuario Usuario { get; set; }

        // EmAnalise, Aprovado ou Recusado
        public string Status { get; set; }

    }
}
