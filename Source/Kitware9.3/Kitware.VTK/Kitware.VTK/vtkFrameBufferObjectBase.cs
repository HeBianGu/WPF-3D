using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFrameBufferObjectBase
	/// </summary>
	/// <remarks>
	///    abstract interface to OpenGL FBOs
	///
	/// API for classes that encapsulate an OpenGL Frame Buffer Object.
	/// </remarks>
	// Token: 0x020005A8 RID: 1448
	public abstract class vtkFrameBufferObjectBase : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FDCB RID: 64971 RVA: 0x001617DE File Offset: 0x0015F9DE
		static vtkFrameBufferObjectBase()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFrameBufferObjectBase.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFrameBufferObjectBase"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FDCC RID: 64972 RVA: 0x00161806 File Offset: 0x0015FA06
		public vtkFrameBufferObjectBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FDCD RID: 64973 RVA: 0x00161814 File Offset: 0x0015FA14
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FDCE RID: 64974
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFrameBufferObjectBase_GetLastSize_01(HandleRef pThis);

		/// <summary>
		/// Dimensions in pixels of the framebuffer.
		/// </summary>
		// Token: 0x0600FDCF RID: 64975 RVA: 0x00161820 File Offset: 0x0015FA20
		public virtual IntPtr GetLastSize()
		{
			return vtkFrameBufferObjectBase.vtkFrameBufferObjectBase_GetLastSize_01(base.GetCppThis());
		}

		// Token: 0x0600FDD0 RID: 64976
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFrameBufferObjectBase_GetLastSize_02(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Dimensions in pixels of the framebuffer.
		/// </summary>
		// Token: 0x0600FDD1 RID: 64977 RVA: 0x0016183F File Offset: 0x0015FA3F
		public virtual void GetLastSize(ref int _arg1, ref int _arg2)
		{
			vtkFrameBufferObjectBase.vtkFrameBufferObjectBase_GetLastSize_02(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600FDD2 RID: 64978
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFrameBufferObjectBase_GetLastSize_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Dimensions in pixels of the framebuffer.
		/// </summary>
		// Token: 0x0600FDD3 RID: 64979 RVA: 0x00161850 File Offset: 0x0015FA50
		public virtual void GetLastSize(IntPtr _arg)
		{
			vtkFrameBufferObjectBase.vtkFrameBufferObjectBase_GetLastSize_03(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FDD4 RID: 64980
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFrameBufferObjectBase_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FDD5 RID: 64981 RVA: 0x00161860 File Offset: 0x0015FA60
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFrameBufferObjectBase.vtkFrameBufferObjectBase_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600FDD6 RID: 64982
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFrameBufferObjectBase_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FDD7 RID: 64983 RVA: 0x00161880 File Offset: 0x0015FA80
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFrameBufferObjectBase.vtkFrameBufferObjectBase_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600FDD8 RID: 64984
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFrameBufferObjectBase_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FDD9 RID: 64985 RVA: 0x0016189C File Offset: 0x0015FA9C
		public override int IsA(string type)
		{
			return vtkFrameBufferObjectBase.vtkFrameBufferObjectBase_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600FDDA RID: 64986
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFrameBufferObjectBase_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FDDB RID: 64987 RVA: 0x001618BC File Offset: 0x0015FABC
		public new static int IsTypeOf(string type)
		{
			return vtkFrameBufferObjectBase.vtkFrameBufferObjectBase_IsTypeOf_07(type);
		}

		// Token: 0x0600FDDC RID: 64988
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFrameBufferObjectBase_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FDDD RID: 64989 RVA: 0x001618D8 File Offset: 0x0015FAD8
		public new vtkFrameBufferObjectBase NewInstance()
		{
			vtkFrameBufferObjectBase result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFrameBufferObjectBase.vtkFrameBufferObjectBase_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFrameBufferObjectBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FDDE RID: 64990
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFrameBufferObjectBase_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FDDF RID: 64991 RVA: 0x00161934 File Offset: 0x0015FB34
		public new static vtkFrameBufferObjectBase SafeDownCast(vtkObjectBase o)
		{
			vtkFrameBufferObjectBase vtkFrameBufferObjectBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFrameBufferObjectBase.vtkFrameBufferObjectBase_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFrameBufferObjectBase = (vtkFrameBufferObjectBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFrameBufferObjectBase.Register(null);
				}
			}
			return vtkFrameBufferObjectBase;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001282 RID: 4738
		public new const string MRFullTypeName = "Kitware.VTK.vtkFrameBufferObjectBase";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001283 RID: 4739
		public new static readonly string MRClassNameKey = "class vtkFrameBufferObjectBase";
	}
}
