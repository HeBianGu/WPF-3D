using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkThreshold
	/// </summary>
	/// <remarks>
	///    extracts cells where scalar value in cell satisfies threshold criterion
	///
	/// vtkThreshold is a filter that extracts cells from any dataset type that
	/// satisfy a threshold criterion. A cell satisfies the criterion if the
	/// scalar value of (every or any) point satisfies the criterion. The
	/// criterion can take three forms: 1) greater than a particular value; 2)
	/// less than a particular value; or 3) between two values. The output of this
	/// filter is an unstructured grid.
	///
	/// Note that scalar values are available from the point and cell attribute
	/// data.  By default, point data is used to obtain scalars, but you can
	/// control this behavior. See the AttributeMode ivar below.
	///
	/// By default only the first scalar value is used in the decision. Use the ComponentMode
	/// and SelectedComponent ivars to control this behavior.
	///
	/// @warning
	/// This class is templated. It may run slower than serial execution if the code
	/// is not optimized during compilation. Build in Release or ReleaseWithDebugInfo.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkThresholdPoints vtkThresholdTextureCoords
	/// </seealso>
	// Token: 0x020009B4 RID: 2484
	public class vtkThreshold : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019F3B RID: 106299 RVA: 0x0023FF4F File Offset: 0x0023E14F
		static vtkThreshold()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkThreshold.MRClassNameKey, Type.GetType("Kitware.VTK.vtkThreshold"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019F3C RID: 106300 RVA: 0x0023FF77 File Offset: 0x0023E177
		public vtkThreshold(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019F3D RID: 106301
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThreshold_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019F3E RID: 106302 RVA: 0x0023FF88 File Offset: 0x0023E188
		public new static vtkThreshold New()
		{
			vtkThreshold result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThreshold.vtkThreshold_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThreshold)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019F3F RID: 106303 RVA: 0x0023FFDC File Offset: 0x0023E1DC
		public vtkThreshold() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkThreshold.vtkThreshold_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019F40 RID: 106304 RVA: 0x00240020 File Offset: 0x0023E220
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019F41 RID: 106305
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreshold_AllScalarsOff_01(HandleRef pThis);

		/// <summary>
		/// If using scalars from point data, all scalars for all points in a cell
		/// must satisfy the threshold criterion if AllScalars is set. Otherwise,
		/// just a single scalar value satisfying the threshold criterion enables
		/// will extract the cell.
		/// </summary>
		// Token: 0x06019F42 RID: 106306 RVA: 0x0024002B File Offset: 0x0023E22B
		public virtual void AllScalarsOff()
		{
			vtkThreshold.vtkThreshold_AllScalarsOff_01(base.GetCppThis());
		}

		// Token: 0x06019F43 RID: 106307
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreshold_AllScalarsOn_02(HandleRef pThis);

		/// <summary>
		/// If using scalars from point data, all scalars for all points in a cell
		/// must satisfy the threshold criterion if AllScalars is set. Otherwise,
		/// just a single scalar value satisfying the threshold criterion enables
		/// will extract the cell.
		/// </summary>
		// Token: 0x06019F44 RID: 106308 RVA: 0x0024003A File Offset: 0x0023E23A
		public virtual void AllScalarsOn()
		{
			vtkThreshold.vtkThreshold_AllScalarsOn_02(base.GetCppThis());
		}

		// Token: 0x06019F45 RID: 106309
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreshold_Between_03(HandleRef pThis, double s);

		/// <summary>
		/// Methods used for thresholding. vtkThreshold::Lower returns true if s is lower than the lower
		/// threshold, vtkThreshold::Upper returns true if s is larger than the upper threshold, and
		/// vtkThreshold::Between returns true if s is between the lower and upper thresholds.
		///
		/// @warning These methods use threshold values that can be set with
		/// vtkThreshold::SetLowerThreshold and vtkThreshold::SetUpperThreshold. The threshold
		/// method can be set using vtkThreshold::SetThresholdFunction.
		///
		/// @note They are not protected members for inheritance purposes. The addresses of those methods
		/// are stored in one of this class attributes to figure out which version of the threshold to
		/// apply, which are inaccessible if protected.
		/// </summary>
		// Token: 0x06019F46 RID: 106310 RVA: 0x0024004C File Offset: 0x0023E24C
		public int Between(double s)
		{
			return vtkThreshold.vtkThreshold_Between_03(base.GetCppThis(), s);
		}

		// Token: 0x06019F47 RID: 106311
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreshold_GetAllScalars_04(HandleRef pThis);

		/// <summary>
		/// If using scalars from point data, all scalars for all points in a cell
		/// must satisfy the threshold criterion if AllScalars is set. Otherwise,
		/// just a single scalar value satisfying the threshold criterion enables
		/// will extract the cell.
		/// </summary>
		// Token: 0x06019F48 RID: 106312 RVA: 0x0024006C File Offset: 0x0023E26C
		public virtual int GetAllScalars()
		{
			return vtkThreshold.vtkThreshold_GetAllScalars_04(base.GetCppThis());
		}

		// Token: 0x06019F49 RID: 106313
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreshold_GetComponentMode_05(HandleRef pThis);

		/// <summary>
		/// Control how the decision of in / out is made with multi-component data.
		/// The choices are to use the selected component (specified in the
		/// SelectedComponent ivar), or to look at all components. When looking at
		/// all components, the evaluation can pass if all the components satisfy
		/// the rule (UseAll) or if any satisfy is (UseAny). The default value is
		/// UseSelected.
		/// </summary>
		// Token: 0x06019F4A RID: 106314 RVA: 0x0024008C File Offset: 0x0023E28C
		public virtual int GetComponentMode()
		{
			return vtkThreshold.vtkThreshold_GetComponentMode_05(base.GetCppThis());
		}

		// Token: 0x06019F4B RID: 106315
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThreshold_GetComponentModeAsString_06(HandleRef pThis);

		/// <summary>
		/// Control how the decision of in / out is made with multi-component data.
		/// The choices are to use the selected component (specified in the
		/// SelectedComponent ivar), or to look at all components. When looking at
		/// all components, the evaluation can pass if all the components satisfy
		/// the rule (UseAll) or if any satisfy is (UseAny). The default value is
		/// UseSelected.
		/// </summary>
		// Token: 0x06019F4C RID: 106316 RVA: 0x002400AC File Offset: 0x0023E2AC
		public string GetComponentModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkThreshold.vtkThreshold_GetComponentModeAsString_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06019F4D RID: 106317
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreshold_GetComponentModeMaxValue_07(HandleRef pThis);

		/// <summary>
		/// Control how the decision of in / out is made with multi-component data.
		/// The choices are to use the selected component (specified in the
		/// SelectedComponent ivar), or to look at all components. When looking at
		/// all components, the evaluation can pass if all the components satisfy
		/// the rule (UseAll) or if any satisfy is (UseAny). The default value is
		/// UseSelected.
		/// </summary>
		// Token: 0x06019F4E RID: 106318 RVA: 0x002400E8 File Offset: 0x0023E2E8
		public virtual int GetComponentModeMaxValue()
		{
			return vtkThreshold.vtkThreshold_GetComponentModeMaxValue_07(base.GetCppThis());
		}

		// Token: 0x06019F4F RID: 106319
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreshold_GetComponentModeMinValue_08(HandleRef pThis);

		/// <summary>
		/// Control how the decision of in / out is made with multi-component data.
		/// The choices are to use the selected component (specified in the
		/// SelectedComponent ivar), or to look at all components. When looking at
		/// all components, the evaluation can pass if all the components satisfy
		/// the rule (UseAll) or if any satisfy is (UseAny). The default value is
		/// UseSelected.
		/// </summary>
		// Token: 0x06019F50 RID: 106320 RVA: 0x00240108 File Offset: 0x0023E308
		public virtual int GetComponentModeMinValue()
		{
			return vtkThreshold.vtkThreshold_GetComponentModeMinValue_08(base.GetCppThis());
		}

		// Token: 0x06019F51 RID: 106321
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkThreshold_GetInvert_09(HandleRef pThis);

		/// <summary>
		/// Invert the threshold results. That is, cells that would have been in the output with this
		/// option off are excluded, while cells that would have been excluded from the output are
		/// included.
		/// </summary>
		// Token: 0x06019F52 RID: 106322 RVA: 0x00240128 File Offset: 0x0023E328
		public virtual bool GetInvert()
		{
			return vtkThreshold.vtkThreshold_GetInvert_09(base.GetCppThis()) != 0;
		}

		// Token: 0x06019F53 RID: 106323
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkThreshold_GetLowerThreshold_10(HandleRef pThis);

		/// <summary>
		/// Set/get the upper and lower thresholds. The default values are set to +infinity and -infinity,
		/// respectively.
		/// </summary>
		// Token: 0x06019F54 RID: 106324 RVA: 0x00240150 File Offset: 0x0023E350
		public virtual double GetLowerThreshold()
		{
			return vtkThreshold.vtkThreshold_GetLowerThreshold_10(base.GetCppThis());
		}

		// Token: 0x06019F55 RID: 106325
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkThreshold_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019F56 RID: 106326 RVA: 0x00240170 File Offset: 0x0023E370
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkThreshold.vtkThreshold_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x06019F57 RID: 106327
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkThreshold_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019F58 RID: 106328 RVA: 0x00240190 File Offset: 0x0023E390
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkThreshold.vtkThreshold_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x06019F59 RID: 106329
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreshold_GetOutputPointsPrecision_13(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019F5A RID: 106330 RVA: 0x002401AC File Offset: 0x0023E3AC
		public virtual int GetOutputPointsPrecision()
		{
			return vtkThreshold.vtkThreshold_GetOutputPointsPrecision_13(base.GetCppThis());
		}

		// Token: 0x06019F5B RID: 106331
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreshold_GetSelectedComponent_14(HandleRef pThis);

		/// <summary>
		/// When the component mode is UseSelected, this ivar indicated the selected
		/// component. The default value is 0.
		/// </summary>
		// Token: 0x06019F5C RID: 106332 RVA: 0x002401CC File Offset: 0x0023E3CC
		public virtual int GetSelectedComponent()
		{
			return vtkThreshold.vtkThreshold_GetSelectedComponent_14(base.GetCppThis());
		}

		// Token: 0x06019F5D RID: 106333
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreshold_GetSelectedComponentMaxValue_15(HandleRef pThis);

		/// <summary>
		/// When the component mode is UseSelected, this ivar indicated the selected
		/// component. The default value is 0.
		/// </summary>
		// Token: 0x06019F5E RID: 106334 RVA: 0x002401EC File Offset: 0x0023E3EC
		public virtual int GetSelectedComponentMaxValue()
		{
			return vtkThreshold.vtkThreshold_GetSelectedComponentMaxValue_15(base.GetCppThis());
		}

		// Token: 0x06019F5F RID: 106335
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreshold_GetSelectedComponentMinValue_16(HandleRef pThis);

		/// <summary>
		/// When the component mode is UseSelected, this ivar indicated the selected
		/// component. The default value is 0.
		/// </summary>
		// Token: 0x06019F60 RID: 106336 RVA: 0x0024020C File Offset: 0x0023E40C
		public virtual int GetSelectedComponentMinValue()
		{
			return vtkThreshold.vtkThreshold_GetSelectedComponentMinValue_16(base.GetCppThis());
		}

		// Token: 0x06019F61 RID: 106337
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreshold_GetThresholdFunction_17(HandleRef pThis);

		/// <summary>
		/// Get/Set the threshold method, defining which threshold bounds to use. The default method is
		/// vtkThreshold::Between.
		/// </summary>
		// Token: 0x06019F62 RID: 106338 RVA: 0x0024022C File Offset: 0x0023E42C
		public int GetThresholdFunction()
		{
			return vtkThreshold.vtkThreshold_GetThresholdFunction_17(base.GetCppThis());
		}

		// Token: 0x06019F63 RID: 106339
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkThreshold_GetUpperThreshold_18(HandleRef pThis);

		/// <summary>
		/// Set/get the upper and lower thresholds. The default values are set to +infinity and -infinity,
		/// respectively.
		/// </summary>
		// Token: 0x06019F64 RID: 106340 RVA: 0x0024024C File Offset: 0x0023E44C
		public virtual double GetUpperThreshold()
		{
			return vtkThreshold.vtkThreshold_GetUpperThreshold_18(base.GetCppThis());
		}

		// Token: 0x06019F65 RID: 106341
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreshold_GetUseContinuousCellRange_19(HandleRef pThis);

		/// <summary>
		/// If this is on (default is off), we will use the continuous interval
		/// [minimum cell scalar, maximum cell scalar] to intersect the threshold bound
		/// , rather than the set of discrete scalar values from the vertices
		/// *WARNING*: For higher order cells, the scalar range of the cell is
		/// not the same as the vertex scalar interval used here, so the
		/// result will not be accurate.
		/// </summary>
		// Token: 0x06019F66 RID: 106342 RVA: 0x0024026C File Offset: 0x0023E46C
		public virtual int GetUseContinuousCellRange()
		{
			return vtkThreshold.vtkThreshold_GetUseContinuousCellRange_19(base.GetCppThis());
		}

		// Token: 0x06019F67 RID: 106343
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreshold_InvertOff_20(HandleRef pThis);

		/// <summary>
		/// Invert the threshold results. That is, cells that would have been in the output with this
		/// option off are excluded, while cells that would have been excluded from the output are
		/// included.
		/// </summary>
		// Token: 0x06019F68 RID: 106344 RVA: 0x0024028B File Offset: 0x0023E48B
		public virtual void InvertOff()
		{
			vtkThreshold.vtkThreshold_InvertOff_20(base.GetCppThis());
		}

		// Token: 0x06019F69 RID: 106345
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreshold_InvertOn_21(HandleRef pThis);

		/// <summary>
		/// Invert the threshold results. That is, cells that would have been in the output with this
		/// option off are excluded, while cells that would have been excluded from the output are
		/// included.
		/// </summary>
		// Token: 0x06019F6A RID: 106346 RVA: 0x0024029A File Offset: 0x0023E49A
		public virtual void InvertOn()
		{
			vtkThreshold.vtkThreshold_InvertOn_21(base.GetCppThis());
		}

		// Token: 0x06019F6B RID: 106347
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreshold_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019F6C RID: 106348 RVA: 0x002402AC File Offset: 0x0023E4AC
		public override int IsA(string type)
		{
			return vtkThreshold.vtkThreshold_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x06019F6D RID: 106349
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreshold_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019F6E RID: 106350 RVA: 0x002402CC File Offset: 0x0023E4CC
		public new static int IsTypeOf(string type)
		{
			return vtkThreshold.vtkThreshold_IsTypeOf_23(type);
		}

		// Token: 0x06019F6F RID: 106351
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreshold_Lower_24(HandleRef pThis, double s);

		/// <summary>
		/// Methods used for thresholding. vtkThreshold::Lower returns true if s is lower than the lower
		/// threshold, vtkThreshold::Upper returns true if s is larger than the upper threshold, and
		/// vtkThreshold::Between returns true if s is between the lower and upper thresholds.
		///
		/// @warning These methods use threshold values that can be set with
		/// vtkThreshold::SetLowerThreshold and vtkThreshold::SetUpperThreshold. The threshold
		/// method can be set using vtkThreshold::SetThresholdFunction.
		///
		/// @note They are not protected members for inheritance purposes. The addresses of those methods
		/// are stored in one of this class attributes to figure out which version of the threshold to
		/// apply, which are inaccessible if protected.
		/// </summary>
		// Token: 0x06019F70 RID: 106352 RVA: 0x002402E8 File Offset: 0x0023E4E8
		public int Lower(double s)
		{
			return vtkThreshold.vtkThreshold_Lower_24(base.GetCppThis(), s);
		}

		// Token: 0x06019F71 RID: 106353
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThreshold_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019F72 RID: 106354 RVA: 0x00240308 File Offset: 0x0023E508
		public new vtkThreshold NewInstance()
		{
			vtkThreshold result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThreshold.vtkThreshold_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThreshold)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019F73 RID: 106355
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThreshold_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019F74 RID: 106356 RVA: 0x00240364 File Offset: 0x0023E564
		public new static vtkThreshold SafeDownCast(vtkObjectBase o)
		{
			vtkThreshold vtkThreshold = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThreshold.vtkThreshold_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkThreshold = (vtkThreshold)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkThreshold.Register(null);
				}
			}
			return vtkThreshold;
		}

		// Token: 0x06019F75 RID: 106357
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreshold_SetAllScalars_28(HandleRef pThis, int _arg);

		/// <summary>
		/// If using scalars from point data, all scalars for all points in a cell
		/// must satisfy the threshold criterion if AllScalars is set. Otherwise,
		/// just a single scalar value satisfying the threshold criterion enables
		/// will extract the cell.
		/// </summary>
		// Token: 0x06019F76 RID: 106358 RVA: 0x002403E3 File Offset: 0x0023E5E3
		public virtual void SetAllScalars(int _arg)
		{
			vtkThreshold.vtkThreshold_SetAllScalars_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06019F77 RID: 106359
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreshold_SetComponentMode_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Control how the decision of in / out is made with multi-component data.
		/// The choices are to use the selected component (specified in the
		/// SelectedComponent ivar), or to look at all components. When looking at
		/// all components, the evaluation can pass if all the components satisfy
		/// the rule (UseAll) or if any satisfy is (UseAny). The default value is
		/// UseSelected.
		/// </summary>
		// Token: 0x06019F78 RID: 106360 RVA: 0x002403F3 File Offset: 0x0023E5F3
		public virtual void SetComponentMode(int _arg)
		{
			vtkThreshold.vtkThreshold_SetComponentMode_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06019F79 RID: 106361
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreshold_SetComponentModeToUseAll_30(HandleRef pThis);

		/// <summary>
		/// Control how the decision of in / out is made with multi-component data.
		/// The choices are to use the selected component (specified in the
		/// SelectedComponent ivar), or to look at all components. When looking at
		/// all components, the evaluation can pass if all the components satisfy
		/// the rule (UseAll) or if any satisfy is (UseAny). The default value is
		/// UseSelected.
		/// </summary>
		// Token: 0x06019F7A RID: 106362 RVA: 0x00240403 File Offset: 0x0023E603
		public void SetComponentModeToUseAll()
		{
			vtkThreshold.vtkThreshold_SetComponentModeToUseAll_30(base.GetCppThis());
		}

		// Token: 0x06019F7B RID: 106363
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreshold_SetComponentModeToUseAny_31(HandleRef pThis);

		/// <summary>
		/// Control how the decision of in / out is made with multi-component data.
		/// The choices are to use the selected component (specified in the
		/// SelectedComponent ivar), or to look at all components. When looking at
		/// all components, the evaluation can pass if all the components satisfy
		/// the rule (UseAll) or if any satisfy is (UseAny). The default value is
		/// UseSelected.
		/// </summary>
		// Token: 0x06019F7C RID: 106364 RVA: 0x00240412 File Offset: 0x0023E612
		public void SetComponentModeToUseAny()
		{
			vtkThreshold.vtkThreshold_SetComponentModeToUseAny_31(base.GetCppThis());
		}

		// Token: 0x06019F7D RID: 106365
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreshold_SetComponentModeToUseSelected_32(HandleRef pThis);

		/// <summary>
		/// Control how the decision of in / out is made with multi-component data.
		/// The choices are to use the selected component (specified in the
		/// SelectedComponent ivar), or to look at all components. When looking at
		/// all components, the evaluation can pass if all the components satisfy
		/// the rule (UseAll) or if any satisfy is (UseAny). The default value is
		/// UseSelected.
		/// </summary>
		// Token: 0x06019F7E RID: 106366 RVA: 0x00240421 File Offset: 0x0023E621
		public void SetComponentModeToUseSelected()
		{
			vtkThreshold.vtkThreshold_SetComponentModeToUseSelected_32(base.GetCppThis());
		}

		// Token: 0x06019F7F RID: 106367
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreshold_SetInvert_33(HandleRef pThis, byte _arg);

		/// <summary>
		/// Invert the threshold results. That is, cells that would have been in the output with this
		/// option off are excluded, while cells that would have been excluded from the output are
		/// included.
		/// </summary>
		// Token: 0x06019F80 RID: 106368 RVA: 0x00240430 File Offset: 0x0023E630
		public virtual void SetInvert(bool _arg)
		{
			vtkThreshold.vtkThreshold_SetInvert_33(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019F81 RID: 106369
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreshold_SetLowerThreshold_34(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the upper and lower thresholds. The default values are set to +infinity and -infinity,
		/// respectively.
		/// </summary>
		// Token: 0x06019F82 RID: 106370 RVA: 0x00240448 File Offset: 0x0023E648
		public virtual void SetLowerThreshold(double _arg)
		{
			vtkThreshold.vtkThreshold_SetLowerThreshold_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06019F83 RID: 106371
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreshold_SetOutputPointsPrecision_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019F84 RID: 106372 RVA: 0x00240458 File Offset: 0x0023E658
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkThreshold.vtkThreshold_SetOutputPointsPrecision_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06019F85 RID: 106373
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreshold_SetSelectedComponent_36(HandleRef pThis, int _arg);

		/// <summary>
		/// When the component mode is UseSelected, this ivar indicated the selected
		/// component. The default value is 0.
		/// </summary>
		// Token: 0x06019F86 RID: 106374 RVA: 0x00240468 File Offset: 0x0023E668
		public virtual void SetSelectedComponent(int _arg)
		{
			vtkThreshold.vtkThreshold_SetSelectedComponent_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06019F87 RID: 106375
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreshold_SetThresholdFunction_37(HandleRef pThis, int function);

		/// <summary>
		/// Get/Set the threshold method, defining which threshold bounds to use. The default method is
		/// vtkThreshold::Between.
		/// </summary>
		// Token: 0x06019F88 RID: 106376 RVA: 0x00240478 File Offset: 0x0023E678
		public void SetThresholdFunction(int function)
		{
			vtkThreshold.vtkThreshold_SetThresholdFunction_37(base.GetCppThis(), function);
		}

		// Token: 0x06019F89 RID: 106377
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreshold_SetUpperThreshold_38(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the upper and lower thresholds. The default values are set to +infinity and -infinity,
		/// respectively.
		/// </summary>
		// Token: 0x06019F8A RID: 106378 RVA: 0x00240488 File Offset: 0x0023E688
		public virtual void SetUpperThreshold(double _arg)
		{
			vtkThreshold.vtkThreshold_SetUpperThreshold_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06019F8B RID: 106379
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreshold_SetUseContinuousCellRange_39(HandleRef pThis, int _arg);

		/// <summary>
		/// If this is on (default is off), we will use the continuous interval
		/// [minimum cell scalar, maximum cell scalar] to intersect the threshold bound
		/// , rather than the set of discrete scalar values from the vertices
		/// *WARNING*: For higher order cells, the scalar range of the cell is
		/// not the same as the vertex scalar interval used here, so the
		/// result will not be accurate.
		/// </summary>
		// Token: 0x06019F8C RID: 106380 RVA: 0x00240498 File Offset: 0x0023E698
		public virtual void SetUseContinuousCellRange(int _arg)
		{
			vtkThreshold.vtkThreshold_SetUseContinuousCellRange_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06019F8D RID: 106381
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreshold_Upper_40(HandleRef pThis, double s);

		/// <summary>
		/// Methods used for thresholding. vtkThreshold::Lower returns true if s is lower than the lower
		/// threshold, vtkThreshold::Upper returns true if s is larger than the upper threshold, and
		/// vtkThreshold::Between returns true if s is between the lower and upper thresholds.
		///
		/// @warning These methods use threshold values that can be set with
		/// vtkThreshold::SetLowerThreshold and vtkThreshold::SetUpperThreshold. The threshold
		/// method can be set using vtkThreshold::SetThresholdFunction.
		///
		/// @note They are not protected members for inheritance purposes. The addresses of those methods
		/// are stored in one of this class attributes to figure out which version of the threshold to
		/// apply, which are inaccessible if protected.
		/// </summary>
		// Token: 0x06019F8E RID: 106382 RVA: 0x002404A8 File Offset: 0x0023E6A8
		public int Upper(double s)
		{
			return vtkThreshold.vtkThreshold_Upper_40(base.GetCppThis(), s);
		}

		// Token: 0x06019F8F RID: 106383
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreshold_UseContinuousCellRangeOff_41(HandleRef pThis);

		/// <summary>
		/// If this is on (default is off), we will use the continuous interval
		/// [minimum cell scalar, maximum cell scalar] to intersect the threshold bound
		/// , rather than the set of discrete scalar values from the vertices
		/// *WARNING*: For higher order cells, the scalar range of the cell is
		/// not the same as the vertex scalar interval used here, so the
		/// result will not be accurate.
		/// </summary>
		// Token: 0x06019F90 RID: 106384 RVA: 0x002404C8 File Offset: 0x0023E6C8
		public virtual void UseContinuousCellRangeOff()
		{
			vtkThreshold.vtkThreshold_UseContinuousCellRangeOff_41(base.GetCppThis());
		}

		// Token: 0x06019F91 RID: 106385
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreshold_UseContinuousCellRangeOn_42(HandleRef pThis);

		/// <summary>
		/// If this is on (default is off), we will use the continuous interval
		/// [minimum cell scalar, maximum cell scalar] to intersect the threshold bound
		/// , rather than the set of discrete scalar values from the vertices
		/// *WARNING*: For higher order cells, the scalar range of the cell is
		/// not the same as the vertex scalar interval used here, so the
		/// result will not be accurate.
		/// </summary>
		// Token: 0x06019F92 RID: 106386 RVA: 0x002404D7 File Offset: 0x0023E6D7
		public virtual void UseContinuousCellRangeOn()
		{
			vtkThreshold.vtkThreshold_UseContinuousCellRangeOn_42(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C2C RID: 7212
		public new const string MRFullTypeName = "Kitware.VTK.vtkThreshold";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C2D RID: 7213
		public new static readonly string MRClassNameKey = "class vtkThreshold";

		/// <summary>
		/// Possible values for the threshold function:
		/// - THRESHOLD_BETWEEN - Keep values between the lower and upper thresholds.
		/// - THRESHOLD_LOWER - Keep values below the lower threshold.
		/// - THRESHOLD_UPPER - Keep values above the upper threshold.
		/// </summary>
		// Token: 0x020009B5 RID: 2485
		public enum ThresholdType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001C2F RID: 7215
			THRESHOLD_BETWEEN,
			/// <summary>enum member</summary>
			// Token: 0x04001C30 RID: 7216
			THRESHOLD_LOWER,
			/// <summary>enum member</summary>
			// Token: 0x04001C31 RID: 7217
			THRESHOLD_UPPER
		}
	}
}
