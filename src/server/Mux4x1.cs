using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace GG
{
    public class Mux4x1 : LogicComponent
    {
        protected override void DoLogicUpdate()
        {
            if (base.Inputs[1].On)
            {
                if (base.Inputs[0].On)
                {
                    base.Outputs[0].On = base.Inputs[5].On;
                }
                else
                {
                    base.Outputs[0].On = base.Inputs[4].On;
                }
            }
            else
            {
                if (base.Inputs[0].On)
                {
                    base.Outputs[0].On = base.Inputs[3].On;
                }
                else
                {
                    base.Outputs[0].On = base.Inputs[2].On;
                }
            }
        }
    }
}