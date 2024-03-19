using System;
using System.Reflection;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000033 RID: 51
	public class vtkDICOMReferenceCount : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000887 RID: 2183 RVA: 0x0001398B File Offset: 0x00011B8B
		static vtkDICOMReferenceCount()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMReferenceCount.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMReferenceCount"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000888 RID: 2184 RVA: 0x000139B3 File Offset: 0x00011BB3
		public vtkDICOMReferenceCount(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000889 RID: 2185 RVA: 0x000139C1 File Offset: 0x00011BC1
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000390 RID: 912
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMReferenceCount";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000391 RID: 913
		public new static readonly string MRClassNameKey = "class vtkDICOMReferenceCount";
	}
}
