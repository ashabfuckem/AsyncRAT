using dnlib.DotNet;
using Server.RenamingObfuscation.Interfaces;

namespace Server.RenamingObfuscation.Classes;

public class PropertiesRenaming : IRenaming
{
	public ModuleDefMD Rename(ModuleDefMD module)
	{
		foreach (TypeDef type in ((ModuleDef)module).GetTypes())
		{
			if (type.IsGlobalModuleType)
			{
				continue;
			}
			foreach (PropertyDef property in type.Properties)
			{
				property.Name = UTF8String.op_Implicit(Utils.GenerateRandomString());
			}
		}
		return module;
	}
}
