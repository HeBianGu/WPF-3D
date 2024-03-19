using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDEMReader
	/// </summary>
	/// <remarks>
	///    read a digital elevation model (DEM) file
	///
	/// vtkDEMReader reads digital elevation files and creates image data.
	/// Digital elevation files are produced by the
	/// &lt;A HREF="http://www.usgs.gov"&gt;US Geological Survey&lt;/A&gt;.
	/// A complete description of the DEM file is located at the USGS site.
	/// The reader reads the entire dem file and create a vtkImageData that
	/// contains a single scalar component that is the elevation in meters.
	/// The spacing is also expressed in meters. A number of get methods
	/// provide access to fields on the header.
	/// </remarks>
	// Token: 0x0200075E RID: 1886
	public class vtkDEMReader : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601395D RID: 80221 RVA: 0x001BADA9 File Offset: 0x001B8FA9
		static vtkDEMReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDEMReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDEMReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601395E RID: 80222 RVA: 0x001BADD1 File Offset: 0x001B8FD1
		public vtkDEMReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601395F RID: 80223
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDEMReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013960 RID: 80224 RVA: 0x001BADE0 File Offset: 0x001B8FE0
		public new static vtkDEMReader New()
		{
			vtkDEMReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDEMReader.vtkDEMReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDEMReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013961 RID: 80225 RVA: 0x001BAE34 File Offset: 0x001B9034
		public vtkDEMReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDEMReader.vtkDEMReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013962 RID: 80226 RVA: 0x001BAE78 File Offset: 0x001B9078
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013963 RID: 80227
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDEMReader_GetAccuracyCode_01(HandleRef pThis);

		/// <summary>
		/// Accuracy code for elevations. 0=unknown accuracy
		/// </summary>
		// Token: 0x06013964 RID: 80228 RVA: 0x001BAE84 File Offset: 0x001B9084
		public virtual int GetAccuracyCode()
		{
			return vtkDEMReader.vtkDEMReader_GetAccuracyCode_01(base.GetCppThis());
		}

		// Token: 0x06013965 RID: 80229
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDEMReader_GetDEMLevel_02(HandleRef pThis);

		/// <summary>
		/// Code 1=DEM-1, 2=DEM_2, ...
		/// </summary>
		// Token: 0x06013966 RID: 80230 RVA: 0x001BAEA4 File Offset: 0x001B90A4
		public virtual int GetDEMLevel()
		{
			return vtkDEMReader.vtkDEMReader_GetDEMLevel_02(base.GetCppThis());
		}

		// Token: 0x06013967 RID: 80231
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDEMReader_GetElevationBounds_03(HandleRef pThis);

		/// <summary>
		/// Minimum and maximum elevation for the DEM. The units in the file
		/// are in ElevationUnitOfMeasure. This class converts them to meters.
		/// </summary>
		// Token: 0x06013968 RID: 80232 RVA: 0x001BAEC4 File Offset: 0x001B90C4
		public virtual float[] GetElevationBounds()
		{
			IntPtr intPtr = vtkDEMReader.vtkDEMReader_GetElevationBounds_03(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013969 RID: 80233
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDEMReader_GetElevationBounds_04(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Minimum and maximum elevation for the DEM. The units in the file
		/// are in ElevationUnitOfMeasure. This class converts them to meters.
		/// </summary>
		// Token: 0x0601396A RID: 80234 RVA: 0x001BAF0C File Offset: 0x001B910C
		public virtual void GetElevationBounds(IntPtr data)
		{
			vtkDEMReader.vtkDEMReader_GetElevationBounds_04(base.GetCppThis(), data);
		}

		// Token: 0x0601396B RID: 80235
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDEMReader_GetElevationPattern_05(HandleRef pThis);

		/// <summary>
		/// Code 1=regular, 2=random, reserved for future use
		/// </summary>
		// Token: 0x0601396C RID: 80236 RVA: 0x001BAF1C File Offset: 0x001B911C
		public virtual int GetElevationPattern()
		{
			return vtkDEMReader.vtkDEMReader_GetElevationPattern_05(base.GetCppThis());
		}

		// Token: 0x0601396D RID: 80237
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDEMReader_GetElevationReference_06(HandleRef pThis);

		/// <summary>
		/// Specify the elevation origin to use. By default, the elevation origin
		/// is equal to ElevationBounds[0]. A more convenient origin is to use sea
		/// level (i.e., a value of 0.0).
		/// </summary>
		// Token: 0x0601396E RID: 80238 RVA: 0x001BAF3C File Offset: 0x001B913C
		public virtual int GetElevationReference()
		{
			return vtkDEMReader.vtkDEMReader_GetElevationReference_06(base.GetCppThis());
		}

		// Token: 0x0601396F RID: 80239
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDEMReader_GetElevationReferenceAsString_07(HandleRef pThis);

		/// <summary>
		/// Specify the elevation origin to use. By default, the elevation origin
		/// is equal to ElevationBounds[0]. A more convenient origin is to use sea
		/// level (i.e., a value of 0.0).
		/// </summary>
		// Token: 0x06013970 RID: 80240 RVA: 0x001BAF5C File Offset: 0x001B915C
		public string GetElevationReferenceAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkDEMReader.vtkDEMReader_GetElevationReferenceAsString_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013971 RID: 80241
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDEMReader_GetElevationReferenceMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Specify the elevation origin to use. By default, the elevation origin
		/// is equal to ElevationBounds[0]. A more convenient origin is to use sea
		/// level (i.e., a value of 0.0).
		/// </summary>
		// Token: 0x06013972 RID: 80242 RVA: 0x001BAF98 File Offset: 0x001B9198
		public virtual int GetElevationReferenceMaxValue()
		{
			return vtkDEMReader.vtkDEMReader_GetElevationReferenceMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06013973 RID: 80243
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDEMReader_GetElevationReferenceMinValue_09(HandleRef pThis);

		/// <summary>
		/// Specify the elevation origin to use. By default, the elevation origin
		/// is equal to ElevationBounds[0]. A more convenient origin is to use sea
		/// level (i.e., a value of 0.0).
		/// </summary>
		// Token: 0x06013974 RID: 80244 RVA: 0x001BAFB8 File Offset: 0x001B91B8
		public virtual int GetElevationReferenceMinValue()
		{
			return vtkDEMReader.vtkDEMReader_GetElevationReferenceMinValue_09(base.GetCppThis());
		}

		// Token: 0x06013975 RID: 80245
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDEMReader_GetElevationUnitOfMeasure_10(HandleRef pThis);

		/// <summary>
		/// Defining unit of measure for elevation coordinates throughout
		/// the file. 1 = feet, 2 = meters
		/// </summary>
		// Token: 0x06013976 RID: 80246 RVA: 0x001BAFD8 File Offset: 0x001B91D8
		public virtual int GetElevationUnitOfMeasure()
		{
			return vtkDEMReader.vtkDEMReader_GetElevationUnitOfMeasure_10(base.GetCppThis());
		}

		// Token: 0x06013977 RID: 80247
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDEMReader_GetFileName_11(HandleRef pThis);

		/// <summary>
		/// Specify file name of Digital Elevation Model (DEM) file
		/// </summary>
		// Token: 0x06013978 RID: 80248 RVA: 0x001BAFF8 File Offset: 0x001B91F8
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDEMReader.vtkDEMReader_GetFileName_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013979 RID: 80249
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDEMReader_GetGroundSystem_12(HandleRef pThis);

		/// <summary>
		/// Ground planimetric reference system
		/// </summary>
		// Token: 0x0601397A RID: 80250 RVA: 0x001BB034 File Offset: 0x001B9234
		public virtual int GetGroundSystem()
		{
			return vtkDEMReader.vtkDEMReader_GetGroundSystem_12(base.GetCppThis());
		}

		// Token: 0x0601397B RID: 80251
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDEMReader_GetGroundZone_13(HandleRef pThis);

		/// <summary>
		/// Zone in ground planimetric reference system
		/// </summary>
		// Token: 0x0601397C RID: 80252 RVA: 0x001BB054 File Offset: 0x001B9254
		public virtual int GetGroundZone()
		{
			return vtkDEMReader.vtkDEMReader_GetGroundZone_13(base.GetCppThis());
		}

		// Token: 0x0601397D RID: 80253
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkDEMReader_GetLocalRotation_14(HandleRef pThis);

		/// <summary>
		/// Counterclockwise angle (in radians) from the primary axis of the planimetric
		/// reference to the primary axis of the DEM local reference system.
		/// IGNORED BY THIS IMPLEMENTATION.
		/// </summary>
		// Token: 0x0601397E RID: 80254 RVA: 0x001BB074 File Offset: 0x001B9274
		public virtual float GetLocalRotation()
		{
			return vtkDEMReader.vtkDEMReader_GetLocalRotation_14(base.GetCppThis());
		}

		// Token: 0x0601397F RID: 80255
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDEMReader_GetMapLabel_15(HandleRef pThis);

		/// <summary>
		/// An ASCII description of the map
		/// </summary>
		// Token: 0x06013980 RID: 80256 RVA: 0x001BB094 File Offset: 0x001B9294
		public virtual string GetMapLabel()
		{
			string s = Marshal.PtrToStringAnsi(vtkDEMReader.vtkDEMReader_GetMapLabel_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013981 RID: 80257
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDEMReader_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013982 RID: 80258 RVA: 0x001BB0D0 File Offset: 0x001B92D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDEMReader.vtkDEMReader_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x06013983 RID: 80259
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDEMReader_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013984 RID: 80260 RVA: 0x001BB0F0 File Offset: 0x001B92F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDEMReader.vtkDEMReader_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x06013985 RID: 80261
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDEMReader_GetPlaneUnitOfMeasure_18(HandleRef pThis);

		/// <summary>
		/// Defining unit of measure for ground planimetric coordinates throughout
		/// the file. 0 = radians, 1 = feet, 2 = meters, 3 = arc-seconds.
		/// </summary>
		// Token: 0x06013986 RID: 80262 RVA: 0x001BB10C File Offset: 0x001B930C
		public virtual int GetPlaneUnitOfMeasure()
		{
			return vtkDEMReader.vtkDEMReader_GetPlaneUnitOfMeasure_18(base.GetCppThis());
		}

		// Token: 0x06013987 RID: 80263
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDEMReader_GetPolygonSize_19(HandleRef pThis);

		/// <summary>
		/// Number of sides in the polygon which defines the coverage of
		/// the DEM file. Set to 4.
		/// </summary>
		// Token: 0x06013988 RID: 80264 RVA: 0x001BB12C File Offset: 0x001B932C
		public virtual int GetPolygonSize()
		{
			return vtkDEMReader.vtkDEMReader_GetPolygonSize_19(base.GetCppThis());
		}

		// Token: 0x06013989 RID: 80265
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDEMReader_GetProfileDimension_20(HandleRef pThis);

		/// <summary>
		/// The number of rows and columns in the DEM.
		/// </summary>
		// Token: 0x0601398A RID: 80266 RVA: 0x001BB14C File Offset: 0x001B934C
		public virtual int[] GetProfileDimension()
		{
			IntPtr intPtr = vtkDEMReader.vtkDEMReader_GetProfileDimension_20(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601398B RID: 80267
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDEMReader_GetProfileDimension_21(HandleRef pThis, IntPtr data);

		/// <summary>
		/// The number of rows and columns in the DEM.
		/// </summary>
		// Token: 0x0601398C RID: 80268 RVA: 0x001BB194 File Offset: 0x001B9394
		public virtual void GetProfileDimension(IntPtr data)
		{
			vtkDEMReader.vtkDEMReader_GetProfileDimension_21(base.GetCppThis(), data);
		}

		// Token: 0x0601398D RID: 80269
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDEMReader_GetProjectionParameters_22(HandleRef pThis);

		/// <summary>
		/// Map Projection parameters. All are zero.
		/// </summary>
		// Token: 0x0601398E RID: 80270 RVA: 0x001BB1A4 File Offset: 0x001B93A4
		public virtual float[] GetProjectionParameters()
		{
			IntPtr intPtr = vtkDEMReader.vtkDEMReader_GetProjectionParameters_22(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[5];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601398F RID: 80271
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDEMReader_GetProjectionParameters_23(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Map Projection parameters. All are zero.
		/// </summary>
		// Token: 0x06013990 RID: 80272 RVA: 0x001BB1EC File Offset: 0x001B93EC
		public virtual void GetProjectionParameters(IntPtr data)
		{
			vtkDEMReader.vtkDEMReader_GetProjectionParameters_23(base.GetCppThis(), data);
		}

		// Token: 0x06013991 RID: 80273
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDEMReader_GetSpatialResolution_24(HandleRef pThis);

		/// <summary>
		/// DEM spatial resolution for x,y,z. Values are expressed in units of resolution.
		/// Since elevations are read as integers, this permits fractional elevations.
		/// </summary>
		// Token: 0x06013992 RID: 80274 RVA: 0x001BB1FC File Offset: 0x001B93FC
		public virtual float[] GetSpatialResolution()
		{
			IntPtr intPtr = vtkDEMReader.vtkDEMReader_GetSpatialResolution_24(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013993 RID: 80275
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDEMReader_GetSpatialResolution_25(HandleRef pThis, IntPtr data);

		/// <summary>
		/// DEM spatial resolution for x,y,z. Values are expressed in units of resolution.
		/// Since elevations are read as integers, this permits fractional elevations.
		/// </summary>
		// Token: 0x06013994 RID: 80276 RVA: 0x001BB244 File Offset: 0x001B9444
		public virtual void GetSpatialResolution(IntPtr data)
		{
			vtkDEMReader.vtkDEMReader_GetSpatialResolution_25(base.GetCppThis(), data);
		}

		// Token: 0x06013995 RID: 80277
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDEMReader_IsA_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013996 RID: 80278 RVA: 0x001BB254 File Offset: 0x001B9454
		public override int IsA(string type)
		{
			return vtkDEMReader.vtkDEMReader_IsA_26(base.GetCppThis(), type);
		}

		// Token: 0x06013997 RID: 80279
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDEMReader_IsTypeOf_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013998 RID: 80280 RVA: 0x001BB274 File Offset: 0x001B9474
		public new static int IsTypeOf(string type)
		{
			return vtkDEMReader.vtkDEMReader_IsTypeOf_27(type);
		}

		// Token: 0x06013999 RID: 80281
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDEMReader_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601399A RID: 80282 RVA: 0x001BB290 File Offset: 0x001B9490
		public new vtkDEMReader NewInstance()
		{
			vtkDEMReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDEMReader.vtkDEMReader_NewInstance_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDEMReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601399B RID: 80283
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDEMReader_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601399C RID: 80284 RVA: 0x001BB2EC File Offset: 0x001B94EC
		public new static vtkDEMReader SafeDownCast(vtkObjectBase o)
		{
			vtkDEMReader vtkDEMReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDEMReader.vtkDEMReader_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDEMReader = (vtkDEMReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDEMReader.Register(null);
				}
			}
			return vtkDEMReader;
		}

		// Token: 0x0601399D RID: 80285
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDEMReader_SetElevationReference_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the elevation origin to use. By default, the elevation origin
		/// is equal to ElevationBounds[0]. A more convenient origin is to use sea
		/// level (i.e., a value of 0.0).
		/// </summary>
		// Token: 0x0601399E RID: 80286 RVA: 0x001BB36B File Offset: 0x001B956B
		public virtual void SetElevationReference(int _arg)
		{
			vtkDEMReader.vtkDEMReader_SetElevationReference_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0601399F RID: 80287
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDEMReader_SetElevationReferenceToElevationBounds_32(HandleRef pThis);

		/// <summary>
		/// Specify the elevation origin to use. By default, the elevation origin
		/// is equal to ElevationBounds[0]. A more convenient origin is to use sea
		/// level (i.e., a value of 0.0).
		/// </summary>
		// Token: 0x060139A0 RID: 80288 RVA: 0x001BB37B File Offset: 0x001B957B
		public void SetElevationReferenceToElevationBounds()
		{
			vtkDEMReader.vtkDEMReader_SetElevationReferenceToElevationBounds_32(base.GetCppThis());
		}

		// Token: 0x060139A1 RID: 80289
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDEMReader_SetElevationReferenceToSeaLevel_33(HandleRef pThis);

		/// <summary>
		/// Specify the elevation origin to use. By default, the elevation origin
		/// is equal to ElevationBounds[0]. A more convenient origin is to use sea
		/// level (i.e., a value of 0.0).
		/// </summary>
		// Token: 0x060139A2 RID: 80290 RVA: 0x001BB38A File Offset: 0x001B958A
		public void SetElevationReferenceToSeaLevel()
		{
			vtkDEMReader.vtkDEMReader_SetElevationReferenceToSeaLevel_33(base.GetCppThis());
		}

		// Token: 0x060139A3 RID: 80291
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDEMReader_SetFileName_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file name of Digital Elevation Model (DEM) file
		/// </summary>
		// Token: 0x060139A4 RID: 80292 RVA: 0x001BB399 File Offset: 0x001B9599
		public virtual void SetFileName(string _arg)
		{
			vtkDEMReader.vtkDEMReader_SetFileName_34(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001699 RID: 5785
		public new const string MRFullTypeName = "Kitware.VTK.vtkDEMReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400169A RID: 5786
		public new static readonly string MRClassNameKey = "class vtkDEMReader";

		/// <summary>
		/// Specify file name of Digital Elevation Model (DEM) file
		/// </summary>
		// Token: 0x0200075F RID: 1887
		public enum REFERENCE_ELEVATION_BOUNDS_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400169C RID: 5788
			REFERENCE_ELEVATION_BOUNDS = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400169D RID: 5789
			REFERENCE_SEA_LEVEL = 0
		}
	}
}
