using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x020005B2 RID: 1458
	public class vtkOpenGLHelper : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FFA4 RID: 65444 RVA: 0x00163B67 File Offset: 0x00161D67
		static vtkOpenGLHelper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLHelper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FFA5 RID: 65445 RVA: 0x00163B8F File Offset: 0x00161D8F
		public vtkOpenGLHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FFA6 RID: 65446 RVA: 0x00163B9D File Offset: 0x00161D9D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FFA7 RID: 65447
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLHelper_ReleaseGraphicsResources_01(HandleRef pThis, HandleRef win);

		// Token: 0x0600FFA8 RID: 65448 RVA: 0x00163BA8 File Offset: 0x00161DA8
		public void ReleaseGraphicsResources(vtkWindow win)
		{
			vtkOpenGLHelper.vtkOpenGLHelper_ReleaseGraphicsResources_01(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012A6 RID: 4774
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLHelper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012A7 RID: 4775
		public new static readonly string MRClassNameKey = "class vtkOpenGLHelper";
	}
}
