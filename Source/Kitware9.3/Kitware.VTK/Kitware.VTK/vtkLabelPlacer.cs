using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLabelPlacer
	/// </summary>
	/// <remarks>
	///    place a prioritized hierarchy of labels in screen space
	///
	///
	/// &lt;b&gt;This class is deprecated and will be removed from VTK in a future
	/// release. Use vtkLabelPlacementMapper instead.&lt;/b&gt;
	///
	/// This should probably be a mapper unto itself (given that
	/// the polydata output could be large and will realistically
	/// always be iterated over exactly once before being tossed
	/// for the next frame of the render).
	///
	/// In any event, it takes as input one (or more, eventually)
	/// vtkLabelHierarchies that represent prioritized lists of
	/// labels sorted by their placement in space. As output, it
	/// provides vtkPolyData containing only VTK_QUAD cells, each
	/// representing a single label from the input. Each quadrilateral
	/// has cell data indicating what label in the input it
	/// corresponds to (via an array named "LabelId").
	/// </remarks>
	// Token: 0x020000F4 RID: 244
	public class vtkLabelPlacer : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003275 RID: 12917 RVA: 0x0004A4C3 File Offset: 0x000486C3
		static vtkLabelPlacer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLabelPlacer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabelPlacer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003276 RID: 12918 RVA: 0x0004A4EB File Offset: 0x000486EB
		public vtkLabelPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003277 RID: 12919
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003278 RID: 12920 RVA: 0x0004A4FC File Offset: 0x000486FC
		public new static vtkLabelPlacer New()
		{
			vtkLabelPlacer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelPlacer.vtkLabelPlacer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003279 RID: 12921 RVA: 0x0004A550 File Offset: 0x00048750
		public vtkLabelPlacer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLabelPlacer.vtkLabelPlacer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600327A RID: 12922 RVA: 0x0004A594 File Offset: 0x00048794
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600327B RID: 12923
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacer_GeneratePerturbedLabelSpokesOff_01(HandleRef pThis);

		/// <summary>
		/// Enable drawing spokes (lines) to anchor point coordinates that were perturbed
		/// for being coincident with other anchor point coordinates.
		/// </summary>
		// Token: 0x0600327C RID: 12924 RVA: 0x0004A59F File Offset: 0x0004879F
		public virtual void GeneratePerturbedLabelSpokesOff()
		{
			vtkLabelPlacer.vtkLabelPlacer_GeneratePerturbedLabelSpokesOff_01(base.GetCppThis());
		}

		// Token: 0x0600327D RID: 12925
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacer_GeneratePerturbedLabelSpokesOn_02(HandleRef pThis);

		/// <summary>
		/// Enable drawing spokes (lines) to anchor point coordinates that were perturbed
		/// for being coincident with other anchor point coordinates.
		/// </summary>
		// Token: 0x0600327E RID: 12926 RVA: 0x0004A5AE File Offset: 0x000487AE
		public virtual void GeneratePerturbedLabelSpokesOn()
		{
			vtkLabelPlacer.vtkLabelPlacer_GeneratePerturbedLabelSpokesOn_02(base.GetCppThis());
		}

		// Token: 0x0600327F RID: 12927
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelPlacer_GetAnchorTransform_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003280 RID: 12928 RVA: 0x0004A5C0 File Offset: 0x000487C0
		public virtual vtkCoordinate GetAnchorTransform()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelPlacer.vtkLabelPlacer_GetAnchorTransform_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003281 RID: 12929
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLabelPlacer_GetGeneratePerturbedLabelSpokes_04(HandleRef pThis);

		/// <summary>
		/// Enable drawing spokes (lines) to anchor point coordinates that were perturbed
		/// for being coincident with other anchor point coordinates.
		/// </summary>
		// Token: 0x06003282 RID: 12930 RVA: 0x0004A630 File Offset: 0x00048830
		public virtual bool GetGeneratePerturbedLabelSpokes()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetGeneratePerturbedLabelSpokes_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06003283 RID: 12931
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelPlacer_GetGravity_05(HandleRef pThis);

		/// <summary>
		/// The placement of the label relative to the anchor point.
		/// </summary>
		// Token: 0x06003284 RID: 12932 RVA: 0x0004A658 File Offset: 0x00048858
		public virtual int GetGravity()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetGravity_05(base.GetCppThis());
		}

		// Token: 0x06003285 RID: 12933
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelPlacer_GetIteratorType_06(HandleRef pThis);

		/// <summary>
		/// The type of iterator used when traversing the labels.
		/// May be vtkLabelHierarchy::FRUSTUM or vtkLabelHierarchy::FULL_SORT.
		/// </summary>
		// Token: 0x06003286 RID: 12934 RVA: 0x0004A678 File Offset: 0x00048878
		public virtual int GetIteratorType()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetIteratorType_06(base.GetCppThis());
		}

		// Token: 0x06003287 RID: 12935
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkLabelPlacer_GetMTime_07(HandleRef pThis);

		/// <summary>
		/// The type of iterator used when traversing the labels.
		/// May be vtkLabelHierarchy::FRUSTUM or vtkLabelHierarchy::FULL_SORT.
		/// </summary>
		// Token: 0x06003288 RID: 12936 RVA: 0x0004A698 File Offset: 0x00048898
		public override ulong GetMTime()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetMTime_07(base.GetCppThis());
		}

		// Token: 0x06003289 RID: 12937
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLabelPlacer_GetMaximumLabelFraction_08(HandleRef pThis);

		/// <summary>
		/// The maximum amount of screen space labels can take up before placement
		/// terminates.
		/// </summary>
		// Token: 0x0600328A RID: 12938 RVA: 0x0004A6B8 File Offset: 0x000488B8
		public virtual double GetMaximumLabelFraction()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetMaximumLabelFraction_08(base.GetCppThis());
		}

		// Token: 0x0600328B RID: 12939
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLabelPlacer_GetMaximumLabelFractionMaxValue_09(HandleRef pThis);

		/// <summary>
		/// The maximum amount of screen space labels can take up before placement
		/// terminates.
		/// </summary>
		// Token: 0x0600328C RID: 12940 RVA: 0x0004A6D8 File Offset: 0x000488D8
		public virtual double GetMaximumLabelFractionMaxValue()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetMaximumLabelFractionMaxValue_09(base.GetCppThis());
		}

		// Token: 0x0600328D RID: 12941
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLabelPlacer_GetMaximumLabelFractionMinValue_10(HandleRef pThis);

		/// <summary>
		/// The maximum amount of screen space labels can take up before placement
		/// terminates.
		/// </summary>
		// Token: 0x0600328E RID: 12942 RVA: 0x0004A6F8 File Offset: 0x000488F8
		public virtual double GetMaximumLabelFractionMinValue()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetMaximumLabelFractionMinValue_10(base.GetCppThis());
		}

		// Token: 0x0600328F RID: 12943
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabelPlacer_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003290 RID: 12944 RVA: 0x0004A718 File Offset: 0x00048918
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x06003291 RID: 12945
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabelPlacer_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003292 RID: 12946 RVA: 0x0004A738 File Offset: 0x00048938
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x06003293 RID: 12947
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelPlacer_GetOutputCoordinateSystem_13(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system used for output labels.
		/// The output datasets may have point coordinates reported in the world space or display space.
		/// </summary>
		// Token: 0x06003294 RID: 12948 RVA: 0x0004A754 File Offset: 0x00048954
		public virtual int GetOutputCoordinateSystem()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetOutputCoordinateSystem_13(base.GetCppThis());
		}

		// Token: 0x06003295 RID: 12949
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelPlacer_GetOutputCoordinateSystemMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system used for output labels.
		/// The output datasets may have point coordinates reported in the world space or display space.
		/// </summary>
		// Token: 0x06003296 RID: 12950 RVA: 0x0004A774 File Offset: 0x00048974
		public virtual int GetOutputCoordinateSystemMaxValue()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetOutputCoordinateSystemMaxValue_14(base.GetCppThis());
		}

		// Token: 0x06003297 RID: 12951
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelPlacer_GetOutputCoordinateSystemMinValue_15(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system used for output labels.
		/// The output datasets may have point coordinates reported in the world space or display space.
		/// </summary>
		// Token: 0x06003298 RID: 12952 RVA: 0x0004A794 File Offset: 0x00048994
		public virtual int GetOutputCoordinateSystemMinValue()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetOutputCoordinateSystemMinValue_15(base.GetCppThis());
		}

		// Token: 0x06003299 RID: 12953
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLabelPlacer_GetOutputTraversedBounds_16(HandleRef pThis);

		/// <summary>
		/// In the second output, output the geometry of the traversed octree nodes.
		/// </summary>
		// Token: 0x0600329A RID: 12954 RVA: 0x0004A7B4 File Offset: 0x000489B4
		public virtual bool GetOutputTraversedBounds()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetOutputTraversedBounds_16(base.GetCppThis()) != 0;
		}

		// Token: 0x0600329B RID: 12955
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLabelPlacer_GetPositionsAsNormals_17(HandleRef pThis);

		/// <summary>
		/// Use label anchor point coordinates as normal vectors and eliminate those
		/// pointing away from the camera. Valid only when points are on a sphere
		/// centered at the origin (such as a 3D geographic view). Off by default.
		/// </summary>
		// Token: 0x0600329C RID: 12956 RVA: 0x0004A7DC File Offset: 0x000489DC
		public virtual bool GetPositionsAsNormals()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetPositionsAsNormals_17(base.GetCppThis()) != 0;
		}

		// Token: 0x0600329D RID: 12957
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelPlacer_GetRenderer_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600329E RID: 12958 RVA: 0x0004A804 File Offset: 0x00048A04
		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelPlacer.vtkLabelPlacer_GetRenderer_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		// Token: 0x0600329F RID: 12959
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLabelPlacer_GetUseDepthBuffer_19(HandleRef pThis);

		/// <summary>
		/// Use the depth buffer to test each label to see if it should not be displayed if
		/// it would be occluded by other objects in the scene. Off by default.
		/// </summary>
		// Token: 0x060032A0 RID: 12960 RVA: 0x0004A874 File Offset: 0x00048A74
		public virtual bool GetUseDepthBuffer()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetUseDepthBuffer_19(base.GetCppThis()) != 0;
		}

		// Token: 0x060032A1 RID: 12961
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelPlacer_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060032A2 RID: 12962 RVA: 0x0004A89C File Offset: 0x00048A9C
		public override int IsA(string type)
		{
			return vtkLabelPlacer.vtkLabelPlacer_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x060032A3 RID: 12963
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelPlacer_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060032A4 RID: 12964 RVA: 0x0004A8BC File Offset: 0x00048ABC
		public new static int IsTypeOf(string type)
		{
			return vtkLabelPlacer.vtkLabelPlacer_IsTypeOf_21(type);
		}

		// Token: 0x060032A5 RID: 12965
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelPlacer_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060032A6 RID: 12966 RVA: 0x0004A8D8 File Offset: 0x00048AD8
		public new vtkLabelPlacer NewInstance()
		{
			vtkLabelPlacer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelPlacer.vtkLabelPlacer_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060032A7 RID: 12967
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacer_OutputCoordinateSystemDisplay_24(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system used for output labels.
		/// The output datasets may have point coordinates reported in the world space or display space.
		/// </summary>
		// Token: 0x060032A8 RID: 12968 RVA: 0x0004A932 File Offset: 0x00048B32
		public void OutputCoordinateSystemDisplay()
		{
			vtkLabelPlacer.vtkLabelPlacer_OutputCoordinateSystemDisplay_24(base.GetCppThis());
		}

		// Token: 0x060032A9 RID: 12969
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacer_OutputCoordinateSystemWorld_25(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system used for output labels.
		/// The output datasets may have point coordinates reported in the world space or display space.
		/// </summary>
		// Token: 0x060032AA RID: 12970 RVA: 0x0004A941 File Offset: 0x00048B41
		public void OutputCoordinateSystemWorld()
		{
			vtkLabelPlacer.vtkLabelPlacer_OutputCoordinateSystemWorld_25(base.GetCppThis());
		}

		// Token: 0x060032AB RID: 12971
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacer_OutputTraversedBoundsOff_26(HandleRef pThis);

		/// <summary>
		/// In the second output, output the geometry of the traversed octree nodes.
		/// </summary>
		// Token: 0x060032AC RID: 12972 RVA: 0x0004A950 File Offset: 0x00048B50
		public virtual void OutputTraversedBoundsOff()
		{
			vtkLabelPlacer.vtkLabelPlacer_OutputTraversedBoundsOff_26(base.GetCppThis());
		}

		// Token: 0x060032AD RID: 12973
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacer_OutputTraversedBoundsOn_27(HandleRef pThis);

		/// <summary>
		/// In the second output, output the geometry of the traversed octree nodes.
		/// </summary>
		// Token: 0x060032AE RID: 12974 RVA: 0x0004A95F File Offset: 0x00048B5F
		public virtual void OutputTraversedBoundsOn()
		{
			vtkLabelPlacer.vtkLabelPlacer_OutputTraversedBoundsOn_27(base.GetCppThis());
		}

		// Token: 0x060032AF RID: 12975
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacer_PositionsAsNormalsOff_28(HandleRef pThis);

		/// <summary>
		/// Use label anchor point coordinates as normal vectors and eliminate those
		/// pointing away from the camera. Valid only when points are on a sphere
		/// centered at the origin (such as a 3D geographic view). Off by default.
		/// </summary>
		// Token: 0x060032B0 RID: 12976 RVA: 0x0004A96E File Offset: 0x00048B6E
		public virtual void PositionsAsNormalsOff()
		{
			vtkLabelPlacer.vtkLabelPlacer_PositionsAsNormalsOff_28(base.GetCppThis());
		}

		// Token: 0x060032B1 RID: 12977
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacer_PositionsAsNormalsOn_29(HandleRef pThis);

		/// <summary>
		/// Use label anchor point coordinates as normal vectors and eliminate those
		/// pointing away from the camera. Valid only when points are on a sphere
		/// centered at the origin (such as a 3D geographic view). Off by default.
		/// </summary>
		// Token: 0x060032B2 RID: 12978 RVA: 0x0004A97D File Offset: 0x00048B7D
		public virtual void PositionsAsNormalsOn()
		{
			vtkLabelPlacer.vtkLabelPlacer_PositionsAsNormalsOn_29(base.GetCppThis());
		}

		// Token: 0x060032B3 RID: 12979
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelPlacer_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060032B4 RID: 12980 RVA: 0x0004A98C File Offset: 0x00048B8C
		public new static vtkLabelPlacer SafeDownCast(vtkObjectBase o)
		{
			vtkLabelPlacer vtkLabelPlacer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelPlacer.vtkLabelPlacer_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelPlacer = (vtkLabelPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelPlacer.Register(null);
				}
			}
			return vtkLabelPlacer;
		}

		// Token: 0x060032B5 RID: 12981
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacer_SetGeneratePerturbedLabelSpokes_31(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable drawing spokes (lines) to anchor point coordinates that were perturbed
		/// for being coincident with other anchor point coordinates.
		/// </summary>
		// Token: 0x060032B6 RID: 12982 RVA: 0x0004AA0B File Offset: 0x00048C0B
		public virtual void SetGeneratePerturbedLabelSpokes(bool _arg)
		{
			vtkLabelPlacer.vtkLabelPlacer_SetGeneratePerturbedLabelSpokes_31(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060032B7 RID: 12983
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacer_SetGravity_32(HandleRef pThis, int gravity);

		/// <summary>
		/// The placement of the label relative to the anchor point.
		/// </summary>
		// Token: 0x060032B8 RID: 12984 RVA: 0x0004AA23 File Offset: 0x00048C23
		public virtual void SetGravity(int gravity)
		{
			vtkLabelPlacer.vtkLabelPlacer_SetGravity_32(base.GetCppThis(), gravity);
		}

		// Token: 0x060032B9 RID: 12985
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacer_SetIteratorType_33(HandleRef pThis, int _arg);

		/// <summary>
		/// The type of iterator used when traversing the labels.
		/// May be vtkLabelHierarchy::FRUSTUM or vtkLabelHierarchy::FULL_SORT.
		/// </summary>
		// Token: 0x060032BA RID: 12986 RVA: 0x0004AA33 File Offset: 0x00048C33
		public virtual void SetIteratorType(int _arg)
		{
			vtkLabelPlacer.vtkLabelPlacer_SetIteratorType_33(base.GetCppThis(), _arg);
		}

		// Token: 0x060032BB RID: 12987
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacer_SetMaximumLabelFraction_34(HandleRef pThis, double _arg);

		/// <summary>
		/// The maximum amount of screen space labels can take up before placement
		/// terminates.
		/// </summary>
		// Token: 0x060032BC RID: 12988 RVA: 0x0004AA43 File Offset: 0x00048C43
		public virtual void SetMaximumLabelFraction(double _arg)
		{
			vtkLabelPlacer.vtkLabelPlacer_SetMaximumLabelFraction_34(base.GetCppThis(), _arg);
		}

		// Token: 0x060032BD RID: 12989
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacer_SetOutputCoordinateSystem_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the coordinate system used for output labels.
		/// The output datasets may have point coordinates reported in the world space or display space.
		/// </summary>
		// Token: 0x060032BE RID: 12990 RVA: 0x0004AA53 File Offset: 0x00048C53
		public virtual void SetOutputCoordinateSystem(int _arg)
		{
			vtkLabelPlacer.vtkLabelPlacer_SetOutputCoordinateSystem_35(base.GetCppThis(), _arg);
		}

		// Token: 0x060032BF RID: 12991
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacer_SetOutputTraversedBounds_36(HandleRef pThis, byte _arg);

		/// <summary>
		/// In the second output, output the geometry of the traversed octree nodes.
		/// </summary>
		// Token: 0x060032C0 RID: 12992 RVA: 0x0004AA63 File Offset: 0x00048C63
		public virtual void SetOutputTraversedBounds(bool _arg)
		{
			vtkLabelPlacer.vtkLabelPlacer_SetOutputTraversedBounds_36(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060032C1 RID: 12993
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacer_SetPositionsAsNormals_37(HandleRef pThis, byte _arg);

		/// <summary>
		/// Use label anchor point coordinates as normal vectors and eliminate those
		/// pointing away from the camera. Valid only when points are on a sphere
		/// centered at the origin (such as a 3D geographic view). Off by default.
		/// </summary>
		// Token: 0x060032C2 RID: 12994 RVA: 0x0004AA7B File Offset: 0x00048C7B
		public virtual void SetPositionsAsNormals(bool _arg)
		{
			vtkLabelPlacer.vtkLabelPlacer_SetPositionsAsNormals_37(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060032C3 RID: 12995
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacer_SetRenderer_38(HandleRef pThis, HandleRef arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060032C4 RID: 12996 RVA: 0x0004AA94 File Offset: 0x00048C94
		public virtual void SetRenderer(vtkRenderer arg0)
		{
			vtkLabelPlacer.vtkLabelPlacer_SetRenderer_38(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060032C5 RID: 12997
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacer_SetUseDepthBuffer_39(HandleRef pThis, byte _arg);

		/// <summary>
		/// Use the depth buffer to test each label to see if it should not be displayed if
		/// it would be occluded by other objects in the scene. Off by default.
		/// </summary>
		// Token: 0x060032C6 RID: 12998 RVA: 0x0004AAC3 File Offset: 0x00048CC3
		public virtual void SetUseDepthBuffer(bool _arg)
		{
			vtkLabelPlacer.vtkLabelPlacer_SetUseDepthBuffer_39(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060032C7 RID: 12999
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacer_UseDepthBufferOff_40(HandleRef pThis);

		/// <summary>
		/// Use the depth buffer to test each label to see if it should not be displayed if
		/// it would be occluded by other objects in the scene. Off by default.
		/// </summary>
		// Token: 0x060032C8 RID: 13000 RVA: 0x0004AADB File Offset: 0x00048CDB
		public virtual void UseDepthBufferOff()
		{
			vtkLabelPlacer.vtkLabelPlacer_UseDepthBufferOff_40(base.GetCppThis());
		}

		// Token: 0x060032C9 RID: 13001
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelPlacer_UseDepthBufferOn_41(HandleRef pThis);

		/// <summary>
		/// Use the depth buffer to test each label to see if it should not be displayed if
		/// it would be occluded by other objects in the scene. Off by default.
		/// </summary>
		// Token: 0x060032CA RID: 13002 RVA: 0x0004AAEA File Offset: 0x00048CEA
		public virtual void UseDepthBufferOn()
		{
			vtkLabelPlacer.vtkLabelPlacer_UseDepthBufferOn_41(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005F7 RID: 1527
		public new const string MRFullTypeName = "Kitware.VTK.vtkLabelPlacer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005F8 RID: 1528
		public new static readonly string MRClassNameKey = "class vtkLabelPlacer";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020000F5 RID: 245
		public enum LabelGravity
		{
			/// <summary>enum member</summary>
			// Token: 0x040005FA RID: 1530
			BaselineCenter = 34,
			/// <summary>enum member</summary>
			// Token: 0x040005FB RID: 1531
			BaselineLeft = 18,
			/// <summary>enum member</summary>
			// Token: 0x040005FC RID: 1532
			BaselineRight = 66,
			/// <summary>enum member</summary>
			// Token: 0x040005FD RID: 1533
			CenterCenter = 36,
			/// <summary>enum member</summary>
			// Token: 0x040005FE RID: 1534
			CenterLeft = 20,
			/// <summary>enum member</summary>
			// Token: 0x040005FF RID: 1535
			CenterRight = 68,
			/// <summary>enum member</summary>
			// Token: 0x04000600 RID: 1536
			HorizontalBitMask = 112,
			/// <summary>enum member</summary>
			// Token: 0x04000601 RID: 1537
			HorizontalCenterBit = 32,
			/// <summary>enum member</summary>
			// Token: 0x04000602 RID: 1538
			HorizontalLeftBit = 16,
			/// <summary>enum member</summary>
			// Token: 0x04000603 RID: 1539
			HorizontalRightBit = 64,
			/// <summary>enum member</summary>
			// Token: 0x04000604 RID: 1540
			LowerCenter = 33,
			/// <summary>enum member</summary>
			// Token: 0x04000605 RID: 1541
			LowerLeft = 17,
			/// <summary>enum member</summary>
			// Token: 0x04000606 RID: 1542
			LowerRight = 65,
			/// <summary>enum member</summary>
			// Token: 0x04000607 RID: 1543
			UpperCenter = 40,
			/// <summary>enum member</summary>
			// Token: 0x04000608 RID: 1544
			UpperLeft = 24,
			/// <summary>enum member</summary>
			// Token: 0x04000609 RID: 1545
			UpperRight = 72,
			/// <summary>enum member</summary>
			// Token: 0x0400060A RID: 1546
			VerticalBaselineBit = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400060B RID: 1547
			VerticalBitMask = 15,
			/// <summary>enum member</summary>
			// Token: 0x0400060C RID: 1548
			VerticalBottomBit = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400060D RID: 1549
			VerticalCenterBit = 4,
			/// <summary>enum member</summary>
			// Token: 0x0400060E RID: 1550
			VerticalTopBit = 8
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020000F6 RID: 246
		public enum OutputCoordinates
		{
			/// <summary>enum member</summary>
			// Token: 0x04000610 RID: 1552
			DISPLAY = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000611 RID: 1553
			WORLD = 0
		}
	}
}
