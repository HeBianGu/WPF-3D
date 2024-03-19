using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorStyle3D
	/// </summary>
	/// <remarks>
	///    extends interaction to support 3D input
	///
	/// vtkInteractorStyle3D allows the user to interact with (rotate,
	/// pan, etc.) objects in the scene independent of each other. It is
	/// designed to use 3d positions and orientations instead of 2D.
	///
	/// The following interactions are specified by default.
	///
	/// A click and hold in 3D within the bounding box of a prop
	/// will pick up that prop allowing you to translate and
	/// orient that prop as desired with the 3D controller.
	///
	/// Click/dragging two controllers and pulling them apart or
	/// pushing them together will initial a scale gesture
	/// that will scale the world larger or smaller.
	///
	/// Click/dragging two controllers and translating them in the same
	/// direction will translate the camera/world
	/// pushing them together will initial a scale gesture
	/// that will scale the world larger or smaller.
	///
	/// If a controller is right clicked (push touchpad on Vive)
	/// then it starts a fly motion where the camer moves in the
	/// direction the controller is pointing. It moves at a speed
	/// scaled by the position of your thumb on the trackpad.
	/// Higher moves faster forward. Lower moves faster backwards.
	///
	/// For the Vive left click is mapped to the trigger and right
	/// click is mapped to pushing the trackpad down.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderWindowInteractor3D
	/// </seealso>
	// Token: 0x020000B1 RID: 177
	public class vtkInteractorStyle3D : vtkInteractorStyle
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060026FE RID: 9982 RVA: 0x00039A43 File Offset: 0x00037C43
		static vtkInteractorStyle3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyle3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyle3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060026FF RID: 9983 RVA: 0x00039A6B File Offset: 0x00037C6B
		public vtkInteractorStyle3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002700 RID: 9984
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyle3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002701 RID: 9985 RVA: 0x00039A7C File Offset: 0x00037C7C
		public new static vtkInteractorStyle3D New()
		{
			vtkInteractorStyle3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyle3D.vtkInteractorStyle3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyle3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002702 RID: 9986 RVA: 0x00039AD0 File Offset: 0x00037CD0
		public vtkInteractorStyle3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorStyle3D.vtkInteractorStyle3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002703 RID: 9987 RVA: 0x00039B14 File Offset: 0x00037D14
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002704 RID: 9988
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle3D_Dolly3D_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002705 RID: 9989 RVA: 0x00039B20 File Offset: 0x00037D20
		public virtual void Dolly3D(vtkEventData arg0)
		{
			vtkInteractorStyle3D.vtkInteractorStyle3D_Dolly3D_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002706 RID: 9990
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkInteractorStyle3D_GetDollyPhysicalSpeed_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum dolly speed used when flying in 3D, in meters per second.
		/// Default is 1.6666, corresponding to walking speed (= 6 km/h).
		/// This speed is scaled by the touchpad position as well.
		/// </summary>
		// Token: 0x06002707 RID: 9991 RVA: 0x00039B50 File Offset: 0x00037D50
		public virtual double GetDollyPhysicalSpeed()
		{
			return vtkInteractorStyle3D.vtkInteractorStyle3D_GetDollyPhysicalSpeed_02(base.GetCppThis());
		}

		// Token: 0x06002708 RID: 9992
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyle3D_GetInteractionPicker_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the interaction picker.
		/// By default, a vtkPropPicker is instancied.
		/// </summary>
		// Token: 0x06002709 RID: 9993 RVA: 0x00039B70 File Offset: 0x00037D70
		public virtual vtkAbstractPropPicker GetInteractionPicker()
		{
			vtkAbstractPropPicker vtkAbstractPropPicker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyle3D.vtkInteractorStyle3D_GetInteractionPicker_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPropPicker = (vtkAbstractPropPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPropPicker.Register(null);
				}
			}
			return vtkAbstractPropPicker;
		}

		// Token: 0x0600270A RID: 9994
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyle3D_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600270B RID: 9995 RVA: 0x00039BE0 File Offset: 0x00037DE0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorStyle3D.vtkInteractorStyle3D_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600270C RID: 9996
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyle3D_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600270D RID: 9997 RVA: 0x00039C00 File Offset: 0x00037E00
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorStyle3D.vtkInteractorStyle3D_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600270E RID: 9998
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyle3D_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600270F RID: 9999 RVA: 0x00039C1C File Offset: 0x00037E1C
		public override int IsA(string type)
		{
			return vtkInteractorStyle3D.vtkInteractorStyle3D_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06002710 RID: 10000
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyle3D_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002711 RID: 10001 RVA: 0x00039C3C File Offset: 0x00037E3C
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyle3D.vtkInteractorStyle3D_IsTypeOf_07(type);
		}

		// Token: 0x06002712 RID: 10002
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyle3D_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002713 RID: 10003 RVA: 0x00039C58 File Offset: 0x00037E58
		public new vtkInteractorStyle3D NewInstance()
		{
			vtkInteractorStyle3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyle3D.vtkInteractorStyle3D_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyle3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002714 RID: 10004
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle3D_PositionProp_10(HandleRef pThis, HandleRef arg0, IntPtr lwpos, IntPtr lwori);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002715 RID: 10005 RVA: 0x00039CB4 File Offset: 0x00037EB4
		public virtual void PositionProp(vtkEventData arg0, IntPtr lwpos, IntPtr lwori)
		{
			vtkInteractorStyle3D.vtkInteractorStyle3D_PositionProp_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), lwpos, lwori);
		}

		// Token: 0x06002716 RID: 10006
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyle3D_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002717 RID: 10007 RVA: 0x00039CE8 File Offset: 0x00037EE8
		public new static vtkInteractorStyle3D SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyle3D vtkInteractorStyle3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyle3D.vtkInteractorStyle3D_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyle3D = (vtkInteractorStyle3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyle3D.Register(null);
				}
			}
			return vtkInteractorStyle3D;
		}

		// Token: 0x06002718 RID: 10008
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle3D_SetDollyPhysicalSpeed_12(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the maximum dolly speed used when flying in 3D, in meters per second.
		/// Default is 1.6666, corresponding to walking speed (= 6 km/h).
		/// This speed is scaled by the touchpad position as well.
		/// </summary>
		// Token: 0x06002719 RID: 10009 RVA: 0x00039D67 File Offset: 0x00037F67
		public virtual void SetDollyPhysicalSpeed(double _arg)
		{
			vtkInteractorStyle3D.vtkInteractorStyle3D_SetDollyPhysicalSpeed_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0600271A RID: 10010
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle3D_SetInteractionPicker_13(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Get/Set the interaction picker.
		/// By default, a vtkPropPicker is instancied.
		/// </summary>
		// Token: 0x0600271B RID: 10011 RVA: 0x00039D78 File Offset: 0x00037F78
		public void SetInteractionPicker(vtkAbstractPropPicker prop)
		{
			vtkInteractorStyle3D.vtkInteractorStyle3D_SetInteractionPicker_13(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x0600271C RID: 10012
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle3D_SetScale_14(HandleRef pThis, HandleRef cam, double newScale);

		/// <summary>
		/// Set the scaling factor from world to physical space.
		/// In VR when we set it to a new value we also adjust the
		/// HMD position to maintain the same relative position.
		/// </summary>
		// Token: 0x0600271D RID: 10013 RVA: 0x00039DA8 File Offset: 0x00037FA8
		public virtual void SetScale(vtkCamera cam, double newScale)
		{
			vtkInteractorStyle3D.vtkInteractorStyle3D_SetScale_14(base.GetCppThis(), (cam == null) ? default(HandleRef) : cam.GetCppThis(), newScale);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400054B RID: 1355
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyle3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400054C RID: 1356
		public new static readonly string MRClassNameKey = "class vtkInteractorStyle3D";
	}
}
