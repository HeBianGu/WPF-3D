using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorStyleUnicam
	/// </summary>
	/// <remarks>
	///    provides Unicam navigation style
	///
	/// UniCam is a camera interactor.  Here, just the primary features of the
	/// UniCam technique are implemented.  UniCam requires just one mouse button
	/// and supports context sensitive dollying, panning, and rotation.  (In this
	/// implementation, it uses the right mouse button, leaving the middle and
	/// left available for other functions.) For more information, see the paper
	/// at:
	///
	///    ftp://ftp.cs.brown.edu/pub/papers/graphics/research/unicam.pdf
	///
	/// The following is a brief description of the UniCam Camera Controls.  You
	/// can perform 3 operations on the camera: rotate, pan, and dolly the camera.
	/// All operations are reached through the right mouse button &amp; mouse
	/// movements.
	///
	/// IMPORTANT: UniCam assumes there is an axis that makes sense as a "up"
	/// vector for the world.  By default, this axis is defined to be the
	/// vector &lt;0,0,1&gt;.  You can set it explicitly for the data you are
	/// viewing with the 'SetWorldUpVector(..)' method.
	///
	/// 1. ROTATE:
	///
	/// Position the cursor over the point you wish to rotate around and press and
	/// release the left mouse button.  A 'focus dot' appears indicating the
	/// point that will be the center of rotation.  To rotate, press and hold the
	/// left mouse button and drag the mouse.. release the button to complete the
	/// rotation.
	///
	/// Rotations can be done without placing a focus dot first by moving the
	/// mouse cursor to within 10% of the window border &amp; pressing and holding the
	/// left button followed by dragging the mouse.  The last focus dot position
	/// will be re-used.
	///
	/// 2. PAN:
	///
	/// Click and hold the left mouse button, and initially move the mouse left
	/// or right.  The point under the initial pick will pick correlate w/ the
	/// mouse tip-- (i.e., direct manipulation).
	///
	/// 3. DOLLY (+ PAN):
	///
	/// Click and hold the left mouse button, and initially move the mouse up or
	/// down.  Moving the mouse down will dolly towards the picked point, and moving
	/// the mouse up will dolly away from it.  Dollying occurs relative to the
	/// picked point which simplifies the task of dollying towards a region of
	/// interest. Left and right mouse movements will pan the camera left and right.
	///
	/// @warning
	/// (NOTE: This implementation of Unicam assumes a perspective camera.  It
	/// could be modified relatively easily to also support an orthographic
	/// projection.)
	/// </remarks>
	// Token: 0x02000407 RID: 1031
	public class vtkInteractorStyleUnicam : vtkInteractorStyle
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C401 RID: 50177 RVA: 0x00110AFD File Offset: 0x0010ECFD
		static vtkInteractorStyleUnicam()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleUnicam.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleUnicam"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C402 RID: 50178 RVA: 0x00110B25 File Offset: 0x0010ED25
		public vtkInteractorStyleUnicam(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C403 RID: 50179
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleUnicam_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C404 RID: 50180 RVA: 0x00110B34 File Offset: 0x0010ED34
		public new static vtkInteractorStyleUnicam New()
		{
			vtkInteractorStyleUnicam result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleUnicam)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C405 RID: 50181 RVA: 0x00110B88 File Offset: 0x0010ED88
		public vtkInteractorStyleUnicam() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C406 RID: 50182 RVA: 0x00110BCC File Offset: 0x0010EDCC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C407 RID: 50183
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleUnicam_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C408 RID: 50184 RVA: 0x00110BD8 File Offset: 0x0010EDD8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600C409 RID: 50185
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleUnicam_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C40A RID: 50186 RVA: 0x00110BF8 File Offset: 0x0010EDF8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600C40B RID: 50187
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleUnicam_GetWorldUpVector_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C40C RID: 50188 RVA: 0x00110C14 File Offset: 0x0010EE14
		public virtual double[] GetWorldUpVector()
		{
			IntPtr intPtr = vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_GetWorldUpVector_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600C40D RID: 50189
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUnicam_GetWorldUpVector_04(HandleRef pThis, IntPtr data);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C40E RID: 50190 RVA: 0x00110C5C File Offset: 0x0010EE5C
		public virtual void GetWorldUpVector(IntPtr data)
		{
			vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_GetWorldUpVector_04(base.GetCppThis(), data);
		}

		// Token: 0x0600C40F RID: 50191
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleUnicam_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C410 RID: 50192 RVA: 0x00110C6C File Offset: 0x0010EE6C
		public override int IsA(string type)
		{
			return vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600C411 RID: 50193
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleUnicam_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C412 RID: 50194 RVA: 0x00110C8C File Offset: 0x0010EE8C
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_IsTypeOf_06(type);
		}

		// Token: 0x0600C413 RID: 50195
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleUnicam_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C414 RID: 50196 RVA: 0x00110CA8 File Offset: 0x0010EEA8
		public new vtkInteractorStyleUnicam NewInstance()
		{
			vtkInteractorStyleUnicam result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleUnicam)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C415 RID: 50197
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUnicam_OnLeftButtonDown_09(HandleRef pThis);

		/// <summary>
		/// Concrete implementation of event bindings
		/// </summary>
		// Token: 0x0600C416 RID: 50198 RVA: 0x00110D02 File Offset: 0x0010EF02
		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_OnLeftButtonDown_09(base.GetCppThis());
		}

		// Token: 0x0600C417 RID: 50199
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUnicam_OnLeftButtonMove_10(HandleRef pThis);

		/// <summary>
		/// Concrete implementation of event bindings
		/// </summary>
		// Token: 0x0600C418 RID: 50200 RVA: 0x00110D11 File Offset: 0x0010EF11
		public virtual void OnLeftButtonMove()
		{
			vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_OnLeftButtonMove_10(base.GetCppThis());
		}

		// Token: 0x0600C419 RID: 50201
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUnicam_OnLeftButtonUp_11(HandleRef pThis);

		/// <summary>
		/// Concrete implementation of event bindings
		/// </summary>
		// Token: 0x0600C41A RID: 50202 RVA: 0x00110D20 File Offset: 0x0010EF20
		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_OnLeftButtonUp_11(base.GetCppThis());
		}

		// Token: 0x0600C41B RID: 50203
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUnicam_OnMouseMove_12(HandleRef pThis);

		/// <summary>
		/// Concrete implementation of event bindings
		/// </summary>
		// Token: 0x0600C41C RID: 50204 RVA: 0x00110D2F File Offset: 0x0010EF2F
		public override void OnMouseMove()
		{
			vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_OnMouseMove_12(base.GetCppThis());
		}

		// Token: 0x0600C41D RID: 50205
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUnicam_OnTimer_13(HandleRef pThis);

		/// <summary>
		/// OnTimer calls RotateCamera, RotateActor etc which should be overridden by
		/// style subclasses.
		/// </summary>
		// Token: 0x0600C41E RID: 50206 RVA: 0x00110D3E File Offset: 0x0010EF3E
		public override void OnTimer()
		{
			vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_OnTimer_13(base.GetCppThis());
		}

		// Token: 0x0600C41F RID: 50207
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleUnicam_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C420 RID: 50208 RVA: 0x00110D50 File Offset: 0x0010EF50
		public new static vtkInteractorStyleUnicam SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleUnicam vtkInteractorStyleUnicam = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleUnicam = (vtkInteractorStyleUnicam)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleUnicam.Register(null);
				}
			}
			return vtkInteractorStyleUnicam;
		}

		// Token: 0x0600C421 RID: 50209
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUnicam_SetWorldUpVector_15(HandleRef pThis, IntPtr a);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C422 RID: 50210 RVA: 0x00110DCF File Offset: 0x0010EFCF
		public void SetWorldUpVector(IntPtr a)
		{
			vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_SetWorldUpVector_15(base.GetCppThis(), a);
		}

		// Token: 0x0600C423 RID: 50211
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUnicam_SetWorldUpVector_16(HandleRef pThis, double x, double y, double z);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C424 RID: 50212 RVA: 0x00110DDF File Offset: 0x0010EFDF
		public void SetWorldUpVector(double x, double y, double z)
		{
			vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_SetWorldUpVector_16(base.GetCppThis(), x, y, z);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E80 RID: 3712
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleUnicam";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E81 RID: 3713
		public new static readonly string MRClassNameKey = "class vtkInteractorStyleUnicam";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000408 RID: 1032
		public enum BUTTON_LEFT_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000E83 RID: 3715
			BUTTON_LEFT = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000E84 RID: 3716
			BUTTON_MIDDLE,
			/// <summary>enum member</summary>
			// Token: 0x04000E85 RID: 3717
			BUTTON_RIGHT,
			/// <summary>enum member</summary>
			// Token: 0x04000E86 RID: 3718
			NONE = 0
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000409 RID: 1033
		public enum CAM_INT_CHOOSE_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000E88 RID: 3720
			CAM_INT_CHOOSE = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000E89 RID: 3721
			CAM_INT_DOLLY = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000E8A RID: 3722
			CAM_INT_PAN = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000E8B RID: 3723
			CAM_INT_ROT = 0
		}
	}
}
