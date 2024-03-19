using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkExtractGhostCells
	/// </summary>
	/// <remarks>
	///  Extracts ghost cells from the input and untag them (they become visible).
	///
	/// This filter takes a `vtkDataSet` as input, removes any non-ghost cell,
	/// and renames the ghost cell array in the output to what `OutputGhostArrayName` is set to
	/// so it is no longer treated as a ghost type array.
	/// By default, `OutputGhostArrayName` is set to `GhostType`.
	/// </remarks>
	// Token: 0x0200089D RID: 2205
	public class vtkExtractGhostCells : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016E53 RID: 93779 RVA: 0x00202CA7 File Offset: 0x00200EA7
		static vtkExtractGhostCells()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractGhostCells.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractGhostCells"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016E54 RID: 93780 RVA: 0x00202CCF File Offset: 0x00200ECF
		public vtkExtractGhostCells(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016E55 RID: 93781
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractGhostCells_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E56 RID: 93782 RVA: 0x00202CE0 File Offset: 0x00200EE0
		public new static vtkExtractGhostCells New()
		{
			vtkExtractGhostCells result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractGhostCells.vtkExtractGhostCells_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractGhostCells)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E57 RID: 93783 RVA: 0x00202D34 File Offset: 0x00200F34
		public vtkExtractGhostCells() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractGhostCells.vtkExtractGhostCells_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016E58 RID: 93784 RVA: 0x00202D78 File Offset: 0x00200F78
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016E59 RID: 93785
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractGhostCells_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E5A RID: 93786 RVA: 0x00202D84 File Offset: 0x00200F84
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractGhostCells.vtkExtractGhostCells_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06016E5B RID: 93787
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractGhostCells_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E5C RID: 93788 RVA: 0x00202DA4 File Offset: 0x00200FA4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractGhostCells.vtkExtractGhostCells_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06016E5D RID: 93789
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractGhostCells_GetOutputGhostArrayName_03(HandleRef pThis);

		/// <summary>
		/// Set / Get the name of the ghost cell array in the output.
		/// </summary>
		// Token: 0x06016E5E RID: 93790 RVA: 0x00202DC0 File Offset: 0x00200FC0
		public virtual string GetOutputGhostArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExtractGhostCells.vtkExtractGhostCells_GetOutputGhostArrayName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06016E5F RID: 93791
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractGhostCells_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E60 RID: 93792 RVA: 0x00202DFC File Offset: 0x00200FFC
		public override int IsA(string type)
		{
			return vtkExtractGhostCells.vtkExtractGhostCells_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06016E61 RID: 93793
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractGhostCells_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E62 RID: 93794 RVA: 0x00202E1C File Offset: 0x0020101C
		public new static int IsTypeOf(string type)
		{
			return vtkExtractGhostCells.vtkExtractGhostCells_IsTypeOf_05(type);
		}

		// Token: 0x06016E63 RID: 93795
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractGhostCells_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E64 RID: 93796 RVA: 0x00202E38 File Offset: 0x00201038
		public new vtkExtractGhostCells NewInstance()
		{
			vtkExtractGhostCells result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractGhostCells.vtkExtractGhostCells_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractGhostCells)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016E65 RID: 93797
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractGhostCells_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E66 RID: 93798 RVA: 0x00202E94 File Offset: 0x00201094
		public new static vtkExtractGhostCells SafeDownCast(vtkObjectBase o)
		{
			vtkExtractGhostCells vtkExtractGhostCells = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractGhostCells.vtkExtractGhostCells_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractGhostCells = (vtkExtractGhostCells)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractGhostCells.Register(null);
				}
			}
			return vtkExtractGhostCells;
		}

		// Token: 0x06016E67 RID: 93799
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractGhostCells_SetOutputGhostArrayName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set / Get the name of the ghost cell array in the output.
		/// </summary>
		// Token: 0x06016E68 RID: 93800 RVA: 0x00202F13 File Offset: 0x00201113
		public virtual void SetOutputGhostArrayName(string _arg)
		{
			vtkExtractGhostCells.vtkExtractGhostCells_SetOutputGhostArrayName_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400199B RID: 6555
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractGhostCells";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400199C RID: 6556
		public new static readonly string MRClassNameKey = "class vtkExtractGhostCells";
	}
}
