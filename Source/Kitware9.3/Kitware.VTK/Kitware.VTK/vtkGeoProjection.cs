using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGeoProjection
	/// </summary>
	/// <remarks>
	///    Represent a projection from a sphere to a plane
	///
	///
	/// This class uses the PROJ.4 library to represent geographic coordinate
	/// projections.
	/// </remarks>
	// Token: 0x02000275 RID: 629
	public class vtkGeoProjection : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007275 RID: 29301 RVA: 0x000A542B File Offset: 0x000A362B
		static vtkGeoProjection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoProjection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoProjection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007276 RID: 29302 RVA: 0x000A5453 File Offset: 0x000A3653
		public vtkGeoProjection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007277 RID: 29303
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeoProjection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007278 RID: 29304 RVA: 0x000A5464 File Offset: 0x000A3664
		public new static vtkGeoProjection New()
		{
			vtkGeoProjection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeoProjection.vtkGeoProjection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoProjection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007279 RID: 29305 RVA: 0x000A54B8 File Offset: 0x000A36B8
		public vtkGeoProjection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGeoProjection.vtkGeoProjection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600727A RID: 29306 RVA: 0x000A54FC File Offset: 0x000A36FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600727B RID: 29307
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeoProjection_ClearOptionalParameters_01(HandleRef pThis);

		/// <summary>
		/// Clear all optional parameters
		/// </summary>
		// Token: 0x0600727C RID: 29308 RVA: 0x000A5507 File Offset: 0x000A3707
		public void ClearOptionalParameters()
		{
			vtkGeoProjection.vtkGeoProjection_ClearOptionalParameters_01(base.GetCppThis());
		}

		// Token: 0x0600727D RID: 29309
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGeoProjection_GetCentralMeridian_02(HandleRef pThis);

		/// <summary>
		/// Set/get the longitude which corresponds to the central meridian of the projection.
		/// This defaults to 0, the Greenwich Meridian.
		/// </summary>
		// Token: 0x0600727E RID: 29310 RVA: 0x000A5518 File Offset: 0x000A3718
		public virtual double GetCentralMeridian()
		{
			return vtkGeoProjection.vtkGeoProjection_GetCentralMeridian_02(base.GetCppThis());
		}

		// Token: 0x0600727F RID: 29311
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeoProjection_GetDescription_03(HandleRef pThis);

		/// <summary>
		/// Get the description of a projection.
		/// This will return nullptr if the projection name is invalid.
		/// </summary>
		// Token: 0x06007280 RID: 29312 RVA: 0x000A5538 File Offset: 0x000A3738
		public string GetDescription()
		{
			string s = Marshal.PtrToStringAnsi(vtkGeoProjection.vtkGeoProjection_GetDescription_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007281 RID: 29313
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeoProjection_GetIndex_04(HandleRef pThis);

		/// <summary>
		/// Return the index of the current projection's type in the list of all projection types.
		/// On error, this will return -1. On success, it returns a number in [0,GetNumberOfProjections()[.
		/// </summary>
		// Token: 0x06007282 RID: 29314 RVA: 0x000A5574 File Offset: 0x000A3774
		public int GetIndex()
		{
			return vtkGeoProjection.vtkGeoProjection_GetIndex_04(base.GetCppThis());
		}

		// Token: 0x06007283 RID: 29315
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeoProjection_GetName_05(HandleRef pThis);

		/// <summary>
		/// Set/get the short name describing the projection you wish to use.
		/// This defaults to "latlong".
		/// To get a list of valid values, use the GetNumberOfProjections() and
		/// GetProjectionName(int) static methods.
		/// </summary>
		// Token: 0x06007284 RID: 29316 RVA: 0x000A5594 File Offset: 0x000A3794
		public virtual string GetName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGeoProjection.vtkGeoProjection_GetName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007285 RID: 29317
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeoProjection_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007286 RID: 29318 RVA: 0x000A55D0 File Offset: 0x000A37D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGeoProjection.vtkGeoProjection_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06007287 RID: 29319
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeoProjection_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007288 RID: 29320 RVA: 0x000A55F0 File Offset: 0x000A37F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGeoProjection.vtkGeoProjection_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06007289 RID: 29321
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeoProjection_GetNumberOfOptionalParameters_08(HandleRef pThis);

		/// <summary>
		/// Return the number of optional parameters
		/// </summary>
		// Token: 0x0600728A RID: 29322 RVA: 0x000A560C File Offset: 0x000A380C
		public int GetNumberOfOptionalParameters()
		{
			return vtkGeoProjection.vtkGeoProjection_GetNumberOfOptionalParameters_08(base.GetCppThis());
		}

		// Token: 0x0600728B RID: 29323
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeoProjection_GetNumberOfProjections_09();

		/// <summary>
		/// Returns the number of projections that this class offers.
		/// </summary>
		// Token: 0x0600728C RID: 29324 RVA: 0x000A562C File Offset: 0x000A382C
		public static int GetNumberOfProjections()
		{
			return vtkGeoProjection.vtkGeoProjection_GetNumberOfProjections_09();
		}

		// Token: 0x0600728D RID: 29325
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeoProjection_GetOptionalParameterKey_10(HandleRef pThis, int index);

		/// <summary>
		/// Return the number of optional parameters
		/// </summary>
		// Token: 0x0600728E RID: 29326 RVA: 0x000A5648 File Offset: 0x000A3848
		public string GetOptionalParameterKey(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkGeoProjection.vtkGeoProjection_GetOptionalParameterKey_10(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600728F RID: 29327
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeoProjection_GetOptionalParameterValue_11(HandleRef pThis, int index);

		/// <summary>
		/// Return the number of optional parameters
		/// </summary>
		// Token: 0x06007290 RID: 29328 RVA: 0x000A5684 File Offset: 0x000A3884
		public string GetOptionalParameterValue(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkGeoProjection.vtkGeoProjection_GetOptionalParameterValue_11(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007291 RID: 29329
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeoProjection_GetPROJ4String_12(HandleRef pThis);

		/// <summary>
		/// Set/Get/Clear projection string in PROJ.4 format.
		/// This is a special case alternative to setting the projection name and
		/// specifying parameters.
		///
		/// \note If the PROJ4String is not empty, it supersedes the other parameters
		/// and is used explicitly to instantiate the `projPJ` projection object.
		/// </summary>
		// Token: 0x06007292 RID: 29330 RVA: 0x000A56C0 File Offset: 0x000A38C0
		public virtual string GetPROJ4String()
		{
			string s = Marshal.PtrToStringAnsi(vtkGeoProjection.vtkGeoProjection_GetPROJ4String_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007293 RID: 29331
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeoProjection_GetProjectionDescription_13(int projection);

		/// <summary>
		/// Returns a description of one of the projections supported by this class.
		/// @param projection the index of a projection, must be in [0,GetNumberOfProjections()[.
		/// </summary>
		// Token: 0x06007294 RID: 29332 RVA: 0x000A56FC File Offset: 0x000A38FC
		public static string GetProjectionDescription(int projection)
		{
			string s = Marshal.PtrToStringAnsi(vtkGeoProjection.vtkGeoProjection_GetProjectionDescription_13(projection));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007295 RID: 29333
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeoProjection_GetProjectionName_14(int projection);

		/// <summary>
		/// Returns the name of one of the projections supported by this class.
		/// You can pass these strings to SetName(char*).
		/// @param projection the index of a projection, must be in [0,GetNumberOfProjections()[.
		/// </summary>
		// Token: 0x06007296 RID: 29334 RVA: 0x000A5734 File Offset: 0x000A3934
		public static string GetProjectionName(int projection)
		{
			string s = Marshal.PtrToStringAnsi(vtkGeoProjection.vtkGeoProjection_GetProjectionName_14(projection));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007297 RID: 29335
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeoProjection_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007298 RID: 29336 RVA: 0x000A576C File Offset: 0x000A396C
		public override int IsA(string type)
		{
			return vtkGeoProjection.vtkGeoProjection_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x06007299 RID: 29337
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeoProjection_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600729A RID: 29338 RVA: 0x000A578C File Offset: 0x000A398C
		public new static int IsTypeOf(string type)
		{
			return vtkGeoProjection.vtkGeoProjection_IsTypeOf_16(type);
		}

		// Token: 0x0600729B RID: 29339
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeoProjection_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600729C RID: 29340 RVA: 0x000A57A8 File Offset: 0x000A39A8
		public new vtkGeoProjection NewInstance()
		{
			vtkGeoProjection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeoProjection.vtkGeoProjection_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoProjection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600729D RID: 29341
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeoProjection_RemoveOptionalParameter_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Remove an optional parameter to the projection that will be computed
		/// </summary>
		// Token: 0x0600729E RID: 29342 RVA: 0x000A5802 File Offset: 0x000A3A02
		public void RemoveOptionalParameter(string arg0)
		{
			vtkGeoProjection.vtkGeoProjection_RemoveOptionalParameter_19(base.GetCppThis(), arg0);
		}

		// Token: 0x0600729F RID: 29343
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeoProjection_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060072A0 RID: 29344 RVA: 0x000A5814 File Offset: 0x000A3A14
		public new static vtkGeoProjection SafeDownCast(vtkObjectBase o)
		{
			vtkGeoProjection vtkGeoProjection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeoProjection.vtkGeoProjection_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoProjection = (vtkGeoProjection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoProjection.Register(null);
				}
			}
			return vtkGeoProjection;
		}

		// Token: 0x060072A1 RID: 29345
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeoProjection_SetCentralMeridian_21(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the longitude which corresponds to the central meridian of the projection.
		/// This defaults to 0, the Greenwich Meridian.
		/// </summary>
		// Token: 0x060072A2 RID: 29346 RVA: 0x000A5893 File Offset: 0x000A3A93
		public virtual void SetCentralMeridian(double _arg)
		{
			vtkGeoProjection.vtkGeoProjection_SetCentralMeridian_21(base.GetCppThis(), _arg);
		}

		// Token: 0x060072A3 RID: 29347
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeoProjection_SetName_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the short name describing the projection you wish to use.
		/// This defaults to "latlong".
		/// To get a list of valid values, use the GetNumberOfProjections() and
		/// GetProjectionName(int) static methods.
		/// </summary>
		// Token: 0x060072A4 RID: 29348 RVA: 0x000A58A3 File Offset: 0x000A3AA3
		public virtual void SetName(string _arg)
		{
			vtkGeoProjection.vtkGeoProjection_SetName_22(base.GetCppThis(), _arg);
		}

		// Token: 0x060072A5 RID: 29349
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeoProjection_SetOptionalParameter_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string key, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);

		/// <summary>
		/// Add an optional parameter to the projection that will be computed or
		/// replace it if already present.
		/// </summary>
		// Token: 0x060072A6 RID: 29350 RVA: 0x000A58B3 File Offset: 0x000A3AB3
		public void SetOptionalParameter(string key, string value)
		{
			vtkGeoProjection.vtkGeoProjection_SetOptionalParameter_23(base.GetCppThis(), key, value);
		}

		// Token: 0x060072A7 RID: 29351
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeoProjection_SetPROJ4String_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get/Clear projection string in PROJ.4 format.
		/// This is a special case alternative to setting the projection name and
		/// specifying parameters.
		///
		/// \note If the PROJ4String is not empty, it supersedes the other parameters
		/// and is used explicitly to instantiate the `projPJ` projection object.
		/// </summary>
		// Token: 0x060072A8 RID: 29352 RVA: 0x000A58C4 File Offset: 0x000A3AC4
		public virtual void SetPROJ4String(string _arg)
		{
			vtkGeoProjection.vtkGeoProjection_SetPROJ4String_24(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009F8 RID: 2552
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoProjection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009F9 RID: 2553
		public new static readonly string MRClassNameKey = "class vtkGeoProjection";
	}
}
