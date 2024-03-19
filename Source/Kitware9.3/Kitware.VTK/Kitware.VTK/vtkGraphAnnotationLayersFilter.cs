using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGraphAnnotationLayersFilter
	/// </summary>
	/// <remarks>
	///    Produce filled convex hulls around
	/// subsets of vertices in a vtkGraph.
	///
	///
	/// Produces a vtkPolyData comprised of filled polygons of the convex hull
	/// of a cluster. Alternatively, you may choose to output bounding rectangles.
	/// Clusters with fewer than three vertices are artificially expanded to
	/// ensure visibility (see vtkConvexHull2D).
	///
	/// The first input is a vtkGraph with points, possibly set by
	/// passing the graph through vtkGraphLayout (z-values are ignored). The second
	/// input is a vtkAnnotationsLayer containing vtkSelectionNodeS of vertex
	/// ids (the 'clusters' output of vtkTulipReader for example).
	///
	/// Setting OutlineOn() additionally produces outlines of the clusters on
	/// output port 1.
	///
	/// Three arrays are added to the cells of the output: "Hull id"; "Hull name";
	/// and "Hull color".
	///
	/// Note: This filter operates in the x,y-plane and as such works best with an
	/// interactor style that does not allow camera rotation, such as
	/// vtkInteractorStyleRubberBand2D.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkContext2D
	///
	/// @par Thanks:
	/// Thanks to Colin Myers, University of Leeds for providing this implementation.
	/// </seealso>
	// Token: 0x020003CA RID: 970
	public class vtkGraphAnnotationLayersFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600B4C8 RID: 46280 RVA: 0x000FEC43 File Offset: 0x000FCE43
		static vtkGraphAnnotationLayersFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphAnnotationLayersFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphAnnotationLayersFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600B4C9 RID: 46281 RVA: 0x000FEC6B File Offset: 0x000FCE6B
		public vtkGraphAnnotationLayersFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600B4CA RID: 46282
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphAnnotationLayersFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B4CB RID: 46283 RVA: 0x000FEC7C File Offset: 0x000FCE7C
		public new static vtkGraphAnnotationLayersFilter New()
		{
			vtkGraphAnnotationLayersFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphAnnotationLayersFilter.vtkGraphAnnotationLayersFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphAnnotationLayersFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B4CC RID: 46284 RVA: 0x000FECD0 File Offset: 0x000FCED0
		public vtkGraphAnnotationLayersFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGraphAnnotationLayersFilter.vtkGraphAnnotationLayersFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600B4CD RID: 46285 RVA: 0x000FED14 File Offset: 0x000FCF14
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600B4CE RID: 46286
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkGraphAnnotationLayersFilter_GetMTime_01(HandleRef pThis);

		/// <summary>
		/// The modified time of this filter.
		/// </summary>
		// Token: 0x0600B4CF RID: 46287 RVA: 0x000FED20 File Offset: 0x000FCF20
		public override ulong GetMTime()
		{
			return vtkGraphAnnotationLayersFilter.vtkGraphAnnotationLayersFilter_GetMTime_01(base.GetCppThis());
		}

		// Token: 0x0600B4D0 RID: 46288
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphAnnotationLayersFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B4D1 RID: 46289 RVA: 0x000FED40 File Offset: 0x000FCF40
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGraphAnnotationLayersFilter.vtkGraphAnnotationLayersFilter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600B4D2 RID: 46290
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphAnnotationLayersFilter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B4D3 RID: 46291 RVA: 0x000FED60 File Offset: 0x000FCF60
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGraphAnnotationLayersFilter.vtkGraphAnnotationLayersFilter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600B4D4 RID: 46292
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphAnnotationLayersFilter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B4D5 RID: 46293 RVA: 0x000FED7C File Offset: 0x000FCF7C
		public override int IsA(string type)
		{
			return vtkGraphAnnotationLayersFilter.vtkGraphAnnotationLayersFilter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600B4D6 RID: 46294
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphAnnotationLayersFilter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B4D7 RID: 46295 RVA: 0x000FED9C File Offset: 0x000FCF9C
		public new static int IsTypeOf(string type)
		{
			return vtkGraphAnnotationLayersFilter.vtkGraphAnnotationLayersFilter_IsTypeOf_05(type);
		}

		// Token: 0x0600B4D8 RID: 46296
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphAnnotationLayersFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B4D9 RID: 46297 RVA: 0x000FEDB8 File Offset: 0x000FCFB8
		public new vtkGraphAnnotationLayersFilter NewInstance()
		{
			vtkGraphAnnotationLayersFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphAnnotationLayersFilter.vtkGraphAnnotationLayersFilter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphAnnotationLayersFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600B4DA RID: 46298
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphAnnotationLayersFilter_OutlineOff_08(HandleRef pThis);

		/// <summary>
		/// Produce outlines of the hulls on output port 1.
		/// </summary>
		// Token: 0x0600B4DB RID: 46299 RVA: 0x000FEE12 File Offset: 0x000FD012
		public void OutlineOff()
		{
			vtkGraphAnnotationLayersFilter.vtkGraphAnnotationLayersFilter_OutlineOff_08(base.GetCppThis());
		}

		// Token: 0x0600B4DC RID: 46300
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphAnnotationLayersFilter_OutlineOn_09(HandleRef pThis);

		/// <summary>
		/// Produce outlines of the hulls on output port 1.
		/// </summary>
		// Token: 0x0600B4DD RID: 46301 RVA: 0x000FEE21 File Offset: 0x000FD021
		public void OutlineOn()
		{
			vtkGraphAnnotationLayersFilter.vtkGraphAnnotationLayersFilter_OutlineOn_09(base.GetCppThis());
		}

		// Token: 0x0600B4DE RID: 46302
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphAnnotationLayersFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B4DF RID: 46303 RVA: 0x000FEE30 File Offset: 0x000FD030
		public new static vtkGraphAnnotationLayersFilter SafeDownCast(vtkObjectBase o)
		{
			vtkGraphAnnotationLayersFilter vtkGraphAnnotationLayersFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphAnnotationLayersFilter.vtkGraphAnnotationLayersFilter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphAnnotationLayersFilter = (vtkGraphAnnotationLayersFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphAnnotationLayersFilter.Register(null);
				}
			}
			return vtkGraphAnnotationLayersFilter;
		}

		// Token: 0x0600B4E0 RID: 46304
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphAnnotationLayersFilter_SetHullShapeToBoundingRectangle_11(HandleRef pThis);

		/// <summary>
		/// Set the shape of the hulls to bounding rectangle.
		/// </summary>
		// Token: 0x0600B4E1 RID: 46305 RVA: 0x000FEEAF File Offset: 0x000FD0AF
		public void SetHullShapeToBoundingRectangle()
		{
			vtkGraphAnnotationLayersFilter.vtkGraphAnnotationLayersFilter_SetHullShapeToBoundingRectangle_11(base.GetCppThis());
		}

		// Token: 0x0600B4E2 RID: 46306
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphAnnotationLayersFilter_SetHullShapeToConvexHull_12(HandleRef pThis);

		/// <summary>
		/// Set the shape of the hulls to convex hull. Default.
		/// </summary>
		// Token: 0x0600B4E3 RID: 46307 RVA: 0x000FEEBE File Offset: 0x000FD0BE
		public void SetHullShapeToConvexHull()
		{
			vtkGraphAnnotationLayersFilter.vtkGraphAnnotationLayersFilter_SetHullShapeToConvexHull_12(base.GetCppThis());
		}

		// Token: 0x0600B4E4 RID: 46308
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphAnnotationLayersFilter_SetMinHullSizeInDisplay_13(HandleRef pThis, int size);

		/// <summary>
		/// Set the minimum x,y-dimensions of each hull in pixels. You must also set a
		/// vtkRenderer. Defaults to 1. Set to 0 to disable.
		/// </summary>
		// Token: 0x0600B4E5 RID: 46309 RVA: 0x000FEECD File Offset: 0x000FD0CD
		public void SetMinHullSizeInDisplay(int size)
		{
			vtkGraphAnnotationLayersFilter.vtkGraphAnnotationLayersFilter_SetMinHullSizeInDisplay_13(base.GetCppThis(), size);
		}

		// Token: 0x0600B4E6 RID: 46310
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphAnnotationLayersFilter_SetMinHullSizeInWorld_14(HandleRef pThis, double size);

		/// <summary>
		/// Set the minimum x,y-dimensions of each hull in world coordinates. Defaults
		/// to 1.0. Set to 0.0 to disable.
		/// </summary>
		// Token: 0x0600B4E7 RID: 46311 RVA: 0x000FEEDD File Offset: 0x000FD0DD
		public void SetMinHullSizeInWorld(double size)
		{
			vtkGraphAnnotationLayersFilter.vtkGraphAnnotationLayersFilter_SetMinHullSizeInWorld_14(base.GetCppThis(), size);
		}

		// Token: 0x0600B4E8 RID: 46312
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphAnnotationLayersFilter_SetOutline_15(HandleRef pThis, byte b);

		/// <summary>
		/// Produce outlines of the hulls on output port 1.
		/// </summary>
		// Token: 0x0600B4E9 RID: 46313 RVA: 0x000FEEED File Offset: 0x000FD0ED
		public void SetOutline(bool b)
		{
			vtkGraphAnnotationLayersFilter.vtkGraphAnnotationLayersFilter_SetOutline_15(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B4EA RID: 46314
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphAnnotationLayersFilter_SetRenderer_16(HandleRef pThis, HandleRef renderer);

		/// <summary>
		/// Renderer needed for MinHullSizeInDisplay calculation. Not reference counted.
		/// </summary>
		// Token: 0x0600B4EB RID: 46315 RVA: 0x000FEF08 File Offset: 0x000FD108
		public void SetRenderer(vtkRenderer renderer)
		{
			vtkGraphAnnotationLayersFilter.vtkGraphAnnotationLayersFilter_SetRenderer_16(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		// Token: 0x0600B4EC RID: 46316
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphAnnotationLayersFilter_SetScaleFactor_17(HandleRef pThis, double scale);

		/// <summary>
		/// Scale each hull by the amount specified. Defaults to 1.0.
		/// </summary>
		// Token: 0x0600B4ED RID: 46317 RVA: 0x000FEF37 File Offset: 0x000FD137
		public void SetScaleFactor(double scale)
		{
			vtkGraphAnnotationLayersFilter.vtkGraphAnnotationLayersFilter_SetScaleFactor_17(base.GetCppThis(), scale);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DE9 RID: 3561
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphAnnotationLayersFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DEA RID: 3562
		public new static readonly string MRClassNameKey = "class vtkGraphAnnotationLayersFilter";
	}
}
