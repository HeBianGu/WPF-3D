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
	// Token: 0x02000AF0 RID: 2800
	public class vtkVector4i : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D7F3 RID: 120819 RVA: 0x0029A967 File Offset: 0x00298B67
		static vtkVector4i()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVector4i.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVector4i"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D7F4 RID: 120820 RVA: 0x0029A98F File Offset: 0x00298B8F
		public vtkVector4i(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D7F5 RID: 120821 RVA: 0x0029A99D File Offset: 0x00298B9D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D7F6 RID: 120822
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkVector4i vtkVector4i_Normalized_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D7F7 RID: 120823 RVA: 0x0029A9A8 File Offset: 0x00298BA8
		public vtkVector4i Normalized()
		{
			return vtkVector4i.vtkVector4i_Normalized_01(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F07 RID: 7943
		public new const string MRFullTypeName = "Kitware.VTK.vtkVector4i";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F08 RID: 7944
		public new static readonly string MRClassNameKey = "class vtkVector4i";
	}
}
