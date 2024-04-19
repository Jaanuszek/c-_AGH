using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c6_instrukcja_1
{
    internal class OpenShop : GameState
    {
        public OpenShop(GameApp app) : base(app)
        {
            parentApp = app;
        }
        public override void EnterButton()
        {
            Console.WriteLine("Otworzono czat");
            parentApp.ChangeState(new OpenChat(parentApp));
        }

        public override void EscapeButton()
        {
            Console.WriteLine("Powrot do menu");
            parentApp.ChangeState(new GameMenu(parentApp));
        }

        public override void TabButton()
        {
            Console.WriteLine("Powrot do menu");
            parentApp.ChangeState(new GameMenu(parentApp));
        }

        public override void KeyboardInput(string s)
        {
            Console.WriteLine(s);
        }
    }
}
