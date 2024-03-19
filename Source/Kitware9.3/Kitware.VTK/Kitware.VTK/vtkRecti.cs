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
	// Token: 0x02000AE7 RID: 2791
	public class vtkRecti : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D79C RID: 120732 RVA: 0x0029A027 File Offset: 0x00298227
		static vtkRecti()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRecti.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRecti"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D79D RID: 120733 RVA: 0x0029A04F File Offset: 0x0029824F
		public vtkRecti(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D79E RID: 120734 RVA: 0x0029A05D File Offset: 0x0029825D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D79F RID: 120735
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRecti_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount, float x, float y, float width, float height);

		// Token: 0x0601D7A0 RID: 120736 RVA: 0x0029A068 File Offset: 0x00298268
		public vtkRecti(float x, float y, float width, float height) : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRecti.vtkRecti_New(ref num, ref maxValue, ref num2, x, y, width, height);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		// Token: 0x0601D7A1 RID: 120737
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRecti_GetX(HandleRef pThis);

		// Token: 0x0601D7A2 RID: 120738 RVA: 0x0029A0B4 File Offset: 0x002982B4
		public double GetX()
		{
			return vtkRecti.vtkRecti_GetX(base.GetCppThis());
		}

		// Token: 0x0601D7A3 RID: 120739
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRecti_GetY(HandleRef pThis);

		// Token: 0x0601D7A4 RID: 120740 RVA: 0x0029A0D4 File Offset: 0x002982D4
		public double GetY()
		{
			return vtkRecti.vtkRecti_GetY(base.GetCppThis());
		}

		// Token: 0x0601D7A5 RID: 120741
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRecti_GetWidth(HandleRef pThis);

		// Token: 0x0601D7A6 RID: 120742 RVA: 0x0029A0F4 File Offset: 0x002982F4
		public double GetWidth()
		{
			return vtkRecti.vtkRecti_GetWidth(base.GetCppThis());
		}

		// Token: 0x0601D7A7 RID: 120743
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRecti_GetHeight(HandleRef pThis);

		// Token: 0x0601D7A8 RID: 120744 RVA: 0x0029A114 File Offset: 0x00298314
		public double GetHeight()
		{
			return vtkRecti.vtkRecti_GetHeight(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EF5 RID: 7925
		public new const string MRFullTypeName = "Kitware.VTK.vtkRecti";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EF6 RID: 7926
		public new static readonly string MRClassNameKey = "class vtkRecti";
	}
}
