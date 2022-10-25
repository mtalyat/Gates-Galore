using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace GG
{
    public class FullAdder : LogicComponent
    {
        protected override void DoLogicUpdate()
        {
            //carry
            Outputs[0].On = (Inputs[2].On & (Inputs[0].On ^ Inputs[1].On)) | (Inputs[0].On & Inputs[1].On);
            //sum
            Outputs[1].On = (Inputs[0].On ^ Inputs[1].On) ^ Inputs[2].On;
        }
    }
}