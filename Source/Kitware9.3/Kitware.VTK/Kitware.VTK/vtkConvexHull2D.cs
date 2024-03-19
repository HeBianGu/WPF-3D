using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkConvexHull2D
	/// </summary>
	/// <remarks>
	///    Produce filled convex hulls around a set of points.
	///
	///
	/// Produces a vtkPolyData comprised of a filled polygon of the convex hull
	/// of the input points. You may alternatively choose to output a bounding
	/// rectangle. Static methods are provided that calculate a (counter-clockwise)
	/// hull based on a set of input points.
	///
	/// To help maintain the property of &lt;i&gt;guaranteed visibility&lt;/i&gt; hulls may be
	/// artificially scaled by setting MinHullSizeInWorld. This is particularly
	/// helpful in the case that there are only one or two points as it avoids
	/// producing a degenerate polygon. This setting is also available as an
	/// argument to the static methods.
	///
	/// Setting a vtkRenderer on the filter enables the possibility to set
	/// MinHullSizeInDisplay to the desired number of display pixels to cover in
	/// each of the x- and y-dimensions.
	///
	/// Setting OutlineOn() additionally produces an outline of the hull on output
	/// port 1.
	///
	/// @attention
	/// This filter operates in the x,y-plane and as such works best with an
	/// interactor style that does not permit camera rotation such as
	/// vtkInteractorStyleRubberBand2D.
	///
	/// @par Thanks:
	/// Thanks to Colin Myers, University of Leeds for providing this implementation.
	/// </remarks>
	// Token: 0x020003C0 RID: 960
	public class vtkConvexHull2D : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600B17A RID: 45434 RVA: 0x000FAEAD File Offset: 0x000F90AD
		static vtkConvexHull2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConvexHull2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConvexHull2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600B17B RID: 45435 RVA: 0x000FAED5 File Offset: 0x000F90D5
		public vtkConvexHull2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600B17C RID: 45436
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvexHull2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B17D RID: 45437 RVA: 0x000FAEE4 File Offset: 0x000F90E4
		public new static vtkConvexHull2D New()
		{
			vtkConvexHull2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvexHull2D.vtkConvexHull2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConvexHull2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B17E RID: 45438 RVA: 0x000FAF38 File Offset: 0x000F9138
		public vtkConvexHull2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkConvexHull2D.vtkConvexHull2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600B17F RID: 45439 RVA: 0x000FAF7C File Offset: 0x000F917C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600B180 RID: 45440
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvexHull2D_CalculateBoundingRectangle_01(HandleRef inPoints, HandleRef outPoints, double minimumHullSize);

		/// <summary>
		/// Convenience methods to calculate a convex hull from a set of vtkPointS.
		/// </summary>
		// Token: 0x0600B181 RID: 45441 RVA: 0x000FAF88 File Offset: 0x000F9188
		public static void CalculateBoundingRectangle(vtkPoints inPoints, vtkPoints outPoints, double minimumHullSize)
		{
			vtkConvexHull2D.vtkConvexHull2D_CalculateBoundingRectangle_01((inPoints == null) ? default(HandleRef) : inPoints.GetCppThis(), (outPoints == null) ? default(HandleRef) : outPoints.GetCppThis(), minimumHullSize);
		}

		// Token: 0x0600B182 RID: 45442
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvexHull2D_CalculateConvexHull_02(HandleRef inPoints, HandleRef outPoints, double minimumHullSize);

		/// <summary>
		/// Convenience methods to calculate a convex hull from a set of vtkPointS.
		/// </summary>
		// Token: 0x0600B183 RID: 45443 RVA: 0x000FAFC8 File Offset: 0x000F91C8
		public static void CalculateConvexHull(vtkPoints inPoints, vtkPoints outPoints, double minimumHullSize)
		{
			vtkConvexHull2D.vtkConvexHull2D_CalculateConvexHull_02((inPoints == null) ? default(HandleRef) : inPoints.GetCppThis(), (outPoints == null) ? default(HandleRef) : outPoints.GetCppThis(), minimumHullSize);
		}

		// Token: 0x0600B184 RID: 45444
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvexHull2D_GetHullShape_03(HandleRef pThis);

		/// <summary>
		/// Set the shape of the hull to BoundingRectangle or ConvexHull.
		/// </summary>
		// Token: 0x0600B185 RID: 45445 RVA: 0x000FB008 File Offset: 0x000F9208
		public virtual int GetHullShape()
		{
			return vtkConvexHull2D.vtkConvexHull2D_GetHullShape_03(base.GetCppThis());
		}

		// Token: 0x0600B186 RID: 45446
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvexHull2D_GetHullShapeMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Set the shape of the hull to BoundingRectangle or ConvexHull.
		/// </summary>
		// Token: 0x0600B187 RID: 45447 RVA: 0x000FB028 File Offset: 0x000F9228
		public virtual int GetHullShapeMaxValue()
		{
			return vtkConvexHull2D.vtkConvexHull2D_GetHullShapeMaxValue_04(base.GetCppThis());
		}

		// Token: 0x0600B188 RID: 45448
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvexHull2D_GetHullShapeMinValue_05(HandleRef pThis);

		/// <summary>
		/// Set the shape of the hull to BoundingRectangle or ConvexHull.
		/// </summary>
		// Token: 0x0600B189 RID: 45449 RVA: 0x000FB048 File Offset: 0x000F9248
		public virtual int GetHullShapeMinValue()
		{
			return vtkConvexHull2D.vtkConvexHull2D_GetHullShapeMinValue_05(base.GetCppThis());
		}

		// Token: 0x0600B18A RID: 45450
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkConvexHull2D_GetMTime_06(HandleRef pThis);

		/// <summary>
		/// The modified time of this filter.
		/// </summary>
		// Token: 0x0600B18B RID: 45451 RVA: 0x000FB068 File Offset: 0x000F9268
		public override ulong GetMTime()
		{
			return vtkConvexHull2D.vtkConvexHull2D_GetMTime_06(base.GetCppThis());
		}

		// Token: 0x0600B18C RID: 45452
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvexHull2D_GetMinHullSizeInDisplay_07(HandleRef pThis);

		/// <summary>
		/// Set the minimum x,y-dimensions of each hull in pixels. You must also set a
		/// vtkRenderer. Defaults to 1. Set to 0 to disable.
		/// </summary>
		// Token: 0x0600B18D RID: 45453 RVA: 0x000FB088 File Offset: 0x000F9288
		public virtual int GetMinHullSizeInDisplay()
		{
			return vtkConvexHull2D.vtkConvexHull2D_GetMinHullSizeInDisplay_07(base.GetCppThis());
		}

		// Token: 0x0600B18E RID: 45454
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvexHull2D_GetMinHullSizeInDisplayMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set the minimum x,y-dimensions of each hull in pixels. You must also set a
		/// vtkRenderer. Defaults to 1. Set to 0 to disable.
		/// </summary>
		// Token: 0x0600B18F RID: 45455 RVA: 0x000FB0A8 File Offset: 0x000F92A8
		public virtual int GetMinHullSizeInDisplayMaxValue()
		{
			return vtkConvexHull2D.vtkConvexHull2D_GetMinHullSizeInDisplayMaxValue_08(base.GetCppThis());
		}

		// Token: 0x0600B190 RID: 45456
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvexHull2D_GetMinHullSizeInDisplayMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set the minimum x,y-dimensions of each hull in pixels. You must also set a
		/// vtkRenderer. Defaults to 1. Set to 0 to disable.
		/// </summary>
		// Token: 0x0600B191 RID: 45457 RVA: 0x000FB0C8 File Offset: 0x000F92C8
		public virtual int GetMinHullSizeInDisplayMinValue()
		{
			return vtkConvexHull2D.vtkConvexHull2D_GetMinHullSizeInDisplayMinValue_09(base.GetCppThis());
		}

		// Token: 0x0600B192 RID: 45458
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConvexHull2D_GetMinHullSizeInWorld_10(HandleRef pThis);

		/// <summary>
		/// Set the minimum x,y-dimensions of each hull in world coordinates. Defaults
		/// to 1.0. Set to 0.0 to disable.
		/// </summary>
		// Token: 0x0600B193 RID: 45459 RVA: 0x000FB0E8 File Offset: 0x000F92E8
		public virtual double GetMinHullSizeInWorld()
		{
			return vtkConvexHull2D.vtkConvexHull2D_GetMinHullSizeInWorld_10(base.GetCppThis());
		}

		// Token: 0x0600B194 RID: 45460
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConvexHull2D_GetMinHullSizeInWorldMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Set the minimum x,y-dimensions of each hull in world coordinates. Defaults
		/// to 1.0. Set to 0.0 to disable.
		/// </summary>
		// Token: 0x0600B195 RID: 45461 RVA: 0x000FB108 File Offset: 0x000F9308
		public virtual double GetMinHullSizeInWorldMaxValue()
		{
			return vtkConvexHull2D.vtkConvexHull2D_GetMinHullSizeInWorldMaxValue_11(base.GetCppThis());
		}

		// Token: 0x0600B196 RID: 45462
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConvexHull2D_GetMinHullSizeInWorldMinValue_12(HandleRef pThis);

		/// <summary>
		/// Set the minimum x,y-dimensions of each hull in world coordinates. Defaults
		/// to 1.0. Set to 0.0 to disable.
		/// </summary>
		// Token: 0x0600B197 RID: 45463 RVA: 0x000FB128 File Offset: 0x000F9328
		public virtual double GetMinHullSizeInWorldMinValue()
		{
			return vtkConvexHull2D.vtkConvexHull2D_GetMinHullSizeInWorldMinValue_12(base.GetCppThis());
		}

		// Token: 0x0600B198 RID: 45464
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConvexHull2D_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B199 RID: 45465 RVA: 0x000FB148 File Offset: 0x000F9348
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkConvexHull2D.vtkConvexHull2D_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0600B19A RID: 45466
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConvexHull2D_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B19B RID: 45467 RVA: 0x000FB168 File Offset: 0x000F9368
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkConvexHull2D.vtkConvexHull2D_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0600B19C RID: 45468
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkConvexHull2D_GetOutline_15(HandleRef pThis);

		/// <summary>
		/// Produce an outline (polyline) of the hull on output port 1.
		/// </summary>
		// Token: 0x0600B19D RID: 45469 RVA: 0x000FB184 File Offset: 0x000F9384
		public virtual bool GetOutline()
		{
			return vtkConvexHull2D.vtkConvexHull2D_GetOutline_15(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B19E RID: 45470
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvexHull2D_GetRenderer_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Renderer needed for MinHullSizeInDisplay calculation. Not reference counted.
		/// </summary>
		// Token: 0x0600B19F RID: 45471 RVA: 0x000FB1AC File Offset: 0x000F93AC
		public vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvexHull2D.vtkConvexHull2D_GetRenderer_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B1A0 RID: 45472
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConvexHull2D_GetScaleFactor_17(HandleRef pThis);

		/// <summary>
		/// Scale the hull by the amount specified. Defaults to 1.0.
		/// </summary>
		// Token: 0x0600B1A1 RID: 45473 RVA: 0x000FB21C File Offset: 0x000F941C
		public virtual double GetScaleFactor()
		{
			return vtkConvexHull2D.vtkConvexHull2D_GetScaleFactor_17(base.GetCppThis());
		}

		// Token: 0x0600B1A2 RID: 45474
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvexHull2D_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B1A3 RID: 45475 RVA: 0x000FB23C File Offset: 0x000F943C
		public override int IsA(string type)
		{
			return vtkConvexHull2D.vtkConvexHull2D_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0600B1A4 RID: 45476
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvexHull2D_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B1A5 RID: 45477 RVA: 0x000FB25C File Offset: 0x000F945C
		public new static int IsTypeOf(string type)
		{
			return vtkConvexHull2D.vtkConvexHull2D_IsTypeOf_19(type);
		}

		// Token: 0x0600B1A6 RID: 45478
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvexHull2D_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B1A7 RID: 45479 RVA: 0x000FB278 File Offset: 0x000F9478
		public new vtkConvexHull2D NewInstance()
		{
			vtkConvexHull2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvexHull2D.vtkConvexHull2D_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConvexHull2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600B1A8 RID: 45480
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvexHull2D_OutlineOff_22(HandleRef pThis);

		/// <summary>
		/// Produce an outline (polyline) of the hull on output port 1.
		/// </summary>
		// Token: 0x0600B1A9 RID: 45481 RVA: 0x000FB2D2 File Offset: 0x000F94D2
		public virtual void OutlineOff()
		{
			vtkConvexHull2D.vtkConvexHull2D_OutlineOff_22(base.GetCppThis());
		}

		// Token: 0x0600B1AA RID: 45482
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvexHull2D_OutlineOn_23(HandleRef pThis);

		/// <summary>
		/// Produce an outline (polyline) of the hull on output port 1.
		/// </summary>
		// Token: 0x0600B1AB RID: 45483 RVA: 0x000FB2E1 File Offset: 0x000F94E1
		public virtual void OutlineOn()
		{
			vtkConvexHull2D.vtkConvexHull2D_OutlineOn_23(base.GetCppThis());
		}

		// Token: 0x0600B1AC RID: 45484
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvexHull2D_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B1AD RID: 45485 RVA: 0x000FB2F0 File Offset: 0x000F94F0
		public new static vtkConvexHull2D SafeDownCast(vtkObjectBase o)
		{
			vtkConvexHull2D vtkConvexHull2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvexHull2D.vtkConvexHull2D_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConvexHull2D = (vtkConvexHull2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConvexHull2D.Register(null);
				}
			}
			return vtkConvexHull2D;
		}

		// Token: 0x0600B1AE RID: 45486
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvexHull2D_SetHullShape_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the shape of the hull to BoundingRectangle or ConvexHull.
		/// </summary>
		// Token: 0x0600B1AF RID: 45487 RVA: 0x000FB36F File Offset: 0x000F956F
		public virtual void SetHullShape(int _arg)
		{
			vtkConvexHull2D.vtkConvexHull2D_SetHullShape_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B1B0 RID: 45488
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvexHull2D_SetMinHullSizeInDisplay_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the minimum x,y-dimensions of each hull in pixels. You must also set a
		/// vtkRenderer. Defaults to 1. Set to 0 to disable.
		/// </summary>
		// Token: 0x0600B1B1 RID: 45489 RVA: 0x000FB37F File Offset: 0x000F957F
		public virtual void SetMinHullSizeInDisplay(int _arg)
		{
			vtkConvexHull2D.vtkConvexHull2D_SetMinHullSizeInDisplay_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B1B2 RID: 45490
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvexHull2D_SetMinHullSizeInWorld_27(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the minimum x,y-dimensions of each hull in world coordinates. Defaults
		/// to 1.0. Set to 0.0 to disable.
		/// </summary>
		// Token: 0x0600B1B3 RID: 45491 RVA: 0x000FB38F File Offset: 0x000F958F
		public virtual void SetMinHullSizeInWorld(double _arg)
		{
			vtkConvexHull2D.vtkConvexHull2D_SetMinHullSizeInWorld_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B1B4 RID: 45492
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvexHull2D_SetOutline_28(HandleRef pThis, byte _arg);

		/// <summary>
		/// Produce an outline (polyline) of the hull on output port 1.
		/// </summary>
		// Token: 0x0600B1B5 RID: 45493 RVA: 0x000FB39F File Offset: 0x000F959F
		public virtual void SetOutline(bool _arg)
		{
			vtkConvexHull2D.vtkConvexHull2D_SetOutline_28(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B1B6 RID: 45494
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvexHull2D_SetRenderer_29(HandleRef pThis, HandleRef renderer);

		/// <summary>
		/// Renderer needed for MinHullSizeInDisplay calculation. Not reference counted.
		/// </summary>
		// Token: 0x0600B1B7 RID: 45495 RVA: 0x000FB3B8 File Offset: 0x000F95B8
		public void SetRenderer(vtkRenderer renderer)
		{
			vtkConvexHull2D.vtkConvexHull2D_SetRenderer_29(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		// Token: 0x0600B1B8 RID: 45496
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvexHull2D_SetScaleFactor_30(HandleRef pThis, double _arg);

		/// <summary>
		/// Scale the hull by the amount specified. Defaults to 1.0.
		/// </summary>
		// Token: 0x0600B1B9 RID: 45497 RVA: 0x000FB3E7 File Offset: 0x000F95E7
		public virtual void SetScaleFactor(double _arg)
		{
			vtkConvexHull2D.vtkConvexHull2D_SetScaleFactor_30(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DC3 RID: 3523
		public new const string MRFullTypeName = "Kitware.VTK.vtkConvexHull2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DC4 RID: 3524
		public new static readonly string MRClassNameKey = "class vtkConvexHull2D";

		/// <summary>
		/// Produce an outline (polyline) of the hull on output port 1.
		/// </summary>
		// Token: 0x020003C1 RID: 961
		public enum HullShapes
		{
			/// <summary>enum member</summary>
			// Token: 0x04000DC6 RID: 3526
			BoundingRectangle,
			/// <summary>enum member</summary>
			// Token: 0x04000DC7 RID: 3527
			ConvexHull
		}
	}
}
