using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCurveRepresentation
	/// </summary>
	/// <remarks>
	///    base class for a widget that represents a curve that connects control
	/// points.
	///
	/// Base class for widgets used to define curves from points, such as
	/// vtkPolyLineRepresentation and vtkSplineRepresentation.  This class
	/// uses handles, the number of which can be changed, to represent the
	/// points that define the curve. The handles can be picked can be
	/// picked on the curve itself to translate or rotate it in the scene.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPolyLineRepresentation vtkSplineRepresentation
	/// </seealso>
	// Token: 0x020002B0 RID: 688
	public abstract class vtkCurveRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007C6F RID: 31855 RVA: 0x000B2E2D File Offset: 0x000B102D
		static vtkCurveRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCurveRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCurveRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007C70 RID: 31856 RVA: 0x000B2E55 File Offset: 0x000B1055
		public vtkCurveRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007C71 RID: 31857 RVA: 0x000B2E63 File Offset: 0x000B1063
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007C72 RID: 31858
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation
		/// API. Note that a version of place widget is available where the
		/// center and handle position are specified.
		/// </summary>
		// Token: 0x06007C73 RID: 31859 RVA: 0x000B2E6E File Offset: 0x000B106E
		public override void BuildRepresentation()
		{
			vtkCurveRepresentation.vtkCurveRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06007C74 RID: 31860
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_ClosedOff_02(HandleRef pThis);

		/// <summary>
		/// Control whether the curve is open or closed. A closed forms a
		/// continuous loop: the first and last points are the same.  A
		/// minimum of 3 handles are required to form a closed loop.
		/// </summary>
		// Token: 0x06007C75 RID: 31861 RVA: 0x000B2E7D File Offset: 0x000B107D
		public virtual void ClosedOff()
		{
			vtkCurveRepresentation.vtkCurveRepresentation_ClosedOff_02(base.GetCppThis());
		}

		// Token: 0x06007C76 RID: 31862
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_ClosedOn_03(HandleRef pThis);

		/// <summary>
		/// Control whether the curve is open or closed. A closed forms a
		/// continuous loop: the first and last points are the same.  A
		/// minimum of 3 handles are required to form a closed loop.
		/// </summary>
		// Token: 0x06007C77 RID: 31863 RVA: 0x000B2E8C File Offset: 0x000B108C
		public virtual void ClosedOn()
		{
			vtkCurveRepresentation.vtkCurveRepresentation_ClosedOn_03(base.GetCppThis());
		}

		// Token: 0x06007C78 RID: 31864
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCurveRepresentation_ComputeInteractionState_04(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation
		/// API. Note that a version of place widget is available where the
		/// center and handle position are specified.
		/// </summary>
		// Token: 0x06007C79 RID: 31865 RVA: 0x000B2E9C File Offset: 0x000B109C
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_ComputeInteractionState_04(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x06007C7A RID: 31866
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_DirectionalOff_05(HandleRef pThis);

		/// <summary>
		/// Set the representation to be directional or not.
		/// The meaning of being directional depends on the representation and
		/// its handles implementations in the subclasses.
		/// </summary>
		// Token: 0x06007C7B RID: 31867 RVA: 0x000B2EBE File Offset: 0x000B10BE
		public virtual void DirectionalOff()
		{
			vtkCurveRepresentation.vtkCurveRepresentation_DirectionalOff_05(base.GetCppThis());
		}

		// Token: 0x06007C7C RID: 31868
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_DirectionalOn_06(HandleRef pThis);

		/// <summary>
		/// Set the representation to be directional or not.
		/// The meaning of being directional depends on the representation and
		/// its handles implementations in the subclasses.
		/// </summary>
		// Token: 0x06007C7D RID: 31869 RVA: 0x000B2ECD File Offset: 0x000B10CD
		public virtual void DirectionalOn()
		{
			vtkCurveRepresentation.vtkCurveRepresentation_DirectionalOn_06(base.GetCppThis());
		}

		// Token: 0x06007C7E RID: 31870
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_EndWidgetInteraction_07(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation
		/// API. Note that a version of place widget is available where the
		/// center and handle position are specified.
		/// </summary>
		// Token: 0x06007C7F RID: 31871 RVA: 0x000B2EDC File Offset: 0x000B10DC
		public override void EndWidgetInteraction(IntPtr e)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_EndWidgetInteraction_07(base.GetCppThis(), e);
		}

		// Token: 0x06007C80 RID: 31872
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_GetActors_08(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp. They are repeated here (from the
		/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
		/// these methods properly may result in the representation not appearing in the scene
		/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
		/// (i.e., not implementing ReleaseGraphicsResources() properly).
		/// </summary>
		// Token: 0x06007C81 RID: 31873 RVA: 0x000B2EEC File Offset: 0x000B10EC
		public override void GetActors(vtkPropCollection arg0)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_GetActors_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06007C82 RID: 31874
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCurveRepresentation_GetBounds_09(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation
		/// API. Note that a version of place widget is available where the
		/// center and handle position are specified.
		/// </summary>
		// Token: 0x06007C83 RID: 31875 RVA: 0x000B2F1C File Offset: 0x000B111C
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkCurveRepresentation.vtkCurveRepresentation_GetBounds_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06007C84 RID: 31876
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCurveRepresentation_GetClosed_10(HandleRef pThis);

		/// <summary>
		/// Control whether the curve is open or closed. A closed forms a
		/// continuous loop: the first and last points are the same.  A
		/// minimum of 3 handles are required to form a closed loop.
		/// </summary>
		// Token: 0x06007C85 RID: 31877 RVA: 0x000B2F64 File Offset: 0x000B1164
		public virtual int GetClosed()
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_GetClosed_10(base.GetCppThis());
		}

		// Token: 0x06007C86 RID: 31878
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCurveRepresentation_GetCurrentHandleIndex_11(HandleRef pThis);

		/// <summary>
		/// Get/Set the current handle index. Setting the current handle index will
		/// also result in the handle being highlighted. Set to `-1` to remove the
		/// highlight.
		/// </summary>
		// Token: 0x06007C87 RID: 31879 RVA: 0x000B2F84 File Offset: 0x000B1184
		public virtual int GetCurrentHandleIndex()
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_GetCurrentHandleIndex_11(base.GetCppThis());
		}

		// Token: 0x06007C88 RID: 31880
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCurveRepresentation_GetDirectional_12(HandleRef pThis);

		/// <summary>
		/// Set the representation to be directional or not.
		/// The meaning of being directional depends on the representation and
		/// its handles implementations in the subclasses.
		/// </summary>
		// Token: 0x06007C89 RID: 31881 RVA: 0x000B2FA4 File Offset: 0x000B11A4
		public virtual bool GetDirectional()
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_GetDirectional_12(base.GetCppThis()) != 0;
		}

		// Token: 0x06007C8A RID: 31882
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_GetHandlePosition_13(HandleRef pThis, int handle, IntPtr xyz);

		/// <summary>
		/// Set/Get the position of the handles. Call GetNumberOfHandles
		/// to determine the valid range of handle indices.
		/// </summary>
		// Token: 0x06007C8B RID: 31883 RVA: 0x000B2FCA File Offset: 0x000B11CA
		public virtual void GetHandlePosition(int handle, IntPtr xyz)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_GetHandlePosition_13(base.GetCppThis(), handle, xyz);
		}

		// Token: 0x06007C8C RID: 31884
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCurveRepresentation_GetHandlePosition_14(HandleRef pThis, int handle);

		/// <summary>
		/// Set/Get the position of the handles. Call GetNumberOfHandles
		/// to determine the valid range of handle indices.
		/// </summary>
		// Token: 0x06007C8D RID: 31885 RVA: 0x000B2FDC File Offset: 0x000B11DC
		public virtual IntPtr GetHandlePosition(int handle)
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_GetHandlePosition_14(base.GetCppThis(), handle);
		}

		// Token: 0x06007C8E RID: 31886
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCurveRepresentation_GetHandlePositions_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the position of the handles. Call GetNumberOfHandles
		/// to determine the valid range of handle indices.
		/// </summary>
		// Token: 0x06007C8F RID: 31887 RVA: 0x000B2FFC File Offset: 0x000B11FC
		public virtual vtkDoubleArray GetHandlePositions()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCurveRepresentation.vtkCurveRepresentation_GetHandlePositions_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		// Token: 0x06007C90 RID: 31888
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCurveRepresentation_GetHandleProperty_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle properties (the spheres are the handles). The
		/// properties of the handles when selected and unselected can be manipulated.
		/// </summary>
		// Token: 0x06007C91 RID: 31889 RVA: 0x000B306C File Offset: 0x000B126C
		public virtual vtkProperty GetHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCurveRepresentation.vtkCurveRepresentation_GetHandleProperty_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06007C92 RID: 31890
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCurveRepresentation_GetLineProperty_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the line properties. The properties of the line when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06007C93 RID: 31891 RVA: 0x000B30DC File Offset: 0x000B12DC
		public virtual vtkProperty GetLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCurveRepresentation.vtkCurveRepresentation_GetLineProperty_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06007C94 RID: 31892
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCurveRepresentation_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007C95 RID: 31893 RVA: 0x000B314C File Offset: 0x000B134C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x06007C96 RID: 31894
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCurveRepresentation_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007C97 RID: 31895 RVA: 0x000B316C File Offset: 0x000B136C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x06007C98 RID: 31896
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCurveRepresentation_GetNumberOfHandles_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of handles for this widget.
		/// </summary>
		// Token: 0x06007C99 RID: 31897 RVA: 0x000B3188 File Offset: 0x000B1388
		public virtual int GetNumberOfHandles()
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_GetNumberOfHandles_20(base.GetCppThis());
		}

		// Token: 0x06007C9A RID: 31898
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_GetPolyData_21(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Grab the polydata (including points) that defines the
		/// interpolating curve. Points are guaranteed to be up-to-date when
		/// either the InteractionEvent or EndInteraction events are
		/// invoked. The user provides the vtkPolyData and the points and
		/// polyline are added to it.
		/// </summary>
		// Token: 0x06007C9B RID: 31899 RVA: 0x000B31A8 File Offset: 0x000B13A8
		public virtual void GetPolyData(vtkPolyData pd)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_GetPolyData_21(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x06007C9C RID: 31900
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCurveRepresentation_GetProjectToPlane_22(HandleRef pThis);

		/// <summary>
		/// Force the widget to be projected onto one of the orthogonal
		/// planes.  Remember that when the InteractionState changes, a
		/// ModifiedEvent is invoked.  This can be used to snap the curve to
		/// the plane if it is originally not aligned.  The normal in
		/// SetProjectionNormal is 0,1,2 for YZ,XZ,XY planes respectively and
		/// 3 for arbitrary oblique planes when the widget is tied to a
		/// vtkPlaneSource.
		/// </summary>
		// Token: 0x06007C9D RID: 31901 RVA: 0x000B31D8 File Offset: 0x000B13D8
		public virtual int GetProjectToPlane()
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_GetProjectToPlane_22(base.GetCppThis());
		}

		// Token: 0x06007C9E RID: 31902
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCurveRepresentation_GetProjectionNormal_23(HandleRef pThis);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x06007C9F RID: 31903 RVA: 0x000B31F8 File Offset: 0x000B13F8
		public virtual int GetProjectionNormal()
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_GetProjectionNormal_23(base.GetCppThis());
		}

		// Token: 0x06007CA0 RID: 31904
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCurveRepresentation_GetProjectionNormalMaxValue_24(HandleRef pThis);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x06007CA1 RID: 31905 RVA: 0x000B3218 File Offset: 0x000B1418
		public virtual int GetProjectionNormalMaxValue()
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_GetProjectionNormalMaxValue_24(base.GetCppThis());
		}

		// Token: 0x06007CA2 RID: 31906
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCurveRepresentation_GetProjectionNormalMinValue_25(HandleRef pThis);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x06007CA3 RID: 31907 RVA: 0x000B3238 File Offset: 0x000B1438
		public virtual int GetProjectionNormalMinValue()
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_GetProjectionNormalMinValue_25(base.GetCppThis());
		}

		// Token: 0x06007CA4 RID: 31908
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCurveRepresentation_GetProjectionPosition_26(HandleRef pThis);

		/// <summary>
		/// Set the position of poly line handles and points in terms of a plane's
		/// position. i.e., if ProjectionNormal is 0, all of the x-coordinate
		/// values of the points are set to position. Any value can be passed (and is
		/// ignored) to update the poly line points when Projection normal is set to 3
		/// for arbitrary plane orientations.
		/// </summary>
		// Token: 0x06007CA5 RID: 31909 RVA: 0x000B3258 File Offset: 0x000B1458
		public virtual double GetProjectionPosition()
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_GetProjectionPosition_26(base.GetCppThis());
		}

		// Token: 0x06007CA6 RID: 31910
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCurveRepresentation_GetSelectedHandleProperty_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle properties (the spheres are the handles). The
		/// properties of the handles when selected and unselected can be manipulated.
		/// </summary>
		// Token: 0x06007CA7 RID: 31911 RVA: 0x000B3278 File Offset: 0x000B1478
		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCurveRepresentation.vtkCurveRepresentation_GetSelectedHandleProperty_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06007CA8 RID: 31912
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCurveRepresentation_GetSelectedLineProperty_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the line properties. The properties of the line when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06007CA9 RID: 31913 RVA: 0x000B32E8 File Offset: 0x000B14E8
		public virtual vtkProperty GetSelectedLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCurveRepresentation.vtkCurveRepresentation_GetSelectedLineProperty_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06007CAA RID: 31914
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCurveRepresentation_GetSummedLength_29(HandleRef pThis);

		/// <summary>
		/// Get the approximate vs. the true arc length of the curve. Calculated as
		/// the summed lengths of the individual straight line segments. Use
		/// SetResolution to control the accuracy.
		/// </summary>
		// Token: 0x06007CAB RID: 31915 RVA: 0x000B3358 File Offset: 0x000B1558
		public virtual double GetSummedLength()
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_GetSummedLength_29(base.GetCppThis());
		}

		// Token: 0x06007CAC RID: 31916
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCurveRepresentation_GetTranslationAxis_30(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x06007CAD RID: 31917 RVA: 0x000B3378 File Offset: 0x000B1578
		public virtual int GetTranslationAxis()
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_GetTranslationAxis_30(base.GetCppThis());
		}

		// Token: 0x06007CAE RID: 31918
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCurveRepresentation_GetTranslationAxisMaxValue_31(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x06007CAF RID: 31919 RVA: 0x000B3398 File Offset: 0x000B1598
		public virtual int GetTranslationAxisMaxValue()
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_GetTranslationAxisMaxValue_31(base.GetCppThis());
		}

		// Token: 0x06007CB0 RID: 31920
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCurveRepresentation_GetTranslationAxisMinValue_32(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x06007CB1 RID: 31921 RVA: 0x000B33B8 File Offset: 0x000B15B8
		public virtual int GetTranslationAxisMinValue()
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_GetTranslationAxisMinValue_32(base.GetCppThis());
		}

		// Token: 0x06007CB2 RID: 31922
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCurveRepresentation_HasTranslucentPolygonalGeometry_33(HandleRef pThis);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x06007CB3 RID: 31923 RVA: 0x000B33D8 File Offset: 0x000B15D8
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_HasTranslucentPolygonalGeometry_33(base.GetCppThis());
		}

		// Token: 0x06007CB4 RID: 31924
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_InitializeHandles_34(HandleRef pThis, HandleRef points);

		/// <summary>
		/// Convenience method to allocate and set the handles from a
		/// vtkPoints instance.  If the first and last points are the same,
		/// the curve sets Closed to the on InteractionState and disregards
		/// the last point, otherwise Closed remains unchanged.
		/// </summary>
		// Token: 0x06007CB5 RID: 31925 RVA: 0x000B33F8 File Offset: 0x000B15F8
		public virtual void InitializeHandles(vtkPoints points)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_InitializeHandles_34(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		// Token: 0x06007CB6 RID: 31926
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCurveRepresentation_IsA_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007CB7 RID: 31927 RVA: 0x000B3428 File Offset: 0x000B1628
		public override int IsA(string type)
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_IsA_35(base.GetCppThis(), type);
		}

		// Token: 0x06007CB8 RID: 31928
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCurveRepresentation_IsClosed_36(HandleRef pThis);

		/// <summary>
		/// Convenience method to determine whether the curve is
		/// closed in a geometric sense.  The widget may be set "closed" but still
		/// be geometrically open (e.g., a straight line).
		/// </summary>
		// Token: 0x06007CB9 RID: 31929 RVA: 0x000B3448 File Offset: 0x000B1648
		public int IsClosed()
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_IsClosed_36(base.GetCppThis());
		}

		// Token: 0x06007CBA RID: 31930
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCurveRepresentation_IsTranslationConstrained_37(HandleRef pThis);

		/// <summary>
		/// Returns true if ConstrainedAxis
		/// </summary>
		// Token: 0x06007CBB RID: 31931 RVA: 0x000B3468 File Offset: 0x000B1668
		public bool IsTranslationConstrained()
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_IsTranslationConstrained_37(base.GetCppThis()) != 0;
		}

		// Token: 0x06007CBC RID: 31932
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCurveRepresentation_IsTypeOf_38([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007CBD RID: 31933 RVA: 0x000B3490 File Offset: 0x000B1690
		public new static int IsTypeOf(string type)
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_IsTypeOf_38(type);
		}

		// Token: 0x06007CBE RID: 31934
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCurveRepresentation_NewInstance_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007CBF RID: 31935 RVA: 0x000B34AC File Offset: 0x000B16AC
		public new vtkCurveRepresentation NewInstance()
		{
			vtkCurveRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCurveRepresentation.vtkCurveRepresentation_NewInstance_39(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCurveRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007CC0 RID: 31936
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_ProjectToPlaneOff_40(HandleRef pThis);

		/// <summary>
		/// Force the widget to be projected onto one of the orthogonal
		/// planes.  Remember that when the InteractionState changes, a
		/// ModifiedEvent is invoked.  This can be used to snap the curve to
		/// the plane if it is originally not aligned.  The normal in
		/// SetProjectionNormal is 0,1,2 for YZ,XZ,XY planes respectively and
		/// 3 for arbitrary oblique planes when the widget is tied to a
		/// vtkPlaneSource.
		/// </summary>
		// Token: 0x06007CC1 RID: 31937 RVA: 0x000B3506 File Offset: 0x000B1706
		public virtual void ProjectToPlaneOff()
		{
			vtkCurveRepresentation.vtkCurveRepresentation_ProjectToPlaneOff_40(base.GetCppThis());
		}

		// Token: 0x06007CC2 RID: 31938
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_ProjectToPlaneOn_41(HandleRef pThis);

		/// <summary>
		/// Force the widget to be projected onto one of the orthogonal
		/// planes.  Remember that when the InteractionState changes, a
		/// ModifiedEvent is invoked.  This can be used to snap the curve to
		/// the plane if it is originally not aligned.  The normal in
		/// SetProjectionNormal is 0,1,2 for YZ,XZ,XY planes respectively and
		/// 3 for arbitrary oblique planes when the widget is tied to a
		/// vtkPlaneSource.
		/// </summary>
		// Token: 0x06007CC3 RID: 31939 RVA: 0x000B3515 File Offset: 0x000B1715
		public virtual void ProjectToPlaneOn()
		{
			vtkCurveRepresentation.vtkCurveRepresentation_ProjectToPlaneOn_41(base.GetCppThis());
		}

		// Token: 0x06007CC4 RID: 31940
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_RegisterPickers_42(HandleRef pThis);

		/// <summary>
		/// Set the color when unselected and selected.
		/// </summary>
		// Token: 0x06007CC5 RID: 31941 RVA: 0x000B3524 File Offset: 0x000B1724
		public override void RegisterPickers()
		{
			vtkCurveRepresentation.vtkCurveRepresentation_RegisterPickers_42(base.GetCppThis());
		}

		// Token: 0x06007CC6 RID: 31942
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_ReleaseGraphicsResources_43(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x06007CC7 RID: 31943 RVA: 0x000B3534 File Offset: 0x000B1734
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_ReleaseGraphicsResources_43(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06007CC8 RID: 31944
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCurveRepresentation_RenderOpaqueGeometry_44(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x06007CC9 RID: 31945 RVA: 0x000B3564 File Offset: 0x000B1764
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_RenderOpaqueGeometry_44(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06007CCA RID: 31946
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCurveRepresentation_RenderOverlay_45(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x06007CCB RID: 31947 RVA: 0x000B3598 File Offset: 0x000B1798
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_RenderOverlay_45(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06007CCC RID: 31948
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCurveRepresentation_RenderTranslucentPolygonalGeometry_46(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x06007CCD RID: 31949 RVA: 0x000B35CC File Offset: 0x000B17CC
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkCurveRepresentation.vtkCurveRepresentation_RenderTranslucentPolygonalGeometry_46(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06007CCE RID: 31950
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCurveRepresentation_SafeDownCast_47(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007CCF RID: 31951 RVA: 0x000B3600 File Offset: 0x000B1800
		public new static vtkCurveRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkCurveRepresentation vtkCurveRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCurveRepresentation.vtkCurveRepresentation_SafeDownCast_47((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCurveRepresentation = (vtkCurveRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCurveRepresentation.Register(null);
				}
			}
			return vtkCurveRepresentation;
		}

		// Token: 0x06007CD0 RID: 31952
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetClosed_48(HandleRef pThis, int closed);

		/// <summary>
		/// Control whether the curve is open or closed. A closed forms a
		/// continuous loop: the first and last points are the same.  A
		/// minimum of 3 handles are required to form a closed loop.
		/// </summary>
		// Token: 0x06007CD1 RID: 31953 RVA: 0x000B367F File Offset: 0x000B187F
		public void SetClosed(int closed)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetClosed_48(base.GetCppThis(), closed);
		}

		// Token: 0x06007CD2 RID: 31954
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetCurrentHandleIndex_49(HandleRef pThis, int index);

		/// <summary>
		/// Get/Set the current handle index. Setting the current handle index will
		/// also result in the handle being highlighted. Set to `-1` to remove the
		/// highlight.
		/// </summary>
		// Token: 0x06007CD3 RID: 31955 RVA: 0x000B368F File Offset: 0x000B188F
		public void SetCurrentHandleIndex(int index)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetCurrentHandleIndex_49(base.GetCppThis(), index);
		}

		// Token: 0x06007CD4 RID: 31956
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetDirectional_50(HandleRef pThis, byte val);

		/// <summary>
		/// Set the representation to be directional or not.
		/// The meaning of being directional depends on the representation and
		/// its handles implementations in the subclasses.
		/// </summary>
		// Token: 0x06007CD5 RID: 31957 RVA: 0x000B369F File Offset: 0x000B189F
		public virtual void SetDirectional(bool val)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetDirectional_50(base.GetCppThis(), val ? (byte)1 : (byte)0);
		}

		// Token: 0x06007CD6 RID: 31958
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetForegroundColor_51(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set the color when unselected and selected.
		/// </summary>
		// Token: 0x06007CD7 RID: 31959 RVA: 0x000B36B7 File Offset: 0x000B18B7
		public void SetForegroundColor(double arg0, double arg1, double arg2)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetForegroundColor_51(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x06007CD8 RID: 31960
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetForegroundColor_52(HandleRef pThis, IntPtr c);

		/// <summary>
		/// Set the color when unselected and selected.
		/// </summary>
		// Token: 0x06007CD9 RID: 31961 RVA: 0x000B36C9 File Offset: 0x000B18C9
		public void SetForegroundColor(IntPtr c)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetForegroundColor_52(base.GetCppThis(), c);
		}

		// Token: 0x06007CDA RID: 31962
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetHandlePosition_53(HandleRef pThis, int handle, double x, double y, double z);

		/// <summary>
		/// Set/Get the position of the handles. Call GetNumberOfHandles
		/// to determine the valid range of handle indices.
		/// </summary>
		// Token: 0x06007CDB RID: 31963 RVA: 0x000B36D9 File Offset: 0x000B18D9
		public virtual void SetHandlePosition(int handle, double x, double y, double z)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetHandlePosition_53(base.GetCppThis(), handle, x, y, z);
		}

		// Token: 0x06007CDC RID: 31964
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetHandlePosition_54(HandleRef pThis, int handle, IntPtr xyz);

		/// <summary>
		/// Set/Get the position of the handles. Call GetNumberOfHandles
		/// to determine the valid range of handle indices.
		/// </summary>
		// Token: 0x06007CDD RID: 31965 RVA: 0x000B36ED File Offset: 0x000B18ED
		public virtual void SetHandlePosition(int handle, IntPtr xyz)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetHandlePosition_54(base.GetCppThis(), handle, xyz);
		}

		// Token: 0x06007CDE RID: 31966
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetInteractionColor_55(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set the color when unselected and selected.
		/// </summary>
		// Token: 0x06007CDF RID: 31967 RVA: 0x000B36FE File Offset: 0x000B18FE
		public void SetInteractionColor(double arg0, double arg1, double arg2)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetInteractionColor_55(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x06007CE0 RID: 31968
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetInteractionColor_56(HandleRef pThis, IntPtr c);

		/// <summary>
		/// Set the color when unselected and selected.
		/// </summary>
		// Token: 0x06007CE1 RID: 31969 RVA: 0x000B3710 File Offset: 0x000B1910
		public void SetInteractionColor(IntPtr c)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetInteractionColor_56(base.GetCppThis(), c);
		}

		// Token: 0x06007CE2 RID: 31970
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetInteractionState_57(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the interaction state
		/// </summary>
		// Token: 0x06007CE3 RID: 31971 RVA: 0x000B3720 File Offset: 0x000B1920
		public virtual void SetInteractionState(int _arg)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetInteractionState_57(base.GetCppThis(), _arg);
		}

		// Token: 0x06007CE4 RID: 31972
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetLineColor_58(HandleRef pThis, double r, double g, double b);

		/// <summary>
		/// Convenience method to set the line color.
		/// Ideally one should use GetLineProperty()-&gt;SetColor().
		/// </summary>
		// Token: 0x06007CE5 RID: 31973 RVA: 0x000B3730 File Offset: 0x000B1930
		public void SetLineColor(double r, double g, double b)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetLineColor_58(base.GetCppThis(), r, g, b);
		}

		// Token: 0x06007CE6 RID: 31974
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetNumberOfHandles_59(HandleRef pThis, int npts);

		/// <summary>
		/// Set/Get the number of handles for this widget.
		/// </summary>
		// Token: 0x06007CE7 RID: 31975 RVA: 0x000B3742 File Offset: 0x000B1942
		public virtual void SetNumberOfHandles(int npts)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetNumberOfHandles_59(base.GetCppThis(), npts);
		}

		// Token: 0x06007CE8 RID: 31976
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetPlaneSource_60(HandleRef pThis, HandleRef plane);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x06007CE9 RID: 31977 RVA: 0x000B3754 File Offset: 0x000B1954
		public void SetPlaneSource(vtkPlaneSource plane)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetPlaneSource_60(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		// Token: 0x06007CEA RID: 31978
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetProjectToPlane_61(HandleRef pThis, int _arg);

		/// <summary>
		/// Force the widget to be projected onto one of the orthogonal
		/// planes.  Remember that when the InteractionState changes, a
		/// ModifiedEvent is invoked.  This can be used to snap the curve to
		/// the plane if it is originally not aligned.  The normal in
		/// SetProjectionNormal is 0,1,2 for YZ,XZ,XY planes respectively and
		/// 3 for arbitrary oblique planes when the widget is tied to a
		/// vtkPlaneSource.
		/// </summary>
		// Token: 0x06007CEB RID: 31979 RVA: 0x000B3783 File Offset: 0x000B1983
		public virtual void SetProjectToPlane(int _arg)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetProjectToPlane_61(base.GetCppThis(), _arg);
		}

		// Token: 0x06007CEC RID: 31980
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetProjectionNormal_62(HandleRef pThis, int _arg);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x06007CED RID: 31981 RVA: 0x000B3793 File Offset: 0x000B1993
		public virtual void SetProjectionNormal(int _arg)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetProjectionNormal_62(base.GetCppThis(), _arg);
		}

		// Token: 0x06007CEE RID: 31982
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetProjectionNormalToOblique_63(HandleRef pThis);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x06007CEF RID: 31983 RVA: 0x000B37A3 File Offset: 0x000B19A3
		public void SetProjectionNormalToOblique()
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetProjectionNormalToOblique_63(base.GetCppThis());
		}

		// Token: 0x06007CF0 RID: 31984
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetProjectionNormalToXAxes_64(HandleRef pThis);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x06007CF1 RID: 31985 RVA: 0x000B37B2 File Offset: 0x000B19B2
		public void SetProjectionNormalToXAxes()
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetProjectionNormalToXAxes_64(base.GetCppThis());
		}

		// Token: 0x06007CF2 RID: 31986
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetProjectionNormalToYAxes_65(HandleRef pThis);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x06007CF3 RID: 31987 RVA: 0x000B37C1 File Offset: 0x000B19C1
		public void SetProjectionNormalToYAxes()
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetProjectionNormalToYAxes_65(base.GetCppThis());
		}

		// Token: 0x06007CF4 RID: 31988
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetProjectionNormalToZAxes_66(HandleRef pThis);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x06007CF5 RID: 31989 RVA: 0x000B37D0 File Offset: 0x000B19D0
		public void SetProjectionNormalToZAxes()
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetProjectionNormalToZAxes_66(base.GetCppThis());
		}

		// Token: 0x06007CF6 RID: 31990
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetProjectionPosition_67(HandleRef pThis, double position);

		/// <summary>
		/// Set the position of poly line handles and points in terms of a plane's
		/// position. i.e., if ProjectionNormal is 0, all of the x-coordinate
		/// values of the points are set to position. Any value can be passed (and is
		/// ignored) to update the poly line points when Projection normal is set to 3
		/// for arbitrary plane orientations.
		/// </summary>
		// Token: 0x06007CF7 RID: 31991 RVA: 0x000B37DF File Offset: 0x000B19DF
		public void SetProjectionPosition(double position)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetProjectionPosition_67(base.GetCppThis(), position);
		}

		// Token: 0x06007CF8 RID: 31992
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetTranslationAxis_68(HandleRef pThis, int _arg);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x06007CF9 RID: 31993 RVA: 0x000B37EF File Offset: 0x000B19EF
		public virtual void SetTranslationAxis(int _arg)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetTranslationAxis_68(base.GetCppThis(), _arg);
		}

		// Token: 0x06007CFA RID: 31994
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetTranslationAxisOff_69(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x06007CFB RID: 31995 RVA: 0x000B37FF File Offset: 0x000B19FF
		public void SetTranslationAxisOff()
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetTranslationAxisOff_69(base.GetCppThis());
		}

		// Token: 0x06007CFC RID: 31996
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetXTranslationAxisOn_70(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x06007CFD RID: 31997 RVA: 0x000B380E File Offset: 0x000B1A0E
		public void SetXTranslationAxisOn()
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetXTranslationAxisOn_70(base.GetCppThis());
		}

		// Token: 0x06007CFE RID: 31998
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetYTranslationAxisOn_71(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x06007CFF RID: 31999 RVA: 0x000B381D File Offset: 0x000B1A1D
		public void SetYTranslationAxisOn()
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetYTranslationAxisOn_71(base.GetCppThis());
		}

		// Token: 0x06007D00 RID: 32000
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_SetZTranslationAxisOn_72(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x06007D01 RID: 32001 RVA: 0x000B382C File Offset: 0x000B1A2C
		public void SetZTranslationAxisOn()
		{
			vtkCurveRepresentation.vtkCurveRepresentation_SetZTranslationAxisOn_72(base.GetCppThis());
		}

		// Token: 0x06007D02 RID: 32002
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_StartWidgetInteraction_73(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation
		/// API. Note that a version of place widget is available where the
		/// center and handle position are specified.
		/// </summary>
		// Token: 0x06007D03 RID: 32003 RVA: 0x000B383B File Offset: 0x000B1A3B
		public override void StartWidgetInteraction(IntPtr e)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_StartWidgetInteraction_73(base.GetCppThis(), e);
		}

		// Token: 0x06007D04 RID: 32004
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurveRepresentation_WidgetInteraction_74(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation
		/// API. Note that a version of place widget is available where the
		/// center and handle position are specified.
		/// </summary>
		// Token: 0x06007D05 RID: 32005 RVA: 0x000B384B File Offset: 0x000B1A4B
		public override void WidgetInteraction(IntPtr e)
		{
			vtkCurveRepresentation.vtkCurveRepresentation_WidgetInteraction_74(base.GetCppThis(), e);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A76 RID: 2678
		public new const string MRFullTypeName = "Kitware.VTK.vtkCurveRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A77 RID: 2679
		public new static readonly string MRClassNameKey = "class vtkCurveRepresentation";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020002B1 RID: 689
		public enum InteractionStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000A79 RID: 2681
			Erasing = 7,
			/// <summary>enum member</summary>
			// Token: 0x04000A7A RID: 2682
			Inserting = 6,
			/// <summary>enum member</summary>
			// Token: 0x04000A7B RID: 2683
			Moving = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000A7C RID: 2684
			OnHandle = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000A7D RID: 2685
			OnLine,
			/// <summary>enum member</summary>
			// Token: 0x04000A7E RID: 2686
			Outside = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000A7F RID: 2687
			Pushing = 8,
			/// <summary>enum member</summary>
			// Token: 0x04000A80 RID: 2688
			Scaling = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000A81 RID: 2689
			Spinning
		}
	}
}
