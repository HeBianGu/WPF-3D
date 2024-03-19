using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImplicitPlaneWidget
	/// </summary>
	/// <remarks>
	///    3D widget for manipulating an infinite plane
	///
	/// This 3D widget defines an infinite plane that can be interactively placed
	/// in a scene. The widget is represented by a plane with a normal vector; the
	/// plane is contained by a bounding box, and where the plane intersects the
	/// bounding box the edges are shown (possibly tubed). The normal can be
	/// selected and moved to rotate the plane; the plane itself can be selected
	/// and translated in various directions. As the plane is moved, the implicit
	/// plane function and polygon (representing the plane cut against the bounding
	/// box) is updated.
	///
	/// To use this object, just invoke SetInteractor() with the argument of the
	/// method a vtkRenderWindowInteractor.  You may also wish to invoke
	/// "PlaceWidget()" to initially position the widget. If the "i" key (for
	/// "interactor") is pressed, the vtkImplicitPlaneWidget will appear. (See
	/// superclass documentation for information about changing this behavior.)
	/// If you select the normal vector, the plane can be arbitrarily rotated. The
	/// plane can be translated along the normal by selecting the plane and moving
	/// it. The plane (the plane origin) can also be arbitrary moved by selecting
	/// the plane with the middle mouse button. The right mouse button can be used
	/// to uniformly scale the bounding box (moving "up" the box scales larger;
	/// moving "down" the box scales smaller). Events that occur outside of the
	/// widget (i.e., no part of the widget is picked) are propagated to any other
	/// registered obsevers (such as the interaction style).  Turn off the widget
	/// by pressing the "i" key again (or invoke the Off() method).
	///
	/// The vtkImplicitPlaneWidget has several methods that can be used in
	/// conjunction with other VTK objects.  The GetPolyData() method can be used
	/// to get a polygonal representation (the single polygon clipped by the
	/// bounding box).  Typical usage of the widget is to make use of the
	/// StartInteractionEvent, InteractionEvent, and EndInteractionEvent
	/// events. The InteractionEvent is called on mouse motion; the other two
	/// events are called on button down and button up (either left or right
	/// button). (Note: there is also a PlaceWidgetEvent that is invoked when
	/// the widget is placed with PlaceWidget().)
	///
	/// Some additional features of this class include the ability to control the
	/// properties of the widget. You do this by setting property values on the
	/// normal vector (selected and unselected properties); the plane (selected
	/// and unselected properties); the outline (selected and unselected
	/// properties); and the edges. The edges may also be tubed or not.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtk3DWidget vtkBoxWidget vtkPlaneWidget vtkLineWidget vtkPointWidget
	/// vtkSphereWidget vtkImagePlaneWidget
	/// </seealso>
	// Token: 0x02000330 RID: 816
	public class vtkImplicitPlaneWidget : vtkPolyDataSourceWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060093FD RID: 37885 RVA: 0x000D1A9C File Offset: 0x000CFC9C
		static vtkImplicitPlaneWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitPlaneWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitPlaneWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060093FE RID: 37886 RVA: 0x000D1AC4 File Offset: 0x000CFCC4
		public vtkImplicitPlaneWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060093FF RID: 37887
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009400 RID: 37888 RVA: 0x000D1AD4 File Offset: 0x000CFCD4
		public new static vtkImplicitPlaneWidget New()
		{
			vtkImplicitPlaneWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitPlaneWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009401 RID: 37889 RVA: 0x000D1B28 File Offset: 0x000CFD28
		public vtkImplicitPlaneWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009402 RID: 37890 RVA: 0x000D1B6C File Offset: 0x000CFD6C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009403 RID: 37891
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_DrawPlaneOff_01(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the plane. In some cases the plane
		/// interferes with the object that it is operating on (i.e., the
		/// plane interferes with the cut surface it produces producing
		/// z-buffer artifacts.)
		/// </summary>
		// Token: 0x06009404 RID: 37892 RVA: 0x000D1B77 File Offset: 0x000CFD77
		public virtual void DrawPlaneOff()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_DrawPlaneOff_01(base.GetCppThis());
		}

		// Token: 0x06009405 RID: 37893
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_DrawPlaneOn_02(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the plane. In some cases the plane
		/// interferes with the object that it is operating on (i.e., the
		/// plane interferes with the cut surface it produces producing
		/// z-buffer artifacts.)
		/// </summary>
		// Token: 0x06009406 RID: 37894 RVA: 0x000D1B86 File Offset: 0x000CFD86
		public virtual void DrawPlaneOn()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_DrawPlaneOn_02(base.GetCppThis());
		}

		// Token: 0x06009407 RID: 37895
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitPlaneWidget_GetDiagonalRatio_03(HandleRef pThis);

		/// <summary>
		/// By default the arrow is 30% of the diagonal length. DiagonalRatio control
		/// this ratio in the interval [0-2]
		/// </summary>
		// Token: 0x06009408 RID: 37896 RVA: 0x000D1B98 File Offset: 0x000CFD98
		public virtual double GetDiagonalRatio()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetDiagonalRatio_03(base.GetCppThis());
		}

		// Token: 0x06009409 RID: 37897
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitPlaneWidget_GetDiagonalRatioMaxValue_04(HandleRef pThis);

		/// <summary>
		/// By default the arrow is 30% of the diagonal length. DiagonalRatio control
		/// this ratio in the interval [0-2]
		/// </summary>
		// Token: 0x0600940A RID: 37898 RVA: 0x000D1BB8 File Offset: 0x000CFDB8
		public virtual double GetDiagonalRatioMaxValue()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetDiagonalRatioMaxValue_04(base.GetCppThis());
		}

		// Token: 0x0600940B RID: 37899
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitPlaneWidget_GetDiagonalRatioMinValue_05(HandleRef pThis);

		/// <summary>
		/// By default the arrow is 30% of the diagonal length. DiagonalRatio control
		/// this ratio in the interval [0-2]
		/// </summary>
		// Token: 0x0600940C RID: 37900 RVA: 0x000D1BD8 File Offset: 0x000CFDD8
		public virtual double GetDiagonalRatioMinValue()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetDiagonalRatioMinValue_05(base.GetCppThis());
		}

		// Token: 0x0600940D RID: 37901
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneWidget_GetDrawPlane_06(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the plane. In some cases the plane
		/// interferes with the object that it is operating on (i.e., the
		/// plane interferes with the cut surface it produces producing
		/// z-buffer artifacts.)
		/// </summary>
		// Token: 0x0600940E RID: 37902 RVA: 0x000D1BF8 File Offset: 0x000CFDF8
		public virtual int GetDrawPlane()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetDrawPlane_06(base.GetCppThis());
		}

		// Token: 0x0600940F RID: 37903
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneWidget_GetEdgesProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the property of the intersection edges. (This property also
		/// applies to the edges when tubed.)
		/// </summary>
		// Token: 0x06009410 RID: 37904 RVA: 0x000D1C18 File Offset: 0x000CFE18
		public virtual vtkProperty GetEdgesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetEdgesProperty_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009411 RID: 37905
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneWidget_GetNormal_08(HandleRef pThis);

		/// <summary>
		/// Get the normal to the plane.
		/// </summary>
		// Token: 0x06009412 RID: 37906 RVA: 0x000D1C88 File Offset: 0x000CFE88
		public double[] GetNormal()
		{
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetNormal_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009413 RID: 37907
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_GetNormal_09(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Get the normal to the plane.
		/// </summary>
		// Token: 0x06009414 RID: 37908 RVA: 0x000D1CD0 File Offset: 0x000CFED0
		public void GetNormal(IntPtr xyz)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetNormal_09(base.GetCppThis(), xyz);
		}

		// Token: 0x06009415 RID: 37909
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneWidget_GetNormalProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the normal (line and cone).
		/// </summary>
		// Token: 0x06009416 RID: 37910 RVA: 0x000D1CE0 File Offset: 0x000CFEE0
		public virtual vtkProperty GetNormalProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetNormalProperty_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009417 RID: 37911
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneWidget_GetNormalToXAxis_11(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009418 RID: 37912 RVA: 0x000D1D50 File Offset: 0x000CFF50
		public virtual int GetNormalToXAxis()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetNormalToXAxis_11(base.GetCppThis());
		}

		// Token: 0x06009419 RID: 37913
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneWidget_GetNormalToYAxis_12(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x0600941A RID: 37914 RVA: 0x000D1D70 File Offset: 0x000CFF70
		public virtual int GetNormalToYAxis()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetNormalToYAxis_12(base.GetCppThis());
		}

		// Token: 0x0600941B RID: 37915
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneWidget_GetNormalToZAxis_13(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x0600941C RID: 37916 RVA: 0x000D1D90 File Offset: 0x000CFF90
		public virtual int GetNormalToZAxis()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetNormalToZAxis_13(base.GetCppThis());
		}

		// Token: 0x0600941D RID: 37917
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitPlaneWidget_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600941E RID: 37918 RVA: 0x000D1DB0 File Offset: 0x000CFFB0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x0600941F RID: 37919
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitPlaneWidget_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009420 RID: 37920 RVA: 0x000D1DD0 File Offset: 0x000CFFD0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x06009421 RID: 37921
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneWidget_GetOrigin_16(HandleRef pThis);

		/// <summary>
		/// Get the origin of the plane.
		/// </summary>
		// Token: 0x06009422 RID: 37922 RVA: 0x000D1DEC File Offset: 0x000CFFEC
		public double[] GetOrigin()
		{
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetOrigin_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009423 RID: 37923
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_GetOrigin_17(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Get the origin of the plane.
		/// </summary>
		// Token: 0x06009424 RID: 37924 RVA: 0x000D1E34 File Offset: 0x000D0034
		public void GetOrigin(IntPtr xyz)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetOrigin_17(base.GetCppThis(), xyz);
		}

		// Token: 0x06009425 RID: 37925
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneWidget_GetOriginTranslation_18(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to translate the origin (sphere)
		/// with the left mouse button.
		/// </summary>
		// Token: 0x06009426 RID: 37926 RVA: 0x000D1E44 File Offset: 0x000D0044
		public virtual int GetOriginTranslation()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetOriginTranslation_18(base.GetCppThis());
		}

		// Token: 0x06009427 RID: 37927
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneWidget_GetOutlineProperty_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the property of the outline.
		/// </summary>
		// Token: 0x06009428 RID: 37928 RVA: 0x000D1E64 File Offset: 0x000D0064
		public virtual vtkProperty GetOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetOutlineProperty_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009429 RID: 37929
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneWidget_GetOutlineTranslation_20(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to translate the bounding box by grabbing it
		/// with the left mouse button.
		/// </summary>
		// Token: 0x0600942A RID: 37930 RVA: 0x000D1ED4 File Offset: 0x000D00D4
		public virtual int GetOutlineTranslation()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetOutlineTranslation_20(base.GetCppThis());
		}

		// Token: 0x0600942B RID: 37931
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneWidget_GetOutsideBounds_21(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to move the widget outside of the input's bound
		/// </summary>
		// Token: 0x0600942C RID: 37932 RVA: 0x000D1EF4 File Offset: 0x000D00F4
		public virtual int GetOutsideBounds()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetOutsideBounds_21(base.GetCppThis());
		}

		// Token: 0x0600942D RID: 37933
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_GetPlane_22(HandleRef pThis, HandleRef plane);

		/// <summary>
		/// Get the implicit function for the plane. The user must provide the
		/// instance of the class vtkPlane. Note that vtkPlane is a subclass of
		/// vtkImplicitFunction, meaning that it can be used by a variety of filters
		/// to perform clipping, cutting, and selection of data.
		/// </summary>
		// Token: 0x0600942E RID: 37934 RVA: 0x000D1F14 File Offset: 0x000D0114
		public void GetPlane(vtkPlane plane)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetPlane_22(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		// Token: 0x0600942F RID: 37935
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneWidget_GetPlaneProperty_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the plane properties. The properties of the plane when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06009430 RID: 37936 RVA: 0x000D1F44 File Offset: 0x000D0144
		public virtual vtkProperty GetPlaneProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetPlaneProperty_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009431 RID: 37937
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_GetPolyData_24(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Grab the polydata that defines the plane. The polydata contains a single
		/// polygon that is clipped by the bounding box.
		/// </summary>
		// Token: 0x06009432 RID: 37938 RVA: 0x000D1FB4 File Offset: 0x000D01B4
		public void GetPolyData(vtkPolyData pd)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetPolyData_24(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x06009433 RID: 37939
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneWidget_GetPolyDataAlgorithm_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Satisfies superclass API.  This returns a pointer to the underlying
		/// PolyData (which represents the plane).
		/// </summary>
		// Token: 0x06009434 RID: 37940 RVA: 0x000D1FE4 File Offset: 0x000D01E4
		public override vtkPolyDataAlgorithm GetPolyDataAlgorithm()
		{
			vtkPolyDataAlgorithm vtkPolyDataAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetPolyDataAlgorithm_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataAlgorithm = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataAlgorithm.Register(null);
				}
			}
			return vtkPolyDataAlgorithm;
		}

		// Token: 0x06009435 RID: 37941
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneWidget_GetScaleEnabled_26(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to scale with the mouse
		/// </summary>
		// Token: 0x06009436 RID: 37942 RVA: 0x000D2054 File Offset: 0x000D0254
		public virtual int GetScaleEnabled()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetScaleEnabled_26(base.GetCppThis());
		}

		// Token: 0x06009437 RID: 37943
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneWidget_GetSelectedNormalProperty_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the normal (line and cone).
		/// </summary>
		// Token: 0x06009438 RID: 37944 RVA: 0x000D2074 File Offset: 0x000D0274
		public virtual vtkProperty GetSelectedNormalProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetSelectedNormalProperty_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009439 RID: 37945
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneWidget_GetSelectedOutlineProperty_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the property of the outline.
		/// </summary>
		// Token: 0x0600943A RID: 37946 RVA: 0x000D20E4 File Offset: 0x000D02E4
		public virtual vtkProperty GetSelectedOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetSelectedOutlineProperty_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600943B RID: 37947
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneWidget_GetSelectedPlaneProperty_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the plane properties. The properties of the plane when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x0600943C RID: 37948 RVA: 0x000D2154 File Offset: 0x000D0354
		public virtual vtkProperty GetSelectedPlaneProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetSelectedPlaneProperty_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600943D RID: 37949
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneWidget_GetTubing_30(HandleRef pThis);

		/// <summary>
		/// Turn on/off tubing of the wire outline of the plane. The tube thickens
		/// the line by wrapping with a vtkTubeFilter.
		/// </summary>
		// Token: 0x0600943E RID: 37950 RVA: 0x000D21C4 File Offset: 0x000D03C4
		public virtual int GetTubing()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetTubing_30(base.GetCppThis());
		}

		// Token: 0x0600943F RID: 37951
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneWidget_IsA_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009440 RID: 37952 RVA: 0x000D21E4 File Offset: 0x000D03E4
		public override int IsA(string type)
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_IsA_31(base.GetCppThis(), type);
		}

		// Token: 0x06009441 RID: 37953
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneWidget_IsTypeOf_32([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009442 RID: 37954 RVA: 0x000D2204 File Offset: 0x000D0404
		public new static int IsTypeOf(string type)
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_IsTypeOf_32(type);
		}

		// Token: 0x06009443 RID: 37955
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneWidget_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009444 RID: 37956 RVA: 0x000D2220 File Offset: 0x000D0420
		public new vtkImplicitPlaneWidget NewInstance()
		{
			vtkImplicitPlaneWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_NewInstance_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitPlaneWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009445 RID: 37957
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_NormalToXAxisOff_35(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009446 RID: 37958 RVA: 0x000D227A File Offset: 0x000D047A
		public virtual void NormalToXAxisOff()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_NormalToXAxisOff_35(base.GetCppThis());
		}

		// Token: 0x06009447 RID: 37959
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_NormalToXAxisOn_36(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009448 RID: 37960 RVA: 0x000D2289 File Offset: 0x000D0489
		public virtual void NormalToXAxisOn()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_NormalToXAxisOn_36(base.GetCppThis());
		}

		// Token: 0x06009449 RID: 37961
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_NormalToYAxisOff_37(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x0600944A RID: 37962 RVA: 0x000D2298 File Offset: 0x000D0498
		public virtual void NormalToYAxisOff()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_NormalToYAxisOff_37(base.GetCppThis());
		}

		// Token: 0x0600944B RID: 37963
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_NormalToYAxisOn_38(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x0600944C RID: 37964 RVA: 0x000D22A7 File Offset: 0x000D04A7
		public virtual void NormalToYAxisOn()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_NormalToYAxisOn_38(base.GetCppThis());
		}

		// Token: 0x0600944D RID: 37965
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_NormalToZAxisOff_39(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x0600944E RID: 37966 RVA: 0x000D22B6 File Offset: 0x000D04B6
		public virtual void NormalToZAxisOff()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_NormalToZAxisOff_39(base.GetCppThis());
		}

		// Token: 0x0600944F RID: 37967
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_NormalToZAxisOn_40(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009450 RID: 37968 RVA: 0x000D22C5 File Offset: 0x000D04C5
		public virtual void NormalToZAxisOn()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_NormalToZAxisOn_40(base.GetCppThis());
		}

		// Token: 0x06009451 RID: 37969
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_OriginTranslationOff_41(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to translate the origin (sphere)
		/// with the left mouse button.
		/// </summary>
		// Token: 0x06009452 RID: 37970 RVA: 0x000D22D4 File Offset: 0x000D04D4
		public virtual void OriginTranslationOff()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_OriginTranslationOff_41(base.GetCppThis());
		}

		// Token: 0x06009453 RID: 37971
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_OriginTranslationOn_42(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to translate the origin (sphere)
		/// with the left mouse button.
		/// </summary>
		// Token: 0x06009454 RID: 37972 RVA: 0x000D22E3 File Offset: 0x000D04E3
		public virtual void OriginTranslationOn()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_OriginTranslationOn_42(base.GetCppThis());
		}

		// Token: 0x06009455 RID: 37973
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_OutlineTranslationOff_43(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to translate the bounding box by grabbing it
		/// with the left mouse button.
		/// </summary>
		// Token: 0x06009456 RID: 37974 RVA: 0x000D22F2 File Offset: 0x000D04F2
		public virtual void OutlineTranslationOff()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_OutlineTranslationOff_43(base.GetCppThis());
		}

		// Token: 0x06009457 RID: 37975
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_OutlineTranslationOn_44(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to translate the bounding box by grabbing it
		/// with the left mouse button.
		/// </summary>
		// Token: 0x06009458 RID: 37976 RVA: 0x000D2301 File Offset: 0x000D0501
		public virtual void OutlineTranslationOn()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_OutlineTranslationOn_44(base.GetCppThis());
		}

		// Token: 0x06009459 RID: 37977
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_OutsideBoundsOff_45(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to move the widget outside of the input's bound
		/// </summary>
		// Token: 0x0600945A RID: 37978 RVA: 0x000D2310 File Offset: 0x000D0510
		public virtual void OutsideBoundsOff()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_OutsideBoundsOff_45(base.GetCppThis());
		}

		// Token: 0x0600945B RID: 37979
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_OutsideBoundsOn_46(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to move the widget outside of the input's bound
		/// </summary>
		// Token: 0x0600945C RID: 37980 RVA: 0x000D231F File Offset: 0x000D051F
		public virtual void OutsideBoundsOn()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_OutsideBoundsOn_46(base.GetCppThis());
		}

		// Token: 0x0600945D RID: 37981
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_PlaceWidget_47(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x0600945E RID: 37982 RVA: 0x000D232E File Offset: 0x000D052E
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_PlaceWidget_47(base.GetCppThis(), bounds);
		}

		// Token: 0x0600945F RID: 37983
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_PlaceWidget_48(HandleRef pThis);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x06009460 RID: 37984 RVA: 0x000D233E File Offset: 0x000D053E
		public override void PlaceWidget()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_PlaceWidget_48(base.GetCppThis());
		}

		// Token: 0x06009461 RID: 37985
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_PlaceWidget_49(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x06009462 RID: 37986 RVA: 0x000D234D File Offset: 0x000D054D
		public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_PlaceWidget_49(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		// Token: 0x06009463 RID: 37987
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneWidget_SafeDownCast_50(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009464 RID: 37988 RVA: 0x000D2368 File Offset: 0x000D0568
		public new static vtkImplicitPlaneWidget SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitPlaneWidget vtkImplicitPlaneWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SafeDownCast_50((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitPlaneWidget = (vtkImplicitPlaneWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitPlaneWidget.Register(null);
				}
			}
			return vtkImplicitPlaneWidget;
		}

		// Token: 0x06009465 RID: 37989
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_ScaleEnabledOff_51(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to scale with the mouse
		/// </summary>
		// Token: 0x06009466 RID: 37990 RVA: 0x000D23E7 File Offset: 0x000D05E7
		public virtual void ScaleEnabledOff()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_ScaleEnabledOff_51(base.GetCppThis());
		}

		// Token: 0x06009467 RID: 37991
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_ScaleEnabledOn_52(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to scale with the mouse
		/// </summary>
		// Token: 0x06009468 RID: 37992 RVA: 0x000D23F6 File Offset: 0x000D05F6
		public virtual void ScaleEnabledOn()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_ScaleEnabledOn_52(base.GetCppThis());
		}

		// Token: 0x06009469 RID: 37993
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_SetDiagonalRatio_53(HandleRef pThis, double _arg);

		/// <summary>
		/// By default the arrow is 30% of the diagonal length. DiagonalRatio control
		/// this ratio in the interval [0-2]
		/// </summary>
		// Token: 0x0600946A RID: 37994 RVA: 0x000D2405 File Offset: 0x000D0605
		public virtual void SetDiagonalRatio(double _arg)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetDiagonalRatio_53(base.GetCppThis(), _arg);
		}

		// Token: 0x0600946B RID: 37995
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_SetDrawPlane_54(HandleRef pThis, int plane);

		/// <summary>
		/// Enable/disable the drawing of the plane. In some cases the plane
		/// interferes with the object that it is operating on (i.e., the
		/// plane interferes with the cut surface it produces producing
		/// z-buffer artifacts.)
		/// </summary>
		// Token: 0x0600946C RID: 37996 RVA: 0x000D2415 File Offset: 0x000D0615
		public void SetDrawPlane(int plane)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetDrawPlane_54(base.GetCppThis(), plane);
		}

		// Token: 0x0600946D RID: 37997
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_SetEnabled_55(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x0600946E RID: 37998 RVA: 0x000D2425 File Offset: 0x000D0625
		public override void SetEnabled(int arg0)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetEnabled_55(base.GetCppThis(), arg0);
		}

		// Token: 0x0600946F RID: 37999
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_SetNormal_56(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Get the normal to the plane.
		/// </summary>
		// Token: 0x06009470 RID: 38000 RVA: 0x000D2435 File Offset: 0x000D0635
		public void SetNormal(double x, double y, double z)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetNormal_56(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06009471 RID: 38001
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_SetNormal_57(HandleRef pThis, IntPtr n);

		/// <summary>
		/// Get the normal to the plane.
		/// </summary>
		// Token: 0x06009472 RID: 38002 RVA: 0x000D2447 File Offset: 0x000D0647
		public void SetNormal(IntPtr n)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetNormal_57(base.GetCppThis(), n);
		}

		// Token: 0x06009473 RID: 38003
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_SetNormalToXAxis_58(HandleRef pThis, int arg0);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009474 RID: 38004 RVA: 0x000D2457 File Offset: 0x000D0657
		public void SetNormalToXAxis(int arg0)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetNormalToXAxis_58(base.GetCppThis(), arg0);
		}

		// Token: 0x06009475 RID: 38005
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_SetNormalToYAxis_59(HandleRef pThis, int arg0);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009476 RID: 38006 RVA: 0x000D2467 File Offset: 0x000D0667
		public void SetNormalToYAxis(int arg0)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetNormalToYAxis_59(base.GetCppThis(), arg0);
		}

		// Token: 0x06009477 RID: 38007
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_SetNormalToZAxis_60(HandleRef pThis, int arg0);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009478 RID: 38008 RVA: 0x000D2477 File Offset: 0x000D0677
		public void SetNormalToZAxis(int arg0)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetNormalToZAxis_60(base.GetCppThis(), arg0);
		}

		// Token: 0x06009479 RID: 38009
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_SetOrigin_61(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Get the origin of the plane.
		/// </summary>
		// Token: 0x0600947A RID: 38010 RVA: 0x000D2487 File Offset: 0x000D0687
		public virtual void SetOrigin(double x, double y, double z)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetOrigin_61(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600947B RID: 38011
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_SetOrigin_62(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Get the origin of the plane.
		/// </summary>
		// Token: 0x0600947C RID: 38012 RVA: 0x000D2499 File Offset: 0x000D0699
		public virtual void SetOrigin(IntPtr x)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetOrigin_62(base.GetCppThis(), x);
		}

		// Token: 0x0600947D RID: 38013
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_SetOriginTranslation_63(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the ability to translate the origin (sphere)
		/// with the left mouse button.
		/// </summary>
		// Token: 0x0600947E RID: 38014 RVA: 0x000D24A9 File Offset: 0x000D06A9
		public virtual void SetOriginTranslation(int _arg)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetOriginTranslation_63(base.GetCppThis(), _arg);
		}

		// Token: 0x0600947F RID: 38015
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_SetOutlineTranslation_64(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the ability to translate the bounding box by grabbing it
		/// with the left mouse button.
		/// </summary>
		// Token: 0x06009480 RID: 38016 RVA: 0x000D24B9 File Offset: 0x000D06B9
		public virtual void SetOutlineTranslation(int _arg)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetOutlineTranslation_64(base.GetCppThis(), _arg);
		}

		// Token: 0x06009481 RID: 38017
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_SetOutsideBounds_65(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the ability to move the widget outside of the input's bound
		/// </summary>
		// Token: 0x06009482 RID: 38018 RVA: 0x000D24C9 File Offset: 0x000D06C9
		public virtual void SetOutsideBounds(int _arg)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetOutsideBounds_65(base.GetCppThis(), _arg);
		}

		// Token: 0x06009483 RID: 38019
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_SetScaleEnabled_66(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the ability to scale with the mouse
		/// </summary>
		// Token: 0x06009484 RID: 38020 RVA: 0x000D24D9 File Offset: 0x000D06D9
		public virtual void SetScaleEnabled(int _arg)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetScaleEnabled_66(base.GetCppThis(), _arg);
		}

		// Token: 0x06009485 RID: 38021
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_SetTubing_67(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off tubing of the wire outline of the plane. The tube thickens
		/// the line by wrapping with a vtkTubeFilter.
		/// </summary>
		// Token: 0x06009486 RID: 38022 RVA: 0x000D24E9 File Offset: 0x000D06E9
		public virtual void SetTubing(int _arg)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetTubing_67(base.GetCppThis(), _arg);
		}

		// Token: 0x06009487 RID: 38023
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_SizeHandles_68(HandleRef pThis);

		/// <summary>
		/// Control widget appearance
		/// </summary>
		// Token: 0x06009488 RID: 38024 RVA: 0x000D24F9 File Offset: 0x000D06F9
		public virtual void SizeHandles()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SizeHandles_68(base.GetCppThis());
		}

		// Token: 0x06009489 RID: 38025
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_TubingOff_69(HandleRef pThis);

		/// <summary>
		/// Turn on/off tubing of the wire outline of the plane. The tube thickens
		/// the line by wrapping with a vtkTubeFilter.
		/// </summary>
		// Token: 0x0600948A RID: 38026 RVA: 0x000D2508 File Offset: 0x000D0708
		public virtual void TubingOff()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_TubingOff_69(base.GetCppThis());
		}

		// Token: 0x0600948B RID: 38027
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_TubingOn_70(HandleRef pThis);

		/// <summary>
		/// Turn on/off tubing of the wire outline of the plane. The tube thickens
		/// the line by wrapping with a vtkTubeFilter.
		/// </summary>
		// Token: 0x0600948C RID: 38028 RVA: 0x000D2517 File Offset: 0x000D0717
		public virtual void TubingOn()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_TubingOn_70(base.GetCppThis());
		}

		// Token: 0x0600948D RID: 38029
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget_UpdatePlacement_71(HandleRef pThis);

		/// <summary>
		/// Satisfies the superclass API.  This will change the state of the widget
		/// to match changes that have been made to the underlying PolyDataSource
		/// </summary>
		// Token: 0x0600948E RID: 38030 RVA: 0x000D2526 File Offset: 0x000D0726
		public override void UpdatePlacement()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_UpdatePlacement_71(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C2F RID: 3119
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitPlaneWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C30 RID: 3120
		public new static readonly string MRClassNameKey = "class vtkImplicitPlaneWidget";
	}
}
