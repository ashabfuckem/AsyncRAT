using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Server.RenamingObfuscation.Classes;
using Server.RenamingObfuscation.Interfaces;

namespace Server.RenamingObfuscation;

public static class EncryptString
{
	private static MethodDef InjectMethod(ModuleDef module, string methodName)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		MethodDef result = (MethodDef)InjectHelper.Inject(ModuleDefMD.Load(typeof(DecryptionHelper).Module).ResolveTypeDef(MDToken.ToRID(typeof(DecryptionHelper).MetadataToken)), module.GlobalType, module).Single((IDnlibDef method) => ((IFullName)method).Name == methodName);
		foreach (MethodDef method in module.GlobalType.Methods)
		{
			if (method.Name == ".ctor")
			{
				module.GlobalType.Remove(method);
				break;
			}
		}
		return result;
	}

	public static void DoEncrypt(ModuleDef inPath)
	{
		EncryptStrings(inPath);
	}

	private static ModuleDef EncryptStrings(ModuleDef inModule)
	{
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		ICrypto crypto = new Base64();
		MethodDef val = InjectMethod(inModule, "Decrypt_Base64");
		foreach (TypeDef type in inModule.Types)
		{
			if (type.IsGlobalModuleType || type.Name == "Resources" || type.Name == "Settings")
			{
				continue;
			}
			foreach (MethodDef method in type.Methods)
			{
				if (!method.HasBody || method == val)
				{
					continue;
				}
				method.Body.KeepOldMaxStack = true;
				for (int i = 0; i < method.Body.Instructions.Count; i++)
				{
					if (method.Body.Instructions[i].OpCode == OpCodes.Ldstr)
					{
						string dataPlain = method.Body.Instructions[i].Operand.ToString();
						method.Body.Instructions[i].Operand = crypto.Encrypt(dataPlain);
						method.Body.Instructions.Insert(i + 1, new Instruction(OpCodes.Call, (object)val));
					}
				}
				method.Body.SimplifyBranches();
				method.Body.OptimizeBranches();
			}
		}
		return inModule;
	}
}
