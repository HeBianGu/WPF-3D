using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCubeAxesActor
	/// </summary>
	/// <remarks>
	///    create a plot of a bounding box edges -
	/// used for navigation
	///
	/// vtkCubeAxesActor is a composite actor that draws axes of the
	/// bounding box of an input dataset. The axes include labels and titles
	/// for the x-y-z axes. The algorithm selects which axes to draw based
	/// on the user-defined 'fly' mode.  (STATIC is default).
	/// 'STATIC' constructs axes from all edges of the bounding box.
	/// 'CLOSEST_TRIAD' consists of the three axes x-y-z forming a triad that
	/// lies closest to the specified camera.
	/// 'FURTHEST_TRIAD' consists of the three axes x-y-z forming a triad that
	/// lies furthest from the specified camera.
	/// 'OUTER_EDGES' is constructed from edges that are on the "exterior" of the
	/// bounding box, exterior as determined from examining outer edges of the
	/// bounding box in projection (display) space.
	///
	/// To use this object you must define a bounding box and the camera used
	/// to render the vtkCubeAxesActor. You can optionally turn on/off labels,
	/// ticks, gridlines, and set tick location, number of labels, and text to
	/// use for axis-titles.  A 'corner offset' can also be set.  This allows
	/// the axes to be set partially away from the actual bounding box to perhaps
	/// prevent overlap of labels between the various axes.
	///
	/// The Bounds instance variable (an array of six doubles) is used to determine
	/// the bounding box.
	///
	/// @par Thanks:
	/// This class was written by:
	/// Hank Childs, Kathleen Bonnell, Amy Squillacote, Brad Whitlock, Will Schroeder,
	/// Eric Brugger, Daniel Aguilera, Claire Guilbaud, Nicolas Dolegieviez,
	/// Aashish Chaudhary, Philippe Pebay, David Gobbi, David Partyka, Utkarsh Ayachit
	/// David Cole, Francois Bertel, and Mark Olesen
	/// Part of this work was supported by CEA/DIF - Commissariat a l'Energie Atomique,
	/// Centre DAM Ile-De-France, BP12, F-91297 Arpajon, France.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkActor vtkAxisActor vtkCubeAxesActor2D
	/// </seealso>
	// Token: 0x020003C4 RID: 964
	public class vtkCubeAxesActor : vtkActor
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600B20E RID: 45582 RVA: 0x000FBB1D File Offset: 0x000F9D1D
		static vtkCubeAxesActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCubeAxesActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCubeAxesActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600B20F RID: 45583 RVA: 0x000FBB45 File Offset: 0x000F9D45
		public vtkCubeAxesActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600B210 RID: 45584
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object with label format "6.3g" and the number of labels
		/// per axis set to 3.
		/// </summary>
		// Token: 0x0600B211 RID: 45585 RVA: 0x000FBB54 File Offset: 0x000F9D54
		public new static vtkCubeAxesActor New()
		{
			vtkCubeAxesActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCubeAxesActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate object with label format "6.3g" and the number of labels
		/// per axis set to 3.
		/// </summary>
		// Token: 0x0600B212 RID: 45586 RVA: 0x000FBBA8 File Offset: 0x000F9DA8
		public vtkCubeAxesActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCubeAxesActor.vtkCubeAxesActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600B213 RID: 45587 RVA: 0x000FBBEC File Offset: 0x000F9DEC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600B214 RID: 45588
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_CenterStickyAxesOff_01(HandleRef pThis);

		/// <summary>
		/// Enable/Disable centering of axes when the Sticky option is
		/// on. If on, the axes bounds will be centered in the
		/// viewport. Otherwise, the axes can move about the longer of the
		/// horizontal or vertical directions of the viewport to follow the
		/// data.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B215 RID: 45589 RVA: 0x000FBBF7 File Offset: 0x000F9DF7
		public virtual void CenterStickyAxesOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_CenterStickyAxesOff_01(base.GetCppThis());
		}

		// Token: 0x0600B216 RID: 45590
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_CenterStickyAxesOn_02(HandleRef pThis);

		/// <summary>
		/// Enable/Disable centering of axes when the Sticky option is
		/// on. If on, the axes bounds will be centered in the
		/// viewport. Otherwise, the axes can move about the longer of the
		/// horizontal or vertical directions of the viewport to follow the
		/// data.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B217 RID: 45591 RVA: 0x000FBC06 File Offset: 0x000F9E06
		public virtual void CenterStickyAxesOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_CenterStickyAxesOn_02(base.GetCppThis());
		}

		// Token: 0x0600B218 RID: 45592
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_DrawXGridlinesOff_03(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B219 RID: 45593 RVA: 0x000FBC15 File Offset: 0x000F9E15
		public virtual void DrawXGridlinesOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawXGridlinesOff_03(base.GetCppThis());
		}

		// Token: 0x0600B21A RID: 45594
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_DrawXGridlinesOn_04(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B21B RID: 45595 RVA: 0x000FBC24 File Offset: 0x000F9E24
		public virtual void DrawXGridlinesOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawXGridlinesOn_04(base.GetCppThis());
		}

		// Token: 0x0600B21C RID: 45596
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_DrawXGridpolysOff_05(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of grid polys for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B21D RID: 45597 RVA: 0x000FBC33 File Offset: 0x000F9E33
		public virtual void DrawXGridpolysOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawXGridpolysOff_05(base.GetCppThis());
		}

		// Token: 0x0600B21E RID: 45598
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_DrawXGridpolysOn_06(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of grid polys for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B21F RID: 45599 RVA: 0x000FBC42 File Offset: 0x000F9E42
		public virtual void DrawXGridpolysOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawXGridpolysOn_06(base.GetCppThis());
		}

		// Token: 0x0600B220 RID: 45600
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_DrawXInnerGridlinesOff_07(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of inner grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B221 RID: 45601 RVA: 0x000FBC51 File Offset: 0x000F9E51
		public virtual void DrawXInnerGridlinesOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawXInnerGridlinesOff_07(base.GetCppThis());
		}

		// Token: 0x0600B222 RID: 45602
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_DrawXInnerGridlinesOn_08(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of inner grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B223 RID: 45603 RVA: 0x000FBC60 File Offset: 0x000F9E60
		public virtual void DrawXInnerGridlinesOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawXInnerGridlinesOn_08(base.GetCppThis());
		}

		// Token: 0x0600B224 RID: 45604
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_DrawYGridlinesOff_09(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B225 RID: 45605 RVA: 0x000FBC6F File Offset: 0x000F9E6F
		public virtual void DrawYGridlinesOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawYGridlinesOff_09(base.GetCppThis());
		}

		// Token: 0x0600B226 RID: 45606
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_DrawYGridlinesOn_10(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B227 RID: 45607 RVA: 0x000FBC7E File Offset: 0x000F9E7E
		public virtual void DrawYGridlinesOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawYGridlinesOn_10(base.GetCppThis());
		}

		// Token: 0x0600B228 RID: 45608
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_DrawYGridpolysOff_11(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of grid polys for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B229 RID: 45609 RVA: 0x000FBC8D File Offset: 0x000F9E8D
		public virtual void DrawYGridpolysOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawYGridpolysOff_11(base.GetCppThis());
		}

		// Token: 0x0600B22A RID: 45610
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_DrawYGridpolysOn_12(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of grid polys for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B22B RID: 45611 RVA: 0x000FBC9C File Offset: 0x000F9E9C
		public virtual void DrawYGridpolysOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawYGridpolysOn_12(base.GetCppThis());
		}

		// Token: 0x0600B22C RID: 45612
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_DrawYInnerGridlinesOff_13(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of inner grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B22D RID: 45613 RVA: 0x000FBCAB File Offset: 0x000F9EAB
		public virtual void DrawYInnerGridlinesOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawYInnerGridlinesOff_13(base.GetCppThis());
		}

		// Token: 0x0600B22E RID: 45614
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_DrawYInnerGridlinesOn_14(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of inner grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B22F RID: 45615 RVA: 0x000FBCBA File Offset: 0x000F9EBA
		public virtual void DrawYInnerGridlinesOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawYInnerGridlinesOn_14(base.GetCppThis());
		}

		// Token: 0x0600B230 RID: 45616
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_DrawZGridlinesOff_15(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B231 RID: 45617 RVA: 0x000FBCC9 File Offset: 0x000F9EC9
		public virtual void DrawZGridlinesOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawZGridlinesOff_15(base.GetCppThis());
		}

		// Token: 0x0600B232 RID: 45618
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_DrawZGridlinesOn_16(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B233 RID: 45619 RVA: 0x000FBCD8 File Offset: 0x000F9ED8
		public virtual void DrawZGridlinesOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawZGridlinesOn_16(base.GetCppThis());
		}

		// Token: 0x0600B234 RID: 45620
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_DrawZGridpolysOff_17(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of grid polys for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B235 RID: 45621 RVA: 0x000FBCE7 File Offset: 0x000F9EE7
		public virtual void DrawZGridpolysOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawZGridpolysOff_17(base.GetCppThis());
		}

		// Token: 0x0600B236 RID: 45622
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_DrawZGridpolysOn_18(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of grid polys for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B237 RID: 45623 RVA: 0x000FBCF6 File Offset: 0x000F9EF6
		public virtual void DrawZGridpolysOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawZGridpolysOn_18(base.GetCppThis());
		}

		// Token: 0x0600B238 RID: 45624
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_DrawZInnerGridlinesOff_19(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of inner grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B239 RID: 45625 RVA: 0x000FBD05 File Offset: 0x000F9F05
		public virtual void DrawZInnerGridlinesOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawZInnerGridlinesOff_19(base.GetCppThis());
		}

		// Token: 0x0600B23A RID: 45626
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_DrawZInnerGridlinesOn_20(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of inner grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B23B RID: 45627 RVA: 0x000FBD14 File Offset: 0x000F9F14
		public virtual void DrawZInnerGridlinesOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawZInnerGridlinesOn_20(base.GetCppThis());
		}

		// Token: 0x0600B23C RID: 45628
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetAxisBaseForX_21(HandleRef pThis);

		/// <summary>
		/// Vector that should be use as the base for X.
		/// Default: (1.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x0600B23D RID: 45629 RVA: 0x000FBD24 File Offset: 0x000F9F24
		public virtual double[] GetAxisBaseForX()
		{
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetAxisBaseForX_21(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600B23E RID: 45630
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_GetAxisBaseForX_22(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Vector that should be use as the base for X.
		/// Default: (1.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x0600B23F RID: 45631 RVA: 0x000FBD6C File Offset: 0x000F9F6C
		public virtual void GetAxisBaseForX(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetAxisBaseForX_22(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600B240 RID: 45632
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_GetAxisBaseForX_23(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Vector that should be use as the base for X.
		/// Default: (1.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x0600B241 RID: 45633 RVA: 0x000FBD7E File Offset: 0x000F9F7E
		public virtual void GetAxisBaseForX(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetAxisBaseForX_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B242 RID: 45634
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetAxisBaseForY_24(HandleRef pThis);

		/// <summary>
		/// Vector that should be use as the base for Y.
		/// Default: (0.0, 1.0, 0.0).
		/// </summary>
		// Token: 0x0600B243 RID: 45635 RVA: 0x000FBD90 File Offset: 0x000F9F90
		public virtual double[] GetAxisBaseForY()
		{
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetAxisBaseForY_24(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600B244 RID: 45636
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_GetAxisBaseForY_25(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Vector that should be use as the base for Y.
		/// Default: (0.0, 1.0, 0.0).
		/// </summary>
		// Token: 0x0600B245 RID: 45637 RVA: 0x000FBDD8 File Offset: 0x000F9FD8
		public virtual void GetAxisBaseForY(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetAxisBaseForY_25(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600B246 RID: 45638
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_GetAxisBaseForY_26(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Vector that should be use as the base for Y.
		/// Default: (0.0, 1.0, 0.0).
		/// </summary>
		// Token: 0x0600B247 RID: 45639 RVA: 0x000FBDEA File Offset: 0x000F9FEA
		public virtual void GetAxisBaseForY(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetAxisBaseForY_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B248 RID: 45640
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetAxisBaseForZ_27(HandleRef pThis);

		/// <summary>
		/// Vector that should be use as the base for Z.
		/// Default: (0.0, 0.0, 1.0).
		/// </summary>
		// Token: 0x0600B249 RID: 45641 RVA: 0x000FBDFC File Offset: 0x000F9FFC
		public virtual double[] GetAxisBaseForZ()
		{
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetAxisBaseForZ_27(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600B24A RID: 45642
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_GetAxisBaseForZ_28(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Vector that should be use as the base for Z.
		/// Default: (0.0, 0.0, 1.0).
		/// </summary>
		// Token: 0x0600B24B RID: 45643 RVA: 0x000FBE44 File Offset: 0x000FA044
		public virtual void GetAxisBaseForZ(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetAxisBaseForZ_28(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600B24C RID: 45644
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_GetAxisBaseForZ_29(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Vector that should be use as the base for Z.
		/// Default: (0.0, 0.0, 1.0).
		/// </summary>
		// Token: 0x0600B24D RID: 45645 RVA: 0x000FBE56 File Offset: 0x000FA056
		public virtual void GetAxisBaseForZ(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetAxisBaseForZ_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B24E RID: 45646
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetAxisLabels_30(HandleRef pThis, int axis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Explicitly specify the axis labels along an axis as an array of strings
		/// instead of using the values.
		/// </summary>
		// Token: 0x0600B24F RID: 45647 RVA: 0x000FBE68 File Offset: 0x000FA068
		public vtkStringArray GetAxisLabels(int axis)
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetAxisLabels_30(base.GetCppThis(), axis, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x0600B250 RID: 45648
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetAxisOrigin_31(HandleRef pThis);

		/// <summary>
		/// Provide a custom AxisOrigin. This point must be inside the bounding box and
		/// will represent the point where the 3 axes will intersect.
		/// Default: (0.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x0600B251 RID: 45649 RVA: 0x000FBED8 File Offset: 0x000FA0D8
		public virtual double[] GetAxisOrigin()
		{
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetAxisOrigin_31(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600B252 RID: 45650
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_GetAxisOrigin_32(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Provide a custom AxisOrigin. This point must be inside the bounding box and
		/// will represent the point where the 3 axes will intersect.
		/// Default: (0.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x0600B253 RID: 45651 RVA: 0x000FBF20 File Offset: 0x000FA120
		public virtual void GetAxisOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetAxisOrigin_32(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600B254 RID: 45652
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_GetAxisOrigin_33(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Provide a custom AxisOrigin. This point must be inside the bounding box and
		/// will represent the point where the 3 axes will intersect.
		/// Default: (0.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x0600B255 RID: 45653 RVA: 0x000FBF32 File Offset: 0x000FA132
		public virtual void GetAxisOrigin(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetAxisOrigin_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B256 RID: 45654
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetBounds_34(HandleRef pThis);

		/// <summary>
		/// Explicitly specify the region in space around which to draw the bounds.
		/// The bounds is used only when no Input or Prop is specified. The bounds
		/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
		/// sure that the min's are less than the max's.
		/// </summary>
		// Token: 0x0600B257 RID: 45655 RVA: 0x000FBF44 File Offset: 0x000FA144
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetBounds_34(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600B258 RID: 45656
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetCamera_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the camera to perform scaling and translation of the
		/// vtkCubeAxesActor.
		/// </summary>
		// Token: 0x0600B259 RID: 45657 RVA: 0x000FBF8C File Offset: 0x000FA18C
		public vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetCamera_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		// Token: 0x0600B25A RID: 45658
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetCenterStickyAxes_36(HandleRef pThis);

		/// <summary>
		/// Enable/Disable centering of axes when the Sticky option is
		/// on. If on, the axes bounds will be centered in the
		/// viewport. Otherwise, the axes can move about the longer of the
		/// horizontal or vertical directions of the viewport to follow the
		/// data.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B25B RID: 45659 RVA: 0x000FBFFC File Offset: 0x000FA1FC
		public virtual bool GetCenterStickyAxes()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetCenterStickyAxes_36(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B25C RID: 45660
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubeAxesActor_GetCornerOffset_37(HandleRef pThis);

		/// <summary>
		/// Specify an offset value to "pull back" the axes from the corner at
		/// which they are joined to avoid overlap of axes labels. The
		/// "CornerOffset" is the fraction of the axis length to pull back.
		/// Default: 0.0.
		/// </summary>
		// Token: 0x0600B25D RID: 45661 RVA: 0x000FC024 File Offset: 0x000FA224
		public virtual double GetCornerOffset()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetCornerOffset_37(base.GetCppThis());
		}

		// Token: 0x0600B25E RID: 45662
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubeAxesActor_GetDistanceLODThreshold_38(HandleRef pThis);

		/// <summary>
		/// Set distance LOD threshold [0.0 - 1.0] for titles and labels.
		/// Default: 0.8.
		/// </summary>
		// Token: 0x0600B25F RID: 45663 RVA: 0x000FC044 File Offset: 0x000FA244
		public virtual double GetDistanceLODThreshold()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetDistanceLODThreshold_38(base.GetCppThis());
		}

		// Token: 0x0600B260 RID: 45664
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubeAxesActor_GetDistanceLODThresholdMaxValue_39(HandleRef pThis);

		/// <summary>
		/// Set distance LOD threshold [0.0 - 1.0] for titles and labels.
		/// Default: 0.8.
		/// </summary>
		// Token: 0x0600B261 RID: 45665 RVA: 0x000FC064 File Offset: 0x000FA264
		public virtual double GetDistanceLODThresholdMaxValue()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetDistanceLODThresholdMaxValue_39(base.GetCppThis());
		}

		// Token: 0x0600B262 RID: 45666
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubeAxesActor_GetDistanceLODThresholdMinValue_40(HandleRef pThis);

		/// <summary>
		/// Set distance LOD threshold [0.0 - 1.0] for titles and labels.
		/// Default: 0.8.
		/// </summary>
		// Token: 0x0600B263 RID: 45667 RVA: 0x000FC084 File Offset: 0x000FA284
		public virtual double GetDistanceLODThresholdMinValue()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetDistanceLODThresholdMinValue_40(base.GetCppThis());
		}

		// Token: 0x0600B264 RID: 45668
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetDrawXGridlines_41(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B265 RID: 45669 RVA: 0x000FC0A4 File Offset: 0x000FA2A4
		public virtual bool GetDrawXGridlines()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetDrawXGridlines_41(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B266 RID: 45670
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetDrawXGridpolys_42(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of grid polys for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B267 RID: 45671 RVA: 0x000FC0CC File Offset: 0x000FA2CC
		public virtual bool GetDrawXGridpolys()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetDrawXGridpolys_42(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B268 RID: 45672
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetDrawXInnerGridlines_43(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of inner grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B269 RID: 45673 RVA: 0x000FC0F4 File Offset: 0x000FA2F4
		public virtual bool GetDrawXInnerGridlines()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetDrawXInnerGridlines_43(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B26A RID: 45674
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetDrawYGridlines_44(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B26B RID: 45675 RVA: 0x000FC11C File Offset: 0x000FA31C
		public virtual bool GetDrawYGridlines()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetDrawYGridlines_44(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B26C RID: 45676
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetDrawYGridpolys_45(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of grid polys for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B26D RID: 45677 RVA: 0x000FC144 File Offset: 0x000FA344
		public virtual bool GetDrawYGridpolys()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetDrawYGridpolys_45(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B26E RID: 45678
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetDrawYInnerGridlines_46(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of inner grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B26F RID: 45679 RVA: 0x000FC16C File Offset: 0x000FA36C
		public virtual bool GetDrawYInnerGridlines()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetDrawYInnerGridlines_46(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B270 RID: 45680
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetDrawZGridlines_47(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B271 RID: 45681 RVA: 0x000FC194 File Offset: 0x000FA394
		public virtual bool GetDrawZGridlines()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetDrawZGridlines_47(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B272 RID: 45682
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetDrawZGridpolys_48(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of grid polys for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B273 RID: 45683 RVA: 0x000FC1BC File Offset: 0x000FA3BC
		public virtual bool GetDrawZGridpolys()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetDrawZGridpolys_48(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B274 RID: 45684
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetDrawZInnerGridlines_49(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of inner grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B275 RID: 45685 RVA: 0x000FC1E4 File Offset: 0x000FA3E4
		public virtual bool GetDrawZInnerGridlines()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetDrawZInnerGridlines_49(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B276 RID: 45686
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetEnableDistanceLOD_50(HandleRef pThis);

		/// <summary>
		/// Enable and disable the use of distance based LOD for titles and labels.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B277 RID: 45687 RVA: 0x000FC20C File Offset: 0x000FA40C
		public virtual bool GetEnableDistanceLOD()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetEnableDistanceLOD_50(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B278 RID: 45688
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetEnableViewAngleLOD_51(HandleRef pThis);

		/// <summary>
		/// Enable and disable the use of view angle based LOD for titles and labels.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B279 RID: 45689 RVA: 0x000FC234 File Offset: 0x000FA434
		public virtual bool GetEnableViewAngleLOD()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetEnableViewAngleLOD_51(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B27A RID: 45690
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor_GetFlyMode_52(HandleRef pThis);

		/// <summary>
		/// Specify a mode to control how the axes are drawn: either static,
		/// closest triad, furthest triad or outer edges in relation to the
		/// camera position.
		/// Default: VTK_FLY_CLOSEST_TRIAD.
		/// </summary>
		// Token: 0x0600B27B RID: 45691 RVA: 0x000FC25C File Offset: 0x000FA45C
		public virtual int GetFlyMode()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetFlyMode_52(base.GetCppThis());
		}

		// Token: 0x0600B27C RID: 45692
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor_GetFlyModeMaxValue_53(HandleRef pThis);

		/// <summary>
		/// Specify a mode to control how the axes are drawn: either static,
		/// closest triad, furthest triad or outer edges in relation to the
		/// camera position.
		/// Default: VTK_FLY_CLOSEST_TRIAD.
		/// </summary>
		// Token: 0x0600B27D RID: 45693 RVA: 0x000FC27C File Offset: 0x000FA47C
		public virtual int GetFlyModeMaxValue()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetFlyModeMaxValue_53(base.GetCppThis());
		}

		// Token: 0x0600B27E RID: 45694
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor_GetFlyModeMinValue_54(HandleRef pThis);

		/// <summary>
		/// Specify a mode to control how the axes are drawn: either static,
		/// closest triad, furthest triad or outer edges in relation to the
		/// camera position.
		/// Default: VTK_FLY_CLOSEST_TRIAD.
		/// </summary>
		// Token: 0x0600B27F RID: 45695 RVA: 0x000FC29C File Offset: 0x000FA49C
		public virtual int GetFlyModeMinValue()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetFlyModeMinValue_54(base.GetCppThis());
		}

		// Token: 0x0600B280 RID: 45696
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor_GetGridLineLocation_55(HandleRef pThis);

		/// <summary>
		/// Specify the mode in which the cube axes should render its gridLines.
		/// Default: VTK_GRID_LINES_ALL.
		/// </summary>
		// Token: 0x0600B281 RID: 45697 RVA: 0x000FC2BC File Offset: 0x000FA4BC
		public virtual int GetGridLineLocation()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetGridLineLocation_55(base.GetCppThis());
		}

		// Token: 0x0600B282 RID: 45698
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor_GetInertia_56(HandleRef pThis);

		/// <summary>
		/// Set/Get the inertial factor that controls how often (i.e, how
		/// many renders) the axes can switch position (jump from one axes
		/// to another).
		/// Default: 1.
		/// </summary>
		// Token: 0x0600B283 RID: 45699 RVA: 0x000FC2DC File Offset: 0x000FA4DC
		public virtual int GetInertia()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetInertia_56(base.GetCppThis());
		}

		// Token: 0x0600B284 RID: 45700
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor_GetInertiaMaxValue_57(HandleRef pThis);

		/// <summary>
		/// Set/Get the inertial factor that controls how often (i.e, how
		/// many renders) the axes can switch position (jump from one axes
		/// to another).
		/// Default: 1.
		/// </summary>
		// Token: 0x0600B285 RID: 45701 RVA: 0x000FC2FC File Offset: 0x000FA4FC
		public virtual int GetInertiaMaxValue()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetInertiaMaxValue_57(base.GetCppThis());
		}

		// Token: 0x0600B286 RID: 45702
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor_GetInertiaMinValue_58(HandleRef pThis);

		/// <summary>
		/// Set/Get the inertial factor that controls how often (i.e, how
		/// many renders) the axes can switch position (jump from one axes
		/// to another).
		/// Default: 1.
		/// </summary>
		// Token: 0x0600B287 RID: 45703 RVA: 0x000FC31C File Offset: 0x000FA51C
		public virtual int GetInertiaMinValue()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetInertiaMinValue_58(base.GetCppThis());
		}

		// Token: 0x0600B288 RID: 45704
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubeAxesActor_GetLabelOffset_59(HandleRef pThis);

		/// <summary>
		/// Explicitly specify the offset between labels and the axis.
		/// Default: 20.0.
		/// </summary>
		// Token: 0x0600B289 RID: 45705 RVA: 0x000FC33C File Offset: 0x000FA53C
		public virtual double GetLabelOffset()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetLabelOffset_59(base.GetCppThis());
		}

		// Token: 0x0600B28A RID: 45706
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetLabelTextProperty_60(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the text property for the labels on an axis.
		/// </summary>
		// Token: 0x0600B28B RID: 45707 RVA: 0x000FC35C File Offset: 0x000FA55C
		public vtkTextProperty GetLabelTextProperty(int arg0)
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetLabelTextProperty_60(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x0600B28C RID: 45708
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCubeAxesActor_GetNumberOfGenerationsFromBase_61(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B28D RID: 45709 RVA: 0x000FC3CC File Offset: 0x000FA5CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetNumberOfGenerationsFromBase_61(base.GetCppThis(), type);
		}

		// Token: 0x0600B28E RID: 45710
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCubeAxesActor_GetNumberOfGenerationsFromBaseType_62([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B28F RID: 45711 RVA: 0x000FC3EC File Offset: 0x000FA5EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetNumberOfGenerationsFromBaseType_62(type);
		}

		// Token: 0x0600B290 RID: 45712
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetOrientedBounds_63(HandleRef pThis);

		/// <summary>
		/// Provide an oriented bounded box when using AxisBaseFor.
		/// Default: (-1, 1, -1, 1, -1, 1).
		/// </summary>
		// Token: 0x0600B291 RID: 45713 RVA: 0x000FC408 File Offset: 0x000FA608
		public virtual double[] GetOrientedBounds()
		{
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetOrientedBounds_63(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600B292 RID: 45714
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_GetOrientedBounds_64(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

		/// <summary>
		/// Provide an oriented bounded box when using AxisBaseFor.
		/// Default: (-1, 1, -1, 1, -1, 1).
		/// </summary>
		// Token: 0x0600B293 RID: 45715 RVA: 0x000FC450 File Offset: 0x000FA650
		public virtual void GetOrientedBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetOrientedBounds_64(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x0600B294 RID: 45716
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_GetOrientedBounds_65(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Provide an oriented bounded box when using AxisBaseFor.
		/// Default: (-1, 1, -1, 1, -1, 1).
		/// </summary>
		// Token: 0x0600B295 RID: 45717 RVA: 0x000FC468 File Offset: 0x000FA668
		public virtual void GetOrientedBounds(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetOrientedBounds_65(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B296 RID: 45718
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetRebuildAxes_66(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the RebuildAxes flag.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B297 RID: 45719 RVA: 0x000FC478 File Offset: 0x000FA678
		public virtual bool GetRebuildAxes()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetRebuildAxes_66(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B298 RID: 45720
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_GetRenderedBounds_67(HandleRef pThis, IntPtr rBounds);

		/// <summary>
		/// Method used to properly return the bounds of the cube axis itself with all
		/// its labels.
		/// </summary>
		// Token: 0x0600B299 RID: 45721 RVA: 0x000FC49E File Offset: 0x000FA69E
		public virtual void GetRenderedBounds(IntPtr rBounds)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetRenderedBounds_67(base.GetCppThis(), rBounds);
		}

		// Token: 0x0600B29A RID: 45722
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetRenderedBounds_68(HandleRef pThis);

		/// <summary>
		/// Method used to properly return the bounds of the cube axis itself with all
		/// its labels.
		/// </summary>
		// Token: 0x0600B29B RID: 45723 RVA: 0x000FC4B0 File Offset: 0x000FA6B0
		public virtual IntPtr GetRenderedBounds()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetRenderedBounds_68(base.GetCppThis());
		}

		// Token: 0x0600B29C RID: 45724
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubeAxesActor_GetScreenSize_69(HandleRef pThis);

		/// <summary>
		/// Explicitly specify the screen size of title and label text.
		/// ScreenSize determines the size of the text in terms of screen
		/// pixels.
		/// Default: 10.0.
		/// </summary>
		// Token: 0x0600B29D RID: 45725 RVA: 0x000FC4D0 File Offset: 0x000FA6D0
		public virtual double GetScreenSize()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetScreenSize_69(base.GetCppThis());
		}

		// Token: 0x0600B29E RID: 45726
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetStickyAxes_70(HandleRef pThis);

		/// <summary>
		/// Enable/Disable axis stickiness. When on, the axes will be adjusted to always
		/// be visible in the viewport unless the original bounds of the axes are entirely
		/// outside the viewport.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B29F RID: 45727 RVA: 0x000FC4F0 File Offset: 0x000FA6F0
		public virtual bool GetStickyAxes()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetStickyAxes_70(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B2A0 RID: 45728
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor_GetTickLocation_71(HandleRef pThis);

		/// <summary>
		/// Set/Get the location of ticks marks.
		/// Default: VTK_TICKS_INSIDE.
		/// </summary>
		// Token: 0x0600B2A1 RID: 45729 RVA: 0x000FC518 File Offset: 0x000FA718
		public virtual int GetTickLocation()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetTickLocation_71(base.GetCppThis());
		}

		// Token: 0x0600B2A2 RID: 45730
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor_GetTickLocationMaxValue_72(HandleRef pThis);

		/// <summary>
		/// Set/Get the location of ticks marks.
		/// Default: VTK_TICKS_INSIDE.
		/// </summary>
		// Token: 0x0600B2A3 RID: 45731 RVA: 0x000FC538 File Offset: 0x000FA738
		public virtual int GetTickLocationMaxValue()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetTickLocationMaxValue_72(base.GetCppThis());
		}

		// Token: 0x0600B2A4 RID: 45732
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor_GetTickLocationMinValue_73(HandleRef pThis);

		/// <summary>
		/// Set/Get the location of ticks marks.
		/// Default: VTK_TICKS_INSIDE.
		/// </summary>
		// Token: 0x0600B2A5 RID: 45733 RVA: 0x000FC558 File Offset: 0x000FA758
		public virtual int GetTickLocationMinValue()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetTickLocationMinValue_73(base.GetCppThis());
		}

		// Token: 0x0600B2A6 RID: 45734
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_GetTitleOffset_74(HandleRef pThis, ref double titleOffsetX, ref double titleOffsetY);

		/// <summary>
		/// Explicitly specify the offset between title and labels.
		/// Default: (20.0, 20.0).
		/// </summary>
		// Token: 0x0600B2A7 RID: 45735 RVA: 0x000FC577 File Offset: 0x000FA777
		public void GetTitleOffset(ref double titleOffsetX, ref double titleOffsetY)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetTitleOffset_74(base.GetCppThis(), ref titleOffsetX, ref titleOffsetY);
		}

		// Token: 0x0600B2A8 RID: 45736
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetTitleTextProperty_75(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the text property for the title on an axis.
		/// </summary>
		// Token: 0x0600B2A9 RID: 45737 RVA: 0x000FC588 File Offset: 0x000FA788
		public vtkTextProperty GetTitleTextProperty(int arg0)
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetTitleTextProperty_75(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x0600B2AA RID: 45738
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetUse2DMode_76(HandleRef pThis);

		/// <summary>
		/// Get/Set 2D mode
		/// NB: Use vtkTextActor for titles in 2D instead of vtkAxisFollower
		/// </summary>
		// Token: 0x0600B2AB RID: 45739 RVA: 0x000FC5F8 File Offset: 0x000FA7F8
		public bool GetUse2DMode()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetUse2DMode_76(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B2AC RID: 45740
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetUseAxisOrigin_77(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the usage of the AxisOrigin.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B2AD RID: 45741 RVA: 0x000FC620 File Offset: 0x000FA820
		public virtual bool GetUseAxisOrigin()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetUseAxisOrigin_77(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B2AE RID: 45742
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetUseOrientedBounds_78(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the usage of the OrientedBounds.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B2AF RID: 45743 RVA: 0x000FC648 File Offset: 0x000FA848
		public virtual bool GetUseOrientedBounds()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetUseOrientedBounds_78(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B2B0 RID: 45744
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetUseTextActor3D_79(HandleRef pThis);

		/// <summary>
		/// Use or not vtkTextActor3D for titles and labels.
		/// See Also:
		/// vtkAxisActor::SetUseTextActor3D(), vtkAxisActor::GetUseTextActor3D()
		/// </summary>
		// Token: 0x0600B2B1 RID: 45745 RVA: 0x000FC670 File Offset: 0x000FA870
		public bool GetUseTextActor3D()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetUseTextActor3D_79(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B2B2 RID: 45746
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubeAxesActor_GetViewAngleLODThreshold_80(HandleRef pThis);

		/// <summary>
		/// Set view angle LOD threshold [0.0 - 1.0] for titles and labels.
		/// Default: 0.2.
		/// </summary>
		// Token: 0x0600B2B3 RID: 45747 RVA: 0x000FC698 File Offset: 0x000FA898
		public virtual double GetViewAngleLODThreshold()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetViewAngleLODThreshold_80(base.GetCppThis());
		}

		// Token: 0x0600B2B4 RID: 45748
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubeAxesActor_GetViewAngleLODThresholdMaxValue_81(HandleRef pThis);

		/// <summary>
		/// Set view angle LOD threshold [0.0 - 1.0] for titles and labels.
		/// Default: 0.2.
		/// </summary>
		// Token: 0x0600B2B5 RID: 45749 RVA: 0x000FC6B8 File Offset: 0x000FA8B8
		public virtual double GetViewAngleLODThresholdMaxValue()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetViewAngleLODThresholdMaxValue_81(base.GetCppThis());
		}

		// Token: 0x0600B2B6 RID: 45750
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubeAxesActor_GetViewAngleLODThresholdMinValue_82(HandleRef pThis);

		/// <summary>
		/// Set view angle LOD threshold [0.0 - 1.0] for titles and labels.
		/// Default: 0.2.
		/// </summary>
		// Token: 0x0600B2B7 RID: 45751 RVA: 0x000FC6D8 File Offset: 0x000FA8D8
		public virtual double GetViewAngleLODThresholdMinValue()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetViewAngleLODThresholdMinValue_82(base.GetCppThis());
		}

		// Token: 0x0600B2B8 RID: 45752
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetXAxesGridlinesProperty_83(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set axes (outer) gridlines actors properties.
		/// </summary>
		// Token: 0x0600B2B9 RID: 45753 RVA: 0x000FC6F8 File Offset: 0x000FA8F8
		public vtkProperty GetXAxesGridlinesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetXAxesGridlinesProperty_83(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600B2BA RID: 45754
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetXAxesGridpolysProperty_84(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set axes gridPolys actors properties.
		/// </summary>
		// Token: 0x0600B2BB RID: 45755 RVA: 0x000FC768 File Offset: 0x000FA968
		public vtkProperty GetXAxesGridpolysProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetXAxesGridpolysProperty_84(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600B2BC RID: 45756
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetXAxesInnerGridlinesProperty_85(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set axes inner gridlines actors properties.
		/// </summary>
		// Token: 0x0600B2BD RID: 45757 RVA: 0x000FC7D8 File Offset: 0x000FA9D8
		public vtkProperty GetXAxesInnerGridlinesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetXAxesInnerGridlinesProperty_85(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600B2BE RID: 45758
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetXAxesLinesProperty_86(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set axes actors properties.
		/// </summary>
		// Token: 0x0600B2BF RID: 45759 RVA: 0x000FC848 File Offset: 0x000FAA48
		public vtkProperty GetXAxesLinesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetXAxesLinesProperty_86(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600B2C0 RID: 45760
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetXAxisLabelVisibility_87(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of labels for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B2C1 RID: 45761 RVA: 0x000FC8B8 File Offset: 0x000FAAB8
		public virtual bool GetXAxisLabelVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetXAxisLabelVisibility_87(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B2C2 RID: 45762
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetXAxisMinorTickVisibility_88(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of minor ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B2C3 RID: 45763 RVA: 0x000FC8E0 File Offset: 0x000FAAE0
		public virtual bool GetXAxisMinorTickVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetXAxisMinorTickVisibility_88(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B2C4 RID: 45764
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetXAxisRange_89(HandleRef pThis);

		/// <summary>
		/// Explicitly specify the range of each axes that's used to define the prop.
		/// The default, (if you do not use these methods) is to use the bounds
		/// specified, or use the bounds of the Input Prop if one is specified. This
		/// method allows you to separate the notion of extent of the axes in physical
		/// space (bounds) and the extent of the values it represents. In other words,
		/// you can have the ticks and labels show a different range.
		/// </summary>
		// Token: 0x0600B2C5 RID: 45765 RVA: 0x000FC908 File Offset: 0x000FAB08
		public virtual double[] GetXAxisRange()
		{
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetXAxisRange_89(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600B2C6 RID: 45766
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_GetXAxisRange_90(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Explicitly specify the range of each axes that's used to define the prop.
		/// The default, (if you do not use these methods) is to use the bounds
		/// specified, or use the bounds of the Input Prop if one is specified. This
		/// method allows you to separate the notion of extent of the axes in physical
		/// space (bounds) and the extent of the values it represents. In other words,
		/// you can have the ticks and labels show a different range.
		/// </summary>
		// Token: 0x0600B2C7 RID: 45767 RVA: 0x000FC950 File Offset: 0x000FAB50
		public virtual void GetXAxisRange(ref double _arg1, ref double _arg2)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetXAxisRange_90(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600B2C8 RID: 45768
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_GetXAxisRange_91(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Explicitly specify the range of each axes that's used to define the prop.
		/// The default, (if you do not use these methods) is to use the bounds
		/// specified, or use the bounds of the Input Prop if one is specified. This
		/// method allows you to separate the notion of extent of the axes in physical
		/// space (bounds) and the extent of the values it represents. In other words,
		/// you can have the ticks and labels show a different range.
		/// </summary>
		// Token: 0x0600B2C9 RID: 45769 RVA: 0x000FC961 File Offset: 0x000FAB61
		public virtual void GetXAxisRange(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetXAxisRange_91(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B2CA RID: 45770
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetXAxisTickVisibility_92(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B2CB RID: 45771 RVA: 0x000FC974 File Offset: 0x000FAB74
		public virtual bool GetXAxisTickVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetXAxisTickVisibility_92(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B2CC RID: 45772
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetXAxisVisibility_93(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B2CD RID: 45773 RVA: 0x000FC99C File Offset: 0x000FAB9C
		public virtual bool GetXAxisVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetXAxisVisibility_93(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B2CE RID: 45774
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetXLabelFormat_94(HandleRef pThis);

		/// <summary>
		/// Set/Get the format with which to print the labels on each of the
		/// x-y-z axes.
		/// </summary>
		// Token: 0x0600B2CF RID: 45775 RVA: 0x000FC9C4 File Offset: 0x000FABC4
		public virtual string GetXLabelFormat()
		{
			string s = Marshal.PtrToStringAnsi(vtkCubeAxesActor.vtkCubeAxesActor_GetXLabelFormat_94(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B2D0 RID: 45776
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetXTitle_95(HandleRef pThis);

		/// <summary>
		/// Set/Get the labels for the x, y, and z axes. By default,
		/// use "X-Axis", "Y-Axis" and "Z-Axis".
		/// </summary>
		// Token: 0x0600B2D1 RID: 45777 RVA: 0x000FCA00 File Offset: 0x000FAC00
		public virtual string GetXTitle()
		{
			string s = Marshal.PtrToStringAnsi(vtkCubeAxesActor.vtkCubeAxesActor_GetXTitle_95(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B2D2 RID: 45778
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetXUnits_96(HandleRef pThis);

		/// <summary>
		/// Set/Get the labels for the x, y, and z axes. By default,
		/// use "X-Axis", "Y-Axis" and "Z-Axis".
		/// </summary>
		// Token: 0x0600B2D3 RID: 45779 RVA: 0x000FCA3C File Offset: 0x000FAC3C
		public virtual string GetXUnits()
		{
			string s = Marshal.PtrToStringAnsi(vtkCubeAxesActor.vtkCubeAxesActor_GetXUnits_96(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B2D4 RID: 45780
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetYAxesGridlinesProperty_97(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set axes (outer) gridlines actors properties.
		/// </summary>
		// Token: 0x0600B2D5 RID: 45781 RVA: 0x000FCA78 File Offset: 0x000FAC78
		public vtkProperty GetYAxesGridlinesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetYAxesGridlinesProperty_97(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600B2D6 RID: 45782
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetYAxesGridpolysProperty_98(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set axes gridPolys actors properties.
		/// </summary>
		// Token: 0x0600B2D7 RID: 45783 RVA: 0x000FCAE8 File Offset: 0x000FACE8
		public vtkProperty GetYAxesGridpolysProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetYAxesGridpolysProperty_98(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600B2D8 RID: 45784
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetYAxesInnerGridlinesProperty_99(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set axes inner gridlines actors properties.
		/// </summary>
		// Token: 0x0600B2D9 RID: 45785 RVA: 0x000FCB58 File Offset: 0x000FAD58
		public vtkProperty GetYAxesInnerGridlinesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetYAxesInnerGridlinesProperty_99(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600B2DA RID: 45786
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetYAxesLinesProperty_100(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set axes actors properties.
		/// </summary>
		// Token: 0x0600B2DB RID: 45787 RVA: 0x000FCBC8 File Offset: 0x000FADC8
		public vtkProperty GetYAxesLinesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetYAxesLinesProperty_100(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600B2DC RID: 45788
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetYAxisLabelVisibility_101(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of labels for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B2DD RID: 45789 RVA: 0x000FCC38 File Offset: 0x000FAE38
		public virtual bool GetYAxisLabelVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetYAxisLabelVisibility_101(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B2DE RID: 45790
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetYAxisMinorTickVisibility_102(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of minor ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B2DF RID: 45791 RVA: 0x000FCC60 File Offset: 0x000FAE60
		public virtual bool GetYAxisMinorTickVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetYAxisMinorTickVisibility_102(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B2E0 RID: 45792
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetYAxisRange_103(HandleRef pThis);

		/// <summary>
		/// Explicitly specify the range of each axes that's used to define the prop.
		/// The default, (if you do not use these methods) is to use the bounds
		/// specified, or use the bounds of the Input Prop if one is specified. This
		/// method allows you to separate the notion of extent of the axes in physical
		/// space (bounds) and the extent of the values it represents. In other words,
		/// you can have the ticks and labels show a different range.
		/// </summary>
		// Token: 0x0600B2E1 RID: 45793 RVA: 0x000FCC88 File Offset: 0x000FAE88
		public virtual double[] GetYAxisRange()
		{
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetYAxisRange_103(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600B2E2 RID: 45794
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_GetYAxisRange_104(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Explicitly specify the range of each axes that's used to define the prop.
		/// The default, (if you do not use these methods) is to use the bounds
		/// specified, or use the bounds of the Input Prop if one is specified. This
		/// method allows you to separate the notion of extent of the axes in physical
		/// space (bounds) and the extent of the values it represents. In other words,
		/// you can have the ticks and labels show a different range.
		/// </summary>
		// Token: 0x0600B2E3 RID: 45795 RVA: 0x000FCCD0 File Offset: 0x000FAED0
		public virtual void GetYAxisRange(ref double _arg1, ref double _arg2)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetYAxisRange_104(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600B2E4 RID: 45796
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_GetYAxisRange_105(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Explicitly specify the range of each axes that's used to define the prop.
		/// The default, (if you do not use these methods) is to use the bounds
		/// specified, or use the bounds of the Input Prop if one is specified. This
		/// method allows you to separate the notion of extent of the axes in physical
		/// space (bounds) and the extent of the values it represents. In other words,
		/// you can have the ticks and labels show a different range.
		/// </summary>
		// Token: 0x0600B2E5 RID: 45797 RVA: 0x000FCCE1 File Offset: 0x000FAEE1
		public virtual void GetYAxisRange(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetYAxisRange_105(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B2E6 RID: 45798
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetYAxisTickVisibility_106(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B2E7 RID: 45799 RVA: 0x000FCCF4 File Offset: 0x000FAEF4
		public virtual bool GetYAxisTickVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetYAxisTickVisibility_106(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B2E8 RID: 45800
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetYAxisVisibility_107(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B2E9 RID: 45801 RVA: 0x000FCD1C File Offset: 0x000FAF1C
		public virtual bool GetYAxisVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetYAxisVisibility_107(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B2EA RID: 45802
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetYLabelFormat_108(HandleRef pThis);

		/// <summary>
		/// Set/Get the format with which to print the labels on each of the
		/// x-y-z axes.
		/// </summary>
		// Token: 0x0600B2EB RID: 45803 RVA: 0x000FCD44 File Offset: 0x000FAF44
		public virtual string GetYLabelFormat()
		{
			string s = Marshal.PtrToStringAnsi(vtkCubeAxesActor.vtkCubeAxesActor_GetYLabelFormat_108(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B2EC RID: 45804
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetYTitle_109(HandleRef pThis);

		/// <summary>
		/// Set/Get the labels for the x, y, and z axes. By default,
		/// use "X-Axis", "Y-Axis" and "Z-Axis".
		/// </summary>
		// Token: 0x0600B2ED RID: 45805 RVA: 0x000FCD80 File Offset: 0x000FAF80
		public virtual string GetYTitle()
		{
			string s = Marshal.PtrToStringAnsi(vtkCubeAxesActor.vtkCubeAxesActor_GetYTitle_109(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B2EE RID: 45806
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetYUnits_110(HandleRef pThis);

		/// <summary>
		/// Set/Get the labels for the x, y, and z axes. By default,
		/// use "X-Axis", "Y-Axis" and "Z-Axis".
		/// </summary>
		// Token: 0x0600B2EF RID: 45807 RVA: 0x000FCDBC File Offset: 0x000FAFBC
		public virtual string GetYUnits()
		{
			string s = Marshal.PtrToStringAnsi(vtkCubeAxesActor.vtkCubeAxesActor_GetYUnits_110(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B2F0 RID: 45808
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetZAxesGridlinesProperty_111(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set axes (outer) gridlines actors properties.
		/// </summary>
		// Token: 0x0600B2F1 RID: 45809 RVA: 0x000FCDF8 File Offset: 0x000FAFF8
		public vtkProperty GetZAxesGridlinesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetZAxesGridlinesProperty_111(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600B2F2 RID: 45810
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetZAxesGridpolysProperty_112(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set axes gridPolys actors properties.
		/// </summary>
		// Token: 0x0600B2F3 RID: 45811 RVA: 0x000FCE68 File Offset: 0x000FB068
		public vtkProperty GetZAxesGridpolysProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetZAxesGridpolysProperty_112(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600B2F4 RID: 45812
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetZAxesInnerGridlinesProperty_113(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set axes inner gridlines actors properties.
		/// </summary>
		// Token: 0x0600B2F5 RID: 45813 RVA: 0x000FCED8 File Offset: 0x000FB0D8
		public vtkProperty GetZAxesInnerGridlinesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetZAxesInnerGridlinesProperty_113(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600B2F6 RID: 45814
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetZAxesLinesProperty_114(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set axes actors properties.
		/// </summary>
		// Token: 0x0600B2F7 RID: 45815 RVA: 0x000FCF48 File Offset: 0x000FB148
		public vtkProperty GetZAxesLinesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetZAxesLinesProperty_114(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600B2F8 RID: 45816
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetZAxisLabelVisibility_115(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of labels for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B2F9 RID: 45817 RVA: 0x000FCFB8 File Offset: 0x000FB1B8
		public virtual bool GetZAxisLabelVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetZAxisLabelVisibility_115(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B2FA RID: 45818
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetZAxisMinorTickVisibility_116(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of minor ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B2FB RID: 45819 RVA: 0x000FCFE0 File Offset: 0x000FB1E0
		public virtual bool GetZAxisMinorTickVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetZAxisMinorTickVisibility_116(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B2FC RID: 45820
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetZAxisRange_117(HandleRef pThis);

		/// <summary>
		/// Explicitly specify the axis labels along an axis as an array of strings
		/// instead of using the values.
		/// </summary>
		// Token: 0x0600B2FD RID: 45821 RVA: 0x000FD008 File Offset: 0x000FB208
		public virtual double[] GetZAxisRange()
		{
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetZAxisRange_117(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600B2FE RID: 45822
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_GetZAxisRange_118(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Explicitly specify the axis labels along an axis as an array of strings
		/// instead of using the values.
		/// </summary>
		// Token: 0x0600B2FF RID: 45823 RVA: 0x000FD050 File Offset: 0x000FB250
		public virtual void GetZAxisRange(ref double _arg1, ref double _arg2)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetZAxisRange_118(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600B300 RID: 45824
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_GetZAxisRange_119(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Explicitly specify the axis labels along an axis as an array of strings
		/// instead of using the values.
		/// </summary>
		// Token: 0x0600B301 RID: 45825 RVA: 0x000FD061 File Offset: 0x000FB261
		public virtual void GetZAxisRange(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetZAxisRange_119(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B302 RID: 45826
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetZAxisTickVisibility_120(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B303 RID: 45827 RVA: 0x000FD074 File Offset: 0x000FB274
		public virtual bool GetZAxisTickVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetZAxisTickVisibility_120(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B304 RID: 45828
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCubeAxesActor_GetZAxisVisibility_121(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B305 RID: 45829 RVA: 0x000FD09C File Offset: 0x000FB29C
		public virtual bool GetZAxisVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetZAxisVisibility_121(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B306 RID: 45830
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetZLabelFormat_122(HandleRef pThis);

		/// <summary>
		/// Set/Get the format with which to print the labels on each of the
		/// x-y-z axes.
		/// </summary>
		// Token: 0x0600B307 RID: 45831 RVA: 0x000FD0C4 File Offset: 0x000FB2C4
		public virtual string GetZLabelFormat()
		{
			string s = Marshal.PtrToStringAnsi(vtkCubeAxesActor.vtkCubeAxesActor_GetZLabelFormat_122(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B308 RID: 45832
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetZTitle_123(HandleRef pThis);

		/// <summary>
		/// Set/Get the labels for the x, y, and z axes. By default,
		/// use "X-Axis", "Y-Axis" and "Z-Axis".
		/// </summary>
		// Token: 0x0600B309 RID: 45833 RVA: 0x000FD100 File Offset: 0x000FB300
		public virtual string GetZTitle()
		{
			string s = Marshal.PtrToStringAnsi(vtkCubeAxesActor.vtkCubeAxesActor_GetZTitle_123(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B30A RID: 45834
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_GetZUnits_124(HandleRef pThis);

		/// <summary>
		/// Set/Get the labels for the x, y, and z axes. By default,
		/// use "X-Axis", "Y-Axis" and "Z-Axis".
		/// </summary>
		// Token: 0x0600B30B RID: 45835 RVA: 0x000FD13C File Offset: 0x000FB33C
		public virtual string GetZUnits()
		{
			string s = Marshal.PtrToStringAnsi(vtkCubeAxesActor.vtkCubeAxesActor_GetZUnits_124(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B30C RID: 45836
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor_HasTranslucentPolygonalGeometry_125(HandleRef pThis);

		/// <summary>
		/// Draw the axes as per the vtkProp superclass' API.
		/// </summary>
		// Token: 0x0600B30D RID: 45837 RVA: 0x000FD178 File Offset: 0x000FB378
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_HasTranslucentPolygonalGeometry_125(base.GetCppThis());
		}

		// Token: 0x0600B30E RID: 45838
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor_IsA_126(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B30F RID: 45839 RVA: 0x000FD198 File Offset: 0x000FB398
		public override int IsA(string type)
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_IsA_126(base.GetCppThis(), type);
		}

		// Token: 0x0600B310 RID: 45840
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor_IsTypeOf_127([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B311 RID: 45841 RVA: 0x000FD1B8 File Offset: 0x000FB3B8
		public new static int IsTypeOf(string type)
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_IsTypeOf_127(type);
		}

		// Token: 0x0600B312 RID: 45842
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_NewInstance_129(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B313 RID: 45843 RVA: 0x000FD1D4 File Offset: 0x000FB3D4
		public new vtkCubeAxesActor NewInstance()
		{
			vtkCubeAxesActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_NewInstance_129(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCubeAxesActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600B314 RID: 45844
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_ReleaseGraphicsResources_130(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600B315 RID: 45845 RVA: 0x000FD230 File Offset: 0x000FB430
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_ReleaseGraphicsResources_130(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B316 RID: 45846
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor_RenderOpaqueGeometry_131(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the axes as per the vtkProp superclass' API.
		/// </summary>
		// Token: 0x0600B317 RID: 45847 RVA: 0x000FD260 File Offset: 0x000FB460
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_RenderOpaqueGeometry_131(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B318 RID: 45848
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor_RenderOverlay_132(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the axes as per the vtkProp superclass' API.
		/// </summary>
		// Token: 0x0600B319 RID: 45849 RVA: 0x000FD294 File Offset: 0x000FB494
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_RenderOverlay_132(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B31A RID: 45850
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor_RenderTranslucentGeometry_133(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the axes as per the vtkProp superclass' API.
		/// </summary>
		// Token: 0x0600B31B RID: 45851 RVA: 0x000FD2C8 File Offset: 0x000FB4C8
		public virtual int RenderTranslucentGeometry(vtkViewport arg0)
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_RenderTranslucentGeometry_133(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B31C RID: 45852
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor_RenderTranslucentPolygonalGeometry_134(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the axes as per the vtkProp superclass' API.
		/// </summary>
		// Token: 0x0600B31D RID: 45853 RVA: 0x000FD2FC File Offset: 0x000FB4FC
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_RenderTranslucentPolygonalGeometry_134(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B31E RID: 45854
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor_SafeDownCast_135(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B31F RID: 45855 RVA: 0x000FD330 File Offset: 0x000FB530
		public new static vtkCubeAxesActor SafeDownCast(vtkObjectBase o)
		{
			vtkCubeAxesActor vtkCubeAxesActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_SafeDownCast_135((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCubeAxesActor = (vtkCubeAxesActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCubeAxesActor.Register(null);
				}
			}
			return vtkCubeAxesActor;
		}

		// Token: 0x0600B320 RID: 45856
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetAxisBaseForX_136(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Vector that should be use as the base for X.
		/// Default: (1.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x0600B321 RID: 45857 RVA: 0x000FD3AF File Offset: 0x000FB5AF
		public virtual void SetAxisBaseForX(double _arg1, double _arg2, double _arg3)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetAxisBaseForX_136(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600B322 RID: 45858
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetAxisBaseForX_137(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Vector that should be use as the base for X.
		/// Default: (1.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x0600B323 RID: 45859 RVA: 0x000FD3C1 File Offset: 0x000FB5C1
		public virtual void SetAxisBaseForX(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetAxisBaseForX_137(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B324 RID: 45860
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetAxisBaseForY_138(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Vector that should be use as the base for Y.
		/// Default: (0.0, 1.0, 0.0).
		/// </summary>
		// Token: 0x0600B325 RID: 45861 RVA: 0x000FD3D1 File Offset: 0x000FB5D1
		public virtual void SetAxisBaseForY(double _arg1, double _arg2, double _arg3)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetAxisBaseForY_138(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600B326 RID: 45862
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetAxisBaseForY_139(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Vector that should be use as the base for Y.
		/// Default: (0.0, 1.0, 0.0).
		/// </summary>
		// Token: 0x0600B327 RID: 45863 RVA: 0x000FD3E3 File Offset: 0x000FB5E3
		public virtual void SetAxisBaseForY(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetAxisBaseForY_139(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B328 RID: 45864
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetAxisBaseForZ_140(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Vector that should be use as the base for Z.
		/// Default: (0.0, 0.0, 1.0).
		/// </summary>
		// Token: 0x0600B329 RID: 45865 RVA: 0x000FD3F3 File Offset: 0x000FB5F3
		public virtual void SetAxisBaseForZ(double _arg1, double _arg2, double _arg3)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetAxisBaseForZ_140(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600B32A RID: 45866
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetAxisBaseForZ_141(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Vector that should be use as the base for Z.
		/// Default: (0.0, 0.0, 1.0).
		/// </summary>
		// Token: 0x0600B32B RID: 45867 RVA: 0x000FD405 File Offset: 0x000FB605
		public virtual void SetAxisBaseForZ(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetAxisBaseForZ_141(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B32C RID: 45868
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetAxisLabels_142(HandleRef pThis, int axis, HandleRef value);

		/// <summary>
		/// Explicitly specify the axis labels along an axis as an array of strings
		/// instead of using the values.
		/// </summary>
		// Token: 0x0600B32D RID: 45869 RVA: 0x000FD418 File Offset: 0x000FB618
		public void SetAxisLabels(int axis, vtkStringArray value)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetAxisLabels_142(base.GetCppThis(), axis, (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0600B32E RID: 45870
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetAxisOrigin_143(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Provide a custom AxisOrigin. This point must be inside the bounding box and
		/// will represent the point where the 3 axes will intersect.
		/// Default: (0.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x0600B32F RID: 45871 RVA: 0x000FD448 File Offset: 0x000FB648
		public virtual void SetAxisOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetAxisOrigin_143(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600B330 RID: 45872
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetAxisOrigin_144(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Provide a custom AxisOrigin. This point must be inside the bounding box and
		/// will represent the point where the 3 axes will intersect.
		/// Default: (0.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x0600B331 RID: 45873 RVA: 0x000FD45A File Offset: 0x000FB65A
		public virtual void SetAxisOrigin(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetAxisOrigin_144(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B332 RID: 45874
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetBounds_145(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Explicitly specify the region in space around which to draw the bounds.
		/// The bounds is used only when no Input or Prop is specified. The bounds
		/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
		/// sure that the min's are less than the max's.
		/// </summary>
		// Token: 0x0600B333 RID: 45875 RVA: 0x000FD46A File Offset: 0x000FB66A
		public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetBounds_145(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0600B334 RID: 45876
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetBounds_146(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Explicitly specify the region in space around which to draw the bounds.
		/// The bounds is used only when no Input or Prop is specified. The bounds
		/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
		/// sure that the min's are less than the max's.
		/// </summary>
		// Token: 0x0600B335 RID: 45877 RVA: 0x000FD482 File Offset: 0x000FB682
		public virtual void SetBounds(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetBounds_146(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B336 RID: 45878
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetCamera_147(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the camera to perform scaling and translation of the
		/// vtkCubeAxesActor.
		/// </summary>
		// Token: 0x0600B337 RID: 45879 RVA: 0x000FD494 File Offset: 0x000FB694
		public virtual void SetCamera(vtkCamera arg0)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetCamera_147(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B338 RID: 45880
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetCenterStickyAxes_148(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/Disable centering of axes when the Sticky option is
		/// on. If on, the axes bounds will be centered in the
		/// viewport. Otherwise, the axes can move about the longer of the
		/// horizontal or vertical directions of the viewport to follow the
		/// data.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B339 RID: 45881 RVA: 0x000FD4C3 File Offset: 0x000FB6C3
		public virtual void SetCenterStickyAxes(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetCenterStickyAxes_148(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B33A RID: 45882
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetCornerOffset_149(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify an offset value to "pull back" the axes from the corner at
		/// which they are joined to avoid overlap of axes labels. The
		/// "CornerOffset" is the fraction of the axis length to pull back.
		/// Default: 0.0.
		/// </summary>
		// Token: 0x0600B33B RID: 45883 RVA: 0x000FD4DB File Offset: 0x000FB6DB
		public virtual void SetCornerOffset(double _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetCornerOffset_149(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B33C RID: 45884
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetDistanceLODThreshold_150(HandleRef pThis, double _arg);

		/// <summary>
		/// Set distance LOD threshold [0.0 - 1.0] for titles and labels.
		/// Default: 0.8.
		/// </summary>
		// Token: 0x0600B33D RID: 45885 RVA: 0x000FD4EB File Offset: 0x000FB6EB
		public virtual void SetDistanceLODThreshold(double _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetDistanceLODThreshold_150(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B33E RID: 45886
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetDrawXGridlines_151(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B33F RID: 45887 RVA: 0x000FD4FB File Offset: 0x000FB6FB
		public virtual void SetDrawXGridlines(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetDrawXGridlines_151(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B340 RID: 45888
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetDrawXGridpolys_152(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of grid polys for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B341 RID: 45889 RVA: 0x000FD513 File Offset: 0x000FB713
		public virtual void SetDrawXGridpolys(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetDrawXGridpolys_152(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B342 RID: 45890
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetDrawXInnerGridlines_153(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of inner grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B343 RID: 45891 RVA: 0x000FD52B File Offset: 0x000FB72B
		public virtual void SetDrawXInnerGridlines(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetDrawXInnerGridlines_153(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B344 RID: 45892
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetDrawYGridlines_154(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B345 RID: 45893 RVA: 0x000FD543 File Offset: 0x000FB743
		public virtual void SetDrawYGridlines(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetDrawYGridlines_154(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B346 RID: 45894
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetDrawYGridpolys_155(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of grid polys for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B347 RID: 45895 RVA: 0x000FD55B File Offset: 0x000FB75B
		public virtual void SetDrawYGridpolys(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetDrawYGridpolys_155(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B348 RID: 45896
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetDrawYInnerGridlines_156(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of inner grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B349 RID: 45897 RVA: 0x000FD573 File Offset: 0x000FB773
		public virtual void SetDrawYInnerGridlines(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetDrawYInnerGridlines_156(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B34A RID: 45898
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetDrawZGridlines_157(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B34B RID: 45899 RVA: 0x000FD58B File Offset: 0x000FB78B
		public virtual void SetDrawZGridlines(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetDrawZGridlines_157(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B34C RID: 45900
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetDrawZGridpolys_158(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of grid polys for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B34D RID: 45901 RVA: 0x000FD5A3 File Offset: 0x000FB7A3
		public virtual void SetDrawZGridpolys(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetDrawZGridpolys_158(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B34E RID: 45902
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetDrawZInnerGridlines_159(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of inner grid lines for each axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B34F RID: 45903 RVA: 0x000FD5BB File Offset: 0x000FB7BB
		public virtual void SetDrawZInnerGridlines(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetDrawZInnerGridlines_159(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B350 RID: 45904
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetEnableDistanceLOD_160(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable and disable the use of distance based LOD for titles and labels.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B351 RID: 45905 RVA: 0x000FD5D3 File Offset: 0x000FB7D3
		public virtual void SetEnableDistanceLOD(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetEnableDistanceLOD_160(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B352 RID: 45906
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetEnableViewAngleLOD_161(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable and disable the use of view angle based LOD for titles and labels.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B353 RID: 45907 RVA: 0x000FD5EB File Offset: 0x000FB7EB
		public virtual void SetEnableViewAngleLOD(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetEnableViewAngleLOD_161(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B354 RID: 45908
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetFlyMode_162(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify a mode to control how the axes are drawn: either static,
		/// closest triad, furthest triad or outer edges in relation to the
		/// camera position.
		/// Default: VTK_FLY_CLOSEST_TRIAD.
		/// </summary>
		// Token: 0x0600B355 RID: 45909 RVA: 0x000FD603 File Offset: 0x000FB803
		public virtual void SetFlyMode(int _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetFlyMode_162(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B356 RID: 45910
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetFlyModeToClosestTriad_163(HandleRef pThis);

		/// <summary>
		/// Specify a mode to control how the axes are drawn: either static,
		/// closest triad, furthest triad or outer edges in relation to the
		/// camera position.
		/// Default: VTK_FLY_CLOSEST_TRIAD.
		/// </summary>
		// Token: 0x0600B357 RID: 45911 RVA: 0x000FD613 File Offset: 0x000FB813
		public void SetFlyModeToClosestTriad()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetFlyModeToClosestTriad_163(base.GetCppThis());
		}

		// Token: 0x0600B358 RID: 45912
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetFlyModeToFurthestTriad_164(HandleRef pThis);

		/// <summary>
		/// Specify a mode to control how the axes are drawn: either static,
		/// closest triad, furthest triad or outer edges in relation to the
		/// camera position.
		/// Default: VTK_FLY_CLOSEST_TRIAD.
		/// </summary>
		// Token: 0x0600B359 RID: 45913 RVA: 0x000FD622 File Offset: 0x000FB822
		public void SetFlyModeToFurthestTriad()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetFlyModeToFurthestTriad_164(base.GetCppThis());
		}

		// Token: 0x0600B35A RID: 45914
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetFlyModeToOuterEdges_165(HandleRef pThis);

		/// <summary>
		/// Specify a mode to control how the axes are drawn: either static,
		/// closest triad, furthest triad or outer edges in relation to the
		/// camera position.
		/// Default: VTK_FLY_CLOSEST_TRIAD.
		/// </summary>
		// Token: 0x0600B35B RID: 45915 RVA: 0x000FD631 File Offset: 0x000FB831
		public void SetFlyModeToOuterEdges()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetFlyModeToOuterEdges_165(base.GetCppThis());
		}

		// Token: 0x0600B35C RID: 45916
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetFlyModeToStaticEdges_166(HandleRef pThis);

		/// <summary>
		/// Specify a mode to control how the axes are drawn: either static,
		/// closest triad, furthest triad or outer edges in relation to the
		/// camera position.
		/// Default: VTK_FLY_CLOSEST_TRIAD.
		/// </summary>
		// Token: 0x0600B35D RID: 45917 RVA: 0x000FD640 File Offset: 0x000FB840
		public void SetFlyModeToStaticEdges()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetFlyModeToStaticEdges_166(base.GetCppThis());
		}

		// Token: 0x0600B35E RID: 45918
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetFlyModeToStaticTriad_167(HandleRef pThis);

		/// <summary>
		/// Specify a mode to control how the axes are drawn: either static,
		/// closest triad, furthest triad or outer edges in relation to the
		/// camera position.
		/// Default: VTK_FLY_CLOSEST_TRIAD.
		/// </summary>
		// Token: 0x0600B35F RID: 45919 RVA: 0x000FD64F File Offset: 0x000FB84F
		public void SetFlyModeToStaticTriad()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetFlyModeToStaticTriad_167(base.GetCppThis());
		}

		// Token: 0x0600B360 RID: 45920
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetGridLineLocation_168(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the mode in which the cube axes should render its gridLines.
		/// Default: VTK_GRID_LINES_ALL.
		/// </summary>
		// Token: 0x0600B361 RID: 45921 RVA: 0x000FD65E File Offset: 0x000FB85E
		public virtual void SetGridLineLocation(int _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetGridLineLocation_168(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B362 RID: 45922
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetInertia_169(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the inertial factor that controls how often (i.e, how
		/// many renders) the axes can switch position (jump from one axes
		/// to another).
		/// Default: 1.
		/// </summary>
		// Token: 0x0600B363 RID: 45923 RVA: 0x000FD66E File Offset: 0x000FB86E
		public virtual void SetInertia(int _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetInertia_169(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B364 RID: 45924
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetLabelOffset_170(HandleRef pThis, double offset);

		/// <summary>
		/// Explicitly specify the offset between labels and the axis.
		/// Default: 20.0.
		/// </summary>
		// Token: 0x0600B365 RID: 45925 RVA: 0x000FD67E File Offset: 0x000FB87E
		public void SetLabelOffset(double offset)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetLabelOffset_170(base.GetCppThis(), offset);
		}

		// Token: 0x0600B366 RID: 45926
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetLabelScaling_171(HandleRef pThis, byte arg0, int arg1, int arg2, int arg3);

		/// <summary>
		/// Set/Get the location of ticks marks.
		/// Default: VTK_TICKS_INSIDE.
		/// </summary>
		// Token: 0x0600B367 RID: 45927 RVA: 0x000FD68E File Offset: 0x000FB88E
		public void SetLabelScaling(bool arg0, int arg1, int arg2, int arg3)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetLabelScaling_171(base.GetCppThis(), arg0 ? (byte)1 : (byte)0, arg1, arg2, arg3);
		}

		// Token: 0x0600B368 RID: 45928
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetOrientedBounds_172(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Provide an oriented bounded box when using AxisBaseFor.
		/// Default: (-1, 1, -1, 1, -1, 1).
		/// </summary>
		// Token: 0x0600B369 RID: 45929 RVA: 0x000FD6AA File Offset: 0x000FB8AA
		public virtual void SetOrientedBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetOrientedBounds_172(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0600B36A RID: 45930
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetOrientedBounds_173(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Provide an oriented bounded box when using AxisBaseFor.
		/// Default: (-1, 1, -1, 1, -1, 1).
		/// </summary>
		// Token: 0x0600B36B RID: 45931 RVA: 0x000FD6C2 File Offset: 0x000FB8C2
		public virtual void SetOrientedBounds(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetOrientedBounds_173(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B36C RID: 45932
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetRebuildAxes_174(HandleRef pThis, byte _arg);

		/// <summary>
		/// Gets/Sets the RebuildAxes flag.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B36D RID: 45933 RVA: 0x000FD6D2 File Offset: 0x000FB8D2
		public virtual void SetRebuildAxes(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetRebuildAxes_174(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B36E RID: 45934
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetSaveTitlePosition_175(HandleRef pThis, int val);

		/// <summary>
		/// For 2D mode only: save axis title positions for later use
		/// </summary>
		// Token: 0x0600B36F RID: 45935 RVA: 0x000FD6EA File Offset: 0x000FB8EA
		public void SetSaveTitlePosition(int val)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetSaveTitlePosition_175(base.GetCppThis(), val);
		}

		// Token: 0x0600B370 RID: 45936
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetScreenSize_176(HandleRef pThis, double screenSize);

		/// <summary>
		/// Explicitly specify the screen size of title and label text.
		/// ScreenSize determines the size of the text in terms of screen
		/// pixels.
		/// Default: 10.0.
		/// </summary>
		// Token: 0x0600B371 RID: 45937 RVA: 0x000FD6FA File Offset: 0x000FB8FA
		public void SetScreenSize(double screenSize)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetScreenSize_176(base.GetCppThis(), screenSize);
		}

		// Token: 0x0600B372 RID: 45938
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetStickyAxes_177(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/Disable axis stickiness. When on, the axes will be adjusted to always
		/// be visible in the viewport unless the original bounds of the axes are entirely
		/// outside the viewport.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B373 RID: 45939 RVA: 0x000FD70A File Offset: 0x000FB90A
		public virtual void SetStickyAxes(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetStickyAxes_177(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B374 RID: 45940
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetTickLocation_178(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the location of ticks marks.
		/// Default: VTK_TICKS_INSIDE.
		/// </summary>
		// Token: 0x0600B375 RID: 45941 RVA: 0x000FD722 File Offset: 0x000FB922
		public virtual void SetTickLocation(int _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetTickLocation_178(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B376 RID: 45942
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetTickLocationToBoth_179(HandleRef pThis);

		/// <summary>
		/// Set/Get the location of ticks marks.
		/// Default: VTK_TICKS_INSIDE.
		/// </summary>
		// Token: 0x0600B377 RID: 45943 RVA: 0x000FD732 File Offset: 0x000FB932
		public void SetTickLocationToBoth()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetTickLocationToBoth_179(base.GetCppThis());
		}

		// Token: 0x0600B378 RID: 45944
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetTickLocationToInside_180(HandleRef pThis);

		/// <summary>
		/// Set/Get the location of ticks marks.
		/// Default: VTK_TICKS_INSIDE.
		/// </summary>
		// Token: 0x0600B379 RID: 45945 RVA: 0x000FD741 File Offset: 0x000FB941
		public void SetTickLocationToInside()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetTickLocationToInside_180(base.GetCppThis());
		}

		// Token: 0x0600B37A RID: 45946
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetTickLocationToOutside_181(HandleRef pThis);

		/// <summary>
		/// Set/Get the location of ticks marks.
		/// Default: VTK_TICKS_INSIDE.
		/// </summary>
		// Token: 0x0600B37B RID: 45947 RVA: 0x000FD750 File Offset: 0x000FB950
		public void SetTickLocationToOutside()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetTickLocationToOutside_181(base.GetCppThis());
		}

		// Token: 0x0600B37C RID: 45948
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetTitleOffset_182(HandleRef pThis, IntPtr titleOffset);

		/// <summary>
		/// Explicitly specify the offset between title and labels.
		/// Default: (20.0, 20.0).
		/// </summary>
		// Token: 0x0600B37D RID: 45949 RVA: 0x000FD75F File Offset: 0x000FB95F
		public void SetTitleOffset(IntPtr titleOffset)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetTitleOffset_182(base.GetCppThis(), titleOffset);
		}

		// Token: 0x0600B37E RID: 45950
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetUse2DMode_183(HandleRef pThis, byte enable);

		/// <summary>
		/// Get/Set 2D mode
		/// NB: Use vtkTextActor for titles in 2D instead of vtkAxisFollower
		/// </summary>
		// Token: 0x0600B37F RID: 45951 RVA: 0x000FD76F File Offset: 0x000FB96F
		public void SetUse2DMode(bool enable)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetUse2DMode_183(base.GetCppThis(), enable ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B380 RID: 45952
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetUseAxisOrigin_184(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/Disable the usage of the AxisOrigin.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B381 RID: 45953 RVA: 0x000FD787 File Offset: 0x000FB987
		public virtual void SetUseAxisOrigin(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetUseAxisOrigin_184(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B382 RID: 45954
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetUseOrientedBounds_185(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/Disable the usage of the OrientedBounds.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B383 RID: 45955 RVA: 0x000FD79F File Offset: 0x000FB99F
		public virtual void SetUseOrientedBounds(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetUseOrientedBounds_185(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B384 RID: 45956
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetUseTextActor3D_186(HandleRef pThis, byte enable);

		/// <summary>
		/// Use or not vtkTextActor3D for titles and labels.
		/// See Also:
		/// vtkAxisActor::SetUseTextActor3D(), vtkAxisActor::GetUseTextActor3D()
		/// </summary>
		// Token: 0x0600B385 RID: 45957 RVA: 0x000FD7B7 File Offset: 0x000FB9B7
		public void SetUseTextActor3D(bool enable)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetUseTextActor3D_186(base.GetCppThis(), enable ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B386 RID: 45958
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetViewAngleLODThreshold_187(HandleRef pThis, double _arg);

		/// <summary>
		/// Set view angle LOD threshold [0.0 - 1.0] for titles and labels.
		/// Default: 0.2.
		/// </summary>
		// Token: 0x0600B387 RID: 45959 RVA: 0x000FD7CF File Offset: 0x000FB9CF
		public virtual void SetViewAngleLODThreshold(double _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetViewAngleLODThreshold_187(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B388 RID: 45960
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetXAxesGridlinesProperty_188(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set axes (outer) gridlines actors properties.
		/// </summary>
		// Token: 0x0600B389 RID: 45961 RVA: 0x000FD7E0 File Offset: 0x000FB9E0
		public void SetXAxesGridlinesProperty(vtkProperty arg0)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetXAxesGridlinesProperty_188(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B38A RID: 45962
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetXAxesGridpolysProperty_189(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set axes gridPolys actors properties.
		/// </summary>
		// Token: 0x0600B38B RID: 45963 RVA: 0x000FD810 File Offset: 0x000FBA10
		public void SetXAxesGridpolysProperty(vtkProperty arg0)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetXAxesGridpolysProperty_189(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B38C RID: 45964
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetXAxesInnerGridlinesProperty_190(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set axes inner gridlines actors properties.
		/// </summary>
		// Token: 0x0600B38D RID: 45965 RVA: 0x000FD840 File Offset: 0x000FBA40
		public void SetXAxesInnerGridlinesProperty(vtkProperty arg0)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetXAxesInnerGridlinesProperty_190(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B38E RID: 45966
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetXAxesLinesProperty_191(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set axes actors properties.
		/// </summary>
		// Token: 0x0600B38F RID: 45967 RVA: 0x000FD870 File Offset: 0x000FBA70
		public void SetXAxesLinesProperty(vtkProperty arg0)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetXAxesLinesProperty_191(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B390 RID: 45968
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetXAxisLabelVisibility_192(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of labels for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B391 RID: 45969 RVA: 0x000FD89F File Offset: 0x000FBA9F
		public virtual void SetXAxisLabelVisibility(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetXAxisLabelVisibility_192(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B392 RID: 45970
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetXAxisMinorTickVisibility_193(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of minor ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B393 RID: 45971 RVA: 0x000FD8B7 File Offset: 0x000FBAB7
		public virtual void SetXAxisMinorTickVisibility(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetXAxisMinorTickVisibility_193(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B394 RID: 45972
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetXAxisRange_194(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Explicitly specify the range of each axes that's used to define the prop.
		/// The default, (if you do not use these methods) is to use the bounds
		/// specified, or use the bounds of the Input Prop if one is specified. This
		/// method allows you to separate the notion of extent of the axes in physical
		/// space (bounds) and the extent of the values it represents. In other words,
		/// you can have the ticks and labels show a different range.
		/// </summary>
		// Token: 0x0600B395 RID: 45973 RVA: 0x000FD8CF File Offset: 0x000FBACF
		public virtual void SetXAxisRange(double _arg1, double _arg2)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetXAxisRange_194(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600B396 RID: 45974
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetXAxisRange_195(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Explicitly specify the range of each axes that's used to define the prop.
		/// The default, (if you do not use these methods) is to use the bounds
		/// specified, or use the bounds of the Input Prop if one is specified. This
		/// method allows you to separate the notion of extent of the axes in physical
		/// space (bounds) and the extent of the values it represents. In other words,
		/// you can have the ticks and labels show a different range.
		/// </summary>
		// Token: 0x0600B397 RID: 45975 RVA: 0x000FD8E0 File Offset: 0x000FBAE0
		public void SetXAxisRange(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetXAxisRange_195(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B398 RID: 45976
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetXAxisTickVisibility_196(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B399 RID: 45977 RVA: 0x000FD8F0 File Offset: 0x000FBAF0
		public virtual void SetXAxisTickVisibility(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetXAxisTickVisibility_196(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B39A RID: 45978
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetXAxisVisibility_197(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B39B RID: 45979 RVA: 0x000FD908 File Offset: 0x000FBB08
		public virtual void SetXAxisVisibility(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetXAxisVisibility_197(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B39C RID: 45980
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetXLabelFormat_198(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the format with which to print the labels on each of the
		/// x-y-z axes.
		/// </summary>
		// Token: 0x0600B39D RID: 45981 RVA: 0x000FD920 File Offset: 0x000FBB20
		public virtual void SetXLabelFormat(string _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetXLabelFormat_198(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B39E RID: 45982
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetXTitle_199(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the labels for the x, y, and z axes. By default,
		/// use "X-Axis", "Y-Axis" and "Z-Axis".
		/// </summary>
		// Token: 0x0600B39F RID: 45983 RVA: 0x000FD930 File Offset: 0x000FBB30
		public virtual void SetXTitle(string _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetXTitle_199(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B3A0 RID: 45984
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetXUnits_200(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the labels for the x, y, and z axes. By default,
		/// use "X-Axis", "Y-Axis" and "Z-Axis".
		/// </summary>
		// Token: 0x0600B3A1 RID: 45985 RVA: 0x000FD940 File Offset: 0x000FBB40
		public virtual void SetXUnits(string _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetXUnits_200(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B3A2 RID: 45986
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetYAxesGridlinesProperty_201(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set axes (outer) gridlines actors properties.
		/// </summary>
		// Token: 0x0600B3A3 RID: 45987 RVA: 0x000FD950 File Offset: 0x000FBB50
		public void SetYAxesGridlinesProperty(vtkProperty arg0)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetYAxesGridlinesProperty_201(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B3A4 RID: 45988
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetYAxesGridpolysProperty_202(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set axes gridPolys actors properties.
		/// </summary>
		// Token: 0x0600B3A5 RID: 45989 RVA: 0x000FD980 File Offset: 0x000FBB80
		public void SetYAxesGridpolysProperty(vtkProperty arg0)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetYAxesGridpolysProperty_202(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B3A6 RID: 45990
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetYAxesInnerGridlinesProperty_203(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set axes inner gridlines actors properties.
		/// </summary>
		// Token: 0x0600B3A7 RID: 45991 RVA: 0x000FD9B0 File Offset: 0x000FBBB0
		public void SetYAxesInnerGridlinesProperty(vtkProperty arg0)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetYAxesInnerGridlinesProperty_203(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B3A8 RID: 45992
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetYAxesLinesProperty_204(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set axes actors properties.
		/// </summary>
		// Token: 0x0600B3A9 RID: 45993 RVA: 0x000FD9E0 File Offset: 0x000FBBE0
		public void SetYAxesLinesProperty(vtkProperty arg0)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetYAxesLinesProperty_204(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B3AA RID: 45994
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetYAxisLabelVisibility_205(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of labels for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3AB RID: 45995 RVA: 0x000FDA0F File Offset: 0x000FBC0F
		public virtual void SetYAxisLabelVisibility(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetYAxisLabelVisibility_205(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B3AC RID: 45996
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetYAxisMinorTickVisibility_206(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of minor ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3AD RID: 45997 RVA: 0x000FDA27 File Offset: 0x000FBC27
		public virtual void SetYAxisMinorTickVisibility(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetYAxisMinorTickVisibility_206(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B3AE RID: 45998
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetYAxisRange_207(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Explicitly specify the range of each axes that's used to define the prop.
		/// The default, (if you do not use these methods) is to use the bounds
		/// specified, or use the bounds of the Input Prop if one is specified. This
		/// method allows you to separate the notion of extent of the axes in physical
		/// space (bounds) and the extent of the values it represents. In other words,
		/// you can have the ticks and labels show a different range.
		/// </summary>
		// Token: 0x0600B3AF RID: 45999 RVA: 0x000FDA3F File Offset: 0x000FBC3F
		public virtual void SetYAxisRange(double _arg1, double _arg2)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetYAxisRange_207(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600B3B0 RID: 46000
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetYAxisRange_208(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Explicitly specify the range of each axes that's used to define the prop.
		/// The default, (if you do not use these methods) is to use the bounds
		/// specified, or use the bounds of the Input Prop if one is specified. This
		/// method allows you to separate the notion of extent of the axes in physical
		/// space (bounds) and the extent of the values it represents. In other words,
		/// you can have the ticks and labels show a different range.
		/// </summary>
		// Token: 0x0600B3B1 RID: 46001 RVA: 0x000FDA50 File Offset: 0x000FBC50
		public void SetYAxisRange(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetYAxisRange_208(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B3B2 RID: 46002
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetYAxisTickVisibility_209(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3B3 RID: 46003 RVA: 0x000FDA60 File Offset: 0x000FBC60
		public virtual void SetYAxisTickVisibility(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetYAxisTickVisibility_209(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B3B4 RID: 46004
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetYAxisVisibility_210(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3B5 RID: 46005 RVA: 0x000FDA78 File Offset: 0x000FBC78
		public virtual void SetYAxisVisibility(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetYAxisVisibility_210(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B3B6 RID: 46006
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetYLabelFormat_211(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the format with which to print the labels on each of the
		/// x-y-z axes.
		/// </summary>
		// Token: 0x0600B3B7 RID: 46007 RVA: 0x000FDA90 File Offset: 0x000FBC90
		public virtual void SetYLabelFormat(string _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetYLabelFormat_211(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B3B8 RID: 46008
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetYTitle_212(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the labels for the x, y, and z axes. By default,
		/// use "X-Axis", "Y-Axis" and "Z-Axis".
		/// </summary>
		// Token: 0x0600B3B9 RID: 46009 RVA: 0x000FDAA0 File Offset: 0x000FBCA0
		public virtual void SetYTitle(string _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetYTitle_212(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B3BA RID: 46010
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetYUnits_213(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the labels for the x, y, and z axes. By default,
		/// use "X-Axis", "Y-Axis" and "Z-Axis".
		/// </summary>
		// Token: 0x0600B3BB RID: 46011 RVA: 0x000FDAB0 File Offset: 0x000FBCB0
		public virtual void SetYUnits(string _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetYUnits_213(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B3BC RID: 46012
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetZAxesGridlinesProperty_214(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set axes (outer) gridlines actors properties.
		/// </summary>
		// Token: 0x0600B3BD RID: 46013 RVA: 0x000FDAC0 File Offset: 0x000FBCC0
		public void SetZAxesGridlinesProperty(vtkProperty arg0)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetZAxesGridlinesProperty_214(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B3BE RID: 46014
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetZAxesGridpolysProperty_215(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set axes gridPolys actors properties.
		/// </summary>
		// Token: 0x0600B3BF RID: 46015 RVA: 0x000FDAF0 File Offset: 0x000FBCF0
		public void SetZAxesGridpolysProperty(vtkProperty arg0)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetZAxesGridpolysProperty_215(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B3C0 RID: 46016
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetZAxesInnerGridlinesProperty_216(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set axes inner gridlines actors properties.
		/// </summary>
		// Token: 0x0600B3C1 RID: 46017 RVA: 0x000FDB20 File Offset: 0x000FBD20
		public void SetZAxesInnerGridlinesProperty(vtkProperty arg0)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetZAxesInnerGridlinesProperty_216(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B3C2 RID: 46018
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetZAxesLinesProperty_217(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set axes actors properties.
		/// </summary>
		// Token: 0x0600B3C3 RID: 46019 RVA: 0x000FDB50 File Offset: 0x000FBD50
		public void SetZAxesLinesProperty(vtkProperty arg0)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetZAxesLinesProperty_217(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B3C4 RID: 46020
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetZAxisLabelVisibility_218(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of labels for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3C5 RID: 46021 RVA: 0x000FDB7F File Offset: 0x000FBD7F
		public virtual void SetZAxisLabelVisibility(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetZAxisLabelVisibility_218(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B3C6 RID: 46022
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetZAxisMinorTickVisibility_219(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of minor ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3C7 RID: 46023 RVA: 0x000FDB97 File Offset: 0x000FBD97
		public virtual void SetZAxisMinorTickVisibility(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetZAxisMinorTickVisibility_219(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B3C8 RID: 46024
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetZAxisRange_220(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Explicitly specify the range of each axes that's used to define the prop.
		/// The default, (if you do not use these methods) is to use the bounds
		/// specified, or use the bounds of the Input Prop if one is specified. This
		/// method allows you to separate the notion of extent of the axes in physical
		/// space (bounds) and the extent of the values it represents. In other words,
		/// you can have the ticks and labels show a different range.
		/// </summary>
		// Token: 0x0600B3C9 RID: 46025 RVA: 0x000FDBAF File Offset: 0x000FBDAF
		public virtual void SetZAxisRange(double _arg1, double _arg2)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetZAxisRange_220(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600B3CA RID: 46026
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetZAxisRange_221(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Explicitly specify the range of each axes that's used to define the prop.
		/// The default, (if you do not use these methods) is to use the bounds
		/// specified, or use the bounds of the Input Prop if one is specified. This
		/// method allows you to separate the notion of extent of the axes in physical
		/// space (bounds) and the extent of the values it represents. In other words,
		/// you can have the ticks and labels show a different range.
		/// </summary>
		// Token: 0x0600B3CB RID: 46027 RVA: 0x000FDBC0 File Offset: 0x000FBDC0
		public void SetZAxisRange(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetZAxisRange_221(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B3CC RID: 46028
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetZAxisTickVisibility_222(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3CD RID: 46029 RVA: 0x000FDBD0 File Offset: 0x000FBDD0
		public virtual void SetZAxisTickVisibility(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetZAxisTickVisibility_222(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B3CE RID: 46030
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetZAxisVisibility_223(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3CF RID: 46031 RVA: 0x000FDBE8 File Offset: 0x000FBDE8
		public virtual void SetZAxisVisibility(bool _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetZAxisVisibility_223(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B3D0 RID: 46032
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetZLabelFormat_224(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the format with which to print the labels on each of the
		/// x-y-z axes.
		/// </summary>
		// Token: 0x0600B3D1 RID: 46033 RVA: 0x000FDC00 File Offset: 0x000FBE00
		public virtual void SetZLabelFormat(string _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetZLabelFormat_224(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B3D2 RID: 46034
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetZTitle_225(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the labels for the x, y, and z axes. By default,
		/// use "X-Axis", "Y-Axis" and "Z-Axis".
		/// </summary>
		// Token: 0x0600B3D3 RID: 46035 RVA: 0x000FDC10 File Offset: 0x000FBE10
		public virtual void SetZTitle(string _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetZTitle_225(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B3D4 RID: 46036
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_SetZUnits_226(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the labels for the x, y, and z axes. By default,
		/// use "X-Axis", "Y-Axis" and "Z-Axis".
		/// </summary>
		// Token: 0x0600B3D5 RID: 46037 RVA: 0x000FDC20 File Offset: 0x000FBE20
		public virtual void SetZUnits(string _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetZUnits_226(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B3D6 RID: 46038
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_StickyAxesOff_227(HandleRef pThis);

		/// <summary>
		/// Enable/Disable axis stickiness. When on, the axes will be adjusted to always
		/// be visible in the viewport unless the original bounds of the axes are entirely
		/// outside the viewport.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B3D7 RID: 46039 RVA: 0x000FDC30 File Offset: 0x000FBE30
		public virtual void StickyAxesOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_StickyAxesOff_227(base.GetCppThis());
		}

		// Token: 0x0600B3D8 RID: 46040
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_StickyAxesOn_228(HandleRef pThis);

		/// <summary>
		/// Enable/Disable axis stickiness. When on, the axes will be adjusted to always
		/// be visible in the viewport unless the original bounds of the axes are entirely
		/// outside the viewport.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B3D9 RID: 46041 RVA: 0x000FDC3F File Offset: 0x000FBE3F
		public virtual void StickyAxesOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_StickyAxesOn_228(base.GetCppThis());
		}

		// Token: 0x0600B3DA RID: 46042
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_XAxisLabelVisibilityOff_229(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of labels for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3DB RID: 46043 RVA: 0x000FDC4E File Offset: 0x000FBE4E
		public virtual void XAxisLabelVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_XAxisLabelVisibilityOff_229(base.GetCppThis());
		}

		// Token: 0x0600B3DC RID: 46044
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_XAxisLabelVisibilityOn_230(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of labels for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3DD RID: 46045 RVA: 0x000FDC5D File Offset: 0x000FBE5D
		public virtual void XAxisLabelVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_XAxisLabelVisibilityOn_230(base.GetCppThis());
		}

		// Token: 0x0600B3DE RID: 46046
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_XAxisMinorTickVisibilityOff_231(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of minor ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3DF RID: 46047 RVA: 0x000FDC6C File Offset: 0x000FBE6C
		public virtual void XAxisMinorTickVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_XAxisMinorTickVisibilityOff_231(base.GetCppThis());
		}

		// Token: 0x0600B3E0 RID: 46048
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_XAxisMinorTickVisibilityOn_232(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of minor ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3E1 RID: 46049 RVA: 0x000FDC7B File Offset: 0x000FBE7B
		public virtual void XAxisMinorTickVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_XAxisMinorTickVisibilityOn_232(base.GetCppThis());
		}

		// Token: 0x0600B3E2 RID: 46050
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_XAxisTickVisibilityOff_233(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3E3 RID: 46051 RVA: 0x000FDC8A File Offset: 0x000FBE8A
		public virtual void XAxisTickVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_XAxisTickVisibilityOff_233(base.GetCppThis());
		}

		// Token: 0x0600B3E4 RID: 46052
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_XAxisTickVisibilityOn_234(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3E5 RID: 46053 RVA: 0x000FDC99 File Offset: 0x000FBE99
		public virtual void XAxisTickVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_XAxisTickVisibilityOn_234(base.GetCppThis());
		}

		// Token: 0x0600B3E6 RID: 46054
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_XAxisVisibilityOff_235(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3E7 RID: 46055 RVA: 0x000FDCA8 File Offset: 0x000FBEA8
		public virtual void XAxisVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_XAxisVisibilityOff_235(base.GetCppThis());
		}

		// Token: 0x0600B3E8 RID: 46056
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_XAxisVisibilityOn_236(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3E9 RID: 46057 RVA: 0x000FDCB7 File Offset: 0x000FBEB7
		public virtual void XAxisVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_XAxisVisibilityOn_236(base.GetCppThis());
		}

		// Token: 0x0600B3EA RID: 46058
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_YAxisLabelVisibilityOff_237(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of labels for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3EB RID: 46059 RVA: 0x000FDCC6 File Offset: 0x000FBEC6
		public virtual void YAxisLabelVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_YAxisLabelVisibilityOff_237(base.GetCppThis());
		}

		// Token: 0x0600B3EC RID: 46060
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_YAxisLabelVisibilityOn_238(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of labels for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3ED RID: 46061 RVA: 0x000FDCD5 File Offset: 0x000FBED5
		public virtual void YAxisLabelVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_YAxisLabelVisibilityOn_238(base.GetCppThis());
		}

		// Token: 0x0600B3EE RID: 46062
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_YAxisMinorTickVisibilityOff_239(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of minor ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3EF RID: 46063 RVA: 0x000FDCE4 File Offset: 0x000FBEE4
		public virtual void YAxisMinorTickVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_YAxisMinorTickVisibilityOff_239(base.GetCppThis());
		}

		// Token: 0x0600B3F0 RID: 46064
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_YAxisMinorTickVisibilityOn_240(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of minor ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3F1 RID: 46065 RVA: 0x000FDCF3 File Offset: 0x000FBEF3
		public virtual void YAxisMinorTickVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_YAxisMinorTickVisibilityOn_240(base.GetCppThis());
		}

		// Token: 0x0600B3F2 RID: 46066
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_YAxisTickVisibilityOff_241(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3F3 RID: 46067 RVA: 0x000FDD02 File Offset: 0x000FBF02
		public virtual void YAxisTickVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_YAxisTickVisibilityOff_241(base.GetCppThis());
		}

		// Token: 0x0600B3F4 RID: 46068
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_YAxisTickVisibilityOn_242(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3F5 RID: 46069 RVA: 0x000FDD11 File Offset: 0x000FBF11
		public virtual void YAxisTickVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_YAxisTickVisibilityOn_242(base.GetCppThis());
		}

		// Token: 0x0600B3F6 RID: 46070
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_YAxisVisibilityOff_243(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3F7 RID: 46071 RVA: 0x000FDD20 File Offset: 0x000FBF20
		public virtual void YAxisVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_YAxisVisibilityOff_243(base.GetCppThis());
		}

		// Token: 0x0600B3F8 RID: 46072
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_YAxisVisibilityOn_244(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3F9 RID: 46073 RVA: 0x000FDD2F File Offset: 0x000FBF2F
		public virtual void YAxisVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_YAxisVisibilityOn_244(base.GetCppThis());
		}

		// Token: 0x0600B3FA RID: 46074
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_ZAxisLabelVisibilityOff_245(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of labels for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3FB RID: 46075 RVA: 0x000FDD3E File Offset: 0x000FBF3E
		public virtual void ZAxisLabelVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_ZAxisLabelVisibilityOff_245(base.GetCppThis());
		}

		// Token: 0x0600B3FC RID: 46076
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_ZAxisLabelVisibilityOn_246(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of labels for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3FD RID: 46077 RVA: 0x000FDD4D File Offset: 0x000FBF4D
		public virtual void ZAxisLabelVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_ZAxisLabelVisibilityOn_246(base.GetCppThis());
		}

		// Token: 0x0600B3FE RID: 46078
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_ZAxisMinorTickVisibilityOff_247(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of minor ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B3FF RID: 46079 RVA: 0x000FDD5C File Offset: 0x000FBF5C
		public virtual void ZAxisMinorTickVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_ZAxisMinorTickVisibilityOff_247(base.GetCppThis());
		}

		// Token: 0x0600B400 RID: 46080
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_ZAxisMinorTickVisibilityOn_248(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of minor ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B401 RID: 46081 RVA: 0x000FDD6B File Offset: 0x000FBF6B
		public virtual void ZAxisMinorTickVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_ZAxisMinorTickVisibilityOn_248(base.GetCppThis());
		}

		// Token: 0x0600B402 RID: 46082
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_ZAxisTickVisibilityOff_249(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B403 RID: 46083 RVA: 0x000FDD7A File Offset: 0x000FBF7A
		public virtual void ZAxisTickVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_ZAxisTickVisibilityOff_249(base.GetCppThis());
		}

		// Token: 0x0600B404 RID: 46084
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_ZAxisTickVisibilityOn_250(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of ticks for each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B405 RID: 46085 RVA: 0x000FDD89 File Offset: 0x000FBF89
		public virtual void ZAxisTickVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_ZAxisTickVisibilityOn_250(base.GetCppThis());
		}

		// Token: 0x0600B406 RID: 46086
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_ZAxisVisibilityOff_251(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B407 RID: 46087 RVA: 0x000FDD98 File Offset: 0x000FBF98
		public virtual void ZAxisVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_ZAxisVisibilityOff_251(base.GetCppThis());
		}

		// Token: 0x0600B408 RID: 46088
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor_ZAxisVisibilityOn_252(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B409 RID: 46089 RVA: 0x000FDDA7 File Offset: 0x000FBFA7
		public virtual void ZAxisVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_ZAxisVisibilityOn_252(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DD3 RID: 3539
		public new const string MRFullTypeName = "Kitware.VTK.vtkCubeAxesActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DD4 RID: 3540
		public new static readonly string MRClassNameKey = "class vtkCubeAxesActor";

		/// <summary>
		/// Set/Get the camera to perform scaling and translation of the
		/// vtkCubeAxesActor.
		/// </summary>
		// Token: 0x020003C5 RID: 965
		public enum FlyMode
		{
			/// <summary>enum member</summary>
			// Token: 0x04000DD6 RID: 3542
			VTK_FLY_CLOSEST_TRIAD = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000DD7 RID: 3543
			VTK_FLY_FURTHEST_TRIAD,
			/// <summary>enum member</summary>
			// Token: 0x04000DD8 RID: 3544
			VTK_FLY_OUTER_EDGES = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000DD9 RID: 3545
			VTK_FLY_STATIC_EDGES = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000DDA RID: 3546
			VTK_FLY_STATIC_TRIAD = 3
		}

		/// <summary>
		/// Enable/Disable centering of axes when the Sticky option is
		/// on. If on, the axes bounds will be centered in the
		/// viewport. Otherwise, the axes can move about the longer of the
		/// horizontal or vertical directions of the viewport to follow the
		/// data.
		/// Default: true.
		/// </summary>
		// Token: 0x020003C6 RID: 966
		public enum GridVisibility
		{
			/// <summary>enum member</summary>
			// Token: 0x04000DDC RID: 3548
			VTK_GRID_LINES_ALL,
			/// <summary>enum member</summary>
			// Token: 0x04000DDD RID: 3549
			VTK_GRID_LINES_CLOSEST,
			/// <summary>enum member</summary>
			// Token: 0x04000DDE RID: 3550
			VTK_GRID_LINES_FURTHEST
		}

		/// <summary>
		/// Get/Set axes gridPolys actors properties.
		/// </summary>
		// Token: 0x020003C7 RID: 967
		public enum TickLocation
		{
			/// <summary>enum member</summary>
			// Token: 0x04000DE0 RID: 3552
			VTK_TICKS_BOTH = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000DE1 RID: 3553
			VTK_TICKS_INSIDE = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000DE2 RID: 3554
			VTK_TICKS_OUTSIDE
		}
	}
}
