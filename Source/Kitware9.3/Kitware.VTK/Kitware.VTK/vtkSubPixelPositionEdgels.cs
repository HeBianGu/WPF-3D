using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSubPixelPositionEdgels
	/// </summary>
	/// <remarks>
	///    adjust edgel locations based on gradients.
	///
	/// vtkSubPixelPositionEdgels is a filter that takes a series of linked
	/// edgels (digital curves) and gradient maps as input. It then adjusts
	/// the edgel locations based on the gradient data. Specifically, the
	/// algorithm first determines the neighboring gradient magnitudes of
	/// an edgel using simple interpolation of its neighbors. It then fits
	/// the following three data points: negative gradient direction
	/// gradient magnitude, edgel gradient magnitude and positive gradient
	/// direction gradient magnitude to a quadratic function. It then
	/// solves this quadratic to find the maximum gradient location along
	/// the gradient orientation.  It then modifies the edgels location
	/// along the gradient orientation to the calculated maximum
	/// location. This algorithm does not adjust an edgel in the direction
	/// orthogonal to its gradient vector.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageData vtkImageGradient vtkLinkEdgels
	/// </seealso>
	// Token: 0x020008E8 RID: 2280
	public class vtkSubPixelPositionEdgels : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017873 RID: 96371 RVA: 0x00210338 File Offset: 0x0020E538
		static vtkSubPixelPositionEdgels()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSubPixelPositionEdgels.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSubPixelPositionEdgels"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017874 RID: 96372 RVA: 0x00210360 File Offset: 0x0020E560
		public vtkSubPixelPositionEdgels(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017875 RID: 96373
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSubPixelPositionEdgels_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017876 RID: 96374 RVA: 0x00210370 File Offset: 0x0020E570
		public new static vtkSubPixelPositionEdgels New()
		{
			vtkSubPixelPositionEdgels result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSubPixelPositionEdgels)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017877 RID: 96375 RVA: 0x002103C4 File Offset: 0x0020E5C4
		public vtkSubPixelPositionEdgels() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017878 RID: 96376 RVA: 0x00210408 File Offset: 0x0020E608
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017879 RID: 96377
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSubPixelPositionEdgels_GetGradMaps_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the gradient data for doing the position adjustments.
		/// </summary>
		// Token: 0x0601787A RID: 96378 RVA: 0x00210414 File Offset: 0x0020E614
		public vtkStructuredPoints GetGradMaps()
		{
			vtkStructuredPoints vtkStructuredPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_GetGradMaps_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPoints = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPoints.Register(null);
				}
			}
			return vtkStructuredPoints;
		}

		// Token: 0x0601787B RID: 96379
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSubPixelPositionEdgels_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601787C RID: 96380 RVA: 0x00210484 File Offset: 0x0020E684
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601787D RID: 96381
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSubPixelPositionEdgels_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601787E RID: 96382 RVA: 0x002104A4 File Offset: 0x0020E6A4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601787F RID: 96383
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubPixelPositionEdgels_GetTargetFlag_04(HandleRef pThis);

		/// <summary>
		/// These methods can make the positioning look for a target scalar value
		/// instead of looking for a maximum.
		/// </summary>
		// Token: 0x06017880 RID: 96384 RVA: 0x002104C0 File Offset: 0x0020E6C0
		public virtual int GetTargetFlag()
		{
			return vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_GetTargetFlag_04(base.GetCppThis());
		}

		// Token: 0x06017881 RID: 96385
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSubPixelPositionEdgels_GetTargetValue_05(HandleRef pThis);

		/// <summary>
		/// These methods can make the positioning look for a target scalar value
		/// instead of looking for a maximum.
		/// </summary>
		// Token: 0x06017882 RID: 96386 RVA: 0x002104E0 File Offset: 0x0020E6E0
		public virtual double GetTargetValue()
		{
			return vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_GetTargetValue_05(base.GetCppThis());
		}

		// Token: 0x06017883 RID: 96387
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubPixelPositionEdgels_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017884 RID: 96388 RVA: 0x00210500 File Offset: 0x0020E700
		public override int IsA(string type)
		{
			return vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06017885 RID: 96389
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubPixelPositionEdgels_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017886 RID: 96390 RVA: 0x00210520 File Offset: 0x0020E720
		public new static int IsTypeOf(string type)
		{
			return vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_IsTypeOf_07(type);
		}

		// Token: 0x06017887 RID: 96391
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSubPixelPositionEdgels_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017888 RID: 96392 RVA: 0x0021053C File Offset: 0x0020E73C
		public new vtkSubPixelPositionEdgels NewInstance()
		{
			vtkSubPixelPositionEdgels result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSubPixelPositionEdgels)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017889 RID: 96393
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSubPixelPositionEdgels_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601788A RID: 96394 RVA: 0x00210598 File Offset: 0x0020E798
		public new static vtkSubPixelPositionEdgels SafeDownCast(vtkObjectBase o)
		{
			vtkSubPixelPositionEdgels vtkSubPixelPositionEdgels = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSubPixelPositionEdgels = (vtkSubPixelPositionEdgels)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSubPixelPositionEdgels.Register(null);
				}
			}
			return vtkSubPixelPositionEdgels;
		}

		// Token: 0x0601788B RID: 96395
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSubPixelPositionEdgels_SetGradMapsData_11(HandleRef pThis, HandleRef gm);

		/// <summary>
		/// Set/Get the gradient data for doing the position adjustments.
		/// </summary>
		// Token: 0x0601788C RID: 96396 RVA: 0x00210618 File Offset: 0x0020E818
		public void SetGradMapsData(vtkStructuredPoints gm)
		{
			vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_SetGradMapsData_11(base.GetCppThis(), (gm == null) ? default(HandleRef) : gm.GetCppThis());
		}

		// Token: 0x0601788D RID: 96397
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSubPixelPositionEdgels_SetTargetFlag_12(HandleRef pThis, int _arg);

		/// <summary>
		/// These methods can make the positioning look for a target scalar value
		/// instead of looking for a maximum.
		/// </summary>
		// Token: 0x0601788E RID: 96398 RVA: 0x00210647 File Offset: 0x0020E847
		public virtual void SetTargetFlag(int _arg)
		{
			vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_SetTargetFlag_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0601788F RID: 96399
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSubPixelPositionEdgels_SetTargetValue_13(HandleRef pThis, double _arg);

		/// <summary>
		/// These methods can make the positioning look for a target scalar value
		/// instead of looking for a maximum.
		/// </summary>
		// Token: 0x06017890 RID: 96400 RVA: 0x00210657 File Offset: 0x0020E857
		public virtual void SetTargetValue(double _arg)
		{
			vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_SetTargetValue_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06017891 RID: 96401
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSubPixelPositionEdgels_TargetFlagOff_14(HandleRef pThis);

		/// <summary>
		/// These methods can make the positioning look for a target scalar value
		/// instead of looking for a maximum.
		/// </summary>
		// Token: 0x06017892 RID: 96402 RVA: 0x00210667 File Offset: 0x0020E867
		public virtual void TargetFlagOff()
		{
			vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_TargetFlagOff_14(base.GetCppThis());
		}

		// Token: 0x06017893 RID: 96403
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSubPixelPositionEdgels_TargetFlagOn_15(HandleRef pThis);

		/// <summary>
		/// These methods can make the positioning look for a target scalar value
		/// instead of looking for a maximum.
		/// </summary>
		// Token: 0x06017894 RID: 96404 RVA: 0x00210676 File Offset: 0x0020E876
		public virtual void TargetFlagOn()
		{
			vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_TargetFlagOn_15(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A4A RID: 6730
		public new const string MRFullTypeName = "Kitware.VTK.vtkSubPixelPositionEdgels";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A4B RID: 6731
		public new static readonly string MRClassNameKey = "class vtkSubPixelPositionEdgels";
	}
}
