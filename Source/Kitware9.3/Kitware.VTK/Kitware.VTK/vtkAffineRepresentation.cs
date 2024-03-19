using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAffineRepresentation
	/// </summary>
	/// <remarks>
	///    abstract class for representing affine transformation widgets
	///
	/// This class defines an API for affine transformation widget
	/// representations. These representations interact with vtkAffineWidget. The
	/// basic functionality of the affine representation is to maintain a
	/// transformation matrix.
	///
	/// This class may be subclassed so that alternative representations can
	/// be created.  The class defines an API and a default implementation that
	/// the vtkAffineWidget interacts with to render itself in the scene.
	///
	/// @warning
	/// The separation of the widget event handling and representation enables
	/// users and developers to create new appearances for the widget. It also
	/// facilitates parallel processing, where the client application handles
	/// events, and remote representations of the widget are slaves to the
	/// client (and do not handle events).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAffineWidget vtkWidgetRepresentation vtkAbstractWidget
	/// </seealso>
	// Token: 0x020002B3 RID: 691
	public abstract class vtkAffineRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007D23 RID: 32035 RVA: 0x000B3B7F File Offset: 0x000B1D7F
		static vtkAffineRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAffineRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAffineRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007D24 RID: 32036 RVA: 0x000B3BA7 File Offset: 0x000B1DA7
		public vtkAffineRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007D25 RID: 32037 RVA: 0x000B3BB5 File Offset: 0x000B1DB5
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007D26 RID: 32038
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAffineRepresentation_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007D27 RID: 32039 RVA: 0x000B3BC0 File Offset: 0x000B1DC0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAffineRepresentation.vtkAffineRepresentation_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06007D28 RID: 32040
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAffineRepresentation_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007D29 RID: 32041 RVA: 0x000B3BE0 File Offset: 0x000B1DE0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAffineRepresentation.vtkAffineRepresentation_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06007D2A RID: 32042
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAffineRepresentation_GetTolerance_03(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels)
		/// in which the cursor is considered near enough to the widget to
		/// be active.
		/// </summary>
		// Token: 0x06007D2B RID: 32043 RVA: 0x000B3BFC File Offset: 0x000B1DFC
		public virtual int GetTolerance()
		{
			return vtkAffineRepresentation.vtkAffineRepresentation_GetTolerance_03(base.GetCppThis());
		}

		// Token: 0x06007D2C RID: 32044
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAffineRepresentation_GetToleranceMaxValue_04(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels)
		/// in which the cursor is considered near enough to the widget to
		/// be active.
		/// </summary>
		// Token: 0x06007D2D RID: 32045 RVA: 0x000B3C1C File Offset: 0x000B1E1C
		public virtual int GetToleranceMaxValue()
		{
			return vtkAffineRepresentation.vtkAffineRepresentation_GetToleranceMaxValue_04(base.GetCppThis());
		}

		// Token: 0x06007D2E RID: 32046
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAffineRepresentation_GetToleranceMinValue_05(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels)
		/// in which the cursor is considered near enough to the widget to
		/// be active.
		/// </summary>
		// Token: 0x06007D2F RID: 32047 RVA: 0x000B3C3C File Offset: 0x000B1E3C
		public virtual int GetToleranceMinValue()
		{
			return vtkAffineRepresentation.vtkAffineRepresentation_GetToleranceMinValue_05(base.GetCppThis());
		}

		// Token: 0x06007D30 RID: 32048
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAffineRepresentation_GetTransform_06(HandleRef pThis, HandleRef t);

		/// <summary>
		/// Retrieve a linear transform characterizing the affine transformation
		/// generated by this widget. This method copies its internal transform into
		/// the transform provided. The transform is relative to the initial placement
		/// of the representation (i.e., when PlaceWidget() is invoked).
		/// </summary>
		// Token: 0x06007D31 RID: 32049 RVA: 0x000B3C5C File Offset: 0x000B1E5C
		public virtual void GetTransform(vtkTransform t)
		{
			vtkAffineRepresentation.vtkAffineRepresentation_GetTransform_06(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		// Token: 0x06007D32 RID: 32050
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAffineRepresentation_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007D33 RID: 32051 RVA: 0x000B3C8C File Offset: 0x000B1E8C
		public override int IsA(string type)
		{
			return vtkAffineRepresentation.vtkAffineRepresentation_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06007D34 RID: 32052
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAffineRepresentation_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007D35 RID: 32053 RVA: 0x000B3CAC File Offset: 0x000B1EAC
		public new static int IsTypeOf(string type)
		{
			return vtkAffineRepresentation.vtkAffineRepresentation_IsTypeOf_08(type);
		}

		// Token: 0x06007D36 RID: 32054
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAffineRepresentation_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007D37 RID: 32055 RVA: 0x000B3CC8 File Offset: 0x000B1EC8
		public new vtkAffineRepresentation NewInstance()
		{
			vtkAffineRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAffineRepresentation.vtkAffineRepresentation_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAffineRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007D38 RID: 32056
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAffineRepresentation_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007D39 RID: 32057 RVA: 0x000B3D24 File Offset: 0x000B1F24
		public new static vtkAffineRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkAffineRepresentation vtkAffineRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAffineRepresentation.vtkAffineRepresentation_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAffineRepresentation = (vtkAffineRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAffineRepresentation.Register(null);
				}
			}
			return vtkAffineRepresentation;
		}

		// Token: 0x06007D3A RID: 32058
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAffineRepresentation_SetTolerance_11(HandleRef pThis, int _arg);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels)
		/// in which the cursor is considered near enough to the widget to
		/// be active.
		/// </summary>
		// Token: 0x06007D3B RID: 32059 RVA: 0x000B3DA3 File Offset: 0x000B1FA3
		public virtual void SetTolerance(int _arg)
		{
			vtkAffineRepresentation.vtkAffineRepresentation_SetTolerance_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06007D3C RID: 32060
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAffineRepresentation_ShallowCopy_12(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x06007D3D RID: 32061 RVA: 0x000B3DB4 File Offset: 0x000B1FB4
		public override void ShallowCopy(vtkProp prop)
		{
			vtkAffineRepresentation.vtkAffineRepresentation_ShallowCopy_12(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A84 RID: 2692
		public new const string MRFullTypeName = "Kitware.VTK.vtkAffineRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A85 RID: 2693
		public new static readonly string MRClassNameKey = "class vtkAffineRepresentation";

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels)
		/// in which the cursor is considered near enough to the widget to
		/// be active.
		/// </summary>
		// Token: 0x020002B4 RID: 692
		public enum InteractionStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000A87 RID: 2695
			MoveOrigin = 19,
			/// <summary>enum member</summary>
			// Token: 0x04000A88 RID: 2696
			MoveOriginX = 17,
			/// <summary>enum member</summary>
			// Token: 0x04000A89 RID: 2697
			MoveOriginY,
			/// <summary>enum member</summary>
			// Token: 0x04000A8A RID: 2698
			Outside = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000A8B RID: 2699
			Rotate,
			/// <summary>enum member</summary>
			// Token: 0x04000A8C RID: 2700
			ScaleEEdge = 6,
			/// <summary>enum member</summary>
			// Token: 0x04000A8D RID: 2701
			ScaleNE = 9,
			/// <summary>enum member</summary>
			// Token: 0x04000A8E RID: 2702
			ScaleNEdge = 7,
			/// <summary>enum member</summary>
			// Token: 0x04000A8F RID: 2703
			ScaleNW = 11,
			/// <summary>enum member</summary>
			// Token: 0x04000A90 RID: 2704
			ScaleSE,
			/// <summary>enum member</summary>
			// Token: 0x04000A91 RID: 2705
			ScaleSEdge = 8,
			/// <summary>enum member</summary>
			// Token: 0x04000A92 RID: 2706
			ScaleSW = 10,
			/// <summary>enum member</summary>
			// Token: 0x04000A93 RID: 2707
			ScaleWEdge = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000A94 RID: 2708
			ShearEEdge = 13,
			/// <summary>enum member</summary>
			// Token: 0x04000A95 RID: 2709
			ShearNEdge = 15,
			/// <summary>enum member</summary>
			// Token: 0x04000A96 RID: 2710
			ShearSEdge,
			/// <summary>enum member</summary>
			// Token: 0x04000A97 RID: 2711
			ShearWEdge = 14,
			/// <summary>enum member</summary>
			// Token: 0x04000A98 RID: 2712
			Translate = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000A99 RID: 2713
			TranslateX,
			/// <summary>enum member</summary>
			// Token: 0x04000A9A RID: 2714
			TranslateY
		}
	}
}
