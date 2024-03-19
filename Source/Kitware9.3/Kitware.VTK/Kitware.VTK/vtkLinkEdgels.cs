using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLinkEdgels
	/// </summary>
	/// <remarks>
	///    links edgels together to form digital curves.
	///
	/// vtkLinkEdgels links edgels into digital curves which are then stored
	/// as polylines. The algorithm works one pixel at a time only looking at
	/// its immediate neighbors. There is a GradientThreshold that can be set
	/// that eliminates any pixels with a smaller gradient value. This can
	/// be used as the lower threshold of a two value edgel thresholding.
	///
	/// For the remaining edgels, links are first tried for the four
	/// connected neighbors.  A successful neighbor will satisfy three
	/// tests. First both edgels must be above the gradient
	/// threshold. Second, the difference between the orientation between
	/// the two edgels (Alpha) and each edgels orientation (Phi) must be
	/// less than LinkThreshold. Third, the difference between the two
	/// edgels Phi values must be less than PhiThreshold.
	/// The most successful link is selected. The measure is simply the
	/// sum of the three angle differences (actually stored as the sum of
	/// the cosines). If none of the four connect neighbors succeeds, then
	/// the eight connect neighbors are examined using the same method.
	///
	/// This filter requires gradient information so you will need to use
	/// a vtkImageGradient at some point prior to this filter.  Typically
	/// a vtkNonMaximumSuppression filter is also used. vtkThresholdEdgels
	/// can be used to complete the two value edgel thresholding as used
	/// in a Canny edge detector. The vtkSubpixelPositionEdgels filter
	/// can also be used after this filter to adjust the edgel locations.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageData vtkImageGradient vtkImageNonMaximumSuppression
	/// </seealso>
	// Token: 0x020008B4 RID: 2228
	public class vtkLinkEdgels : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060171AA RID: 94634 RVA: 0x002070FF File Offset: 0x002052FF
		static vtkLinkEdgels()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLinkEdgels.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLinkEdgels"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060171AB RID: 94635 RVA: 0x00207127 File Offset: 0x00205327
		public vtkLinkEdgels(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060171AC RID: 94636
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinkEdgels_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct instance of vtkLinkEdgels with GradientThreshold set to
		/// 0.1, PhiThreshold set to 90 degrees and LinkThreshold set to 90 degrees.
		/// </summary>
		// Token: 0x060171AD RID: 94637 RVA: 0x00207138 File Offset: 0x00205338
		public new static vtkLinkEdgels New()
		{
			vtkLinkEdgels result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinkEdgels.vtkLinkEdgels_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinkEdgels)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct instance of vtkLinkEdgels with GradientThreshold set to
		/// 0.1, PhiThreshold set to 90 degrees and LinkThreshold set to 90 degrees.
		/// </summary>
		// Token: 0x060171AE RID: 94638 RVA: 0x0020718C File Offset: 0x0020538C
		public vtkLinkEdgels() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLinkEdgels.vtkLinkEdgels_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060171AF RID: 94639 RVA: 0x002071D0 File Offset: 0x002053D0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060171B0 RID: 94640
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLinkEdgels_GetGradientThreshold_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the threshold for image gradient thresholding.
		/// </summary>
		// Token: 0x060171B1 RID: 94641 RVA: 0x002071DC File Offset: 0x002053DC
		public virtual double GetGradientThreshold()
		{
			return vtkLinkEdgels.vtkLinkEdgels_GetGradientThreshold_01(base.GetCppThis());
		}

		// Token: 0x060171B2 RID: 94642
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLinkEdgels_GetLinkThreshold_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the threshold for Phi vs. Alpha link thresholding.
		/// </summary>
		// Token: 0x060171B3 RID: 94643 RVA: 0x002071FC File Offset: 0x002053FC
		public virtual double GetLinkThreshold()
		{
			return vtkLinkEdgels.vtkLinkEdgels_GetLinkThreshold_02(base.GetCppThis());
		}

		// Token: 0x060171B4 RID: 94644
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLinkEdgels_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060171B5 RID: 94645 RVA: 0x0020721C File Offset: 0x0020541C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLinkEdgels.vtkLinkEdgels_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060171B6 RID: 94646
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLinkEdgels_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060171B7 RID: 94647 RVA: 0x0020723C File Offset: 0x0020543C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLinkEdgels.vtkLinkEdgels_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060171B8 RID: 94648
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLinkEdgels_GetPhiThreshold_05(HandleRef pThis);

		/// <summary>
		/// Set/get the threshold for Phi vs. Phi link thresholding.
		/// </summary>
		// Token: 0x060171B9 RID: 94649 RVA: 0x00207258 File Offset: 0x00205458
		public virtual double GetPhiThreshold()
		{
			return vtkLinkEdgels.vtkLinkEdgels_GetPhiThreshold_05(base.GetCppThis());
		}

		// Token: 0x060171BA RID: 94650
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLinkEdgels_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060171BB RID: 94651 RVA: 0x00207278 File Offset: 0x00205478
		public override int IsA(string type)
		{
			return vtkLinkEdgels.vtkLinkEdgels_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060171BC RID: 94652
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLinkEdgels_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060171BD RID: 94653 RVA: 0x00207298 File Offset: 0x00205498
		public new static int IsTypeOf(string type)
		{
			return vtkLinkEdgels.vtkLinkEdgels_IsTypeOf_07(type);
		}

		// Token: 0x060171BE RID: 94654
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinkEdgels_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060171BF RID: 94655 RVA: 0x002072B4 File Offset: 0x002054B4
		public new vtkLinkEdgels NewInstance()
		{
			vtkLinkEdgels result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinkEdgels.vtkLinkEdgels_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinkEdgels)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060171C0 RID: 94656
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinkEdgels_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060171C1 RID: 94657 RVA: 0x00207310 File Offset: 0x00205510
		public new static vtkLinkEdgels SafeDownCast(vtkObjectBase o)
		{
			vtkLinkEdgels vtkLinkEdgels = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinkEdgels.vtkLinkEdgels_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLinkEdgels = (vtkLinkEdgels)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLinkEdgels.Register(null);
				}
			}
			return vtkLinkEdgels;
		}

		// Token: 0x060171C2 RID: 94658
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinkEdgels_SetGradientThreshold_11(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the threshold for image gradient thresholding.
		/// </summary>
		// Token: 0x060171C3 RID: 94659 RVA: 0x0020738F File Offset: 0x0020558F
		public virtual void SetGradientThreshold(double _arg)
		{
			vtkLinkEdgels.vtkLinkEdgels_SetGradientThreshold_11(base.GetCppThis(), _arg);
		}

		// Token: 0x060171C4 RID: 94660
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinkEdgels_SetLinkThreshold_12(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the threshold for Phi vs. Alpha link thresholding.
		/// </summary>
		// Token: 0x060171C5 RID: 94661 RVA: 0x0020739F File Offset: 0x0020559F
		public virtual void SetLinkThreshold(double _arg)
		{
			vtkLinkEdgels.vtkLinkEdgels_SetLinkThreshold_12(base.GetCppThis(), _arg);
		}

		// Token: 0x060171C6 RID: 94662
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinkEdgels_SetPhiThreshold_13(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the threshold for Phi vs. Phi link thresholding.
		/// </summary>
		// Token: 0x060171C7 RID: 94663 RVA: 0x002073AF File Offset: 0x002055AF
		public virtual void SetPhiThreshold(double _arg)
		{
			vtkLinkEdgels.vtkLinkEdgels_SetPhiThreshold_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019D1 RID: 6609
		public new const string MRFullTypeName = "Kitware.VTK.vtkLinkEdgels";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019D2 RID: 6610
		public new static readonly string MRClassNameKey = "class vtkLinkEdgels";
	}
}
