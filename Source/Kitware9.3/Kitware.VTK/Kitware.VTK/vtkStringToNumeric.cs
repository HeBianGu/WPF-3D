using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStringToNumeric
	/// </summary>
	/// <remarks>
	///    Converts string arrays to numeric arrays
	///
	///
	/// vtkStringToNumeric is a filter for converting a string array
	/// into a numeric arrays.
	/// </remarks>
	// Token: 0x02000693 RID: 1683
	public class vtkStringToNumeric : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601208B RID: 73867 RVA: 0x001940CB File Offset: 0x001922CB
		static vtkStringToNumeric()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStringToNumeric.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStringToNumeric"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601208C RID: 73868 RVA: 0x001940F3 File Offset: 0x001922F3
		public vtkStringToNumeric(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601208D RID: 73869
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStringToNumeric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601208E RID: 73870 RVA: 0x00194104 File Offset: 0x00192304
		public new static vtkStringToNumeric New()
		{
			vtkStringToNumeric result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStringToNumeric.vtkStringToNumeric_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStringToNumeric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601208F RID: 73871 RVA: 0x00194158 File Offset: 0x00192358
		public vtkStringToNumeric() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStringToNumeric.vtkStringToNumeric_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012090 RID: 73872 RVA: 0x0019419C File Offset: 0x0019239C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012091 RID: 73873
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_ConvertCellDataOff_01(HandleRef pThis);

		/// <summary>
		/// Whether to detect and convert point data arrays.  Default is on.
		/// </summary>
		// Token: 0x06012092 RID: 73874 RVA: 0x001941A7 File Offset: 0x001923A7
		public virtual void ConvertCellDataOff()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertCellDataOff_01(base.GetCppThis());
		}

		// Token: 0x06012093 RID: 73875
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_ConvertCellDataOn_02(HandleRef pThis);

		/// <summary>
		/// Whether to detect and convert point data arrays.  Default is on.
		/// </summary>
		// Token: 0x06012094 RID: 73876 RVA: 0x001941B6 File Offset: 0x001923B6
		public virtual void ConvertCellDataOn()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertCellDataOn_02(base.GetCppThis());
		}

		// Token: 0x06012095 RID: 73877
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_ConvertEdgeDataOff_03(HandleRef pThis);

		/// <summary>
		/// Whether to detect and convert edge data arrays.  Default is on.
		/// </summary>
		// Token: 0x06012096 RID: 73878 RVA: 0x001941C5 File Offset: 0x001923C5
		public virtual void ConvertEdgeDataOff()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertEdgeDataOff_03(base.GetCppThis());
		}

		// Token: 0x06012097 RID: 73879
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_ConvertEdgeDataOn_04(HandleRef pThis);

		/// <summary>
		/// Whether to detect and convert edge data arrays.  Default is on.
		/// </summary>
		// Token: 0x06012098 RID: 73880 RVA: 0x001941D4 File Offset: 0x001923D4
		public virtual void ConvertEdgeDataOn()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertEdgeDataOn_04(base.GetCppThis());
		}

		// Token: 0x06012099 RID: 73881
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_ConvertFieldDataOff_05(HandleRef pThis);

		/// <summary>
		/// Whether to detect and convert field data arrays.  Default is on.
		/// </summary>
		// Token: 0x0601209A RID: 73882 RVA: 0x001941E3 File Offset: 0x001923E3
		public virtual void ConvertFieldDataOff()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertFieldDataOff_05(base.GetCppThis());
		}

		// Token: 0x0601209B RID: 73883
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_ConvertFieldDataOn_06(HandleRef pThis);

		/// <summary>
		/// Whether to detect and convert field data arrays.  Default is on.
		/// </summary>
		// Token: 0x0601209C RID: 73884 RVA: 0x001941F2 File Offset: 0x001923F2
		public virtual void ConvertFieldDataOn()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertFieldDataOn_06(base.GetCppThis());
		}

		// Token: 0x0601209D RID: 73885
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_ConvertPointDataOff_07(HandleRef pThis);

		/// <summary>
		/// Whether to detect and convert cell data arrays.  Default is on.
		/// </summary>
		// Token: 0x0601209E RID: 73886 RVA: 0x00194201 File Offset: 0x00192401
		public virtual void ConvertPointDataOff()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertPointDataOff_07(base.GetCppThis());
		}

		// Token: 0x0601209F RID: 73887
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_ConvertPointDataOn_08(HandleRef pThis);

		/// <summary>
		/// Whether to detect and convert cell data arrays.  Default is on.
		/// </summary>
		// Token: 0x060120A0 RID: 73888 RVA: 0x00194210 File Offset: 0x00192410
		public virtual void ConvertPointDataOn()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertPointDataOn_08(base.GetCppThis());
		}

		// Token: 0x060120A1 RID: 73889
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_ConvertRowDataOff_09(HandleRef pThis);

		/// <summary>
		/// Whether to detect and convert row data arrays.  Default is on.
		/// </summary>
		// Token: 0x060120A2 RID: 73890 RVA: 0x0019421F File Offset: 0x0019241F
		public virtual void ConvertRowDataOff()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertRowDataOff_09(base.GetCppThis());
		}

		// Token: 0x060120A3 RID: 73891
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_ConvertRowDataOn_10(HandleRef pThis);

		/// <summary>
		/// Whether to detect and convert row data arrays.  Default is on.
		/// </summary>
		// Token: 0x060120A4 RID: 73892 RVA: 0x0019422E File Offset: 0x0019242E
		public virtual void ConvertRowDataOn()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertRowDataOn_10(base.GetCppThis());
		}

		// Token: 0x060120A5 RID: 73893
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_ConvertVertexDataOff_11(HandleRef pThis);

		/// <summary>
		/// Whether to detect and convert vertex data arrays.  Default is on.
		/// </summary>
		// Token: 0x060120A6 RID: 73894 RVA: 0x0019423D File Offset: 0x0019243D
		public virtual void ConvertVertexDataOff()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertVertexDataOff_11(base.GetCppThis());
		}

		// Token: 0x060120A7 RID: 73895
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_ConvertVertexDataOn_12(HandleRef pThis);

		/// <summary>
		/// Whether to detect and convert vertex data arrays.  Default is on.
		/// </summary>
		// Token: 0x060120A8 RID: 73896 RVA: 0x0019424C File Offset: 0x0019244C
		public virtual void ConvertVertexDataOn()
		{
			vtkStringToNumeric.vtkStringToNumeric_ConvertVertexDataOn_12(base.GetCppThis());
		}

		// Token: 0x060120A9 RID: 73897
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_ForceDoubleOff_13(HandleRef pThis);

		/// <summary>
		/// Convert all numeric columns to vtkDoubleArray, even if they
		/// contain only integer values. Default is off.
		/// </summary>
		// Token: 0x060120AA RID: 73898 RVA: 0x0019425B File Offset: 0x0019245B
		public virtual void ForceDoubleOff()
		{
			vtkStringToNumeric.vtkStringToNumeric_ForceDoubleOff_13(base.GetCppThis());
		}

		// Token: 0x060120AB RID: 73899
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_ForceDoubleOn_14(HandleRef pThis);

		/// <summary>
		/// Convert all numeric columns to vtkDoubleArray, even if they
		/// contain only integer values. Default is off.
		/// </summary>
		// Token: 0x060120AC RID: 73900 RVA: 0x0019426A File Offset: 0x0019246A
		public virtual void ForceDoubleOn()
		{
			vtkStringToNumeric.vtkStringToNumeric_ForceDoubleOn_14(base.GetCppThis());
		}

		// Token: 0x060120AD RID: 73901
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStringToNumeric_GetConvertCellData_15(HandleRef pThis);

		/// <summary>
		/// Whether to detect and convert point data arrays.  Default is on.
		/// </summary>
		// Token: 0x060120AE RID: 73902 RVA: 0x0019427C File Offset: 0x0019247C
		public virtual bool GetConvertCellData()
		{
			return vtkStringToNumeric.vtkStringToNumeric_GetConvertCellData_15(base.GetCppThis()) != 0;
		}

		// Token: 0x060120AF RID: 73903
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStringToNumeric_GetConvertEdgeData_16(HandleRef pThis);

		/// <summary>
		/// Whether to detect and convert edge data arrays.  Default is on.
		/// </summary>
		// Token: 0x060120B0 RID: 73904 RVA: 0x001942A4 File Offset: 0x001924A4
		public virtual bool GetConvertEdgeData()
		{
			return vtkStringToNumeric.vtkStringToNumeric_GetConvertEdgeData_16(base.GetCppThis()) != 0;
		}

		// Token: 0x060120B1 RID: 73905
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStringToNumeric_GetConvertFieldData_17(HandleRef pThis);

		/// <summary>
		/// Whether to detect and convert field data arrays.  Default is on.
		/// </summary>
		// Token: 0x060120B2 RID: 73906 RVA: 0x001942CC File Offset: 0x001924CC
		public virtual bool GetConvertFieldData()
		{
			return vtkStringToNumeric.vtkStringToNumeric_GetConvertFieldData_17(base.GetCppThis()) != 0;
		}

		// Token: 0x060120B3 RID: 73907
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStringToNumeric_GetConvertPointData_18(HandleRef pThis);

		/// <summary>
		/// Whether to detect and convert cell data arrays.  Default is on.
		/// </summary>
		// Token: 0x060120B4 RID: 73908 RVA: 0x001942F4 File Offset: 0x001924F4
		public virtual bool GetConvertPointData()
		{
			return vtkStringToNumeric.vtkStringToNumeric_GetConvertPointData_18(base.GetCppThis()) != 0;
		}

		// Token: 0x060120B5 RID: 73909
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStringToNumeric_GetConvertRowData_19(HandleRef pThis);

		/// <summary>
		/// Whether to detect and convert row data arrays.  Default is on.
		/// </summary>
		// Token: 0x060120B6 RID: 73910 RVA: 0x0019431C File Offset: 0x0019251C
		public virtual bool GetConvertRowData()
		{
			return vtkStringToNumeric.vtkStringToNumeric_GetConvertRowData_19(base.GetCppThis()) != 0;
		}

		// Token: 0x060120B7 RID: 73911
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStringToNumeric_GetConvertVertexData_20(HandleRef pThis);

		/// <summary>
		/// Whether to detect and convert vertex data arrays.  Default is on.
		/// </summary>
		// Token: 0x060120B8 RID: 73912 RVA: 0x00194344 File Offset: 0x00192544
		public virtual bool GetConvertVertexData()
		{
			return vtkStringToNumeric.vtkStringToNumeric_GetConvertVertexData_20(base.GetCppThis()) != 0;
		}

		// Token: 0x060120B9 RID: 73913
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStringToNumeric_GetDefaultDoubleValue_21(HandleRef pThis);

		/// <summary>
		/// Set the default double value assigned to arrays.  Default is 0.0
		/// </summary>
		// Token: 0x060120BA RID: 73914 RVA: 0x0019436C File Offset: 0x0019256C
		public virtual double GetDefaultDoubleValue()
		{
			return vtkStringToNumeric.vtkStringToNumeric_GetDefaultDoubleValue_21(base.GetCppThis());
		}

		// Token: 0x060120BB RID: 73915
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStringToNumeric_GetDefaultIntegerValue_22(HandleRef pThis);

		/// <summary>
		/// Set the default integer value assigned to arrays.  Default is 0.
		/// </summary>
		// Token: 0x060120BC RID: 73916 RVA: 0x0019438C File Offset: 0x0019258C
		public virtual int GetDefaultIntegerValue()
		{
			return vtkStringToNumeric.vtkStringToNumeric_GetDefaultIntegerValue_22(base.GetCppThis());
		}

		// Token: 0x060120BD RID: 73917
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStringToNumeric_GetForceDouble_23(HandleRef pThis);

		/// <summary>
		/// Convert all numeric columns to vtkDoubleArray, even if they
		/// contain only integer values. Default is off.
		/// </summary>
		// Token: 0x060120BE RID: 73918 RVA: 0x001943AC File Offset: 0x001925AC
		public virtual bool GetForceDouble()
		{
			return vtkStringToNumeric.vtkStringToNumeric_GetForceDouble_23(base.GetCppThis()) != 0;
		}

		// Token: 0x060120BF RID: 73919
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStringToNumeric_GetNumberOfGenerationsFromBase_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060120C0 RID: 73920 RVA: 0x001943D4 File Offset: 0x001925D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStringToNumeric.vtkStringToNumeric_GetNumberOfGenerationsFromBase_24(base.GetCppThis(), type);
		}

		// Token: 0x060120C1 RID: 73921
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStringToNumeric_GetNumberOfGenerationsFromBaseType_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060120C2 RID: 73922 RVA: 0x001943F4 File Offset: 0x001925F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStringToNumeric.vtkStringToNumeric_GetNumberOfGenerationsFromBaseType_25(type);
		}

		// Token: 0x060120C3 RID: 73923
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStringToNumeric_GetTrimWhitespacePriorToNumericConversion_26(HandleRef pThis);

		/// <summary>
		/// Whether to trim whitespace from strings prior to conversion to a numeric.
		/// Default is false to preserve backward compatibility.
		///
		/// vtkVariant handles whitespace inconsistently, so trim it before we try to
		/// convert it.  For example:
		///
		/// vtkVariant("  2.0").ToDouble() == 2.0 &lt;-- leading whitespace is not a problem
		/// vtkVariant("  2.0  ").ToDouble() == NaN &lt;-- trailing whitespace is a problem
		/// vtkVariant("  infinity  ").ToDouble() == NaN &lt;-- any whitespace is a problem
		///
		/// In these cases, trimming the whitespace gives us the result we expect:
		/// 2.0 and INF respectively.
		/// </summary>
		// Token: 0x060120C4 RID: 73924 RVA: 0x00194410 File Offset: 0x00192610
		public virtual bool GetTrimWhitespacePriorToNumericConversion()
		{
			return vtkStringToNumeric.vtkStringToNumeric_GetTrimWhitespacePriorToNumericConversion_26(base.GetCppThis()) != 0;
		}

		// Token: 0x060120C5 RID: 73925
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStringToNumeric_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060120C6 RID: 73926 RVA: 0x00194438 File Offset: 0x00192638
		public override int IsA(string type)
		{
			return vtkStringToNumeric.vtkStringToNumeric_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x060120C7 RID: 73927
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStringToNumeric_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060120C8 RID: 73928 RVA: 0x00194458 File Offset: 0x00192658
		public new static int IsTypeOf(string type)
		{
			return vtkStringToNumeric.vtkStringToNumeric_IsTypeOf_28(type);
		}

		// Token: 0x060120C9 RID: 73929
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStringToNumeric_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060120CA RID: 73930 RVA: 0x00194474 File Offset: 0x00192674
		public new vtkStringToNumeric NewInstance()
		{
			vtkStringToNumeric result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStringToNumeric.vtkStringToNumeric_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStringToNumeric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060120CB RID: 73931
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStringToNumeric_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060120CC RID: 73932 RVA: 0x001944D0 File Offset: 0x001926D0
		public new static vtkStringToNumeric SafeDownCast(vtkObjectBase o)
		{
			vtkStringToNumeric vtkStringToNumeric = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStringToNumeric.vtkStringToNumeric_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringToNumeric = (vtkStringToNumeric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringToNumeric.Register(null);
				}
			}
			return vtkStringToNumeric;
		}

		// Token: 0x060120CD RID: 73933
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_SetConvertCellData_32(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to detect and convert point data arrays.  Default is on.
		/// </summary>
		// Token: 0x060120CE RID: 73934 RVA: 0x0019454F File Offset: 0x0019274F
		public virtual void SetConvertCellData(bool _arg)
		{
			vtkStringToNumeric.vtkStringToNumeric_SetConvertCellData_32(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060120CF RID: 73935
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_SetConvertEdgeData_33(HandleRef pThis, byte b);

		/// <summary>
		/// Whether to detect and convert edge data arrays.  Default is on.
		/// </summary>
		// Token: 0x060120D0 RID: 73936 RVA: 0x00194567 File Offset: 0x00192767
		public virtual void SetConvertEdgeData(bool b)
		{
			vtkStringToNumeric.vtkStringToNumeric_SetConvertEdgeData_33(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x060120D1 RID: 73937
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_SetConvertFieldData_34(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to detect and convert field data arrays.  Default is on.
		/// </summary>
		// Token: 0x060120D2 RID: 73938 RVA: 0x0019457F File Offset: 0x0019277F
		public virtual void SetConvertFieldData(bool _arg)
		{
			vtkStringToNumeric.vtkStringToNumeric_SetConvertFieldData_34(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060120D3 RID: 73939
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_SetConvertPointData_35(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to detect and convert cell data arrays.  Default is on.
		/// </summary>
		// Token: 0x060120D4 RID: 73940 RVA: 0x00194597 File Offset: 0x00192797
		public virtual void SetConvertPointData(bool _arg)
		{
			vtkStringToNumeric.vtkStringToNumeric_SetConvertPointData_35(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060120D5 RID: 73941
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_SetConvertRowData_36(HandleRef pThis, byte b);

		/// <summary>
		/// Whether to detect and convert row data arrays.  Default is on.
		/// </summary>
		// Token: 0x060120D6 RID: 73942 RVA: 0x001945AF File Offset: 0x001927AF
		public virtual void SetConvertRowData(bool b)
		{
			vtkStringToNumeric.vtkStringToNumeric_SetConvertRowData_36(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x060120D7 RID: 73943
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_SetConvertVertexData_37(HandleRef pThis, byte b);

		/// <summary>
		/// Whether to detect and convert vertex data arrays.  Default is on.
		/// </summary>
		// Token: 0x060120D8 RID: 73944 RVA: 0x001945C7 File Offset: 0x001927C7
		public virtual void SetConvertVertexData(bool b)
		{
			vtkStringToNumeric.vtkStringToNumeric_SetConvertVertexData_37(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x060120D9 RID: 73945
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_SetDefaultDoubleValue_38(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the default double value assigned to arrays.  Default is 0.0
		/// </summary>
		// Token: 0x060120DA RID: 73946 RVA: 0x001945DF File Offset: 0x001927DF
		public virtual void SetDefaultDoubleValue(double _arg)
		{
			vtkStringToNumeric.vtkStringToNumeric_SetDefaultDoubleValue_38(base.GetCppThis(), _arg);
		}

		// Token: 0x060120DB RID: 73947
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_SetDefaultIntegerValue_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the default integer value assigned to arrays.  Default is 0.
		/// </summary>
		// Token: 0x060120DC RID: 73948 RVA: 0x001945EF File Offset: 0x001927EF
		public virtual void SetDefaultIntegerValue(int _arg)
		{
			vtkStringToNumeric.vtkStringToNumeric_SetDefaultIntegerValue_39(base.GetCppThis(), _arg);
		}

		// Token: 0x060120DD RID: 73949
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_SetForceDouble_40(HandleRef pThis, byte _arg);

		/// <summary>
		/// Convert all numeric columns to vtkDoubleArray, even if they
		/// contain only integer values. Default is off.
		/// </summary>
		// Token: 0x060120DE RID: 73950 RVA: 0x001945FF File Offset: 0x001927FF
		public virtual void SetForceDouble(bool _arg)
		{
			vtkStringToNumeric.vtkStringToNumeric_SetForceDouble_40(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060120DF RID: 73951
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_SetTrimWhitespacePriorToNumericConversion_41(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to trim whitespace from strings prior to conversion to a numeric.
		/// Default is false to preserve backward compatibility.
		///
		/// vtkVariant handles whitespace inconsistently, so trim it before we try to
		/// convert it.  For example:
		///
		/// vtkVariant("  2.0").ToDouble() == 2.0 &lt;-- leading whitespace is not a problem
		/// vtkVariant("  2.0  ").ToDouble() == NaN &lt;-- trailing whitespace is a problem
		/// vtkVariant("  infinity  ").ToDouble() == NaN &lt;-- any whitespace is a problem
		///
		/// In these cases, trimming the whitespace gives us the result we expect:
		/// 2.0 and INF respectively.
		/// </summary>
		// Token: 0x060120E0 RID: 73952 RVA: 0x00194617 File Offset: 0x00192817
		public virtual void SetTrimWhitespacePriorToNumericConversion(bool _arg)
		{
			vtkStringToNumeric.vtkStringToNumeric_SetTrimWhitespacePriorToNumericConversion_41(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060120E1 RID: 73953
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_TrimWhitespacePriorToNumericConversionOff_42(HandleRef pThis);

		/// <summary>
		/// Whether to trim whitespace from strings prior to conversion to a numeric.
		/// Default is false to preserve backward compatibility.
		///
		/// vtkVariant handles whitespace inconsistently, so trim it before we try to
		/// convert it.  For example:
		///
		/// vtkVariant("  2.0").ToDouble() == 2.0 &lt;-- leading whitespace is not a problem
		/// vtkVariant("  2.0  ").ToDouble() == NaN &lt;-- trailing whitespace is a problem
		/// vtkVariant("  infinity  ").ToDouble() == NaN &lt;-- any whitespace is a problem
		///
		/// In these cases, trimming the whitespace gives us the result we expect:
		/// 2.0 and INF respectively.
		/// </summary>
		// Token: 0x060120E2 RID: 73954 RVA: 0x0019462F File Offset: 0x0019282F
		public virtual void TrimWhitespacePriorToNumericConversionOff()
		{
			vtkStringToNumeric.vtkStringToNumeric_TrimWhitespacePriorToNumericConversionOff_42(base.GetCppThis());
		}

		// Token: 0x060120E3 RID: 73955
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToNumeric_TrimWhitespacePriorToNumericConversionOn_43(HandleRef pThis);

		/// <summary>
		/// Whether to trim whitespace from strings prior to conversion to a numeric.
		/// Default is false to preserve backward compatibility.
		///
		/// vtkVariant handles whitespace inconsistently, so trim it before we try to
		/// convert it.  For example:
		///
		/// vtkVariant("  2.0").ToDouble() == 2.0 &lt;-- leading whitespace is not a problem
		/// vtkVariant("  2.0  ").ToDouble() == NaN &lt;-- trailing whitespace is a problem
		/// vtkVariant("  infinity  ").ToDouble() == NaN &lt;-- any whitespace is a problem
		///
		/// In these cases, trimming the whitespace gives us the result we expect:
		/// 2.0 and INF respectively.
		/// </summary>
		// Token: 0x060120E4 RID: 73956 RVA: 0x0019463E File Offset: 0x0019283E
		public virtual void TrimWhitespacePriorToNumericConversionOn()
		{
			vtkStringToNumeric.vtkStringToNumeric_TrimWhitespacePriorToNumericConversionOn_43(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014D1 RID: 5329
		public new const string MRFullTypeName = "Kitware.VTK.vtkStringToNumeric";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014D2 RID: 5330
		public new static readonly string MRClassNameKey = "class vtkStringToNumeric";
	}
}
