using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDijkstraImageContourLineInterpolator
	/// </summary>
	/// <remarks>
	///    Contour interpolator for placing points on an image.
	///
	///
	/// vtkDijkstraImageContourLineInterpolator interpolates and places
	/// contour points on images. The class interpolates nodes by
	/// computing a graph laying on the image data. By graph, we mean
	/// that the line interpolating the two end points traverses along
	/// pixels so as to form a shortest path. A Dijkstra algorithm is
	/// used to compute the path.
	///
	/// The class is meant to be used in conjunction with
	/// vtkImageActorPointPlacer. One reason for this coupling is a
	/// performance issue: both classes need to perform a cell pick, and
	/// coupling avoids multiple cell picks (cell picks are slow).  Another
	/// issue is that the interpolator may need to set the image input to
	/// its vtkDijkstraImageGeodesicPath ivar.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkContourWidget vtkContourLineInterpolator vtkDijkstraImageGeodesicPath
	/// </seealso>
	// Token: 0x02000308 RID: 776
	public class vtkDijkstraImageContourLineInterpolator : vtkContourLineInterpolator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008AFD RID: 35581 RVA: 0x000C6733 File Offset: 0x000C4933
		static vtkDijkstraImageContourLineInterpolator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDijkstraImageContourLineInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDijkstraImageContourLineInterpolator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008AFE RID: 35582 RVA: 0x000C675B File Offset: 0x000C495B
		public vtkDijkstraImageContourLineInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008AFF RID: 35583
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDijkstraImageContourLineInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008B00 RID: 35584 RVA: 0x000C676C File Offset: 0x000C496C
		public new static vtkDijkstraImageContourLineInterpolator New()
		{
			vtkDijkstraImageContourLineInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDijkstraImageContourLineInterpolator.vtkDijkstraImageContourLineInterpolator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDijkstraImageContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008B01 RID: 35585 RVA: 0x000C67C0 File Offset: 0x000C49C0
		public vtkDijkstraImageContourLineInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDijkstraImageContourLineInterpolator.vtkDijkstraImageContourLineInterpolator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008B02 RID: 35586 RVA: 0x000C6804 File Offset: 0x000C4A04
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008B03 RID: 35587
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDijkstraImageContourLineInterpolator_GetCostImage_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the image data for the vtkDijkstraImageGeodesicPath.
		/// If not set, the interpolator uses the image data input to the image actor.
		/// The image actor is obtained from the expected vtkImageActorPointPlacer.
		/// </summary>
		// Token: 0x06008B04 RID: 35588 RVA: 0x000C6810 File Offset: 0x000C4A10
		public virtual vtkImageData GetCostImage()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDijkstraImageContourLineInterpolator.vtkDijkstraImageContourLineInterpolator_GetCostImage_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x06008B05 RID: 35589
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDijkstraImageContourLineInterpolator_GetDijkstraImageGeodesicPath_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// access to the internal dijkstra path
		/// </summary>
		// Token: 0x06008B06 RID: 35590 RVA: 0x000C6880 File Offset: 0x000C4A80
		public virtual vtkDijkstraImageGeodesicPath GetDijkstraImageGeodesicPath()
		{
			vtkDijkstraImageGeodesicPath vtkDijkstraImageGeodesicPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDijkstraImageContourLineInterpolator.vtkDijkstraImageContourLineInterpolator_GetDijkstraImageGeodesicPath_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDijkstraImageGeodesicPath = (vtkDijkstraImageGeodesicPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDijkstraImageGeodesicPath.Register(null);
				}
			}
			return vtkDijkstraImageGeodesicPath;
		}

		// Token: 0x06008B07 RID: 35591
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDijkstraImageContourLineInterpolator_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008B08 RID: 35592 RVA: 0x000C68F0 File Offset: 0x000C4AF0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDijkstraImageContourLineInterpolator.vtkDijkstraImageContourLineInterpolator_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06008B09 RID: 35593
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDijkstraImageContourLineInterpolator_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008B0A RID: 35594 RVA: 0x000C6910 File Offset: 0x000C4B10
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDijkstraImageContourLineInterpolator.vtkDijkstraImageContourLineInterpolator_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06008B0B RID: 35595
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDijkstraImageContourLineInterpolator_InterpolateLine_05(HandleRef pThis, HandleRef ren, HandleRef rep, int idx1, int idx2);

		/// <summary>
		/// Subclasses that wish to interpolate a line segment must implement this.
		/// For instance vtkBezierContourLineInterpolator adds nodes between idx1
		/// and idx2, that allow the contour to adhere to a bezier curve.
		/// </summary>
		// Token: 0x06008B0C RID: 35596 RVA: 0x000C692C File Offset: 0x000C4B2C
		public override int InterpolateLine(vtkRenderer ren, vtkContourRepresentation rep, int idx1, int idx2)
		{
			return vtkDijkstraImageContourLineInterpolator.vtkDijkstraImageContourLineInterpolator_InterpolateLine_05(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis(), idx1, idx2);
		}

		// Token: 0x06008B0D RID: 35597
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDijkstraImageContourLineInterpolator_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008B0E RID: 35598 RVA: 0x000C6978 File Offset: 0x000C4B78
		public override int IsA(string type)
		{
			return vtkDijkstraImageContourLineInterpolator.vtkDijkstraImageContourLineInterpolator_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06008B0F RID: 35599
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDijkstraImageContourLineInterpolator_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008B10 RID: 35600 RVA: 0x000C6998 File Offset: 0x000C4B98
		public new static int IsTypeOf(string type)
		{
			return vtkDijkstraImageContourLineInterpolator.vtkDijkstraImageContourLineInterpolator_IsTypeOf_07(type);
		}

		// Token: 0x06008B11 RID: 35601
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDijkstraImageContourLineInterpolator_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008B12 RID: 35602 RVA: 0x000C69B4 File Offset: 0x000C4BB4
		public new vtkDijkstraImageContourLineInterpolator NewInstance()
		{
			vtkDijkstraImageContourLineInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDijkstraImageContourLineInterpolator.vtkDijkstraImageContourLineInterpolator_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDijkstraImageContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008B13 RID: 35603
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDijkstraImageContourLineInterpolator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008B14 RID: 35604 RVA: 0x000C6A10 File Offset: 0x000C4C10
		public new static vtkDijkstraImageContourLineInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkDijkstraImageContourLineInterpolator vtkDijkstraImageContourLineInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDijkstraImageContourLineInterpolator.vtkDijkstraImageContourLineInterpolator_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDijkstraImageContourLineInterpolator = (vtkDijkstraImageContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDijkstraImageContourLineInterpolator.Register(null);
				}
			}
			return vtkDijkstraImageContourLineInterpolator;
		}

		// Token: 0x06008B15 RID: 35605
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDijkstraImageContourLineInterpolator_SetCostImage_11(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the image data for the vtkDijkstraImageGeodesicPath.
		/// If not set, the interpolator uses the image data input to the image actor.
		/// The image actor is obtained from the expected vtkImageActorPointPlacer.
		/// </summary>
		// Token: 0x06008B16 RID: 35606 RVA: 0x000C6A90 File Offset: 0x000C4C90
		public virtual void SetCostImage(vtkImageData arg0)
		{
			vtkDijkstraImageContourLineInterpolator.vtkDijkstraImageContourLineInterpolator_SetCostImage_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BB5 RID: 2997
		public new const string MRFullTypeName = "Kitware.VTK.vtkDijkstraImageContourLineInterpolator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BB6 RID: 2998
		public new static readonly string MRClassNameKey = "class vtkDijkstraImageContourLineInterpolator";
	}
}
