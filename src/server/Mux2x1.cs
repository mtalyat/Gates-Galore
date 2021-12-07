using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace GG
{
    public class Mux2x1 : LogicComponent
    {
        protected override void DoLogicUpdate()
        {
            if (base.Inputs[0].On)
            {
                base.Outputs[0].On = base.Inputs[1].On;
            }
            else
            {
                base.Outputs[0].On = base.Inputs[2].On;
            }
        }
    }
}