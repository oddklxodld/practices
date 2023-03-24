using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Wizard
    {
        public string Name
        {
            get;
            private set;
        }

        public int Mana
        {
            get;
            private set;
        }

        public Wizard(string name, int mana)
        {
            Name = name;
            Mana = mana;
        }

        public void CastSpell(Spell spell)
        {
            if (Mana >= spell.Mana)
            {
                Console.WriteLine(Name + " колдует! " + spell.Effect);
                Mana -= spell.Mana;
            }
            else
            {
                Console.WriteLine("Для использования " + spell.Effect + " не хватает " + (spell.Mana - Mana) + " единиц маны. Хлебните зелья!");
            }
        }
    }

    class Spell
    {
        public int Mana
        {
            get;
            private set;
        }

        public string Effect
        {
            get;
            private set;
        }

        public Spell(int mana, string effect)
        {
            Mana = mana;
            Effect = effect;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard = new Wizard("Гендальф", 10);
            Spell fireball = new Spell(5, "огненный шар");
            Spell teleport = new Spell(8, "телепортация");

            wizard.CastSpell(fireball);
            wizard.CastSpell(teleport);
            wizard.CastSpell(fireball);
        }
    }
}
