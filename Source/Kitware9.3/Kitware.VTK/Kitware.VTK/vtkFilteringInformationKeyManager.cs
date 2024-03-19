using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFilteringInformationKeyManager
	/// </summary>
	/// <remarks>
	///    Manages key types in vtkFiltering.
	///
	/// vtkFilteringInformationKeyManager is included in the header of any
	/// subclass of vtkInformationKey defined in the vtkFiltering library.
	/// It makes sure that the table of keys is created before and
	/// destroyed after it is used.
	/// </remarks>
	// Token: 0x020009D2 RID: 2514
	public class vtkFilteringInformationKeyManager : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A383 RID: 107395 RVA: 0x002458C9 File Offset: 0x00243AC9
		static vtkFilteringInformationKeyManager()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFilteringInformationKeyManager.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFilteringInformationKeyManager"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A384 RID: 107396 RVA: 0x002458F1 File Offset: 0x00243AF1
		public vtkFilteringInformationKeyManager(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A385 RID: 107397
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFilteringInformationKeyManager_Register_01(HandleRef key);

		/// <summary>
		/// Called by constructors of vtkInformationKey subclasses defined in
		/// vtkFiltering to register themselves with the manager.  The
		/// instances will be deleted when vtkFiltering is unloaded on
		/// program exit.
		/// </summary>
		// Token: 0x0601A386 RID: 107398 RVA: 0x00245900 File Offset: 0x00243B00
		public static void Register(vtkInformationKey key)
		{
			vtkFilteringInformationKeyManager.vtkFilteringInformationKeyManager_Register_01((key == null) ? default(HandleRef) : key.GetCppThis());
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A387 RID: 107399 RVA: 0x00245929 File Offset: 0x00243B29
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C74 RID: 7284
		public new const string MRFullTypeName = "Kitware.VTK.vtkFilteringInformationKeyManager";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C75 RID: 7285
		public new static readonly string MRClassNameKey = "class vtkFilteringInformationKeyManager";
	}
}
