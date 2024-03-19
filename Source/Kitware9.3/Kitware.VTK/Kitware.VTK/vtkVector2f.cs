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
	// Token: 0x02000AEB RID: 2795
	public class vtkVector2f : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D7CA RID: 120778 RVA: 0x0029A42E File Offset: 0x0029862E
		static vtkVector2f()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVector2f.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVector2f"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D7CB RID: 120779 RVA: 0x0029A456 File Offset: 0x00298656
		public vtkVector2f(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D7CC RID: 120780 RVA: 0x0029A464 File Offset: 0x00298664
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D7CD RID: 120781
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVector2f_Normalized_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D7CE RID: 120782 RVA: 0x0029A470 File Offset: 0x00298670
		public vtkVector2f Normalized()
		{
			vtkVector2f result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVector2f.vtkVector2f_Normalized_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D7CF RID: 120783
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVector2f_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount, float x, float y);

		// Token: 0x0601D7D0 RID: 120784 RVA: 0x0029A4CC File Offset: 0x002986CC
		public vtkVector2f(float x, float y) : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVector2f.vtkVector2f_New(ref num, ref maxValue, ref num2, x, y);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EFD RID: 7933
		public new const string MRFullTypeName = "Kitware.VTK.vtkVector2f";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EFE RID: 7934
		public new static readonly string MRClassNameKey = "class vtkVector2f";
	}
}
