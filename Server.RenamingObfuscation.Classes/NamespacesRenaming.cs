using System;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.Utils;
using Server.RenamingObfuscation.Interfaces;

namespace Server.RenamingObfuscation.Classes;

public class NamespacesRenaming : IRenaming
{
	private static Dictionary<string, string> _names = new Dictionary<string, string>();

	public ModuleDefMD Rename(ModuleDefMD module)
	{
		((ModuleDef)module).Name = UTF8String.op_Implicit(Utils.GenerateRandomString());
		foreach (TypeDef type in ((ModuleDef)module).GetTypes())
		{
			if (!type.IsGlobalModuleType && !(type.Namespace == ""))
			{
				if (_names.TryGetValue(UTF8String.op_Implicit(type.Namespace), out var value))
				{
					type.Namespace = UTF8String.op_Implicit(value);
					continue;
				}
				string text = Utils.GenerateRandomString();
				_names.Add(UTF8String.op_Implicit(type.Namespace), text);
				type.Namespace = UTF8String.op_Implicit(text);
			}
		}
		return ApplyChangesToResources(module);
	}

	private static ModuleDefMD ApplyChangesToResources(ModuleDefMD module)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<Resource> enumerator = ((LazyList<Resource>)(object)((ModuleDef)module).Resources).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Resource current = enumerator.Current;
				foreach (KeyValuePair<string, string> name in _names)
				{
					if (current.Name.Contains(name.Key))
					{
						current.Name = current.Name.Replace(name.Key, name.Value);
					}
				}
			}
		}
		finally
		{
			((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
		}
		foreach (TypeDef type in ((ModuleDef)module).GetTypes())
		{
			foreach (PropertyDef property in type.Properties)
			{
				if (property.Name != "ResourceManager")
				{
					continue;
				}
				IList<Instruction> instructions = property.GetMethod.Body.Instructions;
				for (int i = 0; i < instructions.Count; i++)
				{
					if (instructions[i].OpCode != OpCodes.Ldstr)
					{
						continue;
					}
					foreach (KeyValuePair<string, string> name2 in _names)
					{
						if (((object)instructions[i]).ToString().Contains(name2.Key))
						{
							instructions[i].Operand = instructions[i].Operand.ToString().Replace(name2.Key, name2.Value);
						}
					}
				}
			}
		}
		return module;
	}
}
