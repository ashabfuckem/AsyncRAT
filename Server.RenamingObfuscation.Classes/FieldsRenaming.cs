using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Server.RenamingObfuscation.Interfaces;

namespace Server.RenamingObfuscation.Classes;

public class FieldsRenaming : IRenaming
{
	private static Dictionary<string, string> _names = new Dictionary<string, string>();

	public ModuleDefMD Rename(ModuleDefMD module)
	{
		foreach (TypeDef type in ((ModuleDef)module).GetTypes())
		{
			if (type.IsGlobalModuleType)
			{
				continue;
			}
			foreach (FieldDef field in type.Fields)
			{
				if (_names.TryGetValue(UTF8String.op_Implicit(field.Name), out var value))
				{
					field.Name = UTF8String.op_Implicit(value);
				}
				else if (!field.IsSpecialName && !field.HasCustomAttributes)
				{
					string text = Utils.GenerateRandomString();
					_names.Add(UTF8String.op_Implicit(field.Name), text);
					field.Name = UTF8String.op_Implicit(text);
				}
			}
		}
		return ApplyChangesToResources(module);
	}

	private static ModuleDefMD ApplyChangesToResources(ModuleDefMD module)
	{
		foreach (TypeDef type in ((ModuleDef)module).GetTypes())
		{
			if (type.IsGlobalModuleType)
			{
				continue;
			}
			foreach (MethodDef method in type.Methods)
			{
				if (method.Name != "InitializeComponent")
				{
					continue;
				}
				IList<Instruction> instructions = method.Body.Instructions;
				for (int i = 0; i < instructions.Count - 3; i++)
				{
					if (instructions[i].OpCode != OpCodes.Ldstr)
					{
						continue;
					}
					foreach (KeyValuePair<string, string> name in _names)
					{
						if (name.Key == instructions[i].Operand.ToString())
						{
							instructions[i].Operand = name.Value;
						}
					}
				}
			}
		}
		return module;
	}
}
