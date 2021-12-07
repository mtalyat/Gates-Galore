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
            if (base.Inputs[2].On)
            {
                if (base.Inputs[1].On)
                {
                    if (base.Inputs[0].On)
                    {
                        base.Outputs[0].On = base.Inputs[10].On;
                    }
                    else
                    {
                        base.Outputs[0].On = base.Inputs[9].On;
                    }
                }
                else
                {
                    if (base.Inputs[0].On)
                    {
                        base.Outputs[0].On = base.Inputs[8].On;
                    }
                    else
                    {
                        base.Outputs[0].On = base.Inputs[7].On;
                    }
                }
            }
            else
            {
                if (base.Inputs[1].On)
                {
                    if (base.Inputs[0].On)
                    {
                        base.Outputs[0].On = base.Inputs[6].On;
                    }
                    else
                    {
                        base.Outputs[0].On = base.Inputs[5].On;
                    }
                }
                else
                {
                    if (base.Inputs[0].On)
                    {
                        base.Outputs[0].On = base.Inputs[4].On;
                    }
                    else
                    {
                        base.Outputs[0].On = base.Inputs[3].On;
                    }
                }
            }
        }
    }
}