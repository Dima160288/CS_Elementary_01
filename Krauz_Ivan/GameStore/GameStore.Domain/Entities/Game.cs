using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Entities
{
    public class Game
    {
        private int gameID;
        private string name;
        private string description;
        private string category;
        private int price;

        public int GameID { get => gameID; set => gameID = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Category { get => category; set => category = value; }
        public int Price { get => price; set => price = value; }
    }
}
