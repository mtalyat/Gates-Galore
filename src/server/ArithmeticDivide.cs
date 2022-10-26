using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace GG
{
    public class ArithmeticDivide : LogicComponent
    {
        protected override void DoLogicUpdate()
        {
            // get number from inputs
            int right = (Inputs[0].On ? 1 : 0) | ((Inputs[1].On ? 1 : 0) << 1) | ((Inputs[2].On ? 1 : 0) << 2) | ((Inputs[3].On ? 1 : 0) << 3) | ((Inputs[4].On ? 1 : 0) << 4) | ((Inputs[5].On ? 1 : 0) << 5) | ((Inputs[6].On ? 1 : 0) << 6) | ((Inputs[7].On ? 1 : 0) << 7);
            int left = (Inputs[8].On ? 1 : 0) | ((Inputs[9].On ? 1 : 0) << 1) | ((Inputs[10].On ? 1 : 0) << 2) | ((Inputs[11].On ? 1 : 0) << 3) | ((Inputs[12].On ? 1 : 0) << 4) | ((Inputs[13].On ? 1 : 0) << 5) | ((Inputs[14].On ? 1 : 0) << 6) | ((Inputs[15].On ? 1 : 0) << 7);

            // divide
            int result;

            // if right is 0, just set to zero
            if (right == 0)
            {
                result = 0;
            }
            else
            {
                result = left / right;
            }

            // put in outputs
            Outputs[0].On = (result & 1) != 0;
            Outputs[1].On = ((result >> 1) & 1) != 0;
            Outputs[2].On = ((result >> 2) & 1) != 0;
            Outputs[3].On = ((result >> 3) & 1) != 0;
            Outputs[4].On = ((result >> 4) & 1) != 0;
            Outputs[5].On = ((result >> 5) & 1) != 0;
            Outputs[6].On = ((result >> 6) & 1) != 0;
            Outputs[7].On = ((result >> 7) & 1) != 0;
        }
    }
}