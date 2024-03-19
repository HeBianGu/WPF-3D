using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkArrayToTable
	/// </summary>
	/// <remarks>
	///    Converts one- and two-dimensional vtkArrayData
	/// objects to vtkTable
	///
	/// @par Thanks:
	/// </remarks>
	/// <seealso>
	/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
	/// </seealso>
	// Token: 0x02000673 RID: 1651
	public class vtkArrayToTable : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011CCD RID: 72909 RVA: 0x0018E7BF File Offset: 0x0018C9BF
		static vtkArrayToTable()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArrayToTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrayToTable"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011CCE RID: 72910 RVA: 0x0018E7E7 File Offset: 0x0018C9E7
		public vtkArrayToTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011CCF RID: 72911
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayToTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CD0 RID: 72912 RVA: 0x0018E7F8 File Offset: 0x0018C9F8
		public new static vtkArrayToTable New()
		{
			vtkArrayToTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayToTable.vtkArrayToTable_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayToTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CD1 RID: 72913 RVA: 0x0018E84C File Offset: 0x0018CA4C
		public vtkArrayToTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkArrayToTable.vtkArrayToTable_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011CD2 RID: 72914 RVA: 0x0018E890 File Offset: 0x0018CA90
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011CD3 RID: 72915
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayToTable_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CD4 RID: 72916 RVA: 0x0018E89C File Offset: 0x0018CA9C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkArrayToTable.vtkArrayToTable_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06011CD5 RID: 72917
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayToTable_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CD6 RID: 72918 RVA: 0x0018E8BC File Offset: 0x0018CABC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkArrayToTable.vtkArrayToTable_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06011CD7 RID: 72919
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayToTable_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CD8 RID: 72920 RVA: 0x0018E8D8 File Offset: 0x0018CAD8
		public override int IsA(string type)
		{
			return vtkArrayToTable.vtkArrayToTable_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06011CD9 RID: 72921
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayToTable_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CDA RID: 72922 RVA: 0x0018E8F8 File Offset: 0x0018CAF8
		public new static int IsTypeOf(string type)
		{
			return vtkArrayToTable.vtkArrayToTable_IsTypeOf_04(type);
		}

		// Token: 0x06011CDB RID: 72923
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayToTable_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CDC RID: 72924 RVA: 0x0018E914 File Offset: 0x0018CB14
		public new vtkArrayToTable NewInstance()
		{
			vtkArrayToTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayToTable.vtkArrayToTable_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayToTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011CDD RID: 72925
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayToTable_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CDE RID: 72926 RVA: 0x0018E970 File Offset: 0x0018CB70
		public new static vtkArrayToTable SafeDownCast(vtkObjectBase o)
		{
			vtkArrayToTable vtkArrayToTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayToTable.vtkArrayToTable_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayToTable = (vtkArrayToTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayToTable.Register(null);
				}
			}
			return vtkArrayToTable;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001487 RID: 5255
		public new const string MRFullTypeName = "Kitware.VTK.vtkArrayToTable";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001488 RID: 5256
		public new static readonly string MRClassNameKey = "class vtkArrayToTable";
	}
}
