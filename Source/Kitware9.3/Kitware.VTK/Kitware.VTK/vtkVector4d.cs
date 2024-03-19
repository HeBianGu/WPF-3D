using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVector
	/// </summary>
	/// <remarks>
	///    templated base type for storage of vectors.
	///
	///
	/// This class is a templated data type for storing and manipulating fixed size
	/// vectors, which can be used to represent two and three dimensional points. The
	/// memory layout is a contiguous array of the specified type, such that a
	/// float[2] can be cast to a vtkVector2f and manipulated. Also a float[6] could
	/// be cast and used as a vtkVector2f[3].
	/// </remarks>
	// Token: 0x02000AF1 RID: 2801
	public class vtkVector4d : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D7F8 RID: 120824 RVA: 0x0029A9C7 File Offset: 0x00298BC7
		static vtkVector4d()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVector4d.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVector4d"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D7F9 RID: 120825 RVA: 0x0029A9EF File Offset: 0x00298BEF
		public vtkVector4d(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D7FA RID: 120826 RVA: 0x0029A9FD File Offset: 0x00298BFD
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D7FB RID: 120827
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkVector4d vtkVector4d_Normalized_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D7FC RID: 120828 RVA: 0x0029AA08 File Offset: 0x00298C08
		public vtkVector4d Normalized()
		{
			return vtkVector4d.vtkVector4d_Normalized_01(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F09 RID: 7945
		public new const string MRFullTypeName = "Kitware.VTK.vtkVector4d";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F0A RID: 7946
		public new static readonly string MRClassNameKey = "class vtkVector4d";
	}
}
