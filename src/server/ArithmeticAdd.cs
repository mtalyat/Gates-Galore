using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace GG
{
    public class ArithmeticAdd : LogicComponent
    {
        protected override void DoLogicUpdate()
        {
            //  input
            // 0 is carry
            // 1-8 is a
            // 9-16 is b

            //  output
            // 0 is carry
            // 1-8 is outputs

            // carry in
            bool carry = Inputs[0].On;

            Add(1, ref carry);
            Add(2, ref carry);
            Add(3, ref carry);
            Add(4, ref carry);
            Add(5, ref carry);
            Add(6, ref carry);
            Add(7, ref carry);
            Add(8, ref carry);

            // carry out
            Outputs[0].On = carry;
        }

        private void Add(int index, ref bool carry)
        {
            bool a = Inputs[index].On;
            bool b = Inputs[index + 8].On;
            bool ab = a ^ b;
            Outputs[index].On = ab ^ carry;
            carry = (ab & carry) | (a & b);
        }
    }
}