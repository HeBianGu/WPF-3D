using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkNetCDFCFWriter
	///
	/// Writes netCDF files that follow the CF convention.  Details on this convention
	/// can be found at &lt;http://cfconventions.org/&gt;
	/// </summary>
	// Token: 0x02000171 RID: 369
	public class vtkNetCDFCFWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004680 RID: 18048 RVA: 0x000668D0 File Offset: 0x00064AD0
		static vtkNetCDFCFWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNetCDFCFWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNetCDFCFWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004681 RID: 18049 RVA: 0x000668F8 File Offset: 0x00064AF8
		public vtkNetCDFCFWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004682 RID: 18050
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFCFWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004683 RID: 18051 RVA: 0x00066908 File Offset: 0x00064B08
		public new static vtkNetCDFCFWriter New()
		{
			vtkNetCDFCFWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFCFWriter.vtkNetCDFCFWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNetCDFCFWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004684 RID: 18052 RVA: 0x0006695C File Offset: 0x00064B5C
		public vtkNetCDFCFWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkNetCDFCFWriter.vtkNetCDFCFWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004685 RID: 18053 RVA: 0x000669A0 File Offset: 0x00064BA0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004686 RID: 18054
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCFWriter_AddGridMappingAttribute_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);

		/// <summary>
		/// Add/clear attributes that define the grid mapping (or the coordinate
		/// reference system (CRS))
		///
		/// \verbatim
		/// To obtain the correct CF conventions attribute names and values
		/// when knowing the EPSG code use projinfo &lt;epsg_code&gt; This will
		/// print the WKT string. From that you can get the attribute names
		/// and values you need for CF convention.. The WKT attribute names
		/// are fairly close to CF convention attribute names.  The following
		/// link also helps with the conversion.
		/// &lt;a
		/// href="https://github.com/cf-convention/cf-conventions/wiki/Mapping-from-CF-Grid-Mapping-Attributes-to-CRS-WKT-Elements"&gt;CF
		/// Grid Mapping to WKT&lt;/a&gt; See also &lt;a
		/// href="http://cfconventions.org/Data/cf-conventions/cf-conventions-1.9/cf-conventions.html#appendix-grid-mappings"&gt;CF
		/// Grid Mapping&lt;/a&gt; for the attributes needed for each projection.
		/// \endverbatim
		/// </summary>
		// Token: 0x06004687 RID: 18055 RVA: 0x000669AB File Offset: 0x00064BAB
		public void AddGridMappingAttribute(string name, string value)
		{
			vtkNetCDFCFWriter.vtkNetCDFCFWriter_AddGridMappingAttribute_01(base.GetCppThis(), name, value);
		}

		// Token: 0x06004688 RID: 18056
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCFWriter_AddGridMappingAttribute_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, double value);

		/// <summary>
		/// Add/clear attributes that define the grid mapping (or the coordinate
		/// reference system (CRS))
		///
		/// \verbatim
		/// To obtain the correct CF conventions attribute names and values
		/// when knowing the EPSG code use projinfo &lt;epsg_code&gt; This will
		/// print the WKT string. From that you can get the attribute names
		/// and values you need for CF convention.. The WKT attribute names
		/// are fairly close to CF convention attribute names.  The following
		/// link also helps with the conversion.
		/// &lt;a
		/// href="https://github.com/cf-convention/cf-conventions/wiki/Mapping-from-CF-Grid-Mapping-Attributes-to-CRS-WKT-Elements"&gt;CF
		/// Grid Mapping to WKT&lt;/a&gt; See also &lt;a
		/// href="http://cfconventions.org/Data/cf-conventions/cf-conventions-1.9/cf-conventions.html#appendix-grid-mappings"&gt;CF
		/// Grid Mapping&lt;/a&gt; for the attributes needed for each projection.
		/// \endverbatim
		/// </summary>
		// Token: 0x06004689 RID: 18057 RVA: 0x000669BC File Offset: 0x00064BBC
		public void AddGridMappingAttribute(string name, double value)
		{
			vtkNetCDFCFWriter.vtkNetCDFCFWriter_AddGridMappingAttribute_02(base.GetCppThis(), name, value);
		}

		// Token: 0x0600468A RID: 18058
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCFWriter_ClearGridMappingAttributes_03(HandleRef pThis);

		/// <summary>
		/// Add/clear attributes that define the grid mapping (or the coordinate
		/// reference system (CRS))
		///
		/// \verbatim
		/// To obtain the correct CF conventions attribute names and values
		/// when knowing the EPSG code use projinfo &lt;epsg_code&gt; This will
		/// print the WKT string. From that you can get the attribute names
		/// and values you need for CF convention.. The WKT attribute names
		/// are fairly close to CF convention attribute names.  The following
		/// link also helps with the conversion.
		/// &lt;a
		/// href="https://github.com/cf-convention/cf-conventions/wiki/Mapping-from-CF-Grid-Mapping-Attributes-to-CRS-WKT-Elements"&gt;CF
		/// Grid Mapping to WKT&lt;/a&gt; See also &lt;a
		/// href="http://cfconventions.org/Data/cf-conventions/cf-conventions-1.9/cf-conventions.html#appendix-grid-mappings"&gt;CF
		/// Grid Mapping&lt;/a&gt; for the attributes needed for each projection.
		/// \endverbatim
		/// </summary>
		// Token: 0x0600468B RID: 18059 RVA: 0x000669CD File Offset: 0x00064BCD
		public void ClearGridMappingAttributes()
		{
			vtkNetCDFCFWriter.vtkNetCDFCFWriter_ClearGridMappingAttributes_03(base.GetCppThis());
		}

		// Token: 0x0600468C RID: 18060
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCFWriter_FillBlankedAttributesOff_04(HandleRef pThis);

		/// <summary>
		/// If true, before writing to the file it fills all blanked cells and points in
		/// the attribute arrays with the fill value for the type. Default is false.
		/// </summary>
		// Token: 0x0600468D RID: 18061 RVA: 0x000669DC File Offset: 0x00064BDC
		public virtual void FillBlankedAttributesOff()
		{
			vtkNetCDFCFWriter.vtkNetCDFCFWriter_FillBlankedAttributesOff_04(base.GetCppThis());
		}

		// Token: 0x0600468E RID: 18062
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCFWriter_FillBlankedAttributesOn_05(HandleRef pThis);

		/// <summary>
		/// If true, before writing to the file it fills all blanked cells and points in
		/// the attribute arrays with the fill value for the type. Default is false.
		/// </summary>
		// Token: 0x0600468F RID: 18063 RVA: 0x000669EB File Offset: 0x00064BEB
		public virtual void FillBlankedAttributesOn()
		{
			vtkNetCDFCFWriter.vtkNetCDFCFWriter_FillBlankedAttributesOn_05(base.GetCppThis());
		}

		// Token: 0x06004690 RID: 18064
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFCFWriter_GetAttributeType_06(HandleRef pThis);

		/// <summary>
		/// Only arrays of this attribute type are saved in the file. (vtkDataObject::POINT or CELL).
		/// Saving only one type of arrays avoids issues with conflicting array names
		/// between points and cells. Default is vtkDataObject::POINT
		/// </summary>
		// Token: 0x06004691 RID: 18065 RVA: 0x000669FC File Offset: 0x00064BFC
		public virtual int GetAttributeType()
		{
			return vtkNetCDFCFWriter.vtkNetCDFCFWriter_GetAttributeType_06(base.GetCppThis());
		}

		// Token: 0x06004692 RID: 18066
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFCFWriter_GetCellArrayNamePostfix_07(HandleRef pThis);

		/// <summary>
		/// VTK allows point and cell arrays with the same name, but NetCDF does not.
		/// This string is appended to a cell array name if it conflicts with a point
		/// array name when it is saved in a NetCDF file. Default is _c.
		///
		/// </summary>
		// Token: 0x06004693 RID: 18067 RVA: 0x00066A1C File Offset: 0x00064C1C
		public virtual string GetCellArrayNamePostfix()
		{
			string s = Marshal.PtrToStringAnsi(vtkNetCDFCFWriter.vtkNetCDFCFWriter_GetCellArrayNamePostfix_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004694 RID: 18068
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFCFWriter_GetFileName_08(HandleRef pThis);

		/// <summary>
		/// Get/Set the file name of the file.
		/// </summary>
		// Token: 0x06004695 RID: 18069 RVA: 0x00066A58 File Offset: 0x00064C58
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkNetCDFCFWriter.vtkNetCDFCFWriter_GetFileName_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004696 RID: 18070
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkNetCDFCFWriter_GetFillBlankedAttributes_09(HandleRef pThis);

		/// <summary>
		/// If true, before writing to the file it fills all blanked cells and points in
		/// the attribute arrays with the fill value for the type. Default is false.
		/// </summary>
		// Token: 0x06004697 RID: 18071 RVA: 0x00066A94 File Offset: 0x00064C94
		public virtual bool GetFillBlankedAttributes()
		{
			return vtkNetCDFCFWriter.vtkNetCDFCFWriter_GetFillBlankedAttributes_09(base.GetCppThis()) != 0;
		}

		// Token: 0x06004698 RID: 18072
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFCFWriter_GetFillValue_10(HandleRef pThis);

		/// <summary>
		/// Get/Set the FillValue for all array. Care must be taken to make sure
		/// the value fits in the value type of each array.
		/// Fill value has the same meaning as blanking in VTK but it is stored in
		/// the data array. This is stored in the NetCDF file.
		/// </summary>
		// Token: 0x06004699 RID: 18073 RVA: 0x00066ABC File Offset: 0x00064CBC
		public virtual int GetFillValue()
		{
			return vtkNetCDFCFWriter.vtkNetCDFCFWriter_GetFillValue_10(base.GetCppThis());
		}

		// Token: 0x0600469A RID: 18074
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNetCDFCFWriter_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600469B RID: 18075 RVA: 0x00066ADC File Offset: 0x00064CDC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNetCDFCFWriter.vtkNetCDFCFWriter_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0600469C RID: 18076
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNetCDFCFWriter_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600469D RID: 18077 RVA: 0x00066AFC File Offset: 0x00064CFC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNetCDFCFWriter.vtkNetCDFCFWriter_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0600469E RID: 18078
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFCFWriter_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600469F RID: 18079 RVA: 0x00066B18 File Offset: 0x00064D18
		public override int IsA(string type)
		{
			return vtkNetCDFCFWriter.vtkNetCDFCFWriter_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x060046A0 RID: 18080
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFCFWriter_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060046A1 RID: 18081 RVA: 0x00066B38 File Offset: 0x00064D38
		public new static int IsTypeOf(string type)
		{
			return vtkNetCDFCFWriter.vtkNetCDFCFWriter_IsTypeOf_14(type);
		}

		// Token: 0x060046A2 RID: 18082
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFCFWriter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060046A3 RID: 18083 RVA: 0x00066B54 File Offset: 0x00064D54
		public new vtkNetCDFCFWriter NewInstance()
		{
			vtkNetCDFCFWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFCFWriter.vtkNetCDFCFWriter_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNetCDFCFWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060046A4 RID: 18084
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFCFWriter_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060046A5 RID: 18085 RVA: 0x00066BB0 File Offset: 0x00064DB0
		public new static vtkNetCDFCFWriter SafeDownCast(vtkObjectBase o)
		{
			vtkNetCDFCFWriter vtkNetCDFCFWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFCFWriter.vtkNetCDFCFWriter_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNetCDFCFWriter = (vtkNetCDFCFWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNetCDFCFWriter.Register(null);
				}
			}
			return vtkNetCDFCFWriter;
		}

		// Token: 0x060046A6 RID: 18086
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCFWriter_SetAttributeType_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Only arrays of this attribute type are saved in the file. (vtkDataObject::POINT or CELL).
		/// Saving only one type of arrays avoids issues with conflicting array names
		/// between points and cells. Default is vtkDataObject::POINT
		/// </summary>
		// Token: 0x060046A7 RID: 18087 RVA: 0x00066C2F File Offset: 0x00064E2F
		public virtual void SetAttributeType(int _arg)
		{
			vtkNetCDFCFWriter.vtkNetCDFCFWriter_SetAttributeType_18(base.GetCppThis(), _arg);
		}

		// Token: 0x060046A8 RID: 18088
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCFWriter_SetCellArrayNamePostfix_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// VTK allows point and cell arrays with the same name, but NetCDF does not.
		/// This string is appended to a cell array name if it conflicts with a point
		/// array name when it is saved in a NetCDF file. Default is _c.
		///
		/// </summary>
		// Token: 0x060046A9 RID: 18089 RVA: 0x00066C3F File Offset: 0x00064E3F
		public virtual void SetCellArrayNamePostfix(string _arg)
		{
			vtkNetCDFCFWriter.vtkNetCDFCFWriter_SetCellArrayNamePostfix_19(base.GetCppThis(), _arg);
		}

		// Token: 0x060046AA RID: 18090
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCFWriter_SetFileName_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the file name of the file.
		/// </summary>
		// Token: 0x060046AB RID: 18091 RVA: 0x00066C4F File Offset: 0x00064E4F
		public virtual void SetFileName(string _arg)
		{
			vtkNetCDFCFWriter.vtkNetCDFCFWriter_SetFileName_20(base.GetCppThis(), _arg);
		}

		// Token: 0x060046AC RID: 18092
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCFWriter_SetFillBlankedAttributes_21(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true, before writing to the file it fills all blanked cells and points in
		/// the attribute arrays with the fill value for the type. Default is false.
		/// </summary>
		// Token: 0x060046AD RID: 18093 RVA: 0x00066C5F File Offset: 0x00064E5F
		public virtual void SetFillBlankedAttributes(bool _arg)
		{
			vtkNetCDFCFWriter.vtkNetCDFCFWriter_SetFillBlankedAttributes_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060046AE RID: 18094
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCFWriter_SetFillValue_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the FillValue for all array. Care must be taken to make sure
		/// the value fits in the value type of each array.
		/// Fill value has the same meaning as blanking in VTK but it is stored in
		/// the data array. This is stored in the NetCDF file.
		/// </summary>
		// Token: 0x060046AF RID: 18095 RVA: 0x00066C77 File Offset: 0x00064E77
		public virtual void SetFillValue(int _arg)
		{
			vtkNetCDFCFWriter.vtkNetCDFCFWriter_SetFillValue_22(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000731 RID: 1841
		public new const string MRFullTypeName = "Kitware.VTK.vtkNetCDFCFWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000732 RID: 1842
		public new static readonly string MRClassNameKey = "class vtkNetCDFCFWriter";
	}
}
