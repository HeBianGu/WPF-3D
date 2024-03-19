using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGPUInfo
	/// </summary>
	/// <remarks>
	///    Stores GPU VRAM information.
	///
	/// vtkGPUInfo stores information about GPU Video RAM. An host can have
	/// several GPUs. The values are set by vtkGPUInfoList.
	/// </remarks>
	/// <seealso>
	///
	/// vtkGPUInfoList vtkDirectXGPUInfoList vtkCoreGraphicsGPUInfoList
	/// </seealso>
	// Token: 0x020007E0 RID: 2016
	public class vtkGPUInfo : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014B44 RID: 84804 RVA: 0x001D4E30 File Offset: 0x001D3030
		static vtkGPUInfo()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGPUInfo.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGPUInfo"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014B45 RID: 84805 RVA: 0x001D4E58 File Offset: 0x001D3058
		public vtkGPUInfo(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014B46 RID: 84806
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGPUInfo_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B47 RID: 84807 RVA: 0x001D4E68 File Offset: 0x001D3068
		public new static vtkGPUInfo New()
		{
			vtkGPUInfo result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGPUInfo.vtkGPUInfo_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGPUInfo)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B48 RID: 84808 RVA: 0x001D4EBC File Offset: 0x001D30BC
		public vtkGPUInfo() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGPUInfo.vtkGPUInfo_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014B49 RID: 84809 RVA: 0x001D4F00 File Offset: 0x001D3100
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014B4A RID: 84810
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkGPUInfo_GetDedicatedSystemMemory_01(HandleRef pThis);

		/// <summary>
		/// Set/Get dedicated system memory in bytes. Initial value is 0.
		/// This is slow memory. If it is not 0, this value should be taken into
		/// account only if there is no DedicatedVideoMemory and SharedSystemMemory
		/// should be ignored.
		/// </summary>
		// Token: 0x06014B4B RID: 84811 RVA: 0x001D4F0C File Offset: 0x001D310C
		public virtual ulong GetDedicatedSystemMemory()
		{
			return vtkGPUInfo.vtkGPUInfo_GetDedicatedSystemMemory_01(base.GetCppThis());
		}

		// Token: 0x06014B4C RID: 84812
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkGPUInfo_GetDedicatedVideoMemory_02(HandleRef pThis);

		/// <summary>
		/// Set/Get dedicated video memory in bytes. Initial value is 0.
		/// Usually the fastest one. If it is not 0, it should be taken into
		/// account first and DedicatedSystemMemory or SharedSystemMemory should be
		/// ignored.
		/// </summary>
		// Token: 0x06014B4D RID: 84813 RVA: 0x001D4F2C File Offset: 0x001D312C
		public virtual ulong GetDedicatedVideoMemory()
		{
			return vtkGPUInfo.vtkGPUInfo_GetDedicatedVideoMemory_02(base.GetCppThis());
		}

		// Token: 0x06014B4E RID: 84814
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGPUInfo_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B4F RID: 84815 RVA: 0x001D4F4C File Offset: 0x001D314C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGPUInfo.vtkGPUInfo_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06014B50 RID: 84816
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGPUInfo_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B51 RID: 84817 RVA: 0x001D4F6C File Offset: 0x001D316C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGPUInfo.vtkGPUInfo_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06014B52 RID: 84818
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkGPUInfo_GetSharedSystemMemory_05(HandleRef pThis);

		/// <summary>
		/// Set/Get shared system memory in bytes. Initial value is 0.
		/// Slowest memory. This value should be taken into account only if there is
		/// neither DedicatedVideoMemory nor DedicatedSystemMemory.
		/// </summary>
		// Token: 0x06014B53 RID: 84819 RVA: 0x001D4F88 File Offset: 0x001D3188
		public virtual ulong GetSharedSystemMemory()
		{
			return vtkGPUInfo.vtkGPUInfo_GetSharedSystemMemory_05(base.GetCppThis());
		}

		// Token: 0x06014B54 RID: 84820
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUInfo_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B55 RID: 84821 RVA: 0x001D4FA8 File Offset: 0x001D31A8
		public override int IsA(string type)
		{
			return vtkGPUInfo.vtkGPUInfo_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06014B56 RID: 84822
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUInfo_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B57 RID: 84823 RVA: 0x001D4FC8 File Offset: 0x001D31C8
		public new static int IsTypeOf(string type)
		{
			return vtkGPUInfo.vtkGPUInfo_IsTypeOf_07(type);
		}

		// Token: 0x06014B58 RID: 84824
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGPUInfo_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B59 RID: 84825 RVA: 0x001D4FE4 File Offset: 0x001D31E4
		public new vtkGPUInfo NewInstance()
		{
			vtkGPUInfo result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGPUInfo.vtkGPUInfo_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGPUInfo)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014B5A RID: 84826
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGPUInfo_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B5B RID: 84827 RVA: 0x001D5040 File Offset: 0x001D3240
		public new static vtkGPUInfo SafeDownCast(vtkObjectBase o)
		{
			vtkGPUInfo vtkGPUInfo = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGPUInfo.vtkGPUInfo_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGPUInfo = (vtkGPUInfo)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGPUInfo.Register(null);
				}
			}
			return vtkGPUInfo;
		}

		// Token: 0x06014B5C RID: 84828
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUInfo_SetDedicatedSystemMemory_11(HandleRef pThis, ulong _arg);

		/// <summary>
		/// Set/Get dedicated system memory in bytes. Initial value is 0.
		/// This is slow memory. If it is not 0, this value should be taken into
		/// account only if there is no DedicatedVideoMemory and SharedSystemMemory
		/// should be ignored.
		/// </summary>
		// Token: 0x06014B5D RID: 84829 RVA: 0x001D50BF File Offset: 0x001D32BF
		public virtual void SetDedicatedSystemMemory(ulong _arg)
		{
			vtkGPUInfo.vtkGPUInfo_SetDedicatedSystemMemory_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06014B5E RID: 84830
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUInfo_SetDedicatedVideoMemory_12(HandleRef pThis, ulong _arg);

		/// <summary>
		/// Set/Get dedicated video memory in bytes. Initial value is 0.
		/// Usually the fastest one. If it is not 0, it should be taken into
		/// account first and DedicatedSystemMemory or SharedSystemMemory should be
		/// ignored.
		/// </summary>
		// Token: 0x06014B5F RID: 84831 RVA: 0x001D50CF File Offset: 0x001D32CF
		public virtual void SetDedicatedVideoMemory(ulong _arg)
		{
			vtkGPUInfo.vtkGPUInfo_SetDedicatedVideoMemory_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06014B60 RID: 84832
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUInfo_SetSharedSystemMemory_13(HandleRef pThis, ulong _arg);

		/// <summary>
		/// Set/Get shared system memory in bytes. Initial value is 0.
		/// Slowest memory. This value should be taken into account only if there is
		/// neither DedicatedVideoMemory nor DedicatedSystemMemory.
		/// </summary>
		// Token: 0x06014B61 RID: 84833 RVA: 0x001D50DF File Offset: 0x001D32DF
		public virtual void SetSharedSystemMemory(ulong _arg)
		{
			vtkGPUInfo.vtkGPUInfo_SetSharedSystemMemory_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017ED RID: 6125
		public new const string MRFullTypeName = "Kitware.VTK.vtkGPUInfo";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017EE RID: 6126
		public new static readonly string MRClassNameKey = "class vtkGPUInfo";
	}
}
