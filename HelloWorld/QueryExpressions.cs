using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class GameObject
    {
        public int ID { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public double MaxHP { get; set; }

        public double CurrentHP { get; set; }

        public int PlayerID { get; set; }

        public bool Intersects(GameObject obj)
        {
            if (X == obj.X && Y == obj.Y)
                return true;

            return false;
        }
    }

    class Ship : GameObject
    {
    }

    class MyPlayer
    {
        public int ID { get; set; }

        public string UserName { get; set; }

        public string TeamColor { get; set; }

        public override string ToString() => ID + ": " + UserName + " in team " + TeamColor;
    }

    class QueryExpressions
    {
        private List<GameObject> gameObjects;

        private List<MyPlayer> players;

        public QueryExpressions()
        {
            gameObjects = new List<GameObject>();
            gameObjects.Add(new Ship() { ID = 1, X = 0, Y = 0, CurrentHP = 50, MaxHP = 100, PlayerID = 1 });
            gameObjects.Add(new Ship() { ID = 2, X = 4, Y = 2, CurrentHP = 75, MaxHP = 100, PlayerID = 1 });
            gameObjects.Add(new Ship() { ID = 3, X = 9, Y = 3, CurrentHP = 0, MaxHP = 100, PlayerID = 2 });

            players = new List<MyPlayer>();
            players.Add(new MyPlayer() { ID = 1, UserName = "Player 1", TeamColor = "Red" });
            players.Add(new MyPlayer() { ID = 2, UserName = "Player 2", TeamColor = "Blue" });
        }

        public void Test()
        {
            var results = from o in gameObjects
                          join p in players on o.PlayerID equals p.ID
                          select new { o.ID, p.TeamColor };

            IEnumerable<MyPlayer> sortedPlayers = from p in players
                                                  orderby p.UserName descending, p.ID ascending
                                                  select p;
            foreach (MyPlayer player in sortedPlayers)
                Console.WriteLine(player);

            IEnumerable<IGrouping<int, GameObject>> groups = from o in gameObjects
                                                             group o by o.PlayerID;
            foreach (var group in groups)
            {
                Console.WriteLine("group " + group.Key);
                foreach (GameObject o in group)
                    Console.WriteLine(" " + o.ID);
            }

            var objectCountPerPlayer = from o in gameObjects
                                       group o by o.PlayerID
                                       into playerGroup
                                       select new { ID = playerGroup.Key, Count = playerGroup.Count() };

            var playerObjects = from p in players
                                join o in gameObjects on p.ID equals o.PlayerID into objectsOwnedByPlayer
                                select new { Player = p, Objects = objectsOwnedByPlayer };
            foreach (var objects in playerObjects)
            {
                Console.WriteLine(objects.Player.UserName + " has the following objects: ");
                foreach (GameObject obj in objects.Objects)
                    Console.WriteLine($"{obj.ID} {obj.CurrentHP} / {obj.MaxHP}");
            }

            IEnumerable<int> aliveIDs = gameObjects.Where(o => o.CurrentHP > 0).Select(o => o.ID);

            IEnumerable<GameObject> fullHealthObjects = from o in gameObjects
                                                        where o.CurrentHP == o.MaxHP
                                                        select o;
            IEnumerable<int> fullHealthIDs = from o in gameObjects
                                             where o.CurrentHP == o.MaxHP
                                             select o.ID;
            var percentHealthObjects = from o in gameObjects
                                       orderby o.CurrentHP / o.MaxHP
                                       group o by o.PlayerID;
        }
    }
}
