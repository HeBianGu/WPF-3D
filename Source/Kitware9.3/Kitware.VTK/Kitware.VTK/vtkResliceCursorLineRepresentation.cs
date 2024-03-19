using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkResliceCursorLineRepresentation
	/// </summary>
	/// <remarks>
	///    represent the vtkResliceCursorWidget
	///
	/// This class provides a representation for the reslice cursor widget. It
	/// consists of two cross sectional hairs, with an optional thickness. The
	/// hairs may have a hole in the center. These may be translated or rotated
	/// independent of each other in the view. The result is used to reslice
	/// the data along these cross sections. This allows the user to perform
	/// multi-planar thin or thick reformat of the data on an image view, rather
	/// than a 3D view.
	/// </remarks>
	/// <seealso>
	///
	/// vtkResliceCursorWidget vtkResliceCursor vtkResliceCursorPolyDataAlgorithm
	/// vtkResliceCursorRepresentation vtkResliceCursorThickLineRepresentation
	/// vtkResliceCursorActor vtkImagePlaneWidget
	/// </seealso>
	// Token: 0x02000367 RID: 871
	public class vtkResliceCursorLineRepresentation : vtkResliceCursorRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009E85 RID: 40581 RVA: 0x000E09B2 File Offset: 0x000DEBB2
		static vtkResliceCursorLineRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkResliceCursorLineRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkResliceCursorLineRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009E86 RID: 40582 RVA: 0x000E09DA File Offset: 0x000DEBDA
		public vtkResliceCursorLineRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009E87 RID: 40583
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorLineRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06009E88 RID: 40584 RVA: 0x000E09E8 File Offset: 0x000DEBE8
		public new static vtkResliceCursorLineRepresentation New()
		{
			vtkResliceCursorLineRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResliceCursorLineRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06009E89 RID: 40585 RVA: 0x000E0A3C File Offset: 0x000DEC3C
		public vtkResliceCursorLineRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009E8A RID: 40586 RVA: 0x000E0A80 File Offset: 0x000DEC80
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009E8B RID: 40587
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorLineRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06009E8C RID: 40588 RVA: 0x000E0A8B File Offset: 0x000DEC8B
		public override void BuildRepresentation()
		{
			vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009E8D RID: 40589
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorLineRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06009E8E RID: 40590 RVA: 0x000E0A9C File Offset: 0x000DEC9C
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x06009E8F RID: 40591
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorLineRepresentation_GetBounds_03(HandleRef pThis);

		/// <summary>
		/// Get the bounds of this prop. This simply returns the bounds of the
		/// reslice cursor object.
		/// </summary>
		// Token: 0x06009E90 RID: 40592 RVA: 0x000E0AC0 File Offset: 0x000DECC0
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009E91 RID: 40593
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResliceCursorLineRepresentation_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06009E92 RID: 40594 RVA: 0x000E0B08 File Offset: 0x000DED08
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06009E93 RID: 40595
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResliceCursorLineRepresentation_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06009E94 RID: 40596 RVA: 0x000E0B28 File Offset: 0x000DED28
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06009E95 RID: 40597
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorLineRepresentation_GetResliceCursor_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reslice cursor.
		/// </summary>
		// Token: 0x06009E96 RID: 40598 RVA: 0x000E0B44 File Offset: 0x000DED44
		public override vtkResliceCursor GetResliceCursor()
		{
			vtkResliceCursor vtkResliceCursor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_GetResliceCursor_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResliceCursor = (vtkResliceCursor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResliceCursor.Register(null);
				}
			}
			return vtkResliceCursor;
		}

		// Token: 0x06009E97 RID: 40599
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorLineRepresentation_GetResliceCursorActor_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reslice cursor actor. You must set the reslice cursor on this
		/// class
		/// </summary>
		// Token: 0x06009E98 RID: 40600 RVA: 0x000E0BB4 File Offset: 0x000DEDB4
		public virtual vtkResliceCursorActor GetResliceCursorActor()
		{
			vtkResliceCursorActor vtkResliceCursorActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_GetResliceCursorActor_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResliceCursorActor = (vtkResliceCursorActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResliceCursorActor.Register(null);
				}
			}
			return vtkResliceCursorActor;
		}

		// Token: 0x06009E99 RID: 40601
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorLineRepresentation_HasTranslucentPolygonalGeometry_08(HandleRef pThis);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06009E9A RID: 40602 RVA: 0x000E0C24 File Offset: 0x000DEE24
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_HasTranslucentPolygonalGeometry_08(base.GetCppThis());
		}

		// Token: 0x06009E9B RID: 40603
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorLineRepresentation_Highlight_09(HandleRef pThis, int highlightOn);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06009E9C RID: 40604 RVA: 0x000E0C43 File Offset: 0x000DEE43
		public override void Highlight(int highlightOn)
		{
			vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_Highlight_09(base.GetCppThis(), highlightOn);
		}

		// Token: 0x06009E9D RID: 40605
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorLineRepresentation_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06009E9E RID: 40606 RVA: 0x000E0C54 File Offset: 0x000DEE54
		public override int IsA(string type)
		{
			return vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06009E9F RID: 40607
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorLineRepresentation_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06009EA0 RID: 40608 RVA: 0x000E0C74 File Offset: 0x000DEE74
		public new static int IsTypeOf(string type)
		{
			return vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_IsTypeOf_11(type);
		}

		// Token: 0x06009EA1 RID: 40609
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorLineRepresentation_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06009EA2 RID: 40610 RVA: 0x000E0C90 File Offset: 0x000DEE90
		public new vtkResliceCursorLineRepresentation NewInstance()
		{
			vtkResliceCursorLineRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResliceCursorLineRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009EA3 RID: 40611
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorLineRepresentation_ReleaseGraphicsResources_14(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06009EA4 RID: 40612 RVA: 0x000E0CEC File Offset: 0x000DEEEC
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_ReleaseGraphicsResources_14(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x06009EA5 RID: 40613
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorLineRepresentation_RenderOpaqueGeometry_15(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06009EA6 RID: 40614 RVA: 0x000E0D1C File Offset: 0x000DEF1C
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_RenderOpaqueGeometry_15(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06009EA7 RID: 40615
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorLineRepresentation_RenderOverlay_16(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06009EA8 RID: 40616 RVA: 0x000E0D50 File Offset: 0x000DEF50
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_RenderOverlay_16(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06009EA9 RID: 40617
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorLineRepresentation_RenderTranslucentPolygonalGeometry_17(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06009EAA RID: 40618 RVA: 0x000E0D84 File Offset: 0x000DEF84
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_RenderTranslucentPolygonalGeometry_17(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06009EAB RID: 40619
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorLineRepresentation_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06009EAC RID: 40620 RVA: 0x000E0DB8 File Offset: 0x000DEFB8
		public new static vtkResliceCursorLineRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkResliceCursorLineRepresentation vtkResliceCursorLineRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResliceCursorLineRepresentation = (vtkResliceCursorLineRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResliceCursorLineRepresentation.Register(null);
				}
			}
			return vtkResliceCursorLineRepresentation;
		}

		// Token: 0x06009EAD RID: 40621
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorLineRepresentation_SetTolerance_19(HandleRef pThis, int t);

		/// <summary>
		/// Re-implemented to set the tolerance of the picker.
		/// </summary>
		// Token: 0x06009EAE RID: 40622 RVA: 0x000E0E37 File Offset: 0x000DF037
		public override void SetTolerance(int t)
		{
			vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_SetTolerance_19(base.GetCppThis(), t);
		}

		// Token: 0x06009EAF RID: 40623
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorLineRepresentation_SetUserMatrix_20(HandleRef pThis, HandleRef matrix);

		/// <summary>
		/// Set the user matrix on all the internal actors.
		/// </summary>
		// Token: 0x06009EB0 RID: 40624 RVA: 0x000E0E48 File Offset: 0x000DF048
		public virtual void SetUserMatrix(vtkMatrix4x4 matrix)
		{
			vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_SetUserMatrix_20(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x06009EB1 RID: 40625
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorLineRepresentation_StartWidgetInteraction_21(HandleRef pThis, IntPtr startEventPos);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06009EB2 RID: 40626 RVA: 0x000E0E77 File Offset: 0x000DF077
		public override void StartWidgetInteraction(IntPtr startEventPos)
		{
			vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_StartWidgetInteraction_21(base.GetCppThis(), startEventPos);
		}

		// Token: 0x06009EB3 RID: 40627
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorLineRepresentation_WidgetInteraction_22(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06009EB4 RID: 40628 RVA: 0x000E0E87 File Offset: 0x000DF087
		public override void WidgetInteraction(IntPtr e)
		{
			vtkResliceCursorLineRepresentation.vtkResliceCursorLineRepresentation_WidgetInteraction_22(base.GetCppThis(), e);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CCF RID: 3279
		public new const string MRFullTypeName = "Kitware.VTK.vtkResliceCursorLineRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CD0 RID: 3280
		public new static readonly string MRClassNameKey = "class vtkResliceCursorLineRepresentation";
	}
}
