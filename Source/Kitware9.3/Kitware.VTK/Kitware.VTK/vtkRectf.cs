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
	// Token: 0x02000AE9 RID: 2793
	public class vtkRectf : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D7B6 RID: 120758 RVA: 0x0029A23F File Offset: 0x0029843F
		static vtkRectf()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectf.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectf"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D7B7 RID: 120759 RVA: 0x0029A267 File Offset: 0x00298467
		public vtkRectf(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D7B8 RID: 120760 RVA: 0x0029A275 File Offset: 0x00298475
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D7B9 RID: 120761
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectf_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount, float x, float y, float width, float height);

		// Token: 0x0601D7BA RID: 120762 RVA: 0x0029A280 File Offset: 0x00298480
		public vtkRectf(float x, float y, float width, float height) : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRectf.vtkRectf_New(ref num, ref maxValue, ref num2, x, y, width, height);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		// Token: 0x0601D7BB RID: 120763
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectf_GetX(HandleRef pThis);

		// Token: 0x0601D7BC RID: 120764 RVA: 0x0029A2CC File Offset: 0x002984CC
		public double GetX()
		{
			return vtkRectf.vtkRectf_GetX(base.GetCppThis());
		}

		// Token: 0x0601D7BD RID: 120765
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectf_GetY(HandleRef pThis);

		// Token: 0x0601D7BE RID: 120766 RVA: 0x0029A2EC File Offset: 0x002984EC
		public double GetY()
		{
			return vtkRectf.vtkRectf_GetY(base.GetCppThis());
		}

		// Token: 0x0601D7BF RID: 120767
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectf_GetWidth(HandleRef pThis);

		// Token: 0x0601D7C0 RID: 120768 RVA: 0x0029A30C File Offset: 0x0029850C
		public double GetWidth()
		{
			return vtkRectf.vtkRectf_GetWidth(base.GetCppThis());
		}

		// Token: 0x0601D7C1 RID: 120769
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectf_GetHeight(HandleRef pThis);

		// Token: 0x0601D7C2 RID: 120770 RVA: 0x0029A32C File Offset: 0x0029852C
		public double GetHeight()
		{
			return vtkRectf.vtkRectf_GetHeight(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EF9 RID: 7929
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectf";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EFA RID: 7930
		public new static readonly string MRClassNameKey = "class vtkRectf";
	}
}
