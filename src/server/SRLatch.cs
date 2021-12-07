using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace GG
{
    public class SRLatch : LogicComponent
    {
        protected override void DoLogicUpdate()
        {
            if (!base.Inputs[0].On & base.Inputs[1].On)//S = 0, R = 1
            {
                base.Outputs[0].On = false;
            }
            else if (base.Inputs[0].On & !base.Inputs[1].On)//S = 1, R = 0
            {
                base.Outputs[0].On = true;
            }

            //no change otherwise
        }
    }
}