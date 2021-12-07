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
            base.Outputs[0].On = !base.Inputs[2].On & !base.Inputs[1].On & !base.Inputs[0].On;
            base.Outputs[1].On = !base.Inputs[2].On & !base.Inputs[1].On & base.Inputs[0].On;
            base.Outputs[2].On = !base.Inputs[2].On & base.Inputs[1].On & !base.Inputs[0].On;
            base.Outputs[3].On = !base.Inputs[2].On & base.Inputs[1].On & base.Inputs[0].On;
            base.Outputs[4].On = base.Inputs[2].On & !base.Inputs[1].On & !base.Inputs[0].On;
            base.Outputs[5].On = base.Inputs[2].On & !base.Inputs[1].On & base.Inputs[0].On;
            base.Outputs[6].On = base.Inputs[2].On & base.Inputs[1].On & !base.Inputs[0].On;
            base.Outputs[7].On = base.Inputs[2].On & base.Inputs[1].On & base.Inputs[0].On;
        }
    }
}