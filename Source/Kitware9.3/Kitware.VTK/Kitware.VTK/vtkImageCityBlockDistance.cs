using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageCityBlockDistance
	/// </summary>
	/// <remarks>
	///    1,2 or 3D distance map.
	///
	/// vtkImageCityBlockDistance creates a distance map using the city block
	/// (Manhatten) distance measure.  The input is a mask.  Zero values are
	/// considered boundaries.  The output pixel is the minimum of the input pixel
	/// and the distance to a boundary (or neighbor value + 1 unit).
	/// distance values are calculated in pixels.
	/// The filter works by taking 6 passes (for 3d distance map): 2 along each
	/// axis (forward and backward). Each pass keeps a running minimum distance.
	/// For some reason, I preserve the sign if the distance.  If the input
	/// mask is initially negative, the output distances will be negative.
	/// Distances maps can have inside (negative regions)
	/// and outsides (positive regions).
	/// </remarks>
	// Token: 0x02000480 RID: 1152
	public class vtkImageCityBlockDistance : vtkImageDecomposeFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D421 RID: 54305 RVA: 0x001272E5 File Offset: 0x001254E5
		static vtkImageCityBlockDistance()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageCityBlockDistance.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageCityBlockDistance"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D422 RID: 54306 RVA: 0x0012730D File Offset: 0x0012550D
		public vtkImageCityBlockDistance(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D423 RID: 54307
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCityBlockDistance_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D424 RID: 54308 RVA: 0x0012731C File Offset: 0x0012551C
		public new static vtkImageCityBlockDistance New()
		{
			vtkImageCityBlockDistance result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCityBlockDistance.vtkImageCityBlockDistance_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCityBlockDistance)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D425 RID: 54309 RVA: 0x00127370 File Offset: 0x00125570
		public vtkImageCityBlockDistance() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageCityBlockDistance.vtkImageCityBlockDistance_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D426 RID: 54310 RVA: 0x001273B4 File Offset: 0x001255B4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D427 RID: 54311
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageCityBlockDistance_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D428 RID: 54312 RVA: 0x001273C0 File Offset: 0x001255C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageCityBlockDistance.vtkImageCityBlockDistance_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600D429 RID: 54313
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageCityBlockDistance_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D42A RID: 54314 RVA: 0x001273E0 File Offset: 0x001255E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageCityBlockDistance.vtkImageCityBlockDistance_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600D42B RID: 54315
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCityBlockDistance_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D42C RID: 54316 RVA: 0x001273FC File Offset: 0x001255FC
		public override int IsA(string type)
		{
			return vtkImageCityBlockDistance.vtkImageCityBlockDistance_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600D42D RID: 54317
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCityBlockDistance_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D42E RID: 54318 RVA: 0x0012741C File Offset: 0x0012561C
		public new static int IsTypeOf(string type)
		{
			return vtkImageCityBlockDistance.vtkImageCityBlockDistance_IsTypeOf_04(type);
		}

		// Token: 0x0600D42F RID: 54319
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCityBlockDistance_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D430 RID: 54320 RVA: 0x00127438 File Offset: 0x00125638
		public new vtkImageCityBlockDistance NewInstance()
		{
			vtkImageCityBlockDistance result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCityBlockDistance.vtkImageCityBlockDistance_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCityBlockDistance)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D431 RID: 54321
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCityBlockDistance_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D432 RID: 54322 RVA: 0x00127494 File Offset: 0x00125694
		public new static vtkImageCityBlockDistance SafeDownCast(vtkObjectBase o)
		{
			vtkImageCityBlockDistance vtkImageCityBlockDistance = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCityBlockDistance.vtkImageCityBlockDistance_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageCityBlockDistance = (vtkImageCityBlockDistance)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageCityBlockDistance.Register(null);
				}
			}
			return vtkImageCityBlockDistance;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FA8 RID: 4008
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageCityBlockDistance";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FA9 RID: 4009
		public new static readonly string MRClassNameKey = "class vtkImageCityBlockDistance";
	}
}
