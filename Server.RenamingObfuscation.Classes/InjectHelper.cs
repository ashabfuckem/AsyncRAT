using System;
using System.Collections.Generic;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.Utils;

namespace Server.RenamingObfuscation.Classes;

public static class InjectHelper
{
	public class ImportResolver
	{
		public virtual TypeDef Resolve(TypeDef typeDef)
		{
			return null;
		}

		public virtual MethodDef Resolve(MethodDef methodDef)
		{
			return null;
		}

		public virtual FieldDef Resolve(FieldDef fieldDef)
		{
			return null;
		}
	}

	private class InjectContext : ImportResolver
	{
		public readonly Dictionary<IDnlibDef, IDnlibDef> Map = new Dictionary<IDnlibDef, IDnlibDef>();

		public readonly ModuleDef OriginModule;

		public readonly ModuleDef TargetModule;

		private readonly Importer importer;

		public Importer Importer => importer;

		public InjectContext(ModuleDef module, ModuleDef target)
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			OriginModule = module;
			TargetModule = target;
			importer = new Importer(target, (ImporterOptions)1);
		}

		public override TypeDef Resolve(TypeDef typeDef)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			if (Map.ContainsKey((IDnlibDef)(object)typeDef))
			{
				return (TypeDef)Map[(IDnlibDef)(object)typeDef];
			}
			return null;
		}

		public override MethodDef Resolve(MethodDef methodDef)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			if (Map.ContainsKey((IDnlibDef)(object)methodDef))
			{
				return (MethodDef)Map[(IDnlibDef)(object)methodDef];
			}
			return null;
		}

		public override FieldDef Resolve(FieldDef fieldDef)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			if (Map.ContainsKey((IDnlibDef)(object)fieldDef))
			{
				return (FieldDef)Map[(IDnlibDef)(object)fieldDef];
			}
			return null;
		}
	}

	private static TypeDefUser Clone(TypeDef origin)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		TypeDefUser val = new TypeDefUser(origin.Namespace, origin.Name);
		((TypeDef)val).Attributes = origin.Attributes;
		if (origin.ClassLayout != null)
		{
			((TypeDef)val).ClassLayout = (ClassLayout)new ClassLayoutUser(origin.ClassLayout.PackingSize, origin.ClassSize);
		}
		foreach (GenericParam genericParameter in origin.GenericParameters)
		{
			((TypeDef)val).GenericParameters.Add((GenericParam)new GenericParamUser(genericParameter.Number, genericParameter.Flags, UTF8String.op_Implicit("-")));
		}
		return val;
	}

	private static MethodDefUser Clone(MethodDef origin)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		MethodDefUser val = new MethodDefUser(origin.Name, (MethodSig)null, origin.ImplAttributes, origin.Attributes);
		foreach (GenericParam genericParameter in origin.GenericParameters)
		{
			((MethodDef)val).GenericParameters.Add((GenericParam)new GenericParamUser(genericParameter.Number, genericParameter.Flags, UTF8String.op_Implicit("-")));
		}
		return val;
	}

	private static FieldDefUser Clone(FieldDef origin)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		return new FieldDefUser(origin.Name, (FieldSig)null, origin.Attributes);
	}

	private static TypeDef PopulateContext(TypeDef typeDef, InjectContext ctx)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		TypeDef val;
		if (!ctx.Map.TryGetValue((IDnlibDef)(object)typeDef, out var value))
		{
			val = (TypeDef)(object)Clone(typeDef);
			ctx.Map[(IDnlibDef)(object)typeDef] = (IDnlibDef)(object)val;
		}
		else
		{
			val = (TypeDef)value;
		}
		foreach (TypeDef nestedType in typeDef.NestedTypes)
		{
			val.NestedTypes.Add(PopulateContext(nestedType, ctx));
		}
		foreach (MethodDef method in typeDef.Methods)
		{
			IList<MethodDef> methods = val.Methods;
			IDnlibDef val2 = (ctx.Map[(IDnlibDef)(object)method] = (IDnlibDef)(object)Clone(method));
			methods.Add((MethodDef)val2);
		}
		foreach (FieldDef field in typeDef.Fields)
		{
			IList<FieldDef> fields = val.Fields;
			IDnlibDef val2 = (ctx.Map[(IDnlibDef)(object)field] = (IDnlibDef)(object)Clone(field));
			fields.Add((FieldDef)val2);
		}
		return val;
	}

	private static void CopyTypeDef(TypeDef typeDef, InjectContext ctx)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		TypeDef val = (TypeDef)ctx.Map[(IDnlibDef)(object)typeDef];
		Importer importer = ctx.Importer;
		val.BaseType = ((Importer)(ref importer)).Import(typeDef.BaseType);
		foreach (InterfaceImpl @interface in typeDef.Interfaces)
		{
			IList<InterfaceImpl> interfaces = val.Interfaces;
			importer = ctx.Importer;
			interfaces.Add((InterfaceImpl)new InterfaceImplUser(((Importer)(ref importer)).Import(@interface.Interface)));
		}
	}

	private static void CopyMethodDef(MethodDef methodDef, InjectContext ctx)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected O, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected O, but got Unknown
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected O, but got Unknown
		MethodDef val = (MethodDef)ctx.Map[(IDnlibDef)(object)methodDef];
		Importer importer = ctx.Importer;
		val.Signature = ((Importer)(ref importer)).Import(methodDef.Signature);
		val.Parameters.UpdateParameterTypes();
		if (methodDef.ImplMap != null)
		{
			val.ImplMap = (ImplMap)new ImplMapUser((ModuleRef)new ModuleRefUser(ctx.TargetModule, methodDef.ImplMap.Module.Name), methodDef.ImplMap.Name, methodDef.ImplMap.Attributes);
		}
		Enumerator<CustomAttribute> enumerator = ((LazyList<CustomAttribute>)(object)methodDef.CustomAttributes).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CustomAttribute current = enumerator.Current;
				CustomAttributeCollection customAttributes = val.CustomAttributes;
				importer = ctx.Importer;
				((LazyList<CustomAttribute>)(object)customAttributes).Add(new CustomAttribute((ICustomAttributeType)((Importer)(ref importer)).Import((IMethod)(object)current.Constructor)));
			}
		}
		finally
		{
			((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
		}
		if (!methodDef.HasBody)
		{
			return;
		}
		val.Body = new CilBody(methodDef.Body.InitLocals, (IList<Instruction>)new List<Instruction>(), (IList<ExceptionHandler>)new List<ExceptionHandler>(), (IList<Local>)new List<Local>());
		val.Body.MaxStack = methodDef.Body.MaxStack;
		Dictionary<object, object> bodyMap = new Dictionary<object, object>();
		Enumerator<Local> enumerator2 = methodDef.Body.Variables.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				Local current2 = enumerator2.Current;
				importer = ctx.Importer;
				Local val2 = new Local(((Importer)(ref importer)).Import(current2.Type));
				val.Body.Variables.Add(val2);
				val2.Name = current2.Name;
				bodyMap[current2] = val2;
			}
		}
		finally
		{
			((IDisposable)enumerator2/*cast due to constrained. prefix*/).Dispose();
		}
		foreach (Instruction instruction in methodDef.Body.Instructions)
		{
			Instruction val3 = new Instruction(instruction.OpCode, instruction.Operand);
			val3.SequencePoint = instruction.SequencePoint;
			if (val3.Operand is IType)
			{
				importer = ctx.Importer;
				val3.Operand = ((Importer)(ref importer)).Import((IType)val3.Operand);
			}
			else if (val3.Operand is IMethod)
			{
				importer = ctx.Importer;
				val3.Operand = ((Importer)(ref importer)).Import((IMethod)val3.Operand);
			}
			else if (val3.Operand is IField)
			{
				importer = ctx.Importer;
				val3.Operand = ((Importer)(ref importer)).Import((IField)val3.Operand);
			}
			val.Body.Instructions.Add(val3);
			bodyMap[instruction] = val3;
		}
		foreach (Instruction instruction2 in val.Body.Instructions)
		{
			if (instruction2.Operand != null && bodyMap.ContainsKey(instruction2.Operand))
			{
				instruction2.Operand = bodyMap[instruction2.Operand];
			}
			else if (instruction2.Operand is Instruction[])
			{
				instruction2.Operand = ((IEnumerable<Instruction>)(Instruction[])instruction2.Operand).Select((Func<Instruction, Instruction>)((Instruction target) => (Instruction)bodyMap[target])).ToArray();
			}
		}
		foreach (ExceptionHandler exceptionHandler in methodDef.Body.ExceptionHandlers)
		{
			IList<ExceptionHandler> exceptionHandlers = val.Body.ExceptionHandlers;
			ExceptionHandler val4 = new ExceptionHandler(exceptionHandler.HandlerType);
			object catchType;
			if (exceptionHandler.CatchType != null)
			{
				importer = ctx.Importer;
				catchType = ((Importer)(ref importer)).Import(exceptionHandler.CatchType);
			}
			else
			{
				catchType = null;
			}
			val4.CatchType = (ITypeDefOrRef)catchType;
			val4.TryStart = (Instruction)bodyMap[exceptionHandler.TryStart];
			val4.TryEnd = (Instruction)bodyMap[exceptionHandler.TryEnd];
			val4.HandlerStart = (Instruction)bodyMap[exceptionHandler.HandlerStart];
			val4.HandlerEnd = (Instruction)bodyMap[exceptionHandler.HandlerEnd];
			val4.FilterStart = ((exceptionHandler.FilterStart == null) ? ((Instruction)null) : ((Instruction)bodyMap[exceptionHandler.FilterStart]));
			exceptionHandlers.Add(val4);
		}
		val.Body.SimplifyMacros((IList<Parameter>)val.Parameters);
	}

	private static void CopyFieldDef(FieldDef fieldDef, InjectContext ctx)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		FieldDef val = (FieldDef)ctx.Map[(IDnlibDef)(object)fieldDef];
		Importer importer = ctx.Importer;
		val.Signature = ((Importer)(ref importer)).Import(fieldDef.Signature);
	}

	private static void Copy(TypeDef typeDef, InjectContext ctx, bool copySelf)
	{
		if (copySelf)
		{
			CopyTypeDef(typeDef, ctx);
		}
		foreach (TypeDef nestedType in typeDef.NestedTypes)
		{
			Copy(nestedType, ctx, copySelf: true);
		}
		foreach (MethodDef method in typeDef.Methods)
		{
			CopyMethodDef(method, ctx);
		}
		foreach (FieldDef field in typeDef.Fields)
		{
			CopyFieldDef(field, ctx);
		}
	}

	public static TypeDef Inject(TypeDef typeDef, ModuleDef target)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		InjectContext injectContext = new InjectContext(typeDef.Module, target);
		PopulateContext(typeDef, injectContext);
		Copy(typeDef, injectContext, copySelf: true);
		return (TypeDef)injectContext.Map[(IDnlibDef)(object)typeDef];
	}

	public static MethodDef Inject(MethodDef methodDef, ModuleDef target)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		InjectContext injectContext = new InjectContext(methodDef.Module, target);
		injectContext.Map[(IDnlibDef)(object)methodDef] = (IDnlibDef)(object)Clone(methodDef);
		CopyMethodDef(methodDef, injectContext);
		return (MethodDef)injectContext.Map[(IDnlibDef)(object)methodDef];
	}

	public static IEnumerable<IDnlibDef> Inject(TypeDef typeDef, TypeDef newType, ModuleDef target)
	{
		InjectContext injectContext = new InjectContext(typeDef.Module, target);
		injectContext.Map[(IDnlibDef)(object)typeDef] = (IDnlibDef)(object)newType;
		PopulateContext(typeDef, injectContext);
		Copy(typeDef, injectContext, copySelf: false);
		return injectContext.Map.Values.Except((IEnumerable<IDnlibDef>)(object)new TypeDef[1] { newType });
	}
}
