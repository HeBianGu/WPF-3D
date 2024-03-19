using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBlankStructuredGrid
	/// </summary>
	/// <remarks>
	///    translate point attribute data into a blanking field
	///
	///
	/// vtkBlankStructuredGrid is a filter that sets the blanking field in a
	/// vtkStructuredGrid dataset. The blanking field is set by examining a
	/// specified point attribute data array (e.g., scalars) and converting
	/// values in the data array to either a "1" (visible) or "0" (blanked) value
	/// in the blanking array. The values to be blanked are specified by giving
	/// a min/max range. All data values in the data array indicated and laying
	/// within the range specified (inclusive on both ends) are translated to
	/// a "off" blanking value.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkStructuredGrid
	/// </seealso>
	// Token: 0x02000874 RID: 2164
	public class vtkBlankStructuredGrid : vtkStructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016762 RID: 92002 RVA: 0x001F951B File Offset: 0x001F771B
		static vtkBlankStructuredGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBlankStructuredGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBlankStructuredGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016763 RID: 92003 RVA: 0x001F9543 File Offset: 0x001F7743
		public vtkBlankStructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016764 RID: 92004
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlankStructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016765 RID: 92005 RVA: 0x001F9554 File Offset: 0x001F7754
		public new static vtkBlankStructuredGrid New()
		{
			vtkBlankStructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBlankStructuredGrid.vtkBlankStructuredGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBlankStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016766 RID: 92006 RVA: 0x001F95A8 File Offset: 0x001F77A8
		public vtkBlankStructuredGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBlankStructuredGrid.vtkBlankStructuredGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016767 RID: 92007 RVA: 0x001F95EC File Offset: 0x001F77EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016768 RID: 92008
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBlankStructuredGrid_GetArrayId_01(HandleRef pThis);

		/// <summary>
		/// Specify the data array id to use to generate the blanking
		/// field. Alternatively, you can specify the array name. (If both are set,
		/// the array name takes precedence.)
		/// </summary>
		// Token: 0x06016769 RID: 92009 RVA: 0x001F95F8 File Offset: 0x001F77F8
		public virtual int GetArrayId()
		{
			return vtkBlankStructuredGrid.vtkBlankStructuredGrid_GetArrayId_01(base.GetCppThis());
		}

		// Token: 0x0601676A RID: 92010
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlankStructuredGrid_GetArrayName_02(HandleRef pThis);

		/// <summary>
		/// Specify the data array name to use to generate the blanking
		/// field. Alternatively, you can specify the array id. (If both are set,
		/// the array name takes precedence.)
		/// </summary>
		// Token: 0x0601676B RID: 92011 RVA: 0x001F9618 File Offset: 0x001F7818
		public virtual string GetArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkBlankStructuredGrid.vtkBlankStructuredGrid_GetArrayName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601676C RID: 92012
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBlankStructuredGrid_GetComponent_03(HandleRef pThis);

		/// <summary>
		/// Specify the component in the data array to use to generate the blanking
		/// field.
		/// </summary>
		// Token: 0x0601676D RID: 92013 RVA: 0x001F9654 File Offset: 0x001F7854
		public virtual int GetComponent()
		{
			return vtkBlankStructuredGrid.vtkBlankStructuredGrid_GetComponent_03(base.GetCppThis());
		}

		// Token: 0x0601676E RID: 92014
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBlankStructuredGrid_GetComponentMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Specify the component in the data array to use to generate the blanking
		/// field.
		/// </summary>
		// Token: 0x0601676F RID: 92015 RVA: 0x001F9674 File Offset: 0x001F7874
		public virtual int GetComponentMaxValue()
		{
			return vtkBlankStructuredGrid.vtkBlankStructuredGrid_GetComponentMaxValue_04(base.GetCppThis());
		}

		// Token: 0x06016770 RID: 92016
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBlankStructuredGrid_GetComponentMinValue_05(HandleRef pThis);

		/// <summary>
		/// Specify the component in the data array to use to generate the blanking
		/// field.
		/// </summary>
		// Token: 0x06016771 RID: 92017 RVA: 0x001F9694 File Offset: 0x001F7894
		public virtual int GetComponentMinValue()
		{
			return vtkBlankStructuredGrid.vtkBlankStructuredGrid_GetComponentMinValue_05(base.GetCppThis());
		}

		// Token: 0x06016772 RID: 92018
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBlankStructuredGrid_GetMaxBlankingValue_06(HandleRef pThis);

		/// <summary>
		/// Specify the upper data value in the data array specified which will be
		/// converted into a "blank" (or off) value in the blanking array.
		/// </summary>
		// Token: 0x06016773 RID: 92019 RVA: 0x001F96B4 File Offset: 0x001F78B4
		public virtual double GetMaxBlankingValue()
		{
			return vtkBlankStructuredGrid.vtkBlankStructuredGrid_GetMaxBlankingValue_06(base.GetCppThis());
		}

		// Token: 0x06016774 RID: 92020
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBlankStructuredGrid_GetMinBlankingValue_07(HandleRef pThis);

		/// <summary>
		/// Specify the lower data value in the data array specified which will be
		/// converted into a "blank" (or off) value in the blanking array.
		/// </summary>
		// Token: 0x06016775 RID: 92021 RVA: 0x001F96D4 File Offset: 0x001F78D4
		public virtual double GetMinBlankingValue()
		{
			return vtkBlankStructuredGrid.vtkBlankStructuredGrid_GetMinBlankingValue_07(base.GetCppThis());
		}

		// Token: 0x06016776 RID: 92022
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBlankStructuredGrid_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016777 RID: 92023 RVA: 0x001F96F4 File Offset: 0x001F78F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBlankStructuredGrid.vtkBlankStructuredGrid_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06016778 RID: 92024
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBlankStructuredGrid_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016779 RID: 92025 RVA: 0x001F9714 File Offset: 0x001F7914
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBlankStructuredGrid.vtkBlankStructuredGrid_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0601677A RID: 92026
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBlankStructuredGrid_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601677B RID: 92027 RVA: 0x001F9730 File Offset: 0x001F7930
		public override int IsA(string type)
		{
			return vtkBlankStructuredGrid.vtkBlankStructuredGrid_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0601677C RID: 92028
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBlankStructuredGrid_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601677D RID: 92029 RVA: 0x001F9750 File Offset: 0x001F7950
		public new static int IsTypeOf(string type)
		{
			return vtkBlankStructuredGrid.vtkBlankStructuredGrid_IsTypeOf_11(type);
		}

		// Token: 0x0601677E RID: 92030
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlankStructuredGrid_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601677F RID: 92031 RVA: 0x001F976C File Offset: 0x001F796C
		public new vtkBlankStructuredGrid NewInstance()
		{
			vtkBlankStructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBlankStructuredGrid.vtkBlankStructuredGrid_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBlankStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016780 RID: 92032
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlankStructuredGrid_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016781 RID: 92033 RVA: 0x001F97C8 File Offset: 0x001F79C8
		public new static vtkBlankStructuredGrid SafeDownCast(vtkObjectBase o)
		{
			vtkBlankStructuredGrid vtkBlankStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBlankStructuredGrid.vtkBlankStructuredGrid_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBlankStructuredGrid = (vtkBlankStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBlankStructuredGrid.Register(null);
				}
			}
			return vtkBlankStructuredGrid;
		}

		// Token: 0x06016782 RID: 92034
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlankStructuredGrid_SetArrayId_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the data array id to use to generate the blanking
		/// field. Alternatively, you can specify the array name. (If both are set,
		/// the array name takes precedence.)
		/// </summary>
		// Token: 0x06016783 RID: 92035 RVA: 0x001F9847 File Offset: 0x001F7A47
		public virtual void SetArrayId(int _arg)
		{
			vtkBlankStructuredGrid.vtkBlankStructuredGrid_SetArrayId_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06016784 RID: 92036
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlankStructuredGrid_SetArrayName_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the data array name to use to generate the blanking
		/// field. Alternatively, you can specify the array id. (If both are set,
		/// the array name takes precedence.)
		/// </summary>
		// Token: 0x06016785 RID: 92037 RVA: 0x001F9857 File Offset: 0x001F7A57
		public virtual void SetArrayName(string _arg)
		{
			vtkBlankStructuredGrid.vtkBlankStructuredGrid_SetArrayName_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06016786 RID: 92038
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlankStructuredGrid_SetComponent_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the component in the data array to use to generate the blanking
		/// field.
		/// </summary>
		// Token: 0x06016787 RID: 92039 RVA: 0x001F9867 File Offset: 0x001F7A67
		public virtual void SetComponent(int _arg)
		{
			vtkBlankStructuredGrid.vtkBlankStructuredGrid_SetComponent_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06016788 RID: 92040
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlankStructuredGrid_SetMaxBlankingValue_18(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the upper data value in the data array specified which will be
		/// converted into a "blank" (or off) value in the blanking array.
		/// </summary>
		// Token: 0x06016789 RID: 92041 RVA: 0x001F9877 File Offset: 0x001F7A77
		public virtual void SetMaxBlankingValue(double _arg)
		{
			vtkBlankStructuredGrid.vtkBlankStructuredGrid_SetMaxBlankingValue_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0601678A RID: 92042
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlankStructuredGrid_SetMinBlankingValue_19(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the lower data value in the data array specified which will be
		/// converted into a "blank" (or off) value in the blanking array.
		/// </summary>
		// Token: 0x0601678B RID: 92043 RVA: 0x001F9887 File Offset: 0x001F7A87
		public virtual void SetMinBlankingValue(double _arg)
		{
			vtkBlankStructuredGrid.vtkBlankStructuredGrid_SetMinBlankingValue_19(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400193E RID: 6462
		public new const string MRFullTypeName = "Kitware.VTK.vtkBlankStructuredGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400193F RID: 6463
		public new static readonly string MRClassNameKey = "class vtkBlankStructuredGrid";
	}
}
