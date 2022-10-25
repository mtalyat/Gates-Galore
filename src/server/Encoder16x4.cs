using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace GG
{
    public class Encoder16x4 : LogicComponent
    {
        protected override void DoLogicUpdate()
        {
            Outputs[0].On = Inputs[1].On | Inputs[3].On | Inputs[5].On | Inputs[7].On | Inputs[9].On | Inputs[11].On | Inputs[13].On | Inputs[15].On;
            Outputs[1].On = Inputs[2].On | Inputs[3].On | Inputs[6].On | Inputs[7].On | Inputs[10].On | Inputs[11].On | Inputs[14].On | Inputs[15].On;
            Outputs[2].On = Inputs[4].On | Inputs[5].On | Inputs[6].On | Inputs[7].On | Inputs[12].On | Inputs[13].On | Inputs[14].On | Inputs[15].On;
            Outputs[3].On = Inputs[8].On | Inputs[9].On | Inputs[10].On | Inputs[11].On | Inputs[12].On | Inputs[13].On | Inputs[14].On | Inputs[15].On;
        }
    }
}