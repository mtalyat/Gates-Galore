using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace GG
{
    public class TLatch : LogicComponent
    {
        protected override void DoLogicUpdate()
        {
            //only toggle when both input and enable are on
            if (base.Inputs[0].On && base.Inputs[1].On)
            {
                base.Outputs[0].On = !base.Outputs[0].On;
            }
        }
    }
}