using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtk3DCursorRepresentation
	/// </summary>
	/// <remarks>
	///  Representation of the vtk3DCursorWidget
	///
	/// Internally, the class uses a vtkHardwarePicker to pick the position of the cursor
	/// in the scene given a display position (in pixels). If the mouse hovers an actor,
	/// the cursor is placed on its surface. If not, it's placed on the focal plane of the camera.
	/// Because of the current state of pickers in VTK, this cursor do not support volumetric data.
	///
	/// The cursor itself can be considered as a self-employed widget handle. For resizing the cursor,
	/// use the SetHandleSize method of this widget.
	///
	/// Current limitations :
	/// - Do not work with volumes (for now no pickers handles them properly)
	/// - Unsteady placement on other widgets (manipulation and cursor actualization remain fine)
	/// - When zooming the cursor do not follows the mouse until moving it again
	///
	/// </remarks>
	/// <seealso>
	///  vtk3DCursorWidget
	/// </seealso>
	// Token: 0x020002A9 RID: 681
	public class vtk3DCursorRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007B38 RID: 31544 RVA: 0x000B14C2 File Offset: 0x000AF6C2
		static vtk3DCursorRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtk3DCursorRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtk3DCursorRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007B39 RID: 31545 RVA: 0x000B14EA File Offset: 0x000AF6EA
		public vtk3DCursorRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007B3A RID: 31546
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DCursorRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007B3B RID: 31547 RVA: 0x000B14F8 File Offset: 0x000AF6F8
		public new static vtk3DCursorRepresentation New()
		{
			vtk3DCursorRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DCursorRepresentation.vtk3DCursorRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtk3DCursorRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007B3C RID: 31548 RVA: 0x000B154C File Offset: 0x000AF74C
		public vtk3DCursorRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtk3DCursorRepresentation.vtk3DCursorRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007B3D RID: 31549 RVA: 0x000B1590 File Offset: 0x000AF790
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007B3E RID: 31550
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DCursorRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Update the cursor size (in world coordinates) to always keep the same
		/// size in display coordinates.
		/// </summary>
		// Token: 0x06007B3F RID: 31551 RVA: 0x000B159B File Offset: 0x000AF79B
		public override void BuildRepresentation()
		{
			vtk3DCursorRepresentation.vtk3DCursorRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06007B40 RID: 31552
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DCursorRepresentation_GetCustomCursor_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / Get an actor to use as custom cursor.
		/// You must set the cursor shape to CUSTOM enable it.
		/// </summary>
		// Token: 0x06007B41 RID: 31553 RVA: 0x000B15AC File Offset: 0x000AF7AC
		public virtual vtkActor GetCustomCursor()
		{
			vtkActor vtkActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DCursorRepresentation.vtk3DCursorRepresentation_GetCustomCursor_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor = (vtkActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor.Register(null);
				}
			}
			return vtkActor;
		}

		// Token: 0x06007B42 RID: 31554
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtk3DCursorRepresentation_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007B43 RID: 31555 RVA: 0x000B161C File Offset: 0x000AF81C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtk3DCursorRepresentation.vtk3DCursorRepresentation_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06007B44 RID: 31556
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtk3DCursorRepresentation_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007B45 RID: 31557 RVA: 0x000B163C File Offset: 0x000AF83C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtk3DCursorRepresentation.vtk3DCursorRepresentation_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06007B46 RID: 31558
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtk3DCursorRepresentation_GetShape_05(HandleRef pThis);

		/// <summary>
		/// Set / Get the shape of the cursor.
		/// You can choose between CROSS, SPHERE and CUSTOM.
		/// Choose CUSTOM if you want to use the actor you pass
		/// with SetCustomCursor.
		/// </summary>
		// Token: 0x06007B47 RID: 31559 RVA: 0x000B1658 File Offset: 0x000AF858
		public virtual int GetShape()
		{
			return vtk3DCursorRepresentation.vtk3DCursorRepresentation_GetShape_05(base.GetCppThis());
		}

		// Token: 0x06007B48 RID: 31560
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtk3DCursorRepresentation_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007B49 RID: 31561 RVA: 0x000B1678 File Offset: 0x000AF878
		public override int IsA(string type)
		{
			return vtk3DCursorRepresentation.vtk3DCursorRepresentation_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06007B4A RID: 31562
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtk3DCursorRepresentation_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007B4B RID: 31563 RVA: 0x000B1698 File Offset: 0x000AF898
		public new static int IsTypeOf(string type)
		{
			return vtk3DCursorRepresentation.vtk3DCursorRepresentation_IsTypeOf_07(type);
		}

		// Token: 0x06007B4C RID: 31564
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DCursorRepresentation_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007B4D RID: 31565 RVA: 0x000B16B4 File Offset: 0x000AF8B4
		public new vtk3DCursorRepresentation NewInstance()
		{
			vtk3DCursorRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DCursorRepresentation.vtk3DCursorRepresentation_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtk3DCursorRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007B4E RID: 31566
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DCursorRepresentation_ReleaseGraphicsResources_10(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are reimplemented to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06007B4F RID: 31567 RVA: 0x000B1710 File Offset: 0x000AF910
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtk3DCursorRepresentation.vtk3DCursorRepresentation_ReleaseGraphicsResources_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06007B50 RID: 31568
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtk3DCursorRepresentation_RenderOpaqueGeometry_11(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// These methods are reimplemented to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06007B51 RID: 31569 RVA: 0x000B1740 File Offset: 0x000AF940
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtk3DCursorRepresentation.vtk3DCursorRepresentation_RenderOpaqueGeometry_11(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06007B52 RID: 31570
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DCursorRepresentation_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007B53 RID: 31571 RVA: 0x000B1774 File Offset: 0x000AF974
		public new static vtk3DCursorRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtk3DCursorRepresentation vtk3DCursorRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DCursorRepresentation.vtk3DCursorRepresentation_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtk3DCursorRepresentation = (vtk3DCursorRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtk3DCursorRepresentation.Register(null);
				}
			}
			return vtk3DCursorRepresentation;
		}

		// Token: 0x06007B54 RID: 31572
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DCursorRepresentation_SetCursorShape_13(HandleRef pThis, int shape);

		/// <summary>
		/// Set / Get the shape of the cursor.
		/// You can choose between CROSS, SPHERE and CUSTOM.
		/// Choose CUSTOM if you want to use the actor you pass
		/// with SetCustomCursor.
		/// </summary>
		// Token: 0x06007B55 RID: 31573 RVA: 0x000B17F3 File Offset: 0x000AF9F3
		public void SetCursorShape(int shape)
		{
			vtk3DCursorRepresentation.vtk3DCursorRepresentation_SetCursorShape_13(base.GetCppThis(), shape);
		}

		// Token: 0x06007B56 RID: 31574
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DCursorRepresentation_SetCustomCursor_14(HandleRef pThis, HandleRef customCursor);

		/// <summary>
		/// Set / Get an actor to use as custom cursor.
		/// You must set the cursor shape to CUSTOM enable it.
		/// </summary>
		// Token: 0x06007B57 RID: 31575 RVA: 0x000B1804 File Offset: 0x000AFA04
		public void SetCustomCursor(vtkActor customCursor)
		{
			vtk3DCursorRepresentation.vtk3DCursorRepresentation_SetCustomCursor_14(base.GetCppThis(), (customCursor == null) ? default(HandleRef) : customCursor.GetCppThis());
		}

		// Token: 0x06007B58 RID: 31576
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DCursorRepresentation_WidgetInteraction_15(HandleRef pThis, IntPtr newEventPos);

		/// <summary>
		/// Position the cursor in the scene using the vtkHardwarePicker
		/// </summary>
		// Token: 0x06007B59 RID: 31577 RVA: 0x000B1833 File Offset: 0x000AFA33
		public override void WidgetInteraction(IntPtr newEventPos)
		{
			vtk3DCursorRepresentation.vtk3DCursorRepresentation_WidgetInteraction_15(base.GetCppThis(), newEventPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A62 RID: 2658
		public new const string MRFullTypeName = "Kitware.VTK.vtk3DCursorRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A63 RID: 2659
		public new static readonly string MRClassNameKey = "class vtk3DCursorRepresentation";

		/// <summary>
		/// These methods are reimplemented to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x020002AA RID: 682
		public enum CursorShape
		{
			/// <summary>enum member</summary>
			// Token: 0x04000A65 RID: 2661
			CROSS_SHAPE,
			/// <summary>enum member</summary>
			// Token: 0x04000A66 RID: 2662
			CUSTOM_SHAPE = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000A67 RID: 2663
			SPHERE_SHAPE = 1
		}
	}
}
