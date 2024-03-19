using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericClip
	/// </summary>
	/// <remarks>
	///    clip any dataset with an implicit function or scalar data
	///
	/// vtkGenericClip is a filter that any type of dataset using either
	/// any subclass of vtkImplicitFunction, or the input scalar
	/// data. Clipping means that it actually "cuts" through the cells of
	/// the dataset, returning everything inside of the specified implicit
	/// function (or greater than the scalar value) including "pieces" of
	/// a cell. (Compare this with vtkExtractGeometry, which pulls out
	/// entire, uncut cells.) The output of this filter is an unstructured
	/// grid.
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
	/// You can also specify a scalar value, which is used to decide what is
	/// inside and outside of the implicit function. You can also reverse the
	/// sense of what inside/outside is by setting the InsideOut instance
	/// variable. (The clipping algorithm proceeds by computing an implicit
	/// function value or using the input scalar data for each point in the
	/// dataset. This is compared to the scalar value to determine
	/// inside/outside.)
	///
	/// This filter can be configured to compute a second output. The
	/// second output is the part of the cell that is clipped away. Set the
	/// GenerateClippedData boolean on if you wish to access this output data.
	///
	/// This filter has been implemented to operate on generic datasets, rather
	/// than the typical vtkDataSet (and subclasses). vtkGenericDataSet is a more
	/// complex cousin of vtkDataSet, typically consisting of nonlinear,
	/// higher-order cells. To process this type of data, generic cells are
	/// automatically tessellated into linear cells prior to isocontouring.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkClipDataSet vtkClipPolyData vtkClipVolume vtkImplicitFunction
	/// vtkGenericDataSet
	/// </seealso>
	// Token: 0x02000498 RID: 1176
	public class vtkGenericClip : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D848 RID: 55368 RVA: 0x0012C9CF File Offset: 0x0012ABCF
		static vtkGenericClip()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericClip.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericClip"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D849 RID: 55369 RVA: 0x0012C9F7 File Offset: 0x0012ABF7
		public vtkGenericClip(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D84A RID: 55370
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericClip_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with user-specified implicit function; InsideOut turned off;
		/// value set to 0.0; and generate clip scalars turned off.
		/// </summary>
		// Token: 0x0600D84B RID: 55371 RVA: 0x0012CA08 File Offset: 0x0012AC08
		public new static vtkGenericClip New()
		{
			vtkGenericClip result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericClip.vtkGenericClip_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericClip)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with user-specified implicit function; InsideOut turned off;
		/// value set to 0.0; and generate clip scalars turned off.
		/// </summary>
		// Token: 0x0600D84C RID: 55372 RVA: 0x0012CA5C File Offset: 0x0012AC5C
		public vtkGenericClip() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenericClip.vtkGenericClip_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D84D RID: 55373 RVA: 0x0012CAA0 File Offset: 0x0012ACA0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D84E RID: 55374
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericClip_CreateDefaultLocator_01(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is specified. The
		/// locator is used to merge coincident points.
		/// </summary>
		// Token: 0x0600D84F RID: 55375 RVA: 0x0012CAAB File Offset: 0x0012ACAB
		public void CreateDefaultLocator()
		{
			vtkGenericClip.vtkGenericClip_CreateDefaultLocator_01(base.GetCppThis());
		}

		// Token: 0x0600D850 RID: 55376
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericClip_GenerateClipScalarsOff_02(HandleRef pThis);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the
		/// input scalar data. If you enable this flag but do not provide an
		/// implicit function an error will be reported.
		/// </summary>
		// Token: 0x0600D851 RID: 55377 RVA: 0x0012CABA File Offset: 0x0012ACBA
		public virtual void GenerateClipScalarsOff()
		{
			vtkGenericClip.vtkGenericClip_GenerateClipScalarsOff_02(base.GetCppThis());
		}

		// Token: 0x0600D852 RID: 55378
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericClip_GenerateClipScalarsOn_03(HandleRef pThis);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the
		/// input scalar data. If you enable this flag but do not provide an
		/// implicit function an error will be reported.
		/// </summary>
		// Token: 0x0600D853 RID: 55379 RVA: 0x0012CAC9 File Offset: 0x0012ACC9
		public virtual void GenerateClipScalarsOn()
		{
			vtkGenericClip.vtkGenericClip_GenerateClipScalarsOn_03(base.GetCppThis());
		}

		// Token: 0x0600D854 RID: 55380
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericClip_GenerateClippedOutputOff_04(HandleRef pThis);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the polygonal data that's been clipped away.
		/// </summary>
		// Token: 0x0600D855 RID: 55381 RVA: 0x0012CAD8 File Offset: 0x0012ACD8
		public virtual void GenerateClippedOutputOff()
		{
			vtkGenericClip.vtkGenericClip_GenerateClippedOutputOff_04(base.GetCppThis());
		}

		// Token: 0x0600D856 RID: 55382
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericClip_GenerateClippedOutputOn_05(HandleRef pThis);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the polygonal data that's been clipped away.
		/// </summary>
		// Token: 0x0600D857 RID: 55383 RVA: 0x0012CAE7 File Offset: 0x0012ACE7
		public virtual void GenerateClippedOutputOn()
		{
			vtkGenericClip.vtkGenericClip_GenerateClippedOutputOn_05(base.GetCppThis());
		}

		// Token: 0x0600D858 RID: 55384
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericClip_GetClipFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the implicit function with which to perform the
		/// clipping. If you do not define an implicit function,
		/// then the selected input scalar data will be used for clipping.
		/// </summary>
		// Token: 0x0600D859 RID: 55385 RVA: 0x0012CAF8 File Offset: 0x0012ACF8
		public virtual vtkImplicitFunction GetClipFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericClip.vtkGenericClip_GetClipFunction_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600D85A RID: 55386
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericClip_GetClippedOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the Clipped output.
		/// </summary>
		// Token: 0x0600D85B RID: 55387 RVA: 0x0012CB68 File Offset: 0x0012AD68
		public vtkUnstructuredGrid GetClippedOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericClip.vtkGenericClip_GetClippedOutput_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		// Token: 0x0600D85C RID: 55388
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericClip_GetGenerateClipScalars_08(HandleRef pThis);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the
		/// input scalar data. If you enable this flag but do not provide an
		/// implicit function an error will be reported.
		/// </summary>
		// Token: 0x0600D85D RID: 55389 RVA: 0x0012CBD8 File Offset: 0x0012ADD8
		public virtual int GetGenerateClipScalars()
		{
			return vtkGenericClip.vtkGenericClip_GetGenerateClipScalars_08(base.GetCppThis());
		}

		// Token: 0x0600D85E RID: 55390
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericClip_GetGenerateClippedOutput_09(HandleRef pThis);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the polygonal data that's been clipped away.
		/// </summary>
		// Token: 0x0600D85F RID: 55391 RVA: 0x0012CBF8 File Offset: 0x0012ADF8
		public virtual int GetGenerateClippedOutput()
		{
			return vtkGenericClip.vtkGenericClip_GetGenerateClippedOutput_09(base.GetCppThis());
		}

		// Token: 0x0600D860 RID: 55392
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericClip_GetInputScalarsSelection_10(HandleRef pThis);

		/// <summary>
		/// If you want to clip by an arbitrary array, then set its name here.
		/// By default this in nullptr and the filter will use the active scalar array.
		/// </summary>
		// Token: 0x0600D861 RID: 55393 RVA: 0x0012CC18 File Offset: 0x0012AE18
		public virtual string GetInputScalarsSelection()
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericClip.vtkGenericClip_GetInputScalarsSelection_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600D862 RID: 55394
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericClip_GetInsideOut_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, a vertex is considered
		/// inside the implicit function if its value is greater than the
		/// Value ivar. When InsideOutside is turned on, a vertex is
		/// considered inside the implicit function if its implicit function
		/// value is less than or equal to the Value ivar.  InsideOut is off
		/// by default.
		/// </summary>
		// Token: 0x0600D863 RID: 55395 RVA: 0x0012CC54 File Offset: 0x0012AE54
		public virtual int GetInsideOut()
		{
			return vtkGenericClip.vtkGenericClip_GetInsideOut_11(base.GetCppThis());
		}

		// Token: 0x0600D864 RID: 55396
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericClip_GetLocator_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a spatial locator for merging points. By default, an
		/// instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0600D865 RID: 55397 RVA: 0x0012CC74 File Offset: 0x0012AE74
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericClip.vtkGenericClip_GetLocator_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600D866 RID: 55398
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkGenericClip_GetMTime_13(HandleRef pThis);

		/// <summary>
		/// Return the mtime also considering the locator and clip function.
		/// </summary>
		// Token: 0x0600D867 RID: 55399 RVA: 0x0012CCE4 File Offset: 0x0012AEE4
		public override ulong GetMTime()
		{
			return vtkGenericClip.vtkGenericClip_GetMTime_13(base.GetCppThis());
		}

		// Token: 0x0600D868 RID: 55400
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGenericClip_GetMergeTolerance_14(HandleRef pThis);

		/// <summary>
		/// Set the tolerance for merging clip intersection points that are near
		/// the vertices of cells. This tolerance is used to prevent the generation
		/// of degenerate primitives. Note that only 3D cells actually use this
		/// instance variable.
		/// </summary>
		// Token: 0x0600D869 RID: 55401 RVA: 0x0012CD04 File Offset: 0x0012AF04
		public virtual double GetMergeTolerance()
		{
			return vtkGenericClip.vtkGenericClip_GetMergeTolerance_14(base.GetCppThis());
		}

		// Token: 0x0600D86A RID: 55402
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGenericClip_GetMergeToleranceMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Set the tolerance for merging clip intersection points that are near
		/// the vertices of cells. This tolerance is used to prevent the generation
		/// of degenerate primitives. Note that only 3D cells actually use this
		/// instance variable.
		/// </summary>
		// Token: 0x0600D86B RID: 55403 RVA: 0x0012CD24 File Offset: 0x0012AF24
		public virtual double GetMergeToleranceMaxValue()
		{
			return vtkGenericClip.vtkGenericClip_GetMergeToleranceMaxValue_15(base.GetCppThis());
		}

		// Token: 0x0600D86C RID: 55404
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGenericClip_GetMergeToleranceMinValue_16(HandleRef pThis);

		/// <summary>
		/// Set the tolerance for merging clip intersection points that are near
		/// the vertices of cells. This tolerance is used to prevent the generation
		/// of degenerate primitives. Note that only 3D cells actually use this
		/// instance variable.
		/// </summary>
		// Token: 0x0600D86D RID: 55405 RVA: 0x0012CD44 File Offset: 0x0012AF44
		public virtual double GetMergeToleranceMinValue()
		{
			return vtkGenericClip.vtkGenericClip_GetMergeToleranceMinValue_16(base.GetCppThis());
		}

		// Token: 0x0600D86E RID: 55406
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericClip_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D86F RID: 55407 RVA: 0x0012CD64 File Offset: 0x0012AF64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericClip.vtkGenericClip_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x0600D870 RID: 55408
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericClip_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D871 RID: 55409 RVA: 0x0012CD84 File Offset: 0x0012AF84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericClip.vtkGenericClip_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x0600D872 RID: 55410
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericClip_GetNumberOfOutputs_19(HandleRef pThis);

		/// <summary>
		/// Return the Clipped output.
		/// </summary>
		// Token: 0x0600D873 RID: 55411 RVA: 0x0012CDA0 File Offset: 0x0012AFA0
		public virtual int GetNumberOfOutputs()
		{
			return vtkGenericClip.vtkGenericClip_GetNumberOfOutputs_19(base.GetCppThis());
		}

		// Token: 0x0600D874 RID: 55412
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGenericClip_GetValue_20(HandleRef pThis);

		/// <summary>
		/// Set the clipping value of the implicit function (if clipping with
		/// implicit function) or scalar value (if clipping with
		/// scalars). The default value is 0.0.
		/// </summary>
		// Token: 0x0600D875 RID: 55413 RVA: 0x0012CDC0 File Offset: 0x0012AFC0
		public virtual double GetValue()
		{
			return vtkGenericClip.vtkGenericClip_GetValue_20(base.GetCppThis());
		}

		// Token: 0x0600D876 RID: 55414
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericClip_InsideOutOff_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, a vertex is considered
		/// inside the implicit function if its value is greater than the
		/// Value ivar. When InsideOutside is turned on, a vertex is
		/// considered inside the implicit function if its implicit function
		/// value is less than or equal to the Value ivar.  InsideOut is off
		/// by default.
		/// </summary>
		// Token: 0x0600D877 RID: 55415 RVA: 0x0012CDDF File Offset: 0x0012AFDF
		public virtual void InsideOutOff()
		{
			vtkGenericClip.vtkGenericClip_InsideOutOff_21(base.GetCppThis());
		}

		// Token: 0x0600D878 RID: 55416
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericClip_InsideOutOn_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, a vertex is considered
		/// inside the implicit function if its value is greater than the
		/// Value ivar. When InsideOutside is turned on, a vertex is
		/// considered inside the implicit function if its implicit function
		/// value is less than or equal to the Value ivar.  InsideOut is off
		/// by default.
		/// </summary>
		// Token: 0x0600D879 RID: 55417 RVA: 0x0012CDEE File Offset: 0x0012AFEE
		public virtual void InsideOutOn()
		{
			vtkGenericClip.vtkGenericClip_InsideOutOn_22(base.GetCppThis());
		}

		// Token: 0x0600D87A RID: 55418
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericClip_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D87B RID: 55419 RVA: 0x0012CE00 File Offset: 0x0012B000
		public override int IsA(string type)
		{
			return vtkGenericClip.vtkGenericClip_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x0600D87C RID: 55420
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericClip_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D87D RID: 55421 RVA: 0x0012CE20 File Offset: 0x0012B020
		public new static int IsTypeOf(string type)
		{
			return vtkGenericClip.vtkGenericClip_IsTypeOf_24(type);
		}

		// Token: 0x0600D87E RID: 55422
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericClip_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D87F RID: 55423 RVA: 0x0012CE3C File Offset: 0x0012B03C
		public new vtkGenericClip NewInstance()
		{
			vtkGenericClip result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericClip.vtkGenericClip_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericClip)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D880 RID: 55424
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericClip_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D881 RID: 55425 RVA: 0x0012CE98 File Offset: 0x0012B098
		public new static vtkGenericClip SafeDownCast(vtkObjectBase o)
		{
			vtkGenericClip vtkGenericClip = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericClip.vtkGenericClip_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericClip = (vtkGenericClip)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericClip.Register(null);
				}
			}
			return vtkGenericClip;
		}

		// Token: 0x0600D882 RID: 55426
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericClip_SelectInputScalars_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fieldName);

		/// <summary>
		/// If you want to clip by an arbitrary array, then set its name here.
		/// By default this in nullptr and the filter will use the active scalar array.
		/// </summary>
		// Token: 0x0600D883 RID: 55427 RVA: 0x0012CF17 File Offset: 0x0012B117
		public void SelectInputScalars(string fieldName)
		{
			vtkGenericClip.vtkGenericClip_SelectInputScalars_28(base.GetCppThis(), fieldName);
		}

		// Token: 0x0600D884 RID: 55428
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericClip_SetClipFunction_29(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the implicit function with which to perform the
		/// clipping. If you do not define an implicit function,
		/// then the selected input scalar data will be used for clipping.
		/// </summary>
		// Token: 0x0600D885 RID: 55429 RVA: 0x0012CF28 File Offset: 0x0012B128
		public virtual void SetClipFunction(vtkImplicitFunction arg0)
		{
			vtkGenericClip.vtkGenericClip_SetClipFunction_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600D886 RID: 55430
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericClip_SetGenerateClipScalars_30(HandleRef pThis, int _arg);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the
		/// input scalar data. If you enable this flag but do not provide an
		/// implicit function an error will be reported.
		/// </summary>
		// Token: 0x0600D887 RID: 55431 RVA: 0x0012CF57 File Offset: 0x0012B157
		public virtual void SetGenerateClipScalars(int _arg)
		{
			vtkGenericClip.vtkGenericClip_SetGenerateClipScalars_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D888 RID: 55432
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericClip_SetGenerateClippedOutput_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the polygonal data that's been clipped away.
		/// </summary>
		// Token: 0x0600D889 RID: 55433 RVA: 0x0012CF67 File Offset: 0x0012B167
		public virtual void SetGenerateClippedOutput(int _arg)
		{
			vtkGenericClip.vtkGenericClip_SetGenerateClippedOutput_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D88A RID: 55434
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericClip_SetInsideOut_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, a vertex is considered
		/// inside the implicit function if its value is greater than the
		/// Value ivar. When InsideOutside is turned on, a vertex is
		/// considered inside the implicit function if its implicit function
		/// value is less than or equal to the Value ivar.  InsideOut is off
		/// by default.
		/// </summary>
		// Token: 0x0600D88B RID: 55435 RVA: 0x0012CF77 File Offset: 0x0012B177
		public virtual void SetInsideOut(int _arg)
		{
			vtkGenericClip.vtkGenericClip_SetInsideOut_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D88C RID: 55436
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericClip_SetLocator_33(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a spatial locator for merging points. By default, an
		/// instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0600D88D RID: 55437 RVA: 0x0012CF88 File Offset: 0x0012B188
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkGenericClip.vtkGenericClip_SetLocator_33(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600D88E RID: 55438
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericClip_SetMergeTolerance_34(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the tolerance for merging clip intersection points that are near
		/// the vertices of cells. This tolerance is used to prevent the generation
		/// of degenerate primitives. Note that only 3D cells actually use this
		/// instance variable.
		/// </summary>
		// Token: 0x0600D88F RID: 55439 RVA: 0x0012CFB7 File Offset: 0x0012B1B7
		public virtual void SetMergeTolerance(double _arg)
		{
			vtkGenericClip.vtkGenericClip_SetMergeTolerance_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D890 RID: 55440
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericClip_SetValue_35(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the clipping value of the implicit function (if clipping with
		/// implicit function) or scalar value (if clipping with
		/// scalars). The default value is 0.0.
		/// </summary>
		// Token: 0x0600D891 RID: 55441 RVA: 0x0012CFC7 File Offset: 0x0012B1C7
		public virtual void SetValue(double _arg)
		{
			vtkGenericClip.vtkGenericClip_SetValue_35(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FD8 RID: 4056
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericClip";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FD9 RID: 4057
		public new static readonly string MRClassNameKey = "class vtkGenericClip";
	}
}
