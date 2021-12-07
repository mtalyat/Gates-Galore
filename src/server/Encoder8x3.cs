using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace GG
{
    public class Encoder8x3 : LogicComponent
    {
        protected override void DoLogicUpdate()
        {
            base.Outputs[0].On = base.Inputs[1].On | base.Inputs[3].On | base.Inputs[5].On | base.Inputs[7].On;
            base.Outputs[1].On = base.Inputs[2].On | base.Inputs[3].On | base.Inputs[6].On | base.Inputs[7].On;
            base.Outputs[2].On = base.Inputs[4].On | base.Inputs[5].On | base.Inputs[6].On | base.Inputs[7].On;
        }
    }
}