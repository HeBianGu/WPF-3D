using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImplicitVolume
	/// </summary>
	/// <remarks>
	///    treat a volume as if it were an implicit function
	///
	/// vtkImplicitVolume treats a volume (e.g., structured point dataset)
	/// as if it were an implicit function. This means it computes a function
	/// value and gradient. vtkImplicitVolume is a concrete implementation of
	/// vtkImplicitFunction.
	///
	/// vtkImplicitDataSet computes the function (at the point x) by performing
	/// cell interpolation. That is, it finds the cell containing x, and then
	/// uses the cell's interpolation functions to compute an interpolated
	/// scalar value at x. (A similar approach is used to find the
	/// gradient, if requested.) Points outside of the dataset are assigned
	/// the value of the ivar OutValue, and the gradient value OutGradient.
	///
	/// @warning
	/// The input volume data is only updated when GetMTime() is called.
	/// Works for 3D structured points datasets, 0D-2D datasets won't work properly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitFunction vtkImplicitDataSet vtkClipPolyData vtkCutter
	/// vtkImplicitWindowFunction
	/// </seealso>
	// Token: 0x02000A6C RID: 2668
	public class vtkImplicitVolume : vtkImplicitFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BEDD RID: 114397 RVA: 0x00271FDC File Offset: 0x002701DC
		static vtkImplicitVolume()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitVolume.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitVolume"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BEDE RID: 114398 RVA: 0x00272004 File Offset: 0x00270204
		public vtkImplicitVolume(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601BEDF RID: 114399
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitVolume_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an vtkImplicitVolume with no initial volume; the OutValue
		/// set to a large negative number; and the OutGradient set to (0,0,1).
		/// </summary>
		// Token: 0x0601BEE0 RID: 114400 RVA: 0x00272014 File Offset: 0x00270214
		public new static vtkImplicitVolume New()
		{
			vtkImplicitVolume result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitVolume.vtkImplicitVolume_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitVolume)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct an vtkImplicitVolume with no initial volume; the OutValue
		/// set to a large negative number; and the OutGradient set to (0,0,1).
		/// </summary>
		// Token: 0x0601BEE1 RID: 114401 RVA: 0x00272068 File Offset: 0x00270268
		public vtkImplicitVolume() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImplicitVolume.vtkImplicitVolume_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BEE2 RID: 114402 RVA: 0x002720AC File Offset: 0x002702AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BEE3 RID: 114403
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitVolume_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate the ImplicitVolume. This returns the interpolated scalar value
		/// at x[3].
		/// </summary>
		// Token: 0x0601BEE4 RID: 114404 RVA: 0x002720B8 File Offset: 0x002702B8
		public override double EvaluateFunction(IntPtr x)
		{
			return vtkImplicitVolume.vtkImplicitVolume_EvaluateFunction_01(base.GetCppThis(), x);
		}

		// Token: 0x0601BEE5 RID: 114405
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitVolume_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr n);

		/// <summary>
		/// Evaluate ImplicitVolume gradient.
		/// </summary>
		// Token: 0x0601BEE6 RID: 114406 RVA: 0x002720D8 File Offset: 0x002702D8
		public override void EvaluateGradient(IntPtr x, IntPtr n)
		{
			vtkImplicitVolume.vtkImplicitVolume_EvaluateGradient_02(base.GetCppThis(), x, n);
		}

		// Token: 0x0601BEE7 RID: 114407
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImplicitVolume_GetMTime_03(HandleRef pThis);

		/// <summary>
		/// Returns the mtime also considering the volume.  This also calls Update
		/// on the volume, and it therefore must be called before the function is
		/// evaluated.
		/// </summary>
		// Token: 0x0601BEE8 RID: 114408 RVA: 0x002720EC File Offset: 0x002702EC
		public override ulong GetMTime()
		{
			return vtkImplicitVolume.vtkImplicitVolume_GetMTime_03(base.GetCppThis());
		}

		// Token: 0x0601BEE9 RID: 114409
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitVolume_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BEEA RID: 114410 RVA: 0x0027210C File Offset: 0x0027030C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImplicitVolume.vtkImplicitVolume_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601BEEB RID: 114411
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitVolume_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BEEC RID: 114412 RVA: 0x0027212C File Offset: 0x0027032C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImplicitVolume.vtkImplicitVolume_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601BEED RID: 114413
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitVolume_GetOutGradient_06(HandleRef pThis);

		/// <summary>
		/// Set the function gradient to use for points outside of the dataset.
		/// </summary>
		// Token: 0x0601BEEE RID: 114414 RVA: 0x00272148 File Offset: 0x00270348
		public virtual double[] GetOutGradient()
		{
			IntPtr intPtr = vtkImplicitVolume.vtkImplicitVolume_GetOutGradient_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601BEEF RID: 114415
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitVolume_GetOutGradient_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the function gradient to use for points outside of the dataset.
		/// </summary>
		// Token: 0x0601BEF0 RID: 114416 RVA: 0x00272190 File Offset: 0x00270390
		public virtual void GetOutGradient(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImplicitVolume.vtkImplicitVolume_GetOutGradient_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601BEF1 RID: 114417
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitVolume_GetOutGradient_08(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the function gradient to use for points outside of the dataset.
		/// </summary>
		// Token: 0x0601BEF2 RID: 114418 RVA: 0x002721A2 File Offset: 0x002703A2
		public virtual void GetOutGradient(IntPtr _arg)
		{
			vtkImplicitVolume.vtkImplicitVolume_GetOutGradient_08(base.GetCppThis(), _arg);
		}

		// Token: 0x0601BEF3 RID: 114419
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitVolume_GetOutValue_09(HandleRef pThis);

		/// <summary>
		/// Set the function value to use for points outside of the dataset.
		/// </summary>
		// Token: 0x0601BEF4 RID: 114420 RVA: 0x002721B4 File Offset: 0x002703B4
		public virtual double GetOutValue()
		{
			return vtkImplicitVolume.vtkImplicitVolume_GetOutValue_09(base.GetCppThis());
		}

		// Token: 0x0601BEF5 RID: 114421
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitVolume_GetVolume_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the volume for the implicit function.
		/// </summary>
		// Token: 0x0601BEF6 RID: 114422 RVA: 0x002721D4 File Offset: 0x002703D4
		public virtual vtkImageData GetVolume()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitVolume.vtkImplicitVolume_GetVolume_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x0601BEF7 RID: 114423
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitVolume_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BEF8 RID: 114424 RVA: 0x00272244 File Offset: 0x00270444
		public override int IsA(string type)
		{
			return vtkImplicitVolume.vtkImplicitVolume_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0601BEF9 RID: 114425
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitVolume_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BEFA RID: 114426 RVA: 0x00272264 File Offset: 0x00270464
		public new static int IsTypeOf(string type)
		{
			return vtkImplicitVolume.vtkImplicitVolume_IsTypeOf_12(type);
		}

		// Token: 0x0601BEFB RID: 114427
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitVolume_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BEFC RID: 114428 RVA: 0x00272280 File Offset: 0x00270480
		public new vtkImplicitVolume NewInstance()
		{
			vtkImplicitVolume result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitVolume.vtkImplicitVolume_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitVolume)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BEFD RID: 114429
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitVolume_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BEFE RID: 114430 RVA: 0x002722DC File Offset: 0x002704DC
		public new static vtkImplicitVolume SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitVolume vtkImplicitVolume = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitVolume.vtkImplicitVolume_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitVolume = (vtkImplicitVolume)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitVolume.Register(null);
				}
			}
			return vtkImplicitVolume;
		}

		// Token: 0x0601BEFF RID: 114431
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitVolume_SetOutGradient_16(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the function gradient to use for points outside of the dataset.
		/// </summary>
		// Token: 0x0601BF00 RID: 114432 RVA: 0x0027235B File Offset: 0x0027055B
		public virtual void SetOutGradient(double _arg1, double _arg2, double _arg3)
		{
			vtkImplicitVolume.vtkImplicitVolume_SetOutGradient_16(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601BF01 RID: 114433
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitVolume_SetOutGradient_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the function gradient to use for points outside of the dataset.
		/// </summary>
		// Token: 0x0601BF02 RID: 114434 RVA: 0x0027236D File Offset: 0x0027056D
		public virtual void SetOutGradient(IntPtr _arg)
		{
			vtkImplicitVolume.vtkImplicitVolume_SetOutGradient_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0601BF03 RID: 114435
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitVolume_SetOutValue_18(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the function value to use for points outside of the dataset.
		/// </summary>
		// Token: 0x0601BF04 RID: 114436 RVA: 0x0027237D File Offset: 0x0027057D
		public virtual void SetOutValue(double _arg)
		{
			vtkImplicitVolume.vtkImplicitVolume_SetOutValue_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0601BF05 RID: 114437
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitVolume_SetVolume_19(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the volume for the implicit function.
		/// </summary>
		// Token: 0x0601BF06 RID: 114438 RVA: 0x00272390 File Offset: 0x00270590
		public virtual void SetVolume(vtkImageData arg0)
		{
			vtkImplicitVolume.vtkImplicitVolume_SetVolume_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DCF RID: 7631
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitVolume";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DD0 RID: 7632
		public new static readonly string MRClassNameKey = "class vtkImplicitVolume";
	}
}
