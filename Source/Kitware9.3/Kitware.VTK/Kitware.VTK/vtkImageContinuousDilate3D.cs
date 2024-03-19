using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageContinuousDilate3D
	/// </summary>
	/// <remarks>
	///    Dilate implemented as a maximum.
	///
	/// vtkImageContinuousDilate3D replaces a pixel with the maximum over
	/// an ellipsoidal neighborhood.  If KernelSize of an axis is 1, no processing
	/// is done on that axis.
	/// </remarks>
	// Token: 0x02000248 RID: 584
	public class vtkImageContinuousDilate3D : vtkImageSpatialAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006C87 RID: 27783 RVA: 0x0009C957 File Offset: 0x0009AB57
		static vtkImageContinuousDilate3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageContinuousDilate3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageContinuousDilate3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006C88 RID: 27784 RVA: 0x0009C97F File Offset: 0x0009AB7F
		public vtkImageContinuousDilate3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006C89 RID: 27785
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageContinuousDilate3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an instance of vtkImageContinuousDilate3D filter.
		/// By default zero values are dilated.
		/// </summary>
		// Token: 0x06006C8A RID: 27786 RVA: 0x0009C990 File Offset: 0x0009AB90
		public new static vtkImageContinuousDilate3D New()
		{
			vtkImageContinuousDilate3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageContinuousDilate3D.vtkImageContinuousDilate3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageContinuousDilate3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct an instance of vtkImageContinuousDilate3D filter.
		/// By default zero values are dilated.
		/// </summary>
		// Token: 0x06006C8B RID: 27787 RVA: 0x0009C9E4 File Offset: 0x0009ABE4
		public vtkImageContinuousDilate3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageContinuousDilate3D.vtkImageContinuousDilate3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006C8C RID: 27788 RVA: 0x0009CA28 File Offset: 0x0009AC28
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006C8D RID: 27789
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageContinuousDilate3D_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageContinuousDilate3D filter.
		/// By default zero values are dilated.
		/// </summary>
		// Token: 0x06006C8E RID: 27790 RVA: 0x0009CA34 File Offset: 0x0009AC34
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageContinuousDilate3D.vtkImageContinuousDilate3D_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06006C8F RID: 27791
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageContinuousDilate3D_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageContinuousDilate3D filter.
		/// By default zero values are dilated.
		/// </summary>
		// Token: 0x06006C90 RID: 27792 RVA: 0x0009CA54 File Offset: 0x0009AC54
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageContinuousDilate3D.vtkImageContinuousDilate3D_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06006C91 RID: 27793
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageContinuousDilate3D_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageContinuousDilate3D filter.
		/// By default zero values are dilated.
		/// </summary>
		// Token: 0x06006C92 RID: 27794 RVA: 0x0009CA70 File Offset: 0x0009AC70
		public override int IsA(string type)
		{
			return vtkImageContinuousDilate3D.vtkImageContinuousDilate3D_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06006C93 RID: 27795
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageContinuousDilate3D_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageContinuousDilate3D filter.
		/// By default zero values are dilated.
		/// </summary>
		// Token: 0x06006C94 RID: 27796 RVA: 0x0009CA90 File Offset: 0x0009AC90
		public new static int IsTypeOf(string type)
		{
			return vtkImageContinuousDilate3D.vtkImageContinuousDilate3D_IsTypeOf_04(type);
		}

		// Token: 0x06006C95 RID: 27797
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageContinuousDilate3D_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an instance of vtkImageContinuousDilate3D filter.
		/// By default zero values are dilated.
		/// </summary>
		// Token: 0x06006C96 RID: 27798 RVA: 0x0009CAAC File Offset: 0x0009ACAC
		public new vtkImageContinuousDilate3D NewInstance()
		{
			vtkImageContinuousDilate3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageContinuousDilate3D.vtkImageContinuousDilate3D_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageContinuousDilate3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006C97 RID: 27799
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageContinuousDilate3D_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an instance of vtkImageContinuousDilate3D filter.
		/// By default zero values are dilated.
		/// </summary>
		// Token: 0x06006C98 RID: 27800 RVA: 0x0009CB08 File Offset: 0x0009AD08
		public new static vtkImageContinuousDilate3D SafeDownCast(vtkObjectBase o)
		{
			vtkImageContinuousDilate3D vtkImageContinuousDilate3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageContinuousDilate3D.vtkImageContinuousDilate3D_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageContinuousDilate3D = (vtkImageContinuousDilate3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageContinuousDilate3D.Register(null);
				}
			}
			return vtkImageContinuousDilate3D;
		}

		// Token: 0x06006C99 RID: 27801
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageContinuousDilate3D_SetKernelSize_08(HandleRef pThis, int size0, int size1, int size2);

		/// <summary>
		/// This method sets the size of the neighborhood.  It also sets the
		/// default middle of the neighborhood and computes the elliptical foot print.
		/// </summary>
		// Token: 0x06006C9A RID: 27802 RVA: 0x0009CB87 File Offset: 0x0009AD87
		public void SetKernelSize(int size0, int size1, int size2)
		{
			vtkImageContinuousDilate3D.vtkImageContinuousDilate3D_SetKernelSize_08(base.GetCppThis(), size0, size1, size2);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000985 RID: 2437
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageContinuousDilate3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000986 RID: 2438
		public new static readonly string MRClassNameKey = "class vtkImageContinuousDilate3D";
	}
}
