using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStateStorage
	/// </summary>
	/// <remarks>
	///    Class to make storing and comparing state quick and easy
	///
	/// vtkStateStorage is just a thin wrapper around std::vector&lt;unsigned char&gt;
	/// It is best to use this class as an ivar so that allocs do not happen
	/// too often.
	///
	/// Example usage:
	/// @code
	///
	/// // compute the new state in a temp ivar
	/// // note that clear does not free memory
	/// this-&gt;TempState.Clear();
	/// this-&gt;TempState.Append(act-&gt;GetProperty()-&gt;GetMTime(), "property mtime");
	/// this-&gt;TempState.Append(
	///   this-&gt;CurrentInput ? this-&gt;CurrentInput-&gt;GetMTime() : 0, "input mtime");
	/// this-&gt;TempState.Append(
	///   act-&gt;GetTexture() ? act-&gt;GetTexture()-&gt;GetMTime() : 0, "texture mtime");
	///
	/// // now compare against the last state value
	///
	/// if (this-&gt;VBOBuildState != this-&gt;TempState)
	/// {
	///   // set the ivar to the new state
	///   this-&gt;VBOBuildState = this-&gt;TempState;
	///   do something...
	/// }
	///
	/// @endcode
	///
	/// </remarks>
	// Token: 0x020007C5 RID: 1989
	public class vtkStateStorage : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060145D7 RID: 83415 RVA: 0x001CCEBC File Offset: 0x001CB0BC
		static vtkStateStorage()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStateStorage.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStateStorage"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060145D8 RID: 83416 RVA: 0x001CCEE4 File Offset: 0x001CB0E4
		public vtkStateStorage(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060145D9 RID: 83417 RVA: 0x001CCEF2 File Offset: 0x001CB0F2
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060145DA RID: 83418
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStateStorage_Clear_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060145DB RID: 83419 RVA: 0x001CCEFD File Offset: 0x001CB0FD
		public void Clear()
		{
			vtkStateStorage.vtkStateStorage_Clear_01(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017A8 RID: 6056
		public new const string MRFullTypeName = "Kitware.VTK.vtkStateStorage";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017A9 RID: 6057
		public new static readonly string MRClassNameKey = "class vtkStateStorage";
	}
}
