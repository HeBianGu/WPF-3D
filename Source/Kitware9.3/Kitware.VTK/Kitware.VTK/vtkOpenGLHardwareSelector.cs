using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLHardwareSelector
	/// </summary>
	/// <remarks>
	///    implements the device specific code of
	///  vtkOpenGLHardwareSelector.
	///
	///
	/// Implements the device specific code of vtkOpenGLHardwareSelector.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkHardwareSelector
	/// </seealso>
	// Token: 0x020005B1 RID: 1457
	public class vtkOpenGLHardwareSelector : vtkHardwareSelector
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FF86 RID: 65414 RVA: 0x001638DB File Offset: 0x00161ADB
		static vtkOpenGLHardwareSelector()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLHardwareSelector.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLHardwareSelector"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FF87 RID: 65415 RVA: 0x00163903 File Offset: 0x00161B03
		public vtkOpenGLHardwareSelector(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FF88 RID: 65416
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLHardwareSelector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FF89 RID: 65417 RVA: 0x00163914 File Offset: 0x00161B14
		public new static vtkOpenGLHardwareSelector New()
		{
			vtkOpenGLHardwareSelector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLHardwareSelector.vtkOpenGLHardwareSelector_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLHardwareSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FF8A RID: 65418 RVA: 0x00163968 File Offset: 0x00161B68
		public vtkOpenGLHardwareSelector() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLHardwareSelector.vtkOpenGLHardwareSelector_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FF8B RID: 65419 RVA: 0x001639AC File Offset: 0x00161BAC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FF8C RID: 65420
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLHardwareSelector_BeginRenderProp_01(HandleRef pThis);

		/// <summary>
		/// Called by the mapper before and after
		/// rendering each prop.
		/// </summary>
		// Token: 0x0600FF8D RID: 65421 RVA: 0x001639B7 File Offset: 0x00161BB7
		public override void BeginRenderProp()
		{
			vtkOpenGLHardwareSelector.vtkOpenGLHardwareSelector_BeginRenderProp_01(base.GetCppThis());
		}

		// Token: 0x0600FF8E RID: 65422
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLHardwareSelector_BeginSelection_02(HandleRef pThis);

		/// <summary>
		/// Called by any vtkMapper or subclass to render process id. This has any
		/// effect when this-&gt;UseProcessIdFromData is true.
		/// </summary>
		// Token: 0x0600FF8F RID: 65423 RVA: 0x001639C6 File Offset: 0x00161BC6
		public virtual void BeginSelection()
		{
			vtkOpenGLHardwareSelector.vtkOpenGLHardwareSelector_BeginSelection_02(base.GetCppThis());
		}

		// Token: 0x0600FF90 RID: 65424
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLHardwareSelector_EndRenderProp_03(HandleRef pThis);

		/// <summary>
		/// Called by the mapper before and after
		/// rendering each prop.
		/// </summary>
		// Token: 0x0600FF91 RID: 65425 RVA: 0x001639D5 File Offset: 0x00161BD5
		public override void EndRenderProp()
		{
			vtkOpenGLHardwareSelector.vtkOpenGLHardwareSelector_EndRenderProp_03(base.GetCppThis());
		}

		// Token: 0x0600FF92 RID: 65426
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLHardwareSelector_EndSelection_04(HandleRef pThis);

		/// <summary>
		/// Called by any vtkMapper or subclass to render process id. This has any
		/// effect when this-&gt;UseProcessIdFromData is true.
		/// </summary>
		// Token: 0x0600FF93 RID: 65427 RVA: 0x001639E4 File Offset: 0x00161BE4
		public virtual void EndSelection()
		{
			vtkOpenGLHardwareSelector.vtkOpenGLHardwareSelector_EndSelection_04(base.GetCppThis());
		}

		// Token: 0x0600FF94 RID: 65428
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLHardwareSelector_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FF95 RID: 65429 RVA: 0x001639F4 File Offset: 0x00161BF4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLHardwareSelector.vtkOpenGLHardwareSelector_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600FF96 RID: 65430
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLHardwareSelector_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FF97 RID: 65431 RVA: 0x00163A14 File Offset: 0x00161C14
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLHardwareSelector.vtkOpenGLHardwareSelector_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600FF98 RID: 65432
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLHardwareSelector_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FF99 RID: 65433 RVA: 0x00163A30 File Offset: 0x00161C30
		public override int IsA(string type)
		{
			return vtkOpenGLHardwareSelector.vtkOpenGLHardwareSelector_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600FF9A RID: 65434
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLHardwareSelector_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FF9B RID: 65435 RVA: 0x00163A50 File Offset: 0x00161C50
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLHardwareSelector.vtkOpenGLHardwareSelector_IsTypeOf_08(type);
		}

		// Token: 0x0600FF9C RID: 65436
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLHardwareSelector_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FF9D RID: 65437 RVA: 0x00163A6C File Offset: 0x00161C6C
		public new vtkOpenGLHardwareSelector NewInstance()
		{
			vtkOpenGLHardwareSelector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLHardwareSelector.vtkOpenGLHardwareSelector_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLHardwareSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FF9E RID: 65438
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLHardwareSelector_RenderCompositeIndex_11(HandleRef pThis, uint index);

		/// <summary>
		/// Called by any vtkMapper or vtkProp subclass to render a composite-index.
		/// Currently indices &gt;= 0xffffff are not supported.
		/// </summary>
		// Token: 0x0600FF9F RID: 65439 RVA: 0x00163AC6 File Offset: 0x00161CC6
		public override void RenderCompositeIndex(uint index)
		{
			vtkOpenGLHardwareSelector.vtkOpenGLHardwareSelector_RenderCompositeIndex_11(base.GetCppThis(), index);
		}

		// Token: 0x0600FFA0 RID: 65440
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLHardwareSelector_RenderProcessId_12(HandleRef pThis, uint processid);

		/// <summary>
		/// Called by any vtkMapper or subclass to render process id. This has any
		/// effect when this-&gt;UseProcessIdFromData is true.
		/// </summary>
		// Token: 0x0600FFA1 RID: 65441 RVA: 0x00163AD6 File Offset: 0x00161CD6
		public override void RenderProcessId(uint processid)
		{
			vtkOpenGLHardwareSelector.vtkOpenGLHardwareSelector_RenderProcessId_12(base.GetCppThis(), processid);
		}

		// Token: 0x0600FFA2 RID: 65442
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLHardwareSelector_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFA3 RID: 65443 RVA: 0x00163AE8 File Offset: 0x00161CE8
		public new static vtkOpenGLHardwareSelector SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLHardwareSelector vtkOpenGLHardwareSelector = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLHardwareSelector.vtkOpenGLHardwareSelector_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLHardwareSelector = (vtkOpenGLHardwareSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLHardwareSelector.Register(null);
				}
			}
			return vtkOpenGLHardwareSelector;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012A4 RID: 4772
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLHardwareSelector";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012A5 RID: 4773
		public new static readonly string MRClassNameKey = "class vtkOpenGLHardwareSelector";
	}
}
