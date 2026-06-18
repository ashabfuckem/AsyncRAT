using dnlib.DotNet;
using Server.RenamingObfuscation.Interfaces;

namespace Server.RenamingObfuscation.Classes;

public class MethodsRenaming : IRenaming
{
	public ModuleDefMD Rename(ModuleDefMD module)
	{
		foreach (TypeDef type in ((ModuleDef)module).Types)
		{
			if (type.IsGlobalModuleType)
			{
				continue;
			}
			type.Name = UTF8String.op_Implicit(Utils.GenerateRandomString());
			foreach (MethodDef method in type.Methods)
			{
				if (!method.IsSpecialName && !method.IsConstructor && !method.HasCustomAttributes && !method.IsAbstract && !method.IsVirtual && method.Name != "Main")
				{
					method.Name = UTF8String.op_Implicit(Utils.GenerateRandomString());
				}
				foreach (ParamDef paramDef in method.ParamDefs)
				{
					paramDef.Name = UTF8String.op_Implicit(Utils.GenerateRandomString());
				}
			}
		}
		return module;
	}
}
