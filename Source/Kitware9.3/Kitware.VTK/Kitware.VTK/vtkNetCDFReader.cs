using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkNetCDFReader
	///
	///
	///
	/// A superclass for reading netCDF files.  Subclass add conventions to the
	/// reader.  This class just outputs data into a multi block data set with a
	/// vtkImageData at each block.  A block is created for each variable except that
	/// variables with matching dimensions will be placed in the same block.
	/// </summary>
	// Token: 0x0200016F RID: 367
	public class vtkNetCDFReader : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004616 RID: 17942 RVA: 0x00065FC3 File Offset: 0x000641C3
		static vtkNetCDFReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNetCDFReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNetCDFReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004617 RID: 17943 RVA: 0x00065FEB File Offset: 0x000641EB
		public vtkNetCDFReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004618 RID: 17944
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004619 RID: 17945 RVA: 0x00065FFC File Offset: 0x000641FC
		public new static vtkNetCDFReader New()
		{
			vtkNetCDFReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFReader.vtkNetCDFReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNetCDFReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600461A RID: 17946 RVA: 0x00066050 File Offset: 0x00064250
		public vtkNetCDFReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkNetCDFReader.vtkNetCDFReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600461B RID: 17947 RVA: 0x00066094 File Offset: 0x00064294
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600461C RID: 17948
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkNetCDFReader_ComputeArraySelection_01(HandleRef pThis);

		/// <summary>
		/// Enables arrays in VariableArraySelection depending on Dimensions.
		/// Returns true if one variable matching Dimensions was found.
		/// </summary>
		// Token: 0x0600461D RID: 17949 RVA: 0x000660A0 File Offset: 0x000642A0
		public bool ComputeArraySelection()
		{
			return vtkNetCDFReader.vtkNetCDFReader_ComputeArraySelection_01(base.GetCppThis()) != 0;
		}

		// Token: 0x0600461E RID: 17950
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFReader_GetAllDimensions_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns an array with string encodings for the dimension combinations used
		/// in the variables.  The result is the same as GetVariableDimensions except
		/// that each entry in the array is unique (a set of dimensions is only given
		/// once even if it occurs for multiple variables) and the order is
		/// meaningless.
		/// </summary>
		// Token: 0x0600461F RID: 17951 RVA: 0x000660C8 File Offset: 0x000642C8
		public virtual vtkStringArray GetAllDimensions()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFReader.vtkNetCDFReader_GetAllDimensions_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x06004620 RID: 17952
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFReader_GetAllVariableArrayNames_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience method to get a list of variable arrays.  The length of the
		/// returned list is the same as GetNumberOfVariableArrays, and the string
		/// at each index i is the same as returned from GetVariableArrayname(i).
		/// </summary>
		// Token: 0x06004621 RID: 17953 RVA: 0x00066138 File Offset: 0x00064338
		public virtual vtkStringArray GetAllVariableArrayNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFReader.vtkNetCDFReader_GetAllVariableArrayNames_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x06004622 RID: 17954
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFReader_GetCalendar_04(HandleRef pThis);

		/// <summary>
		/// Access to the time dimensions units.
		/// Can be used by the udunits library to convert raw numerical time values
		/// into meaningful representations.
		/// </summary>
		// Token: 0x06004623 RID: 17955 RVA: 0x000661A8 File Offset: 0x000643A8
		public virtual string GetCalendar()
		{
			string s = Marshal.PtrToStringAnsi(vtkNetCDFReader.vtkNetCDFReader_GetCalendar_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004624 RID: 17956
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFReader_GetFileName_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004625 RID: 17957 RVA: 0x000661E4 File Offset: 0x000643E4
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkNetCDFReader.vtkNetCDFReader_GetFileName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004626 RID: 17958
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNetCDFReader_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004627 RID: 17959 RVA: 0x00066220 File Offset: 0x00064420
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNetCDFReader.vtkNetCDFReader_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06004628 RID: 17960
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNetCDFReader_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004629 RID: 17961 RVA: 0x00066240 File Offset: 0x00064440
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNetCDFReader.vtkNetCDFReader_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600462A RID: 17962
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFReader_GetNumberOfVariableArrays_08(HandleRef pThis);

		/// <summary>
		/// Variable array selection.
		/// </summary>
		// Token: 0x0600462B RID: 17963 RVA: 0x0006625C File Offset: 0x0006445C
		public virtual int GetNumberOfVariableArrays()
		{
			return vtkNetCDFReader.vtkNetCDFReader_GetNumberOfVariableArrays_08(base.GetCppThis());
		}

		// Token: 0x0600462C RID: 17964
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFReader_GetReplaceFillValueWithNan_09(HandleRef pThis);

		/// <summary>
		/// If on, any float or double variable read that has a _FillValue attribute
		/// will have that fill value replaced with a not-a-number (NaN) value.  The
		/// advantage of setting these to NaN values is that, if implemented properly
		/// by the system and careful math operations are used, they can implicitly be
		/// ignored by calculations like finding the range of the values.  That said,
		/// this option should be used with caution as VTK does not fully support NaN
		/// values and therefore odd calculations may occur.  By default this is off.
		/// </summary>
		// Token: 0x0600462D RID: 17965 RVA: 0x0006627C File Offset: 0x0006447C
		public virtual int GetReplaceFillValueWithNan()
		{
			return vtkNetCDFReader.vtkNetCDFReader_GetReplaceFillValueWithNan_09(base.GetCppThis());
		}

		// Token: 0x0600462E RID: 17966
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFReader_GetTimeUnits_10(HandleRef pThis);

		/// <summary>
		/// Access to the time dimensions units.
		/// Can be used by the udunits library to convert raw numerical time values
		/// into meaningful representations.
		/// </summary>
		// Token: 0x0600462F RID: 17967 RVA: 0x0006629C File Offset: 0x0006449C
		public virtual string GetTimeUnits()
		{
			string s = Marshal.PtrToStringAnsi(vtkNetCDFReader.vtkNetCDFReader_GetTimeUnits_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004630 RID: 17968
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFReader_GetVariableArrayName_11(HandleRef pThis, int index);

		/// <summary>
		/// Variable array selection.
		/// </summary>
		// Token: 0x06004631 RID: 17969 RVA: 0x000662D8 File Offset: 0x000644D8
		public virtual string GetVariableArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkNetCDFReader.vtkNetCDFReader_GetVariableArrayName_11(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004632 RID: 17970
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFReader_GetVariableArrayStatus_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Variable array selection.
		/// </summary>
		// Token: 0x06004633 RID: 17971 RVA: 0x00066314 File Offset: 0x00064514
		public virtual int GetVariableArrayStatus(string name)
		{
			return vtkNetCDFReader.vtkNetCDFReader_GetVariableArrayStatus_12(base.GetCppThis(), name);
		}

		// Token: 0x06004634 RID: 17972
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFReader_GetVariableDimensions_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns an array with string encodings for the dimensions used in each of
		/// the variables.  The indices in the returned array correspond to those used
		/// in the GetVariableArrayName method.  Two arrays with the same dimensions
		/// will have the same encoded string returned by this method.
		/// </summary>
		// Token: 0x06004635 RID: 17973 RVA: 0x00066334 File Offset: 0x00064534
		public virtual vtkStringArray GetVariableDimensions()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFReader.vtkNetCDFReader_GetVariableDimensions_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x06004636 RID: 17974
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFReader_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004637 RID: 17975 RVA: 0x000663A4 File Offset: 0x000645A4
		public override int IsA(string type)
		{
			return vtkNetCDFReader.vtkNetCDFReader_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x06004638 RID: 17976
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFReader_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004639 RID: 17977 RVA: 0x000663C4 File Offset: 0x000645C4
		public new static int IsTypeOf(string type)
		{
			return vtkNetCDFReader.vtkNetCDFReader_IsTypeOf_15(type);
		}

		// Token: 0x0600463A RID: 17978
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFReader_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600463B RID: 17979 RVA: 0x000663E0 File Offset: 0x000645E0
		public new vtkNetCDFReader NewInstance()
		{
			vtkNetCDFReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFReader.vtkNetCDFReader_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNetCDFReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600463C RID: 17980
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkNetCDFReader_QueryArrayUnits_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string ArrayName);

		/// <summary>
		/// Get units attached to a particular array in the netcdf file.
		/// </summary>
		// Token: 0x0600463D RID: 17981 RVA: 0x0006643C File Offset: 0x0006463C
		public string QueryArrayUnits(string ArrayName)
		{
			return vtkNetCDFReader.vtkNetCDFReader_QueryArrayUnits_18(base.GetCppThis(), ArrayName);
		}

		// Token: 0x0600463E RID: 17982
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFReader_ReplaceFillValueWithNanOff_19(HandleRef pThis);

		/// <summary>
		/// If on, any float or double variable read that has a _FillValue attribute
		/// will have that fill value replaced with a not-a-number (NaN) value.  The
		/// advantage of setting these to NaN values is that, if implemented properly
		/// by the system and careful math operations are used, they can implicitly be
		/// ignored by calculations like finding the range of the values.  That said,
		/// this option should be used with caution as VTK does not fully support NaN
		/// values and therefore odd calculations may occur.  By default this is off.
		/// </summary>
		// Token: 0x0600463F RID: 17983 RVA: 0x0006645C File Offset: 0x0006465C
		public virtual void ReplaceFillValueWithNanOff()
		{
			vtkNetCDFReader.vtkNetCDFReader_ReplaceFillValueWithNanOff_19(base.GetCppThis());
		}

		// Token: 0x06004640 RID: 17984
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFReader_ReplaceFillValueWithNanOn_20(HandleRef pThis);

		/// <summary>
		/// If on, any float or double variable read that has a _FillValue attribute
		/// will have that fill value replaced with a not-a-number (NaN) value.  The
		/// advantage of setting these to NaN values is that, if implemented properly
		/// by the system and careful math operations are used, they can implicitly be
		/// ignored by calculations like finding the range of the values.  That said,
		/// this option should be used with caution as VTK does not fully support NaN
		/// values and therefore odd calculations may occur.  By default this is off.
		/// </summary>
		// Token: 0x06004641 RID: 17985 RVA: 0x0006646B File Offset: 0x0006466B
		public virtual void ReplaceFillValueWithNanOn()
		{
			vtkNetCDFReader.vtkNetCDFReader_ReplaceFillValueWithNanOn_20(base.GetCppThis());
		}

		// Token: 0x06004642 RID: 17986
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFReader_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004643 RID: 17987 RVA: 0x0006647C File Offset: 0x0006467C
		public new static vtkNetCDFReader SafeDownCast(vtkObjectBase o)
		{
			vtkNetCDFReader vtkNetCDFReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFReader.vtkNetCDFReader_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNetCDFReader = (vtkNetCDFReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNetCDFReader.Register(null);
				}
			}
			return vtkNetCDFReader;
		}

		// Token: 0x06004644 RID: 17988
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFReader_SetDimensions_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string dimensions);

		/// <summary>
		/// Loads the grid with the given dimensions.  The dimensions are encoded in a
		/// string that conforms to the same format as returned by
		/// GetVariableDimensions and GetAllDimensions.  This method is really a
		/// convenience method for SetVariableArrayStatus.  It turns on all variables
		/// that have the given dimensions and turns off all other variables.
		/// </summary>
		// Token: 0x06004645 RID: 17989 RVA: 0x000664FB File Offset: 0x000646FB
		public virtual void SetDimensions(string dimensions)
		{
			vtkNetCDFReader.vtkNetCDFReader_SetDimensions_22(base.GetCppThis(), dimensions);
		}

		// Token: 0x06004646 RID: 17990
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFReader_SetFileName_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004647 RID: 17991 RVA: 0x0006650B File Offset: 0x0006470B
		public virtual void SetFileName(string filename)
		{
			vtkNetCDFReader.vtkNetCDFReader_SetFileName_23(base.GetCppThis(), filename);
		}

		// Token: 0x06004648 RID: 17992
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFReader_SetReplaceFillValueWithNan_24(HandleRef pThis, int _arg);

		/// <summary>
		/// If on, any float or double variable read that has a _FillValue attribute
		/// will have that fill value replaced with a not-a-number (NaN) value.  The
		/// advantage of setting these to NaN values is that, if implemented properly
		/// by the system and careful math operations are used, they can implicitly be
		/// ignored by calculations like finding the range of the values.  That said,
		/// this option should be used with caution as VTK does not fully support NaN
		/// values and therefore odd calculations may occur.  By default this is off.
		/// </summary>
		// Token: 0x06004649 RID: 17993 RVA: 0x0006651B File Offset: 0x0006471B
		public virtual void SetReplaceFillValueWithNan(int _arg)
		{
			vtkNetCDFReader.vtkNetCDFReader_SetReplaceFillValueWithNan_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600464A RID: 17994
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFReader_SetVariableArrayStatus_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// Variable array selection.
		/// </summary>
		// Token: 0x0600464B RID: 17995 RVA: 0x0006652B File Offset: 0x0006472B
		public virtual void SetVariableArrayStatus(string name, int status)
		{
			vtkNetCDFReader.vtkNetCDFReader_SetVariableArrayStatus_25(base.GetCppThis(), name, status);
		}

		// Token: 0x0600464C RID: 17996
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFReader_UpdateMetaData_26(HandleRef pThis);

		/// <summary>
		/// Update the meta data from the current file.  Automatically called
		/// during the RequestInformation pipeline update stage.
		/// </summary>
		// Token: 0x0600464D RID: 17997 RVA: 0x0006653C File Offset: 0x0006473C
		public int UpdateMetaData()
		{
			return vtkNetCDFReader.vtkNetCDFReader_UpdateMetaData_26(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400072D RID: 1837
		public new const string MRFullTypeName = "Kitware.VTK.vtkNetCDFReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400072E RID: 1838
		public new static readonly string MRClassNameKey = "class vtkNetCDFReader";
	}
}
