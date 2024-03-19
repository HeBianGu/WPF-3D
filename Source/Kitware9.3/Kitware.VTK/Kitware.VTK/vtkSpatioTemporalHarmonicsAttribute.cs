using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSpatioTemporalHarmonicsAttribute
	/// </summary>
	/// <remarks>
	///    Computes spatio-temporal harmonics on each point.
	///
	/// vtkSpatioTemporalHarmonicsAttribute is a filter that adds a
	/// data array storing spatio-temporal harmonics defined by the
	/// filter. Those harmonics are defined by their amplitude,
	/// temporal frequency, wave vector, and phase, with only a
	/// sinus function (no cosinus).
	///
	/// Note that the data array generated is a vtkDoubleArray that
	/// is set as the output SCALARS attribute.
	///
	/// </remarks>
	/// <seealso>
	///  vtkSpatioTemporalHarmonicsSource
	/// </seealso>
	// Token: 0x020008DF RID: 2271
	public class vtkSpatioTemporalHarmonicsAttribute : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601776B RID: 96107 RVA: 0x0020EC07 File Offset: 0x0020CE07
		static vtkSpatioTemporalHarmonicsAttribute()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSpatioTemporalHarmonicsAttribute.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpatioTemporalHarmonicsAttribute"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601776C RID: 96108 RVA: 0x0020EC2F File Offset: 0x0020CE2F
		public vtkSpatioTemporalHarmonicsAttribute(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601776D RID: 96109
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpatioTemporalHarmonicsAttribute_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601776E RID: 96110 RVA: 0x0020EC40 File Offset: 0x0020CE40
		public new static vtkSpatioTemporalHarmonicsAttribute New()
		{
			vtkSpatioTemporalHarmonicsAttribute result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpatioTemporalHarmonicsAttribute.vtkSpatioTemporalHarmonicsAttribute_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpatioTemporalHarmonicsAttribute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601776F RID: 96111 RVA: 0x0020EC94 File Offset: 0x0020CE94
		public vtkSpatioTemporalHarmonicsAttribute() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSpatioTemporalHarmonicsAttribute.vtkSpatioTemporalHarmonicsAttribute_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017770 RID: 96112 RVA: 0x0020ECD8 File Offset: 0x0020CED8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017771 RID: 96113
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpatioTemporalHarmonicsAttribute_AddHarmonic_01(HandleRef pThis, double amplitude, double temporalFrequency, double xWaveVector, double yWaveVector, double zWaveVector, double phase);

		/// <summary>
		/// Add an harmonic with all needed parameters.
		/// </summary>
		// Token: 0x06017772 RID: 96114 RVA: 0x0020ECE3 File Offset: 0x0020CEE3
		public void AddHarmonic(double amplitude, double temporalFrequency, double xWaveVector, double yWaveVector, double zWaveVector, double phase)
		{
			vtkSpatioTemporalHarmonicsAttribute.vtkSpatioTemporalHarmonicsAttribute_AddHarmonic_01(base.GetCppThis(), amplitude, temporalFrequency, xWaveVector, yWaveVector, zWaveVector, phase);
		}

		// Token: 0x06017773 RID: 96115
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpatioTemporalHarmonicsAttribute_ClearHarmonics_02(HandleRef pThis);

		/// <summary>
		/// Clear all harmonics.
		/// </summary>
		// Token: 0x06017774 RID: 96116 RVA: 0x0020ECFB File Offset: 0x0020CEFB
		public void ClearHarmonics()
		{
			vtkSpatioTemporalHarmonicsAttribute.vtkSpatioTemporalHarmonicsAttribute_ClearHarmonics_02(base.GetCppThis());
		}

		// Token: 0x06017775 RID: 96117
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSpatioTemporalHarmonicsAttribute_ComputeValue_03(HandleRef pThis, IntPtr coords, double time);

		/// <summary>
		/// Compute spatio-temporal harmonic using filter-defined harmonics.
		/// </summary>
		// Token: 0x06017776 RID: 96118 RVA: 0x0020ED0C File Offset: 0x0020CF0C
		public double ComputeValue(IntPtr coords, double time)
		{
			return vtkSpatioTemporalHarmonicsAttribute.vtkSpatioTemporalHarmonicsAttribute_ComputeValue_03(base.GetCppThis(), coords, time);
		}

		// Token: 0x06017777 RID: 96119
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpatioTemporalHarmonicsAttribute_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017778 RID: 96120 RVA: 0x0020ED30 File Offset: 0x0020CF30
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSpatioTemporalHarmonicsAttribute.vtkSpatioTemporalHarmonicsAttribute_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06017779 RID: 96121
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpatioTemporalHarmonicsAttribute_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601777A RID: 96122 RVA: 0x0020ED50 File Offset: 0x0020CF50
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSpatioTemporalHarmonicsAttribute.vtkSpatioTemporalHarmonicsAttribute_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601777B RID: 96123
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSpatioTemporalHarmonicsAttribute_HasHarmonics_06(HandleRef pThis);

		/// <summary>
		/// Whether the filter has harmonics set, or is empty.
		/// </summary>
		// Token: 0x0601777C RID: 96124 RVA: 0x0020ED6C File Offset: 0x0020CF6C
		public bool HasHarmonics()
		{
			return vtkSpatioTemporalHarmonicsAttribute.vtkSpatioTemporalHarmonicsAttribute_HasHarmonics_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0601777D RID: 96125
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpatioTemporalHarmonicsAttribute_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601777E RID: 96126 RVA: 0x0020ED94 File Offset: 0x0020CF94
		public override int IsA(string type)
		{
			return vtkSpatioTemporalHarmonicsAttribute.vtkSpatioTemporalHarmonicsAttribute_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601777F RID: 96127
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpatioTemporalHarmonicsAttribute_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017780 RID: 96128 RVA: 0x0020EDB4 File Offset: 0x0020CFB4
		public new static int IsTypeOf(string type)
		{
			return vtkSpatioTemporalHarmonicsAttribute.vtkSpatioTemporalHarmonicsAttribute_IsTypeOf_08(type);
		}

		// Token: 0x06017781 RID: 96129
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpatioTemporalHarmonicsAttribute_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017782 RID: 96130 RVA: 0x0020EDD0 File Offset: 0x0020CFD0
		public new vtkSpatioTemporalHarmonicsAttribute NewInstance()
		{
			vtkSpatioTemporalHarmonicsAttribute result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpatioTemporalHarmonicsAttribute.vtkSpatioTemporalHarmonicsAttribute_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpatioTemporalHarmonicsAttribute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017783 RID: 96131
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpatioTemporalHarmonicsAttribute_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017784 RID: 96132 RVA: 0x0020EE2C File Offset: 0x0020D02C
		public new static vtkSpatioTemporalHarmonicsAttribute SafeDownCast(vtkObjectBase o)
		{
			vtkSpatioTemporalHarmonicsAttribute vtkSpatioTemporalHarmonicsAttribute = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpatioTemporalHarmonicsAttribute.vtkSpatioTemporalHarmonicsAttribute_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpatioTemporalHarmonicsAttribute = (vtkSpatioTemporalHarmonicsAttribute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpatioTemporalHarmonicsAttribute.Register(null);
				}
			}
			return vtkSpatioTemporalHarmonicsAttribute;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A33 RID: 6707
		public new const string MRFullTypeName = "Kitware.VTK.vtkSpatioTemporalHarmonicsAttribute";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A34 RID: 6708
		public new static readonly string MRClassNameKey = "class vtkSpatioTemporalHarmonicsAttribute";
	}
}
