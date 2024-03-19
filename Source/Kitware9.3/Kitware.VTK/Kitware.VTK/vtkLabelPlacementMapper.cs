using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLabelPlacementMapper
	/// </summary>
	/// <remarks>
	///    Places and renders non-overlapping labels.
	///
	///
	/// To use this mapper, first send your data through vtkPointSetToLabelHierarchy,
	/// which takes a set of points, associates special arrays to the points (label,
	/// priority, etc.), and produces a prioritized spatial tree of labels.
	///
	/// This mapper then takes that hierarchy (or hierarchies) as input, and every
	/// frame will decide which labels and/or icons to place in order of priority,
	/// and will render only those labels/icons. A label render strategy is used to
	/// render the labels, and can use e.g. FreeType or Qt for rendering.
	/// </remarks>
	// Token: 0x020000F0 RID: 240
	public class vtkLabelPlacementMapper : vtkMapper2D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060031CF RID: 12751 RVA: 0x000496EF File Offset: 0x000478EF
		static vtkLabelPlacementMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLabelPlacementMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabelPlacementMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060031D0 RID: 12752 RVA: 0x00049717 File Offset: 0x00047917
		public vtkLabelPlacementMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060031D1 RID: 12753
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelPlacementMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060031D2 RID: 12754 RVA: 0x00049728 File Offset: 0x00047928
		public new static vtkLabelPlacementMapper New()
		{
			vtkLabelPlacementMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelPlacementMapper.vtkLabelPlacementMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelPlacementMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060031D3 RID: 12755 RVA: 0x0004977C File Offset: 0x0004797C
		public vtkLabelPlacementMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLabelPlacementMapper.vtkLabelPlacementMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060031D4 RID: 12756 RVA: 0x000497C0 File Offset: 0x000479C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060031D5 RID: 12757
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_GeneratePerturbedLabelSpokesOff_01(HandleRef pThis);

		/// <summary>
		/// Enable drawing spokes (lines) to anchor point coordinates that were perturbed
		/// for being coincident with other anchor point coordinates.
		/// </summary>
		// Token: 0x060031D6 RID: 12758 RVA: 0x000497CB File Offset: 0x000479CB
		public virtual void GeneratePerturbedLabelSpokesOff()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_GeneratePerturbedLabelSpokesOff_01(base.GetCppThis());
		}

		// Token: 0x060031D7 RID: 12759
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_GeneratePerturbedLabelSpokesOn_02(HandleRef pThis);

		/// <summary>
		/// Enable drawing spokes (lines) to anchor point coordinates that were perturbed
		/// for being coincident with other anchor point coordinates.
		/// </summary>
		// Token: 0x060031D8 RID: 12760 RVA: 0x000497DA File Offset: 0x000479DA
		public virtual void GeneratePerturbedLabelSpokesOn()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_GeneratePerturbedLabelSpokesOn_02(base.GetCppThis());
		}

		// Token: 0x060031D9 RID: 12761
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelPlacementMapper_GetAnchorTransform_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the transform for the anchor points.
		/// </summary>
		// Token: 0x060031DA RID: 12762 RVA: 0x000497EC File Offset: 0x000479EC
		public virtual vtkCoordinate GetAnchorTransform()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetAnchorTransform_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		// Token: 0x060031DB RID: 12763
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelPlacementMapper_GetBackgroundColor_04(HandleRef pThis);

		/// <summary>
		/// The color of the background shape.
		/// </summary>
		// Token: 0x060031DC RID: 12764 RVA: 0x0004985C File Offset: 0x00047A5C
		public virtual double[] GetBackgroundColor()
		{
			IntPtr intPtr = vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetBackgroundColor_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060031DD RID: 12765
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_GetBackgroundColor_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// The color of the background shape.
		/// </summary>
		// Token: 0x060031DE RID: 12766 RVA: 0x000498A4 File Offset: 0x00047AA4
		public virtual void GetBackgroundColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetBackgroundColor_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060031DF RID: 12767
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_GetBackgroundColor_06(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The color of the background shape.
		/// </summary>
		// Token: 0x060031E0 RID: 12768 RVA: 0x000498B6 File Offset: 0x00047AB6
		public virtual void GetBackgroundColor(IntPtr _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetBackgroundColor_06(base.GetCppThis(), _arg);
		}

		// Token: 0x060031E1 RID: 12769
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLabelPlacementMapper_GetBackgroundOpacity_07(HandleRef pThis);

		/// <summary>
		/// The opacity of the background shape.
		/// </summary>
		// Token: 0x060031E2 RID: 12770 RVA: 0x000498C8 File Offset: 0x00047AC8
		public virtual double GetBackgroundOpacity()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetBackgroundOpacity_07(base.GetCppThis());
		}

		// Token: 0x060031E3 RID: 12771
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLabelPlacementMapper_GetBackgroundOpacityMaxValue_08(HandleRef pThis);

		/// <summary>
		/// The opacity of the background shape.
		/// </summary>
		// Token: 0x060031E4 RID: 12772 RVA: 0x000498E8 File Offset: 0x00047AE8
		public virtual double GetBackgroundOpacityMaxValue()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetBackgroundOpacityMaxValue_08(base.GetCppThis());
		}

		// Token: 0x060031E5 RID: 12773
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLabelPlacementMapper_GetBackgroundOpacityMinValue_09(HandleRef pThis);

		/// <summary>
		/// The opacity of the background shape.
		/// </summary>
		// Token: 0x060031E6 RID: 12774 RVA: 0x00049908 File Offset: 0x00047B08
		public virtual double GetBackgroundOpacityMinValue()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetBackgroundOpacityMinValue_09(base.GetCppThis());
		}

		// Token: 0x060031E7 RID: 12775
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLabelPlacementMapper_GetGeneratePerturbedLabelSpokes_10(HandleRef pThis);

		/// <summary>
		/// Enable drawing spokes (lines) to anchor point coordinates that were perturbed
		/// for being coincident with other anchor point coordinates.
		/// </summary>
		// Token: 0x060031E8 RID: 12776 RVA: 0x00049928 File Offset: 0x00047B28
		public virtual bool GetGeneratePerturbedLabelSpokes()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetGeneratePerturbedLabelSpokes_10(base.GetCppThis()) != 0;
		}

		// Token: 0x060031E9 RID: 12777
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelPlacementMapper_GetIteratorType_11(HandleRef pThis);

		/// <summary>
		/// The type of iterator used when traversing the labels.
		/// May be vtkLabelHierarchy::FRUSTUM or vtkLabelHierarchy::FULL_SORT
		/// </summary>
		// Token: 0x060031EA RID: 12778 RVA: 0x00049950 File Offset: 0x00047B50
		public virtual int GetIteratorType()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetIteratorType_11(base.GetCppThis());
		}

		// Token: 0x060031EB RID: 12779
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLabelPlacementMapper_GetMargin_12(HandleRef pThis);

		/// <summary>
		/// The size of the margin on the label background shape.
		/// Default is 5.
		/// </summary>
		// Token: 0x060031EC RID: 12780 RVA: 0x00049970 File Offset: 0x00047B70
		public virtual double GetMargin()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetMargin_12(base.GetCppThis());
		}

		// Token: 0x060031ED RID: 12781
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLabelPlacementMapper_GetMaximumLabelFraction_13(HandleRef pThis);

		/// <summary>
		/// The maximum fraction of the screen that the labels may cover.
		/// Label placement stops when this fraction is reached.
		/// </summary>
		// Token: 0x060031EE RID: 12782 RVA: 0x00049990 File Offset: 0x00047B90
		public virtual double GetMaximumLabelFraction()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetMaximumLabelFraction_13(base.GetCppThis());
		}

		// Token: 0x060031EF RID: 12783
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLabelPlacementMapper_GetMaximumLabelFractionMaxValue_14(HandleRef pThis);

		/// <summary>
		/// The maximum fraction of the screen that the labels may cover.
		/// Label placement stops when this fraction is reached.
		/// </summary>
		// Token: 0x060031F0 RID: 12784 RVA: 0x000499B0 File Offset: 0x00047BB0
		public virtual double GetMaximumLabelFractionMaxValue()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetMaximumLabelFractionMaxValue_14(base.GetCppThis());
		}

		// Token: 0x060031F1 RID: 12785
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLabelPlacementMapper_GetMaximumLabelFractionMinValue_15(HandleRef pThis);

		/// <summary>
		/// The maximum fraction of the screen that the labels may cover.
		/// Label placement stops when this fraction is reached.
		/// </summary>
		// Token: 0x060031F2 RID: 12786 RVA: 0x000499D0 File Offset: 0x00047BD0
		public virtual double GetMaximumLabelFractionMinValue()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetMaximumLabelFractionMinValue_15(base.GetCppThis());
		}

		// Token: 0x060031F3 RID: 12787
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabelPlacementMapper_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060031F4 RID: 12788 RVA: 0x000499F0 File Offset: 0x00047BF0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x060031F5 RID: 12789
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabelPlacementMapper_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060031F6 RID: 12790 RVA: 0x00049A10 File Offset: 0x00047C10
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x060031F7 RID: 12791
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLabelPlacementMapper_GetOutputTraversedBounds_18(HandleRef pThis);

		/// <summary>
		/// Whether to render traversed bounds. Off by default.
		/// </summary>
		// Token: 0x060031F8 RID: 12792 RVA: 0x00049A2C File Offset: 0x00047C2C
		public virtual bool GetOutputTraversedBounds()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetOutputTraversedBounds_18(base.GetCppThis()) != 0;
		}

		// Token: 0x060031F9 RID: 12793
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLabelPlacementMapper_GetPlaceAllLabels_19(HandleRef pThis);

		/// <summary>
		/// Tells the placer to place every label regardless of overlap.
		/// Off by default.
		/// </summary>
		// Token: 0x060031FA RID: 12794 RVA: 0x00049A54 File Offset: 0x00047C54
		public virtual bool GetPlaceAllLabels()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetPlaceAllLabels_19(base.GetCppThis()) != 0;
		}

		// Token: 0x060031FB RID: 12795
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLabelPlacementMapper_GetPositionsAsNormals_20(HandleRef pThis);

		/// <summary>
		/// Use label anchor point coordinates as normal vectors and eliminate those
		/// pointing away from the camera. Valid only when points are on a sphere
		/// centered at the origin (such as a 3D geographic view). Off by default.
		/// </summary>
		// Token: 0x060031FC RID: 12796 RVA: 0x00049A7C File Offset: 0x00047C7C
		public virtual bool GetPositionsAsNormals()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetPositionsAsNormals_20(base.GetCppThis()) != 0;
		}

		// Token: 0x060031FD RID: 12797
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelPlacementMapper_GetRenderStrategy_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the label rendering strategy.
		/// </summary>
		// Token: 0x060031FE RID: 12798 RVA: 0x00049AA4 File Offset: 0x00047CA4
		public virtual vtkLabelRenderStrategy GetRenderStrategy()
		{
			vtkLabelRenderStrategy vtkLabelRenderStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetRenderStrategy_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelRenderStrategy = (vtkLabelRenderStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelRenderStrategy.Register(null);
				}
			}
			return vtkLabelRenderStrategy;
		}

		// Token: 0x060031FF RID: 12799
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelPlacementMapper_GetShape_22(HandleRef pThis);

		/// <summary>
		/// The shape of the label background, should be one of the
		/// values in the LabelShape enumeration.
		/// </summary>
		// Token: 0x06003200 RID: 12800 RVA: 0x00049B14 File Offset: 0x00047D14
		public virtual int GetShape()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetShape_22(base.GetCppThis());
		}

		// Token: 0x06003201 RID: 12801
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelPlacementMapper_GetShapeMaxValue_23(HandleRef pThis);

		/// <summary>
		/// The shape of the label background, should be one of the
		/// values in the LabelShape enumeration.
		/// </summary>
		// Token: 0x06003202 RID: 12802 RVA: 0x00049B34 File Offset: 0x00047D34
		public virtual int GetShapeMaxValue()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetShapeMaxValue_23(base.GetCppThis());
		}

		// Token: 0x06003203 RID: 12803
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelPlacementMapper_GetShapeMinValue_24(HandleRef pThis);

		/// <summary>
		/// The shape of the label background, should be one of the
		/// values in the LabelShape enumeration.
		/// </summary>
		// Token: 0x06003204 RID: 12804 RVA: 0x00049B54 File Offset: 0x00047D54
		public virtual int GetShapeMinValue()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetShapeMinValue_24(base.GetCppThis());
		}

		// Token: 0x06003205 RID: 12805
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelPlacementMapper_GetStyle_25(HandleRef pThis);

		/// <summary>
		/// The style of the label background shape, should be one of the
		/// values in the LabelStyle enumeration.
		/// </summary>
		// Token: 0x06003206 RID: 12806 RVA: 0x00049B74 File Offset: 0x00047D74
		public virtual int GetStyle()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetStyle_25(base.GetCppThis());
		}

		// Token: 0x06003207 RID: 12807
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelPlacementMapper_GetStyleMaxValue_26(HandleRef pThis);

		/// <summary>
		/// The style of the label background shape, should be one of the
		/// values in the LabelStyle enumeration.
		/// </summary>
		// Token: 0x06003208 RID: 12808 RVA: 0x00049B94 File Offset: 0x00047D94
		public virtual int GetStyleMaxValue()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetStyleMaxValue_26(base.GetCppThis());
		}

		// Token: 0x06003209 RID: 12809
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelPlacementMapper_GetStyleMinValue_27(HandleRef pThis);

		/// <summary>
		/// The style of the label background shape, should be one of the
		/// values in the LabelStyle enumeration.
		/// </summary>
		// Token: 0x0600320A RID: 12810 RVA: 0x00049BB4 File Offset: 0x00047DB4
		public virtual int GetStyleMinValue()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetStyleMinValue_27(base.GetCppThis());
		}

		// Token: 0x0600320B RID: 12811
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLabelPlacementMapper_GetUseDepthBuffer_28(HandleRef pThis);

		/// <summary>
		/// Use the depth buffer to test each label to see if it should not be displayed if
		/// it would be occluded by other objects in the scene. Off by default.
		/// </summary>
		// Token: 0x0600320C RID: 12812 RVA: 0x00049BD4 File Offset: 0x00047DD4
		public virtual bool GetUseDepthBuffer()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetUseDepthBuffer_28(base.GetCppThis()) != 0;
		}

		// Token: 0x0600320D RID: 12813
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelPlacementMapper_IsA_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600320E RID: 12814 RVA: 0x00049BFC File Offset: 0x00047DFC
		public override int IsA(string type)
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_IsA_29(base.GetCppThis(), type);
		}

		// Token: 0x0600320F RID: 12815
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelPlacementMapper_IsTypeOf_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003210 RID: 12816 RVA: 0x00049C1C File Offset: 0x00047E1C
		public new static int IsTypeOf(string type)
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_IsTypeOf_30(type);
		}

		// Token: 0x06003211 RID: 12817
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelPlacementMapper_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003212 RID: 12818 RVA: 0x00049C38 File Offset: 0x00047E38
		public new vtkLabelPlacementMapper NewInstance()
		{
			vtkLabelPlacementMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelPlacementMapper.vtkLabelPlacementMapper_NewInstance_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelPlacementMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003213 RID: 12819
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_OutputTraversedBoundsOff_33(HandleRef pThis);

		/// <summary>
		/// Whether to render traversed bounds. Off by default.
		/// </summary>
		// Token: 0x06003214 RID: 12820 RVA: 0x00049C92 File Offset: 0x00047E92
		public virtual void OutputTraversedBoundsOff()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_OutputTraversedBoundsOff_33(base.GetCppThis());
		}

		// Token: 0x06003215 RID: 12821
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_OutputTraversedBoundsOn_34(HandleRef pThis);

		/// <summary>
		/// Whether to render traversed bounds. Off by default.
		/// </summary>
		// Token: 0x06003216 RID: 12822 RVA: 0x00049CA1 File Offset: 0x00047EA1
		public virtual void OutputTraversedBoundsOn()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_OutputTraversedBoundsOn_34(base.GetCppThis());
		}

		// Token: 0x06003217 RID: 12823
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_PlaceAllLabelsOff_35(HandleRef pThis);

		/// <summary>
		/// Tells the placer to place every label regardless of overlap.
		/// Off by default.
		/// </summary>
		// Token: 0x06003218 RID: 12824 RVA: 0x00049CB0 File Offset: 0x00047EB0
		public virtual void PlaceAllLabelsOff()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_PlaceAllLabelsOff_35(base.GetCppThis());
		}

		// Token: 0x06003219 RID: 12825
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_PlaceAllLabelsOn_36(HandleRef pThis);

		/// <summary>
		/// Tells the placer to place every label regardless of overlap.
		/// Off by default.
		/// </summary>
		// Token: 0x0600321A RID: 12826 RVA: 0x00049CBF File Offset: 0x00047EBF
		public virtual void PlaceAllLabelsOn()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_PlaceAllLabelsOn_36(base.GetCppThis());
		}

		// Token: 0x0600321B RID: 12827
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_PositionsAsNormalsOff_37(HandleRef pThis);

		/// <summary>
		/// Use label anchor point coordinates as normal vectors and eliminate those
		/// pointing away from the camera. Valid only when points are on a sphere
		/// centered at the origin (such as a 3D geographic view). Off by default.
		/// </summary>
		// Token: 0x0600321C RID: 12828 RVA: 0x00049CCE File Offset: 0x00047ECE
		public virtual void PositionsAsNormalsOff()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_PositionsAsNormalsOff_37(base.GetCppThis());
		}

		// Token: 0x0600321D RID: 12829
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_PositionsAsNormalsOn_38(HandleRef pThis);

		/// <summary>
		/// Use label anchor point coordinates as normal vectors and eliminate those
		/// pointing away from the camera. Valid only when points are on a sphere
		/// centered at the origin (such as a 3D geographic view). Off by default.
		/// </summary>
		// Token: 0x0600321E RID: 12830 RVA: 0x00049CDD File Offset: 0x00047EDD
		public virtual void PositionsAsNormalsOn()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_PositionsAsNormalsOn_38(base.GetCppThis());
		}

		// Token: 0x0600321F RID: 12831
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_ReleaseGraphicsResources_39(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06003220 RID: 12832 RVA: 0x00049CEC File Offset: 0x00047EEC
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_ReleaseGraphicsResources_39(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003221 RID: 12833
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_RenderOverlay_40(HandleRef pThis, HandleRef viewport, HandleRef actor);

		/// <summary>
		/// Draw non-overlapping labels to the screen.
		/// </summary>
		// Token: 0x06003222 RID: 12834 RVA: 0x00049D1C File Offset: 0x00047F1C
		public override void RenderOverlay(vtkViewport viewport, vtkActor2D actor)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_RenderOverlay_40(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		// Token: 0x06003223 RID: 12835
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelPlacementMapper_SafeDownCast_41(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003224 RID: 12836 RVA: 0x00049D60 File Offset: 0x00047F60
		public new static vtkLabelPlacementMapper SafeDownCast(vtkObjectBase o)
		{
			vtkLabelPlacementMapper vtkLabelPlacementMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelPlacementMapper.vtkLabelPlacementMapper_SafeDownCast_41((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelPlacementMapper = (vtkLabelPlacementMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelPlacementMapper.Register(null);
				}
			}
			return vtkLabelPlacementMapper;
		}

		// Token: 0x06003225 RID: 12837
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_SetBackgroundColor_42(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// The color of the background shape.
		/// </summary>
		// Token: 0x06003226 RID: 12838 RVA: 0x00049DDF File Offset: 0x00047FDF
		public virtual void SetBackgroundColor(double _arg1, double _arg2, double _arg3)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetBackgroundColor_42(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06003227 RID: 12839
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_SetBackgroundColor_43(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The color of the background shape.
		/// </summary>
		// Token: 0x06003228 RID: 12840 RVA: 0x00049DF1 File Offset: 0x00047FF1
		public virtual void SetBackgroundColor(IntPtr _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetBackgroundColor_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06003229 RID: 12841
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_SetBackgroundOpacity_44(HandleRef pThis, double _arg);

		/// <summary>
		/// The opacity of the background shape.
		/// </summary>
		// Token: 0x0600322A RID: 12842 RVA: 0x00049E01 File Offset: 0x00048001
		public virtual void SetBackgroundOpacity(double _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetBackgroundOpacity_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0600322B RID: 12843
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_SetGeneratePerturbedLabelSpokes_45(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable drawing spokes (lines) to anchor point coordinates that were perturbed
		/// for being coincident with other anchor point coordinates.
		/// </summary>
		// Token: 0x0600322C RID: 12844 RVA: 0x00049E11 File Offset: 0x00048011
		public virtual void SetGeneratePerturbedLabelSpokes(bool _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetGeneratePerturbedLabelSpokes_45(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600322D RID: 12845
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_SetIteratorType_46(HandleRef pThis, int _arg);

		/// <summary>
		/// The type of iterator used when traversing the labels.
		/// May be vtkLabelHierarchy::FRUSTUM or vtkLabelHierarchy::FULL_SORT
		/// </summary>
		// Token: 0x0600322E RID: 12846 RVA: 0x00049E29 File Offset: 0x00048029
		public virtual void SetIteratorType(int _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetIteratorType_46(base.GetCppThis(), _arg);
		}

		// Token: 0x0600322F RID: 12847
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_SetMargin_47(HandleRef pThis, double _arg);

		/// <summary>
		/// The size of the margin on the label background shape.
		/// Default is 5.
		/// </summary>
		// Token: 0x06003230 RID: 12848 RVA: 0x00049E39 File Offset: 0x00048039
		public virtual void SetMargin(double _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetMargin_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06003231 RID: 12849
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_SetMaximumLabelFraction_48(HandleRef pThis, double _arg);

		/// <summary>
		/// The maximum fraction of the screen that the labels may cover.
		/// Label placement stops when this fraction is reached.
		/// </summary>
		// Token: 0x06003232 RID: 12850 RVA: 0x00049E49 File Offset: 0x00048049
		public virtual void SetMaximumLabelFraction(double _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetMaximumLabelFraction_48(base.GetCppThis(), _arg);
		}

		// Token: 0x06003233 RID: 12851
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_SetOutputTraversedBounds_49(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to render traversed bounds. Off by default.
		/// </summary>
		// Token: 0x06003234 RID: 12852 RVA: 0x00049E59 File Offset: 0x00048059
		public virtual void SetOutputTraversedBounds(bool _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetOutputTraversedBounds_49(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06003235 RID: 12853
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_SetPlaceAllLabels_50(HandleRef pThis, byte _arg);

		/// <summary>
		/// Tells the placer to place every label regardless of overlap.
		/// Off by default.
		/// </summary>
		// Token: 0x06003236 RID: 12854 RVA: 0x00049E71 File Offset: 0x00048071
		public virtual void SetPlaceAllLabels(bool _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetPlaceAllLabels_50(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06003237 RID: 12855
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_SetPositionsAsNormals_51(HandleRef pThis, byte _arg);

		/// <summary>
		/// Use label anchor point coordinates as normal vectors and eliminate those
		/// pointing away from the camera. Valid only when points are on a sphere
		/// centered at the origin (such as a 3D geographic view). Off by default.
		/// </summary>
		// Token: 0x06003238 RID: 12856 RVA: 0x00049E89 File Offset: 0x00048089
		public virtual void SetPositionsAsNormals(bool _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetPositionsAsNormals_51(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06003239 RID: 12857
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_SetRenderStrategy_52(HandleRef pThis, HandleRef s);

		/// <summary>
		/// Set the label rendering strategy.
		/// </summary>
		// Token: 0x0600323A RID: 12858 RVA: 0x00049EA4 File Offset: 0x000480A4
		public virtual void SetRenderStrategy(vtkLabelRenderStrategy s)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetRenderStrategy_52(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		// Token: 0x0600323B RID: 12859
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_SetShape_53(HandleRef pThis, int _arg);

		/// <summary>
		/// The shape of the label background, should be one of the
		/// values in the LabelShape enumeration.
		/// </summary>
		// Token: 0x0600323C RID: 12860 RVA: 0x00049ED3 File Offset: 0x000480D3
		public virtual void SetShape(int _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetShape_53(base.GetCppThis(), _arg);
		}

		// Token: 0x0600323D RID: 12861
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_SetShapeToNone_54(HandleRef pThis);

		/// <summary>
		/// The shape of the label background, should be one of the
		/// values in the LabelShape enumeration.
		/// </summary>
		// Token: 0x0600323E RID: 12862 RVA: 0x00049EE3 File Offset: 0x000480E3
		public virtual void SetShapeToNone()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetShapeToNone_54(base.GetCppThis());
		}

		// Token: 0x0600323F RID: 12863
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_SetShapeToRect_55(HandleRef pThis);

		/// <summary>
		/// The shape of the label background, should be one of the
		/// values in the LabelShape enumeration.
		/// </summary>
		// Token: 0x06003240 RID: 12864 RVA: 0x00049EF2 File Offset: 0x000480F2
		public virtual void SetShapeToRect()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetShapeToRect_55(base.GetCppThis());
		}

		// Token: 0x06003241 RID: 12865
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_SetShapeToRoundedRect_56(HandleRef pThis);

		/// <summary>
		/// The shape of the label background, should be one of the
		/// values in the LabelShape enumeration.
		/// </summary>
		// Token: 0x06003242 RID: 12866 RVA: 0x00049F01 File Offset: 0x00048101
		public virtual void SetShapeToRoundedRect()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetShapeToRoundedRect_56(base.GetCppThis());
		}

		// Token: 0x06003243 RID: 12867
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_SetStyle_57(HandleRef pThis, int _arg);

		/// <summary>
		/// The style of the label background shape, should be one of the
		/// values in the LabelStyle enumeration.
		/// </summary>
		// Token: 0x06003244 RID: 12868 RVA: 0x00049F10 File Offset: 0x00048110
		public virtual void SetStyle(int _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetStyle_57(base.GetCppThis(), _arg);
		}

		// Token: 0x06003245 RID: 12869
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_SetStyleToFilled_58(HandleRef pThis);

		/// <summary>
		/// The style of the label background shape, should be one of the
		/// values in the LabelStyle enumeration.
		/// </summary>
		// Token: 0x06003246 RID: 12870 RVA: 0x00049F20 File Offset: 0x00048120
		public virtual void SetStyleToFilled()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetStyleToFilled_58(base.GetCppThis());
		}

		// Token: 0x06003247 RID: 12871
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_SetStyleToOutline_59(HandleRef pThis);

		/// <summary>
		/// The style of the label background shape, should be one of the
		/// values in the LabelStyle enumeration.
		/// </summary>
		// Token: 0x06003248 RID: 12872 RVA: 0x00049F2F File Offset: 0x0004812F
		public virtual void SetStyleToOutline()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetStyleToOutline_59(base.GetCppThis());
		}

		// Token: 0x06003249 RID: 12873
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_SetUseDepthBuffer_60(HandleRef pThis, byte _arg);

		/// <summary>
		/// Use the depth buffer to test each label to see if it should not be displayed if
		/// it would be occluded by other objects in the scene. Off by default.
		/// </summary>
		// Token: 0x0600324A RID: 12874 RVA: 0x00049F3E File Offset: 0x0004813E
		public virtual void SetUseDepthBuffer(bool _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetUseDepthBuffer_60(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600324B RID: 12875
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_UseDepthBufferOff_61(HandleRef pThis);

		/// <summary>
		/// Use the depth buffer to test each label to see if it should not be displayed if
		/// it would be occluded by other objects in the scene. Off by default.
		/// </summary>
		// Token: 0x0600324C RID: 12876 RVA: 0x00049F56 File Offset: 0x00048156
		public virtual void UseDepthBufferOff()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_UseDepthBufferOff_61(base.GetCppThis());
		}

		// Token: 0x0600324D RID: 12877
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacementMapper_UseDepthBufferOn_62(HandleRef pThis);

		/// <summary>
		/// Use the depth buffer to test each label to see if it should not be displayed if
		/// it would be occluded by other objects in the scene. Off by default.
		/// </summary>
		// Token: 0x0600324E RID: 12878 RVA: 0x00049F65 File Offset: 0x00048165
		public virtual void UseDepthBufferOn()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_UseDepthBufferOn_62(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005EA RID: 1514
		public new const string MRFullTypeName = "Kitware.VTK.vtkLabelPlacementMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005EB RID: 1515
		public new static readonly string MRClassNameKey = "class vtkLabelPlacementMapper";

		/// <summary>
		/// Whether to render traversed bounds. Off by default.
		/// </summary>
		// Token: 0x020000F1 RID: 241
		public enum LabelShape
		{
			/// <summary>enum member</summary>
			// Token: 0x040005ED RID: 1517
			NONE,
			/// <summary>enum member</summary>
			// Token: 0x040005EE RID: 1518
			NUMBER_OF_LABEL_SHAPES = 3,
			/// <summary>enum member</summary>
			// Token: 0x040005EF RID: 1519
			RECT = 1,
			/// <summary>enum member</summary>
			// Token: 0x040005F0 RID: 1520
			ROUNDED_RECT
		}

		/// <summary>
		/// The shape of the label background, should be one of the
		/// values in the LabelShape enumeration.
		/// </summary>
		// Token: 0x020000F2 RID: 242
		public enum LabelStyle
		{
			/// <summary>enum member</summary>
			// Token: 0x040005F2 RID: 1522
			FILLED,
			/// <summary>enum member</summary>
			// Token: 0x040005F3 RID: 1523
			NUMBER_OF_LABEL_STYLES = 2,
			/// <summary>enum member</summary>
			// Token: 0x040005F4 RID: 1524
			OUTLINE = 1
		}
	}
}
