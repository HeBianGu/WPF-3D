using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAdjacencyMatrixToEdgeTable
	///
	///
	/// Treats a dense 2-way array of doubles as an adacency matrix and converts it into a
	/// vtkTable suitable for use as an edge table with vtkTableToGraph.
	///
	/// @par Thanks:
	/// </summary>
	/// <seealso>
	/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
	/// </seealso>
	// Token: 0x02000670 RID: 1648
	public class vtkAdjacencyMatrixToEdgeTable : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011C73 RID: 72819 RVA: 0x0018DE83 File Offset: 0x0018C083
		static vtkAdjacencyMatrixToEdgeTable()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAdjacencyMatrixToEdgeTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAdjacencyMatrixToEdgeTable"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011C74 RID: 72820 RVA: 0x0018DEAB File Offset: 0x0018C0AB
		public vtkAdjacencyMatrixToEdgeTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011C75 RID: 72821
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAdjacencyMatrixToEdgeTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C76 RID: 72822 RVA: 0x0018DEBC File Offset: 0x0018C0BC
		public new static vtkAdjacencyMatrixToEdgeTable New()
		{
			vtkAdjacencyMatrixToEdgeTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAdjacencyMatrixToEdgeTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C77 RID: 72823 RVA: 0x0018DF10 File Offset: 0x0018C110
		public vtkAdjacencyMatrixToEdgeTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011C78 RID: 72824 RVA: 0x0018DF54 File Offset: 0x0018C154
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011C79 RID: 72825
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAdjacencyMatrixToEdgeTable_GetMinimumCount_01(HandleRef pThis);

		/// <summary>
		/// Specifies the minimum number of adjacent edges to include for each source vertex.
		/// Default: 0
		/// </summary>
		// Token: 0x06011C7A RID: 72826 RVA: 0x0018DF60 File Offset: 0x0018C160
		public virtual long GetMinimumCount()
		{
			return vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_GetMinimumCount_01(base.GetCppThis());
		}

		// Token: 0x06011C7B RID: 72827
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAdjacencyMatrixToEdgeTable_GetMinimumThreshold_02(HandleRef pThis);

		/// <summary>
		/// Specifies a minimum threshold that an edge weight must exceed to be included in
		/// the output.
		/// Default: 0.5
		/// </summary>
		// Token: 0x06011C7C RID: 72828 RVA: 0x0018DF80 File Offset: 0x0018C180
		public virtual double GetMinimumThreshold()
		{
			return vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_GetMinimumThreshold_02(base.GetCppThis());
		}

		// Token: 0x06011C7D RID: 72829
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAdjacencyMatrixToEdgeTable_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C7E RID: 72830 RVA: 0x0018DFA0 File Offset: 0x0018C1A0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06011C7F RID: 72831
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAdjacencyMatrixToEdgeTable_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C80 RID: 72832 RVA: 0x0018DFC0 File Offset: 0x0018C1C0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06011C81 RID: 72833
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAdjacencyMatrixToEdgeTable_GetSourceDimension_05(HandleRef pThis);

		/// <summary>
		/// Specifies whether rows or columns become the "source" in the output edge table.
		/// 0 = rows, 1 = columns.  Default: 0
		/// </summary>
		// Token: 0x06011C82 RID: 72834 RVA: 0x0018DFDC File Offset: 0x0018C1DC
		public virtual long GetSourceDimension()
		{
			return vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_GetSourceDimension_05(base.GetCppThis());
		}

		// Token: 0x06011C83 RID: 72835
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAdjacencyMatrixToEdgeTable_GetValueArrayName_06(HandleRef pThis);

		/// <summary>
		/// Controls the name of the output table column that contains edge weights.
		/// Default: "value"
		/// </summary>
		// Token: 0x06011C84 RID: 72836 RVA: 0x0018DFFC File Offset: 0x0018C1FC
		public virtual string GetValueArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_GetValueArrayName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06011C85 RID: 72837
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAdjacencyMatrixToEdgeTable_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C86 RID: 72838 RVA: 0x0018E038 File Offset: 0x0018C238
		public override int IsA(string type)
		{
			return vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06011C87 RID: 72839
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAdjacencyMatrixToEdgeTable_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C88 RID: 72840 RVA: 0x0018E058 File Offset: 0x0018C258
		public new static int IsTypeOf(string type)
		{
			return vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_IsTypeOf_08(type);
		}

		// Token: 0x06011C89 RID: 72841
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAdjacencyMatrixToEdgeTable_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C8A RID: 72842 RVA: 0x0018E074 File Offset: 0x0018C274
		public new vtkAdjacencyMatrixToEdgeTable NewInstance()
		{
			vtkAdjacencyMatrixToEdgeTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAdjacencyMatrixToEdgeTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011C8B RID: 72843
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAdjacencyMatrixToEdgeTable_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C8C RID: 72844 RVA: 0x0018E0D0 File Offset: 0x0018C2D0
		public new static vtkAdjacencyMatrixToEdgeTable SafeDownCast(vtkObjectBase o)
		{
			vtkAdjacencyMatrixToEdgeTable vtkAdjacencyMatrixToEdgeTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAdjacencyMatrixToEdgeTable = (vtkAdjacencyMatrixToEdgeTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAdjacencyMatrixToEdgeTable.Register(null);
				}
			}
			return vtkAdjacencyMatrixToEdgeTable;
		}

		// Token: 0x06011C8D RID: 72845
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAdjacencyMatrixToEdgeTable_SetMinimumCount_12(HandleRef pThis, long _arg);

		/// <summary>
		/// Specifies the minimum number of adjacent edges to include for each source vertex.
		/// Default: 0
		/// </summary>
		// Token: 0x06011C8E RID: 72846 RVA: 0x0018E14F File Offset: 0x0018C34F
		public virtual void SetMinimumCount(long _arg)
		{
			vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_SetMinimumCount_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06011C8F RID: 72847
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAdjacencyMatrixToEdgeTable_SetMinimumThreshold_13(HandleRef pThis, double _arg);

		/// <summary>
		/// Specifies a minimum threshold that an edge weight must exceed to be included in
		/// the output.
		/// Default: 0.5
		/// </summary>
		// Token: 0x06011C90 RID: 72848 RVA: 0x0018E15F File Offset: 0x0018C35F
		public virtual void SetMinimumThreshold(double _arg)
		{
			vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_SetMinimumThreshold_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06011C91 RID: 72849
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAdjacencyMatrixToEdgeTable_SetSourceDimension_14(HandleRef pThis, long _arg);

		/// <summary>
		/// Specifies whether rows or columns become the "source" in the output edge table.
		/// 0 = rows, 1 = columns.  Default: 0
		/// </summary>
		// Token: 0x06011C92 RID: 72850 RVA: 0x0018E16F File Offset: 0x0018C36F
		public virtual void SetSourceDimension(long _arg)
		{
			vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_SetSourceDimension_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06011C93 RID: 72851
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAdjacencyMatrixToEdgeTable_SetValueArrayName_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Controls the name of the output table column that contains edge weights.
		/// Default: "value"
		/// </summary>
		// Token: 0x06011C94 RID: 72852 RVA: 0x0018E17F File Offset: 0x0018C37F
		public virtual void SetValueArrayName(string _arg)
		{
			vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_SetValueArrayName_15(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001481 RID: 5249
		public new const string MRFullTypeName = "Kitware.VTK.vtkAdjacencyMatrixToEdgeTable";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001482 RID: 5250
		public new static readonly string MRClassNameKey = "class vtkAdjacencyMatrixToEdgeTable";
	}
}
