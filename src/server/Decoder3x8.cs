using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace GG
{
    public class Decoder3x8 : LogicComponent
    {
        protected override void DoLogicUpdate()
        {
            Outputs[0].On = !Inputs[2].On & !Inputs[1].On & !Inputs[0].On;
            Outputs[1].On = !Inputs[2].On & !Inputs[1].On & Inputs[0].On;
            Outputs[2].On = !Inputs[2].On & Inputs[1].On & !Inputs[0].On;
            Outputs[3].On = !Inputs[2].On & Inputs[1].On & Inputs[0].On;
            Outputs[4].On = Inputs[2].On & !Inputs[1].On & !Inputs[0].On;
            Outputs[5].On = Inputs[2].On & !Inputs[1].On & Inputs[0].On;
            Outputs[6].On = Inputs[2].On & Inputs[1].On & !Inputs[0].On;
            Outputs[7].On = Inputs[2].On & Inputs[1].On & Inputs[0].On;
        }
    }
}