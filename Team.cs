using System;

namespace Card
{
    class Team : ITeam
    {
        public int wins { get; set; }
        public int losses { get; set; }

        private IGame game;

        public Team(IGame game)
        {
            if (game == null)
            {
                throw new Exception();
            }

            this.game = game;
        }
    }
}