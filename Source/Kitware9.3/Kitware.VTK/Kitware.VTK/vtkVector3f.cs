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
	// Token: 0x02000AEF RID: 2799
	public class vtkVector3f : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D7EA RID: 120810 RVA: 0x0029A813 File Offset: 0x00298A13
		static vtkVector3f()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVector3f.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVector3f"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D7EB RID: 120811 RVA: 0x0029A83B File Offset: 0x00298A3B
		public vtkVector3f(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D7EC RID: 120812 RVA: 0x0029A849 File Offset: 0x00298A49
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D7ED RID: 120813
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVector3f_Cross_01(HandleRef pThis, HandleRef other, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D7EE RID: 120814 RVA: 0x0029A854 File Offset: 0x00298A54
		public vtkVector3f Cross(vtkVector3f other)
		{
			vtkVector3f result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVector3f.vtkVector3f_Cross_01(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector3f)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D7EF RID: 120815
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVector3f_Normalized_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D7F0 RID: 120816 RVA: 0x0029A8C4 File Offset: 0x00298AC4
		public vtkVector3f Normalized()
		{
			vtkVector3f result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVector3f.vtkVector3f_Normalized_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector3f)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D7F1 RID: 120817
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVector3f_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount, float x, float y, float z);

		// Token: 0x0601D7F2 RID: 120818 RVA: 0x0029A920 File Offset: 0x00298B20
		public vtkVector3f(float x, float y, float z) : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVector3f.vtkVector3f_New(ref num, ref maxValue, ref num2, x, y, z);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F05 RID: 7941
		public new const string MRFullTypeName = "Kitware.VTK.vtkVector3f";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F06 RID: 7942
		public new static readonly string MRClassNameKey = "class vtkVector3f";
	}
}
