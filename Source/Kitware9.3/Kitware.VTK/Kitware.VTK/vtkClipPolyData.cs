using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkClipPolyData
	/// </summary>
	/// <remarks>
	///    clip polygonal data with user-specified implicit function or input scalar data
	///
	/// vtkClipPolyData is a filter that clips polygonal data using either
	/// any subclass of vtkImplicitFunction, or the input scalar
	/// data. Clipping means that it actually "cuts" through the cells of
	/// the dataset, returning everything inside of the specified implicit
	/// function (or greater than the scalar value) including "pieces" of
	/// a cell. (Compare this with vtkExtractGeometry, which pulls out
	/// entire, uncut cells.) The output of this filter is polygonal data.
	///
	/// To use this filter, you must decide if you will be clipping with an
	/// implicit function, or whether you will be using the input scalar
	/// data.  If you want to clip with an implicit function, you must:
	/// 1) define an implicit function
	/// 2) set it with the SetClipFunction method
	/// 3) apply the GenerateClipScalarsOn method
	/// If a ClipFunction is not specified, or GenerateClipScalars is off
	/// (the default), then the input's scalar data will be used to clip
	/// the polydata.
	///
	/// You can also specify a scalar value, which is used to
	/// decide what is inside and outside of the implicit function. You can
	/// also reverse the sense of what inside/outside is by setting the
	/// InsideOut instance variable. (The cutting algorithm proceeds by
	/// computing an implicit function value or using the input scalar data
	/// for each point in the dataset. This is compared to the scalar value
	/// to determine inside/outside.)
	///
	/// This filter can be configured to compute a second output. The
	/// second output is the polygonal data that is clipped away. Set the
	/// GenerateClippedData boolean on if you wish to access this output data.
	///
	/// @warning
	/// In order to cut all types of cells in polygonal data, vtkClipPolyData
	/// triangulates some cells, and then cuts the resulting simplices
	/// (i.e., points, lines, and triangles). This means that the resulting
	/// output may consist of different cell types than the input data.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitFunction vtkCutter vtkClipVolume vtkExtractGeometry
	/// </seealso>
	// Token: 0x02000949 RID: 2377
	public class vtkClipPolyData : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018A24 RID: 100900 RVA: 0x00226B8D File Offset: 0x00224D8D
		static vtkClipPolyData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClipPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClipPolyData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018A25 RID: 100901 RVA: 0x00226BB5 File Offset: 0x00224DB5
		public vtkClipPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018A26 RID: 100902
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with user-specified implicit function; InsideOut turned off;
		/// value set to 0.0; GenerateClipScalars turned off; GenerateClippedOutput
		/// turned off.
		/// </summary>
		// Token: 0x06018A27 RID: 100903 RVA: 0x00226BC4 File Offset: 0x00224DC4
		public new static vtkClipPolyData New()
		{
			vtkClipPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipPolyData.vtkClipPolyData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with user-specified implicit function; InsideOut turned off;
		/// value set to 0.0; GenerateClipScalars turned off; GenerateClippedOutput
		/// turned off.
		/// </summary>
		// Token: 0x06018A28 RID: 100904 RVA: 0x00226C18 File Offset: 0x00224E18
		public vtkClipPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkClipPolyData.vtkClipPolyData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018A29 RID: 100905 RVA: 0x00226C5C File Offset: 0x00224E5C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018A2A RID: 100906
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipPolyData_CreateDefaultLocator_01(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is specified. The
		/// locator is used to merge coincident points.
		/// </summary>
		// Token: 0x06018A2B RID: 100907 RVA: 0x00226C67 File Offset: 0x00224E67
		public void CreateDefaultLocator()
		{
			vtkClipPolyData.vtkClipPolyData_CreateDefaultLocator_01(base.GetCppThis());
		}

		// Token: 0x06018A2C RID: 100908
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipPolyData_GenerateClipScalarsOff_02(HandleRef pThis);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the
		/// input scalar data. If you enable this flag but do not provide an
		/// implicit function an error will be reported.
		/// GenerateClipScalars is off by default.
		/// </summary>
		// Token: 0x06018A2D RID: 100909 RVA: 0x00226C76 File Offset: 0x00224E76
		public virtual void GenerateClipScalarsOff()
		{
			vtkClipPolyData.vtkClipPolyData_GenerateClipScalarsOff_02(base.GetCppThis());
		}

		// Token: 0x06018A2E RID: 100910
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipPolyData_GenerateClipScalarsOn_03(HandleRef pThis);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the
		/// input scalar data. If you enable this flag but do not provide an
		/// implicit function an error will be reported.
		/// GenerateClipScalars is off by default.
		/// </summary>
		// Token: 0x06018A2F RID: 100911 RVA: 0x00226C85 File Offset: 0x00224E85
		public virtual void GenerateClipScalarsOn()
		{
			vtkClipPolyData.vtkClipPolyData_GenerateClipScalarsOn_03(base.GetCppThis());
		}

		// Token: 0x06018A30 RID: 100912
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipPolyData_GenerateClippedOutputOff_04(HandleRef pThis);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the polygonal data that's been clipped away.
		/// GenerateClippedOutput is off by default.
		/// </summary>
		// Token: 0x06018A31 RID: 100913 RVA: 0x00226C94 File Offset: 0x00224E94
		public virtual void GenerateClippedOutputOff()
		{
			vtkClipPolyData.vtkClipPolyData_GenerateClippedOutputOff_04(base.GetCppThis());
		}

		// Token: 0x06018A32 RID: 100914
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipPolyData_GenerateClippedOutputOn_05(HandleRef pThis);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the polygonal data that's been clipped away.
		/// GenerateClippedOutput is off by default.
		/// </summary>
		// Token: 0x06018A33 RID: 100915 RVA: 0x00226CA3 File Offset: 0x00224EA3
		public virtual void GenerateClippedOutputOn()
		{
			vtkClipPolyData.vtkClipPolyData_GenerateClippedOutputOn_05(base.GetCppThis());
		}

		// Token: 0x06018A34 RID: 100916
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipPolyData_GetClipFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the implicit function with which to perform the
		/// clipping. If you do not define an implicit function, then the input
		/// scalar data will be used for clipping.
		/// </summary>
		// Token: 0x06018A35 RID: 100917 RVA: 0x00226CB4 File Offset: 0x00224EB4
		public virtual vtkImplicitFunction GetClipFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipPolyData.vtkClipPolyData_GetClipFunction_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		// Token: 0x06018A36 RID: 100918
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipPolyData_GetClippedOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the Clipped output.
		/// </summary>
		// Token: 0x06018A37 RID: 100919 RVA: 0x00226D24 File Offset: 0x00224F24
		public vtkPolyData GetClippedOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipPolyData.vtkClipPolyData_GetClippedOutput_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06018A38 RID: 100920
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipPolyData_GetClippedOutputPort_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the output port (a vtkAlgorithmOutput) of the clipped output.
		/// </summary>
		// Token: 0x06018A39 RID: 100921 RVA: 0x00226D94 File Offset: 0x00224F94
		public vtkAlgorithmOutput GetClippedOutputPort()
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipPolyData.vtkClipPolyData_GetClippedOutputPort_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x06018A3A RID: 100922
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipPolyData_GetGenerateClipScalars_09(HandleRef pThis);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the
		/// input scalar data. If you enable this flag but do not provide an
		/// implicit function an error will be reported.
		/// GenerateClipScalars is off by default.
		/// </summary>
		// Token: 0x06018A3B RID: 100923 RVA: 0x00226E04 File Offset: 0x00225004
		public virtual int GetGenerateClipScalars()
		{
			return vtkClipPolyData.vtkClipPolyData_GetGenerateClipScalars_09(base.GetCppThis());
		}

		// Token: 0x06018A3C RID: 100924
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipPolyData_GetGenerateClippedOutput_10(HandleRef pThis);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the polygonal data that's been clipped away.
		/// GenerateClippedOutput is off by default.
		/// </summary>
		// Token: 0x06018A3D RID: 100925 RVA: 0x00226E24 File Offset: 0x00225024
		public virtual int GetGenerateClippedOutput()
		{
			return vtkClipPolyData.vtkClipPolyData_GetGenerateClippedOutput_10(base.GetCppThis());
		}

		// Token: 0x06018A3E RID: 100926
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipPolyData_GetInsideOut_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, a vertex is considered
		/// inside the implicit function if its value is greater than the
		/// Value ivar. When InsideOutside is turned on, a vertex is
		/// considered inside the implicit function if its implicit function
		/// value is less than or equal to the Value ivar.  InsideOut is off
		/// by default.
		/// </summary>
		// Token: 0x06018A3F RID: 100927 RVA: 0x00226E44 File Offset: 0x00225044
		public virtual int GetInsideOut()
		{
			return vtkClipPolyData.vtkClipPolyData_GetInsideOut_11(base.GetCppThis());
		}

		// Token: 0x06018A40 RID: 100928
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipPolyData_GetLocator_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a spatial locator for merging points. By default, an
		/// instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06018A41 RID: 100929 RVA: 0x00226E64 File Offset: 0x00225064
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipPolyData.vtkClipPolyData_GetLocator_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		// Token: 0x06018A42 RID: 100930
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkClipPolyData_GetMTime_13(HandleRef pThis);

		/// <summary>
		/// Return the mtime also considering the locator and clip function.
		/// </summary>
		// Token: 0x06018A43 RID: 100931 RVA: 0x00226ED4 File Offset: 0x002250D4
		public override ulong GetMTime()
		{
			return vtkClipPolyData.vtkClipPolyData_GetMTime_13(base.GetCppThis());
		}

		// Token: 0x06018A44 RID: 100932
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClipPolyData_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018A45 RID: 100933 RVA: 0x00226EF4 File Offset: 0x002250F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkClipPolyData.vtkClipPolyData_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x06018A46 RID: 100934
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClipPolyData_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018A47 RID: 100935 RVA: 0x00226F14 File Offset: 0x00225114
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkClipPolyData.vtkClipPolyData_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x06018A48 RID: 100936
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipPolyData_GetOutputPointsPrecision_16(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings. OutputPointsPrecision is DEFAULT_PRECISION
		/// by default.
		/// </summary>
		// Token: 0x06018A49 RID: 100937 RVA: 0x00226F30 File Offset: 0x00225130
		public virtual int GetOutputPointsPrecision()
		{
			return vtkClipPolyData.vtkClipPolyData_GetOutputPointsPrecision_16(base.GetCppThis());
		}

		// Token: 0x06018A4A RID: 100938
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkClipPolyData_GetValue_17(HandleRef pThis);

		/// <summary>
		/// Set the clipping value of the implicit function (if clipping with
		/// implicit function) or scalar value (if clipping with
		/// scalars). The default value is 0.0.
		/// </summary>
		// Token: 0x06018A4B RID: 100939 RVA: 0x00226F50 File Offset: 0x00225150
		public virtual double GetValue()
		{
			return vtkClipPolyData.vtkClipPolyData_GetValue_17(base.GetCppThis());
		}

		// Token: 0x06018A4C RID: 100940
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipPolyData_InsideOutOff_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, a vertex is considered
		/// inside the implicit function if its value is greater than the
		/// Value ivar. When InsideOutside is turned on, a vertex is
		/// considered inside the implicit function if its implicit function
		/// value is less than or equal to the Value ivar.  InsideOut is off
		/// by default.
		/// </summary>
		// Token: 0x06018A4D RID: 100941 RVA: 0x00226F6F File Offset: 0x0022516F
		public virtual void InsideOutOff()
		{
			vtkClipPolyData.vtkClipPolyData_InsideOutOff_18(base.GetCppThis());
		}

		// Token: 0x06018A4E RID: 100942
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipPolyData_InsideOutOn_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, a vertex is considered
		/// inside the implicit function if its value is greater than the
		/// Value ivar. When InsideOutside is turned on, a vertex is
		/// considered inside the implicit function if its implicit function
		/// value is less than or equal to the Value ivar.  InsideOut is off
		/// by default.
		/// </summary>
		// Token: 0x06018A4F RID: 100943 RVA: 0x00226F7E File Offset: 0x0022517E
		public virtual void InsideOutOn()
		{
			vtkClipPolyData.vtkClipPolyData_InsideOutOn_19(base.GetCppThis());
		}

		// Token: 0x06018A50 RID: 100944
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipPolyData_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018A51 RID: 100945 RVA: 0x00226F90 File Offset: 0x00225190
		public override int IsA(string type)
		{
			return vtkClipPolyData.vtkClipPolyData_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x06018A52 RID: 100946
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipPolyData_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018A53 RID: 100947 RVA: 0x00226FB0 File Offset: 0x002251B0
		public new static int IsTypeOf(string type)
		{
			return vtkClipPolyData.vtkClipPolyData_IsTypeOf_21(type);
		}

		// Token: 0x06018A54 RID: 100948
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipPolyData_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018A55 RID: 100949 RVA: 0x00226FCC File Offset: 0x002251CC
		public new vtkClipPolyData NewInstance()
		{
			vtkClipPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipPolyData.vtkClipPolyData_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018A56 RID: 100950
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipPolyData_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018A57 RID: 100951 RVA: 0x00227028 File Offset: 0x00225228
		public new static vtkClipPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkClipPolyData vtkClipPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipPolyData.vtkClipPolyData_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClipPolyData = (vtkClipPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClipPolyData.Register(null);
				}
			}
			return vtkClipPolyData;
		}

		// Token: 0x06018A58 RID: 100952
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipPolyData_SetClipFunction_25(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the implicit function with which to perform the
		/// clipping. If you do not define an implicit function, then the input
		/// scalar data will be used for clipping.
		/// </summary>
		// Token: 0x06018A59 RID: 100953 RVA: 0x002270A8 File Offset: 0x002252A8
		public virtual void SetClipFunction(vtkImplicitFunction arg0)
		{
			vtkClipPolyData.vtkClipPolyData_SetClipFunction_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06018A5A RID: 100954
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipPolyData_SetGenerateClipScalars_26(HandleRef pThis, int _arg);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the
		/// input scalar data. If you enable this flag but do not provide an
		/// implicit function an error will be reported.
		/// GenerateClipScalars is off by default.
		/// </summary>
		// Token: 0x06018A5B RID: 100955 RVA: 0x002270D7 File Offset: 0x002252D7
		public virtual void SetGenerateClipScalars(int _arg)
		{
			vtkClipPolyData.vtkClipPolyData_SetGenerateClipScalars_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06018A5C RID: 100956
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipPolyData_SetGenerateClippedOutput_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the polygonal data that's been clipped away.
		/// GenerateClippedOutput is off by default.
		/// </summary>
		// Token: 0x06018A5D RID: 100957 RVA: 0x002270E7 File Offset: 0x002252E7
		public virtual void SetGenerateClippedOutput(int _arg)
		{
			vtkClipPolyData.vtkClipPolyData_SetGenerateClippedOutput_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06018A5E RID: 100958
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipPolyData_SetInsideOut_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, a vertex is considered
		/// inside the implicit function if its value is greater than the
		/// Value ivar. When InsideOutside is turned on, a vertex is
		/// considered inside the implicit function if its implicit function
		/// value is less than or equal to the Value ivar.  InsideOut is off
		/// by default.
		/// </summary>
		// Token: 0x06018A5F RID: 100959 RVA: 0x002270F7 File Offset: 0x002252F7
		public virtual void SetInsideOut(int _arg)
		{
			vtkClipPolyData.vtkClipPolyData_SetInsideOut_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06018A60 RID: 100960
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipPolyData_SetLocator_29(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a spatial locator for merging points. By default, an
		/// instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06018A61 RID: 100961 RVA: 0x00227108 File Offset: 0x00225308
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkClipPolyData.vtkClipPolyData_SetLocator_29(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x06018A62 RID: 100962
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipPolyData_SetOutputPointsPrecision_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings. OutputPointsPrecision is DEFAULT_PRECISION
		/// by default.
		/// </summary>
		// Token: 0x06018A63 RID: 100963 RVA: 0x00227137 File Offset: 0x00225337
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkClipPolyData.vtkClipPolyData_SetOutputPointsPrecision_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06018A64 RID: 100964
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipPolyData_SetValue_31(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the clipping value of the implicit function (if clipping with
		/// implicit function) or scalar value (if clipping with
		/// scalars). The default value is 0.0.
		/// </summary>
		// Token: 0x06018A65 RID: 100965 RVA: 0x00227147 File Offset: 0x00225347
		public virtual void SetValue(double _arg)
		{
			vtkClipPolyData.vtkClipPolyData_SetValue_31(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B46 RID: 6982
		public new const string MRFullTypeName = "Kitware.VTK.vtkClipPolyData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B47 RID: 6983
		public new static readonly string MRClassNameKey = "class vtkClipPolyData";
	}
}
