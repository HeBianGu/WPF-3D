using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOverlayPass
	/// </summary>
	/// <remarks>
	///    Render the overlay geometry with property key
	/// filtering.
	///
	/// vtkOverlayPass renders the overlay geometry of all the props that have the
	/// keys contained in vtkRenderState.
	///
	/// This pass expects an initialized depth buffer and color buffer.
	/// Initialized buffers means they have been cleared with farthest z-value and
	/// background color/gradient/transparent color.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass vtkDefaultPass
	/// </seealso>
	// Token: 0x020005DC RID: 1500
	public class vtkOverlayPass : vtkDefaultPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060105ED RID: 67053 RVA: 0x0016CFDB File Offset: 0x0016B1DB
		static vtkOverlayPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOverlayPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOverlayPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060105EE RID: 67054 RVA: 0x0016D003 File Offset: 0x0016B203
		public vtkOverlayPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060105EF RID: 67055
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverlayPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105F0 RID: 67056 RVA: 0x0016D014 File Offset: 0x0016B214
		public new static vtkOverlayPass New()
		{
			vtkOverlayPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverlayPass.vtkOverlayPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOverlayPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105F1 RID: 67057 RVA: 0x0016D068 File Offset: 0x0016B268
		public vtkOverlayPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOverlayPass.vtkOverlayPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060105F2 RID: 67058 RVA: 0x0016D0AC File Offset: 0x0016B2AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060105F3 RID: 67059
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOverlayPass_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105F4 RID: 67060 RVA: 0x0016D0B8 File Offset: 0x0016B2B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOverlayPass.vtkOverlayPass_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060105F5 RID: 67061
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOverlayPass_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105F6 RID: 67062 RVA: 0x0016D0D8 File Offset: 0x0016B2D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOverlayPass.vtkOverlayPass_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060105F7 RID: 67063
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOverlayPass_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105F8 RID: 67064 RVA: 0x0016D0F4 File Offset: 0x0016B2F4
		public override int IsA(string type)
		{
			return vtkOverlayPass.vtkOverlayPass_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060105F9 RID: 67065
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOverlayPass_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105FA RID: 67066 RVA: 0x0016D114 File Offset: 0x0016B314
		public new static int IsTypeOf(string type)
		{
			return vtkOverlayPass.vtkOverlayPass_IsTypeOf_04(type);
		}

		// Token: 0x060105FB RID: 67067
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverlayPass_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105FC RID: 67068 RVA: 0x0016D130 File Offset: 0x0016B330
		public new vtkOverlayPass NewInstance()
		{
			vtkOverlayPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverlayPass.vtkOverlayPass_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOverlayPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060105FD RID: 67069
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverlayPass_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105FE RID: 67070 RVA: 0x0016D18C File Offset: 0x0016B38C
		public new static vtkOverlayPass SafeDownCast(vtkObjectBase o)
		{
			vtkOverlayPass vtkOverlayPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverlayPass.vtkOverlayPass_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOverlayPass = (vtkOverlayPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOverlayPass.Register(null);
				}
			}
			return vtkOverlayPass;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001303 RID: 4867
		public new const string MRFullTypeName = "Kitware.VTK.vtkOverlayPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001304 RID: 4868
		public new static readonly string MRClassNameKey = "class vtkOverlayPass";
	}
}
