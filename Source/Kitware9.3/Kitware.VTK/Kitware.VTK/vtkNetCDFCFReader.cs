using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkNetCDFCFReader
	///
	///
	///
	/// Reads netCDF files that follow the CF convention.  Details on this convention
	/// can be found at &lt;http://cf-pcmdi.llnl.gov/&gt;.
	///
	/// </summary>
	// Token: 0x02000170 RID: 368
	public class vtkNetCDFCFReader : vtkNetCDFReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600464E RID: 17998 RVA: 0x0006655B File Offset: 0x0006475B
		static vtkNetCDFCFReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNetCDFCFReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNetCDFCFReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600464F RID: 17999 RVA: 0x00066583 File Offset: 0x00064783
		public vtkNetCDFCFReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004650 RID: 18000
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFCFReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004651 RID: 18001 RVA: 0x00066594 File Offset: 0x00064794
		public new static vtkNetCDFCFReader New()
		{
			vtkNetCDFCFReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFCFReader.vtkNetCDFCFReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNetCDFCFReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004652 RID: 18002 RVA: 0x000665E8 File Offset: 0x000647E8
		public vtkNetCDFCFReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkNetCDFCFReader.vtkNetCDFCFReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004653 RID: 18003 RVA: 0x0006662C File Offset: 0x0006482C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004654 RID: 18004
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFCFReader_CanReadFile_01([MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		/// Returns true if the given file can be read.
		/// </summary>
		// Token: 0x06004655 RID: 18005 RVA: 0x00066638 File Offset: 0x00064838
		public static int CanReadFile(string filename)
		{
			return vtkNetCDFCFReader.vtkNetCDFCFReader_CanReadFile_01(filename);
		}

		// Token: 0x06004656 RID: 18006
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNetCDFCFReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004657 RID: 18007 RVA: 0x00066654 File Offset: 0x00064854
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNetCDFCFReader.vtkNetCDFCFReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06004658 RID: 18008
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNetCDFCFReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004659 RID: 18009 RVA: 0x00066674 File Offset: 0x00064874
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNetCDFCFReader.vtkNetCDFCFReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600465A RID: 18010
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFCFReader_GetOutputType_04(HandleRef pThis);

		/// <summary>
		/// Set/get the data type of the output.  The index used is taken from the list
		/// of VTK data types in vtkType.h.  Valid types are VTK_IMAGE_DATA,
		/// VTK_RECTILINEAR_GRID, VTK_STRUCTURED_GRID, and VTK_UNSTRUCTURED_GRID.  In
		/// addition you can set the type to -1 (the default), and this reader will
		/// pick the data type best suited for the dimensions being read.
		/// </summary>
		// Token: 0x0600465B RID: 18011 RVA: 0x00066690 File Offset: 0x00064890
		public virtual int GetOutputType()
		{
			return vtkNetCDFCFReader.vtkNetCDFCFReader_GetOutputType_04(base.GetCppThis());
		}

		// Token: 0x0600465C RID: 18012
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFCFReader_GetSphericalCoordinates_05(HandleRef pThis);

		/// <summary>
		/// If on (the default), then 3D data with latitude/longitude dimensions
		/// will be read in as curvilinear data shaped like spherical coordinates.
		/// If false, then the data will always be read in Cartesian coordinates.
		/// </summary>
		// Token: 0x0600465D RID: 18013 RVA: 0x000666B0 File Offset: 0x000648B0
		public virtual int GetSphericalCoordinates()
		{
			return vtkNetCDFCFReader.vtkNetCDFCFReader_GetSphericalCoordinates_05(base.GetCppThis());
		}

		// Token: 0x0600465E RID: 18014
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNetCDFCFReader_GetVerticalBias_06(HandleRef pThis);

		/// <summary>
		/// The scale and bias of the vertical component of spherical coordinates.  It
		/// is common to write the vertical component with respect to something other
		/// than the center of the sphere (for example, the surface).  In this case, it
		/// might be necessary to scale and/or bias the vertical height.  The height
		/// will become height*scale + bias.  Keep in mind that if the positive
		/// attribute of the vertical dimension is down, then the height is negated.
		/// By default the scale is 1 and the bias is 0 (that is, no change).  The
		/// scaling will be adjusted if it results in invalid (negative) vertical
		/// values.
		/// </summary>
		// Token: 0x0600465F RID: 18015 RVA: 0x000666D0 File Offset: 0x000648D0
		public virtual double GetVerticalBias()
		{
			return vtkNetCDFCFReader.vtkNetCDFCFReader_GetVerticalBias_06(base.GetCppThis());
		}

		// Token: 0x06004660 RID: 18016
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNetCDFCFReader_GetVerticalScale_07(HandleRef pThis);

		/// <summary>
		/// The scale and bias of the vertical component of spherical coordinates.  It
		/// is common to write the vertical component with respect to something other
		/// than the center of the sphere (for example, the surface).  In this case, it
		/// might be necessary to scale and/or bias the vertical height.  The height
		/// will become height*scale + bias.  Keep in mind that if the positive
		/// attribute of the vertical dimension is down, then the height is negated.
		/// By default the scale is 1 and the bias is 0 (that is, no change).  The
		/// scaling will be adjusted if it results in invalid (negative) vertical
		/// values.
		/// </summary>
		// Token: 0x06004661 RID: 18017 RVA: 0x000666F0 File Offset: 0x000648F0
		public virtual double GetVerticalScale()
		{
			return vtkNetCDFCFReader.vtkNetCDFCFReader_GetVerticalScale_07(base.GetCppThis());
		}

		// Token: 0x06004662 RID: 18018
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFCFReader_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004663 RID: 18019 RVA: 0x00066710 File Offset: 0x00064910
		public override int IsA(string type)
		{
			return vtkNetCDFCFReader.vtkNetCDFCFReader_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06004664 RID: 18020
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFCFReader_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004665 RID: 18021 RVA: 0x00066730 File Offset: 0x00064930
		public new static int IsTypeOf(string type)
		{
			return vtkNetCDFCFReader.vtkNetCDFCFReader_IsTypeOf_09(type);
		}

		// Token: 0x06004666 RID: 18022
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFCFReader_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004667 RID: 18023 RVA: 0x0006674C File Offset: 0x0006494C
		public new vtkNetCDFCFReader NewInstance()
		{
			vtkNetCDFCFReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFCFReader.vtkNetCDFCFReader_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNetCDFCFReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004668 RID: 18024
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFCFReader_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004669 RID: 18025 RVA: 0x000667A8 File Offset: 0x000649A8
		public new static vtkNetCDFCFReader SafeDownCast(vtkObjectBase o)
		{
			vtkNetCDFCFReader vtkNetCDFCFReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFCFReader.vtkNetCDFCFReader_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNetCDFCFReader = (vtkNetCDFCFReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNetCDFCFReader.Register(null);
				}
			}
			return vtkNetCDFCFReader;
		}

		// Token: 0x0600466A RID: 18026
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCFReader_SetOutputType_13(HandleRef pThis, int type);

		/// <summary>
		/// Set/get the data type of the output.  The index used is taken from the list
		/// of VTK data types in vtkType.h.  Valid types are VTK_IMAGE_DATA,
		/// VTK_RECTILINEAR_GRID, VTK_STRUCTURED_GRID, and VTK_UNSTRUCTURED_GRID.  In
		/// addition you can set the type to -1 (the default), and this reader will
		/// pick the data type best suited for the dimensions being read.
		/// </summary>
		// Token: 0x0600466B RID: 18027 RVA: 0x00066827 File Offset: 0x00064A27
		public virtual void SetOutputType(int type)
		{
			vtkNetCDFCFReader.vtkNetCDFCFReader_SetOutputType_13(base.GetCppThis(), type);
		}

		// Token: 0x0600466C RID: 18028
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCFReader_SetOutputTypeToAutomatic_14(HandleRef pThis);

		/// <summary>
		/// Set/get the data type of the output.  The index used is taken from the list
		/// of VTK data types in vtkType.h.  Valid types are VTK_IMAGE_DATA,
		/// VTK_RECTILINEAR_GRID, VTK_STRUCTURED_GRID, and VTK_UNSTRUCTURED_GRID.  In
		/// addition you can set the type to -1 (the default), and this reader will
		/// pick the data type best suited for the dimensions being read.
		/// </summary>
		// Token: 0x0600466D RID: 18029 RVA: 0x00066837 File Offset: 0x00064A37
		public void SetOutputTypeToAutomatic()
		{
			vtkNetCDFCFReader.vtkNetCDFCFReader_SetOutputTypeToAutomatic_14(base.GetCppThis());
		}

		// Token: 0x0600466E RID: 18030
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCFReader_SetOutputTypeToImage_15(HandleRef pThis);

		/// <summary>
		/// Set/get the data type of the output.  The index used is taken from the list
		/// of VTK data types in vtkType.h.  Valid types are VTK_IMAGE_DATA,
		/// VTK_RECTILINEAR_GRID, VTK_STRUCTURED_GRID, and VTK_UNSTRUCTURED_GRID.  In
		/// addition you can set the type to -1 (the default), and this reader will
		/// pick the data type best suited for the dimensions being read.
		/// </summary>
		// Token: 0x0600466F RID: 18031 RVA: 0x00066846 File Offset: 0x00064A46
		public void SetOutputTypeToImage()
		{
			vtkNetCDFCFReader.vtkNetCDFCFReader_SetOutputTypeToImage_15(base.GetCppThis());
		}

		// Token: 0x06004670 RID: 18032
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCFReader_SetOutputTypeToRectilinear_16(HandleRef pThis);

		/// <summary>
		/// Set/get the data type of the output.  The index used is taken from the list
		/// of VTK data types in vtkType.h.  Valid types are VTK_IMAGE_DATA,
		/// VTK_RECTILINEAR_GRID, VTK_STRUCTURED_GRID, and VTK_UNSTRUCTURED_GRID.  In
		/// addition you can set the type to -1 (the default), and this reader will
		/// pick the data type best suited for the dimensions being read.
		/// </summary>
		// Token: 0x06004671 RID: 18033 RVA: 0x00066855 File Offset: 0x00064A55
		public void SetOutputTypeToRectilinear()
		{
			vtkNetCDFCFReader.vtkNetCDFCFReader_SetOutputTypeToRectilinear_16(base.GetCppThis());
		}

		// Token: 0x06004672 RID: 18034
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCFReader_SetOutputTypeToStructured_17(HandleRef pThis);

		/// <summary>
		/// Set/get the data type of the output.  The index used is taken from the list
		/// of VTK data types in vtkType.h.  Valid types are VTK_IMAGE_DATA,
		/// VTK_RECTILINEAR_GRID, VTK_STRUCTURED_GRID, and VTK_UNSTRUCTURED_GRID.  In
		/// addition you can set the type to -1 (the default), and this reader will
		/// pick the data type best suited for the dimensions being read.
		/// </summary>
		// Token: 0x06004673 RID: 18035 RVA: 0x00066864 File Offset: 0x00064A64
		public void SetOutputTypeToStructured()
		{
			vtkNetCDFCFReader.vtkNetCDFCFReader_SetOutputTypeToStructured_17(base.GetCppThis());
		}

		// Token: 0x06004674 RID: 18036
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCFReader_SetOutputTypeToUnstructured_18(HandleRef pThis);

		/// <summary>
		/// Set/get the data type of the output.  The index used is taken from the list
		/// of VTK data types in vtkType.h.  Valid types are VTK_IMAGE_DATA,
		/// VTK_RECTILINEAR_GRID, VTK_STRUCTURED_GRID, and VTK_UNSTRUCTURED_GRID.  In
		/// addition you can set the type to -1 (the default), and this reader will
		/// pick the data type best suited for the dimensions being read.
		/// </summary>
		// Token: 0x06004675 RID: 18037 RVA: 0x00066873 File Offset: 0x00064A73
		public void SetOutputTypeToUnstructured()
		{
			vtkNetCDFCFReader.vtkNetCDFCFReader_SetOutputTypeToUnstructured_18(base.GetCppThis());
		}

		// Token: 0x06004676 RID: 18038
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCFReader_SetSphericalCoordinates_19(HandleRef pThis, int _arg);

		/// <summary>
		/// If on (the default), then 3D data with latitude/longitude dimensions
		/// will be read in as curvilinear data shaped like spherical coordinates.
		/// If false, then the data will always be read in Cartesian coordinates.
		/// </summary>
		// Token: 0x06004677 RID: 18039 RVA: 0x00066882 File Offset: 0x00064A82
		public virtual void SetSphericalCoordinates(int _arg)
		{
			vtkNetCDFCFReader.vtkNetCDFCFReader_SetSphericalCoordinates_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06004678 RID: 18040
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCFReader_SetVerticalBias_20(HandleRef pThis, double _arg);

		/// <summary>
		/// The scale and bias of the vertical component of spherical coordinates.  It
		/// is common to write the vertical component with respect to something other
		/// than the center of the sphere (for example, the surface).  In this case, it
		/// might be necessary to scale and/or bias the vertical height.  The height
		/// will become height*scale + bias.  Keep in mind that if the positive
		/// attribute of the vertical dimension is down, then the height is negated.
		/// By default the scale is 1 and the bias is 0 (that is, no change).  The
		/// scaling will be adjusted if it results in invalid (negative) vertical
		/// values.
		/// </summary>
		// Token: 0x06004679 RID: 18041 RVA: 0x00066892 File Offset: 0x00064A92
		public virtual void SetVerticalBias(double _arg)
		{
			vtkNetCDFCFReader.vtkNetCDFCFReader_SetVerticalBias_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0600467A RID: 18042
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCFReader_SetVerticalScale_21(HandleRef pThis, double _arg);

		/// <summary>
		/// The scale and bias of the vertical component of spherical coordinates.  It
		/// is common to write the vertical component with respect to something other
		/// than the center of the sphere (for example, the surface).  In this case, it
		/// might be necessary to scale and/or bias the vertical height.  The height
		/// will become height*scale + bias.  Keep in mind that if the positive
		/// attribute of the vertical dimension is down, then the height is negated.
		/// By default the scale is 1 and the bias is 0 (that is, no change).  The
		/// scaling will be adjusted if it results in invalid (negative) vertical
		/// values.
		/// </summary>
		// Token: 0x0600467B RID: 18043 RVA: 0x000668A2 File Offset: 0x00064AA2
		public virtual void SetVerticalScale(double _arg)
		{
			vtkNetCDFCFReader.vtkNetCDFCFReader_SetVerticalScale_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600467C RID: 18044
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCFReader_SphericalCoordinatesOff_22(HandleRef pThis);

		/// <summary>
		/// If on (the default), then 3D data with latitude/longitude dimensions
		/// will be read in as curvilinear data shaped like spherical coordinates.
		/// If false, then the data will always be read in Cartesian coordinates.
		/// </summary>
		// Token: 0x0600467D RID: 18045 RVA: 0x000668B2 File Offset: 0x00064AB2
		public virtual void SphericalCoordinatesOff()
		{
			vtkNetCDFCFReader.vtkNetCDFCFReader_SphericalCoordinatesOff_22(base.GetCppThis());
		}

		// Token: 0x0600467E RID: 18046
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCFReader_SphericalCoordinatesOn_23(HandleRef pThis);

		/// <summary>
		/// If on (the default), then 3D data with latitude/longitude dimensions
		/// will be read in as curvilinear data shaped like spherical coordinates.
		/// If false, then the data will always be read in Cartesian coordinates.
		/// </summary>
		// Token: 0x0600467F RID: 18047 RVA: 0x000668C1 File Offset: 0x00064AC1
		public virtual void SphericalCoordinatesOn()
		{
			vtkNetCDFCFReader.vtkNetCDFCFReader_SphericalCoordinatesOn_23(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400072F RID: 1839
		public new const string MRFullTypeName = "Kitware.VTK.vtkNetCDFCFReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000730 RID: 1840
		public new static readonly string MRClassNameKey = "class vtkNetCDFCFReader";
	}
}
