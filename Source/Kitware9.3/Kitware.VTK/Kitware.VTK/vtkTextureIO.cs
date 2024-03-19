using System;
using System.Reflection;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTextureIO
	/// </summary>
	/// <remarks>
	///    A small collection of I/O routines that write vtkTextureObject
	/// to disk for debugging.
	/// </remarks>
	// Token: 0x0200010D RID: 269
	public class vtkTextureIO : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060036D6 RID: 14038 RVA: 0x00050337 File Offset: 0x0004E537
		static vtkTextureIO()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextureIO.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextureIO"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060036D7 RID: 14039 RVA: 0x0005035F File Offset: 0x0004E55F
		public vtkTextureIO(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060036D8 RID: 14040 RVA: 0x0005036D File Offset: 0x0004E56D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000652 RID: 1618
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextureIO";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000653 RID: 1619
		public new static readonly string MRClassNameKey = "class vtkTextureIO";
	}
}
