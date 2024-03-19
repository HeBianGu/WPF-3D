using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGeoTransform
	/// </summary>
	/// <remarks>
	///    A transformation between two geographic coordinate systems
	///
	/// This class takes two geographic projections and transforms point
	/// coordinates between them.
	/// </remarks>
	// Token: 0x02000277 RID: 631
	public class vtkGeoTransform : vtkAbstractTransform
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060072EB RID: 29419 RVA: 0x000A6071 File Offset: 0x000A4271
		static vtkGeoTransform()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoTransform"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060072EC RID: 29420 RVA: 0x000A6099 File Offset: 0x000A4299
		public vtkGeoTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060072ED RID: 29421
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeoTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060072EE RID: 29422 RVA: 0x000A60A8 File Offset: 0x000A42A8
		public new static vtkGeoTransform New()
		{
			vtkGeoTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeoTransform.vtkGeoTransform_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060072EF RID: 29423 RVA: 0x000A60FC File Offset: 0x000A42FC
		public vtkGeoTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGeoTransform.vtkGeoTransform_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060072F0 RID: 29424 RVA: 0x000A6140 File Offset: 0x000A4340
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060072F1 RID: 29425
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeoTransform_ComputeUTMZone_01(double lon, double lat);

		/// <summary>
		/// Computes Universal Transverse Mercator (UTM) zone given the
		/// longitude and latitude of the point.
		/// It correctly computes the zones in the two exception areas.
		/// It returns an integer between 1 and 60 for valid long lat, or 0 otherwise.
		///
		/// </summary>
		// Token: 0x060072F2 RID: 29426 RVA: 0x000A614C File Offset: 0x000A434C
		public static int ComputeUTMZone(double lon, double lat)
		{
			return vtkGeoTransform.vtkGeoTransform_ComputeUTMZone_01(lon, lat);
		}

		// Token: 0x060072F3 RID: 29427
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeoTransform_ComputeUTMZone_02(IntPtr lonlat);

		/// <summary>
		/// Computes Universal Transverse Mercator (UTM) zone given the
		/// longitude and latitude of the point.
		/// It correctly computes the zones in the two exception areas.
		/// It returns an integer between 1 and 60 for valid long lat, or 0 otherwise.
		///
		/// </summary>
		// Token: 0x060072F4 RID: 29428 RVA: 0x000A6168 File Offset: 0x000A4368
		public static int ComputeUTMZone(IntPtr lonlat)
		{
			return vtkGeoTransform.vtkGeoTransform_ComputeUTMZone_02(lonlat);
		}

		// Token: 0x060072F5 RID: 29429
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeoTransform_GetDestinationProjection_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The target geographic projection.
		/// </summary>
		// Token: 0x060072F6 RID: 29430 RVA: 0x000A6184 File Offset: 0x000A4384
		public virtual vtkGeoProjection GetDestinationProjection()
		{
			vtkGeoProjection vtkGeoProjection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeoTransform.vtkGeoTransform_GetDestinationProjection_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060072F7 RID: 29431
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeoTransform_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060072F8 RID: 29432 RVA: 0x000A61F4 File Offset: 0x000A43F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGeoTransform.vtkGeoTransform_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060072F9 RID: 29433
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeoTransform_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060072FA RID: 29434 RVA: 0x000A6214 File Offset: 0x000A4414
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGeoTransform.vtkGeoTransform_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060072FB RID: 29435
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeoTransform_GetSourceProjection_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The source geographic projection.
		/// </summary>
		// Token: 0x060072FC RID: 29436 RVA: 0x000A6230 File Offset: 0x000A4430
		public virtual vtkGeoProjection GetSourceProjection()
		{
			vtkGeoProjection vtkGeoProjection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeoTransform.vtkGeoTransform_GetSourceProjection_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060072FD RID: 29437
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeoTransform_InternalTransformPoint_07(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// This will calculate the transformation without calling Update.
		/// Meant for use only within other VTK classes.
		/// </summary>
		// Token: 0x060072FE RID: 29438 RVA: 0x000A629F File Offset: 0x000A449F
		public override void InternalTransformPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkGeoTransform.vtkGeoTransform_InternalTransformPoint_07(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x060072FF RID: 29439
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeoTransform_Inverse_08(HandleRef pThis);

		/// <summary>
		/// Invert the transformation.
		/// </summary>
		// Token: 0x06007300 RID: 29440 RVA: 0x000A62B0 File Offset: 0x000A44B0
		public override void Inverse()
		{
			vtkGeoTransform.vtkGeoTransform_Inverse_08(base.GetCppThis());
		}

		// Token: 0x06007301 RID: 29441
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeoTransform_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007302 RID: 29442 RVA: 0x000A62C0 File Offset: 0x000A44C0
		public override int IsA(string type)
		{
			return vtkGeoTransform.vtkGeoTransform_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06007303 RID: 29443
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeoTransform_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007304 RID: 29444 RVA: 0x000A62E0 File Offset: 0x000A44E0
		public new static int IsTypeOf(string type)
		{
			return vtkGeoTransform.vtkGeoTransform_IsTypeOf_10(type);
		}

		// Token: 0x06007305 RID: 29445
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeoTransform_MakeTransform_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Make another transform of the same type.
		/// </summary>
		// Token: 0x06007306 RID: 29446 RVA: 0x000A62FC File Offset: 0x000A44FC
		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeoTransform.vtkGeoTransform_MakeTransform_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007307 RID: 29447
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeoTransform_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007308 RID: 29448 RVA: 0x000A6358 File Offset: 0x000A4558
		public new vtkGeoTransform NewInstance()
		{
			vtkGeoTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeoTransform.vtkGeoTransform_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007309 RID: 29449
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeoTransform_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600730A RID: 29450 RVA: 0x000A63B4 File Offset: 0x000A45B4
		public new static vtkGeoTransform SafeDownCast(vtkObjectBase o)
		{
			vtkGeoTransform vtkGeoTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeoTransform.vtkGeoTransform_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoTransform = (vtkGeoTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoTransform.Register(null);
				}
			}
			return vtkGeoTransform;
		}

		// Token: 0x0600730B RID: 29451
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeoTransform_SetDestinationProjection_15(HandleRef pThis, HandleRef dest);

		/// <summary>
		/// The target geographic projection.
		/// </summary>
		// Token: 0x0600730C RID: 29452 RVA: 0x000A6434 File Offset: 0x000A4634
		public void SetDestinationProjection(vtkGeoProjection dest)
		{
			vtkGeoTransform.vtkGeoTransform_SetDestinationProjection_15(base.GetCppThis(), (dest == null) ? default(HandleRef) : dest.GetCppThis());
		}

		// Token: 0x0600730D RID: 29453
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeoTransform_SetSourceProjection_16(HandleRef pThis, HandleRef source);

		/// <summary>
		/// The source geographic projection.
		/// </summary>
		// Token: 0x0600730E RID: 29454 RVA: 0x000A6464 File Offset: 0x000A4664
		public void SetSourceProjection(vtkGeoProjection source)
		{
			vtkGeoTransform.vtkGeoTransform_SetSourceProjection_16(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0600730F RID: 29455
		[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeoTransform_TransformPoints_17(HandleRef pThis, HandleRef src, HandleRef dst);

		/// <summary>
		/// Transform many points at once.
		/// </summary>
		// Token: 0x06007310 RID: 29456 RVA: 0x000A6494 File Offset: 0x000A4694
		public override void TransformPoints(vtkPoints src, vtkPoints dst)
		{
			vtkGeoTransform.vtkGeoTransform_TransformPoints_17(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis(), (dst == null) ? default(HandleRef) : dst.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009FC RID: 2556
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoTransform";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009FD RID: 2557
		public new static readonly string MRClassNameKey = "class vtkGeoTransform";
	}
}
