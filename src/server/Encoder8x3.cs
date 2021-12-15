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
            Outputs[0].On = Inputs[1].On | Inputs[3].On | Inputs[5].On | Inputs[7].On;
            Outputs[1].On = Inputs[2].On | Inputs[3].On | Inputs[6].On | Inputs[7].On;
            Outputs[2].On = Inputs[4].On | Inputs[5].On | Inputs[6].On | Inputs[7].On;
        }
    }
}