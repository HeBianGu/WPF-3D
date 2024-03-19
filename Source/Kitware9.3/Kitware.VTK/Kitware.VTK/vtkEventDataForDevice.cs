using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <remarks>
	///    platform-independent event data structures
	/// </remarks>
	// Token: 0x0200040E RID: 1038
	public class vtkEventDataForDevice : vtkEventData
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C4D4 RID: 50388 RVA: 0x00111A6B File Offset: 0x0010FC6B
		static vtkEventDataForDevice()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEventDataForDevice.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEventDataForDevice"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C4D5 RID: 50389 RVA: 0x00111A93 File Offset: 0x0010FC93
		public vtkEventDataForDevice(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C4D6 RID: 50390
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEventDataForDevice_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4D7 RID: 50391 RVA: 0x00111AA4 File Offset: 0x0010FCA4
		public new static vtkEventDataForDevice New()
		{
			vtkEventDataForDevice result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEventDataForDevice.vtkEventDataForDevice_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEventDataForDevice)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4D8 RID: 50392 RVA: 0x00111AF8 File Offset: 0x0010FCF8
		public vtkEventDataForDevice() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEventDataForDevice.vtkEventDataForDevice_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C4D9 RID: 50393 RVA: 0x00111B3C File Offset: 0x0010FD3C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C4DA RID: 50394
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkEventDataForDevice_DeviceMatches_01(HandleRef pThis, vtkEventDataDevice val);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4DB RID: 50395 RVA: 0x00111B48 File Offset: 0x0010FD48
		public bool DeviceMatches(vtkEventDataDevice val)
		{
			return vtkEventDataForDevice.vtkEventDataForDevice_DeviceMatches_01(base.GetCppThis(), val) != 0;
		}

		// Token: 0x0600C4DC RID: 50396
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkEventDataAction vtkEventDataForDevice_GetAction_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4DD RID: 50397 RVA: 0x00111B70 File Offset: 0x0010FD70
		public vtkEventDataAction GetAction()
		{
			return vtkEventDataForDevice.vtkEventDataForDevice_GetAction_02(base.GetCppThis());
		}

		// Token: 0x0600C4DE RID: 50398
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEventDataForDevice_GetAsEventDataForDevice_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4DF RID: 50399 RVA: 0x00111B90 File Offset: 0x0010FD90
		public override vtkEventDataForDevice GetAsEventDataForDevice()
		{
			vtkEventDataForDevice vtkEventDataForDevice = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEventDataForDevice.vtkEventDataForDevice_GetAsEventDataForDevice_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEventDataForDevice = (vtkEventDataForDevice)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEventDataForDevice.Register(null);
				}
			}
			return vtkEventDataForDevice;
		}

		// Token: 0x0600C4E0 RID: 50400
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkEventDataDevice vtkEventDataForDevice_GetDevice_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4E1 RID: 50401 RVA: 0x00111C00 File Offset: 0x0010FE00
		public vtkEventDataDevice GetDevice()
		{
			return vtkEventDataForDevice.vtkEventDataForDevice_GetDevice_04(base.GetCppThis());
		}

		// Token: 0x0600C4E2 RID: 50402
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkEventDataDeviceInput vtkEventDataForDevice_GetInput_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4E3 RID: 50403 RVA: 0x00111C20 File Offset: 0x0010FE20
		public vtkEventDataDeviceInput GetInput()
		{
			return vtkEventDataForDevice.vtkEventDataForDevice_GetInput_05(base.GetCppThis());
		}

		// Token: 0x0600C4E4 RID: 50404
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEventDataForDevice_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4E5 RID: 50405 RVA: 0x00111C40 File Offset: 0x0010FE40
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEventDataForDevice.vtkEventDataForDevice_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600C4E6 RID: 50406
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEventDataForDevice_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4E7 RID: 50407 RVA: 0x00111C60 File Offset: 0x0010FE60
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEventDataForDevice.vtkEventDataForDevice_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600C4E8 RID: 50408
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEventDataForDevice_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4E9 RID: 50409 RVA: 0x00111C7C File Offset: 0x0010FE7C
		public override int IsA(string type)
		{
			return vtkEventDataForDevice.vtkEventDataForDevice_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600C4EA RID: 50410
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEventDataForDevice_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4EB RID: 50411 RVA: 0x00111C9C File Offset: 0x0010FE9C
		public new static int IsTypeOf(string type)
		{
			return vtkEventDataForDevice.vtkEventDataForDevice_IsTypeOf_09(type);
		}

		// Token: 0x0600C4EC RID: 50412
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEventDataForDevice_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4ED RID: 50413 RVA: 0x00111CB8 File Offset: 0x0010FEB8
		public new vtkEventDataForDevice NewInstance()
		{
			vtkEventDataForDevice result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEventDataForDevice.vtkEventDataForDevice_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEventDataForDevice)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C4EE RID: 50414
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEventDataForDevice_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4EF RID: 50415 RVA: 0x00111D14 File Offset: 0x0010FF14
		public new static vtkEventDataForDevice SafeDownCast(vtkObjectBase o)
		{
			vtkEventDataForDevice vtkEventDataForDevice = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEventDataForDevice.vtkEventDataForDevice_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEventDataForDevice = (vtkEventDataForDevice)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEventDataForDevice.Register(null);
				}
			}
			return vtkEventDataForDevice;
		}

		// Token: 0x0600C4F0 RID: 50416
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEventDataForDevice_SetAction_13(HandleRef pThis, vtkEventDataAction v);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4F1 RID: 50417 RVA: 0x00111D93 File Offset: 0x0010FF93
		public void SetAction(vtkEventDataAction v)
		{
			vtkEventDataForDevice.vtkEventDataForDevice_SetAction_13(base.GetCppThis(), v);
		}

		// Token: 0x0600C4F2 RID: 50418
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEventDataForDevice_SetDevice_14(HandleRef pThis, vtkEventDataDevice v);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4F3 RID: 50419 RVA: 0x00111DA3 File Offset: 0x0010FFA3
		public void SetDevice(vtkEventDataDevice v)
		{
			vtkEventDataForDevice.vtkEventDataForDevice_SetDevice_14(base.GetCppThis(), v);
		}

		// Token: 0x0600C4F4 RID: 50420
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEventDataForDevice_SetInput_15(HandleRef pThis, vtkEventDataDeviceInput v);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4F5 RID: 50421 RVA: 0x00111DB3 File Offset: 0x0010FFB3
		public void SetInput(vtkEventDataDeviceInput v)
		{
			vtkEventDataForDevice.vtkEventDataForDevice_SetInput_15(base.GetCppThis(), v);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E97 RID: 3735
		public new const string MRFullTypeName = "Kitware.VTK.vtkEventDataForDevice";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E98 RID: 3736
		public new static readonly string MRClassNameKey = "class vtkEventDataForDevice";
	}
}
