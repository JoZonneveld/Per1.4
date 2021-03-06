﻿using System;
using System.Collections.Generic;

namespace visitor
{
    interface IMonsterVisitor
    {
        string OnTroll(Troll troll);
        string OnBat(Bat bat);
        string OnHound(Hound hound);
    }

    class MonsterAttackVisitor : IMonsterVisitor
    {
        public string OnTroll(Troll troll)
        {
            troll.Health -= 1;
            return "Hound was attacked! It has " + troll.Health.ToString() + " health points left";
        }

        public string OnBat(Bat bat)
        {
            bat.Health -= 3;
            return "Bat was attacked! It has " + bat.Health.ToString() + " health points left";
        }

        public string OnHound(Hound hound)
        {
            hound.Health -= 5;
            return "Hound was attacked! It has " + hound.Health.ToString() + " health points left";
        }
    }

    class MonsterHealedVisitor : IMonsterVisitor
    {
        public string OnTroll(Troll troll)
        {
            troll.Health += 1;
            return "Troll was Healed! It has " + troll.Health.ToString() + " health points left";
        }

        public string OnBat(Bat bat)
        {
            bat.Health += 3;
            return "Bat was Healed! It has " + bat.Health.ToString() + " health points left";
        }

        public string OnHound(Hound hound)
        {
            hound.Health += 5;
            return "Hound was Healed! It has " + hound.Health.ToString() + " health points left";
        }
    }

    interface IMonster
    {
        string Visit(IMonsterVisitor visitor);
    }

    class Troll : IMonster
    {
        public int Health { get; set; } = 10;

        public string Visit(IMonsterVisitor visitor)
        {
            return visitor.OnTroll(this);
        }
    }

    class Bat : IMonster
    {
        public int Health { get; set; } = 5;

        public string Visit(IMonsterVisitor visitor)
        {
            return visitor.OnBat(this);
        }
    }

    class Hound : IMonster
    {
        public int Health { get; set; } = 3;

        public string Visit(IMonsterVisitor visitor)
        {
            return visitor.OnHound(this);
        }
    }

    class Program
    {
        static void Main()
        {
            List<IMonster> monsters = new List<IMonster>();
            monsters.Add(new Troll());
            monsters.Add(new Bat());
            monsters.Add(new Hound());

            IMonsterVisitor monster_visitor = new MonsterAttackVisitor();
            IMonsterVisitor monsterHealed = new MonsterHealedVisitor();

            foreach (var monster in monsters)
            {
                Console.WriteLine(monster.Visit(monster_visitor));
                Console.WriteLine(monster.Visit(monsterHealed));
            }
            Console.ReadKey();
        }
    }
}