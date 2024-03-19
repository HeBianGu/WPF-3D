using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOSPRayVolumeInterface
	/// </summary>
	/// <remarks>
	///    Removes link dependence
	/// on optional ospray module.
	///
	/// Class allows SmartVolume to use OSPRay for rendering when ospray
	/// is enabled. When disabled, this class does nothing but return a warning.
	/// </remarks>
	// Token: 0x0200039F RID: 927
	public class vtkOSPRayVolumeInterface : vtkVolumeMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A8F5 RID: 43253 RVA: 0x000EFE17 File Offset: 0x000EE017
		static vtkOSPRayVolumeInterface()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOSPRayVolumeInterface.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOSPRayVolumeInterface"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A8F6 RID: 43254 RVA: 0x000EFE3F File Offset: 0x000EE03F
		public vtkOSPRayVolumeInterface(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A8F7 RID: 43255
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOSPRayVolumeInterface_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A8F8 RID: 43256 RVA: 0x000EFE50 File Offset: 0x000EE050
		public new static vtkOSPRayVolumeInterface New()
		{
			vtkOSPRayVolumeInterface result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOSPRayVolumeInterface.vtkOSPRayVolumeInterface_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOSPRayVolumeInterface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A8F9 RID: 43257 RVA: 0x000EFEA4 File Offset: 0x000EE0A4
		public vtkOSPRayVolumeInterface() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOSPRayVolumeInterface.vtkOSPRayVolumeInterface_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A8FA RID: 43258 RVA: 0x000EFEE8 File Offset: 0x000EE0E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A8FB RID: 43259
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOSPRayVolumeInterface_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A8FC RID: 43260 RVA: 0x000EFEF4 File Offset: 0x000EE0F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOSPRayVolumeInterface.vtkOSPRayVolumeInterface_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600A8FD RID: 43261
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOSPRayVolumeInterface_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A8FE RID: 43262 RVA: 0x000EFF14 File Offset: 0x000EE114
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOSPRayVolumeInterface.vtkOSPRayVolumeInterface_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600A8FF RID: 43263
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOSPRayVolumeInterface_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A900 RID: 43264 RVA: 0x000EFF30 File Offset: 0x000EE130
		public override int IsA(string type)
		{
			return vtkOSPRayVolumeInterface.vtkOSPRayVolumeInterface_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600A901 RID: 43265
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOSPRayVolumeInterface_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A902 RID: 43266 RVA: 0x000EFF50 File Offset: 0x000EE150
		public new static int IsTypeOf(string type)
		{
			return vtkOSPRayVolumeInterface.vtkOSPRayVolumeInterface_IsTypeOf_04(type);
		}

		// Token: 0x0600A903 RID: 43267
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOSPRayVolumeInterface_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A904 RID: 43268 RVA: 0x000EFF6C File Offset: 0x000EE16C
		public new vtkOSPRayVolumeInterface NewInstance()
		{
			vtkOSPRayVolumeInterface result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOSPRayVolumeInterface.vtkOSPRayVolumeInterface_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOSPRayVolumeInterface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A905 RID: 43269
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOSPRayVolumeInterface_Render_07(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Overridden to warn about lack of OSPRay if not overridden.
		/// </summary>
		// Token: 0x0600A906 RID: 43270 RVA: 0x000EFFC8 File Offset: 0x000EE1C8
		public override void Render(vtkRenderer arg0, vtkVolume arg1)
		{
			vtkOSPRayVolumeInterface.vtkOSPRayVolumeInterface_Render_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600A907 RID: 43271
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOSPRayVolumeInterface_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A908 RID: 43272 RVA: 0x000F000C File Offset: 0x000EE20C
		public new static vtkOSPRayVolumeInterface SafeDownCast(vtkObjectBase o)
		{
			vtkOSPRayVolumeInterface vtkOSPRayVolumeInterface = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOSPRayVolumeInterface.vtkOSPRayVolumeInterface_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOSPRayVolumeInterface = (vtkOSPRayVolumeInterface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOSPRayVolumeInterface.Register(null);
				}
			}
			return vtkOSPRayVolumeInterface;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D73 RID: 3443
		public new const string MRFullTypeName = "Kitware.VTK.vtkOSPRayVolumeInterface";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D74 RID: 3444
		public new static readonly string MRClassNameKey = "class vtkOSPRayVolumeInterface";
	}
}
