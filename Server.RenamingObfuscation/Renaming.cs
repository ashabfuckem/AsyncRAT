using dnlib.DotNet;
using Server.RenamingObfuscation.Classes;
using Server.RenamingObfuscation.Interfaces;

namespace Server.RenamingObfuscation;

public class Renaming
{
	public static ModuleDefMD DoRenaming(ModuleDefMD inPath)
	{
		return RenamingObfuscation(inPath);
	}

	private static ModuleDefMD RenamingObfuscation(ModuleDefMD inModule)
	{
		ModuleDefMD module = inModule;
		module = ((IRenaming)new NamespacesRenaming()).Rename(module);
		module = ((IRenaming)new ClassesRenaming()).Rename(module);
		module = ((IRenaming)new MethodsRenaming()).Rename(module);
		module = ((IRenaming)new PropertiesRenaming()).Rename(module);
		return ((IRenaming)new FieldsRenaming()).Rename(module);
	}
}
