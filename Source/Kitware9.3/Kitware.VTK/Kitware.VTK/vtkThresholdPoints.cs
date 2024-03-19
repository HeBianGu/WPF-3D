using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkThresholdPoints
	/// </summary>
	/// <remarks>
	///    extracts points whose scalar value satisfies threshold criterion
	///
	/// vtkThresholdPoints is a filter that extracts points from a dataset that
	/// satisfy a threshold criterion. The criterion can take three forms:
	/// 1) greater than a particular value; 2) less than a particular value; or
	/// 3) between a particular value. The output of the filter is polygonal data.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkThreshold vtkSelectEnclosedPoints vtkExtractEnclosedPoints
	/// </seealso>
	// Token: 0x020009B6 RID: 2486
	public class vtkThresholdPoints : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019F93 RID: 106387 RVA: 0x002404E6 File Offset: 0x0023E6E6
		static vtkThresholdPoints()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkThresholdPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkThresholdPoints"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019F94 RID: 106388 RVA: 0x0024050E File Offset: 0x0023E70E
		public vtkThresholdPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019F95 RID: 106389
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThresholdPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019F96 RID: 106390 RVA: 0x0024051C File Offset: 0x0023E71C
		public new static vtkThresholdPoints New()
		{
			vtkThresholdPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThresholdPoints.vtkThresholdPoints_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThresholdPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019F97 RID: 106391 RVA: 0x00240570 File Offset: 0x0023E770
		public vtkThresholdPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkThresholdPoints.vtkThresholdPoints_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019F98 RID: 106392 RVA: 0x002405B4 File Offset: 0x0023E7B4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019F99 RID: 106393
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThresholdPoints_GetInputArrayComponent_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the component to threshold. Set this to a value greater than the number of
		/// components in the selected data array to threshold by magnitude.
		/// </summary>
		// Token: 0x06019F9A RID: 106394 RVA: 0x002405C0 File Offset: 0x0023E7C0
		public virtual int GetInputArrayComponent()
		{
			return vtkThresholdPoints.vtkThresholdPoints_GetInputArrayComponent_01(base.GetCppThis());
		}

		// Token: 0x06019F9B RID: 106395
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkThresholdPoints_GetLowerThreshold_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the lower threshold.
		/// </summary>
		// Token: 0x06019F9C RID: 106396 RVA: 0x002405E0 File Offset: 0x0023E7E0
		public virtual double GetLowerThreshold()
		{
			return vtkThresholdPoints.vtkThresholdPoints_GetLowerThreshold_02(base.GetCppThis());
		}

		// Token: 0x06019F9D RID: 106397
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkThresholdPoints_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019F9E RID: 106398 RVA: 0x00240600 File Offset: 0x0023E800
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkThresholdPoints.vtkThresholdPoints_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06019F9F RID: 106399
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkThresholdPoints_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019FA0 RID: 106400 RVA: 0x00240620 File Offset: 0x0023E820
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkThresholdPoints.vtkThresholdPoints_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06019FA1 RID: 106401
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThresholdPoints_GetOutputPointsPrecision_05(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019FA2 RID: 106402 RVA: 0x0024063C File Offset: 0x0023E83C
		public virtual int GetOutputPointsPrecision()
		{
			return vtkThresholdPoints.vtkThresholdPoints_GetOutputPointsPrecision_05(base.GetCppThis());
		}

		// Token: 0x06019FA3 RID: 106403
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkThresholdPoints_GetUpperThreshold_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the upper threshold.
		/// </summary>
		// Token: 0x06019FA4 RID: 106404 RVA: 0x0024065C File Offset: 0x0023E85C
		public virtual double GetUpperThreshold()
		{
			return vtkThresholdPoints.vtkThresholdPoints_GetUpperThreshold_06(base.GetCppThis());
		}

		// Token: 0x06019FA5 RID: 106405
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThresholdPoints_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019FA6 RID: 106406 RVA: 0x0024067C File Offset: 0x0023E87C
		public override int IsA(string type)
		{
			return vtkThresholdPoints.vtkThresholdPoints_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06019FA7 RID: 106407
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThresholdPoints_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019FA8 RID: 106408 RVA: 0x0024069C File Offset: 0x0023E89C
		public new static int IsTypeOf(string type)
		{
			return vtkThresholdPoints.vtkThresholdPoints_IsTypeOf_08(type);
		}

		// Token: 0x06019FA9 RID: 106409
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThresholdPoints_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019FAA RID: 106410 RVA: 0x002406B8 File Offset: 0x0023E8B8
		public new vtkThresholdPoints NewInstance()
		{
			vtkThresholdPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThresholdPoints.vtkThresholdPoints_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThresholdPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019FAB RID: 106411
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThresholdPoints_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019FAC RID: 106412 RVA: 0x00240714 File Offset: 0x0023E914
		public new static vtkThresholdPoints SafeDownCast(vtkObjectBase o)
		{
			vtkThresholdPoints vtkThresholdPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThresholdPoints.vtkThresholdPoints_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkThresholdPoints = (vtkThresholdPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkThresholdPoints.Register(null);
				}
			}
			return vtkThresholdPoints;
		}

		// Token: 0x06019FAD RID: 106413
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdPoints_SetInputArrayComponent_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the component to threshold. Set this to a value greater than the number of
		/// components in the selected data array to threshold by magnitude.
		/// </summary>
		// Token: 0x06019FAE RID: 106414 RVA: 0x00240793 File Offset: 0x0023E993
		public virtual void SetInputArrayComponent(int _arg)
		{
			vtkThresholdPoints.vtkThresholdPoints_SetInputArrayComponent_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06019FAF RID: 106415
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdPoints_SetLowerThreshold_13(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the lower threshold.
		/// </summary>
		// Token: 0x06019FB0 RID: 106416 RVA: 0x002407A3 File Offset: 0x0023E9A3
		public virtual void SetLowerThreshold(double _arg)
		{
			vtkThresholdPoints.vtkThresholdPoints_SetLowerThreshold_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06019FB1 RID: 106417
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdPoints_SetOutputPointsPrecision_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019FB2 RID: 106418 RVA: 0x002407B3 File Offset: 0x0023E9B3
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkThresholdPoints.vtkThresholdPoints_SetOutputPointsPrecision_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06019FB3 RID: 106419
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdPoints_SetUpperThreshold_15(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the upper threshold.
		/// </summary>
		// Token: 0x06019FB4 RID: 106420 RVA: 0x002407C3 File Offset: 0x0023E9C3
		public virtual void SetUpperThreshold(double _arg)
		{
			vtkThresholdPoints.vtkThresholdPoints_SetUpperThreshold_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06019FB5 RID: 106421
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdPoints_ThresholdBetween_16(HandleRef pThis, double lower, double upper);

		/// <summary>
		/// Criterion is cells whose scalars are between lower and upper thresholds
		/// (inclusive of the end values).
		/// </summary>
		// Token: 0x06019FB6 RID: 106422 RVA: 0x002407D3 File Offset: 0x0023E9D3
		public void ThresholdBetween(double lower, double upper)
		{
			vtkThresholdPoints.vtkThresholdPoints_ThresholdBetween_16(base.GetCppThis(), lower, upper);
		}

		// Token: 0x06019FB7 RID: 106423
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdPoints_ThresholdByLower_17(HandleRef pThis, double lower);

		/// <summary>
		/// Criterion is cells whose scalars are less or equal to lower threshold.
		/// </summary>
		// Token: 0x06019FB8 RID: 106424 RVA: 0x002407E4 File Offset: 0x0023E9E4
		public void ThresholdByLower(double lower)
		{
			vtkThresholdPoints.vtkThresholdPoints_ThresholdByLower_17(base.GetCppThis(), lower);
		}

		// Token: 0x06019FB9 RID: 106425
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdPoints_ThresholdByUpper_18(HandleRef pThis, double upper);

		/// <summary>
		/// Criterion is cells whose scalars are greater or equal to upper threshold.
		/// </summary>
		// Token: 0x06019FBA RID: 106426 RVA: 0x002407F4 File Offset: 0x0023E9F4
		public void ThresholdByUpper(double upper)
		{
			vtkThresholdPoints.vtkThresholdPoints_ThresholdByUpper_18(base.GetCppThis(), upper);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C32 RID: 7218
		public new const string MRFullTypeName = "Kitware.VTK.vtkThresholdPoints";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C33 RID: 7219
		public new static readonly string MRClassNameKey = "class vtkThresholdPoints";
	}
}
