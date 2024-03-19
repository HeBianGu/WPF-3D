using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageDilateErode3D
	/// </summary>
	/// <remarks>
	///    Dilates one value and erodes another.
	///
	/// vtkImageDilateErode3D will dilate one value and erode another.
	/// It uses an elliptical foot print, and only erodes/dilates on the
	/// boundary of the two values.  The filter is restricted to the
	/// X, Y, and Z axes for now.  It can degenerate to a 2 or 1 dimensional
	/// filter by setting the kernel size to 1 for a specific axis.
	/// </remarks>
	// Token: 0x0200024A RID: 586
	public class vtkImageDilateErode3D : vtkImageSpatialAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006CAF RID: 27823 RVA: 0x0009CDD9 File Offset: 0x0009AFD9
		static vtkImageDilateErode3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageDilateErode3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDilateErode3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006CB0 RID: 27824 RVA: 0x0009CE01 File Offset: 0x0009B001
		public vtkImageDilateErode3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006CB1 RID: 27825
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDilateErode3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an instance of vtkImageDilateErode3D filter.
		/// By default zero values are dilated.
		/// </summary>
		// Token: 0x06006CB2 RID: 27826 RVA: 0x0009CE10 File Offset: 0x0009B010
		public new static vtkImageDilateErode3D New()
		{
			vtkImageDilateErode3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDilateErode3D.vtkImageDilateErode3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDilateErode3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct an instance of vtkImageDilateErode3D filter.
		/// By default zero values are dilated.
		/// </summary>
		// Token: 0x06006CB3 RID: 27827 RVA: 0x0009CE64 File Offset: 0x0009B064
		public vtkImageDilateErode3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageDilateErode3D.vtkImageDilateErode3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006CB4 RID: 27828 RVA: 0x0009CEA8 File Offset: 0x0009B0A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006CB5 RID: 27829
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageDilateErode3D_GetDilateValue_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the Dilate and Erode values to be used by this filter.
		/// </summary>
		// Token: 0x06006CB6 RID: 27830 RVA: 0x0009CEB4 File Offset: 0x0009B0B4
		public virtual double GetDilateValue()
		{
			return vtkImageDilateErode3D.vtkImageDilateErode3D_GetDilateValue_01(base.GetCppThis());
		}

		// Token: 0x06006CB7 RID: 27831
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageDilateErode3D_GetErodeValue_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the Dilate and Erode values to be used by this filter.
		/// </summary>
		// Token: 0x06006CB8 RID: 27832 RVA: 0x0009CED4 File Offset: 0x0009B0D4
		public virtual double GetErodeValue()
		{
			return vtkImageDilateErode3D.vtkImageDilateErode3D_GetErodeValue_02(base.GetCppThis());
		}

		// Token: 0x06006CB9 RID: 27833
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDilateErode3D_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageDilateErode3D filter.
		/// By default zero values are dilated.
		/// </summary>
		// Token: 0x06006CBA RID: 27834 RVA: 0x0009CEF4 File Offset: 0x0009B0F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageDilateErode3D.vtkImageDilateErode3D_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06006CBB RID: 27835
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDilateErode3D_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageDilateErode3D filter.
		/// By default zero values are dilated.
		/// </summary>
		// Token: 0x06006CBC RID: 27836 RVA: 0x0009CF14 File Offset: 0x0009B114
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageDilateErode3D.vtkImageDilateErode3D_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06006CBD RID: 27837
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDilateErode3D_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageDilateErode3D filter.
		/// By default zero values are dilated.
		/// </summary>
		// Token: 0x06006CBE RID: 27838 RVA: 0x0009CF30 File Offset: 0x0009B130
		public override int IsA(string type)
		{
			return vtkImageDilateErode3D.vtkImageDilateErode3D_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06006CBF RID: 27839
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDilateErode3D_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageDilateErode3D filter.
		/// By default zero values are dilated.
		/// </summary>
		// Token: 0x06006CC0 RID: 27840 RVA: 0x0009CF50 File Offset: 0x0009B150
		public new static int IsTypeOf(string type)
		{
			return vtkImageDilateErode3D.vtkImageDilateErode3D_IsTypeOf_06(type);
		}

		// Token: 0x06006CC1 RID: 27841
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDilateErode3D_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an instance of vtkImageDilateErode3D filter.
		/// By default zero values are dilated.
		/// </summary>
		// Token: 0x06006CC2 RID: 27842 RVA: 0x0009CF6C File Offset: 0x0009B16C
		public new vtkImageDilateErode3D NewInstance()
		{
			vtkImageDilateErode3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDilateErode3D.vtkImageDilateErode3D_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDilateErode3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006CC3 RID: 27843
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDilateErode3D_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an instance of vtkImageDilateErode3D filter.
		/// By default zero values are dilated.
		/// </summary>
		// Token: 0x06006CC4 RID: 27844 RVA: 0x0009CFC8 File Offset: 0x0009B1C8
		public new static vtkImageDilateErode3D SafeDownCast(vtkObjectBase o)
		{
			vtkImageDilateErode3D vtkImageDilateErode3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDilateErode3D.vtkImageDilateErode3D_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDilateErode3D = (vtkImageDilateErode3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDilateErode3D.Register(null);
				}
			}
			return vtkImageDilateErode3D;
		}

		// Token: 0x06006CC5 RID: 27845
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDilateErode3D_SetDilateValue_10(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the Dilate and Erode values to be used by this filter.
		/// </summary>
		// Token: 0x06006CC6 RID: 27846 RVA: 0x0009D047 File Offset: 0x0009B247
		public virtual void SetDilateValue(double _arg)
		{
			vtkImageDilateErode3D.vtkImageDilateErode3D_SetDilateValue_10(base.GetCppThis(), _arg);
		}

		// Token: 0x06006CC7 RID: 27847
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDilateErode3D_SetErodeValue_11(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the Dilate and Erode values to be used by this filter.
		/// </summary>
		// Token: 0x06006CC8 RID: 27848 RVA: 0x0009D057 File Offset: 0x0009B257
		public virtual void SetErodeValue(double _arg)
		{
			vtkImageDilateErode3D.vtkImageDilateErode3D_SetErodeValue_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06006CC9 RID: 27849
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDilateErode3D_SetKernelSize_12(HandleRef pThis, int size0, int size1, int size2);

		/// <summary>
		/// This method sets the size of the neighborhood.  It also sets the
		/// default middle of the neighborhood and computes the elliptical foot print.
		/// </summary>
		// Token: 0x06006CCA RID: 27850 RVA: 0x0009D067 File Offset: 0x0009B267
		public void SetKernelSize(int size0, int size1, int size2)
		{
			vtkImageDilateErode3D.vtkImageDilateErode3D_SetKernelSize_12(base.GetCppThis(), size0, size1, size2);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000989 RID: 2441
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageDilateErode3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400098A RID: 2442
		public new static readonly string MRClassNameKey = "class vtkImageDilateErode3D";
	}
}
