using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGridTransform
	/// </summary>
	/// <remarks>
	///    a nonlinear warp transformation
	///
	/// vtkGridTransform describes a nonlinear warp transformation as a set
	/// of displacement vectors sampled along a uniform 3D grid.
	/// @warning
	/// The inverse grid transform is calculated using an iterative method,
	/// and is several times more expensive than the forward transform.
	/// </remarks>
	/// <seealso>
	///
	/// vtkThinPlateSplineTransform vtkGeneralTransform vtkTransformToGrid
	/// </seealso>
	// Token: 0x0200060D RID: 1549
	public class vtkGridTransform : vtkWarpTransform
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010CFA RID: 68858 RVA: 0x001771B3 File Offset: 0x001753B3
		static vtkGridTransform()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGridTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGridTransform"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010CFB RID: 68859 RVA: 0x001771DB File Offset: 0x001753DB
		public vtkGridTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010CFC RID: 68860
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGridTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010CFD RID: 68861 RVA: 0x001771EC File Offset: 0x001753EC
		public new static vtkGridTransform New()
		{
			vtkGridTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGridTransform.vtkGridTransform_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGridTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010CFE RID: 68862 RVA: 0x00177240 File Offset: 0x00175440
		public vtkGridTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGridTransform.vtkGridTransform_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010CFF RID: 68863 RVA: 0x00177284 File Offset: 0x00175484
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010D00 RID: 68864
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGridTransform_GetDisplacementGrid_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the grid transform (the grid transform must have three
		/// components for displacement in x, y, and z respectively).
		/// The vtkGridTransform class will never modify the data.
		/// Note that SetDisplacementGridData() does not setup a pipeline
		/// connection whereas SetDisplacementGridConnection does.
		/// </summary>
		// Token: 0x06010D01 RID: 68865 RVA: 0x00177290 File Offset: 0x00175490
		public virtual vtkImageData GetDisplacementGrid()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGridTransform.vtkGridTransform_GetDisplacementGrid_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06010D02 RID: 68866
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGridTransform_GetDisplacementScale_02(HandleRef pThis);

		/// <summary>
		/// Set scale factor to be applied to the displacements.
		/// This is used primarily for grids which contain integer
		/// data types.  Default: 1
		/// </summary>
		// Token: 0x06010D03 RID: 68867 RVA: 0x00177300 File Offset: 0x00175500
		public virtual double GetDisplacementScale()
		{
			return vtkGridTransform.vtkGridTransform_GetDisplacementScale_02(base.GetCppThis());
		}

		// Token: 0x06010D04 RID: 68868
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGridTransform_GetDisplacementShift_03(HandleRef pThis);

		/// <summary>
		/// Set a shift to be applied to the displacements.  The shift
		/// is applied after the scale, i.e. x = scale*y + shift.
		/// Default: 0
		/// </summary>
		// Token: 0x06010D05 RID: 68869 RVA: 0x00177320 File Offset: 0x00175520
		public virtual double GetDisplacementShift()
		{
			return vtkGridTransform.vtkGridTransform_GetDisplacementShift_03(base.GetCppThis());
		}

		// Token: 0x06010D06 RID: 68870
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGridTransform_GetInterpolationMode_04(HandleRef pThis);

		/// <summary>
		/// Set interpolation mode for sampling the grid.  Higher-order
		/// interpolation allows you to use a sparser grid.
		/// Default: Linear.
		/// </summary>
		// Token: 0x06010D07 RID: 68871 RVA: 0x00177340 File Offset: 0x00175540
		public virtual int GetInterpolationMode()
		{
			return vtkGridTransform.vtkGridTransform_GetInterpolationMode_04(base.GetCppThis());
		}

		// Token: 0x06010D08 RID: 68872
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGridTransform_GetInterpolationModeAsString_05(HandleRef pThis);

		/// <summary>
		/// Set interpolation mode for sampling the grid.  Higher-order
		/// interpolation allows you to use a sparser grid.
		/// Default: Linear.
		/// </summary>
		// Token: 0x06010D09 RID: 68873 RVA: 0x00177360 File Offset: 0x00175560
		public string GetInterpolationModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkGridTransform.vtkGridTransform_GetInterpolationModeAsString_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06010D0A RID: 68874
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkGridTransform_GetMTime_06(HandleRef pThis);

		/// <summary>
		/// Get the MTime.
		/// </summary>
		// Token: 0x06010D0B RID: 68875 RVA: 0x0017739C File Offset: 0x0017559C
		public override ulong GetMTime()
		{
			return vtkGridTransform.vtkGridTransform_GetMTime_06(base.GetCppThis());
		}

		// Token: 0x06010D0C RID: 68876
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGridTransform_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010D0D RID: 68877 RVA: 0x001773BC File Offset: 0x001755BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGridTransform.vtkGridTransform_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06010D0E RID: 68878
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGridTransform_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010D0F RID: 68879 RVA: 0x001773DC File Offset: 0x001755DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGridTransform.vtkGridTransform_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06010D10 RID: 68880
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGridTransform_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010D11 RID: 68881 RVA: 0x001773F8 File Offset: 0x001755F8
		public override int IsA(string type)
		{
			return vtkGridTransform.vtkGridTransform_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06010D12 RID: 68882
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGridTransform_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010D13 RID: 68883 RVA: 0x00177418 File Offset: 0x00175618
		public new static int IsTypeOf(string type)
		{
			return vtkGridTransform.vtkGridTransform_IsTypeOf_10(type);
		}

		// Token: 0x06010D14 RID: 68884
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGridTransform_MakeTransform_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Make another transform of the same type.
		/// </summary>
		// Token: 0x06010D15 RID: 68885 RVA: 0x00177434 File Offset: 0x00175634
		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGridTransform.vtkGridTransform_MakeTransform_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010D16 RID: 68886
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGridTransform_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010D17 RID: 68887 RVA: 0x00177490 File Offset: 0x00175690
		public new vtkGridTransform NewInstance()
		{
			vtkGridTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGridTransform.vtkGridTransform_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGridTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010D18 RID: 68888
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGridTransform_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010D19 RID: 68889 RVA: 0x001774EC File Offset: 0x001756EC
		public new static vtkGridTransform SafeDownCast(vtkObjectBase o)
		{
			vtkGridTransform vtkGridTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGridTransform.vtkGridTransform_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGridTransform = (vtkGridTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGridTransform.Register(null);
				}
			}
			return vtkGridTransform;
		}

		// Token: 0x06010D1A RID: 68890
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridTransform_SetDisplacementGridConnection_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the grid transform (the grid transform must have three
		/// components for displacement in x, y, and z respectively).
		/// The vtkGridTransform class will never modify the data.
		/// Note that SetDisplacementGridData() does not setup a pipeline
		/// connection whereas SetDisplacementGridConnection does.
		/// </summary>
		// Token: 0x06010D1B RID: 68891 RVA: 0x0017756C File Offset: 0x0017576C
		public virtual void SetDisplacementGridConnection(vtkAlgorithmOutput arg0)
		{
			vtkGridTransform.vtkGridTransform_SetDisplacementGridConnection_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010D1C RID: 68892
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridTransform_SetDisplacementGridData_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the grid transform (the grid transform must have three
		/// components for displacement in x, y, and z respectively).
		/// The vtkGridTransform class will never modify the data.
		/// Note that SetDisplacementGridData() does not setup a pipeline
		/// connection whereas SetDisplacementGridConnection does.
		/// </summary>
		// Token: 0x06010D1D RID: 68893 RVA: 0x0017759C File Offset: 0x0017579C
		public virtual void SetDisplacementGridData(vtkImageData arg0)
		{
			vtkGridTransform.vtkGridTransform_SetDisplacementGridData_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010D1E RID: 68894
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridTransform_SetDisplacementScale_17(HandleRef pThis, double _arg);

		/// <summary>
		/// Set scale factor to be applied to the displacements.
		/// This is used primarily for grids which contain integer
		/// data types.  Default: 1
		/// </summary>
		// Token: 0x06010D1F RID: 68895 RVA: 0x001775CB File Offset: 0x001757CB
		public virtual void SetDisplacementScale(double _arg)
		{
			vtkGridTransform.vtkGridTransform_SetDisplacementScale_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06010D20 RID: 68896
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridTransform_SetDisplacementShift_18(HandleRef pThis, double _arg);

		/// <summary>
		/// Set a shift to be applied to the displacements.  The shift
		/// is applied after the scale, i.e. x = scale*y + shift.
		/// Default: 0
		/// </summary>
		// Token: 0x06010D21 RID: 68897 RVA: 0x001775DB File Offset: 0x001757DB
		public virtual void SetDisplacementShift(double _arg)
		{
			vtkGridTransform.vtkGridTransform_SetDisplacementShift_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06010D22 RID: 68898
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridTransform_SetInterpolationMode_19(HandleRef pThis, int mode);

		/// <summary>
		/// Set interpolation mode for sampling the grid.  Higher-order
		/// interpolation allows you to use a sparser grid.
		/// Default: Linear.
		/// </summary>
		// Token: 0x06010D23 RID: 68899 RVA: 0x001775EB File Offset: 0x001757EB
		public void SetInterpolationMode(int mode)
		{
			vtkGridTransform.vtkGridTransform_SetInterpolationMode_19(base.GetCppThis(), mode);
		}

		// Token: 0x06010D24 RID: 68900
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridTransform_SetInterpolationModeToCubic_20(HandleRef pThis);

		/// <summary>
		/// Set interpolation mode for sampling the grid.  Higher-order
		/// interpolation allows you to use a sparser grid.
		/// Default: Linear.
		/// </summary>
		// Token: 0x06010D25 RID: 68901 RVA: 0x001775FB File Offset: 0x001757FB
		public void SetInterpolationModeToCubic()
		{
			vtkGridTransform.vtkGridTransform_SetInterpolationModeToCubic_20(base.GetCppThis());
		}

		// Token: 0x06010D26 RID: 68902
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridTransform_SetInterpolationModeToLinear_21(HandleRef pThis);

		/// <summary>
		/// Set interpolation mode for sampling the grid.  Higher-order
		/// interpolation allows you to use a sparser grid.
		/// Default: Linear.
		/// </summary>
		// Token: 0x06010D27 RID: 68903 RVA: 0x0017760A File Offset: 0x0017580A
		public void SetInterpolationModeToLinear()
		{
			vtkGridTransform.vtkGridTransform_SetInterpolationModeToLinear_21(base.GetCppThis());
		}

		// Token: 0x06010D28 RID: 68904
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGridTransform_SetInterpolationModeToNearestNeighbor_22(HandleRef pThis);

		/// <summary>
		/// Set interpolation mode for sampling the grid.  Higher-order
		/// interpolation allows you to use a sparser grid.
		/// Default: Linear.
		/// </summary>
		// Token: 0x06010D29 RID: 68905 RVA: 0x00177619 File Offset: 0x00175819
		public void SetInterpolationModeToNearestNeighbor()
		{
			vtkGridTransform.vtkGridTransform_SetInterpolationModeToNearestNeighbor_22(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001374 RID: 4980
		public new const string MRFullTypeName = "Kitware.VTK.vtkGridTransform";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001375 RID: 4981
		public new static readonly string MRClassNameKey = "class vtkGridTransform";
	}
}
