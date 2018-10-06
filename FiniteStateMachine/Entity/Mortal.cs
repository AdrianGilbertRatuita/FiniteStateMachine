using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMachineTesting.StateMachine;
using StateMachineTesting.StateMachine.States;
using StateMachineTesting.Entity.MortalStates;

namespace StateMachineTesting.Entity
{
    public class Mortal : BaseEntity, IMortal
    {

        // Mortal Fields
        int _HP;
        int _Hunger;
        int _Fatique;
        int _Stress;
        string _Name;
        bool _Alive;

        // Mortal Properties
        public int HP { get; private set; }

        public int Hunger { get; private set; }

        public int Fatique { get; private set; }

        public int Stress { get; private set; }

        public string Name { get; private set; }

        public bool Alive { get; private set; }

        public OneWayStateMachine LivingStates { get; set; }

        public ParallelStates_FiniteStateMachine NeedsStates { get; set; }


        // Constructor Chain
        public Mortal() : this(100, 0, 0, 0, string.Empty) { }

        public Mortal(int InitialHP) : this(InitialHP, 100, 0, 0, string.Empty) { }

        public Mortal(int InitialHP, int InitialHunger) : this(InitialHP, InitialHunger, 0, 0, string.Empty) { }

        public Mortal(int InitialHP, int InitialHunger, int InitialFatique) : this(InitialHP, 100, 0, 0, string.Empty) { }

        public Mortal(int InitialHP, int InitialHunger, int InitialFatique, int InitialStress) : this(InitialHP, 100, 0, 0, string.Empty) { }

        public Mortal(int InitialHP, int InitialHunger, int InitialFatique, int InitialStress, string NewName) : base(NewName)
        {

            _HP = InitialHP;
            _Hunger = InitialHunger;
            _Fatique = InitialFatique;
            _Stress = InitialStress;
            _Name = NewName;
            _Alive = true;

        }

        public void SetupLivingStates()
        {

            // Setup List of standard mortal states
            List<IState> MortalLivingStates = new List<IState>();
            MortalLivingStates.Add(new MortalAliveState(MortalLive, this));
            MortalLivingStates.Add(new MortalDeadState(this));


            // Add to Mortal LivingStates list
            LivingStates = new OneWayStateMachine(MortalLivingStates);

        }

        public void SetupNeedsStates()
        {



        }

        public void MortalLive()
        {



        }

    }

}
