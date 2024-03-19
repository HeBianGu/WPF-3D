using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBoundedPointSource
	/// </summary>
	/// <remarks>
	///    create a random cloud of points within a
	/// specified bounding box
	///
	///
	/// vtkBoundedPointSource is a source object that creates a user-specified
	/// number of points within a specified bounding box. The points are scattered
	/// randomly throughout the box. Optionally, the user can produce a
	/// vtkPolyVertex cell as well as random scalar values within a specified
	/// range. The class is typically used for debugging and testing, as well as
	/// seeding streamlines.
	/// </remarks>
	// Token: 0x02000433 RID: 1075
	public class vtkBoundedPointSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C906 RID: 51462 RVA: 0x00118083 File Offset: 0x00116283
		static vtkBoundedPointSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBoundedPointSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoundedPointSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C907 RID: 51463 RVA: 0x001180AB File Offset: 0x001162AB
		public vtkBoundedPointSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C908 RID: 51464
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoundedPointSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information and printing.
		/// </summary>
		// Token: 0x0600C909 RID: 51465 RVA: 0x001180BC File Offset: 0x001162BC
		public new static vtkBoundedPointSource New()
		{
			vtkBoundedPointSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoundedPointSource.vtkBoundedPointSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoundedPointSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information and printing.
		/// </summary>
		// Token: 0x0600C90A RID: 51466 RVA: 0x00118110 File Offset: 0x00116310
		public vtkBoundedPointSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBoundedPointSource.vtkBoundedPointSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C90B RID: 51467 RVA: 0x00118154 File Offset: 0x00116354
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C90C RID: 51468
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoundedPointSource_GetBounds_01(HandleRef pThis);

		/// <summary>
		/// Set the bounding box for the point distribution. By default the bounds is
		/// (-1,1,-1,1,-1,1).
		/// </summary>
		// Token: 0x0600C90D RID: 51469 RVA: 0x00118160 File Offset: 0x00116360
		public virtual double[] GetBounds()
		{
			IntPtr intPtr = vtkBoundedPointSource.vtkBoundedPointSource_GetBounds_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600C90E RID: 51470
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPointSource_GetBounds_02(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the bounding box for the point distribution. By default the bounds is
		/// (-1,1,-1,1,-1,1).
		/// </summary>
		// Token: 0x0600C90F RID: 51471 RVA: 0x001181A8 File Offset: 0x001163A8
		public virtual void GetBounds(IntPtr data)
		{
			vtkBoundedPointSource.vtkBoundedPointSource_GetBounds_02(base.GetCppThis(), data);
		}

		// Token: 0x0600C910 RID: 51472
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBoundedPointSource_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information and printing.
		/// </summary>
		// Token: 0x0600C911 RID: 51473 RVA: 0x001181B8 File Offset: 0x001163B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBoundedPointSource.vtkBoundedPointSource_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600C912 RID: 51474
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBoundedPointSource_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information and printing.
		/// </summary>
		// Token: 0x0600C913 RID: 51475 RVA: 0x001181D8 File Offset: 0x001163D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBoundedPointSource.vtkBoundedPointSource_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600C914 RID: 51476
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBoundedPointSource_GetNumberOfPoints_05(HandleRef pThis);

		/// <summary>
		/// Set the number of points to generate.
		/// </summary>
		// Token: 0x0600C915 RID: 51477 RVA: 0x001181F4 File Offset: 0x001163F4
		public virtual long GetNumberOfPoints()
		{
			return vtkBoundedPointSource.vtkBoundedPointSource_GetNumberOfPoints_05(base.GetCppThis());
		}

		// Token: 0x0600C916 RID: 51478
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBoundedPointSource_GetNumberOfPointsMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Set the number of points to generate.
		/// </summary>
		// Token: 0x0600C917 RID: 51479 RVA: 0x00118214 File Offset: 0x00116414
		public virtual long GetNumberOfPointsMaxValue()
		{
			return vtkBoundedPointSource.vtkBoundedPointSource_GetNumberOfPointsMaxValue_06(base.GetCppThis());
		}

		// Token: 0x0600C918 RID: 51480
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBoundedPointSource_GetNumberOfPointsMinValue_07(HandleRef pThis);

		/// <summary>
		/// Set the number of points to generate.
		/// </summary>
		// Token: 0x0600C919 RID: 51481 RVA: 0x00118234 File Offset: 0x00116434
		public virtual long GetNumberOfPointsMinValue()
		{
			return vtkBoundedPointSource.vtkBoundedPointSource_GetNumberOfPointsMinValue_07(base.GetCppThis());
		}

		// Token: 0x0600C91A RID: 51482
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoundedPointSource_GetOutputPointsPrecision_08(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x0600C91B RID: 51483 RVA: 0x00118254 File Offset: 0x00116454
		public virtual int GetOutputPointsPrecision()
		{
			return vtkBoundedPointSource.vtkBoundedPointSource_GetOutputPointsPrecision_08(base.GetCppThis());
		}

		// Token: 0x0600C91C RID: 51484
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBoundedPointSource_GetProduceCellOutput_09(HandleRef pThis);

		/// <summary>
		/// Indicate whether to produce a vtkPolyVertex cell to go along with the
		/// output vtkPoints generated. By default a cell is NOT produced. Some filters
		/// do not need the vtkPolyVertex which just consumes a lot of memory.
		/// </summary>
		// Token: 0x0600C91D RID: 51485 RVA: 0x00118274 File Offset: 0x00116474
		public virtual bool GetProduceCellOutput()
		{
			return vtkBoundedPointSource.vtkBoundedPointSource_GetProduceCellOutput_09(base.GetCppThis()) != 0;
		}

		// Token: 0x0600C91E RID: 51486
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBoundedPointSource_GetProduceRandomScalars_10(HandleRef pThis);

		/// <summary>
		/// Indicate whether to produce random point scalars in the output. By default
		/// this is off.
		/// </summary>
		// Token: 0x0600C91F RID: 51487 RVA: 0x0011829C File Offset: 0x0011649C
		public virtual bool GetProduceRandomScalars()
		{
			return vtkBoundedPointSource.vtkBoundedPointSource_GetProduceRandomScalars_10(base.GetCppThis()) != 0;
		}

		// Token: 0x0600C920 RID: 51488
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoundedPointSource_GetScalarRange_11(HandleRef pThis);

		/// <summary>
		/// Set the range in which the random scalars should be produced. By default the
		/// scalar range is (0,1).
		/// </summary>
		// Token: 0x0600C921 RID: 51489 RVA: 0x001182C4 File Offset: 0x001164C4
		public virtual double[] GetScalarRange()
		{
			IntPtr intPtr = vtkBoundedPointSource.vtkBoundedPointSource_GetScalarRange_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600C922 RID: 51490
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPointSource_GetScalarRange_12(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the range in which the random scalars should be produced. By default the
		/// scalar range is (0,1).
		/// </summary>
		// Token: 0x0600C923 RID: 51491 RVA: 0x0011830C File Offset: 0x0011650C
		public virtual void GetScalarRange(IntPtr data)
		{
			vtkBoundedPointSource.vtkBoundedPointSource_GetScalarRange_12(base.GetCppThis(), data);
		}

		// Token: 0x0600C924 RID: 51492
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoundedPointSource_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information and printing.
		/// </summary>
		// Token: 0x0600C925 RID: 51493 RVA: 0x0011831C File Offset: 0x0011651C
		public override int IsA(string type)
		{
			return vtkBoundedPointSource.vtkBoundedPointSource_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0600C926 RID: 51494
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoundedPointSource_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information and printing.
		/// </summary>
		// Token: 0x0600C927 RID: 51495 RVA: 0x0011833C File Offset: 0x0011653C
		public new static int IsTypeOf(string type)
		{
			return vtkBoundedPointSource.vtkBoundedPointSource_IsTypeOf_14(type);
		}

		// Token: 0x0600C928 RID: 51496
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoundedPointSource_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information and printing.
		/// </summary>
		// Token: 0x0600C929 RID: 51497 RVA: 0x00118358 File Offset: 0x00116558
		public new vtkBoundedPointSource NewInstance()
		{
			vtkBoundedPointSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoundedPointSource.vtkBoundedPointSource_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoundedPointSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C92A RID: 51498
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPointSource_ProduceCellOutputOff_17(HandleRef pThis);

		/// <summary>
		/// Indicate whether to produce a vtkPolyVertex cell to go along with the
		/// output vtkPoints generated. By default a cell is NOT produced. Some filters
		/// do not need the vtkPolyVertex which just consumes a lot of memory.
		/// </summary>
		// Token: 0x0600C92B RID: 51499 RVA: 0x001183B2 File Offset: 0x001165B2
		public virtual void ProduceCellOutputOff()
		{
			vtkBoundedPointSource.vtkBoundedPointSource_ProduceCellOutputOff_17(base.GetCppThis());
		}

		// Token: 0x0600C92C RID: 51500
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPointSource_ProduceCellOutputOn_18(HandleRef pThis);

		/// <summary>
		/// Indicate whether to produce a vtkPolyVertex cell to go along with the
		/// output vtkPoints generated. By default a cell is NOT produced. Some filters
		/// do not need the vtkPolyVertex which just consumes a lot of memory.
		/// </summary>
		// Token: 0x0600C92D RID: 51501 RVA: 0x001183C1 File Offset: 0x001165C1
		public virtual void ProduceCellOutputOn()
		{
			vtkBoundedPointSource.vtkBoundedPointSource_ProduceCellOutputOn_18(base.GetCppThis());
		}

		// Token: 0x0600C92E RID: 51502
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPointSource_ProduceRandomScalarsOff_19(HandleRef pThis);

		/// <summary>
		/// Indicate whether to produce random point scalars in the output. By default
		/// this is off.
		/// </summary>
		// Token: 0x0600C92F RID: 51503 RVA: 0x001183D0 File Offset: 0x001165D0
		public virtual void ProduceRandomScalarsOff()
		{
			vtkBoundedPointSource.vtkBoundedPointSource_ProduceRandomScalarsOff_19(base.GetCppThis());
		}

		// Token: 0x0600C930 RID: 51504
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPointSource_ProduceRandomScalarsOn_20(HandleRef pThis);

		/// <summary>
		/// Indicate whether to produce random point scalars in the output. By default
		/// this is off.
		/// </summary>
		// Token: 0x0600C931 RID: 51505 RVA: 0x001183DF File Offset: 0x001165DF
		public virtual void ProduceRandomScalarsOn()
		{
			vtkBoundedPointSource.vtkBoundedPointSource_ProduceRandomScalarsOn_20(base.GetCppThis());
		}

		// Token: 0x0600C932 RID: 51506
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoundedPointSource_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information and printing.
		/// </summary>
		// Token: 0x0600C933 RID: 51507 RVA: 0x001183F0 File Offset: 0x001165F0
		public new static vtkBoundedPointSource SafeDownCast(vtkObjectBase o)
		{
			vtkBoundedPointSource vtkBoundedPointSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoundedPointSource.vtkBoundedPointSource_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBoundedPointSource = (vtkBoundedPointSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBoundedPointSource.Register(null);
				}
			}
			return vtkBoundedPointSource;
		}

		// Token: 0x0600C934 RID: 51508
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPointSource_SetBounds_22(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Set the bounding box for the point distribution. By default the bounds is
		/// (-1,1,-1,1,-1,1).
		/// </summary>
		// Token: 0x0600C935 RID: 51509 RVA: 0x0011846F File Offset: 0x0011666F
		public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkBoundedPointSource.vtkBoundedPointSource_SetBounds_22(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0600C936 RID: 51510
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPointSource_SetBounds_23(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the bounding box for the point distribution. By default the bounds is
		/// (-1,1,-1,1,-1,1).
		/// </summary>
		// Token: 0x0600C937 RID: 51511 RVA: 0x00118487 File Offset: 0x00116687
		public virtual void SetBounds(IntPtr _arg)
		{
			vtkBoundedPointSource.vtkBoundedPointSource_SetBounds_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C938 RID: 51512
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPointSource_SetNumberOfPoints_24(HandleRef pThis, long _arg);

		/// <summary>
		/// Set the number of points to generate.
		/// </summary>
		// Token: 0x0600C939 RID: 51513 RVA: 0x00118497 File Offset: 0x00116697
		public virtual void SetNumberOfPoints(long _arg)
		{
			vtkBoundedPointSource.vtkBoundedPointSource_SetNumberOfPoints_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C93A RID: 51514
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPointSource_SetOutputPointsPrecision_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x0600C93B RID: 51515 RVA: 0x001184A7 File Offset: 0x001166A7
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkBoundedPointSource.vtkBoundedPointSource_SetOutputPointsPrecision_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C93C RID: 51516
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPointSource_SetProduceCellOutput_26(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to produce a vtkPolyVertex cell to go along with the
		/// output vtkPoints generated. By default a cell is NOT produced. Some filters
		/// do not need the vtkPolyVertex which just consumes a lot of memory.
		/// </summary>
		// Token: 0x0600C93D RID: 51517 RVA: 0x001184B7 File Offset: 0x001166B7
		public virtual void SetProduceCellOutput(bool _arg)
		{
			vtkBoundedPointSource.vtkBoundedPointSource_SetProduceCellOutput_26(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600C93E RID: 51518
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPointSource_SetProduceRandomScalars_27(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to produce random point scalars in the output. By default
		/// this is off.
		/// </summary>
		// Token: 0x0600C93F RID: 51519 RVA: 0x001184CF File Offset: 0x001166CF
		public virtual void SetProduceRandomScalars(bool _arg)
		{
			vtkBoundedPointSource.vtkBoundedPointSource_SetProduceRandomScalars_27(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600C940 RID: 51520
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPointSource_SetScalarRange_28(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set the range in which the random scalars should be produced. By default the
		/// scalar range is (0,1).
		/// </summary>
		// Token: 0x0600C941 RID: 51521 RVA: 0x001184E7 File Offset: 0x001166E7
		public virtual void SetScalarRange(double _arg1, double _arg2)
		{
			vtkBoundedPointSource.vtkBoundedPointSource_SetScalarRange_28(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600C942 RID: 51522
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPointSource_SetScalarRange_29(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the range in which the random scalars should be produced. By default the
		/// scalar range is (0,1).
		/// </summary>
		// Token: 0x0600C943 RID: 51523 RVA: 0x001184F8 File Offset: 0x001166F8
		public void SetScalarRange(IntPtr _arg)
		{
			vtkBoundedPointSource.vtkBoundedPointSource_SetScalarRange_29(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EEF RID: 3823
		public new const string MRFullTypeName = "Kitware.VTK.vtkBoundedPointSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EF0 RID: 3824
		public new static readonly string MRClassNameKey = "class vtkBoundedPointSource";
	}
}
