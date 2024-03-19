using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkEqualizerFilter
	/// </summary>
	/// <remarks>
	///  implements an algorithm for digital signal processing
	///
	/// The vtkEqualizerFilter implements an algorithm that selectively corrects the signal amplitude
	/// depending on the frequency characteristics.
	/// </remarks>
	// Token: 0x0200089B RID: 2203
	public class vtkEqualizerFilter : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016E17 RID: 93719 RVA: 0x002026FB File Offset: 0x002008FB
		static vtkEqualizerFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEqualizerFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEqualizerFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016E18 RID: 93720 RVA: 0x00202723 File Offset: 0x00200923
		public vtkEqualizerFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016E19 RID: 93721
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEqualizerFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E1A RID: 93722 RVA: 0x00202734 File Offset: 0x00200934
		public new static vtkEqualizerFilter New()
		{
			vtkEqualizerFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEqualizerFilter.vtkEqualizerFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEqualizerFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E1B RID: 93723 RVA: 0x00202788 File Offset: 0x00200988
		public vtkEqualizerFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEqualizerFilter.vtkEqualizerFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016E1C RID: 93724 RVA: 0x002027CC File Offset: 0x002009CC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016E1D RID: 93725
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkEqualizerFilter_GetAllColumns_01(HandleRef pThis);

		/// <summary>
		/// Set / Get a flag to process all columns of the table.
		/// If set to true, all columns of the table will be used. The "SetArray()" method will have no
		/// effect.
		/// Default value is: false
		/// </summary>
		// Token: 0x06016E1E RID: 93726 RVA: 0x002027D8 File Offset: 0x002009D8
		public virtual bool GetAllColumns()
		{
			return vtkEqualizerFilter.vtkEqualizerFilter_GetAllColumns_01(base.GetCppThis()) != 0;
		}

		// Token: 0x06016E1F RID: 93727
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEqualizerFilter_GetArray_02(HandleRef pThis);

		/// <summary>
		/// Set / Get the name of the column from which the data array is taken
		/// </summary>
		// Token: 0x06016E20 RID: 93728 RVA: 0x00202800 File Offset: 0x00200A00
		public virtual string GetArray()
		{
			string s = Marshal.PtrToStringAnsi(vtkEqualizerFilter.vtkEqualizerFilter_GetArray_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06016E21 RID: 93729
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEqualizerFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E22 RID: 93730 RVA: 0x0020283C File Offset: 0x00200A3C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEqualizerFilter.vtkEqualizerFilter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06016E23 RID: 93731
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEqualizerFilter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E24 RID: 93732 RVA: 0x0020285C File Offset: 0x00200A5C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEqualizerFilter.vtkEqualizerFilter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06016E25 RID: 93733
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkEqualizerFilter_GetPoints_05(HandleRef pThis);

		/// <summary>
		/// Set / Get anchor points in the following format
		/// "P1x,P1y;P2x,P2y; ... PNx,PNy;"
		/// Default value is an empty string
		/// </summary>
		// Token: 0x06016E26 RID: 93734 RVA: 0x00202878 File Offset: 0x00200A78
		public string GetPoints()
		{
			return vtkEqualizerFilter.vtkEqualizerFilter_GetPoints_05(base.GetCppThis());
		}

		// Token: 0x06016E27 RID: 93735
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEqualizerFilter_GetSamplingFrequency_06(HandleRef pThis);

		/// <summary>
		/// Set / Get the sampling frequency of the original signal in Hz
		/// Default value is: 1000
		/// </summary>
		// Token: 0x06016E28 RID: 93736 RVA: 0x00202898 File Offset: 0x00200A98
		public virtual int GetSamplingFrequency()
		{
			return vtkEqualizerFilter.vtkEqualizerFilter_GetSamplingFrequency_06(base.GetCppThis());
		}

		// Token: 0x06016E29 RID: 93737
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEqualizerFilter_GetSpectrumGain_07(HandleRef pThis);

		/// <summary>
		/// Set / Get the spectrum gain in dB
		/// Default value is: 0
		/// </summary>
		// Token: 0x06016E2A RID: 93738 RVA: 0x002028B8 File Offset: 0x00200AB8
		public virtual int GetSpectrumGain()
		{
			return vtkEqualizerFilter.vtkEqualizerFilter_GetSpectrumGain_07(base.GetCppThis());
		}

		// Token: 0x06016E2B RID: 93739
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEqualizerFilter_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E2C RID: 93740 RVA: 0x002028D8 File Offset: 0x00200AD8
		public override int IsA(string type)
		{
			return vtkEqualizerFilter.vtkEqualizerFilter_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06016E2D RID: 93741
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEqualizerFilter_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E2E RID: 93742 RVA: 0x002028F8 File Offset: 0x00200AF8
		public new static int IsTypeOf(string type)
		{
			return vtkEqualizerFilter.vtkEqualizerFilter_IsTypeOf_09(type);
		}

		// Token: 0x06016E2F RID: 93743
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEqualizerFilter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E30 RID: 93744 RVA: 0x00202914 File Offset: 0x00200B14
		public new vtkEqualizerFilter NewInstance()
		{
			vtkEqualizerFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEqualizerFilter.vtkEqualizerFilter_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEqualizerFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016E31 RID: 93745
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEqualizerFilter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E32 RID: 93746 RVA: 0x00202970 File Offset: 0x00200B70
		public new static vtkEqualizerFilter SafeDownCast(vtkObjectBase o)
		{
			vtkEqualizerFilter vtkEqualizerFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEqualizerFilter.vtkEqualizerFilter_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEqualizerFilter = (vtkEqualizerFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEqualizerFilter.Register(null);
				}
			}
			return vtkEqualizerFilter;
		}

		// Token: 0x06016E33 RID: 93747
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEqualizerFilter_SetAllColumns_13(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set / Get a flag to process all columns of the table.
		/// If set to true, all columns of the table will be used. The "SetArray()" method will have no
		/// effect.
		/// Default value is: false
		/// </summary>
		// Token: 0x06016E34 RID: 93748 RVA: 0x002029EF File Offset: 0x00200BEF
		public virtual void SetAllColumns(bool _arg)
		{
			vtkEqualizerFilter.vtkEqualizerFilter_SetAllColumns_13(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06016E35 RID: 93749
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEqualizerFilter_SetArray_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Set / Get the name of the column from which the data array is taken
		/// </summary>
		// Token: 0x06016E36 RID: 93750 RVA: 0x00202A07 File Offset: 0x00200C07
		public virtual void SetArray(string arg)
		{
			vtkEqualizerFilter.vtkEqualizerFilter_SetArray_14(base.GetCppThis(), arg);
		}

		// Token: 0x06016E37 RID: 93751
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEqualizerFilter_SetPoints_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string points);

		/// <summary>
		/// Set / Get anchor points in the following format
		/// "P1x,P1y;P2x,P2y; ... PNx,PNy;"
		/// Default value is an empty string
		/// </summary>
		// Token: 0x06016E38 RID: 93752 RVA: 0x00202A17 File Offset: 0x00200C17
		public void SetPoints(string points)
		{
			vtkEqualizerFilter.vtkEqualizerFilter_SetPoints_15(base.GetCppThis(), points);
		}

		// Token: 0x06016E39 RID: 93753
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEqualizerFilter_SetSamplingFrequency_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Set / Get the sampling frequency of the original signal in Hz
		/// Default value is: 1000
		/// </summary>
		// Token: 0x06016E3A RID: 93754 RVA: 0x00202A27 File Offset: 0x00200C27
		public virtual void SetSamplingFrequency(int _arg)
		{
			vtkEqualizerFilter.vtkEqualizerFilter_SetSamplingFrequency_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06016E3B RID: 93755
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEqualizerFilter_SetSpectrumGain_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Set / Get the spectrum gain in dB
		/// Default value is: 0
		/// </summary>
		// Token: 0x06016E3C RID: 93756 RVA: 0x00202A37 File Offset: 0x00200C37
		public virtual void SetSpectrumGain(int _arg)
		{
			vtkEqualizerFilter.vtkEqualizerFilter_SetSpectrumGain_17(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001997 RID: 6551
		public new const string MRFullTypeName = "Kitware.VTK.vtkEqualizerFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001998 RID: 6552
		public new static readonly string MRClassNameKey = "class vtkEqualizerFilter";
	}
}
