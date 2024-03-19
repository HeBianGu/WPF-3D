using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageContinuousErode3D
	/// </summary>
	/// <remarks>
	///    Erosion implemented as a minimum.
	///
	/// vtkImageContinuousErode3D replaces a pixel with the minimum over
	/// an ellipsoidal neighborhood.  If KernelSize of an axis is 1, no processing
	/// is done on that axis.
	/// </remarks>
	// Token: 0x02000249 RID: 585
	public class vtkImageContinuousErode3D : vtkImageSpatialAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006C9B RID: 27803 RVA: 0x0009CB99 File Offset: 0x0009AD99
		static vtkImageContinuousErode3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageContinuousErode3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageContinuousErode3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006C9C RID: 27804 RVA: 0x0009CBC1 File Offset: 0x0009ADC1
		public vtkImageContinuousErode3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006C9D RID: 27805
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageContinuousErode3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an instance of vtkImageContinuousErode3D filter.
		/// By default zero values are eroded.
		/// </summary>
		// Token: 0x06006C9E RID: 27806 RVA: 0x0009CBD0 File Offset: 0x0009ADD0
		public new static vtkImageContinuousErode3D New()
		{
			vtkImageContinuousErode3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageContinuousErode3D.vtkImageContinuousErode3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageContinuousErode3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct an instance of vtkImageContinuousErode3D filter.
		/// By default zero values are eroded.
		/// </summary>
		// Token: 0x06006C9F RID: 27807 RVA: 0x0009CC24 File Offset: 0x0009AE24
		public vtkImageContinuousErode3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageContinuousErode3D.vtkImageContinuousErode3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006CA0 RID: 27808 RVA: 0x0009CC68 File Offset: 0x0009AE68
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006CA1 RID: 27809
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageContinuousErode3D_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageContinuousErode3D filter.
		/// By default zero values are eroded.
		/// </summary>
		// Token: 0x06006CA2 RID: 27810 RVA: 0x0009CC74 File Offset: 0x0009AE74
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageContinuousErode3D.vtkImageContinuousErode3D_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06006CA3 RID: 27811
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageContinuousErode3D_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageContinuousErode3D filter.
		/// By default zero values are eroded.
		/// </summary>
		// Token: 0x06006CA4 RID: 27812 RVA: 0x0009CC94 File Offset: 0x0009AE94
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageContinuousErode3D.vtkImageContinuousErode3D_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06006CA5 RID: 27813
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageContinuousErode3D_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageContinuousErode3D filter.
		/// By default zero values are eroded.
		/// </summary>
		// Token: 0x06006CA6 RID: 27814 RVA: 0x0009CCB0 File Offset: 0x0009AEB0
		public override int IsA(string type)
		{
			return vtkImageContinuousErode3D.vtkImageContinuousErode3D_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06006CA7 RID: 27815
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageContinuousErode3D_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageContinuousErode3D filter.
		/// By default zero values are eroded.
		/// </summary>
		// Token: 0x06006CA8 RID: 27816 RVA: 0x0009CCD0 File Offset: 0x0009AED0
		public new static int IsTypeOf(string type)
		{
			return vtkImageContinuousErode3D.vtkImageContinuousErode3D_IsTypeOf_04(type);
		}

		// Token: 0x06006CA9 RID: 27817
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageContinuousErode3D_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an instance of vtkImageContinuousErode3D filter.
		/// By default zero values are eroded.
		/// </summary>
		// Token: 0x06006CAA RID: 27818 RVA: 0x0009CCEC File Offset: 0x0009AEEC
		public new vtkImageContinuousErode3D NewInstance()
		{
			vtkImageContinuousErode3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageContinuousErode3D.vtkImageContinuousErode3D_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageContinuousErode3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006CAB RID: 27819
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageContinuousErode3D_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an instance of vtkImageContinuousErode3D filter.
		/// By default zero values are eroded.
		/// </summary>
		// Token: 0x06006CAC RID: 27820 RVA: 0x0009CD48 File Offset: 0x0009AF48
		public new static vtkImageContinuousErode3D SafeDownCast(vtkObjectBase o)
		{
			vtkImageContinuousErode3D vtkImageContinuousErode3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageContinuousErode3D.vtkImageContinuousErode3D_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageContinuousErode3D = (vtkImageContinuousErode3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageContinuousErode3D.Register(null);
				}
			}
			return vtkImageContinuousErode3D;
		}

		// Token: 0x06006CAD RID: 27821
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageContinuousErode3D_SetKernelSize_08(HandleRef pThis, int size0, int size1, int size2);

		/// <summary>
		/// This method sets the size of the neighborhood.  It also sets the
		/// default middle of the neighborhood and computes the elliptical foot print.
		/// </summary>
		// Token: 0x06006CAE RID: 27822 RVA: 0x0009CDC7 File Offset: 0x0009AFC7
		public void SetKernelSize(int size0, int size1, int size2)
		{
			vtkImageContinuousErode3D.vtkImageContinuousErode3D_SetKernelSize_08(base.GetCppThis(), size0, size1, size2);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000987 RID: 2439
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageContinuousErode3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000988 RID: 2440
		public new static readonly string MRClassNameKey = "class vtkImageContinuousErode3D";
	}
}
