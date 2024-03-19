using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBiDimensionalRepresentation2D
	/// </summary>
	/// <remarks>
	///    represent the vtkBiDimensionalWidget
	///
	/// The vtkBiDimensionalRepresentation2D is used to represent the
	/// bi-dimensional measure in a 2D (overlay) context. This representation
	/// consists of two perpendicular lines defined by four
	/// vtkHandleRepresentations. The four handles can be independently
	/// manipulated consistent with the orthogonal constraint on the lines. (Note:
	/// the four points are referred to as Point1, Point2, Point3 and
	/// Point4. Point1 and Point2 define the first line; and Point3 and Point4
	/// define the second orthogonal line.)
	///
	/// To create this widget, you click to place the first two points. The third
	/// point is mirrored with the fourth point; when you place the third point
	/// (which is orthogonal to the lined defined by the first two points), the
	/// fourth point is dropped as well. After definition, the four points can be
	/// moved (in constrained fashion, preserving orthogonality). Further, the
	/// entire widget can be translated by grabbing the center point of the widget;
	/// each line can be moved along the other line; and the entire widget can be
	/// rotated around its center point.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAngleWidget vtkHandleRepresentation vtkBiDimensionalRepresentation
	/// </seealso>
	// Token: 0x020002C9 RID: 713
	public class vtkBiDimensionalRepresentation2D : vtkBiDimensionalRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008081 RID: 32897 RVA: 0x000B847D File Offset: 0x000B667D
		static vtkBiDimensionalRepresentation2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBiDimensionalRepresentation2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBiDimensionalRepresentation2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008082 RID: 32898 RVA: 0x000B84A5 File Offset: 0x000B66A5
		public vtkBiDimensionalRepresentation2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008083 RID: 32899
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiDimensionalRepresentation2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06008084 RID: 32900 RVA: 0x000B84B4 File Offset: 0x000B66B4
		public new static vtkBiDimensionalRepresentation2D New()
		{
			vtkBiDimensionalRepresentation2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiDimensionalRepresentation2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06008085 RID: 32901 RVA: 0x000B8508 File Offset: 0x000B6708
		public vtkBiDimensionalRepresentation2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008086 RID: 32902 RVA: 0x000B854C File Offset: 0x000B674C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008087 RID: 32903
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation2D_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008088 RID: 32904 RVA: 0x000B8557 File Offset: 0x000B6757
		public override void BuildRepresentation()
		{
			vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06008089 RID: 32905
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiDimensionalRepresentation2D_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x0600808A RID: 32906 RVA: 0x000B8568 File Offset: 0x000B6768
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x0600808B RID: 32907
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiDimensionalRepresentation2D_GetLabelPosition_03(HandleRef pThis);

		/// <summary>
		/// Get the position of the widget's label in display coordinates.
		/// </summary>
		// Token: 0x0600808C RID: 32908 RVA: 0x000B858C File Offset: 0x000B678C
		public override IntPtr GetLabelPosition()
		{
			return vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_GetLabelPosition_03(base.GetCppThis());
		}

		// Token: 0x0600808D RID: 32909
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation2D_GetLabelPosition_04(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Get the position of the widget's label in display coordinates.
		/// </summary>
		// Token: 0x0600808E RID: 32910 RVA: 0x000B85AB File Offset: 0x000B67AB
		public override void GetLabelPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_GetLabelPosition_04(base.GetCppThis(), pos);
		}

		// Token: 0x0600808F RID: 32911
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiDimensionalRepresentation2D_GetLabelText_05(HandleRef pThis);

		/// <summary>
		/// Get the text shown in the widget's label.
		/// </summary>
		// Token: 0x06008090 RID: 32912 RVA: 0x000B85BC File Offset: 0x000B67BC
		public override string GetLabelText()
		{
			string s = Marshal.PtrToStringAnsi(vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_GetLabelText_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06008091 RID: 32913
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiDimensionalRepresentation2D_GetLineProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve the property used to control the appearance of the two
		/// orthogonal lines.
		/// </summary>
		// Token: 0x06008092 RID: 32914 RVA: 0x000B85F8 File Offset: 0x000B67F8
		public virtual vtkProperty2D GetLineProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_GetLineProperty_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008093 RID: 32915
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBiDimensionalRepresentation2D_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008094 RID: 32916 RVA: 0x000B8668 File Offset: 0x000B6868
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06008095 RID: 32917
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBiDimensionalRepresentation2D_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008096 RID: 32918 RVA: 0x000B8688 File Offset: 0x000B6888
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06008097 RID: 32919
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiDimensionalRepresentation2D_GetSelectedLineProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve the property used to control the appearance of the two
		/// orthogonal lines.
		/// </summary>
		// Token: 0x06008098 RID: 32920 RVA: 0x000B86A4 File Offset: 0x000B68A4
		public virtual vtkProperty2D GetSelectedLineProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_GetSelectedLineProperty_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008099 RID: 32921
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiDimensionalRepresentation2D_GetTextProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve the property used to control the appearance of the text
		/// labels.
		/// </summary>
		// Token: 0x0600809A RID: 32922 RVA: 0x000B8714 File Offset: 0x000B6914
		public virtual vtkTextProperty GetTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_GetTextProperty_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600809B RID: 32923
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation2D_GetWorldLabelPosition_11(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Get the position of the widget's label in display coordinates.
		/// </summary>
		// Token: 0x0600809C RID: 32924 RVA: 0x000B8783 File Offset: 0x000B6983
		public override void GetWorldLabelPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_GetWorldLabelPosition_11(base.GetCppThis(), pos);
		}

		// Token: 0x0600809D RID: 32925
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation2D_Highlight_12(HandleRef pThis, int highlightOn);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x0600809E RID: 32926 RVA: 0x000B8793 File Offset: 0x000B6993
		public override void Highlight(int highlightOn)
		{
			vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_Highlight_12(base.GetCppThis(), highlightOn);
		}

		// Token: 0x0600809F RID: 32927
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiDimensionalRepresentation2D_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x060080A0 RID: 32928 RVA: 0x000B87A4 File Offset: 0x000B69A4
		public override int IsA(string type)
		{
			return vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x060080A1 RID: 32929
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiDimensionalRepresentation2D_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x060080A2 RID: 32930 RVA: 0x000B87C4 File Offset: 0x000B69C4
		public new static int IsTypeOf(string type)
		{
			return vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_IsTypeOf_14(type);
		}

		// Token: 0x060080A3 RID: 32931
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiDimensionalRepresentation2D_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x060080A4 RID: 32932 RVA: 0x000B87E0 File Offset: 0x000B69E0
		public new vtkBiDimensionalRepresentation2D NewInstance()
		{
			vtkBiDimensionalRepresentation2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiDimensionalRepresentation2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060080A5 RID: 32933
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation2D_Point2WidgetInteraction_17(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x060080A6 RID: 32934 RVA: 0x000B883A File Offset: 0x000B6A3A
		public override void Point2WidgetInteraction(IntPtr e)
		{
			vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_Point2WidgetInteraction_17(base.GetCppThis(), e);
		}

		// Token: 0x060080A7 RID: 32935
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation2D_Point3WidgetInteraction_18(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x060080A8 RID: 32936 RVA: 0x000B884A File Offset: 0x000B6A4A
		public override void Point3WidgetInteraction(IntPtr e)
		{
			vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_Point3WidgetInteraction_18(base.GetCppThis(), e);
		}

		// Token: 0x060080A9 RID: 32937
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation2D_ReleaseGraphicsResources_19(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x060080AA RID: 32938 RVA: 0x000B885C File Offset: 0x000B6A5C
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_ReleaseGraphicsResources_19(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x060080AB RID: 32939
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiDimensionalRepresentation2D_RenderOverlay_20(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x060080AC RID: 32940 RVA: 0x000B888C File Offset: 0x000B6A8C
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_RenderOverlay_20(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060080AD RID: 32941
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiDimensionalRepresentation2D_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x060080AE RID: 32942 RVA: 0x000B88C0 File Offset: 0x000B6AC0
		public new static vtkBiDimensionalRepresentation2D SafeDownCast(vtkObjectBase o)
		{
			vtkBiDimensionalRepresentation2D vtkBiDimensionalRepresentation2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBiDimensionalRepresentation2D = (vtkBiDimensionalRepresentation2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBiDimensionalRepresentation2D.Register(null);
				}
			}
			return vtkBiDimensionalRepresentation2D;
		}

		// Token: 0x060080AF RID: 32943
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation2D_StartWidgetDefinition_22(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x060080B0 RID: 32944 RVA: 0x000B893F File Offset: 0x000B6B3F
		public override void StartWidgetDefinition(IntPtr e)
		{
			vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_StartWidgetDefinition_22(base.GetCppThis(), e);
		}

		// Token: 0x060080B1 RID: 32945
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation2D_StartWidgetManipulation_23(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x060080B2 RID: 32946 RVA: 0x000B894F File Offset: 0x000B6B4F
		public override void StartWidgetManipulation(IntPtr e)
		{
			vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_StartWidgetManipulation_23(base.GetCppThis(), e);
		}

		// Token: 0x060080B3 RID: 32947
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation2D_WidgetInteraction_24(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x060080B4 RID: 32948 RVA: 0x000B895F File Offset: 0x000B6B5F
		public override void WidgetInteraction(IntPtr e)
		{
			vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_WidgetInteraction_24(base.GetCppThis(), e);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ADD RID: 2781
		public new const string MRFullTypeName = "Kitware.VTK.vtkBiDimensionalRepresentation2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ADE RID: 2782
		public new static readonly string MRClassNameKey = "class vtkBiDimensionalRepresentation2D";

		/// <summary>
		/// Retrieve the property used to control the appearance of the text
		/// labels.
		/// </summary>
		// Token: 0x020002CA RID: 714
		public new enum NearP1_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000AE0 RID: 2784
			NearP1 = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000AE1 RID: 2785
			NearP2,
			/// <summary>enum member</summary>
			// Token: 0x04000AE2 RID: 2786
			NearP3,
			/// <summary>enum member</summary>
			// Token: 0x04000AE3 RID: 2787
			NearP4,
			/// <summary>enum member</summary>
			// Token: 0x04000AE4 RID: 2788
			OnCenter = 9,
			/// <summary>enum member</summary>
			// Token: 0x04000AE5 RID: 2789
			OnL1Inner = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000AE6 RID: 2790
			OnL1Outer,
			/// <summary>enum member</summary>
			// Token: 0x04000AE7 RID: 2791
			OnL2Inner,
			/// <summary>enum member</summary>
			// Token: 0x04000AE8 RID: 2792
			OnL2Outer,
			/// <summary>enum member</summary>
			// Token: 0x04000AE9 RID: 2793
			Outside = 0
		}
	}
}
