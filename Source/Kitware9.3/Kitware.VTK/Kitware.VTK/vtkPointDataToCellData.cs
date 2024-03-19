using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointDataToCellData
	/// </summary>
	/// <remarks>
	///    map point data to cell data
	///
	/// vtkPointDataToCellData is a filter that transforms point data (i.e., data
	/// specified per point) into cell data (i.e., data specified per cell).  By
	/// default, the method of transformation is based on averaging the data
	/// values of all the points defining a particular cell. Optionally (by enabling
	/// CategoricalData), histograming can be used to assign the cell data. For
	/// large datasets with several cell data arrays, the filter optionally
	/// supports selective processing to speed up processing. Optionally, the
	/// input point data can be passed through to the output as well.
	///
	/// @warning
	/// This filter is an abstract filter, that is, the output is an abstract type
	/// (i.e., vtkDataSet). Use the convenience methods (e.g.,
	/// GetPolyDataOutput(), GetStructuredPointsOutput(), etc.) to get the type
	/// of output you want.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointData vtkCellData vtkCellDataToPointData
	/// </seealso>
	// Token: 0x02000987 RID: 2439
	public class vtkPointDataToCellData : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019645 RID: 104005 RVA: 0x0023602B File Offset: 0x0023422B
		static vtkPointDataToCellData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointDataToCellData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointDataToCellData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019646 RID: 104006 RVA: 0x00236053 File Offset: 0x00234253
		public vtkPointDataToCellData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019647 RID: 104007
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointDataToCellData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06019648 RID: 104008 RVA: 0x00236064 File Offset: 0x00234264
		public new static vtkPointDataToCellData New()
		{
			vtkPointDataToCellData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointDataToCellData.vtkPointDataToCellData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointDataToCellData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06019649 RID: 104009 RVA: 0x002360B8 File Offset: 0x002342B8
		public vtkPointDataToCellData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointDataToCellData.vtkPointDataToCellData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601964A RID: 104010 RVA: 0x002360FC File Offset: 0x002342FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601964B RID: 104011
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDataToCellData_AddPointDataArray_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Adds an array to be processed. This only has an effect if the
		/// ProcessAllArrays option is turned off. If a name is already present,
		/// nothing happens.
		/// </summary>
		// Token: 0x0601964C RID: 104012 RVA: 0x00236107 File Offset: 0x00234307
		public virtual void AddPointDataArray(string name)
		{
			vtkPointDataToCellData.vtkPointDataToCellData_AddPointDataArray_01(base.GetCppThis(), name);
		}

		// Token: 0x0601964D RID: 104013
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDataToCellData_CategoricalDataOff_02(HandleRef pThis);

		/// <summary>
		/// Control whether the input point data is to be treated as categorical. If
		/// the data is categorical, then the resultant cell data will be determined
		/// by a "majority rules" vote (using a histogram of the point data scalar
		/// values), with ties going to the smaller point data value.
		/// </summary>
		// Token: 0x0601964E RID: 104014 RVA: 0x00236117 File Offset: 0x00234317
		public virtual void CategoricalDataOff()
		{
			vtkPointDataToCellData.vtkPointDataToCellData_CategoricalDataOff_02(base.GetCppThis());
		}

		// Token: 0x0601964F RID: 104015
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDataToCellData_CategoricalDataOn_03(HandleRef pThis);

		/// <summary>
		/// Control whether the input point data is to be treated as categorical. If
		/// the data is categorical, then the resultant cell data will be determined
		/// by a "majority rules" vote (using a histogram of the point data scalar
		/// values), with ties going to the smaller point data value.
		/// </summary>
		// Token: 0x06019650 RID: 104016 RVA: 0x00236126 File Offset: 0x00234326
		public virtual void CategoricalDataOn()
		{
			vtkPointDataToCellData.vtkPointDataToCellData_CategoricalDataOn_03(base.GetCppThis());
		}

		// Token: 0x06019651 RID: 104017
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDataToCellData_ClearPointDataArrays_04(HandleRef pThis);

		/// <summary>
		/// Removes all arrays to be processed from the list. This only has an effect
		/// if the ProcessAllArrays option is turned off.
		/// </summary>
		// Token: 0x06019652 RID: 104018 RVA: 0x00236135 File Offset: 0x00234335
		public virtual void ClearPointDataArrays()
		{
			vtkPointDataToCellData.vtkPointDataToCellData_ClearPointDataArrays_04(base.GetCppThis());
		}

		// Token: 0x06019653 RID: 104019
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointDataToCellData_GetCategoricalData_05(HandleRef pThis);

		/// <summary>
		/// Control whether the input point data is to be treated as categorical. If
		/// the data is categorical, then the resultant cell data will be determined
		/// by a "majority rules" vote (using a histogram of the point data scalar
		/// values), with ties going to the smaller point data value.
		/// </summary>
		// Token: 0x06019654 RID: 104020 RVA: 0x00236144 File Offset: 0x00234344
		public virtual bool GetCategoricalData()
		{
			return vtkPointDataToCellData.vtkPointDataToCellData_GetCategoricalData_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06019655 RID: 104021
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointDataToCellData_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06019656 RID: 104022 RVA: 0x0023616C File Offset: 0x0023436C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointDataToCellData.vtkPointDataToCellData_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06019657 RID: 104023
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointDataToCellData_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06019658 RID: 104024 RVA: 0x0023618C File Offset: 0x0023438C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointDataToCellData.vtkPointDataToCellData_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06019659 RID: 104025
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointDataToCellData_GetPassPointData_08(HandleRef pThis);

		/// <summary>
		/// Control whether the input point data is to be passed to the output. If
		/// on, then the input point data is passed through to the output; otherwise,
		/// only generated cell data is placed into the output.
		/// </summary>
		// Token: 0x0601965A RID: 104026 RVA: 0x002361A8 File Offset: 0x002343A8
		public virtual bool GetPassPointData()
		{
			return vtkPointDataToCellData.vtkPointDataToCellData_GetPassPointData_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0601965B RID: 104027
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointDataToCellData_GetProcessAllArrays_09(HandleRef pThis);

		/// <summary>
		/// Activate selective processing of arrays. If inactive, only arrays selected
		/// by the user will be considered by this filter. The default is true.
		/// </summary>
		// Token: 0x0601965C RID: 104028 RVA: 0x002361D0 File Offset: 0x002343D0
		public virtual bool GetProcessAllArrays()
		{
			return vtkPointDataToCellData.vtkPointDataToCellData_GetProcessAllArrays_09(base.GetCppThis()) != 0;
		}

		// Token: 0x0601965D RID: 104029
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointDataToCellData_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601965E RID: 104030 RVA: 0x002361F8 File Offset: 0x002343F8
		public override int IsA(string type)
		{
			return vtkPointDataToCellData.vtkPointDataToCellData_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0601965F RID: 104031
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointDataToCellData_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06019660 RID: 104032 RVA: 0x00236218 File Offset: 0x00234418
		public new static int IsTypeOf(string type)
		{
			return vtkPointDataToCellData.vtkPointDataToCellData_IsTypeOf_11(type);
		}

		// Token: 0x06019661 RID: 104033
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointDataToCellData_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06019662 RID: 104034 RVA: 0x00236234 File Offset: 0x00234434
		public new vtkPointDataToCellData NewInstance()
		{
			vtkPointDataToCellData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointDataToCellData.vtkPointDataToCellData_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointDataToCellData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019663 RID: 104035
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDataToCellData_PassPointDataOff_14(HandleRef pThis);

		/// <summary>
		/// Control whether the input point data is to be passed to the output. If
		/// on, then the input point data is passed through to the output; otherwise,
		/// only generated cell data is placed into the output.
		/// </summary>
		// Token: 0x06019664 RID: 104036 RVA: 0x0023628E File Offset: 0x0023448E
		public virtual void PassPointDataOff()
		{
			vtkPointDataToCellData.vtkPointDataToCellData_PassPointDataOff_14(base.GetCppThis());
		}

		// Token: 0x06019665 RID: 104037
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDataToCellData_PassPointDataOn_15(HandleRef pThis);

		/// <summary>
		/// Control whether the input point data is to be passed to the output. If
		/// on, then the input point data is passed through to the output; otherwise,
		/// only generated cell data is placed into the output.
		/// </summary>
		// Token: 0x06019666 RID: 104038 RVA: 0x0023629D File Offset: 0x0023449D
		public virtual void PassPointDataOn()
		{
			vtkPointDataToCellData.vtkPointDataToCellData_PassPointDataOn_15(base.GetCppThis());
		}

		// Token: 0x06019667 RID: 104039
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDataToCellData_ProcessAllArraysOff_16(HandleRef pThis);

		/// <summary>
		/// Activate selective processing of arrays. If inactive, only arrays selected
		/// by the user will be considered by this filter. The default is true.
		/// </summary>
		// Token: 0x06019668 RID: 104040 RVA: 0x002362AC File Offset: 0x002344AC
		public virtual void ProcessAllArraysOff()
		{
			vtkPointDataToCellData.vtkPointDataToCellData_ProcessAllArraysOff_16(base.GetCppThis());
		}

		// Token: 0x06019669 RID: 104041
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDataToCellData_ProcessAllArraysOn_17(HandleRef pThis);

		/// <summary>
		/// Activate selective processing of arrays. If inactive, only arrays selected
		/// by the user will be considered by this filter. The default is true.
		/// </summary>
		// Token: 0x0601966A RID: 104042 RVA: 0x002362BB File Offset: 0x002344BB
		public virtual void ProcessAllArraysOn()
		{
			vtkPointDataToCellData.vtkPointDataToCellData_ProcessAllArraysOn_17(base.GetCppThis());
		}

		// Token: 0x0601966B RID: 104043
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDataToCellData_RemovePointDataArray_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Removes an array to be processed. This only has an effect if the
		/// ProcessAllArrays option is turned off. If the specified name is not
		/// present, nothing happens.
		/// </summary>
		// Token: 0x0601966C RID: 104044 RVA: 0x002362CA File Offset: 0x002344CA
		public virtual void RemovePointDataArray(string name)
		{
			vtkPointDataToCellData.vtkPointDataToCellData_RemovePointDataArray_18(base.GetCppThis(), name);
		}

		// Token: 0x0601966D RID: 104045
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointDataToCellData_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601966E RID: 104046 RVA: 0x002362DC File Offset: 0x002344DC
		public new static vtkPointDataToCellData SafeDownCast(vtkObjectBase o)
		{
			vtkPointDataToCellData vtkPointDataToCellData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointDataToCellData.vtkPointDataToCellData_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointDataToCellData = (vtkPointDataToCellData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointDataToCellData.Register(null);
				}
			}
			return vtkPointDataToCellData;
		}

		// Token: 0x0601966F RID: 104047
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDataToCellData_SetCategoricalData_20(HandleRef pThis, byte _arg);

		/// <summary>
		/// Control whether the input point data is to be treated as categorical. If
		/// the data is categorical, then the resultant cell data will be determined
		/// by a "majority rules" vote (using a histogram of the point data scalar
		/// values), with ties going to the smaller point data value.
		/// </summary>
		// Token: 0x06019670 RID: 104048 RVA: 0x0023635B File Offset: 0x0023455B
		public virtual void SetCategoricalData(bool _arg)
		{
			vtkPointDataToCellData.vtkPointDataToCellData_SetCategoricalData_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019671 RID: 104049
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDataToCellData_SetPassPointData_21(HandleRef pThis, byte _arg);

		/// <summary>
		/// Control whether the input point data is to be passed to the output. If
		/// on, then the input point data is passed through to the output; otherwise,
		/// only generated cell data is placed into the output.
		/// </summary>
		// Token: 0x06019672 RID: 104050 RVA: 0x00236373 File Offset: 0x00234573
		public virtual void SetPassPointData(bool _arg)
		{
			vtkPointDataToCellData.vtkPointDataToCellData_SetPassPointData_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019673 RID: 104051
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDataToCellData_SetProcessAllArrays_22(HandleRef pThis, byte _arg);

		/// <summary>
		/// Activate selective processing of arrays. If inactive, only arrays selected
		/// by the user will be considered by this filter. The default is true.
		/// </summary>
		// Token: 0x06019674 RID: 104052 RVA: 0x0023638B File Offset: 0x0023458B
		public virtual void SetProcessAllArrays(bool _arg)
		{
			vtkPointDataToCellData.vtkPointDataToCellData_SetProcessAllArrays_22(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BCD RID: 7117
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointDataToCellData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BCE RID: 7118
		public new static readonly string MRClassNameKey = "class vtkPointDataToCellData";
	}
}
