using System.IO;
using System.Linq;
using dnlib.DotNet;

namespace mtgahax.Patches
{
    public abstract class Patch
    {
        protected string _targetAsmPath;
        protected AssemblyDef _targetAsmDef;

        protected Patch(string targetAssembly)
        {
            _targetAsmPath = targetAssembly;
            string backup = BackupAssembly(targetAssembly);
            ModuleDefMD module = ModuleDefMD.Load(backup);
            _targetAsmDef = module.Assembly;
        }

        private string BackupAssembly(string path)
        {
            if (File.Exists(path) && !File.Exists($"{path}.bak"))
                File.Copy(path, $"{path}.bak");
            
            return $"{path}.bak";
        }

        protected void WriteToAssembly(string targetPath)
        {
            _targetAsmDef.Write(targetPath);
        }

        protected FieldDef FindField(TypeDef classType, string fieldName)
        {
            return classType.Fields.First(f => f.Name == fieldName);
        }

        protected TypeDef FindClassType(AssemblyDef asm, string className)
        {
            foreach (var module in asm.Modules)
            {
                foreach (var type in module.Types)
                {
                    if (type.FullName == className)
                    {
                        return type;
                    }
                }
            }
            return null;
        }

        protected MethodDef FindMethodDef(TypeDef classType, string methodName)
        {
            foreach (MethodDef method in classType.Methods)
            {
                if (method.Name == methodName)
                {
                    return method;
                }
            }
            return null;
        }
    }
}