using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSliderRepresentation2D
	/// </summary>
	/// <remarks>
	///    provide the representation for a vtkSliderWidget with a 3D skin
	///
	/// This class is used to represent and render a vtkSliderWidget. To use this
	/// class, you must at a minimum specify the end points of the
	/// slider. Optional instance variable can be used to modify the appearance of
	/// the widget.
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSliderWidget
	/// </seealso>
	// Token: 0x02000375 RID: 885
	public class vtkSliderRepresentation2D : vtkSliderRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A043 RID: 41027 RVA: 0x000E370B File Offset: 0x000E190B
		static vtkSliderRepresentation2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSliderRepresentation2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSliderRepresentation2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A044 RID: 41028 RVA: 0x000E3733 File Offset: 0x000E1933
		public vtkSliderRepresentation2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A045 RID: 41029
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0600A046 RID: 41030 RVA: 0x000E3744 File Offset: 0x000E1944
		public new static vtkSliderRepresentation2D New()
		{
			vtkSliderRepresentation2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderRepresentation2D.vtkSliderRepresentation2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSliderRepresentation2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0600A047 RID: 41031 RVA: 0x000E3798 File Offset: 0x000E1998
		public vtkSliderRepresentation2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSliderRepresentation2D.vtkSliderRepresentation2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A048 RID: 41032 RVA: 0x000E37DC File Offset: 0x000E19DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A049 RID: 41033
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation2D_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display space
		/// where the widget should be placed.
		/// </summary>
		// Token: 0x0600A04A RID: 41034 RVA: 0x000E37E7 File Offset: 0x000E19E7
		public override void BuildRepresentation()
		{
			vtkSliderRepresentation2D.vtkSliderRepresentation2D_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x0600A04B RID: 41035
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation2D_GetActors2D_02(HandleRef pThis, HandleRef propCollection);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600A04C RID: 41036 RVA: 0x000E37F8 File Offset: 0x000E19F8
		public override void GetActors2D(vtkPropCollection propCollection)
		{
			vtkSliderRepresentation2D.vtkSliderRepresentation2D_GetActors2D_02(base.GetCppThis(), (propCollection == null) ? default(HandleRef) : propCollection.GetCppThis());
		}

		// Token: 0x0600A04D RID: 41037
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation2D_GetCapProperty_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties for the tube and end caps.
		/// </summary>
		// Token: 0x0600A04E RID: 41038 RVA: 0x000E3828 File Offset: 0x000E1A28
		public virtual vtkProperty2D GetCapProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderRepresentation2D.vtkSliderRepresentation2D_GetCapProperty_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		// Token: 0x0600A04F RID: 41039
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation2D_GetLabelProperty_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the properties for the label and title text.
		/// </summary>
		// Token: 0x0600A050 RID: 41040 RVA: 0x000E3898 File Offset: 0x000E1A98
		public virtual vtkTextProperty GetLabelProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderRepresentation2D.vtkSliderRepresentation2D_GetLabelProperty_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A051 RID: 41041
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSliderRepresentation2D_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600A052 RID: 41042 RVA: 0x000E3908 File Offset: 0x000E1B08
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSliderRepresentation2D.vtkSliderRepresentation2D_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600A053 RID: 41043
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSliderRepresentation2D_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600A054 RID: 41044 RVA: 0x000E3928 File Offset: 0x000E1B28
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSliderRepresentation2D.vtkSliderRepresentation2D_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600A055 RID: 41045
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation2D_GetPoint1Coordinate_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Position the first end point of the slider. Note that this point is an
		/// instance of vtkCoordinate, meaning that Point 1 can be specified in a
		/// variety of coordinate systems, and can even be relative to another
		/// point. To set the point, you'll want to get the Point1Coordinate and
		/// then invoke the necessary methods to put it into the correct coordinate
		/// system and set the correct initial value.
		/// </summary>
		// Token: 0x0600A056 RID: 41046 RVA: 0x000E3944 File Offset: 0x000E1B44
		public vtkCoordinate GetPoint1Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderRepresentation2D.vtkSliderRepresentation2D_GetPoint1Coordinate_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		// Token: 0x0600A057 RID: 41047
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation2D_GetPoint2Coordinate_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Position the second end point of the slider. Note that this point is an
		/// instance of vtkCoordinate, meaning that Point 1 can be specified in a
		/// variety of coordinate systems, and can even be relative to another
		/// point. To set the point, you'll want to get the Point2Coordinate and
		/// then invoke the necessary methods to put it into the correct coordinate
		/// system and set the correct initial value.
		/// </summary>
		// Token: 0x0600A058 RID: 41048 RVA: 0x000E39B4 File Offset: 0x000E1BB4
		public vtkCoordinate GetPoint2Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderRepresentation2D.vtkSliderRepresentation2D_GetPoint2Coordinate_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		// Token: 0x0600A059 RID: 41049
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation2D_GetSelectedProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the selection property. This property is used to modify the appearance of
		/// selected objects (e.g., the slider).
		/// </summary>
		// Token: 0x0600A05A RID: 41050 RVA: 0x000E3A24 File Offset: 0x000E1C24
		public virtual vtkProperty2D GetSelectedProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderRepresentation2D.vtkSliderRepresentation2D_GetSelectedProperty_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		// Token: 0x0600A05B RID: 41051
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation2D_GetSliderProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the slider properties. The properties of the slider when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x0600A05C RID: 41052 RVA: 0x000E3A94 File Offset: 0x000E1C94
		public virtual vtkProperty2D GetSliderProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderRepresentation2D.vtkSliderRepresentation2D_GetSliderProperty_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		// Token: 0x0600A05D RID: 41053
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation2D_GetTitleProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the properties for the label and title text.
		/// </summary>
		// Token: 0x0600A05E RID: 41054 RVA: 0x000E3B04 File Offset: 0x000E1D04
		public virtual vtkTextProperty GetTitleProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderRepresentation2D.vtkSliderRepresentation2D_GetTitleProperty_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A05F RID: 41055
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation2D_GetTitleText_12(HandleRef pThis);

		/// <summary>
		/// Specify the label text for this widget. If the value is not set, or set
		/// to the empty string "", then the label text is not displayed.
		/// </summary>
		// Token: 0x0600A060 RID: 41056 RVA: 0x000E3B74 File Offset: 0x000E1D74
		public override string GetTitleText()
		{
			string s = Marshal.PtrToStringAnsi(vtkSliderRepresentation2D.vtkSliderRepresentation2D_GetTitleText_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600A061 RID: 41057
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation2D_GetTubeProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties for the tube and end caps.
		/// </summary>
		// Token: 0x0600A062 RID: 41058 RVA: 0x000E3BB0 File Offset: 0x000E1DB0
		public virtual vtkProperty2D GetTubeProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderRepresentation2D.vtkSliderRepresentation2D_GetTubeProperty_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		// Token: 0x0600A063 RID: 41059
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation2D_Highlight_14(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display space
		/// where the widget should be placed.
		/// </summary>
		// Token: 0x0600A064 RID: 41060 RVA: 0x000E3C1F File Offset: 0x000E1E1F
		public override void Highlight(int arg0)
		{
			vtkSliderRepresentation2D.vtkSliderRepresentation2D_Highlight_14(base.GetCppThis(), arg0);
		}

		// Token: 0x0600A065 RID: 41061
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderRepresentation2D_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600A066 RID: 41062 RVA: 0x000E3C30 File Offset: 0x000E1E30
		public override int IsA(string type)
		{
			return vtkSliderRepresentation2D.vtkSliderRepresentation2D_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x0600A067 RID: 41063
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderRepresentation2D_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600A068 RID: 41064 RVA: 0x000E3C50 File Offset: 0x000E1E50
		public new static int IsTypeOf(string type)
		{
			return vtkSliderRepresentation2D.vtkSliderRepresentation2D_IsTypeOf_16(type);
		}

		// Token: 0x0600A069 RID: 41065
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation2D_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600A06A RID: 41066 RVA: 0x000E3C6C File Offset: 0x000E1E6C
		public new vtkSliderRepresentation2D NewInstance()
		{
			vtkSliderRepresentation2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderRepresentation2D.vtkSliderRepresentation2D_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSliderRepresentation2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A06B RID: 41067
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation2D_PlaceWidget_19(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display space
		/// where the widget should be placed.
		/// </summary>
		// Token: 0x0600A06C RID: 41068 RVA: 0x000E3CC6 File Offset: 0x000E1EC6
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkSliderRepresentation2D.vtkSliderRepresentation2D_PlaceWidget_19(base.GetCppThis(), bounds);
		}

		// Token: 0x0600A06D RID: 41069
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation2D_ReleaseGraphicsResources_20(HandleRef pThis, HandleRef window);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600A06E RID: 41070 RVA: 0x000E3CD8 File Offset: 0x000E1ED8
		public override void ReleaseGraphicsResources(vtkWindow window)
		{
			vtkSliderRepresentation2D.vtkSliderRepresentation2D_ReleaseGraphicsResources_20(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		// Token: 0x0600A06F RID: 41071
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderRepresentation2D_RenderOpaqueGeometry_21(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600A070 RID: 41072 RVA: 0x000E3D08 File Offset: 0x000E1F08
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkSliderRepresentation2D.vtkSliderRepresentation2D_RenderOpaqueGeometry_21(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600A071 RID: 41073
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderRepresentation2D_RenderOverlay_22(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600A072 RID: 41074 RVA: 0x000E3D3C File Offset: 0x000E1F3C
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkSliderRepresentation2D.vtkSliderRepresentation2D_RenderOverlay_22(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600A073 RID: 41075
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation2D_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600A074 RID: 41076 RVA: 0x000E3D70 File Offset: 0x000E1F70
		public new static vtkSliderRepresentation2D SafeDownCast(vtkObjectBase o)
		{
			vtkSliderRepresentation2D vtkSliderRepresentation2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderRepresentation2D.vtkSliderRepresentation2D_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSliderRepresentation2D = (vtkSliderRepresentation2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSliderRepresentation2D.Register(null);
				}
			}
			return vtkSliderRepresentation2D;
		}

		// Token: 0x0600A075 RID: 41077
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation2D_SetTitleText_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Specify the label text for this widget. If the value is not set, or set
		/// to the empty string "", then the label text is not displayed.
		/// </summary>
		// Token: 0x0600A076 RID: 41078 RVA: 0x000E3DEF File Offset: 0x000E1FEF
		public override void SetTitleText(string arg0)
		{
			vtkSliderRepresentation2D.vtkSliderRepresentation2D_SetTitleText_24(base.GetCppThis(), arg0);
		}

		// Token: 0x0600A077 RID: 41079
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation2D_StartWidgetInteraction_25(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display space
		/// where the widget should be placed.
		/// </summary>
		// Token: 0x0600A078 RID: 41080 RVA: 0x000E3DFF File Offset: 0x000E1FFF
		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkSliderRepresentation2D.vtkSliderRepresentation2D_StartWidgetInteraction_25(base.GetCppThis(), eventPos);
		}

		// Token: 0x0600A079 RID: 41081
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation2D_WidgetInteraction_26(HandleRef pThis, IntPtr newEventPos);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display space
		/// where the widget should be placed.
		/// </summary>
		// Token: 0x0600A07A RID: 41082 RVA: 0x000E3E0F File Offset: 0x000E200F
		public override void WidgetInteraction(IntPtr newEventPos)
		{
			vtkSliderRepresentation2D.vtkSliderRepresentation2D_WidgetInteraction_26(base.GetCppThis(), newEventPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CF4 RID: 3316
		public new const string MRFullTypeName = "Kitware.VTK.vtkSliderRepresentation2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CF5 RID: 3317
		public new static readonly string MRClassNameKey = "class vtkSliderRepresentation2D";
	}
}
