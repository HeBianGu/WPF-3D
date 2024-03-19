using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGeoMath
	/// </summary>
	/// <remarks>
	///    Useful geographic calculations
	///
	///
	/// vtkGeoMath provides some useful geographic calculations.
	/// </remarks>
	// Token: 0x02000290 RID: 656
	public class vtkGeoMath : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060076D6 RID: 30422 RVA: 0x000AB657 File Offset: 0x000A9857
		static vtkGeoMath()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoMath.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoMath"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060076D7 RID: 30423 RVA: 0x000AB67F File Offset: 0x000A987F
		public vtkGeoMath(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060076D8 RID: 30424
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeoMath_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060076D9 RID: 30425 RVA: 0x000AB690 File Offset: 0x000A9890
		public new static vtkGeoMath New()
		{
			vtkGeoMath result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeoMath.vtkGeoMath_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoMath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060076DA RID: 30426 RVA: 0x000AB6E4 File Offset: 0x000A98E4
		public vtkGeoMath() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGeoMath.vtkGeoMath_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060076DB RID: 30427 RVA: 0x000AB728 File Offset: 0x000A9928
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060076DC RID: 30428
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGeoMath_DistanceSquared_01(IntPtr pt0, IntPtr pt1);

		/// <summary>
		/// Returns the squared distance between two points.
		/// </summary>
		// Token: 0x060076DD RID: 30429 RVA: 0x000AB734 File Offset: 0x000A9934
		public static double DistanceSquared(IntPtr pt0, IntPtr pt1)
		{
			return vtkGeoMath.vtkGeoMath_DistanceSquared_01(pt0, pt1);
		}

		// Token: 0x060076DE RID: 30430
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGeoMath_EarthRadiusMeters_02();

		/// <summary>
		/// Returns the average radius of the earth in meters.
		/// </summary>
		// Token: 0x060076DF RID: 30431 RVA: 0x000AB750 File Offset: 0x000A9950
		public static double EarthRadiusMeters()
		{
			return vtkGeoMath.vtkGeoMath_EarthRadiusMeters_02();
		}

		// Token: 0x060076E0 RID: 30432
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeoMath_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060076E1 RID: 30433 RVA: 0x000AB76C File Offset: 0x000A996C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGeoMath.vtkGeoMath_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060076E2 RID: 30434
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeoMath_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060076E3 RID: 30435 RVA: 0x000AB78C File Offset: 0x000A998C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGeoMath.vtkGeoMath_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060076E4 RID: 30436
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeoMath_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060076E5 RID: 30437 RVA: 0x000AB7A8 File Offset: 0x000A99A8
		public override int IsA(string type)
		{
			return vtkGeoMath.vtkGeoMath_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060076E6 RID: 30438
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeoMath_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060076E7 RID: 30439 RVA: 0x000AB7C8 File Offset: 0x000A99C8
		public new static int IsTypeOf(string type)
		{
			return vtkGeoMath.vtkGeoMath_IsTypeOf_06(type);
		}

		// Token: 0x060076E8 RID: 30440
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeoMath_LongLatAltToRect_07(IntPtr longLatAlt, IntPtr rect);

		/// <summary>
		/// Converts a (longitude, latitude, altitude) triple to
		/// world coordinates where the center of the earth is at the origin.
		/// Units are in meters.
		/// Note that having altitude relative to sea level causes issues.
		/// </summary>
		// Token: 0x060076E9 RID: 30441 RVA: 0x000AB7E2 File Offset: 0x000A99E2
		public static void LongLatAltToRect(IntPtr longLatAlt, IntPtr rect)
		{
			vtkGeoMath.vtkGeoMath_LongLatAltToRect_07(longLatAlt, rect);
		}

		// Token: 0x060076EA RID: 30442
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeoMath_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060076EB RID: 30443 RVA: 0x000AB7F0 File Offset: 0x000A99F0
		public new vtkGeoMath NewInstance()
		{
			vtkGeoMath result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeoMath.vtkGeoMath_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoMath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060076EC RID: 30444
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeoMath_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060076ED RID: 30445 RVA: 0x000AB84C File Offset: 0x000A9A4C
		public new static vtkGeoMath SafeDownCast(vtkObjectBase o)
		{
			vtkGeoMath vtkGeoMath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeoMath.vtkGeoMath_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoMath = (vtkGeoMath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoMath.Register(null);
				}
			}
			return vtkGeoMath;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A2E RID: 2606
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoMath";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A2F RID: 2607
		public new static readonly string MRClassNameKey = "class vtkGeoMath";
	}
}
