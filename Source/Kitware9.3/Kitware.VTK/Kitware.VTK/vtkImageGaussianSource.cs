using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageGaussianSource
	/// </summary>
	/// <remarks>
	///    Create an image with Gaussian pixel values.
	///
	/// vtkImageGaussianSource just produces images with pixel values determined
	/// by a Gaussian.
	/// </remarks>
	// Token: 0x02000756 RID: 1878
	public class vtkImageGaussianSource : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060137C1 RID: 79809 RVA: 0x001B8CB5 File Offset: 0x001B6EB5
		static vtkImageGaussianSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageGaussianSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageGaussianSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060137C2 RID: 79810 RVA: 0x001B8CDD File Offset: 0x001B6EDD
		public vtkImageGaussianSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060137C3 RID: 79811
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGaussianSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060137C4 RID: 79812 RVA: 0x001B8CEC File Offset: 0x001B6EEC
		public new static vtkImageGaussianSource New()
		{
			vtkImageGaussianSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageGaussianSource.vtkImageGaussianSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageGaussianSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060137C5 RID: 79813 RVA: 0x001B8D40 File Offset: 0x001B6F40
		public vtkImageGaussianSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageGaussianSource.vtkImageGaussianSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060137C6 RID: 79814 RVA: 0x001B8D84 File Offset: 0x001B6F84
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060137C7 RID: 79815
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGaussianSource_GetCenter_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the center of the Gaussian.
		/// </summary>
		// Token: 0x060137C8 RID: 79816 RVA: 0x001B8D90 File Offset: 0x001B6F90
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkImageGaussianSource.vtkImageGaussianSource_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060137C9 RID: 79817
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGaussianSource_GetCenter_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the center of the Gaussian.
		/// </summary>
		// Token: 0x060137CA RID: 79818 RVA: 0x001B8DD8 File Offset: 0x001B6FD8
		public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageGaussianSource.vtkImageGaussianSource_GetCenter_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060137CB RID: 79819
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGaussianSource_GetCenter_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the center of the Gaussian.
		/// </summary>
		// Token: 0x060137CC RID: 79820 RVA: 0x001B8DEA File Offset: 0x001B6FEA
		public virtual void GetCenter(IntPtr _arg)
		{
			vtkImageGaussianSource.vtkImageGaussianSource_GetCenter_03(base.GetCppThis(), _arg);
		}

		// Token: 0x060137CD RID: 79821
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageGaussianSource_GetMaximum_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the Maximum value of the gaussian
		/// </summary>
		// Token: 0x060137CE RID: 79822 RVA: 0x001B8DFC File Offset: 0x001B6FFC
		public virtual double GetMaximum()
		{
			return vtkImageGaussianSource.vtkImageGaussianSource_GetMaximum_04(base.GetCppThis());
		}

		// Token: 0x060137CF RID: 79823
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageGaussianSource_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060137D0 RID: 79824 RVA: 0x001B8E1C File Offset: 0x001B701C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageGaussianSource.vtkImageGaussianSource_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060137D1 RID: 79825
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageGaussianSource_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060137D2 RID: 79826 RVA: 0x001B8E3C File Offset: 0x001B703C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageGaussianSource.vtkImageGaussianSource_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060137D3 RID: 79827
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageGaussianSource_GetStandardDeviation_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the standard deviation of the gaussian
		/// </summary>
		// Token: 0x060137D4 RID: 79828 RVA: 0x001B8E58 File Offset: 0x001B7058
		public virtual double GetStandardDeviation()
		{
			return vtkImageGaussianSource.vtkImageGaussianSource_GetStandardDeviation_07(base.GetCppThis());
		}

		// Token: 0x060137D5 RID: 79829
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageGaussianSource_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060137D6 RID: 79830 RVA: 0x001B8E78 File Offset: 0x001B7078
		public override int IsA(string type)
		{
			return vtkImageGaussianSource.vtkImageGaussianSource_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x060137D7 RID: 79831
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageGaussianSource_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060137D8 RID: 79832 RVA: 0x001B8E98 File Offset: 0x001B7098
		public new static int IsTypeOf(string type)
		{
			return vtkImageGaussianSource.vtkImageGaussianSource_IsTypeOf_09(type);
		}

		// Token: 0x060137D9 RID: 79833
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGaussianSource_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060137DA RID: 79834 RVA: 0x001B8EB4 File Offset: 0x001B70B4
		public new vtkImageGaussianSource NewInstance()
		{
			vtkImageGaussianSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageGaussianSource.vtkImageGaussianSource_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageGaussianSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060137DB RID: 79835
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGaussianSource_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060137DC RID: 79836 RVA: 0x001B8F10 File Offset: 0x001B7110
		public new static vtkImageGaussianSource SafeDownCast(vtkObjectBase o)
		{
			vtkImageGaussianSource vtkImageGaussianSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageGaussianSource.vtkImageGaussianSource_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageGaussianSource = (vtkImageGaussianSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageGaussianSource.Register(null);
				}
			}
			return vtkImageGaussianSource;
		}

		// Token: 0x060137DD RID: 79837
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGaussianSource_SetCenter_13(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the center of the Gaussian.
		/// </summary>
		// Token: 0x060137DE RID: 79838 RVA: 0x001B8F8F File Offset: 0x001B718F
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkImageGaussianSource.vtkImageGaussianSource_SetCenter_13(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060137DF RID: 79839
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGaussianSource_SetCenter_14(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the center of the Gaussian.
		/// </summary>
		// Token: 0x060137E0 RID: 79840 RVA: 0x001B8FA1 File Offset: 0x001B71A1
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkImageGaussianSource.vtkImageGaussianSource_SetCenter_14(base.GetCppThis(), _arg);
		}

		// Token: 0x060137E1 RID: 79841
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGaussianSource_SetMaximum_15(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the Maximum value of the gaussian
		/// </summary>
		// Token: 0x060137E2 RID: 79842 RVA: 0x001B8FB1 File Offset: 0x001B71B1
		public virtual void SetMaximum(double _arg)
		{
			vtkImageGaussianSource.vtkImageGaussianSource_SetMaximum_15(base.GetCppThis(), _arg);
		}

		// Token: 0x060137E3 RID: 79843
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGaussianSource_SetStandardDeviation_16(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the standard deviation of the gaussian
		/// </summary>
		// Token: 0x060137E4 RID: 79844 RVA: 0x001B8FC1 File Offset: 0x001B71C1
		public virtual void SetStandardDeviation(double _arg)
		{
			vtkImageGaussianSource.vtkImageGaussianSource_SetStandardDeviation_16(base.GetCppThis(), _arg);
		}

		// Token: 0x060137E5 RID: 79845
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGaussianSource_SetWholeExtent_17(HandleRef pThis, int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax);

		/// <summary>
		/// Set/Get the extent of the whole output image.
		/// </summary>
		// Token: 0x060137E6 RID: 79846 RVA: 0x001B8FD1 File Offset: 0x001B71D1
		public void SetWholeExtent(int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax)
		{
			vtkImageGaussianSource.vtkImageGaussianSource_SetWholeExtent_17(base.GetCppThis(), xMinx, xMax, yMin, yMax, zMin, zMax);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001689 RID: 5769
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageGaussianSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400168A RID: 5770
		public new static readonly string MRClassNameKey = "class vtkImageGaussianSource";
	}
}
