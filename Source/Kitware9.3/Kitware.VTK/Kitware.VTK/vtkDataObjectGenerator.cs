using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataObjectGenerator
	/// </summary>
	/// <remarks>
	///    produces simple (composite or atomic) data
	/// sets for testing.
	///
	/// vtkDataObjectGenerator parses a string and produces dataobjects from the
	/// dataobject template names it sees in the string. For example, if the string
	/// contains "ID1" the generator will create a vtkImageData. "UF1", "RG1",
	/// "SG1", "PD1", and "UG1" will produce vtkUniformGrid, vtkRectilinearGrid,
	/// vtkStructuredGrid, vtkPolyData and vtkUnstructuredGrid respectively.
	/// "PD2" will produce an alternate vtkPolyData. You
	/// can compose composite datasets from the atomic ones listed above
	/// by placing them within one of the two composite dataset identifiers
	/// - "MB{}" or "HB[]". "MB{ ID1 PD1 MB{} }" for example will create a
	/// vtkMultiBlockDataSet consisting of three blocks: image data, poly data,
	/// multi-block (empty). Hierarchical Box data sets additionally require
	/// the notion of groups, declared within "()" braces, to specify AMR depth.
	/// "HB[ (UF1)(UF1)(UF1) ]" will create a vtkHierarchicalBoxDataSet representing
	/// an octree that is three levels deep, in which the firstmost cell in each level
	/// is refined.
	/// </remarks>
	// Token: 0x02000955 RID: 2389
	public class vtkDataObjectGenerator : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018C85 RID: 101509 RVA: 0x002297D3 File Offset: 0x002279D3
		static vtkDataObjectGenerator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataObjectGenerator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObjectGenerator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018C86 RID: 101510 RVA: 0x002297FB File Offset: 0x002279FB
		public vtkDataObjectGenerator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018C87 RID: 101511
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectGenerator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C88 RID: 101512 RVA: 0x0022980C File Offset: 0x00227A0C
		public new static vtkDataObjectGenerator New()
		{
			vtkDataObjectGenerator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectGenerator.vtkDataObjectGenerator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C89 RID: 101513 RVA: 0x00229860 File Offset: 0x00227A60
		public vtkDataObjectGenerator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataObjectGenerator.vtkDataObjectGenerator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018C8A RID: 101514 RVA: 0x002298A4 File Offset: 0x00227AA4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018C8B RID: 101515
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectGenerator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C8C RID: 101516 RVA: 0x002298B0 File Offset: 0x00227AB0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataObjectGenerator.vtkDataObjectGenerator_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06018C8D RID: 101517
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectGenerator_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C8E RID: 101518 RVA: 0x002298D0 File Offset: 0x00227AD0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataObjectGenerator.vtkDataObjectGenerator_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06018C8F RID: 101519
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectGenerator_GetProgram_03(HandleRef pThis);

		/// <summary>
		/// The string that will be parsed to specify a dataobject structure.
		/// </summary>
		// Token: 0x06018C90 RID: 101520 RVA: 0x002298EC File Offset: 0x00227AEC
		public virtual string GetProgram()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataObjectGenerator.vtkDataObjectGenerator_GetProgram_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018C91 RID: 101521
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectGenerator_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C92 RID: 101522 RVA: 0x00229928 File Offset: 0x00227B28
		public override int IsA(string type)
		{
			return vtkDataObjectGenerator.vtkDataObjectGenerator_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06018C93 RID: 101523
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectGenerator_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C94 RID: 101524 RVA: 0x00229948 File Offset: 0x00227B48
		public new static int IsTypeOf(string type)
		{
			return vtkDataObjectGenerator.vtkDataObjectGenerator_IsTypeOf_05(type);
		}

		// Token: 0x06018C95 RID: 101525
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectGenerator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C96 RID: 101526 RVA: 0x00229964 File Offset: 0x00227B64
		public new vtkDataObjectGenerator NewInstance()
		{
			vtkDataObjectGenerator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectGenerator.vtkDataObjectGenerator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018C97 RID: 101527
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectGenerator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C98 RID: 101528 RVA: 0x002299C0 File Offset: 0x00227BC0
		public new static vtkDataObjectGenerator SafeDownCast(vtkObjectBase o)
		{
			vtkDataObjectGenerator vtkDataObjectGenerator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectGenerator.vtkDataObjectGenerator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObjectGenerator = (vtkDataObjectGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObjectGenerator.Register(null);
				}
			}
			return vtkDataObjectGenerator;
		}

		// Token: 0x06018C99 RID: 101529
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectGenerator_SetProgram_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The string that will be parsed to specify a dataobject structure.
		/// </summary>
		// Token: 0x06018C9A RID: 101530 RVA: 0x00229A3F File Offset: 0x00227C3F
		public virtual void SetProgram(string _arg)
		{
			vtkDataObjectGenerator.vtkDataObjectGenerator_SetProgram_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B63 RID: 7011
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataObjectGenerator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B64 RID: 7012
		public new static readonly string MRClassNameKey = "class vtkDataObjectGenerator";
	}
}
