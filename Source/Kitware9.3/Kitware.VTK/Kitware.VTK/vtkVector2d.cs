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
	// Token: 0x02000AEA RID: 2794
	public class vtkVector2d : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D7C3 RID: 120771 RVA: 0x0029A34B File Offset: 0x0029854B
		static vtkVector2d()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVector2d.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVector2d"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D7C4 RID: 120772 RVA: 0x0029A373 File Offset: 0x00298573
		public vtkVector2d(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D7C5 RID: 120773 RVA: 0x0029A381 File Offset: 0x00298581
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D7C6 RID: 120774
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVector2d_Normalized_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D7C7 RID: 120775 RVA: 0x0029A38C File Offset: 0x0029858C
		public vtkVector2d Normalized()
		{
			vtkVector2d result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVector2d.vtkVector2d_Normalized_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2d)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D7C8 RID: 120776
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVector2d_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount, float x, float y);

		// Token: 0x0601D7C9 RID: 120777 RVA: 0x0029A3E8 File Offset: 0x002985E8
		public vtkVector2d(float x, float y) : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVector2d.vtkVector2d_New(ref num, ref maxValue, ref num2, x, y);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EFB RID: 7931
		public new const string MRFullTypeName = "Kitware.VTK.vtkVector2d";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EFC RID: 7932
		public new static readonly string MRClassNameKey = "class vtkVector2d";
	}
}
