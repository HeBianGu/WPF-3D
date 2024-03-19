using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageRange3D
	/// </summary>
	/// <remarks>
	///    Max - min of a circular neighborhood.
	///
	/// vtkImageRange3D replaces a pixel with the maximum minus minimum over
	/// an ellipsoidal neighborhood.  If KernelSize of an axis is 1, no processing
	/// is done on that axis.
	/// </remarks>
	// Token: 0x0200048C RID: 1164
	public class vtkImageRange3D : vtkImageSpatialAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D59F RID: 54687 RVA: 0x001294EF File Offset: 0x001276EF
		static vtkImageRange3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageRange3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageRange3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D5A0 RID: 54688 RVA: 0x00129517 File Offset: 0x00127717
		public vtkImageRange3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D5A1 RID: 54689
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageRange3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5A2 RID: 54690 RVA: 0x00129528 File Offset: 0x00127728
		public new static vtkImageRange3D New()
		{
			vtkImageRange3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageRange3D.vtkImageRange3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageRange3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5A3 RID: 54691 RVA: 0x0012957C File Offset: 0x0012777C
		public vtkImageRange3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageRange3D.vtkImageRange3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D5A4 RID: 54692 RVA: 0x001295C0 File Offset: 0x001277C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D5A5 RID: 54693
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageRange3D_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5A6 RID: 54694 RVA: 0x001295CC File Offset: 0x001277CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageRange3D.vtkImageRange3D_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600D5A7 RID: 54695
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageRange3D_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5A8 RID: 54696 RVA: 0x001295EC File Offset: 0x001277EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageRange3D.vtkImageRange3D_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600D5A9 RID: 54697
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageRange3D_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5AA RID: 54698 RVA: 0x00129608 File Offset: 0x00127808
		public override int IsA(string type)
		{
			return vtkImageRange3D.vtkImageRange3D_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600D5AB RID: 54699
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageRange3D_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5AC RID: 54700 RVA: 0x00129628 File Offset: 0x00127828
		public new static int IsTypeOf(string type)
		{
			return vtkImageRange3D.vtkImageRange3D_IsTypeOf_04(type);
		}

		// Token: 0x0600D5AD RID: 54701
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageRange3D_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5AE RID: 54702 RVA: 0x00129644 File Offset: 0x00127844
		public new vtkImageRange3D NewInstance()
		{
			vtkImageRange3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageRange3D.vtkImageRange3D_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageRange3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D5AF RID: 54703
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageRange3D_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5B0 RID: 54704 RVA: 0x001296A0 File Offset: 0x001278A0
		public new static vtkImageRange3D SafeDownCast(vtkObjectBase o)
		{
			vtkImageRange3D vtkImageRange3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageRange3D.vtkImageRange3D_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageRange3D = (vtkImageRange3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageRange3D.Register(null);
				}
			}
			return vtkImageRange3D;
		}

		// Token: 0x0600D5B1 RID: 54705
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageRange3D_SetKernelSize_08(HandleRef pThis, int size0, int size1, int size2);

		/// <summary>
		/// This method sets the size of the neighborhood.  It also sets the
		/// default middle of the neighborhood and computes the elliptical foot print.
		/// </summary>
		// Token: 0x0600D5B2 RID: 54706 RVA: 0x0012971F File Offset: 0x0012791F
		public void SetKernelSize(int size0, int size1, int size2)
		{
			vtkImageRange3D.vtkImageRange3D_SetKernelSize_08(base.GetCppThis(), size0, size1, size2);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FC0 RID: 4032
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageRange3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FC1 RID: 4033
		public new static readonly string MRClassNameKey = "class vtkImageRange3D";
	}
}
