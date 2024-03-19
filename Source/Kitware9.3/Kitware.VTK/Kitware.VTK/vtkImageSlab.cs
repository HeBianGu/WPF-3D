using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageSlab
	/// </summary>
	/// <remarks>
	///    combine image slices to form a slab image
	///
	/// vtkImageSlab will combine all of the slices of an image to
	/// create a single slice.  The slices can be combined with the
	/// following operations: averaging, summation, minimum, maximum.
	/// If you require an arbitrary angle of projection, you can use
	/// vtkImageReslice.
	/// @par Thanks:
	/// Thanks to David Gobbi for contributing this class to VTK.
	/// </remarks>
	// Token: 0x0200048E RID: 1166
	public class vtkImageSlab : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D5D3 RID: 54739 RVA: 0x00129B5F File Offset: 0x00127D5F
		static vtkImageSlab()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageSlab.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSlab"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D5D4 RID: 54740 RVA: 0x00129B87 File Offset: 0x00127D87
		public vtkImageSlab(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D5D5 RID: 54741
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSlab_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5D6 RID: 54742 RVA: 0x00129B98 File Offset: 0x00127D98
		public new static vtkImageSlab New()
		{
			vtkImageSlab result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSlab.vtkImageSlab_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSlab)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5D7 RID: 54743 RVA: 0x00129BEC File Offset: 0x00127DEC
		public vtkImageSlab() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageSlab.vtkImageSlab_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D5D8 RID: 54744 RVA: 0x00129C30 File Offset: 0x00127E30
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D5D9 RID: 54745
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSlab_GetMultiSliceOutput_01(HandleRef pThis);

		/// <summary>
		/// Turn on multi-slice output.  Each slice of the output will be
		/// a projection through the specified range of input slices, e.g.
		/// if the SliceRange is [0,3] then slice 'i' of the output will
		/// be a projection through slices 'i' through '3+i' of the input.
		/// This flag is off by default.
		/// </summary>
		// Token: 0x0600D5DA RID: 54746 RVA: 0x00129C3C File Offset: 0x00127E3C
		public virtual int GetMultiSliceOutput()
		{
			return vtkImageSlab.vtkImageSlab_GetMultiSliceOutput_01(base.GetCppThis());
		}

		// Token: 0x0600D5DB RID: 54747
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSlab_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5DC RID: 54748 RVA: 0x00129C5C File Offset: 0x00127E5C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageSlab.vtkImageSlab_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600D5DD RID: 54749
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSlab_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5DE RID: 54750 RVA: 0x00129C7C File Offset: 0x00127E7C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageSlab.vtkImageSlab_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600D5DF RID: 54751
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSlab_GetOperation_04(HandleRef pThis);

		/// <summary>
		/// Set the operation to use when combining slices.  The choices are
		/// "Mean", "Sum", "Min", "Max".  The default is "Mean".
		/// </summary>
		// Token: 0x0600D5E0 RID: 54752 RVA: 0x00129C98 File Offset: 0x00127E98
		public virtual int GetOperation()
		{
			return vtkImageSlab.vtkImageSlab_GetOperation_04(base.GetCppThis());
		}

		// Token: 0x0600D5E1 RID: 54753
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSlab_GetOperationAsString_05(HandleRef pThis);

		/// <summary>
		/// Set the operation to use when combining slices.  The choices are
		/// "Mean", "Sum", "Min", "Max".  The default is "Mean".
		/// </summary>
		// Token: 0x0600D5E2 RID: 54754 RVA: 0x00129CB8 File Offset: 0x00127EB8
		public string GetOperationAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageSlab.vtkImageSlab_GetOperationAsString_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600D5E3 RID: 54755
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSlab_GetOperationMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Set the operation to use when combining slices.  The choices are
		/// "Mean", "Sum", "Min", "Max".  The default is "Mean".
		/// </summary>
		// Token: 0x0600D5E4 RID: 54756 RVA: 0x00129CF4 File Offset: 0x00127EF4
		public virtual int GetOperationMaxValue()
		{
			return vtkImageSlab.vtkImageSlab_GetOperationMaxValue_06(base.GetCppThis());
		}

		// Token: 0x0600D5E5 RID: 54757
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSlab_GetOperationMinValue_07(HandleRef pThis);

		/// <summary>
		/// Set the operation to use when combining slices.  The choices are
		/// "Mean", "Sum", "Min", "Max".  The default is "Mean".
		/// </summary>
		// Token: 0x0600D5E6 RID: 54758 RVA: 0x00129D14 File Offset: 0x00127F14
		public virtual int GetOperationMinValue()
		{
			return vtkImageSlab.vtkImageSlab_GetOperationMinValue_07(base.GetCppThis());
		}

		// Token: 0x0600D5E7 RID: 54759
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSlab_GetOrientation_08(HandleRef pThis);

		/// <summary>
		/// Set the slice direction: zero for x, 1 for y, 2 for z.
		/// The default is the Z direction.
		/// </summary>
		// Token: 0x0600D5E8 RID: 54760 RVA: 0x00129D34 File Offset: 0x00127F34
		public virtual int GetOrientation()
		{
			return vtkImageSlab.vtkImageSlab_GetOrientation_08(base.GetCppThis());
		}

		// Token: 0x0600D5E9 RID: 54761
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSlab_GetOrientationMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Set the slice direction: zero for x, 1 for y, 2 for z.
		/// The default is the Z direction.
		/// </summary>
		// Token: 0x0600D5EA RID: 54762 RVA: 0x00129D54 File Offset: 0x00127F54
		public virtual int GetOrientationMaxValue()
		{
			return vtkImageSlab.vtkImageSlab_GetOrientationMaxValue_09(base.GetCppThis());
		}

		// Token: 0x0600D5EB RID: 54763
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSlab_GetOrientationMinValue_10(HandleRef pThis);

		/// <summary>
		/// Set the slice direction: zero for x, 1 for y, 2 for z.
		/// The default is the Z direction.
		/// </summary>
		// Token: 0x0600D5EC RID: 54764 RVA: 0x00129D74 File Offset: 0x00127F74
		public virtual int GetOrientationMinValue()
		{
			return vtkImageSlab.vtkImageSlab_GetOrientationMinValue_10(base.GetCppThis());
		}

		// Token: 0x0600D5ED RID: 54765
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSlab_GetOutputScalarType_11(HandleRef pThis);

		/// <summary>
		/// Set the output scalar type to float or double, to avoid
		/// potential overflow when doing a summation operation.
		/// The default is to use the scalar type of the input data,
		/// and clamp the output to the range of the input scalar type.
		/// </summary>
		// Token: 0x0600D5EE RID: 54766 RVA: 0x00129D94 File Offset: 0x00127F94
		public virtual int GetOutputScalarType()
		{
			return vtkImageSlab.vtkImageSlab_GetOutputScalarType_11(base.GetCppThis());
		}

		// Token: 0x0600D5EF RID: 54767
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSlab_GetSliceRange_12(HandleRef pThis);

		/// <summary>
		/// Set the range of slices to combine. The default is to project
		/// through all slices.
		/// </summary>
		// Token: 0x0600D5F0 RID: 54768 RVA: 0x00129DB4 File Offset: 0x00127FB4
		public virtual int[] GetSliceRange()
		{
			IntPtr intPtr = vtkImageSlab.vtkImageSlab_GetSliceRange_12(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D5F1 RID: 54769
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlab_GetSliceRange_13(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Set the range of slices to combine. The default is to project
		/// through all slices.
		/// </summary>
		// Token: 0x0600D5F2 RID: 54770 RVA: 0x00129DFC File Offset: 0x00127FFC
		public virtual void GetSliceRange(ref int _arg1, ref int _arg2)
		{
			vtkImageSlab.vtkImageSlab_GetSliceRange_13(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600D5F3 RID: 54771
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlab_GetSliceRange_14(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the range of slices to combine. The default is to project
		/// through all slices.
		/// </summary>
		// Token: 0x0600D5F4 RID: 54772 RVA: 0x00129E0D File Offset: 0x0012800D
		public virtual void GetSliceRange(IntPtr _arg)
		{
			vtkImageSlab.vtkImageSlab_GetSliceRange_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D5F5 RID: 54773
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSlab_GetTrapezoidIntegration_15(HandleRef pThis);

		/// <summary>
		/// Use trapezoid integration for slab computation.  This weighs the
		/// first and last slices by half when doing sum and mean, as compared
		/// to the default midpoint integration that weighs all slices equally.
		/// It is off by default.
		/// </summary>
		// Token: 0x0600D5F6 RID: 54774 RVA: 0x00129E20 File Offset: 0x00128020
		public virtual int GetTrapezoidIntegration()
		{
			return vtkImageSlab.vtkImageSlab_GetTrapezoidIntegration_15(base.GetCppThis());
		}

		// Token: 0x0600D5F7 RID: 54775
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSlab_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5F8 RID: 54776 RVA: 0x00129E40 File Offset: 0x00128040
		public override int IsA(string type)
		{
			return vtkImageSlab.vtkImageSlab_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0600D5F9 RID: 54777
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSlab_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5FA RID: 54778 RVA: 0x00129E60 File Offset: 0x00128060
		public new static int IsTypeOf(string type)
		{
			return vtkImageSlab.vtkImageSlab_IsTypeOf_17(type);
		}

		// Token: 0x0600D5FB RID: 54779
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlab_MultiSliceOutputOff_18(HandleRef pThis);

		/// <summary>
		/// Turn on multi-slice output.  Each slice of the output will be
		/// a projection through the specified range of input slices, e.g.
		/// if the SliceRange is [0,3] then slice 'i' of the output will
		/// be a projection through slices 'i' through '3+i' of the input.
		/// This flag is off by default.
		/// </summary>
		// Token: 0x0600D5FC RID: 54780 RVA: 0x00129E7A File Offset: 0x0012807A
		public virtual void MultiSliceOutputOff()
		{
			vtkImageSlab.vtkImageSlab_MultiSliceOutputOff_18(base.GetCppThis());
		}

		// Token: 0x0600D5FD RID: 54781
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlab_MultiSliceOutputOn_19(HandleRef pThis);

		/// <summary>
		/// Turn on multi-slice output.  Each slice of the output will be
		/// a projection through the specified range of input slices, e.g.
		/// if the SliceRange is [0,3] then slice 'i' of the output will
		/// be a projection through slices 'i' through '3+i' of the input.
		/// This flag is off by default.
		/// </summary>
		// Token: 0x0600D5FE RID: 54782 RVA: 0x00129E89 File Offset: 0x00128089
		public virtual void MultiSliceOutputOn()
		{
			vtkImageSlab.vtkImageSlab_MultiSliceOutputOn_19(base.GetCppThis());
		}

		// Token: 0x0600D5FF RID: 54783
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSlab_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D600 RID: 54784 RVA: 0x00129E98 File Offset: 0x00128098
		public new vtkImageSlab NewInstance()
		{
			vtkImageSlab result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSlab.vtkImageSlab_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSlab)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D601 RID: 54785
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSlab_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D602 RID: 54786 RVA: 0x00129EF4 File Offset: 0x001280F4
		public new static vtkImageSlab SafeDownCast(vtkObjectBase o)
		{
			vtkImageSlab vtkImageSlab = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSlab.vtkImageSlab_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageSlab = (vtkImageSlab)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageSlab.Register(null);
				}
			}
			return vtkImageSlab;
		}

		// Token: 0x0600D603 RID: 54787
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlab_SetMultiSliceOutput_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on multi-slice output.  Each slice of the output will be
		/// a projection through the specified range of input slices, e.g.
		/// if the SliceRange is [0,3] then slice 'i' of the output will
		/// be a projection through slices 'i' through '3+i' of the input.
		/// This flag is off by default.
		/// </summary>
		// Token: 0x0600D604 RID: 54788 RVA: 0x00129F73 File Offset: 0x00128173
		public virtual void SetMultiSliceOutput(int _arg)
		{
			vtkImageSlab.vtkImageSlab_SetMultiSliceOutput_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D605 RID: 54789
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlab_SetOperation_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the operation to use when combining slices.  The choices are
		/// "Mean", "Sum", "Min", "Max".  The default is "Mean".
		/// </summary>
		// Token: 0x0600D606 RID: 54790 RVA: 0x00129F83 File Offset: 0x00128183
		public virtual void SetOperation(int _arg)
		{
			vtkImageSlab.vtkImageSlab_SetOperation_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D607 RID: 54791
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlab_SetOperationToMax_25(HandleRef pThis);

		/// <summary>
		/// Set the operation to use when combining slices.  The choices are
		/// "Mean", "Sum", "Min", "Max".  The default is "Mean".
		/// </summary>
		// Token: 0x0600D608 RID: 54792 RVA: 0x00129F93 File Offset: 0x00128193
		public void SetOperationToMax()
		{
			vtkImageSlab.vtkImageSlab_SetOperationToMax_25(base.GetCppThis());
		}

		// Token: 0x0600D609 RID: 54793
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlab_SetOperationToMean_26(HandleRef pThis);

		/// <summary>
		/// Set the operation to use when combining slices.  The choices are
		/// "Mean", "Sum", "Min", "Max".  The default is "Mean".
		/// </summary>
		// Token: 0x0600D60A RID: 54794 RVA: 0x00129FA2 File Offset: 0x001281A2
		public void SetOperationToMean()
		{
			vtkImageSlab.vtkImageSlab_SetOperationToMean_26(base.GetCppThis());
		}

		// Token: 0x0600D60B RID: 54795
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlab_SetOperationToMin_27(HandleRef pThis);

		/// <summary>
		/// Set the operation to use when combining slices.  The choices are
		/// "Mean", "Sum", "Min", "Max".  The default is "Mean".
		/// </summary>
		// Token: 0x0600D60C RID: 54796 RVA: 0x00129FB1 File Offset: 0x001281B1
		public void SetOperationToMin()
		{
			vtkImageSlab.vtkImageSlab_SetOperationToMin_27(base.GetCppThis());
		}

		// Token: 0x0600D60D RID: 54797
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlab_SetOperationToSum_28(HandleRef pThis);

		/// <summary>
		/// Set the operation to use when combining slices.  The choices are
		/// "Mean", "Sum", "Min", "Max".  The default is "Mean".
		/// </summary>
		// Token: 0x0600D60E RID: 54798 RVA: 0x00129FC0 File Offset: 0x001281C0
		public void SetOperationToSum()
		{
			vtkImageSlab.vtkImageSlab_SetOperationToSum_28(base.GetCppThis());
		}

		// Token: 0x0600D60F RID: 54799
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlab_SetOrientation_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the slice direction: zero for x, 1 for y, 2 for z.
		/// The default is the Z direction.
		/// </summary>
		// Token: 0x0600D610 RID: 54800 RVA: 0x00129FCF File Offset: 0x001281CF
		public virtual void SetOrientation(int _arg)
		{
			vtkImageSlab.vtkImageSlab_SetOrientation_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D611 RID: 54801
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlab_SetOrientationToX_30(HandleRef pThis);

		/// <summary>
		/// Set the slice direction: zero for x, 1 for y, 2 for z.
		/// The default is the Z direction.
		/// </summary>
		// Token: 0x0600D612 RID: 54802 RVA: 0x00129FDF File Offset: 0x001281DF
		public void SetOrientationToX()
		{
			vtkImageSlab.vtkImageSlab_SetOrientationToX_30(base.GetCppThis());
		}

		// Token: 0x0600D613 RID: 54803
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlab_SetOrientationToY_31(HandleRef pThis);

		/// <summary>
		/// Set the slice direction: zero for x, 1 for y, 2 for z.
		/// The default is the Z direction.
		/// </summary>
		// Token: 0x0600D614 RID: 54804 RVA: 0x00129FEE File Offset: 0x001281EE
		public void SetOrientationToY()
		{
			vtkImageSlab.vtkImageSlab_SetOrientationToY_31(base.GetCppThis());
		}

		// Token: 0x0600D615 RID: 54805
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlab_SetOrientationToZ_32(HandleRef pThis);

		/// <summary>
		/// Set the slice direction: zero for x, 1 for y, 2 for z.
		/// The default is the Z direction.
		/// </summary>
		// Token: 0x0600D616 RID: 54806 RVA: 0x00129FFD File Offset: 0x001281FD
		public void SetOrientationToZ()
		{
			vtkImageSlab.vtkImageSlab_SetOrientationToZ_32(base.GetCppThis());
		}

		// Token: 0x0600D617 RID: 54807
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlab_SetOutputScalarTypeToDouble_33(HandleRef pThis);

		/// <summary>
		/// Set the output scalar type to float or double, to avoid
		/// potential overflow when doing a summation operation.
		/// The default is to use the scalar type of the input data,
		/// and clamp the output to the range of the input scalar type.
		/// </summary>
		// Token: 0x0600D618 RID: 54808 RVA: 0x0012A00C File Offset: 0x0012820C
		public void SetOutputScalarTypeToDouble()
		{
			vtkImageSlab.vtkImageSlab_SetOutputScalarTypeToDouble_33(base.GetCppThis());
		}

		// Token: 0x0600D619 RID: 54809
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlab_SetOutputScalarTypeToFloat_34(HandleRef pThis);

		/// <summary>
		/// Set the output scalar type to float or double, to avoid
		/// potential overflow when doing a summation operation.
		/// The default is to use the scalar type of the input data,
		/// and clamp the output to the range of the input scalar type.
		/// </summary>
		// Token: 0x0600D61A RID: 54810 RVA: 0x0012A01B File Offset: 0x0012821B
		public void SetOutputScalarTypeToFloat()
		{
			vtkImageSlab.vtkImageSlab_SetOutputScalarTypeToFloat_34(base.GetCppThis());
		}

		// Token: 0x0600D61B RID: 54811
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlab_SetOutputScalarTypeToInputScalarType_35(HandleRef pThis);

		/// <summary>
		/// Set the output scalar type to float or double, to avoid
		/// potential overflow when doing a summation operation.
		/// The default is to use the scalar type of the input data,
		/// and clamp the output to the range of the input scalar type.
		/// </summary>
		// Token: 0x0600D61C RID: 54812 RVA: 0x0012A02A File Offset: 0x0012822A
		public void SetOutputScalarTypeToInputScalarType()
		{
			vtkImageSlab.vtkImageSlab_SetOutputScalarTypeToInputScalarType_35(base.GetCppThis());
		}

		// Token: 0x0600D61D RID: 54813
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlab_SetSliceRange_36(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set the range of slices to combine. The default is to project
		/// through all slices.
		/// </summary>
		// Token: 0x0600D61E RID: 54814 RVA: 0x0012A039 File Offset: 0x00128239
		public virtual void SetSliceRange(int _arg1, int _arg2)
		{
			vtkImageSlab.vtkImageSlab_SetSliceRange_36(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600D61F RID: 54815
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlab_SetSliceRange_37(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the range of slices to combine. The default is to project
		/// through all slices.
		/// </summary>
		// Token: 0x0600D620 RID: 54816 RVA: 0x0012A04A File Offset: 0x0012824A
		public void SetSliceRange(IntPtr _arg)
		{
			vtkImageSlab.vtkImageSlab_SetSliceRange_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D621 RID: 54817
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlab_SetTrapezoidIntegration_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Use trapezoid integration for slab computation.  This weighs the
		/// first and last slices by half when doing sum and mean, as compared
		/// to the default midpoint integration that weighs all slices equally.
		/// It is off by default.
		/// </summary>
		// Token: 0x0600D622 RID: 54818 RVA: 0x0012A05A File Offset: 0x0012825A
		public virtual void SetTrapezoidIntegration(int _arg)
		{
			vtkImageSlab.vtkImageSlab_SetTrapezoidIntegration_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D623 RID: 54819
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlab_TrapezoidIntegrationOff_39(HandleRef pThis);

		/// <summary>
		/// Use trapezoid integration for slab computation.  This weighs the
		/// first and last slices by half when doing sum and mean, as compared
		/// to the default midpoint integration that weighs all slices equally.
		/// It is off by default.
		/// </summary>
		// Token: 0x0600D624 RID: 54820 RVA: 0x0012A06A File Offset: 0x0012826A
		public virtual void TrapezoidIntegrationOff()
		{
			vtkImageSlab.vtkImageSlab_TrapezoidIntegrationOff_39(base.GetCppThis());
		}

		// Token: 0x0600D625 RID: 54821
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlab_TrapezoidIntegrationOn_40(HandleRef pThis);

		/// <summary>
		/// Use trapezoid integration for slab computation.  This weighs the
		/// first and last slices by half when doing sum and mean, as compared
		/// to the default midpoint integration that weighs all slices equally.
		/// It is off by default.
		/// </summary>
		// Token: 0x0600D626 RID: 54822 RVA: 0x0012A079 File Offset: 0x00128279
		public virtual void TrapezoidIntegrationOn()
		{
			vtkImageSlab.vtkImageSlab_TrapezoidIntegrationOn_40(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FC4 RID: 4036
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageSlab";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FC5 RID: 4037
		public new static readonly string MRClassNameKey = "class vtkImageSlab";
	}
}
