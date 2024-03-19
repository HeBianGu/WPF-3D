using System;
using System.Reflection;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGPUInfoListArray
	/// </summary>
	/// <remarks>
	///    Internal class vtkGPUInfoList.
	///
	/// vtkGPUInfoListArray is just a PIMPL mechanism for vtkGPUInfoList.
	/// </remarks>
	// Token: 0x020007C4 RID: 1988
	public class vtkGPUInfoListArray : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060145D4 RID: 83412 RVA: 0x001CCE7B File Offset: 0x001CB07B
		static vtkGPUInfoListArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGPUInfoListArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGPUInfoListArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060145D5 RID: 83413 RVA: 0x001CCEA3 File Offset: 0x001CB0A3
		public vtkGPUInfoListArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060145D6 RID: 83414 RVA: 0x001CCEB1 File Offset: 0x001CB0B1
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017A6 RID: 6054
		public new const string MRFullTypeName = "Kitware.VTK.vtkGPUInfoListArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017A7 RID: 6055
		public new static readonly string MRClassNameKey = "class vtkGPUInfoListArray";
	}
}
