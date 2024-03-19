using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageSpatialAlgorithm
	/// </summary>
	/// <remarks>
	///    Filters that operate on pixel neighborhoods.
	///
	/// vtkImageSpatialAlgorithm is a super class for filters that operate on an
	/// input neighborhood for each output pixel. It handles even sized
	/// neighborhoods, but their can be a half pixel shift associated with
	/// processing.  This superclass has some logic for handling boundaries.  It
	/// can split regions into boundary and non-boundary pieces and call different
	/// execute methods.
	/// </remarks>
	// Token: 0x02000247 RID: 583
	public class vtkImageSpatialAlgorithm : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006C69 RID: 27753 RVA: 0x0009C64F File Offset: 0x0009A84F
		static vtkImageSpatialAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageSpatialAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSpatialAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006C6A RID: 27754 RVA: 0x0009C677 File Offset: 0x0009A877
		public vtkImageSpatialAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006C6B RID: 27755
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSpatialAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C6C RID: 27756 RVA: 0x0009C688 File Offset: 0x0009A888
		public new static vtkImageSpatialAlgorithm New()
		{
			vtkImageSpatialAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSpatialAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C6D RID: 27757 RVA: 0x0009C6DC File Offset: 0x0009A8DC
		public vtkImageSpatialAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006C6E RID: 27758 RVA: 0x0009C720 File Offset: 0x0009A920
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006C6F RID: 27759
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSpatialAlgorithm_GetKernelMiddle_01(HandleRef pThis);

		/// <summary>
		/// Get the Kernel middle.
		/// </summary>
		// Token: 0x06006C70 RID: 27760 RVA: 0x0009C72C File Offset: 0x0009A92C
		public virtual int[] GetKernelMiddle()
		{
			IntPtr intPtr = vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_GetKernelMiddle_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006C71 RID: 27761
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSpatialAlgorithm_GetKernelMiddle_02(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Get the Kernel middle.
		/// </summary>
		// Token: 0x06006C72 RID: 27762 RVA: 0x0009C774 File Offset: 0x0009A974
		public virtual void GetKernelMiddle(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_GetKernelMiddle_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06006C73 RID: 27763
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSpatialAlgorithm_GetKernelMiddle_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the Kernel middle.
		/// </summary>
		// Token: 0x06006C74 RID: 27764 RVA: 0x0009C786 File Offset: 0x0009A986
		public virtual void GetKernelMiddle(IntPtr _arg)
		{
			vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_GetKernelMiddle_03(base.GetCppThis(), _arg);
		}

		// Token: 0x06006C75 RID: 27765
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSpatialAlgorithm_GetKernelSize_04(HandleRef pThis);

		/// <summary>
		/// Get the Kernel size.
		/// </summary>
		// Token: 0x06006C76 RID: 27766 RVA: 0x0009C798 File Offset: 0x0009A998
		public virtual int[] GetKernelSize()
		{
			IntPtr intPtr = vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_GetKernelSize_04(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006C77 RID: 27767
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSpatialAlgorithm_GetKernelSize_05(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Get the Kernel size.
		/// </summary>
		// Token: 0x06006C78 RID: 27768 RVA: 0x0009C7E0 File Offset: 0x0009A9E0
		public virtual void GetKernelSize(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_GetKernelSize_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06006C79 RID: 27769
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSpatialAlgorithm_GetKernelSize_06(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the Kernel size.
		/// </summary>
		// Token: 0x06006C7A RID: 27770 RVA: 0x0009C7F2 File Offset: 0x0009A9F2
		public virtual void GetKernelSize(IntPtr _arg)
		{
			vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_GetKernelSize_06(base.GetCppThis(), _arg);
		}

		// Token: 0x06006C7B RID: 27771
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSpatialAlgorithm_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C7C RID: 27772 RVA: 0x0009C804 File Offset: 0x0009AA04
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06006C7D RID: 27773
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSpatialAlgorithm_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C7E RID: 27774 RVA: 0x0009C824 File Offset: 0x0009AA24
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06006C7F RID: 27775
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSpatialAlgorithm_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C80 RID: 27776 RVA: 0x0009C840 File Offset: 0x0009AA40
		public override int IsA(string type)
		{
			return vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06006C81 RID: 27777
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSpatialAlgorithm_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C82 RID: 27778 RVA: 0x0009C860 File Offset: 0x0009AA60
		public new static int IsTypeOf(string type)
		{
			return vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_IsTypeOf_10(type);
		}

		// Token: 0x06006C83 RID: 27779
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSpatialAlgorithm_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C84 RID: 27780 RVA: 0x0009C87C File Offset: 0x0009AA7C
		public new vtkImageSpatialAlgorithm NewInstance()
		{
			vtkImageSpatialAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSpatialAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006C85 RID: 27781
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSpatialAlgorithm_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C86 RID: 27782 RVA: 0x0009C8D8 File Offset: 0x0009AAD8
		public new static vtkImageSpatialAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkImageSpatialAlgorithm vtkImageSpatialAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageSpatialAlgorithm = (vtkImageSpatialAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageSpatialAlgorithm.Register(null);
				}
			}
			return vtkImageSpatialAlgorithm;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000983 RID: 2435
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageSpatialAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000984 RID: 2436
		public new static readonly string MRClassNameKey = "class vtkImageSpatialAlgorithm";
	}
}
