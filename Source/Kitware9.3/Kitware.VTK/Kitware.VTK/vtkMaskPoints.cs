using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMaskPoints
	/// </summary>
	/// <remarks>
	///    selectively filter points
	///
	/// vtkMaskPoints is a filter that passes through points and point attributes
	/// from input dataset. (Other geometry is not passed through.) It is
	/// possible to mask every nth point, and to specify an initial offset
	/// to begin masking from.
	/// It is possible to also generate different random selections
	/// (jittered strides, real random samples, and spatially stratified
	/// random samples) from the input data.
	/// The filter can also generate vertices (topological
	/// primitives) as well as points. This is useful because vertices are
	/// rendered while points are not.
	/// </remarks>
	// Token: 0x0200051C RID: 1308
	public class vtkMaskPoints : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EA66 RID: 60006 RVA: 0x00146E43 File Offset: 0x00145043
		static vtkMaskPoints()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMaskPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMaskPoints"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EA67 RID: 60007 RVA: 0x00146E6B File Offset: 0x0014506B
		public vtkMaskPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EA68 RID: 60008
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMaskPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EA69 RID: 60009 RVA: 0x00146E7C File Offset: 0x0014507C
		public new static vtkMaskPoints New()
		{
			vtkMaskPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMaskPoints.vtkMaskPoints_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMaskPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EA6A RID: 60010 RVA: 0x00146ED0 File Offset: 0x001450D0
		public vtkMaskPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMaskPoints.vtkMaskPoints_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EA6B RID: 60011 RVA: 0x00146F14 File Offset: 0x00145114
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EA6C RID: 60012
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPoints_GenerateVerticesOff_01(HandleRef pThis);

		/// <summary>
		/// Generate output polydata vertices as well as points. A useful
		/// convenience method because vertices are drawn (they are topology) while
		/// points are not (they are geometry). By default this method is off.
		/// </summary>
		// Token: 0x0600EA6D RID: 60013 RVA: 0x00146F1F File Offset: 0x0014511F
		public virtual void GenerateVerticesOff()
		{
			vtkMaskPoints.vtkMaskPoints_GenerateVerticesOff_01(base.GetCppThis());
		}

		// Token: 0x0600EA6E RID: 60014
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPoints_GenerateVerticesOn_02(HandleRef pThis);

		/// <summary>
		/// Generate output polydata vertices as well as points. A useful
		/// convenience method because vertices are drawn (they are topology) while
		/// points are not (they are geometry). By default this method is off.
		/// </summary>
		// Token: 0x0600EA6F RID: 60015 RVA: 0x00146F2E File Offset: 0x0014512E
		public virtual void GenerateVerticesOn()
		{
			vtkMaskPoints.vtkMaskPoints_GenerateVerticesOn_02(base.GetCppThis());
		}

		// Token: 0x0600EA70 RID: 60016
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMaskPoints_GetGenerateVertices_03(HandleRef pThis);

		/// <summary>
		/// Generate output polydata vertices as well as points. A useful
		/// convenience method because vertices are drawn (they are topology) while
		/// points are not (they are geometry). By default this method is off.
		/// </summary>
		// Token: 0x0600EA71 RID: 60017 RVA: 0x00146F40 File Offset: 0x00145140
		public virtual bool GetGenerateVertices()
		{
			return vtkMaskPoints.vtkMaskPoints_GetGenerateVertices_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600EA72 RID: 60018
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMaskPoints_GetMaximumNumberOfPoints_04(HandleRef pThis);

		/// <summary>
		/// Limit the number of points that can be passed through (i.e.,
		/// sets the output sample size).
		/// </summary>
		// Token: 0x0600EA73 RID: 60019 RVA: 0x00146F68 File Offset: 0x00145168
		public virtual long GetMaximumNumberOfPoints()
		{
			return vtkMaskPoints.vtkMaskPoints_GetMaximumNumberOfPoints_04(base.GetCppThis());
		}

		// Token: 0x0600EA74 RID: 60020
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMaskPoints_GetMaximumNumberOfPointsMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Limit the number of points that can be passed through (i.e.,
		/// sets the output sample size).
		/// </summary>
		// Token: 0x0600EA75 RID: 60021 RVA: 0x00146F88 File Offset: 0x00145188
		public virtual long GetMaximumNumberOfPointsMaxValue()
		{
			return vtkMaskPoints.vtkMaskPoints_GetMaximumNumberOfPointsMaxValue_05(base.GetCppThis());
		}

		// Token: 0x0600EA76 RID: 60022
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMaskPoints_GetMaximumNumberOfPointsMinValue_06(HandleRef pThis);

		/// <summary>
		/// Limit the number of points that can be passed through (i.e.,
		/// sets the output sample size).
		/// </summary>
		// Token: 0x0600EA77 RID: 60023 RVA: 0x00146FA8 File Offset: 0x001451A8
		public virtual long GetMaximumNumberOfPointsMinValue()
		{
			return vtkMaskPoints.vtkMaskPoints_GetMaximumNumberOfPointsMinValue_06(base.GetCppThis());
		}

		// Token: 0x0600EA78 RID: 60024
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMaskPoints_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EA79 RID: 60025 RVA: 0x00146FC8 File Offset: 0x001451C8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMaskPoints.vtkMaskPoints_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0600EA7A RID: 60026
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMaskPoints_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EA7B RID: 60027 RVA: 0x00146FE8 File Offset: 0x001451E8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMaskPoints.vtkMaskPoints_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0600EA7C RID: 60028
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMaskPoints_GetOffset_09(HandleRef pThis);

		/// <summary>
		/// Start sampling with this point. Ignored by certain random modes.
		/// </summary>
		// Token: 0x0600EA7D RID: 60029 RVA: 0x00147004 File Offset: 0x00145204
		public virtual long GetOffset()
		{
			return vtkMaskPoints.vtkMaskPoints_GetOffset_09(base.GetCppThis());
		}

		// Token: 0x0600EA7E RID: 60030
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMaskPoints_GetOffsetMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Start sampling with this point. Ignored by certain random modes.
		/// </summary>
		// Token: 0x0600EA7F RID: 60031 RVA: 0x00147024 File Offset: 0x00145224
		public virtual long GetOffsetMaxValue()
		{
			return vtkMaskPoints.vtkMaskPoints_GetOffsetMaxValue_10(base.GetCppThis());
		}

		// Token: 0x0600EA80 RID: 60032
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMaskPoints_GetOffsetMinValue_11(HandleRef pThis);

		/// <summary>
		/// Start sampling with this point. Ignored by certain random modes.
		/// </summary>
		// Token: 0x0600EA81 RID: 60033 RVA: 0x00147044 File Offset: 0x00145244
		public virtual long GetOffsetMinValue()
		{
			return vtkMaskPoints.vtkMaskPoints_GetOffsetMinValue_11(base.GetCppThis());
		}

		// Token: 0x0600EA82 RID: 60034
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMaskPoints_GetOnRatio_12(HandleRef pThis);

		/// <summary>
		/// Turn on every nth point (strided sampling), ignored by random modes.
		/// </summary>
		// Token: 0x0600EA83 RID: 60035 RVA: 0x00147064 File Offset: 0x00145264
		public virtual int GetOnRatio()
		{
			return vtkMaskPoints.vtkMaskPoints_GetOnRatio_12(base.GetCppThis());
		}

		// Token: 0x0600EA84 RID: 60036
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMaskPoints_GetOnRatioMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Turn on every nth point (strided sampling), ignored by random modes.
		/// </summary>
		// Token: 0x0600EA85 RID: 60037 RVA: 0x00147084 File Offset: 0x00145284
		public virtual int GetOnRatioMaxValue()
		{
			return vtkMaskPoints.vtkMaskPoints_GetOnRatioMaxValue_13(base.GetCppThis());
		}

		// Token: 0x0600EA86 RID: 60038
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMaskPoints_GetOnRatioMinValue_14(HandleRef pThis);

		/// <summary>
		/// Turn on every nth point (strided sampling), ignored by random modes.
		/// </summary>
		// Token: 0x0600EA87 RID: 60039 RVA: 0x001470A4 File Offset: 0x001452A4
		public virtual int GetOnRatioMinValue()
		{
			return vtkMaskPoints.vtkMaskPoints_GetOnRatioMinValue_14(base.GetCppThis());
		}

		// Token: 0x0600EA88 RID: 60040
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMaskPoints_GetOutputPointsPrecision_15(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x0600EA89 RID: 60041 RVA: 0x001470C4 File Offset: 0x001452C4
		public virtual int GetOutputPointsPrecision()
		{
			return vtkMaskPoints.vtkMaskPoints_GetOutputPointsPrecision_15(base.GetCppThis());
		}

		// Token: 0x0600EA8A RID: 60042
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMaskPoints_GetProportionalMaximumNumberOfPoints_16(HandleRef pThis);

		/// <summary>
		/// THIS ONLY WORKS WITH THE PARALLEL IMPLEMENTATION vtkPMaskPoints RUNNING
		/// IN PARALLEL.
		/// NOTHING WILL CHANGE IF THIS IS NOT THE PARALLEL vtkPMaskPoints.
		/// Determines whether maximum number of points is taken per processor
		/// (default) or if the maximum number of points is proportionally
		/// taken across processors (i.e., number of points per
		/// processor = points on a processor * maximum number of points /
		/// total points across all processors).  In the first case,
		/// the total number of points = maximum number of points *
		/// number of processors.  In the second case, the total number of
		/// points = maximum number of points.
		/// </summary>
		// Token: 0x0600EA8B RID: 60043 RVA: 0x001470E4 File Offset: 0x001452E4
		public virtual bool GetProportionalMaximumNumberOfPoints()
		{
			return vtkMaskPoints.vtkMaskPoints_GetProportionalMaximumNumberOfPoints_16(base.GetCppThis()) != 0;
		}

		// Token: 0x0600EA8C RID: 60044
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMaskPoints_GetRandomMode_17(HandleRef pThis);

		/// <summary>
		/// Special flag causes randomization of point selection.
		/// </summary>
		// Token: 0x0600EA8D RID: 60045 RVA: 0x0014710C File Offset: 0x0014530C
		public virtual bool GetRandomMode()
		{
			return vtkMaskPoints.vtkMaskPoints_GetRandomMode_17(base.GetCppThis()) != 0;
		}

		// Token: 0x0600EA8E RID: 60046
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMaskPoints_GetRandomModeType_18(HandleRef pThis);

		/// <summary>
		/// Special mode selector that switches between random mode types.
		/// 0 - randomized strides: randomly strides through the data (default);
		/// fairly certain that this is not a statistically random sample
		/// because the output depends on the order of the input and
		/// the input points do not have an equal chance to appear in the output
		/// (plus Vitter's incremental random algorithms are more complex
		/// than this, while not a proof it is good indication this isn't
		/// a statistically random sample - the closest would be algorithm S)
		/// 1 - random sample: create a statistically random sample using Vitter's
		/// incremental algorithm D without A described in Vitter
		/// "Faster Mthods for Random Sampling", Communications of the ACM
		/// Volume 27, Issue 7, 1984
		/// (OnRatio and Offset are ignored) O(sample size)
		/// 2 - spatially stratified random sample: create a spatially
		/// stratified random sample using the first method described in
		/// Woodring et al. "In-situ Sampling of a Large-Scale Particle
		/// Simulation for Interactive Visualization and Analysis",
		/// Computer Graphics Forum, 2011 (EuroVis 2011).
		/// (OnRatio and Offset are ignored) O(N log N)
		/// 3 - spatially uniform (bound based): point randomly sampled
		/// using a point locator and random positions inside the bounds
		/// of the data set.
		/// 4 - spatially uniform (surface based): points randomly sampled
		/// via an inverse transform on surface area of each cell.
		/// Note that 3D cells are ignored.
		/// 5 - spatially uniform (volume based): points randomly sampled via an
		/// inverse transform on volume area of each cell.
		/// Note that 2D cells are ignored.
		/// </summary>
		// Token: 0x0600EA8F RID: 60047 RVA: 0x00147134 File Offset: 0x00145334
		public virtual int GetRandomModeType()
		{
			return vtkMaskPoints.vtkMaskPoints_GetRandomModeType_18(base.GetCppThis());
		}

		// Token: 0x0600EA90 RID: 60048
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMaskPoints_GetRandomModeTypeMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Special mode selector that switches between random mode types.
		/// 0 - randomized strides: randomly strides through the data (default);
		/// fairly certain that this is not a statistically random sample
		/// because the output depends on the order of the input and
		/// the input points do not have an equal chance to appear in the output
		/// (plus Vitter's incremental random algorithms are more complex
		/// than this, while not a proof it is good indication this isn't
		/// a statistically random sample - the closest would be algorithm S)
		/// 1 - random sample: create a statistically random sample using Vitter's
		/// incremental algorithm D without A described in Vitter
		/// "Faster Mthods for Random Sampling", Communications of the ACM
		/// Volume 27, Issue 7, 1984
		/// (OnRatio and Offset are ignored) O(sample size)
		/// 2 - spatially stratified random sample: create a spatially
		/// stratified random sample using the first method described in
		/// Woodring et al. "In-situ Sampling of a Large-Scale Particle
		/// Simulation for Interactive Visualization and Analysis",
		/// Computer Graphics Forum, 2011 (EuroVis 2011).
		/// (OnRatio and Offset are ignored) O(N log N)
		/// 3 - spatially uniform (bound based): point randomly sampled
		/// using a point locator and random positions inside the bounds
		/// of the data set.
		/// 4 - spatially uniform (surface based): points randomly sampled
		/// via an inverse transform on surface area of each cell.
		/// Note that 3D cells are ignored.
		/// 5 - spatially uniform (volume based): points randomly sampled via an
		/// inverse transform on volume area of each cell.
		/// Note that 2D cells are ignored.
		/// </summary>
		// Token: 0x0600EA91 RID: 60049 RVA: 0x00147154 File Offset: 0x00145354
		public virtual int GetRandomModeTypeMaxValue()
		{
			return vtkMaskPoints.vtkMaskPoints_GetRandomModeTypeMaxValue_19(base.GetCppThis());
		}

		// Token: 0x0600EA92 RID: 60050
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMaskPoints_GetRandomModeTypeMinValue_20(HandleRef pThis);

		/// <summary>
		/// Special mode selector that switches between random mode types.
		/// 0 - randomized strides: randomly strides through the data (default);
		/// fairly certain that this is not a statistically random sample
		/// because the output depends on the order of the input and
		/// the input points do not have an equal chance to appear in the output
		/// (plus Vitter's incremental random algorithms are more complex
		/// than this, while not a proof it is good indication this isn't
		/// a statistically random sample - the closest would be algorithm S)
		/// 1 - random sample: create a statistically random sample using Vitter's
		/// incremental algorithm D without A described in Vitter
		/// "Faster Mthods for Random Sampling", Communications of the ACM
		/// Volume 27, Issue 7, 1984
		/// (OnRatio and Offset are ignored) O(sample size)
		/// 2 - spatially stratified random sample: create a spatially
		/// stratified random sample using the first method described in
		/// Woodring et al. "In-situ Sampling of a Large-Scale Particle
		/// Simulation for Interactive Visualization and Analysis",
		/// Computer Graphics Forum, 2011 (EuroVis 2011).
		/// (OnRatio and Offset are ignored) O(N log N)
		/// 3 - spatially uniform (bound based): point randomly sampled
		/// using a point locator and random positions inside the bounds
		/// of the data set.
		/// 4 - spatially uniform (surface based): points randomly sampled
		/// via an inverse transform on surface area of each cell.
		/// Note that 3D cells are ignored.
		/// 5 - spatially uniform (volume based): points randomly sampled via an
		/// inverse transform on volume area of each cell.
		/// Note that 2D cells are ignored.
		/// </summary>
		// Token: 0x0600EA93 RID: 60051 RVA: 0x00147174 File Offset: 0x00145374
		public virtual int GetRandomModeTypeMinValue()
		{
			return vtkMaskPoints.vtkMaskPoints_GetRandomModeTypeMinValue_20(base.GetCppThis());
		}

		// Token: 0x0600EA94 RID: 60052
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMaskPoints_GetRandomSeed_21(HandleRef pThis);

		/// <summary>
		/// Set/Get Seed used for generating a spatially uniform distributions.
		/// default is 1.
		/// </summary>
		// Token: 0x0600EA95 RID: 60053 RVA: 0x00147194 File Offset: 0x00145394
		public virtual int GetRandomSeed()
		{
			return vtkMaskPoints.vtkMaskPoints_GetRandomSeed_21(base.GetCppThis());
		}

		// Token: 0x0600EA96 RID: 60054
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMaskPoints_GetSingleVertexPerCell_22(HandleRef pThis);

		/// <summary>
		/// When vertex generation is enabled, by default vertices are produced
		/// as multi-vertex cells (more than one per cell), if you wish to have
		/// a single vertex per cell, enable this flag.
		/// </summary>
		// Token: 0x0600EA97 RID: 60055 RVA: 0x001471B4 File Offset: 0x001453B4
		public virtual bool GetSingleVertexPerCell()
		{
			return vtkMaskPoints.vtkMaskPoints_GetSingleVertexPerCell_22(base.GetCppThis()) != 0;
		}

		// Token: 0x0600EA98 RID: 60056
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMaskPoints_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EA99 RID: 60057 RVA: 0x001471DC File Offset: 0x001453DC
		public override int IsA(string type)
		{
			return vtkMaskPoints.vtkMaskPoints_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x0600EA9A RID: 60058
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMaskPoints_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EA9B RID: 60059 RVA: 0x001471FC File Offset: 0x001453FC
		public new static int IsTypeOf(string type)
		{
			return vtkMaskPoints.vtkMaskPoints_IsTypeOf_24(type);
		}

		// Token: 0x0600EA9C RID: 60060
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMaskPoints_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EA9D RID: 60061 RVA: 0x00147218 File Offset: 0x00145418
		public new vtkMaskPoints NewInstance()
		{
			vtkMaskPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMaskPoints.vtkMaskPoints_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMaskPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EA9E RID: 60062
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPoints_ProportionalMaximumNumberOfPointsOff_27(HandleRef pThis);

		/// <summary>
		/// THIS ONLY WORKS WITH THE PARALLEL IMPLEMENTATION vtkPMaskPoints RUNNING
		/// IN PARALLEL.
		/// NOTHING WILL CHANGE IF THIS IS NOT THE PARALLEL vtkPMaskPoints.
		/// Determines whether maximum number of points is taken per processor
		/// (default) or if the maximum number of points is proportionally
		/// taken across processors (i.e., number of points per
		/// processor = points on a processor * maximum number of points /
		/// total points across all processors).  In the first case,
		/// the total number of points = maximum number of points *
		/// number of processors.  In the second case, the total number of
		/// points = maximum number of points.
		/// </summary>
		// Token: 0x0600EA9F RID: 60063 RVA: 0x00147272 File Offset: 0x00145472
		public virtual void ProportionalMaximumNumberOfPointsOff()
		{
			vtkMaskPoints.vtkMaskPoints_ProportionalMaximumNumberOfPointsOff_27(base.GetCppThis());
		}

		// Token: 0x0600EAA0 RID: 60064
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPoints_ProportionalMaximumNumberOfPointsOn_28(HandleRef pThis);

		/// <summary>
		/// THIS ONLY WORKS WITH THE PARALLEL IMPLEMENTATION vtkPMaskPoints RUNNING
		/// IN PARALLEL.
		/// NOTHING WILL CHANGE IF THIS IS NOT THE PARALLEL vtkPMaskPoints.
		/// Determines whether maximum number of points is taken per processor
		/// (default) or if the maximum number of points is proportionally
		/// taken across processors (i.e., number of points per
		/// processor = points on a processor * maximum number of points /
		/// total points across all processors).  In the first case,
		/// the total number of points = maximum number of points *
		/// number of processors.  In the second case, the total number of
		/// points = maximum number of points.
		/// </summary>
		// Token: 0x0600EAA1 RID: 60065 RVA: 0x00147281 File Offset: 0x00145481
		public virtual void ProportionalMaximumNumberOfPointsOn()
		{
			vtkMaskPoints.vtkMaskPoints_ProportionalMaximumNumberOfPointsOn_28(base.GetCppThis());
		}

		// Token: 0x0600EAA2 RID: 60066
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPoints_RandomModeOff_29(HandleRef pThis);

		/// <summary>
		/// Special flag causes randomization of point selection.
		/// </summary>
		// Token: 0x0600EAA3 RID: 60067 RVA: 0x00147290 File Offset: 0x00145490
		public virtual void RandomModeOff()
		{
			vtkMaskPoints.vtkMaskPoints_RandomModeOff_29(base.GetCppThis());
		}

		// Token: 0x0600EAA4 RID: 60068
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPoints_RandomModeOn_30(HandleRef pThis);

		/// <summary>
		/// Special flag causes randomization of point selection.
		/// </summary>
		// Token: 0x0600EAA5 RID: 60069 RVA: 0x0014729F File Offset: 0x0014549F
		public virtual void RandomModeOn()
		{
			vtkMaskPoints.vtkMaskPoints_RandomModeOn_30(base.GetCppThis());
		}

		// Token: 0x0600EAA6 RID: 60070
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMaskPoints_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EAA7 RID: 60071 RVA: 0x001472B0 File Offset: 0x001454B0
		public new static vtkMaskPoints SafeDownCast(vtkObjectBase o)
		{
			vtkMaskPoints vtkMaskPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMaskPoints.vtkMaskPoints_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMaskPoints = (vtkMaskPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMaskPoints.Register(null);
				}
			}
			return vtkMaskPoints;
		}

		// Token: 0x0600EAA8 RID: 60072
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPoints_SetGenerateVertices_32(HandleRef pThis, byte _arg);

		/// <summary>
		/// Generate output polydata vertices as well as points. A useful
		/// convenience method because vertices are drawn (they are topology) while
		/// points are not (they are geometry). By default this method is off.
		/// </summary>
		// Token: 0x0600EAA9 RID: 60073 RVA: 0x0014732F File Offset: 0x0014552F
		public virtual void SetGenerateVertices(bool _arg)
		{
			vtkMaskPoints.vtkMaskPoints_SetGenerateVertices_32(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600EAAA RID: 60074
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPoints_SetMaximumNumberOfPoints_33(HandleRef pThis, long _arg);

		/// <summary>
		/// Limit the number of points that can be passed through (i.e.,
		/// sets the output sample size).
		/// </summary>
		// Token: 0x0600EAAB RID: 60075 RVA: 0x00147347 File Offset: 0x00145547
		public virtual void SetMaximumNumberOfPoints(long _arg)
		{
			vtkMaskPoints.vtkMaskPoints_SetMaximumNumberOfPoints_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EAAC RID: 60076
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPoints_SetOffset_34(HandleRef pThis, long _arg);

		/// <summary>
		/// Start sampling with this point. Ignored by certain random modes.
		/// </summary>
		// Token: 0x0600EAAD RID: 60077 RVA: 0x00147357 File Offset: 0x00145557
		public virtual void SetOffset(long _arg)
		{
			vtkMaskPoints.vtkMaskPoints_SetOffset_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EAAE RID: 60078
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPoints_SetOnRatio_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on every nth point (strided sampling), ignored by random modes.
		/// </summary>
		// Token: 0x0600EAAF RID: 60079 RVA: 0x00147367 File Offset: 0x00145567
		public virtual void SetOnRatio(int _arg)
		{
			vtkMaskPoints.vtkMaskPoints_SetOnRatio_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EAB0 RID: 60080
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPoints_SetOutputPointsPrecision_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x0600EAB1 RID: 60081 RVA: 0x00147377 File Offset: 0x00145577
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkMaskPoints.vtkMaskPoints_SetOutputPointsPrecision_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EAB2 RID: 60082
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPoints_SetProportionalMaximumNumberOfPoints_37(HandleRef pThis, byte _arg);

		/// <summary>
		/// THIS ONLY WORKS WITH THE PARALLEL IMPLEMENTATION vtkPMaskPoints RUNNING
		/// IN PARALLEL.
		/// NOTHING WILL CHANGE IF THIS IS NOT THE PARALLEL vtkPMaskPoints.
		/// Determines whether maximum number of points is taken per processor
		/// (default) or if the maximum number of points is proportionally
		/// taken across processors (i.e., number of points per
		/// processor = points on a processor * maximum number of points /
		/// total points across all processors).  In the first case,
		/// the total number of points = maximum number of points *
		/// number of processors.  In the second case, the total number of
		/// points = maximum number of points.
		/// </summary>
		// Token: 0x0600EAB3 RID: 60083 RVA: 0x00147387 File Offset: 0x00145587
		public virtual void SetProportionalMaximumNumberOfPoints(bool _arg)
		{
			vtkMaskPoints.vtkMaskPoints_SetProportionalMaximumNumberOfPoints_37(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600EAB4 RID: 60084
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPoints_SetRandomMode_38(HandleRef pThis, byte _arg);

		/// <summary>
		/// Special flag causes randomization of point selection.
		/// </summary>
		// Token: 0x0600EAB5 RID: 60085 RVA: 0x0014739F File Offset: 0x0014559F
		public virtual void SetRandomMode(bool _arg)
		{
			vtkMaskPoints.vtkMaskPoints_SetRandomMode_38(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600EAB6 RID: 60086
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPoints_SetRandomModeType_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Special mode selector that switches between random mode types.
		/// 0 - randomized strides: randomly strides through the data (default);
		/// fairly certain that this is not a statistically random sample
		/// because the output depends on the order of the input and
		/// the input points do not have an equal chance to appear in the output
		/// (plus Vitter's incremental random algorithms are more complex
		/// than this, while not a proof it is good indication this isn't
		/// a statistically random sample - the closest would be algorithm S)
		/// 1 - random sample: create a statistically random sample using Vitter's
		/// incremental algorithm D without A described in Vitter
		/// "Faster Mthods for Random Sampling", Communications of the ACM
		/// Volume 27, Issue 7, 1984
		/// (OnRatio and Offset are ignored) O(sample size)
		/// 2 - spatially stratified random sample: create a spatially
		/// stratified random sample using the first method described in
		/// Woodring et al. "In-situ Sampling of a Large-Scale Particle
		/// Simulation for Interactive Visualization and Analysis",
		/// Computer Graphics Forum, 2011 (EuroVis 2011).
		/// (OnRatio and Offset are ignored) O(N log N)
		/// 3 - spatially uniform (bound based): point randomly sampled
		/// using a point locator and random positions inside the bounds
		/// of the data set.
		/// 4 - spatially uniform (surface based): points randomly sampled
		/// via an inverse transform on surface area of each cell.
		/// Note that 3D cells are ignored.
		/// 5 - spatially uniform (volume based): points randomly sampled via an
		/// inverse transform on volume area of each cell.
		/// Note that 2D cells are ignored.
		/// </summary>
		// Token: 0x0600EAB7 RID: 60087 RVA: 0x001473B7 File Offset: 0x001455B7
		public virtual void SetRandomModeType(int _arg)
		{
			vtkMaskPoints.vtkMaskPoints_SetRandomModeType_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EAB8 RID: 60088
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPoints_SetRandomSeed_40(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get Seed used for generating a spatially uniform distributions.
		/// default is 1.
		/// </summary>
		// Token: 0x0600EAB9 RID: 60089 RVA: 0x001473C7 File Offset: 0x001455C7
		public virtual void SetRandomSeed(int _arg)
		{
			vtkMaskPoints.vtkMaskPoints_SetRandomSeed_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EABA RID: 60090
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPoints_SetSingleVertexPerCell_41(HandleRef pThis, byte _arg);

		/// <summary>
		/// When vertex generation is enabled, by default vertices are produced
		/// as multi-vertex cells (more than one per cell), if you wish to have
		/// a single vertex per cell, enable this flag.
		/// </summary>
		// Token: 0x0600EABB RID: 60091 RVA: 0x001473D7 File Offset: 0x001455D7
		public virtual void SetSingleVertexPerCell(bool _arg)
		{
			vtkMaskPoints.vtkMaskPoints_SetSingleVertexPerCell_41(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600EABC RID: 60092
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPoints_SingleVertexPerCellOff_42(HandleRef pThis);

		/// <summary>
		/// When vertex generation is enabled, by default vertices are produced
		/// as multi-vertex cells (more than one per cell), if you wish to have
		/// a single vertex per cell, enable this flag.
		/// </summary>
		// Token: 0x0600EABD RID: 60093 RVA: 0x001473EF File Offset: 0x001455EF
		public virtual void SingleVertexPerCellOff()
		{
			vtkMaskPoints.vtkMaskPoints_SingleVertexPerCellOff_42(base.GetCppThis());
		}

		// Token: 0x0600EABE RID: 60094
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPoints_SingleVertexPerCellOn_43(HandleRef pThis);

		/// <summary>
		/// When vertex generation is enabled, by default vertices are produced
		/// as multi-vertex cells (more than one per cell), if you wish to have
		/// a single vertex per cell, enable this flag.
		/// </summary>
		// Token: 0x0600EABF RID: 60095 RVA: 0x001473FE File Offset: 0x001455FE
		public virtual void SingleVertexPerCellOn()
		{
			vtkMaskPoints.vtkMaskPoints_SingleVertexPerCellOn_43(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001122 RID: 4386
		public new const string MRFullTypeName = "Kitware.VTK.vtkMaskPoints";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001123 RID: 4387
		public new static readonly string MRClassNameKey = "class vtkMaskPoints";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200051D RID: 1309
		public enum DistributionType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001125 RID: 4389
			RANDOMIZED_ID_STRIDES,
			/// <summary>enum member</summary>
			// Token: 0x04001126 RID: 4390
			RANDOM_SAMPLING,
			/// <summary>enum member</summary>
			// Token: 0x04001127 RID: 4391
			SPATIALLY_STRATIFIED,
			/// <summary>enum member</summary>
			// Token: 0x04001128 RID: 4392
			UNIFORM_SPATIAL_BOUNDS,
			/// <summary>enum member</summary>
			// Token: 0x04001129 RID: 4393
			UNIFORM_SPATIAL_SURFACE,
			/// <summary>enum member</summary>
			// Token: 0x0400112A RID: 4394
			UNIFORM_SPATIAL_VOLUME
		}
	}
}
