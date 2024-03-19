using System;
using System.Reflection;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataObjectTreeInternals
	///
	/// </summary>
	// Token: 0x020009ED RID: 2541
	public class vtkDataObjectTreeInternals : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A69D RID: 108189 RVA: 0x0024AE9F File Offset: 0x0024909F
		static vtkDataObjectTreeInternals()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataObjectTreeInternals.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObjectTreeInternals"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A69E RID: 108190 RVA: 0x0024AEC7 File Offset: 0x002490C7
		public vtkDataObjectTreeInternals(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A69F RID: 108191 RVA: 0x0024AED5 File Offset: 0x002490D5
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CAA RID: 7338
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataObjectTreeInternals";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CAB RID: 7339
		public new static readonly string MRClassNameKey = "class vtkDataObjectTreeInternals";
	}
}
