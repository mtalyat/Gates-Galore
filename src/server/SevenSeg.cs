using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace GG
{
    public class SevenSeg : LogicComponent
    {
        protected override void DoLogicUpdate()
        {
            //put input values into a number
            byte input = 0;

            for (int i = 0; i < 4; i++)
            {
                if (Inputs[i].On)
                {
                    input |= (byte)(1 << i);
                }
            }

            byte output = 0;

            //then determine the output
            switch (input)
            {
                case 0:
                    output = 0b01111110;
                    break;
                case 1:
                    output = 0b00000110;
                    break;
                case 2:
                    output = 0b01011011;
                    break;
                case 3:
                    output = 0b01001111;
                    break;
                case 4:
                    output = 0b00100111;
                    break;
                case 5:
                    output = 0b01101101;
                    break;
                case 6:
                    output = 0b01111101;
                    break;
                case 7:
                    output = 0b01000110;
                    break;
                case 8:
                    output = 0b01111111;
                    break;
                case 9:
                    output = 0b01101111;
                    break;
                case 10:
                    output = 0b01110111;
                    break;
                case 11:
                    output = 0b00111101;
                    break;
                case 12:
                    output = 0b01111000;
                    break;
                case 13:
                    output = 0b00011111;
                    break;
                case 14:
                    output = 0b01111001;
                    break;
                case 15:
                    output = 0b01110001;
                    break;
            }

            //and then pump that back into the output values

            for (int i = 0; i < 7; i++)
            {
                //assign A to the MSB, followed by B, followed by C... etc.
                Outputs[i].On = ((output >> (6 - i)) & 0b00000001) == 1;
            }
        }
    }
}