using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkThresholdTable
	/// </summary>
	/// <remarks>
	///    Thresholds table rows.
	///
	///
	/// vtkThresholdTable uses minimum and/or maximum values to threshold
	/// table rows based on the values in a particular column.
	/// The column to threshold is specified using SetInputArrayToProcess(0, ...).
	/// </remarks>
	// Token: 0x02000699 RID: 1689
	public class vtkThresholdTable : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012173 RID: 74099 RVA: 0x00195443 File Offset: 0x00193643
		static vtkThresholdTable()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkThresholdTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkThresholdTable"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012174 RID: 74100 RVA: 0x0019546B File Offset: 0x0019366B
		public vtkThresholdTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012175 RID: 74101
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThresholdTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012176 RID: 74102 RVA: 0x0019547C File Offset: 0x0019367C
		public new static vtkThresholdTable New()
		{
			vtkThresholdTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThresholdTable.vtkThresholdTable_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThresholdTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012177 RID: 74103 RVA: 0x001954D0 File Offset: 0x001936D0
		public vtkThresholdTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkThresholdTable.vtkThresholdTable_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012178 RID: 74104 RVA: 0x00195514 File Offset: 0x00193714
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012179 RID: 74105
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThresholdTable_GetMaxValue_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The maximum value for the threshold.
		/// This may be any data type stored in a vtkVariant.
		/// </summary>
		// Token: 0x0601217A RID: 74106 RVA: 0x00195520 File Offset: 0x00193720
		public virtual vtkVariant GetMaxValue()
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThresholdTable.vtkThresholdTable_GetMaxValue_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601217B RID: 74107
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThresholdTable_GetMinValue_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The minimum value for the threshold.
		/// This may be any data type stored in a vtkVariant.
		/// </summary>
		// Token: 0x0601217C RID: 74108 RVA: 0x0019557C File Offset: 0x0019377C
		public virtual vtkVariant GetMinValue()
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThresholdTable.vtkThresholdTable_GetMinValue_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601217D RID: 74109
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThresholdTable_GetMode_03(HandleRef pThis);

		/// <summary>
		/// The mode of the threshold filter.  Options are:
		/// ACCEPT_LESS_THAN (0) accepts rows with values &lt; MaxValue;
		/// ACCEPT_GREATER_THAN (1) accepts rows with values &gt; MinValue;
		/// ACCEPT_BETWEEN (2) accepts rows with values &gt; MinValue and &lt; MaxValue;
		/// ACCEPT_OUTSIDE (3) accepts rows with values &lt; MinValue or &gt; MaxValue.
		/// </summary>
		// Token: 0x0601217E RID: 74110 RVA: 0x001955D8 File Offset: 0x001937D8
		public virtual int GetMode()
		{
			return vtkThresholdTable.vtkThresholdTable_GetMode_03(base.GetCppThis());
		}

		// Token: 0x0601217F RID: 74111
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThresholdTable_GetModeMaxValue_04(HandleRef pThis);

		/// <summary>
		/// The mode of the threshold filter.  Options are:
		/// ACCEPT_LESS_THAN (0) accepts rows with values &lt; MaxValue;
		/// ACCEPT_GREATER_THAN (1) accepts rows with values &gt; MinValue;
		/// ACCEPT_BETWEEN (2) accepts rows with values &gt; MinValue and &lt; MaxValue;
		/// ACCEPT_OUTSIDE (3) accepts rows with values &lt; MinValue or &gt; MaxValue.
		/// </summary>
		// Token: 0x06012180 RID: 74112 RVA: 0x001955F8 File Offset: 0x001937F8
		public virtual int GetModeMaxValue()
		{
			return vtkThresholdTable.vtkThresholdTable_GetModeMaxValue_04(base.GetCppThis());
		}

		// Token: 0x06012181 RID: 74113
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThresholdTable_GetModeMinValue_05(HandleRef pThis);

		/// <summary>
		/// The mode of the threshold filter.  Options are:
		/// ACCEPT_LESS_THAN (0) accepts rows with values &lt; MaxValue;
		/// ACCEPT_GREATER_THAN (1) accepts rows with values &gt; MinValue;
		/// ACCEPT_BETWEEN (2) accepts rows with values &gt; MinValue and &lt; MaxValue;
		/// ACCEPT_OUTSIDE (3) accepts rows with values &lt; MinValue or &gt; MaxValue.
		/// </summary>
		// Token: 0x06012182 RID: 74114 RVA: 0x00195618 File Offset: 0x00193818
		public virtual int GetModeMinValue()
		{
			return vtkThresholdTable.vtkThresholdTable_GetModeMinValue_05(base.GetCppThis());
		}

		// Token: 0x06012183 RID: 74115
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkThresholdTable_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012184 RID: 74116 RVA: 0x00195638 File Offset: 0x00193838
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkThresholdTable.vtkThresholdTable_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06012185 RID: 74117
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkThresholdTable_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012186 RID: 74118 RVA: 0x00195658 File Offset: 0x00193858
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkThresholdTable.vtkThresholdTable_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06012187 RID: 74119
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThresholdTable_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012188 RID: 74120 RVA: 0x00195674 File Offset: 0x00193874
		public override int IsA(string type)
		{
			return vtkThresholdTable.vtkThresholdTable_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06012189 RID: 74121
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThresholdTable_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601218A RID: 74122 RVA: 0x00195694 File Offset: 0x00193894
		public new static int IsTypeOf(string type)
		{
			return vtkThresholdTable.vtkThresholdTable_IsTypeOf_09(type);
		}

		// Token: 0x0601218B RID: 74123
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkThresholdTable_IsValueAcceptable_10(HandleRef pThis, HandleRef value);

		/// <summary>
		/// Return true if value, converted to double, matches the criteria of the current Mode.
		/// </summary>
		// Token: 0x0601218C RID: 74124 RVA: 0x001956B0 File Offset: 0x001938B0
		public bool IsValueAcceptable(vtkVariant value)
		{
			return vtkThresholdTable.vtkThresholdTable_IsValueAcceptable_10(base.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis()) != 0;
		}

		// Token: 0x0601218D RID: 74125
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThresholdTable_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601218E RID: 74126 RVA: 0x001956EC File Offset: 0x001938EC
		public new vtkThresholdTable NewInstance()
		{
			vtkThresholdTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThresholdTable.vtkThresholdTable_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThresholdTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601218F RID: 74127
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThresholdTable_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012190 RID: 74128 RVA: 0x00195748 File Offset: 0x00193948
		public new static vtkThresholdTable SafeDownCast(vtkObjectBase o)
		{
			vtkThresholdTable vtkThresholdTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThresholdTable.vtkThresholdTable_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkThresholdTable = (vtkThresholdTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkThresholdTable.Register(null);
				}
			}
			return vtkThresholdTable;
		}

		// Token: 0x06012191 RID: 74129
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdTable_SetMaxValue_14(HandleRef pThis, HandleRef v);

		/// <summary>
		/// The maximum value for the threshold.
		/// This may be any data type stored in a vtkVariant.
		/// </summary>
		// Token: 0x06012192 RID: 74130 RVA: 0x001957C8 File Offset: 0x001939C8
		public virtual void SetMaxValue(vtkVariant v)
		{
			vtkThresholdTable.vtkThresholdTable_SetMaxValue_14(base.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		// Token: 0x06012193 RID: 74131
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdTable_SetMaxValue_15(HandleRef pThis, double v);

		/// <summary>
		/// The maximum value for the threshold as a double.
		/// </summary>
		// Token: 0x06012194 RID: 74132 RVA: 0x001957F7 File Offset: 0x001939F7
		public void SetMaxValue(double v)
		{
			vtkThresholdTable.vtkThresholdTable_SetMaxValue_15(base.GetCppThis(), v);
		}

		// Token: 0x06012195 RID: 74133
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdTable_SetMinValue_16(HandleRef pThis, HandleRef v);

		/// <summary>
		/// The minimum value for the threshold.
		/// This may be any data type stored in a vtkVariant.
		/// </summary>
		// Token: 0x06012196 RID: 74134 RVA: 0x00195808 File Offset: 0x00193A08
		public virtual void SetMinValue(vtkVariant v)
		{
			vtkThresholdTable.vtkThresholdTable_SetMinValue_16(base.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		// Token: 0x06012197 RID: 74135
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdTable_SetMinValue_17(HandleRef pThis, double v);

		/// <summary>
		/// The minimum value for the threshold as a double.
		/// </summary>
		// Token: 0x06012198 RID: 74136 RVA: 0x00195837 File Offset: 0x00193A37
		public void SetMinValue(double v)
		{
			vtkThresholdTable.vtkThresholdTable_SetMinValue_17(base.GetCppThis(), v);
		}

		// Token: 0x06012199 RID: 74137
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdTable_SetMode_18(HandleRef pThis, int _arg);

		/// <summary>
		/// The mode of the threshold filter.  Options are:
		/// ACCEPT_LESS_THAN (0) accepts rows with values &lt; MaxValue;
		/// ACCEPT_GREATER_THAN (1) accepts rows with values &gt; MinValue;
		/// ACCEPT_BETWEEN (2) accepts rows with values &gt; MinValue and &lt; MaxValue;
		/// ACCEPT_OUTSIDE (3) accepts rows with values &lt; MinValue or &gt; MaxValue.
		/// </summary>
		// Token: 0x0601219A RID: 74138 RVA: 0x00195847 File Offset: 0x00193A47
		public virtual void SetMode(int _arg)
		{
			vtkThresholdTable.vtkThresholdTable_SetMode_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0601219B RID: 74139
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdTable_ThresholdBetween_19(HandleRef pThis, HandleRef lower, HandleRef upper);

		/// <summary>
		/// Criterion is rows whose scalars are between lower and upper thresholds
		/// (inclusive of the end values).
		/// </summary>
		// Token: 0x0601219C RID: 74140 RVA: 0x00195858 File Offset: 0x00193A58
		public void ThresholdBetween(vtkVariant lower, vtkVariant upper)
		{
			vtkThresholdTable.vtkThresholdTable_ThresholdBetween_19(base.GetCppThis(), (lower == null) ? default(HandleRef) : lower.GetCppThis(), (upper == null) ? default(HandleRef) : upper.GetCppThis());
		}

		// Token: 0x0601219D RID: 74141
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdTable_ThresholdBetween_20(HandleRef pThis, double lower, double upper);

		/// <summary>
		/// Criterion is rows whose scalars are between lower and upper thresholds
		/// (inclusive of the end values).
		/// </summary>
		// Token: 0x0601219E RID: 74142 RVA: 0x0019589C File Offset: 0x00193A9C
		public void ThresholdBetween(double lower, double upper)
		{
			vtkThresholdTable.vtkThresholdTable_ThresholdBetween_20(base.GetCppThis(), lower, upper);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014DD RID: 5341
		public new const string MRFullTypeName = "Kitware.VTK.vtkThresholdTable";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014DE RID: 5342
		public new static readonly string MRClassNameKey = "class vtkThresholdTable";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200069A RID: 1690
		public enum ACCEPT_BETWEEN_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040014E0 RID: 5344
			ACCEPT_BETWEEN = 2,
			/// <summary>enum member</summary>
			// Token: 0x040014E1 RID: 5345
			ACCEPT_GREATER_THAN = 1,
			/// <summary>enum member</summary>
			// Token: 0x040014E2 RID: 5346
			ACCEPT_LESS_THAN = 0,
			/// <summary>enum member</summary>
			// Token: 0x040014E3 RID: 5347
			ACCEPT_OUTSIDE = 3
		}
	}
}
