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
            if (Inputs[1].On)
            {
                if (Inputs[0].On)
                {
                    Outputs[0].On = Inputs[5].On;
                }
                else
                {
                    Outputs[0].On = Inputs[4].On;
                }
            }
            else
            {
                if (Inputs[0].On)
                {
                    Outputs[0].On = Inputs[3].On;
                }
                else
                {
                    Outputs[0].On = Inputs[2].On;
                }
            }
        }
    }
}