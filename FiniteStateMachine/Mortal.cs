﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteStateMachine
{
    public class Mortal : Entity
    {

        // Fields
        int _HP;
        int _Hunger;
        int _Fatique;
        int _Stress;
        string _Name;
        bool _Alive;

        // Property Getters
        int HP { get { return _HP; } }
        int Hunger { get { return _Hunger; } }
        int Fatique { get { return _Fatique; } }
        int Stress { get { return _Stress; } }
        string Name { get { return _Name; } }
        bool Alive { get { return _Alive; } }

        // Constructor Chain
        Mortal() : this(100, 0, 0, 0, string.Empty) { }

        Mortal(int InitialHP) : this(InitialHP, 100, 0, 0, string.Empty) { }

        Mortal(int InitialHP, int InitialHunger) : this(InitialHP, InitialHunger, 0, 0, string.Empty) { }

        Mortal(int InitialHP, int InitialHunger, int InitialFatique) : this(InitialHP, 100, 0, 0, string.Empty) { }

        Mortal(int InitialHP, int InitialHunger, int InitialFatique, int InitialStress) : this(InitialHP, 100, 0, 0, string.Empty) { }

        Mortal(int InitialHP, int InitialHunger, int InitialFatique, int InitialStress, string NewName)
        {

            _HP = InitialHP;
            _Hunger = Hunger;
            _Fatique = Fatique;
            _Stress = Stress;
            _Name = NewName;
            _Alive = true;

        }

    }
}
