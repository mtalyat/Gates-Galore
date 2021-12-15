using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace GG
{
    public class Mux8x1 : LogicComponent
    {
        protected override void DoLogicUpdate()
        {
            if (Inputs[2].On)
            {
                if (Inputs[1].On)
                {
                    if (Inputs[0].On)
                    {
                        Outputs[0].On = Inputs[10].On;
                    }
                    else
                    {
                        Outputs[0].On = Inputs[9].On;
                    }
                }
                else
                {
                    if (Inputs[0].On)
                    {
                        Outputs[0].On = Inputs[8].On;
                    }
                    else
                    {
                        Outputs[0].On = Inputs[7].On;
                    }
                }
            }
            else
            {
                if (Inputs[1].On)
                {
                    if (Inputs[0].On)
                    {
                        Outputs[0].On = Inputs[6].On;
                    }
                    else
                    {
                        Outputs[0].On = Inputs[5].On;
                    }
                }
                else
                {
                    if (Inputs[0].On)
                    {
                        Outputs[0].On = Inputs[4].On;
                    }
                    else
                    {
                        Outputs[0].On = Inputs[3].On;
                    }
                }
            }
        }
    }
}