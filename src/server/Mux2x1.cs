using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace GG
{
    public class Mux2x1 : LogicComponent
    {
        protected override void DoLogicUpdate()
        {
            if (Inputs[0].On)
            {
                Outputs[0].On = Inputs[1].On;
            }
            else
            {
                Outputs[0].On = Inputs[2].On;
            }
        }
    }
}