using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c6_instrukcja_1
{
    internal class OpenChat :GameState
    {
        public OpenChat (GameApp app) : base(app)
        {
            parentApp = app;
        }
        public override void EnterButton()
        {
            Console.WriteLine("Powrot do menu");
            parentApp.ChangeState(new GameMenu(parentApp));
        }

        public override void EscapeButton()
        {
            Console.WriteLine("Powrot do menu");
            parentApp.ChangeState(new GameMenu(parentApp));
        }

        public override void TabButton()
        {
            
        }

        public override void KeyboardInput(string s)
        {
            Console.WriteLine(s);
        }
    }
}
