using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSpatioTemporalHarmonicsSource
	/// </summary>
	/// <remarks>
	///    Creates a vtkImageData with harmonics data.
	///
	/// vtkSpatioTemporalHarmonicsSource creates a vtkImageData source
	/// that will have harmonics data on its points. It simply applies
	/// a vtkSpatioTemporalHarmonicsAttributes on the generated image.
	/// It also allows generation of time steps.
	///
	/// Note that default harmonics and time step values are set for
	/// common usage. Make sure to clear them before adding your own
	/// values.
	///
	/// </remarks>
	/// <seealso>
	///  vtkImageData vtkSpatioTemporalHarmonicsAttribute
	/// </seealso>
	// Token: 0x02000843 RID: 2115
	public class vtkSpatioTemporalHarmonicsSource : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015E94 RID: 89748 RVA: 0x001EE144 File Offset: 0x001EC344
		static vtkSpatioTemporalHarmonicsSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSpatioTemporalHarmonicsSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpatioTemporalHarmonicsSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015E95 RID: 89749 RVA: 0x001EE16C File Offset: 0x001EC36C
		public vtkSpatioTemporalHarmonicsSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015E96 RID: 89750
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpatioTemporalHarmonicsSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015E97 RID: 89751 RVA: 0x001EE17C File Offset: 0x001EC37C
		public new static vtkSpatioTemporalHarmonicsSource New()
		{
			vtkSpatioTemporalHarmonicsSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpatioTemporalHarmonicsSource.vtkSpatioTemporalHarmonicsSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpatioTemporalHarmonicsSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015E98 RID: 89752 RVA: 0x001EE1D0 File Offset: 0x001EC3D0
		public vtkSpatioTemporalHarmonicsSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSpatioTemporalHarmonicsSource.vtkSpatioTemporalHarmonicsSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015E99 RID: 89753 RVA: 0x001EE214 File Offset: 0x001EC414
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015E9A RID: 89754
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpatioTemporalHarmonicsSource_AddHarmonic_01(HandleRef pThis, double amplitude, double temporalFrequency, double xWaveVector, double yWaveVector, double zWaveVector, double phase);

		/// <summary>
		/// Add an harmonic with all needed parameters.
		/// You may want to remove default harmonics first.
		/// </summary>
		// Token: 0x06015E9B RID: 89755 RVA: 0x001EE21F File Offset: 0x001EC41F
		public void AddHarmonic(double amplitude, double temporalFrequency, double xWaveVector, double yWaveVector, double zWaveVector, double phase)
		{
			vtkSpatioTemporalHarmonicsSource.vtkSpatioTemporalHarmonicsSource_AddHarmonic_01(base.GetCppThis(), amplitude, temporalFrequency, xWaveVector, yWaveVector, zWaveVector, phase);
		}

		// Token: 0x06015E9C RID: 89756
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpatioTemporalHarmonicsSource_AddTimeStepValue_02(HandleRef pThis, double timeStepValue);

		/// <summary>
		/// Add a time step value.
		/// You may want to remove default values first.
		/// </summary>
		// Token: 0x06015E9D RID: 89757 RVA: 0x001EE237 File Offset: 0x001EC437
		public void AddTimeStepValue(double timeStepValue)
		{
			vtkSpatioTemporalHarmonicsSource.vtkSpatioTemporalHarmonicsSource_AddTimeStepValue_02(base.GetCppThis(), timeStepValue);
		}

		// Token: 0x06015E9E RID: 89758
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpatioTemporalHarmonicsSource_ClearHarmonics_03(HandleRef pThis);

		/// <summary>
		/// Clear all harmonics.
		/// </summary>
		// Token: 0x06015E9F RID: 89759 RVA: 0x001EE247 File Offset: 0x001EC447
		public void ClearHarmonics()
		{
			vtkSpatioTemporalHarmonicsSource.vtkSpatioTemporalHarmonicsSource_ClearHarmonics_03(base.GetCppThis());
		}

		// Token: 0x06015EA0 RID: 89760
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpatioTemporalHarmonicsSource_ClearTimeStepValues_04(HandleRef pThis);

		/// <summary>
		/// Clear time step values.
		/// </summary>
		// Token: 0x06015EA1 RID: 89761 RVA: 0x001EE256 File Offset: 0x001EC456
		public void ClearTimeStepValues()
		{
			vtkSpatioTemporalHarmonicsSource.vtkSpatioTemporalHarmonicsSource_ClearTimeStepValues_04(base.GetCppThis());
		}

		// Token: 0x06015EA2 RID: 89762
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpatioTemporalHarmonicsSource_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015EA3 RID: 89763 RVA: 0x001EE268 File Offset: 0x001EC468
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSpatioTemporalHarmonicsSource.vtkSpatioTemporalHarmonicsSource_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06015EA4 RID: 89764
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpatioTemporalHarmonicsSource_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015EA5 RID: 89765 RVA: 0x001EE288 File Offset: 0x001EC488
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSpatioTemporalHarmonicsSource.vtkSpatioTemporalHarmonicsSource_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06015EA6 RID: 89766
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpatioTemporalHarmonicsSource_GetWholeExtent_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the image extent.
		/// Default is (-10, 10, -10, 10, -10, 10).
		/// </summary>
		// Token: 0x06015EA7 RID: 89767 RVA: 0x001EE2A4 File Offset: 0x001EC4A4
		public virtual int[] GetWholeExtent()
		{
			IntPtr intPtr = vtkSpatioTemporalHarmonicsSource.vtkSpatioTemporalHarmonicsSource_GetWholeExtent_07(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015EA8 RID: 89768
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpatioTemporalHarmonicsSource_GetWholeExtent_08(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Set/Get the image extent.
		/// Default is (-10, 10, -10, 10, -10, 10).
		/// </summary>
		// Token: 0x06015EA9 RID: 89769 RVA: 0x001EE2EC File Offset: 0x001EC4EC
		public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkSpatioTemporalHarmonicsSource.vtkSpatioTemporalHarmonicsSource_GetWholeExtent_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x06015EAA RID: 89770
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpatioTemporalHarmonicsSource_GetWholeExtent_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the image extent.
		/// Default is (-10, 10, -10, 10, -10, 10).
		/// </summary>
		// Token: 0x06015EAB RID: 89771 RVA: 0x001EE304 File Offset: 0x001EC504
		public virtual void GetWholeExtent(IntPtr _arg)
		{
			vtkSpatioTemporalHarmonicsSource.vtkSpatioTemporalHarmonicsSource_GetWholeExtent_09(base.GetCppThis(), _arg);
		}

		// Token: 0x06015EAC RID: 89772
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpatioTemporalHarmonicsSource_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015EAD RID: 89773 RVA: 0x001EE314 File Offset: 0x001EC514
		public override int IsA(string type)
		{
			return vtkSpatioTemporalHarmonicsSource.vtkSpatioTemporalHarmonicsSource_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06015EAE RID: 89774
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpatioTemporalHarmonicsSource_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015EAF RID: 89775 RVA: 0x001EE334 File Offset: 0x001EC534
		public new static int IsTypeOf(string type)
		{
			return vtkSpatioTemporalHarmonicsSource.vtkSpatioTemporalHarmonicsSource_IsTypeOf_11(type);
		}

		// Token: 0x06015EB0 RID: 89776
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpatioTemporalHarmonicsSource_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015EB1 RID: 89777 RVA: 0x001EE350 File Offset: 0x001EC550
		public new vtkSpatioTemporalHarmonicsSource NewInstance()
		{
			vtkSpatioTemporalHarmonicsSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpatioTemporalHarmonicsSource.vtkSpatioTemporalHarmonicsSource_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpatioTemporalHarmonicsSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015EB2 RID: 89778
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpatioTemporalHarmonicsSource_ResetHarmonics_14(HandleRef pThis);

		/// <summary>
		/// Reset harmonics to default.
		/// By default, the source has harmonics in each direction, with phase shifts and different
		/// frequencies. The default wave vector is scaled to match default extent.
		/// </summary>
		// Token: 0x06015EB3 RID: 89779 RVA: 0x001EE3AA File Offset: 0x001EC5AA
		public void ResetHarmonics()
		{
			vtkSpatioTemporalHarmonicsSource.vtkSpatioTemporalHarmonicsSource_ResetHarmonics_14(base.GetCppThis());
		}

		// Token: 0x06015EB4 RID: 89780
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpatioTemporalHarmonicsSource_ResetTimeStepValues_15(HandleRef pThis);

		/// <summary>
		/// Reset time step values to default.
		/// By default, the source has 20 time steps ranging from 0 to 2*PI.
		/// The default values allows an infinite loop of default harmonics.
		/// </summary>
		// Token: 0x06015EB5 RID: 89781 RVA: 0x001EE3B9 File Offset: 0x001EC5B9
		public void ResetTimeStepValues()
		{
			vtkSpatioTemporalHarmonicsSource.vtkSpatioTemporalHarmonicsSource_ResetTimeStepValues_15(base.GetCppThis());
		}

		// Token: 0x06015EB6 RID: 89782
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpatioTemporalHarmonicsSource_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015EB7 RID: 89783 RVA: 0x001EE3C8 File Offset: 0x001EC5C8
		public new static vtkSpatioTemporalHarmonicsSource SafeDownCast(vtkObjectBase o)
		{
			vtkSpatioTemporalHarmonicsSource vtkSpatioTemporalHarmonicsSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpatioTemporalHarmonicsSource.vtkSpatioTemporalHarmonicsSource_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpatioTemporalHarmonicsSource = (vtkSpatioTemporalHarmonicsSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpatioTemporalHarmonicsSource.Register(null);
				}
			}
			return vtkSpatioTemporalHarmonicsSource;
		}

		// Token: 0x06015EB8 RID: 89784
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpatioTemporalHarmonicsSource_SetWholeExtent_17(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Set/Get the image extent.
		/// Default is (-10, 10, -10, 10, -10, 10).
		/// </summary>
		// Token: 0x06015EB9 RID: 89785 RVA: 0x001EE447 File Offset: 0x001EC647
		public virtual void SetWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkSpatioTemporalHarmonicsSource.vtkSpatioTemporalHarmonicsSource_SetWholeExtent_17(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06015EBA RID: 89786
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpatioTemporalHarmonicsSource_SetWholeExtent_18(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the image extent.
		/// Default is (-10, 10, -10, 10, -10, 10).
		/// </summary>
		// Token: 0x06015EBB RID: 89787 RVA: 0x001EE45F File Offset: 0x001EC65F
		public virtual void SetWholeExtent(IntPtr _arg)
		{
			vtkSpatioTemporalHarmonicsSource.vtkSpatioTemporalHarmonicsSource_SetWholeExtent_18(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018DA RID: 6362
		public new const string MRFullTypeName = "Kitware.VTK.vtkSpatioTemporalHarmonicsSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018DB RID: 6363
		public new static readonly string MRClassNameKey = "class vtkSpatioTemporalHarmonicsSource";
	}
}
