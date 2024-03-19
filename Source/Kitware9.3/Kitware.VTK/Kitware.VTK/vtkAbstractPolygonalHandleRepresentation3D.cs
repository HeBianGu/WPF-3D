using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAbstractPolygonalHandleRepresentation3D
	/// </summary>
	/// <remarks>
	///    represent a user defined handle geometry in 3D while maintaining a fixed orientation
	/// w.r.t the camera.
	///
	/// This class serves as the geometrical representation of a vtkHandleWidget.
	/// The handle can be represented by an arbitrary polygonal data (vtkPolyData),
	/// set via SetHandle(vtkPolyData *). The actual position of the handle
	/// will be initially assumed to be (0,0,0). You can specify an offset from
	/// this position if desired. This class differs from
	/// vtkPolygonalHandleRepresentation3D in that the handle will always remain
	/// front facing, ie it maintains a fixed orientation with respect to the
	/// camera. This is done by using vtkFollowers internally to render the actors.
	/// </remarks>
	/// <seealso>
	///
	/// vtkPolygonalHandleRepresentation3D vtkHandleRepresentation vtkHandleWidget
	/// </seealso>
	// Token: 0x020002AF RID: 687
	public class vtkAbstractPolygonalHandleRepresentation3D : vtkHandleRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007C0C RID: 31756 RVA: 0x000B262C File Offset: 0x000B082C
		static vtkAbstractPolygonalHandleRepresentation3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractPolygonalHandleRepresentation3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractPolygonalHandleRepresentation3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007C0D RID: 31757 RVA: 0x000B2654 File Offset: 0x000B0854
		public vtkAbstractPolygonalHandleRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007C0E RID: 31758 RVA: 0x000B2662 File Offset: 0x000B0862
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007C0F RID: 31759
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x06007C10 RID: 31760 RVA: 0x000B266D File Offset: 0x000B086D
		public override void BuildRepresentation()
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06007C11 RID: 31761
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractPolygonalHandleRepresentation3D_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x06007C12 RID: 31762 RVA: 0x000B267C File Offset: 0x000B087C
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x06007C13 RID: 31763
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_DeepCopy_03(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06007C14 RID: 31764 RVA: 0x000B26A0 File Offset: 0x000B08A0
		public override void DeepCopy(vtkProp prop)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_DeepCopy_03(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x06007C15 RID: 31765
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_GetActors_04(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06007C16 RID: 31766 RVA: 0x000B26D0 File Offset: 0x000B08D0
		public override void GetActors(vtkPropCollection arg0)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetActors_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06007C17 RID: 31767
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetBounds_05(HandleRef pThis);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06007C18 RID: 31768 RVA: 0x000B2700 File Offset: 0x000B0900
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06007C19 RID: 31769
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetHandle_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the handle polydata.
		/// </summary>
		// Token: 0x06007C1A RID: 31770 RVA: 0x000B2748 File Offset: 0x000B0948
		public vtkPolyData GetHandle()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetHandle_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06007C1B RID: 31771
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractPolygonalHandleRepresentation3D_GetHandleVisibility_07(HandleRef pThis);

		/// <summary>
		/// Toggle the visibility of the handle on and off
		/// </summary>
		// Token: 0x06007C1C RID: 31772 RVA: 0x000B27B8 File Offset: 0x000B09B8
		public virtual int GetHandleVisibility()
		{
			return vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetHandleVisibility_07(base.GetCppThis());
		}

		// Token: 0x06007C1D RID: 31773
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetLabelText_08(HandleRef pThis);

		/// <summary>
		/// A label may be associated with the seed. The string can be set via
		/// SetLabelText. The visibility of the label can be turned on / off.
		/// </summary>
		// Token: 0x06007C1E RID: 31774 RVA: 0x000B27D8 File Offset: 0x000B09D8
		public virtual string GetLabelText()
		{
			string s = Marshal.PtrToStringAnsi(vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetLabelText_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007C1F RID: 31775
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetLabelTextActor_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the label text actor
		/// </summary>
		// Token: 0x06007C20 RID: 31776 RVA: 0x000B2814 File Offset: 0x000B0A14
		public virtual vtkFollower GetLabelTextActor()
		{
			vtkFollower vtkFollower = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetLabelTextActor_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFollower = (vtkFollower)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFollower.Register(null);
				}
			}
			return vtkFollower;
		}

		// Token: 0x06007C21 RID: 31777
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetLabelTextScale_10(HandleRef pThis);

		/// <summary>
		/// Scale text (font size along each dimension).
		/// </summary>
		// Token: 0x06007C22 RID: 31778 RVA: 0x000B2884 File Offset: 0x000B0A84
		public virtual IntPtr GetLabelTextScale()
		{
			return vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetLabelTextScale_10(base.GetCppThis());
		}

		// Token: 0x06007C23 RID: 31779
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractPolygonalHandleRepresentation3D_GetLabelVisibility_11(HandleRef pThis);

		/// <summary>
		/// A label may be associated with the seed. The string can be set via
		/// SetLabelText. The visibility of the label can be turned on / off.
		/// </summary>
		// Token: 0x06007C24 RID: 31780 RVA: 0x000B28A4 File Offset: 0x000B0AA4
		public virtual int GetLabelVisibility()
		{
			return vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetLabelVisibility_11(base.GetCppThis());
		}

		// Token: 0x06007C25 RID: 31781
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007C26 RID: 31782 RVA: 0x000B28C4 File Offset: 0x000B0AC4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x06007C27 RID: 31783
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007C28 RID: 31784 RVA: 0x000B28E4 File Offset: 0x000B0AE4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x06007C29 RID: 31785
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetProperty_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle properties when unselected and selected.
		/// </summary>
		// Token: 0x06007C2A RID: 31786 RVA: 0x000B2900 File Offset: 0x000B0B00
		public virtual vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetProperty_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06007C2B RID: 31787
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetSelectedProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle properties when unselected and selected.
		/// </summary>
		// Token: 0x06007C2C RID: 31788 RVA: 0x000B2970 File Offset: 0x000B0B70
		public virtual vtkProperty GetSelectedProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetSelectedProperty_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06007C2D RID: 31789
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractPolygonalHandleRepresentation3D_GetSmoothMotion_16(HandleRef pThis);

		/// <summary>
		/// Turn on/off smooth motion of the handle. See the documentation of
		/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
		/// in certain applications the user may want to turn it off. For instance
		/// when using certain specific PointPlacer's with the representation such
		/// as the vtkCellCentersPointPlacer, which causes the representation to
		/// snap to the center of cells, or using a vtkPolygonalSurfacePointPlacer
		/// which constrains the widget to the surface of a mesh. In such cases,
		/// inherent restrictions on handle placement might conflict with a request
		/// for smooth motion of the handles.
		/// </summary>
		// Token: 0x06007C2E RID: 31790 RVA: 0x000B29E0 File Offset: 0x000B0BE0
		public virtual int GetSmoothMotion()
		{
			return vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetSmoothMotion_16(base.GetCppThis());
		}

		// Token: 0x06007C2F RID: 31791
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetTransform_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the transform used to transform the generic handle polydata before
		/// placing it in the render window
		/// </summary>
		// Token: 0x06007C30 RID: 31792 RVA: 0x000B2A00 File Offset: 0x000B0C00
		public virtual vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetTransform_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		// Token: 0x06007C31 RID: 31793
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_HandleVisibilityOff_18(HandleRef pThis);

		/// <summary>
		/// Toggle the visibility of the handle on and off
		/// </summary>
		// Token: 0x06007C32 RID: 31794 RVA: 0x000B2A6F File Offset: 0x000B0C6F
		public virtual void HandleVisibilityOff()
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_HandleVisibilityOff_18(base.GetCppThis());
		}

		// Token: 0x06007C33 RID: 31795
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_HandleVisibilityOn_19(HandleRef pThis);

		/// <summary>
		/// Toggle the visibility of the handle on and off
		/// </summary>
		// Token: 0x06007C34 RID: 31796 RVA: 0x000B2A7E File Offset: 0x000B0C7E
		public virtual void HandleVisibilityOn()
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_HandleVisibilityOn_19(base.GetCppThis());
		}

		// Token: 0x06007C35 RID: 31797
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractPolygonalHandleRepresentation3D_HasTranslucentPolygonalGeometry_20(HandleRef pThis);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06007C36 RID: 31798 RVA: 0x000B2A90 File Offset: 0x000B0C90
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_HasTranslucentPolygonalGeometry_20(base.GetCppThis());
		}

		// Token: 0x06007C37 RID: 31799
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_Highlight_21(HandleRef pThis, int highlight);

		/// <summary>
		/// Toggle the visibility of the handle on and off
		/// </summary>
		// Token: 0x06007C38 RID: 31800 RVA: 0x000B2AAF File Offset: 0x000B0CAF
		public override void Highlight(int highlight)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_Highlight_21(base.GetCppThis(), highlight);
		}

		// Token: 0x06007C39 RID: 31801
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractPolygonalHandleRepresentation3D_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007C3A RID: 31802 RVA: 0x000B2AC0 File Offset: 0x000B0CC0
		public override int IsA(string type)
		{
			return vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x06007C3B RID: 31803
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractPolygonalHandleRepresentation3D_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007C3C RID: 31804 RVA: 0x000B2AE0 File Offset: 0x000B0CE0
		public new static int IsTypeOf(string type)
		{
			return vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_IsTypeOf_23(type);
		}

		// Token: 0x06007C3D RID: 31805
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_LabelVisibilityOff_24(HandleRef pThis);

		/// <summary>
		/// A label may be associated with the seed. The string can be set via
		/// SetLabelText. The visibility of the label can be turned on / off.
		/// </summary>
		// Token: 0x06007C3E RID: 31806 RVA: 0x000B2AFA File Offset: 0x000B0CFA
		public virtual void LabelVisibilityOff()
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_LabelVisibilityOff_24(base.GetCppThis());
		}

		// Token: 0x06007C3F RID: 31807
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_LabelVisibilityOn_25(HandleRef pThis);

		/// <summary>
		/// A label may be associated with the seed. The string can be set via
		/// SetLabelText. The visibility of the label can be turned on / off.
		/// </summary>
		// Token: 0x06007C40 RID: 31808 RVA: 0x000B2B09 File Offset: 0x000B0D09
		public virtual void LabelVisibilityOn()
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_LabelVisibilityOn_25(base.GetCppThis());
		}

		// Token: 0x06007C41 RID: 31809
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007C42 RID: 31810 RVA: 0x000B2B18 File Offset: 0x000B0D18
		public new vtkAbstractPolygonalHandleRepresentation3D NewInstance()
		{
			vtkAbstractPolygonalHandleRepresentation3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007C43 RID: 31811
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_RegisterPickers_27(HandleRef pThis);

		/// <summary>
		/// Turn on/off smooth motion of the handle. See the documentation of
		/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
		/// in certain applications the user may want to turn it off. For instance
		/// when using certain specific PointPlacer's with the representation such
		/// as the vtkCellCentersPointPlacer, which causes the representation to
		/// snap to the center of cells, or using a vtkPolygonalSurfacePointPlacer
		/// which constrains the widget to the surface of a mesh. In such cases,
		/// inherent restrictions on handle placement might conflict with a request
		/// for smooth motion of the handles.
		/// </summary>
		// Token: 0x06007C44 RID: 31812 RVA: 0x000B2B72 File Offset: 0x000B0D72
		public override void RegisterPickers()
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_RegisterPickers_27(base.GetCppThis());
		}

		// Token: 0x06007C45 RID: 31813
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_ReleaseGraphicsResources_28(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06007C46 RID: 31814 RVA: 0x000B2B84 File Offset: 0x000B0D84
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_ReleaseGraphicsResources_28(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06007C47 RID: 31815
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractPolygonalHandleRepresentation3D_RenderOpaqueGeometry_29(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06007C48 RID: 31816 RVA: 0x000B2BB4 File Offset: 0x000B0DB4
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_RenderOpaqueGeometry_29(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06007C49 RID: 31817
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractPolygonalHandleRepresentation3D_RenderTranslucentPolygonalGeometry_30(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06007C4A RID: 31818 RVA: 0x000B2BE8 File Offset: 0x000B0DE8
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_RenderTranslucentPolygonalGeometry_30(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06007C4B RID: 31819
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007C4C RID: 31820 RVA: 0x000B2C1C File Offset: 0x000B0E1C
		public new static vtkAbstractPolygonalHandleRepresentation3D SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractPolygonalHandleRepresentation3D vtkAbstractPolygonalHandleRepresentation3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPolygonalHandleRepresentation3D = (vtkAbstractPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPolygonalHandleRepresentation3D.Register(null);
				}
			}
			return vtkAbstractPolygonalHandleRepresentation3D;
		}

		// Token: 0x06007C4D RID: 31821
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetDisplayPosition_32(HandleRef pThis, IntPtr p);

		/// <summary>
		/// Set the position of the point in world and display coordinates.
		/// </summary>
		// Token: 0x06007C4E RID: 31822 RVA: 0x000B2C9B File Offset: 0x000B0E9B
		public override void SetDisplayPosition(IntPtr p)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetDisplayPosition_32(base.GetCppThis(), p);
		}

		// Token: 0x06007C4F RID: 31823
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetHandle_33(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/get the handle polydata.
		/// </summary>
		// Token: 0x06007C50 RID: 31824 RVA: 0x000B2CAC File Offset: 0x000B0EAC
		public void SetHandle(vtkPolyData arg0)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetHandle_33(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06007C51 RID: 31825
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetHandleVisibility_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Toggle the visibility of the handle on and off
		/// </summary>
		// Token: 0x06007C52 RID: 31826 RVA: 0x000B2CDB File Offset: 0x000B0EDB
		public virtual void SetHandleVisibility(int _arg)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetHandleVisibility_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06007C53 RID: 31827
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetLabelText_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string label);

		/// <summary>
		/// A label may be associated with the seed. The string can be set via
		/// SetLabelText. The visibility of the label can be turned on / off.
		/// </summary>
		// Token: 0x06007C54 RID: 31828 RVA: 0x000B2CEB File Offset: 0x000B0EEB
		public virtual void SetLabelText(string label)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetLabelText_35(base.GetCppThis(), label);
		}

		// Token: 0x06007C55 RID: 31829
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetLabelTextScale_36(HandleRef pThis, IntPtr scale);

		/// <summary>
		/// Scale text (font size along each dimension).
		/// </summary>
		// Token: 0x06007C56 RID: 31830 RVA: 0x000B2CFB File Offset: 0x000B0EFB
		public virtual void SetLabelTextScale(IntPtr scale)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetLabelTextScale_36(base.GetCppThis(), scale);
		}

		// Token: 0x06007C57 RID: 31831
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetLabelTextScale_37(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Scale text (font size along each dimension).
		/// </summary>
		// Token: 0x06007C58 RID: 31832 RVA: 0x000B2D0B File Offset: 0x000B0F0B
		public void SetLabelTextScale(double x, double y, double z)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetLabelTextScale_37(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06007C59 RID: 31833
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetLabelVisibility_38(HandleRef pThis, int _arg);

		/// <summary>
		/// A label may be associated with the seed. The string can be set via
		/// SetLabelText. The visibility of the label can be turned on / off.
		/// </summary>
		// Token: 0x06007C5A RID: 31834 RVA: 0x000B2D1D File Offset: 0x000B0F1D
		public virtual void SetLabelVisibility(int _arg)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetLabelVisibility_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06007C5B RID: 31835
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetProperty_39(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the handle properties when unselected and selected.
		/// </summary>
		// Token: 0x06007C5C RID: 31836 RVA: 0x000B2D30 File Offset: 0x000B0F30
		public void SetProperty(vtkProperty arg0)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetProperty_39(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06007C5D RID: 31837
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetSelectedProperty_40(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the handle properties when unselected and selected.
		/// </summary>
		// Token: 0x06007C5E RID: 31838 RVA: 0x000B2D60 File Offset: 0x000B0F60
		public void SetSelectedProperty(vtkProperty arg0)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetSelectedProperty_40(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06007C5F RID: 31839
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetSmoothMotion_41(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off smooth motion of the handle. See the documentation of
		/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
		/// in certain applications the user may want to turn it off. For instance
		/// when using certain specific PointPlacer's with the representation such
		/// as the vtkCellCentersPointPlacer, which causes the representation to
		/// snap to the center of cells, or using a vtkPolygonalSurfacePointPlacer
		/// which constrains the widget to the surface of a mesh. In such cases,
		/// inherent restrictions on handle placement might conflict with a request
		/// for smooth motion of the handles.
		/// </summary>
		// Token: 0x06007C60 RID: 31840 RVA: 0x000B2D8F File Offset: 0x000B0F8F
		public virtual void SetSmoothMotion(int _arg)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetSmoothMotion_41(base.GetCppThis(), _arg);
		}

		// Token: 0x06007C61 RID: 31841
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetUniformScale_42(HandleRef pThis, double scale);

		/// <summary>
		/// The handle may be scaled uniformly in all three dimensions using this
		/// API. The handle can also be scaled interactively using the right
		/// mouse button.
		/// </summary>
		// Token: 0x06007C62 RID: 31842 RVA: 0x000B2D9F File Offset: 0x000B0F9F
		public virtual void SetUniformScale(double scale)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetUniformScale_42(base.GetCppThis(), scale);
		}

		// Token: 0x06007C63 RID: 31843
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetWorldPosition_43(HandleRef pThis, IntPtr p);

		/// <summary>
		/// Set the position of the point in world and display coordinates.
		/// </summary>
		// Token: 0x06007C64 RID: 31844 RVA: 0x000B2DAF File Offset: 0x000B0FAF
		public override void SetWorldPosition(IntPtr p)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetWorldPosition_43(base.GetCppThis(), p);
		}

		// Token: 0x06007C65 RID: 31845
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_ShallowCopy_44(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06007C66 RID: 31846 RVA: 0x000B2DC0 File Offset: 0x000B0FC0
		public override void ShallowCopy(vtkProp prop)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_ShallowCopy_44(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x06007C67 RID: 31847
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SmoothMotionOff_45(HandleRef pThis);

		/// <summary>
		/// Turn on/off smooth motion of the handle. See the documentation of
		/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
		/// in certain applications the user may want to turn it off. For instance
		/// when using certain specific PointPlacer's with the representation such
		/// as the vtkCellCentersPointPlacer, which causes the representation to
		/// snap to the center of cells, or using a vtkPolygonalSurfacePointPlacer
		/// which constrains the widget to the surface of a mesh. In such cases,
		/// inherent restrictions on handle placement might conflict with a request
		/// for smooth motion of the handles.
		/// </summary>
		// Token: 0x06007C68 RID: 31848 RVA: 0x000B2DEF File Offset: 0x000B0FEF
		public virtual void SmoothMotionOff()
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SmoothMotionOff_45(base.GetCppThis());
		}

		// Token: 0x06007C69 RID: 31849
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SmoothMotionOn_46(HandleRef pThis);

		/// <summary>
		/// Turn on/off smooth motion of the handle. See the documentation of
		/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
		/// in certain applications the user may want to turn it off. For instance
		/// when using certain specific PointPlacer's with the representation such
		/// as the vtkCellCentersPointPlacer, which causes the representation to
		/// snap to the center of cells, or using a vtkPolygonalSurfacePointPlacer
		/// which constrains the widget to the surface of a mesh. In such cases,
		/// inherent restrictions on handle placement might conflict with a request
		/// for smooth motion of the handles.
		/// </summary>
		// Token: 0x06007C6A RID: 31850 RVA: 0x000B2DFE File Offset: 0x000B0FFE
		public virtual void SmoothMotionOn()
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SmoothMotionOn_46(base.GetCppThis());
		}

		// Token: 0x06007C6B RID: 31851
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_StartWidgetInteraction_47(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x06007C6C RID: 31852 RVA: 0x000B2E0D File Offset: 0x000B100D
		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_StartWidgetInteraction_47(base.GetCppThis(), eventPos);
		}

		// Token: 0x06007C6D RID: 31853
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_WidgetInteraction_48(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x06007C6E RID: 31854 RVA: 0x000B2E1D File Offset: 0x000B101D
		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_WidgetInteraction_48(base.GetCppThis(), eventPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A74 RID: 2676
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractPolygonalHandleRepresentation3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A75 RID: 2677
		public new static readonly string MRClassNameKey = "class vtkAbstractPolygonalHandleRepresentation3D";
	}
}
