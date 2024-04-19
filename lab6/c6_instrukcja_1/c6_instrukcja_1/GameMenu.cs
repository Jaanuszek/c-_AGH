using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c6_instrukcja_1
{
    internal class GameMenu :GameState
    {
        public GameMenu(GameApp app) : base(app) 
        {
            parentApp = app;
        }
        public override void EnterButton()
        {
            Console.WriteLine("Gra rozpoczęta");
            parentApp.ChangeState(new InGame(parentApp));
        }

        public override void EscapeButton()
        {
            
        }

        public override void TabButton()
        {
            
        }

        public override void KeyboardInput(string s)
        {
            
        }
    }
}
