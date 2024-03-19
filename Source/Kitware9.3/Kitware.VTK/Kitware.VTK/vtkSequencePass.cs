using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSequencePass
	/// </summary>
	/// <remarks>
	///    Execute render passes sequentially.
	///
	/// vtkSequencePass executes a list of render passes sequentially.
	/// This class allows to define a sequence of render passes at run time.
	/// The other solution to write a sequence of render passes is to write an
	/// effective subclass of vtkRenderPass.
	///
	/// As vtkSequencePass is a vtkRenderPass itself, it is possible to have a
	/// hierarchy of render passes built at runtime.
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass
	/// </seealso>
	// Token: 0x020005E7 RID: 1511
	public class vtkSequencePass : vtkRenderPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601075F RID: 67423 RVA: 0x0016F5A7 File Offset: 0x0016D7A7
		static vtkSequencePass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSequencePass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSequencePass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010760 RID: 67424 RVA: 0x0016F5CF File Offset: 0x0016D7CF
		public vtkSequencePass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010761 RID: 67425
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSequencePass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010762 RID: 67426 RVA: 0x0016F5E0 File Offset: 0x0016D7E0
		public new static vtkSequencePass New()
		{
			vtkSequencePass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSequencePass.vtkSequencePass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSequencePass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010763 RID: 67427 RVA: 0x0016F634 File Offset: 0x0016D834
		public vtkSequencePass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSequencePass.vtkSequencePass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010764 RID: 67428 RVA: 0x0016F678 File Offset: 0x0016D878
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010765 RID: 67429
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSequencePass_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010766 RID: 67430 RVA: 0x0016F684 File Offset: 0x0016D884
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSequencePass.vtkSequencePass_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06010767 RID: 67431
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSequencePass_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010768 RID: 67432 RVA: 0x0016F6A4 File Offset: 0x0016D8A4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSequencePass.vtkSequencePass_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06010769 RID: 67433
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSequencePass_GetPasses_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The ordered list of render passes to execute sequentially.
		/// If the pointer is NULL or the list is empty, it is silently ignored.
		/// There is no warning.
		/// Initial value is a NULL pointer.
		/// </summary>
		// Token: 0x0601076A RID: 67434 RVA: 0x0016F6C0 File Offset: 0x0016D8C0
		public virtual vtkRenderPassCollection GetPasses()
		{
			vtkRenderPassCollection vtkRenderPassCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSequencePass.vtkSequencePass_GetPasses_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderPassCollection = (vtkRenderPassCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderPassCollection.Register(null);
				}
			}
			return vtkRenderPassCollection;
		}

		// Token: 0x0601076B RID: 67435
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSequencePass_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601076C RID: 67436 RVA: 0x0016F730 File Offset: 0x0016D930
		public override int IsA(string type)
		{
			return vtkSequencePass.vtkSequencePass_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601076D RID: 67437
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSequencePass_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601076E RID: 67438 RVA: 0x0016F750 File Offset: 0x0016D950
		public new static int IsTypeOf(string type)
		{
			return vtkSequencePass.vtkSequencePass_IsTypeOf_05(type);
		}

		// Token: 0x0601076F RID: 67439
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSequencePass_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010770 RID: 67440 RVA: 0x0016F76C File Offset: 0x0016D96C
		public new vtkSequencePass NewInstance()
		{
			vtkSequencePass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSequencePass.vtkSequencePass_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSequencePass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010771 RID: 67441
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSequencePass_ReleaseGraphicsResources_08(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Release graphics resources and ask components to release their own
		/// resources.
		/// \pre w_exists: w!=0
		/// </summary>
		// Token: 0x06010772 RID: 67442 RVA: 0x0016F7C8 File Offset: 0x0016D9C8
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkSequencePass.vtkSequencePass_ReleaseGraphicsResources_08(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x06010773 RID: 67443
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSequencePass_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010774 RID: 67444 RVA: 0x0016F7F8 File Offset: 0x0016D9F8
		public new static vtkSequencePass SafeDownCast(vtkObjectBase o)
		{
			vtkSequencePass vtkSequencePass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSequencePass.vtkSequencePass_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSequencePass = (vtkSequencePass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSequencePass.Register(null);
				}
			}
			return vtkSequencePass;
		}

		// Token: 0x06010775 RID: 67445
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSequencePass_SetPasses_10(HandleRef pThis, HandleRef passes);

		/// <summary>
		/// The ordered list of render passes to execute sequentially.
		/// If the pointer is NULL or the list is empty, it is silently ignored.
		/// There is no warning.
		/// Initial value is a NULL pointer.
		/// </summary>
		// Token: 0x06010776 RID: 67446 RVA: 0x0016F878 File Offset: 0x0016DA78
		public virtual void SetPasses(vtkRenderPassCollection passes)
		{
			vtkSequencePass.vtkSequencePass_SetPasses_10(base.GetCppThis(), (passes == null) ? default(HandleRef) : passes.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400131A RID: 4890
		public new const string MRFullTypeName = "Kitware.VTK.vtkSequencePass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400131B RID: 4891
		public new static readonly string MRClassNameKey = "class vtkSequencePass";
	}
}
