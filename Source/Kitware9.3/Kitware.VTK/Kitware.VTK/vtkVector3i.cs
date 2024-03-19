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
	// Token: 0x02000AED RID: 2797
	public class vtkVector3i : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D7D8 RID: 120792 RVA: 0x0029A5F6 File Offset: 0x002987F6
		static vtkVector3i()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVector3i.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVector3i"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D7D9 RID: 120793 RVA: 0x0029A61E File Offset: 0x0029881E
		public vtkVector3i(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D7DA RID: 120794 RVA: 0x0029A62C File Offset: 0x0029882C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D7DB RID: 120795
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkVector3i vtkVector3i_Cross_01(HandleRef pThis, vtkVector3i other);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D7DC RID: 120796 RVA: 0x0029A638 File Offset: 0x00298838
		public vtkVector3i Cross(vtkVector3i other)
		{
			return vtkVector3i.vtkVector3i_Cross_01(base.GetCppThis(), other);
		}

		// Token: 0x0601D7DD RID: 120797
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkVector3i vtkVector3i_Normalized_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D7DE RID: 120798 RVA: 0x0029A658 File Offset: 0x00298858
		public vtkVector3i Normalized()
		{
			return vtkVector3i.vtkVector3i_Normalized_02(base.GetCppThis());
		}

		// Token: 0x0601D7DF RID: 120799
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVector3i_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount, float x, float y, float z);

		// Token: 0x0601D7E0 RID: 120800 RVA: 0x0029A678 File Offset: 0x00298878
		public vtkVector3i(float x, float y, float z) : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVector3i.vtkVector3i_New(ref num, ref maxValue, ref num2, x, y, z);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F01 RID: 7937
		public new const string MRFullTypeName = "Kitware.VTK.vtkVector3i";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F02 RID: 7938
		public new static readonly string MRClassNameKey = "class vtkVector3i";
	}
}
