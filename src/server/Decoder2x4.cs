using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace GG
{
    public class Decoder2x4 : LogicComponent
    {
        protected override void DoLogicUpdate()
        {
            Outputs[0].On = !Inputs[1].On & !Inputs[0].On;
            Outputs[1].On = !Inputs[1].On & Inputs[0].On;
            Outputs[2].On = Inputs[1].On & !Inputs[0].On;
            Outputs[3].On = Inputs[1].On & Inputs[0].On;
        }
    }
}