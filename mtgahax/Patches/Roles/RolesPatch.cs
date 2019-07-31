using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dnlib.DotNet.Emit;

namespace mtgahax.Patches.Roles
{
    public class RolesPatch : Patch
    {
        public RolesPatch(string targetAssembly) : base(targetAssembly) { }

        public void Apply(List<string> roles)
        {
            if (roles.Count == 0)
                return;

            var targetClass = FindClassType(_targetAsmDef, "AccountInformation");
            foreach (var method in targetClass.Methods)
            {
                if (method.Body.Instructions.Count != 5) continue;

                string role = method.Body.Instructions[2].Operand.ToString();

                method.Body.Instructions.Clear();
                method.Body.Instructions.Add(roles.Contains(role)
                    ? new Instruction(OpCodes.Ldc_I4_1)
                    : new Instruction(OpCodes.Ldc_I4_0));
                method.Body.Instructions.Add(new Instruction(OpCodes.Ret));
            }

            WriteToAssembly(_targetAsmPath);
            
        }
    }
}