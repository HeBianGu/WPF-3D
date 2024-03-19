using System;
using System.Reflection;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyhedronUtilities
	/// </summary>
	/// <remarks>
	///    vtkPolyhedron utilities
	///
	/// This class contains specific methods used to process vtkPolyhedron.
	/// These methods are intended to improve filters behavior over bad-shaped or degenerated
	/// polyhedrons (for example, non-planar ones).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPolyhedron
	/// </seealso>
	// Token: 0x02000AA8 RID: 2728
	public class vtkPolyhedronUtilities : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CA85 RID: 117381 RVA: 0x00284A41 File Offset: 0x00282C41
		static vtkPolyhedronUtilities()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyhedronUtilities.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyhedronUtilities"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CA86 RID: 117382 RVA: 0x00284A69 File Offset: 0x00282C69
		public vtkPolyhedronUtilities(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CA87 RID: 117383 RVA: 0x00284A77 File Offset: 0x00282C77
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E59 RID: 7769
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyhedronUtilities";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E5A RID: 7770
		public new static readonly string MRClassNameKey = "class vtkPolyhedronUtilities";
	}
}
