using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageTracerWidget
	/// </summary>
	/// <remarks>
	///    3D widget for tracing on planar props.
	///
	/// vtkImageTracerWidget is different from other widgets in three distinct ways:
	/// 1) any sub-class of vtkProp can be input rather than just vtkProp3D, so that
	/// vtkImageActor can be set as the prop and then traced over, 2) the widget fires
	/// pick events at the input prop to decide where to move its handles, 3) the
	/// widget has 2D glyphs for handles instead of 3D spheres as is done in other
	/// sub-classes of vtk3DWidget. This widget is primarily designed for manually
	/// tracing over image data.
	/// The button actions and key modifiers are as follows for controlling the
	/// widget:
	/// 1) left button click over the image, hold and drag draws a free hand line.
	/// 2) left button click and release erases the widget line,
	/// if it exists, and repositions the first handle.
	/// 3) middle button click starts a snap drawn line.  The line is terminated by
	/// clicking the middle button while depressing the ctrl key.
	/// 4) when tracing a continuous or snap drawn line, if the last cursor position
	/// is within a specified tolerance to the first handle, the widget line will form
	/// a closed loop.
	/// 5) right button clicking and holding on any handle that is part of a snap
	/// drawn line allows handle dragging: existing line segments are updated
	/// accordingly.  If the path is open and AutoClose is set to On, the path can
	/// be closed by repositioning the first and last points over one another.
	/// 6) ctrl key + right button down on any handle will erase it: existing
	/// snap drawn line segments are updated accordingly.  If the line was formed by
	/// continuous tracing, the line is deleted leaving one handle.
	/// 7) shift key + right button down on any snap drawn line segment will insert
	/// a handle at the cursor position.  The line segment is split accordingly.
	///
	/// @warning
	/// the input vtkDataSet should be vtkImageData.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtk3DWidget vtkBoxWidget vtkLineWidget vtkPointWidget vtkSphereWidget
	/// vtkImagePlaneWidget vtkImplicitPlaneWidget vtkPlaneWidget
	/// </seealso>
	// Token: 0x02000329 RID: 809
	public class vtkImageTracerWidget : vtk3DWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600911F RID: 37151 RVA: 0x000CE6F4 File Offset: 0x000CC8F4
		static vtkImageTracerWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageTracerWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageTracerWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009120 RID: 37152 RVA: 0x000CE71C File Offset: 0x000CC91C
		public vtkImageTracerWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009121 RID: 37153
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageTracerWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009122 RID: 37154 RVA: 0x000CE72C File Offset: 0x000CC92C
		public new static vtkImageTracerWidget New()
		{
			vtkImageTracerWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageTracerWidget.vtkImageTracerWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageTracerWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009123 RID: 37155 RVA: 0x000CE780 File Offset: 0x000CC980
		public vtkImageTracerWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageTracerWidget.vtkImageTracerWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009124 RID: 37156 RVA: 0x000CE7C4 File Offset: 0x000CC9C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009125 RID: 37157
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_AutoCloseOff_01(HandleRef pThis);

		/// <summary>
		/// In concert with a CaptureRadius value, automatically
		/// form a closed path by connecting first to last path points.
		/// Default is Off.
		/// </summary>
		// Token: 0x06009126 RID: 37158 RVA: 0x000CE7CF File Offset: 0x000CC9CF
		public virtual void AutoCloseOff()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_AutoCloseOff_01(base.GetCppThis());
		}

		// Token: 0x06009127 RID: 37159
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_AutoCloseOn_02(HandleRef pThis);

		/// <summary>
		/// In concert with a CaptureRadius value, automatically
		/// form a closed path by connecting first to last path points.
		/// Default is Off.
		/// </summary>
		// Token: 0x06009128 RID: 37160 RVA: 0x000CE7DE File Offset: 0x000CC9DE
		public virtual void AutoCloseOn()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_AutoCloseOn_02(base.GetCppThis());
		}

		// Token: 0x06009129 RID: 37161
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageTracerWidget_GetAutoClose_03(HandleRef pThis);

		/// <summary>
		/// In concert with a CaptureRadius value, automatically
		/// form a closed path by connecting first to last path points.
		/// Default is Off.
		/// </summary>
		// Token: 0x0600912A RID: 37162 RVA: 0x000CE7F0 File Offset: 0x000CC9F0
		public virtual int GetAutoClose()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetAutoClose_03(base.GetCppThis());
		}

		// Token: 0x0600912B RID: 37163
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageTracerWidget_GetCaptureRadius_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the capture radius for automatic path closing.  For image
		/// data, capture radius should be half the distance between voxel/pixel
		/// centers.
		/// Default is 1.0
		/// </summary>
		// Token: 0x0600912C RID: 37164 RVA: 0x000CE810 File Offset: 0x000CCA10
		public virtual double GetCaptureRadius()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetCaptureRadius_04(base.GetCppThis());
		}

		// Token: 0x0600912D RID: 37165
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageTracerWidget_GetGlyphSource_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handles' geometric representation via vtkGlyphSource2D.
		/// </summary>
		// Token: 0x0600912E RID: 37166 RVA: 0x000CE830 File Offset: 0x000CCA30
		public vtkGlyphSource2D GetGlyphSource()
		{
			vtkGlyphSource2D vtkGlyphSource2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageTracerWidget.vtkImageTracerWidget_GetGlyphSource_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGlyphSource2D = (vtkGlyphSource2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGlyphSource2D.Register(null);
				}
			}
			return vtkGlyphSource2D;
		}

		// Token: 0x0600912F RID: 37167
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageTracerWidget_GetHandleLeftMouseButton_06(HandleRef pThis);

		/// <summary>
		/// Enable/Disable mouse button events
		/// </summary>
		// Token: 0x06009130 RID: 37168 RVA: 0x000CE8A0 File Offset: 0x000CCAA0
		public virtual int GetHandleLeftMouseButton()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetHandleLeftMouseButton_06(base.GetCppThis());
		}

		// Token: 0x06009131 RID: 37169
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageTracerWidget_GetHandleMiddleMouseButton_07(HandleRef pThis);

		/// <summary>
		/// Enable/Disable mouse button events
		/// </summary>
		// Token: 0x06009132 RID: 37170 RVA: 0x000CE8C0 File Offset: 0x000CCAC0
		public virtual int GetHandleMiddleMouseButton()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetHandleMiddleMouseButton_07(base.GetCppThis());
		}

		// Token: 0x06009133 RID: 37171
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_GetHandlePosition_08(HandleRef pThis, int handle, IntPtr xyz);

		/// <summary>
		/// Set/Get the handle position in terms of a zero-based array of handles.
		/// </summary>
		// Token: 0x06009134 RID: 37172 RVA: 0x000CE8DF File Offset: 0x000CCADF
		public void GetHandlePosition(int handle, IntPtr xyz)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_GetHandlePosition_08(base.GetCppThis(), handle, xyz);
		}

		// Token: 0x06009135 RID: 37173
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageTracerWidget_GetHandlePosition_09(HandleRef pThis, int handle);

		/// <summary>
		/// Set/Get the handle position in terms of a zero-based array of handles.
		/// </summary>
		// Token: 0x06009136 RID: 37174 RVA: 0x000CE8F0 File Offset: 0x000CCAF0
		public double[] GetHandlePosition(int handle)
		{
			IntPtr intPtr = vtkImageTracerWidget.vtkImageTracerWidget_GetHandlePosition_09(base.GetCppThis(), handle);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009137 RID: 37175
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageTracerWidget_GetHandleProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle properties (the 2D glyphs are the handles). The
		/// properties of the handles when selected and normal can be manipulated.
		/// </summary>
		// Token: 0x06009138 RID: 37176 RVA: 0x000CE93C File Offset: 0x000CCB3C
		public virtual vtkProperty GetHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageTracerWidget.vtkImageTracerWidget_GetHandleProperty_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009139 RID: 37177
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageTracerWidget_GetHandleRightMouseButton_11(HandleRef pThis);

		/// <summary>
		/// Enable/Disable mouse button events
		/// </summary>
		// Token: 0x0600913A RID: 37178 RVA: 0x000CE9AC File Offset: 0x000CCBAC
		public virtual int GetHandleRightMouseButton()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetHandleRightMouseButton_11(base.GetCppThis());
		}

		// Token: 0x0600913B RID: 37179
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageTracerWidget_GetImageSnapType_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the type of snapping to image data: center of a pixel/voxel or
		/// nearest point defining a pixel/voxel.
		/// </summary>
		// Token: 0x0600913C RID: 37180 RVA: 0x000CE9CC File Offset: 0x000CCBCC
		public virtual int GetImageSnapType()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetImageSnapType_12(base.GetCppThis());
		}

		// Token: 0x0600913D RID: 37181
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageTracerWidget_GetImageSnapTypeMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the type of snapping to image data: center of a pixel/voxel or
		/// nearest point defining a pixel/voxel.
		/// </summary>
		// Token: 0x0600913E RID: 37182 RVA: 0x000CE9EC File Offset: 0x000CCBEC
		public virtual int GetImageSnapTypeMaxValue()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetImageSnapTypeMaxValue_13(base.GetCppThis());
		}

		// Token: 0x0600913F RID: 37183
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageTracerWidget_GetImageSnapTypeMinValue_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the type of snapping to image data: center of a pixel/voxel or
		/// nearest point defining a pixel/voxel.
		/// </summary>
		// Token: 0x06009140 RID: 37184 RVA: 0x000CEA0C File Offset: 0x000CCC0C
		public virtual int GetImageSnapTypeMinValue()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetImageSnapTypeMinValue_14(base.GetCppThis());
		}

		// Token: 0x06009141 RID: 37185
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageTracerWidget_GetInteraction_15(HandleRef pThis);

		/// <summary>
		/// Enable/disable mouse interaction when the widget is visible.
		/// </summary>
		// Token: 0x06009142 RID: 37186 RVA: 0x000CEA2C File Offset: 0x000CCC2C
		public virtual int GetInteraction()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetInteraction_15(base.GetCppThis());
		}

		// Token: 0x06009143 RID: 37187
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageTracerWidget_GetLineProperty_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the line properties. The properties of the line when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06009144 RID: 37188 RVA: 0x000CEA4C File Offset: 0x000CCC4C
		public virtual vtkProperty GetLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageTracerWidget.vtkImageTracerWidget_GetLineProperty_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009145 RID: 37189
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageTracerWidget_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009146 RID: 37190 RVA: 0x000CEABC File Offset: 0x000CCCBC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x06009147 RID: 37191
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageTracerWidget_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009148 RID: 37192 RVA: 0x000CEADC File Offset: 0x000CCCDC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x06009149 RID: 37193
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageTracerWidget_GetNumberOfHandles_19(HandleRef pThis);

		/// <summary>
		/// Get the number of handles.
		/// </summary>
		// Token: 0x0600914A RID: 37194 RVA: 0x000CEAF8 File Offset: 0x000CCCF8
		public virtual int GetNumberOfHandles()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetNumberOfHandles_19(base.GetCppThis());
		}

		// Token: 0x0600914B RID: 37195
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_GetPath_20(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Grab the points and lines that define the traced path. These point values
		/// are guaranteed to be up-to-date when either the InteractionEvent or
		/// EndInteraction events are invoked. The user provides the vtkPolyData and
		/// the points and cells representing the line are added to it.
		/// </summary>
		// Token: 0x0600914C RID: 37196 RVA: 0x000CEB18 File Offset: 0x000CCD18
		public void GetPath(vtkPolyData pd)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_GetPath_20(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600914D RID: 37197
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageTracerWidget_GetProjectToPlane_21(HandleRef pThis);

		/// <summary>
		/// Force handles to be on a specific ortho plane. Default is Off.
		/// </summary>
		// Token: 0x0600914E RID: 37198 RVA: 0x000CEB48 File Offset: 0x000CCD48
		public virtual int GetProjectToPlane()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetProjectToPlane_21(base.GetCppThis());
		}

		// Token: 0x0600914F RID: 37199
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageTracerWidget_GetProjectionNormal_22(HandleRef pThis);

		/// <summary>
		/// Set the projection normal.  The normal in SetProjectionNormal is 0,1,2
		/// for YZ,XZ,XY planes respectively.  Since the handles are 2D glyphs, it is
		/// necessary to specify a plane on which to generate them, even though
		/// ProjectToPlane may be turned off.
		/// </summary>
		// Token: 0x06009150 RID: 37200 RVA: 0x000CEB68 File Offset: 0x000CCD68
		public virtual int GetProjectionNormal()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetProjectionNormal_22(base.GetCppThis());
		}

		// Token: 0x06009151 RID: 37201
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageTracerWidget_GetProjectionNormalMaxValue_23(HandleRef pThis);

		/// <summary>
		/// Set the projection normal.  The normal in SetProjectionNormal is 0,1,2
		/// for YZ,XZ,XY planes respectively.  Since the handles are 2D glyphs, it is
		/// necessary to specify a plane on which to generate them, even though
		/// ProjectToPlane may be turned off.
		/// </summary>
		// Token: 0x06009152 RID: 37202 RVA: 0x000CEB88 File Offset: 0x000CCD88
		public virtual int GetProjectionNormalMaxValue()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetProjectionNormalMaxValue_23(base.GetCppThis());
		}

		// Token: 0x06009153 RID: 37203
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageTracerWidget_GetProjectionNormalMinValue_24(HandleRef pThis);

		/// <summary>
		/// Set the projection normal.  The normal in SetProjectionNormal is 0,1,2
		/// for YZ,XZ,XY planes respectively.  Since the handles are 2D glyphs, it is
		/// necessary to specify a plane on which to generate them, even though
		/// ProjectToPlane may be turned off.
		/// </summary>
		// Token: 0x06009154 RID: 37204 RVA: 0x000CEBA8 File Offset: 0x000CCDA8
		public virtual int GetProjectionNormalMinValue()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetProjectionNormalMinValue_24(base.GetCppThis());
		}

		// Token: 0x06009155 RID: 37205
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageTracerWidget_GetProjectionPosition_25(HandleRef pThis);

		/// <summary>
		/// Set the position of the widgets' handles in terms of a plane's position.
		/// e.g., if ProjectionNormal is 0, all of the x-coordinate values of the
		/// handles are set to ProjectionPosition.  No attempt is made to ensure that
		/// the position is within the bounds of either the underlying image data or
		/// the prop on which tracing is performed.
		/// </summary>
		// Token: 0x06009156 RID: 37206 RVA: 0x000CEBC8 File Offset: 0x000CCDC8
		public virtual double GetProjectionPosition()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetProjectionPosition_25(base.GetCppThis());
		}

		// Token: 0x06009157 RID: 37207
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageTracerWidget_GetSelectedHandleProperty_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle properties (the 2D glyphs are the handles). The
		/// properties of the handles when selected and normal can be manipulated.
		/// </summary>
		// Token: 0x06009158 RID: 37208 RVA: 0x000CEBE8 File Offset: 0x000CCDE8
		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageTracerWidget.vtkImageTracerWidget_GetSelectedHandleProperty_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009159 RID: 37209
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageTracerWidget_GetSelectedLineProperty_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the line properties. The properties of the line when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x0600915A RID: 37210 RVA: 0x000CEC58 File Offset: 0x000CCE58
		public virtual vtkProperty GetSelectedLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageTracerWidget.vtkImageTracerWidget_GetSelectedLineProperty_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600915B RID: 37211
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageTracerWidget_GetSnapToImage_28(HandleRef pThis);

		/// <summary>
		/// Force snapping to image data while tracing. Default is Off.
		/// </summary>
		// Token: 0x0600915C RID: 37212 RVA: 0x000CECC8 File Offset: 0x000CCEC8
		public virtual int GetSnapToImage()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetSnapToImage_28(base.GetCppThis());
		}

		// Token: 0x0600915D RID: 37213
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_HandleLeftMouseButtonOff_29(HandleRef pThis);

		/// <summary>
		/// Enable/Disable mouse button events
		/// </summary>
		// Token: 0x0600915E RID: 37214 RVA: 0x000CECE7 File Offset: 0x000CCEE7
		public virtual void HandleLeftMouseButtonOff()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_HandleLeftMouseButtonOff_29(base.GetCppThis());
		}

		// Token: 0x0600915F RID: 37215
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_HandleLeftMouseButtonOn_30(HandleRef pThis);

		/// <summary>
		/// Enable/Disable mouse button events
		/// </summary>
		// Token: 0x06009160 RID: 37216 RVA: 0x000CECF6 File Offset: 0x000CCEF6
		public virtual void HandleLeftMouseButtonOn()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_HandleLeftMouseButtonOn_30(base.GetCppThis());
		}

		// Token: 0x06009161 RID: 37217
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_HandleMiddleMouseButtonOff_31(HandleRef pThis);

		/// <summary>
		/// Enable/Disable mouse button events
		/// </summary>
		// Token: 0x06009162 RID: 37218 RVA: 0x000CED05 File Offset: 0x000CCF05
		public virtual void HandleMiddleMouseButtonOff()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_HandleMiddleMouseButtonOff_31(base.GetCppThis());
		}

		// Token: 0x06009163 RID: 37219
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_HandleMiddleMouseButtonOn_32(HandleRef pThis);

		/// <summary>
		/// Enable/Disable mouse button events
		/// </summary>
		// Token: 0x06009164 RID: 37220 RVA: 0x000CED14 File Offset: 0x000CCF14
		public virtual void HandleMiddleMouseButtonOn()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_HandleMiddleMouseButtonOn_32(base.GetCppThis());
		}

		// Token: 0x06009165 RID: 37221
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_HandleRightMouseButtonOff_33(HandleRef pThis);

		/// <summary>
		/// Enable/Disable mouse button events
		/// </summary>
		// Token: 0x06009166 RID: 37222 RVA: 0x000CED23 File Offset: 0x000CCF23
		public virtual void HandleRightMouseButtonOff()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_HandleRightMouseButtonOff_33(base.GetCppThis());
		}

		// Token: 0x06009167 RID: 37223
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_HandleRightMouseButtonOn_34(HandleRef pThis);

		/// <summary>
		/// Enable/Disable mouse button events
		/// </summary>
		// Token: 0x06009168 RID: 37224 RVA: 0x000CED32 File Offset: 0x000CCF32
		public virtual void HandleRightMouseButtonOn()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_HandleRightMouseButtonOn_34(base.GetCppThis());
		}

		// Token: 0x06009169 RID: 37225
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_InitializeHandles_35(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Initialize the widget with a set of points and generate
		/// lines between them.  If AutoClose is on it will handle the
		/// case wherein the first and last points are congruent.
		/// </summary>
		// Token: 0x0600916A RID: 37226 RVA: 0x000CED44 File Offset: 0x000CCF44
		public void InitializeHandles(vtkPoints arg0)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_InitializeHandles_35(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600916B RID: 37227
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_InteractionOff_36(HandleRef pThis);

		/// <summary>
		/// Enable/disable mouse interaction when the widget is visible.
		/// </summary>
		// Token: 0x0600916C RID: 37228 RVA: 0x000CED73 File Offset: 0x000CCF73
		public virtual void InteractionOff()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_InteractionOff_36(base.GetCppThis());
		}

		// Token: 0x0600916D RID: 37229
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_InteractionOn_37(HandleRef pThis);

		/// <summary>
		/// Enable/disable mouse interaction when the widget is visible.
		/// </summary>
		// Token: 0x0600916E RID: 37230 RVA: 0x000CED82 File Offset: 0x000CCF82
		public virtual void InteractionOn()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_InteractionOn_37(base.GetCppThis());
		}

		// Token: 0x0600916F RID: 37231
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageTracerWidget_IsA_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009170 RID: 37232 RVA: 0x000CED94 File Offset: 0x000CCF94
		public override int IsA(string type)
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_IsA_38(base.GetCppThis(), type);
		}

		// Token: 0x06009171 RID: 37233
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageTracerWidget_IsClosed_39(HandleRef pThis);

		/// <summary>
		/// Is the path closed or open?
		/// </summary>
		// Token: 0x06009172 RID: 37234 RVA: 0x000CEDB4 File Offset: 0x000CCFB4
		public int IsClosed()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_IsClosed_39(base.GetCppThis());
		}

		// Token: 0x06009173 RID: 37235
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageTracerWidget_IsTypeOf_40([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009174 RID: 37236 RVA: 0x000CEDD4 File Offset: 0x000CCFD4
		public new static int IsTypeOf(string type)
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_IsTypeOf_40(type);
		}

		// Token: 0x06009175 RID: 37237
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageTracerWidget_NewInstance_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009176 RID: 37238 RVA: 0x000CEDF0 File Offset: 0x000CCFF0
		public new vtkImageTracerWidget NewInstance()
		{
			vtkImageTracerWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageTracerWidget.vtkImageTracerWidget_NewInstance_42(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageTracerWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009177 RID: 37239
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_PlaceWidget_43(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x06009178 RID: 37240 RVA: 0x000CEE4A File Offset: 0x000CD04A
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_PlaceWidget_43(base.GetCppThis(), bounds);
		}

		// Token: 0x06009179 RID: 37241
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_PlaceWidget_44(HandleRef pThis);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x0600917A RID: 37242 RVA: 0x000CEE5A File Offset: 0x000CD05A
		public override void PlaceWidget()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_PlaceWidget_44(base.GetCppThis());
		}

		// Token: 0x0600917B RID: 37243
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_PlaceWidget_45(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x0600917C RID: 37244 RVA: 0x000CEE69 File Offset: 0x000CD069
		public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_PlaceWidget_45(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		// Token: 0x0600917D RID: 37245
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_ProjectToPlaneOff_46(HandleRef pThis);

		/// <summary>
		/// Force handles to be on a specific ortho plane. Default is Off.
		/// </summary>
		// Token: 0x0600917E RID: 37246 RVA: 0x000CEE81 File Offset: 0x000CD081
		public virtual void ProjectToPlaneOff()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_ProjectToPlaneOff_46(base.GetCppThis());
		}

		// Token: 0x0600917F RID: 37247
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_ProjectToPlaneOn_47(HandleRef pThis);

		/// <summary>
		/// Force handles to be on a specific ortho plane. Default is Off.
		/// </summary>
		// Token: 0x06009180 RID: 37248 RVA: 0x000CEE90 File Offset: 0x000CD090
		public virtual void ProjectToPlaneOn()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_ProjectToPlaneOn_47(base.GetCppThis());
		}

		// Token: 0x06009181 RID: 37249
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageTracerWidget_SafeDownCast_48(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009182 RID: 37250 RVA: 0x000CEEA0 File Offset: 0x000CD0A0
		public new static vtkImageTracerWidget SafeDownCast(vtkObjectBase o)
		{
			vtkImageTracerWidget vtkImageTracerWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageTracerWidget.vtkImageTracerWidget_SafeDownCast_48((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageTracerWidget = (vtkImageTracerWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageTracerWidget.Register(null);
				}
			}
			return vtkImageTracerWidget;
		}

		// Token: 0x06009183 RID: 37251
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SetAutoClose_49(HandleRef pThis, int _arg);

		/// <summary>
		/// In concert with a CaptureRadius value, automatically
		/// form a closed path by connecting first to last path points.
		/// Default is Off.
		/// </summary>
		// Token: 0x06009184 RID: 37252 RVA: 0x000CEF1F File Offset: 0x000CD11F
		public virtual void SetAutoClose(int _arg)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetAutoClose_49(base.GetCppThis(), _arg);
		}

		// Token: 0x06009185 RID: 37253
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SetCaptureRadius_50(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the capture radius for automatic path closing.  For image
		/// data, capture radius should be half the distance between voxel/pixel
		/// centers.
		/// Default is 1.0
		/// </summary>
		// Token: 0x06009186 RID: 37254 RVA: 0x000CEF2F File Offset: 0x000CD12F
		public virtual void SetCaptureRadius(double _arg)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetCaptureRadius_50(base.GetCppThis(), _arg);
		}

		// Token: 0x06009187 RID: 37255
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SetEnabled_51(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x06009188 RID: 37256 RVA: 0x000CEF3F File Offset: 0x000CD13F
		public override void SetEnabled(int arg0)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetEnabled_51(base.GetCppThis(), arg0);
		}

		// Token: 0x06009189 RID: 37257
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SetHandleLeftMouseButton_52(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/Disable mouse button events
		/// </summary>
		// Token: 0x0600918A RID: 37258 RVA: 0x000CEF4F File Offset: 0x000CD14F
		public virtual void SetHandleLeftMouseButton(int _arg)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetHandleLeftMouseButton_52(base.GetCppThis(), _arg);
		}

		// Token: 0x0600918B RID: 37259
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SetHandleMiddleMouseButton_53(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/Disable mouse button events
		/// </summary>
		// Token: 0x0600918C RID: 37260 RVA: 0x000CEF5F File Offset: 0x000CD15F
		public virtual void SetHandleMiddleMouseButton(int _arg)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetHandleMiddleMouseButton_53(base.GetCppThis(), _arg);
		}

		// Token: 0x0600918D RID: 37261
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SetHandlePosition_54(HandleRef pThis, int handle, IntPtr xyz);

		/// <summary>
		/// Set/Get the handle position in terms of a zero-based array of handles.
		/// </summary>
		// Token: 0x0600918E RID: 37262 RVA: 0x000CEF6F File Offset: 0x000CD16F
		public void SetHandlePosition(int handle, IntPtr xyz)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetHandlePosition_54(base.GetCppThis(), handle, xyz);
		}

		// Token: 0x0600918F RID: 37263
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SetHandlePosition_55(HandleRef pThis, int handle, double x, double y, double z);

		/// <summary>
		/// Set/Get the handle position in terms of a zero-based array of handles.
		/// </summary>
		// Token: 0x06009190 RID: 37264 RVA: 0x000CEF80 File Offset: 0x000CD180
		public void SetHandlePosition(int handle, double x, double y, double z)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetHandlePosition_55(base.GetCppThis(), handle, x, y, z);
		}

		// Token: 0x06009191 RID: 37265
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SetHandleProperty_56(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the handle properties (the 2D glyphs are the handles). The
		/// properties of the handles when selected and normal can be manipulated.
		/// </summary>
		// Token: 0x06009192 RID: 37266 RVA: 0x000CEF94 File Offset: 0x000CD194
		public virtual void SetHandleProperty(vtkProperty arg0)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetHandleProperty_56(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009193 RID: 37267
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SetHandleRightMouseButton_57(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/Disable mouse button events
		/// </summary>
		// Token: 0x06009194 RID: 37268 RVA: 0x000CEFC3 File Offset: 0x000CD1C3
		public virtual void SetHandleRightMouseButton(int _arg)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetHandleRightMouseButton_57(base.GetCppThis(), _arg);
		}

		// Token: 0x06009195 RID: 37269
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SetImageSnapType_58(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the type of snapping to image data: center of a pixel/voxel or
		/// nearest point defining a pixel/voxel.
		/// </summary>
		// Token: 0x06009196 RID: 37270 RVA: 0x000CEFD3 File Offset: 0x000CD1D3
		public virtual void SetImageSnapType(int _arg)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetImageSnapType_58(base.GetCppThis(), _arg);
		}

		// Token: 0x06009197 RID: 37271
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SetInteraction_59(HandleRef pThis, int interact);

		/// <summary>
		/// Enable/disable mouse interaction when the widget is visible.
		/// </summary>
		// Token: 0x06009198 RID: 37272 RVA: 0x000CEFE3 File Offset: 0x000CD1E3
		public void SetInteraction(int interact)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetInteraction_59(base.GetCppThis(), interact);
		}

		// Token: 0x06009199 RID: 37273
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SetLineProperty_60(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the line properties. The properties of the line when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x0600919A RID: 37274 RVA: 0x000CEFF4 File Offset: 0x000CD1F4
		public virtual void SetLineProperty(vtkProperty arg0)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetLineProperty_60(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600919B RID: 37275
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SetProjectToPlane_61(HandleRef pThis, int _arg);

		/// <summary>
		/// Force handles to be on a specific ortho plane. Default is Off.
		/// </summary>
		// Token: 0x0600919C RID: 37276 RVA: 0x000CF023 File Offset: 0x000CD223
		public virtual void SetProjectToPlane(int _arg)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetProjectToPlane_61(base.GetCppThis(), _arg);
		}

		// Token: 0x0600919D RID: 37277
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SetProjectionNormal_62(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the projection normal.  The normal in SetProjectionNormal is 0,1,2
		/// for YZ,XZ,XY planes respectively.  Since the handles are 2D glyphs, it is
		/// necessary to specify a plane on which to generate them, even though
		/// ProjectToPlane may be turned off.
		/// </summary>
		// Token: 0x0600919E RID: 37278 RVA: 0x000CF033 File Offset: 0x000CD233
		public virtual void SetProjectionNormal(int _arg)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetProjectionNormal_62(base.GetCppThis(), _arg);
		}

		// Token: 0x0600919F RID: 37279
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SetProjectionNormalToXAxes_63(HandleRef pThis);

		/// <summary>
		/// Set the projection normal.  The normal in SetProjectionNormal is 0,1,2
		/// for YZ,XZ,XY planes respectively.  Since the handles are 2D glyphs, it is
		/// necessary to specify a plane on which to generate them, even though
		/// ProjectToPlane may be turned off.
		/// </summary>
		// Token: 0x060091A0 RID: 37280 RVA: 0x000CF043 File Offset: 0x000CD243
		public void SetProjectionNormalToXAxes()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetProjectionNormalToXAxes_63(base.GetCppThis());
		}

		// Token: 0x060091A1 RID: 37281
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SetProjectionNormalToYAxes_64(HandleRef pThis);

		/// <summary>
		/// Set the projection normal.  The normal in SetProjectionNormal is 0,1,2
		/// for YZ,XZ,XY planes respectively.  Since the handles are 2D glyphs, it is
		/// necessary to specify a plane on which to generate them, even though
		/// ProjectToPlane may be turned off.
		/// </summary>
		// Token: 0x060091A2 RID: 37282 RVA: 0x000CF052 File Offset: 0x000CD252
		public void SetProjectionNormalToYAxes()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetProjectionNormalToYAxes_64(base.GetCppThis());
		}

		// Token: 0x060091A3 RID: 37283
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SetProjectionNormalToZAxes_65(HandleRef pThis);

		/// <summary>
		/// Set the projection normal.  The normal in SetProjectionNormal is 0,1,2
		/// for YZ,XZ,XY planes respectively.  Since the handles are 2D glyphs, it is
		/// necessary to specify a plane on which to generate them, even though
		/// ProjectToPlane may be turned off.
		/// </summary>
		// Token: 0x060091A4 RID: 37284 RVA: 0x000CF061 File Offset: 0x000CD261
		public void SetProjectionNormalToZAxes()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetProjectionNormalToZAxes_65(base.GetCppThis());
		}

		// Token: 0x060091A5 RID: 37285
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SetProjectionPosition_66(HandleRef pThis, double position);

		/// <summary>
		/// Set the position of the widgets' handles in terms of a plane's position.
		/// e.g., if ProjectionNormal is 0, all of the x-coordinate values of the
		/// handles are set to ProjectionPosition.  No attempt is made to ensure that
		/// the position is within the bounds of either the underlying image data or
		/// the prop on which tracing is performed.
		/// </summary>
		// Token: 0x060091A6 RID: 37286 RVA: 0x000CF070 File Offset: 0x000CD270
		public void SetProjectionPosition(double position)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetProjectionPosition_66(base.GetCppThis(), position);
		}

		// Token: 0x060091A7 RID: 37287
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SetSelectedHandleProperty_67(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the handle properties (the 2D glyphs are the handles). The
		/// properties of the handles when selected and normal can be manipulated.
		/// </summary>
		// Token: 0x060091A8 RID: 37288 RVA: 0x000CF080 File Offset: 0x000CD280
		public virtual void SetSelectedHandleProperty(vtkProperty arg0)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetSelectedHandleProperty_67(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060091A9 RID: 37289
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SetSelectedLineProperty_68(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the line properties. The properties of the line when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x060091AA RID: 37290 RVA: 0x000CF0B0 File Offset: 0x000CD2B0
		public virtual void SetSelectedLineProperty(vtkProperty arg0)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetSelectedLineProperty_68(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060091AB RID: 37291
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SetSnapToImage_69(HandleRef pThis, int snap);

		/// <summary>
		/// Force snapping to image data while tracing. Default is Off.
		/// </summary>
		// Token: 0x060091AC RID: 37292 RVA: 0x000CF0DF File Offset: 0x000CD2DF
		public void SetSnapToImage(int snap)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetSnapToImage_69(base.GetCppThis(), snap);
		}

		// Token: 0x060091AD RID: 37293
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SetViewProp_70(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Set the prop, usually a vtkImageActor, to trace over.
		/// </summary>
		// Token: 0x060091AE RID: 37294 RVA: 0x000CF0F0 File Offset: 0x000CD2F0
		public void SetViewProp(vtkProp prop)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetViewProp_70(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x060091AF RID: 37295
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SnapToImageOff_71(HandleRef pThis);

		/// <summary>
		/// Force snapping to image data while tracing. Default is Off.
		/// </summary>
		// Token: 0x060091B0 RID: 37296 RVA: 0x000CF11F File Offset: 0x000CD31F
		public virtual void SnapToImageOff()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SnapToImageOff_71(base.GetCppThis());
		}

		// Token: 0x060091B1 RID: 37297
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTracerWidget_SnapToImageOn_72(HandleRef pThis);

		/// <summary>
		/// Force snapping to image data while tracing. Default is Off.
		/// </summary>
		// Token: 0x060091B2 RID: 37298 RVA: 0x000CF12E File Offset: 0x000CD32E
		public virtual void SnapToImageOn()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SnapToImageOn_72(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C14 RID: 3092
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageTracerWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C15 RID: 3093
		public new static readonly string MRClassNameKey = "class vtkImageTracerWidget";
	}
}
