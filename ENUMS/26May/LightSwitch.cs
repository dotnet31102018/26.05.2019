using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26May
{
    class LightSwitch
    {
        public LightSwitchState State { get; set; }

        public LightSwitch()
        {
            this.State = LightSwitchState.OFF;
        }

        public void ChangeState()
        {
            if (State != LightSwitchState.BROKEN)
            {
                //if (State == "On")
                //{
                //    State = "Off";
                //}
                //else
                //{
                //    State = "On";
                //}

                State = State == LightSwitchState.BROKEN ? LightSwitchState.BROKEN : State == LightSwitchState.OFF ? 
                    LightSwitchState.ON : LightSwitchState.OFF;
            }
        }

        public void ElectricShock()
        {
            State = LightSwitchState.BROKEN;
        }

        public String TranslateState()
        {
            switch (State)
            {
                case LightSwitchState.BROKEN: return "Shabur";
                case LightSwitchState.ON: return "Dolek";
                case LightSwitchState.OFF: return "Mehube";
                default: throw new NotImplementedException($"Type {State} not implemented");

            }
        }
    }
}

