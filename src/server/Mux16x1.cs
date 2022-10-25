using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace GG
{
    public class Mux16x1 : LogicComponent
    {
        protected override void DoLogicUpdate()
        {
            if (Inputs[3].On)
            {
                if (Inputs[2].On)
                {
                    if (Inputs[1].On)
                    {
                        if (Inputs[0].On)
                        {
                            Outputs[0].On = Inputs[19].On;
                        }
                        else
                        {
                            Outputs[0].On = Inputs[18].On;
                        }
                    }
                    else
                    {
                        if (Inputs[0].On)
                        {
                            Outputs[0].On = Inputs[17].On;
                        }
                        else
                        {
                            Outputs[0].On = Inputs[16].On;
                        }
                    }
                }
                else
                {
                    if (Inputs[1].On)
                    {
                        if (Inputs[0].On)
                        {
                            Outputs[0].On = Inputs[15].On;
                        }
                        else
                        {
                            Outputs[0].On = Inputs[14].On;
                        }
                    }
                    else
                    {
                        if (Inputs[0].On)
                        {
                            Outputs[0].On = Inputs[13].On;
                        }
                        else
                        {
                            Outputs[0].On = Inputs[12].On;
                        }
                    }
                }
            }
            else
            {
                if (Inputs[2].On)
                {
                    if (Inputs[1].On)
                    {
                        if (Inputs[0].On)
                        {
                            Outputs[0].On = Inputs[11].On;
                        }
                        else
                        {
                            Outputs[0].On = Inputs[10].On;
                        }
                    }
                    else
                    {
                        if (Inputs[0].On)
                        {
                            Outputs[0].On = Inputs[9].On;
                        }
                        else
                        {
                            Outputs[0].On = Inputs[8].On;
                        }
                    }
                }
                else
                {
                    if (Inputs[1].On)
                    {
                        if (Inputs[0].On)
                        {
                            Outputs[0].On = Inputs[7].On;
                        }
                        else
                        {
                            Outputs[0].On = Inputs[6].On;
                        }
                    }
                    else
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
                }
            }
        }
    }
}