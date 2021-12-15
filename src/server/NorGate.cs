using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace GG
{
    public class NorGate : LogicComponent
    {
        protected override void DoLogicUpdate()
        {
            Outputs[0].On = !(Inputs[0].On | Inputs[1].On);
        }
    }
}