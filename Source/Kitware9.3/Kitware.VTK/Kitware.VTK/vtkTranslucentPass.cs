using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTranslucentPass
	/// </summary>
	/// <remarks>
	///    Render the translucent polygonal geometry
	/// with property key filtering.
	///
	/// vtkTranslucentPass renders the translucent polygonal geometry of all the
	/// props that have the keys contained in vtkRenderState.
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
	// Token: 0x020005F3 RID: 1523
	public class vtkTranslucentPass : vtkDefaultPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060108D9 RID: 67801 RVA: 0x001719FD File Offset: 0x0016FBFD
		static vtkTranslucentPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTranslucentPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTranslucentPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060108DA RID: 67802 RVA: 0x00171A25 File Offset: 0x0016FC25
		public vtkTranslucentPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060108DB RID: 67803
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTranslucentPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060108DC RID: 67804 RVA: 0x00171A34 File Offset: 0x0016FC34
		public new static vtkTranslucentPass New()
		{
			vtkTranslucentPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTranslucentPass.vtkTranslucentPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTranslucentPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060108DD RID: 67805 RVA: 0x00171A88 File Offset: 0x0016FC88
		public vtkTranslucentPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTranslucentPass.vtkTranslucentPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060108DE RID: 67806 RVA: 0x00171ACC File Offset: 0x0016FCCC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060108DF RID: 67807
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTranslucentPass_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060108E0 RID: 67808 RVA: 0x00171AD8 File Offset: 0x0016FCD8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTranslucentPass.vtkTranslucentPass_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060108E1 RID: 67809
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTranslucentPass_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060108E2 RID: 67810 RVA: 0x00171AF8 File Offset: 0x0016FCF8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTranslucentPass.vtkTranslucentPass_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060108E3 RID: 67811
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTranslucentPass_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060108E4 RID: 67812 RVA: 0x00171B14 File Offset: 0x0016FD14
		public override int IsA(string type)
		{
			return vtkTranslucentPass.vtkTranslucentPass_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060108E5 RID: 67813
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTranslucentPass_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060108E6 RID: 67814 RVA: 0x00171B34 File Offset: 0x0016FD34
		public new static int IsTypeOf(string type)
		{
			return vtkTranslucentPass.vtkTranslucentPass_IsTypeOf_04(type);
		}

		// Token: 0x060108E7 RID: 67815
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTranslucentPass_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060108E8 RID: 67816 RVA: 0x00171B50 File Offset: 0x0016FD50
		public new vtkTranslucentPass NewInstance()
		{
			vtkTranslucentPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTranslucentPass.vtkTranslucentPass_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTranslucentPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060108E9 RID: 67817
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTranslucentPass_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060108EA RID: 67818 RVA: 0x00171BAC File Offset: 0x0016FDAC
		public new static vtkTranslucentPass SafeDownCast(vtkObjectBase o)
		{
			vtkTranslucentPass vtkTranslucentPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTranslucentPass.vtkTranslucentPass_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTranslucentPass = (vtkTranslucentPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTranslucentPass.Register(null);
				}
			}
			return vtkTranslucentPass;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400133B RID: 4923
		public new const string MRFullTypeName = "Kitware.VTK.vtkTranslucentPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400133C RID: 4924
		public new static readonly string MRClassNameKey = "class vtkTranslucentPass";
	}
}
