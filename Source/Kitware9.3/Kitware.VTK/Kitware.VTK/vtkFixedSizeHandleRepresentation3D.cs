using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFixedSizeHandleRepresentation
	/// </summary>
	/// <remarks>
	///    A marker that has the same size in pixels.
	///
	///
	/// This class is a concrete implementation of vtkHandleRepresentation. It is
	/// meant to be used as a representation for vtkHandleWidget. Unlike the other
	/// representations, this can maintain a constant size in pixels, regardless of
	/// the camera zoom parameters. The size in pixels may be set via
	/// SetHandleSizeInPixels. This representation renders the markers as spherical
	/// blobs in 3D space with the width as specified above, defaults to 10 pixels.
	/// The handles will have the same size in pixels, give or take a certain
	/// tolerance, as specified by SetHandleSizeToleranceInPixels. The tolerance
	/// defaults to half a pixel. PointPlacers may be used to specify constraints on
	/// the placement of markers. For instance a vtkPolygonalSurfacePointPlacer
	/// will constrain placement of these spherical handles to a surface mesh.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkHandleRepresentation vtkHandleWidget
	/// </seealso>
	// Token: 0x0200031B RID: 795
	public class vtkFixedSizeHandleRepresentation3D : vtkPolygonalHandleRepresentation3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008EA3 RID: 36515 RVA: 0x000CB4F9 File Offset: 0x000C96F9
		static vtkFixedSizeHandleRepresentation3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFixedSizeHandleRepresentation3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedSizeHandleRepresentation3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008EA4 RID: 36516 RVA: 0x000CB521 File Offset: 0x000C9721
		public vtkFixedSizeHandleRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008EA5 RID: 36517
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedSizeHandleRepresentation3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06008EA6 RID: 36518 RVA: 0x000CB530 File Offset: 0x000C9730
		public new static vtkFixedSizeHandleRepresentation3D New()
		{
			vtkFixedSizeHandleRepresentation3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedSizeHandleRepresentation3D.vtkFixedSizeHandleRepresentation3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedSizeHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06008EA7 RID: 36519 RVA: 0x000CB584 File Offset: 0x000C9784
		public vtkFixedSizeHandleRepresentation3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFixedSizeHandleRepresentation3D.vtkFixedSizeHandleRepresentation3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008EA8 RID: 36520 RVA: 0x000CB5C8 File Offset: 0x000C97C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008EA9 RID: 36521
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFixedSizeHandleRepresentation3D_GetHandleSizeInPixels_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the required handle size in pixels. Defaults to a width of
		/// 10 pixels.
		/// </summary>
		// Token: 0x06008EAA RID: 36522 RVA: 0x000CB5D4 File Offset: 0x000C97D4
		public virtual double GetHandleSizeInPixels()
		{
			return vtkFixedSizeHandleRepresentation3D.vtkFixedSizeHandleRepresentation3D_GetHandleSizeInPixels_01(base.GetCppThis());
		}

		// Token: 0x06008EAB RID: 36523
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFixedSizeHandleRepresentation3D_GetHandleSizeToleranceInPixels_02(HandleRef pThis);

		/// <summary>
		/// Specify the acceptable handle size tolerance. During each render, the
		/// handle 3D source will be updated to automatically match a display size
		/// as specified by HandleSizeInPixels. This update will be done if the
		/// handle size is larger than a tolerance. Default value of this
		/// tolerance is half a pixel.
		/// </summary>
		// Token: 0x06008EAC RID: 36524 RVA: 0x000CB5F4 File Offset: 0x000C97F4
		public virtual double GetHandleSizeToleranceInPixels()
		{
			return vtkFixedSizeHandleRepresentation3D.vtkFixedSizeHandleRepresentation3D_GetHandleSizeToleranceInPixels_02(base.GetCppThis());
		}

		// Token: 0x06008EAD RID: 36525
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFixedSizeHandleRepresentation3D_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtk methods
		/// </summary>
		// Token: 0x06008EAE RID: 36526 RVA: 0x000CB614 File Offset: 0x000C9814
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFixedSizeHandleRepresentation3D.vtkFixedSizeHandleRepresentation3D_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06008EAF RID: 36527
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFixedSizeHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtk methods
		/// </summary>
		// Token: 0x06008EB0 RID: 36528 RVA: 0x000CB634 File Offset: 0x000C9834
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFixedSizeHandleRepresentation3D.vtkFixedSizeHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06008EB1 RID: 36529
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedSizeHandleRepresentation3D_GetSphereSource_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the object used to render the spherical handle marker
		/// </summary>
		// Token: 0x06008EB2 RID: 36530 RVA: 0x000CB650 File Offset: 0x000C9850
		public virtual vtkSphereSource GetSphereSource()
		{
			vtkSphereSource vtkSphereSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedSizeHandleRepresentation3D.vtkFixedSizeHandleRepresentation3D_GetSphereSource_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSphereSource = (vtkSphereSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSphereSource.Register(null);
				}
			}
			return vtkSphereSource;
		}

		// Token: 0x06008EB3 RID: 36531
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedSizeHandleRepresentation3D_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtk methods
		/// </summary>
		// Token: 0x06008EB4 RID: 36532 RVA: 0x000CB6C0 File Offset: 0x000C98C0
		public override int IsA(string type)
		{
			return vtkFixedSizeHandleRepresentation3D.vtkFixedSizeHandleRepresentation3D_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06008EB5 RID: 36533
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedSizeHandleRepresentation3D_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtk methods
		/// </summary>
		// Token: 0x06008EB6 RID: 36534 RVA: 0x000CB6E0 File Offset: 0x000C98E0
		public new static int IsTypeOf(string type)
		{
			return vtkFixedSizeHandleRepresentation3D.vtkFixedSizeHandleRepresentation3D_IsTypeOf_07(type);
		}

		// Token: 0x06008EB7 RID: 36535
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedSizeHandleRepresentation3D_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtk methods
		/// </summary>
		// Token: 0x06008EB8 RID: 36536 RVA: 0x000CB6FC File Offset: 0x000C98FC
		public new vtkFixedSizeHandleRepresentation3D NewInstance()
		{
			vtkFixedSizeHandleRepresentation3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedSizeHandleRepresentation3D.vtkFixedSizeHandleRepresentation3D_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedSizeHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008EB9 RID: 36537
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedSizeHandleRepresentation3D_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtk methods
		/// </summary>
		// Token: 0x06008EBA RID: 36538 RVA: 0x000CB758 File Offset: 0x000C9958
		public new static vtkFixedSizeHandleRepresentation3D SafeDownCast(vtkObjectBase o)
		{
			vtkFixedSizeHandleRepresentation3D vtkFixedSizeHandleRepresentation3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedSizeHandleRepresentation3D.vtkFixedSizeHandleRepresentation3D_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedSizeHandleRepresentation3D = (vtkFixedSizeHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedSizeHandleRepresentation3D.Register(null);
				}
			}
			return vtkFixedSizeHandleRepresentation3D;
		}

		// Token: 0x06008EBB RID: 36539
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedSizeHandleRepresentation3D_SetHandleSizeInPixels_11(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the required handle size in pixels. Defaults to a width of
		/// 10 pixels.
		/// </summary>
		// Token: 0x06008EBC RID: 36540 RVA: 0x000CB7D7 File Offset: 0x000C99D7
		public virtual void SetHandleSizeInPixels(double _arg)
		{
			vtkFixedSizeHandleRepresentation3D.vtkFixedSizeHandleRepresentation3D_SetHandleSizeInPixels_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06008EBD RID: 36541
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedSizeHandleRepresentation3D_SetHandleSizeToleranceInPixels_12(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the acceptable handle size tolerance. During each render, the
		/// handle 3D source will be updated to automatically match a display size
		/// as specified by HandleSizeInPixels. This update will be done if the
		/// handle size is larger than a tolerance. Default value of this
		/// tolerance is half a pixel.
		/// </summary>
		// Token: 0x06008EBE RID: 36542 RVA: 0x000CB7E7 File Offset: 0x000C99E7
		public virtual void SetHandleSizeToleranceInPixels(double _arg)
		{
			vtkFixedSizeHandleRepresentation3D.vtkFixedSizeHandleRepresentation3D_SetHandleSizeToleranceInPixels_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BF0 RID: 3056
		public new const string MRFullTypeName = "Kitware.VTK.vtkFixedSizeHandleRepresentation3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BF1 RID: 3057
		public new static readonly string MRClassNameKey = "class vtkFixedSizeHandleRepresentation3D";
	}
}
