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
	// Token: 0x02000AEC RID: 2796
	public class vtkVector2i : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D7D1 RID: 120785 RVA: 0x0029A512 File Offset: 0x00298712
		static vtkVector2i()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVector2i.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVector2i"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D7D2 RID: 120786 RVA: 0x0029A53A File Offset: 0x0029873A
		public vtkVector2i(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D7D3 RID: 120787 RVA: 0x0029A548 File Offset: 0x00298748
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D7D4 RID: 120788
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVector2i_Normalized_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D7D5 RID: 120789 RVA: 0x0029A554 File Offset: 0x00298754
		public vtkVector2i Normalized()
		{
			vtkVector2i result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVector2i.vtkVector2i_Normalized_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D7D6 RID: 120790
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVector2i_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount, float x, float y);

		// Token: 0x0601D7D7 RID: 120791 RVA: 0x0029A5B0 File Offset: 0x002987B0
		public vtkVector2i(float x, float y) : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVector2i.vtkVector2i_New(ref num, ref maxValue, ref num2, x, y);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EFF RID: 7935
		public new const string MRFullTypeName = "Kitware.VTK.vtkVector2i";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F00 RID: 7936
		public new static readonly string MRClassNameKey = "class vtkVector2i";
	}
}
