using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameRentalSystem
{
    public class VideoGame
    {
        private string id;
        private string title;
        private string console;
        private string genre;
        private int inventory;

        public VideoGame(string id, string title, string console, string genre, int inventory)
        {
            this.id = id;
            this.title = title;
            this.console = console;
            this.genre = genre;
            this.inventory = inventory;

        }
        public string getID()
        {
            return id;
        }
        public string getTitle()
        {
            return title;
        }
        public string getConsole()
        {
            return console;
        }
        public string getGenre()
        {
            return genre;
        }
        public int getInventory()
        {
            return inventory;
        }
    }
}
