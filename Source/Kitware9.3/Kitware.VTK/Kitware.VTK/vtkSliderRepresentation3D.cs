using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSliderRepresentation3D
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
	// Token: 0x02000376 RID: 886
	public class vtkSliderRepresentation3D : vtkSliderRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A07B RID: 41083 RVA: 0x000E3E1F File Offset: 0x000E201F
		static vtkSliderRepresentation3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSliderRepresentation3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSliderRepresentation3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A07C RID: 41084 RVA: 0x000E3E47 File Offset: 0x000E2047
		public vtkSliderRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A07D RID: 41085
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0600A07E RID: 41086 RVA: 0x000E3E58 File Offset: 0x000E2058
		public new static vtkSliderRepresentation3D New()
		{
			vtkSliderRepresentation3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderRepresentation3D.vtkSliderRepresentation3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSliderRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0600A07F RID: 41087 RVA: 0x000E3EAC File Offset: 0x000E20AC
		public vtkSliderRepresentation3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSliderRepresentation3D.vtkSliderRepresentation3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A080 RID: 41088 RVA: 0x000E3EF0 File Offset: 0x000E20F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A081 RID: 41089
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation3D_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget.
		/// </summary>
		// Token: 0x0600A082 RID: 41090 RVA: 0x000E3EFB File Offset: 0x000E20FB
		public override void BuildRepresentation()
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x0600A083 RID: 41091
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation3D_GetActors_02(HandleRef pThis, HandleRef propCollection);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600A084 RID: 41092 RVA: 0x000E3F0C File Offset: 0x000E210C
		public override void GetActors(vtkPropCollection propCollection)
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetActors_02(base.GetCppThis(), (propCollection == null) ? default(HandleRef) : propCollection.GetCppThis());
		}

		// Token: 0x0600A085 RID: 41093
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation3D_GetBounds_03(HandleRef pThis);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600A086 RID: 41094 RVA: 0x000E3F3C File Offset: 0x000E213C
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A087 RID: 41095
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation3D_GetCapProperty_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties for the tube and end caps.
		/// </summary>
		// Token: 0x0600A088 RID: 41096 RVA: 0x000E3F84 File Offset: 0x000E2184
		public virtual vtkProperty GetCapProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetCapProperty_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A089 RID: 41097
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkSliderRepresentation3D_GetMTime_05(HandleRef pThis);

		/// <summary>
		/// Override GetMTime to include point coordinates
		/// </summary>
		// Token: 0x0600A08A RID: 41098 RVA: 0x000E3FF4 File Offset: 0x000E21F4
		public override ulong GetMTime()
		{
			return vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetMTime_05(base.GetCppThis());
		}

		// Token: 0x0600A08B RID: 41099
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSliderRepresentation3D_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600A08C RID: 41100 RVA: 0x000E4014 File Offset: 0x000E2214
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600A08D RID: 41101
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSliderRepresentation3D_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600A08E RID: 41102 RVA: 0x000E4034 File Offset: 0x000E2234
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600A08F RID: 41103
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation3D_GetPoint1Coordinate_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Position the first end point of the slider. Note that this point is an
		/// instance of vtkCoordinate, meaning that Point 1 can be specified in a
		/// variety of coordinate systems, and can even be relative to another
		/// point. To set the point, you'll want to get the Point1Coordinate and
		/// then invoke the necessary methods to put it into the correct coordinate
		/// system and set the correct initial value.
		/// </summary>
		// Token: 0x0600A090 RID: 41104 RVA: 0x000E4050 File Offset: 0x000E2250
		public vtkCoordinate GetPoint1Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetPoint1Coordinate_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A091 RID: 41105
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation3D_GetPoint2Coordinate_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Position the second end point of the slider. Note that this point is an
		/// instance of vtkCoordinate, meaning that Point 1 can be specified in a
		/// variety of coordinate systems, and can even be relative to another
		/// point. To set the point, you'll want to get the Point2Coordinate and
		/// then invoke the necessary methods to put it into the correct coordinate
		/// system and set the correct initial value.
		/// </summary>
		// Token: 0x0600A092 RID: 41106 RVA: 0x000E40C0 File Offset: 0x000E22C0
		public vtkCoordinate GetPoint2Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetPoint2Coordinate_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A093 RID: 41107
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation3D_GetRotation_10(HandleRef pThis);

		/// <summary>
		/// Set the rotation of the slider widget around the axis of the widget. This is
		/// used to control which way the widget is initially oriented. (This is especially
		/// important for the label and title.)
		/// </summary>
		// Token: 0x0600A094 RID: 41108 RVA: 0x000E4130 File Offset: 0x000E2330
		public virtual double GetRotation()
		{
			return vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetRotation_10(base.GetCppThis());
		}

		// Token: 0x0600A095 RID: 41109
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation3D_GetSelectedProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the selection property. This property is used to modify the appearance of
		/// selected objects (e.g., the slider).
		/// </summary>
		// Token: 0x0600A096 RID: 41110 RVA: 0x000E4150 File Offset: 0x000E2350
		public virtual vtkProperty GetSelectedProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetSelectedProperty_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A097 RID: 41111
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation3D_GetSliderProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the slider properties. The properties of the slider when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x0600A098 RID: 41112 RVA: 0x000E41C0 File Offset: 0x000E23C0
		public virtual vtkProperty GetSliderProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetSliderProperty_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A099 RID: 41113
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderRepresentation3D_GetSliderShape_13(HandleRef pThis);

		/// <summary>
		/// Specify whether to use a sphere or cylinder slider shape. By default, a
		/// sphere shape is used.
		/// </summary>
		// Token: 0x0600A09A RID: 41114 RVA: 0x000E4230 File Offset: 0x000E2430
		public virtual int GetSliderShape()
		{
			return vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetSliderShape_13(base.GetCppThis());
		}

		// Token: 0x0600A09B RID: 41115
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderRepresentation3D_GetSliderShapeMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Specify whether to use a sphere or cylinder slider shape. By default, a
		/// sphere shape is used.
		/// </summary>
		// Token: 0x0600A09C RID: 41116 RVA: 0x000E4250 File Offset: 0x000E2450
		public virtual int GetSliderShapeMaxValue()
		{
			return vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetSliderShapeMaxValue_14(base.GetCppThis());
		}

		// Token: 0x0600A09D RID: 41117
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderRepresentation3D_GetSliderShapeMinValue_15(HandleRef pThis);

		/// <summary>
		/// Specify whether to use a sphere or cylinder slider shape. By default, a
		/// sphere shape is used.
		/// </summary>
		// Token: 0x0600A09E RID: 41118 RVA: 0x000E4270 File Offset: 0x000E2470
		public virtual int GetSliderShapeMinValue()
		{
			return vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetSliderShapeMinValue_15(base.GetCppThis());
		}

		// Token: 0x0600A09F RID: 41119
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation3D_GetTitleText_16(HandleRef pThis);

		/// <summary>
		/// Specify the title text for this widget. If the value is not set, or set
		/// to the empty string "", then the title text is not displayed.
		/// </summary>
		// Token: 0x0600A0A0 RID: 41120 RVA: 0x000E4290 File Offset: 0x000E2490
		public override string GetTitleText()
		{
			string s = Marshal.PtrToStringAnsi(vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetTitleText_16(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600A0A1 RID: 41121
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation3D_GetTubeProperty_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties for the tube and end caps.
		/// </summary>
		// Token: 0x0600A0A2 RID: 41122 RVA: 0x000E42CC File Offset: 0x000E24CC
		public virtual vtkProperty GetTubeProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetTubeProperty_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A0A3 RID: 41123
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderRepresentation3D_HasTranslucentPolygonalGeometry_18(HandleRef pThis);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600A0A4 RID: 41124 RVA: 0x000E433C File Offset: 0x000E253C
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkSliderRepresentation3D.vtkSliderRepresentation3D_HasTranslucentPolygonalGeometry_18(base.GetCppThis());
		}

		// Token: 0x0600A0A5 RID: 41125
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation3D_Highlight_19(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget.
		/// </summary>
		// Token: 0x0600A0A6 RID: 41126 RVA: 0x000E435B File Offset: 0x000E255B
		public override void Highlight(int arg0)
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_Highlight_19(base.GetCppThis(), arg0);
		}

		// Token: 0x0600A0A7 RID: 41127
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderRepresentation3D_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600A0A8 RID: 41128 RVA: 0x000E436C File Offset: 0x000E256C
		public override int IsA(string type)
		{
			return vtkSliderRepresentation3D.vtkSliderRepresentation3D_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x0600A0A9 RID: 41129
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderRepresentation3D_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600A0AA RID: 41130 RVA: 0x000E438C File Offset: 0x000E258C
		public new static int IsTypeOf(string type)
		{
			return vtkSliderRepresentation3D.vtkSliderRepresentation3D_IsTypeOf_21(type);
		}

		// Token: 0x0600A0AB RID: 41131
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation3D_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600A0AC RID: 41132 RVA: 0x000E43A8 File Offset: 0x000E25A8
		public new vtkSliderRepresentation3D NewInstance()
		{
			vtkSliderRepresentation3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderRepresentation3D.vtkSliderRepresentation3D_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSliderRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A0AD RID: 41133
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation3D_PlaceWidget_24(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget.
		/// </summary>
		// Token: 0x0600A0AE RID: 41134 RVA: 0x000E4402 File Offset: 0x000E2602
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_PlaceWidget_24(base.GetCppThis(), bounds);
		}

		// Token: 0x0600A0AF RID: 41135
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation3D_RegisterPickers_25(HandleRef pThis);

		/// <summary>
		/// Override GetMTime to include point coordinates
		/// </summary>
		// Token: 0x0600A0B0 RID: 41136 RVA: 0x000E4412 File Offset: 0x000E2612
		public override void RegisterPickers()
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_RegisterPickers_25(base.GetCppThis());
		}

		// Token: 0x0600A0B1 RID: 41137
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation3D_ReleaseGraphicsResources_26(HandleRef pThis, HandleRef window);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600A0B2 RID: 41138 RVA: 0x000E4424 File Offset: 0x000E2624
		public override void ReleaseGraphicsResources(vtkWindow window)
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_ReleaseGraphicsResources_26(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		// Token: 0x0600A0B3 RID: 41139
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderRepresentation3D_RenderOpaqueGeometry_27(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600A0B4 RID: 41140 RVA: 0x000E4454 File Offset: 0x000E2654
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkSliderRepresentation3D.vtkSliderRepresentation3D_RenderOpaqueGeometry_27(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600A0B5 RID: 41141
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderRepresentation3D_RenderTranslucentPolygonalGeometry_28(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600A0B6 RID: 41142 RVA: 0x000E4488 File Offset: 0x000E2688
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkSliderRepresentation3D.vtkSliderRepresentation3D_RenderTranslucentPolygonalGeometry_28(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600A0B7 RID: 41143
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation3D_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600A0B8 RID: 41144 RVA: 0x000E44BC File Offset: 0x000E26BC
		public new static vtkSliderRepresentation3D SafeDownCast(vtkObjectBase o)
		{
			vtkSliderRepresentation3D vtkSliderRepresentation3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderRepresentation3D.vtkSliderRepresentation3D_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSliderRepresentation3D = (vtkSliderRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSliderRepresentation3D.Register(null);
				}
			}
			return vtkSliderRepresentation3D;
		}

		// Token: 0x0600A0B9 RID: 41145
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation3D_SetPoint1InWorldCoordinates_30(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Position the first end point of the slider. Note that this point is an
		/// instance of vtkCoordinate, meaning that Point 1 can be specified in a
		/// variety of coordinate systems, and can even be relative to another
		/// point. To set the point, you'll want to get the Point1Coordinate and
		/// then invoke the necessary methods to put it into the correct coordinate
		/// system and set the correct initial value.
		/// </summary>
		// Token: 0x0600A0BA RID: 41146 RVA: 0x000E453B File Offset: 0x000E273B
		public void SetPoint1InWorldCoordinates(double x, double y, double z)
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_SetPoint1InWorldCoordinates_30(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600A0BB RID: 41147
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation3D_SetPoint2InWorldCoordinates_31(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Position the second end point of the slider. Note that this point is an
		/// instance of vtkCoordinate, meaning that Point 1 can be specified in a
		/// variety of coordinate systems, and can even be relative to another
		/// point. To set the point, you'll want to get the Point2Coordinate and
		/// then invoke the necessary methods to put it into the correct coordinate
		/// system and set the correct initial value.
		/// </summary>
		// Token: 0x0600A0BC RID: 41148 RVA: 0x000E454D File Offset: 0x000E274D
		public void SetPoint2InWorldCoordinates(double x, double y, double z)
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_SetPoint2InWorldCoordinates_31(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600A0BD RID: 41149
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation3D_SetRotation_32(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the rotation of the slider widget around the axis of the widget. This is
		/// used to control which way the widget is initially oriented. (This is especially
		/// important for the label and title.)
		/// </summary>
		// Token: 0x0600A0BE RID: 41150 RVA: 0x000E455F File Offset: 0x000E275F
		public virtual void SetRotation(double _arg)
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_SetRotation_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A0BF RID: 41151
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation3D_SetSliderShape_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether to use a sphere or cylinder slider shape. By default, a
		/// sphere shape is used.
		/// </summary>
		// Token: 0x0600A0C0 RID: 41152 RVA: 0x000E456F File Offset: 0x000E276F
		public virtual void SetSliderShape(int _arg)
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_SetSliderShape_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A0C1 RID: 41153
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation3D_SetSliderShapeToCylinder_34(HandleRef pThis);

		/// <summary>
		/// Specify whether to use a sphere or cylinder slider shape. By default, a
		/// sphere shape is used.
		/// </summary>
		// Token: 0x0600A0C2 RID: 41154 RVA: 0x000E457F File Offset: 0x000E277F
		public void SetSliderShapeToCylinder()
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_SetSliderShapeToCylinder_34(base.GetCppThis());
		}

		// Token: 0x0600A0C3 RID: 41155
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation3D_SetSliderShapeToSphere_35(HandleRef pThis);

		/// <summary>
		/// Specify whether to use a sphere or cylinder slider shape. By default, a
		/// sphere shape is used.
		/// </summary>
		// Token: 0x0600A0C4 RID: 41156 RVA: 0x000E458E File Offset: 0x000E278E
		public void SetSliderShapeToSphere()
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_SetSliderShapeToSphere_35(base.GetCppThis());
		}

		// Token: 0x0600A0C5 RID: 41157
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation3D_SetTitleText_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Specify the title text for this widget. If the value is not set, or set
		/// to the empty string "", then the title text is not displayed.
		/// </summary>
		// Token: 0x0600A0C6 RID: 41158 RVA: 0x000E459D File Offset: 0x000E279D
		public override void SetTitleText(string arg0)
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_SetTitleText_36(base.GetCppThis(), arg0);
		}

		// Token: 0x0600A0C7 RID: 41159
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation3D_StartWidgetInteraction_37(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget.
		/// </summary>
		// Token: 0x0600A0C8 RID: 41160 RVA: 0x000E45AD File Offset: 0x000E27AD
		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_StartWidgetInteraction_37(base.GetCppThis(), eventPos);
		}

		// Token: 0x0600A0C9 RID: 41161
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation3D_WidgetInteraction_38(HandleRef pThis, IntPtr newEventPos);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget.
		/// </summary>
		// Token: 0x0600A0CA RID: 41162 RVA: 0x000E45BD File Offset: 0x000E27BD
		public override void WidgetInteraction(IntPtr newEventPos)
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_WidgetInteraction_38(base.GetCppThis(), newEventPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CF6 RID: 3318
		public new const string MRFullTypeName = "Kitware.VTK.vtkSliderRepresentation3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CF7 RID: 3319
		public new static readonly string MRClassNameKey = "class vtkSliderRepresentation3D";
	}
}
