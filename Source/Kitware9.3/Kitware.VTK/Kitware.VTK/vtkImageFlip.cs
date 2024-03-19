using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageFlip
	/// </summary>
	/// <remarks>
	///    This flips an axis of an image. Right becomes left ...
	///
	/// vtkImageFlip will reflect the data along the filtered axis.  This filter is
	/// actually a thin wrapper around vtkImageReslice.
	/// </remarks>
	// Token: 0x02000859 RID: 2137
	public class vtkImageFlip : vtkImageReslice
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060162A8 RID: 90792 RVA: 0x001F3486 File Offset: 0x001F1686
		static vtkImageFlip()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageFlip.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageFlip"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060162A9 RID: 90793 RVA: 0x001F34AE File Offset: 0x001F16AE
		public vtkImageFlip(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060162AA RID: 90794
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageFlip_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060162AB RID: 90795 RVA: 0x001F34BC File Offset: 0x001F16BC
		public new static vtkImageFlip New()
		{
			vtkImageFlip result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageFlip.vtkImageFlip_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageFlip)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060162AC RID: 90796 RVA: 0x001F3510 File Offset: 0x001F1710
		public vtkImageFlip() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageFlip.vtkImageFlip_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060162AD RID: 90797 RVA: 0x001F3554 File Offset: 0x001F1754
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060162AE RID: 90798
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageFlip_FlipAboutOriginOff_01(HandleRef pThis);

		/// <summary>
		/// By default the image will be flipped about its center, and the
		/// Origin, Spacing and Extent of the output will be identical to
		/// the input.  However, if you have a coordinate system associated
		/// with the image and you want to use the flip to convert +ve values
		/// along one axis to -ve values (and vice versa) then you actually
		/// want to flip the image about coordinate (0,0,0) instead of about
		/// the center of the image.  This method will adjust the Origin of
		/// the output such that the flip occurs about (0,0,0).  Note that
		/// this method only changes the Origin (and hence the coordinate system)
		/// the output data: the actual pixel values are the same whether or not
		/// this method is used.  Also note that the Origin in this method name
		/// refers to (0,0,0) in the coordinate system associated with the image,
		/// it does not refer to the Origin ivar that is associated with a
		/// vtkImageData.
		/// </summary>
		// Token: 0x060162AF RID: 90799 RVA: 0x001F355F File Offset: 0x001F175F
		public virtual void FlipAboutOriginOff()
		{
			vtkImageFlip.vtkImageFlip_FlipAboutOriginOff_01(base.GetCppThis());
		}

		// Token: 0x060162B0 RID: 90800
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageFlip_FlipAboutOriginOn_02(HandleRef pThis);

		/// <summary>
		/// By default the image will be flipped about its center, and the
		/// Origin, Spacing and Extent of the output will be identical to
		/// the input.  However, if you have a coordinate system associated
		/// with the image and you want to use the flip to convert +ve values
		/// along one axis to -ve values (and vice versa) then you actually
		/// want to flip the image about coordinate (0,0,0) instead of about
		/// the center of the image.  This method will adjust the Origin of
		/// the output such that the flip occurs about (0,0,0).  Note that
		/// this method only changes the Origin (and hence the coordinate system)
		/// the output data: the actual pixel values are the same whether or not
		/// this method is used.  Also note that the Origin in this method name
		/// refers to (0,0,0) in the coordinate system associated with the image,
		/// it does not refer to the Origin ivar that is associated with a
		/// vtkImageData.
		/// </summary>
		// Token: 0x060162B1 RID: 90801 RVA: 0x001F356E File Offset: 0x001F176E
		public virtual void FlipAboutOriginOn()
		{
			vtkImageFlip.vtkImageFlip_FlipAboutOriginOn_02(base.GetCppThis());
		}

		// Token: 0x060162B2 RID: 90802
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageFlip_GetFilteredAxes_03(HandleRef pThis);

		/// <summary>
		/// Keep the mis-named Axes variations around for compatibility with old
		/// scripts. Axis is singular, not plural...
		/// </summary>
		// Token: 0x060162B3 RID: 90803 RVA: 0x001F3580 File Offset: 0x001F1780
		public int GetFilteredAxes()
		{
			return vtkImageFlip.vtkImageFlip_GetFilteredAxes_03(base.GetCppThis());
		}

		// Token: 0x060162B4 RID: 90804
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageFlip_GetFilteredAxis_04(HandleRef pThis);

		/// <summary>
		/// Specify which axis will be flipped.  This must be an integer
		/// between 0 (for x) and 2 (for z). Initial value is 0.
		/// </summary>
		// Token: 0x060162B5 RID: 90805 RVA: 0x001F35A0 File Offset: 0x001F17A0
		public virtual int GetFilteredAxis()
		{
			return vtkImageFlip.vtkImageFlip_GetFilteredAxis_04(base.GetCppThis());
		}

		// Token: 0x060162B6 RID: 90806
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageFlip_GetFlipAboutOrigin_05(HandleRef pThis);

		/// <summary>
		/// By default the image will be flipped about its center, and the
		/// Origin, Spacing and Extent of the output will be identical to
		/// the input.  However, if you have a coordinate system associated
		/// with the image and you want to use the flip to convert +ve values
		/// along one axis to -ve values (and vice versa) then you actually
		/// want to flip the image about coordinate (0,0,0) instead of about
		/// the center of the image.  This method will adjust the Origin of
		/// the output such that the flip occurs about (0,0,0).  Note that
		/// this method only changes the Origin (and hence the coordinate system)
		/// the output data: the actual pixel values are the same whether or not
		/// this method is used.  Also note that the Origin in this method name
		/// refers to (0,0,0) in the coordinate system associated with the image,
		/// it does not refer to the Origin ivar that is associated with a
		/// vtkImageData.
		/// </summary>
		// Token: 0x060162B7 RID: 90807 RVA: 0x001F35C0 File Offset: 0x001F17C0
		public virtual int GetFlipAboutOrigin()
		{
			return vtkImageFlip.vtkImageFlip_GetFlipAboutOrigin_05(base.GetCppThis());
		}

		// Token: 0x060162B8 RID: 90808
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageFlip_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060162B9 RID: 90809 RVA: 0x001F35E0 File Offset: 0x001F17E0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageFlip.vtkImageFlip_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x060162BA RID: 90810
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageFlip_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060162BB RID: 90811 RVA: 0x001F3600 File Offset: 0x001F1800
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageFlip.vtkImageFlip_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x060162BC RID: 90812
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageFlip_GetPreserveImageExtent_08(HandleRef pThis);

		/// <summary>
		/// PreserveImageExtentOff wasn't covered by test scripts and its
		/// implementation was broken.  It is deprecated now and it has
		/// no effect (i.e. the ImageExtent is always preserved).
		/// </summary>
		// Token: 0x060162BD RID: 90813 RVA: 0x001F361C File Offset: 0x001F181C
		public virtual int GetPreserveImageExtent()
		{
			return vtkImageFlip.vtkImageFlip_GetPreserveImageExtent_08(base.GetCppThis());
		}

		// Token: 0x060162BE RID: 90814
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageFlip_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060162BF RID: 90815 RVA: 0x001F363C File Offset: 0x001F183C
		public override int IsA(string type)
		{
			return vtkImageFlip.vtkImageFlip_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x060162C0 RID: 90816
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageFlip_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060162C1 RID: 90817 RVA: 0x001F365C File Offset: 0x001F185C
		public new static int IsTypeOf(string type)
		{
			return vtkImageFlip.vtkImageFlip_IsTypeOf_10(type);
		}

		// Token: 0x060162C2 RID: 90818
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageFlip_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060162C3 RID: 90819 RVA: 0x001F3678 File Offset: 0x001F1878
		public new vtkImageFlip NewInstance()
		{
			vtkImageFlip result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageFlip.vtkImageFlip_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageFlip)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060162C4 RID: 90820
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageFlip_PreserveImageExtentOff_13(HandleRef pThis);

		/// <summary>
		/// PreserveImageExtentOff wasn't covered by test scripts and its
		/// implementation was broken.  It is deprecated now and it has
		/// no effect (i.e. the ImageExtent is always preserved).
		/// </summary>
		// Token: 0x060162C5 RID: 90821 RVA: 0x001F36D2 File Offset: 0x001F18D2
		public virtual void PreserveImageExtentOff()
		{
			vtkImageFlip.vtkImageFlip_PreserveImageExtentOff_13(base.GetCppThis());
		}

		// Token: 0x060162C6 RID: 90822
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageFlip_PreserveImageExtentOn_14(HandleRef pThis);

		/// <summary>
		/// PreserveImageExtentOff wasn't covered by test scripts and its
		/// implementation was broken.  It is deprecated now and it has
		/// no effect (i.e. the ImageExtent is always preserved).
		/// </summary>
		// Token: 0x060162C7 RID: 90823 RVA: 0x001F36E1 File Offset: 0x001F18E1
		public virtual void PreserveImageExtentOn()
		{
			vtkImageFlip.vtkImageFlip_PreserveImageExtentOn_14(base.GetCppThis());
		}

		// Token: 0x060162C8 RID: 90824
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageFlip_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060162C9 RID: 90825 RVA: 0x001F36F0 File Offset: 0x001F18F0
		public new static vtkImageFlip SafeDownCast(vtkObjectBase o)
		{
			vtkImageFlip vtkImageFlip = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageFlip.vtkImageFlip_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageFlip = (vtkImageFlip)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageFlip.Register(null);
				}
			}
			return vtkImageFlip;
		}

		// Token: 0x060162CA RID: 90826
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageFlip_SetFilteredAxes_16(HandleRef pThis, int axis);

		/// <summary>
		/// Keep the mis-named Axes variations around for compatibility with old
		/// scripts. Axis is singular, not plural...
		/// </summary>
		// Token: 0x060162CB RID: 90827 RVA: 0x001F376F File Offset: 0x001F196F
		public void SetFilteredAxes(int axis)
		{
			vtkImageFlip.vtkImageFlip_SetFilteredAxes_16(base.GetCppThis(), axis);
		}

		// Token: 0x060162CC RID: 90828
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageFlip_SetFilteredAxis_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify which axis will be flipped.  This must be an integer
		/// between 0 (for x) and 2 (for z). Initial value is 0.
		/// </summary>
		// Token: 0x060162CD RID: 90829 RVA: 0x001F377F File Offset: 0x001F197F
		public virtual void SetFilteredAxis(int _arg)
		{
			vtkImageFlip.vtkImageFlip_SetFilteredAxis_17(base.GetCppThis(), _arg);
		}

		// Token: 0x060162CE RID: 90830
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageFlip_SetFlipAboutOrigin_18(HandleRef pThis, int _arg);

		/// <summary>
		/// By default the image will be flipped about its center, and the
		/// Origin, Spacing and Extent of the output will be identical to
		/// the input.  However, if you have a coordinate system associated
		/// with the image and you want to use the flip to convert +ve values
		/// along one axis to -ve values (and vice versa) then you actually
		/// want to flip the image about coordinate (0,0,0) instead of about
		/// the center of the image.  This method will adjust the Origin of
		/// the output such that the flip occurs about (0,0,0).  Note that
		/// this method only changes the Origin (and hence the coordinate system)
		/// the output data: the actual pixel values are the same whether or not
		/// this method is used.  Also note that the Origin in this method name
		/// refers to (0,0,0) in the coordinate system associated with the image,
		/// it does not refer to the Origin ivar that is associated with a
		/// vtkImageData.
		/// </summary>
		// Token: 0x060162CF RID: 90831 RVA: 0x001F378F File Offset: 0x001F198F
		public virtual void SetFlipAboutOrigin(int _arg)
		{
			vtkImageFlip.vtkImageFlip_SetFlipAboutOrigin_18(base.GetCppThis(), _arg);
		}

		// Token: 0x060162D0 RID: 90832
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageFlip_SetPreserveImageExtent_19(HandleRef pThis, int _arg);

		/// <summary>
		/// PreserveImageExtentOff wasn't covered by test scripts and its
		/// implementation was broken.  It is deprecated now and it has
		/// no effect (i.e. the ImageExtent is always preserved).
		/// </summary>
		// Token: 0x060162D1 RID: 90833 RVA: 0x001F379F File Offset: 0x001F199F
		public virtual void SetPreserveImageExtent(int _arg)
		{
			vtkImageFlip.vtkImageFlip_SetPreserveImageExtent_19(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001906 RID: 6406
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageFlip";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001907 RID: 6407
		public new static readonly string MRClassNameKey = "class vtkImageFlip";
	}
}
