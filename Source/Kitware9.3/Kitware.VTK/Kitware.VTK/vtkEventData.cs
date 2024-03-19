using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <remarks>
	///    platform-independent event data structures
	/// </remarks>
	// Token: 0x0200040D RID: 1037
	public abstract class vtkEventData : vtkObjectBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C4BD RID: 50365 RVA: 0x001117C5 File Offset: 0x0010F9C5
		static vtkEventData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEventData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEventData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C4BE RID: 50366 RVA: 0x001117ED File Offset: 0x0010F9ED
		public vtkEventData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C4BF RID: 50367 RVA: 0x001117FB File Offset: 0x0010F9FB
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C4C0 RID: 50368
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEventData_GetAsEventDataDevice3D_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4C1 RID: 50369 RVA: 0x00111808 File Offset: 0x0010FA08
		public virtual vtkEventDataDevice3D GetAsEventDataDevice3D()
		{
			vtkEventDataDevice3D vtkEventDataDevice3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEventData.vtkEventData_GetAsEventDataDevice3D_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEventDataDevice3D = (vtkEventDataDevice3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEventDataDevice3D.Register(null);
				}
			}
			return vtkEventDataDevice3D;
		}

		// Token: 0x0600C4C2 RID: 50370
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEventData_GetAsEventDataForDevice_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4C3 RID: 50371 RVA: 0x00111878 File Offset: 0x0010FA78
		public virtual vtkEventDataForDevice GetAsEventDataForDevice()
		{
			vtkEventDataForDevice vtkEventDataForDevice = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEventData.vtkEventData_GetAsEventDataForDevice_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600C4C4 RID: 50372
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEventData_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4C5 RID: 50373 RVA: 0x001118E8 File Offset: 0x0010FAE8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEventData.vtkEventData_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600C4C6 RID: 50374
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEventData_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4C7 RID: 50375 RVA: 0x00111908 File Offset: 0x0010FB08
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEventData.vtkEventData_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600C4C8 RID: 50376
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEventData_GetType_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4C9 RID: 50377 RVA: 0x00111924 File Offset: 0x0010FB24
		public int GetTypeWrapper()
		{
			return vtkEventData.vtkEventData_GetType_05(base.GetCppThis());
		}

		// Token: 0x0600C4CA RID: 50378
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEventData_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4CB RID: 50379 RVA: 0x00111944 File Offset: 0x0010FB44
		public override int IsA(string type)
		{
			return vtkEventData.vtkEventData_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600C4CC RID: 50380
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEventData_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4CD RID: 50381 RVA: 0x00111964 File Offset: 0x0010FB64
		public new static int IsTypeOf(string type)
		{
			return vtkEventData.vtkEventData_IsTypeOf_07(type);
		}

		// Token: 0x0600C4CE RID: 50382
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEventData_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4CF RID: 50383 RVA: 0x00111980 File Offset: 0x0010FB80
		public vtkEventData NewInstance()
		{
			vtkEventData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEventData.vtkEventData_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEventData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C4D0 RID: 50384
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEventData_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4D1 RID: 50385 RVA: 0x001119DC File Offset: 0x0010FBDC
		public static vtkEventData SafeDownCast(vtkObjectBase o)
		{
			vtkEventData vtkEventData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEventData.vtkEventData_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEventData = (vtkEventData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEventData.Register(null);
				}
			}
			return vtkEventData;
		}

		// Token: 0x0600C4D2 RID: 50386
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEventData_SetType_10(HandleRef pThis, int val);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4D3 RID: 50387 RVA: 0x00111A5B File Offset: 0x0010FC5B
		public void SetType(int val)
		{
			vtkEventData.vtkEventData_SetType_10(base.GetCppThis(), val);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E95 RID: 3733
		public new const string MRFullTypeName = "Kitware.VTK.vtkEventData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E96 RID: 3734
		public new static readonly string MRClassNameKey = "class vtkEventData";
	}
}
