using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace GG
{
    public class Decoder4x16 : LogicComponent
    {
        protected override void DoLogicUpdate()
        {
            Outputs[0].On = !Inputs[3].On & !Inputs[2].On & !Inputs[1].On & !Inputs[0].On;
            Outputs[1].On = !Inputs[3].On & !Inputs[2].On & !Inputs[1].On & Inputs[0].On;
            Outputs[2].On = !Inputs[3].On & !Inputs[2].On & Inputs[1].On & !Inputs[0].On;
            Outputs[3].On = !Inputs[3].On & !Inputs[2].On & Inputs[1].On & Inputs[0].On;
            Outputs[4].On = !Inputs[3].On & Inputs[2].On & !Inputs[1].On & !Inputs[0].On;
            Outputs[5].On = !Inputs[3].On & Inputs[2].On & !Inputs[1].On & Inputs[0].On;
            Outputs[6].On = !Inputs[3].On & Inputs[2].On & Inputs[1].On & !Inputs[0].On;
            Outputs[7].On = !Inputs[3].On & Inputs[2].On & Inputs[1].On & Inputs[0].On;
            Outputs[8].On = Inputs[3].On & !Inputs[2].On & !Inputs[1].On & !Inputs[0].On;
            Outputs[9].On = Inputs[3].On & !Inputs[2].On & !Inputs[1].On & Inputs[0].On;
            Outputs[10].On = Inputs[3].On & !Inputs[2].On & Inputs[1].On & !Inputs[0].On;
            Outputs[11].On = Inputs[3].On & !Inputs[2].On & Inputs[1].On & Inputs[0].On;
            Outputs[12].On = Inputs[3].On & Inputs[2].On & !Inputs[1].On & !Inputs[0].On;
            Outputs[13].On = Inputs[3].On & Inputs[2].On & !Inputs[1].On & Inputs[0].On;
            Outputs[14].On = Inputs[3].On & Inputs[2].On & Inputs[1].On & !Inputs[0].On;
            Outputs[15].On = Inputs[3].On & Inputs[2].On & Inputs[1].On & Inputs[0].On;
        }
    }
}