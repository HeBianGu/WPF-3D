using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorStyleTerrain
	/// </summary>
	/// <remarks>
	///    manipulate camera in scene with natural view up (e.g., terrain)
	///
	/// vtkInteractorStyleTerrain is used to manipulate a camera which is viewing
	/// a scene with a natural view up, e.g., terrain. The camera in such a
	/// scene is manipulated by specifying azimuth (angle around the view
	/// up vector) and elevation (the angle from the horizon).
	///
	/// The mouse binding for this class is as follows. Left mouse click followed
	/// rotates the camera around the focal point using both elevation and azimuth
	/// invocations on the camera. Left mouse motion in the horizontal direction
	/// results in azimuth motion; left mouse motion in the vertical direction
	/// results in elevation motion. Therefore, diagonal motion results in a
	/// combination of azimuth and elevation. (If the shift key is held during
	/// motion, then only one of elevation or azimuth is invoked, depending on the
	/// whether the mouse motion is primarily horizontal or vertical.) Middle
	/// mouse button pans the camera across the scene (again the shift key has a
	/// similar effect on limiting the motion to the vertical or horizontal
	/// direction. The right mouse is used to dolly (e.g., a type of zoom) towards
	/// or away from the focal point.
	///
	/// The class also supports some keypress events. The "r" key resets the
	/// camera.  The "e" key invokes the exit callback and by default exits the
	/// program. The "f" key sets a new camera focal point and flys towards that
	/// point. The "u" key invokes the user event. The "3" key toggles between
	/// stereo and non-stero mode. The "l" key toggles on/off a latitude/longitude
	/// markers that can be used to estimate/control position.
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInteractorObserver vtkInteractorStyle vtk3DWidget
	/// </seealso>
	// Token: 0x02000402 RID: 1026
	public class vtkInteractorStyleTerrain : vtkInteractorStyle
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C359 RID: 50009 RVA: 0x0010FC8D File Offset: 0x0010DE8D
		static vtkInteractorStyleTerrain()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleTerrain.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleTerrain"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C35A RID: 50010 RVA: 0x0010FCB5 File Offset: 0x0010DEB5
		public vtkInteractorStyleTerrain(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C35B RID: 50011
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleTerrain_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600C35C RID: 50012 RVA: 0x0010FCC4 File Offset: 0x0010DEC4
		public new static vtkInteractorStyleTerrain New()
		{
			vtkInteractorStyleTerrain result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleTerrain)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600C35D RID: 50013 RVA: 0x0010FD18 File Offset: 0x0010DF18
		public vtkInteractorStyleTerrain() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C35E RID: 50014 RVA: 0x0010FD5C File Offset: 0x0010DF5C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C35F RID: 50015
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTerrain_Dolly_01(HandleRef pThis);

		/// <summary>
		/// Override the "fly-to" (f keypress) for images.
		/// </summary>
		// Token: 0x0600C360 RID: 50016 RVA: 0x0010FD67 File Offset: 0x0010DF67
		public override void Dolly()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_Dolly_01(base.GetCppThis());
		}

		// Token: 0x0600C361 RID: 50017
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleTerrain_GetLatLongLines_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off the latitude/longitude lines.
		/// </summary>
		// Token: 0x0600C362 RID: 50018 RVA: 0x0010FD78 File Offset: 0x0010DF78
		public virtual int GetLatLongLines()
		{
			return vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_GetLatLongLines_02(base.GetCppThis());
		}

		// Token: 0x0600C363 RID: 50019
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleTerrain_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600C364 RID: 50020 RVA: 0x0010FD98 File Offset: 0x0010DF98
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600C365 RID: 50021
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleTerrain_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600C366 RID: 50022 RVA: 0x0010FDB8 File Offset: 0x0010DFB8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600C367 RID: 50023
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleTerrain_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600C368 RID: 50024 RVA: 0x0010FDD4 File Offset: 0x0010DFD4
		public override int IsA(string type)
		{
			return vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600C369 RID: 50025
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleTerrain_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600C36A RID: 50026 RVA: 0x0010FDF4 File Offset: 0x0010DFF4
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_IsTypeOf_06(type);
		}

		// Token: 0x0600C36B RID: 50027
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTerrain_LatLongLinesOff_07(HandleRef pThis);

		/// <summary>
		/// Turn on/off the latitude/longitude lines.
		/// </summary>
		// Token: 0x0600C36C RID: 50028 RVA: 0x0010FE0E File Offset: 0x0010E00E
		public virtual void LatLongLinesOff()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_LatLongLinesOff_07(base.GetCppThis());
		}

		// Token: 0x0600C36D RID: 50029
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTerrain_LatLongLinesOn_08(HandleRef pThis);

		/// <summary>
		/// Turn on/off the latitude/longitude lines.
		/// </summary>
		// Token: 0x0600C36E RID: 50030 RVA: 0x0010FE1D File Offset: 0x0010E01D
		public virtual void LatLongLinesOn()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_LatLongLinesOn_08(base.GetCppThis());
		}

		// Token: 0x0600C36F RID: 50031
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleTerrain_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600C370 RID: 50032 RVA: 0x0010FE2C File Offset: 0x0010E02C
		public new vtkInteractorStyleTerrain NewInstance()
		{
			vtkInteractorStyleTerrain result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleTerrain)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C371 RID: 50033
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTerrain_OnChar_11(HandleRef pThis);

		/// <summary>
		/// Override the "fly-to" (f keypress) for images.
		/// </summary>
		// Token: 0x0600C372 RID: 50034 RVA: 0x0010FE86 File Offset: 0x0010E086
		public override void OnChar()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_OnChar_11(base.GetCppThis());
		}

		// Token: 0x0600C373 RID: 50035
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTerrain_OnLeftButtonDown_12(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C374 RID: 50036 RVA: 0x0010FE95 File Offset: 0x0010E095
		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_OnLeftButtonDown_12(base.GetCppThis());
		}

		// Token: 0x0600C375 RID: 50037
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTerrain_OnLeftButtonUp_13(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C376 RID: 50038 RVA: 0x0010FEA4 File Offset: 0x0010E0A4
		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_OnLeftButtonUp_13(base.GetCppThis());
		}

		// Token: 0x0600C377 RID: 50039
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTerrain_OnMiddleButtonDown_14(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C378 RID: 50040 RVA: 0x0010FEB3 File Offset: 0x0010E0B3
		public override void OnMiddleButtonDown()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_OnMiddleButtonDown_14(base.GetCppThis());
		}

		// Token: 0x0600C379 RID: 50041
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTerrain_OnMiddleButtonUp_15(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C37A RID: 50042 RVA: 0x0010FEC2 File Offset: 0x0010E0C2
		public override void OnMiddleButtonUp()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_OnMiddleButtonUp_15(base.GetCppThis());
		}

		// Token: 0x0600C37B RID: 50043
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTerrain_OnMouseMove_16(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C37C RID: 50044 RVA: 0x0010FED1 File Offset: 0x0010E0D1
		public override void OnMouseMove()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_OnMouseMove_16(base.GetCppThis());
		}

		// Token: 0x0600C37D RID: 50045
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTerrain_OnRightButtonDown_17(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C37E RID: 50046 RVA: 0x0010FEE0 File Offset: 0x0010E0E0
		public override void OnRightButtonDown()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_OnRightButtonDown_17(base.GetCppThis());
		}

		// Token: 0x0600C37F RID: 50047
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTerrain_OnRightButtonUp_18(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C380 RID: 50048 RVA: 0x0010FEEF File Offset: 0x0010E0EF
		public override void OnRightButtonUp()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_OnRightButtonUp_18(base.GetCppThis());
		}

		// Token: 0x0600C381 RID: 50049
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTerrain_Pan_19(HandleRef pThis);

		/// <summary>
		/// Override the "fly-to" (f keypress) for images.
		/// </summary>
		// Token: 0x0600C382 RID: 50050 RVA: 0x0010FEFE File Offset: 0x0010E0FE
		public override void Pan()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_Pan_19(base.GetCppThis());
		}

		// Token: 0x0600C383 RID: 50051
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTerrain_Rotate_20(HandleRef pThis);

		/// <summary>
		/// Override the "fly-to" (f keypress) for images.
		/// </summary>
		// Token: 0x0600C384 RID: 50052 RVA: 0x0010FF0D File Offset: 0x0010E10D
		public override void Rotate()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_Rotate_20(base.GetCppThis());
		}

		// Token: 0x0600C385 RID: 50053
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleTerrain_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600C386 RID: 50054 RVA: 0x0010FF1C File Offset: 0x0010E11C
		public new static vtkInteractorStyleTerrain SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleTerrain vtkInteractorStyleTerrain = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleTerrain = (vtkInteractorStyleTerrain)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleTerrain.Register(null);
				}
			}
			return vtkInteractorStyleTerrain;
		}

		// Token: 0x0600C387 RID: 50055
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTerrain_SetLatLongLines_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the latitude/longitude lines.
		/// </summary>
		// Token: 0x0600C388 RID: 50056 RVA: 0x0010FF9B File Offset: 0x0010E19B
		public virtual void SetLatLongLines(int _arg)
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_SetLatLongLines_22(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E76 RID: 3702
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleTerrain";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E77 RID: 3703
		public new static readonly string MRClassNameKey = "class vtkInteractorStyleTerrain";
	}
}
