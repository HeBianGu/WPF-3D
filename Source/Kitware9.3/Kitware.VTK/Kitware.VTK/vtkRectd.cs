using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRect
	/// </summary>
	/// <remarks>
	///    templated base type for storage of 2D rectangles.
	///
	///
	/// This class is a templated data type for storing and manipulating rectangles.
	/// The memory layout is a contiguous array of the specified type, such that a
	/// float[4] can be cast to a vtkRectf and manipulated. Also a float[12] could
	/// be cast and used as a vtkRectf[3].
	/// </remarks>
	// Token: 0x02000AE8 RID: 2792
	public class vtkRectd : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D7A9 RID: 120745 RVA: 0x0029A133 File Offset: 0x00298333
		static vtkRectd()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectd.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectd"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D7AA RID: 120746 RVA: 0x0029A15B File Offset: 0x0029835B
		public vtkRectd(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D7AB RID: 120747 RVA: 0x0029A169 File Offset: 0x00298369
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D7AC RID: 120748
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectd_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount, float x, float y, float width, float height);

		// Token: 0x0601D7AD RID: 120749 RVA: 0x0029A174 File Offset: 0x00298374
		public vtkRectd(float x, float y, float width, float height) : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRectd.vtkRectd_New(ref num, ref maxValue, ref num2, x, y, width, height);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		// Token: 0x0601D7AE RID: 120750
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectd_GetX(HandleRef pThis);

		// Token: 0x0601D7AF RID: 120751 RVA: 0x0029A1C0 File Offset: 0x002983C0
		public double GetX()
		{
			return vtkRectd.vtkRectd_GetX(base.GetCppThis());
		}

		// Token: 0x0601D7B0 RID: 120752
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectd_GetY(HandleRef pThis);

		// Token: 0x0601D7B1 RID: 120753 RVA: 0x0029A1E0 File Offset: 0x002983E0
		public double GetY()
		{
			return vtkRectd.vtkRectd_GetY(base.GetCppThis());
		}

		// Token: 0x0601D7B2 RID: 120754
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectd_GetWidth(HandleRef pThis);

		// Token: 0x0601D7B3 RID: 120755 RVA: 0x0029A200 File Offset: 0x00298400
		public double GetWidth()
		{
			return vtkRectd.vtkRectd_GetWidth(base.GetCppThis());
		}

		// Token: 0x0601D7B4 RID: 120756
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectd_GetHeight(HandleRef pThis);

		// Token: 0x0601D7B5 RID: 120757 RVA: 0x0029A220 File Offset: 0x00298420
		public double GetHeight()
		{
			return vtkRectd.vtkRectd_GetHeight(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EF7 RID: 7927
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectd";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EF8 RID: 7928
		public new static readonly string MRClassNameKey = "class vtkRectd";
	}
}
