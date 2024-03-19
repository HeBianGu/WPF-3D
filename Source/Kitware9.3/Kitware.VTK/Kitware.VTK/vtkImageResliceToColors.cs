using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageResliceToColors
	/// </summary>
	/// <remarks>
	///    Reslice and produce color scalars.
	///
	/// vtkImageResliceToColors is an extension of vtkImageReslice that
	/// produces color scalars.  It should be provided with a lookup table
	/// that defines the output colors and the desired range of input values
	/// to map to those colors.  If the input has multiple components, then
	/// you should use the SetVectorMode() method of the lookup table to
	/// specify how the vectors will be colored.  If no lookup table is
	/// provided, then the input must already be color scalars, but they
	/// will be converted to the specified output format.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageMapToColors
	/// </seealso>
	// Token: 0x02000864 RID: 2148
	public class vtkImageResliceToColors : vtkImageReslice
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601642E RID: 91182 RVA: 0x001F550A File Offset: 0x001F370A
		static vtkImageResliceToColors()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageResliceToColors.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageResliceToColors"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601642F RID: 91183 RVA: 0x001F5532 File Offset: 0x001F3732
		public vtkImageResliceToColors(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016430 RID: 91184
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResliceToColors_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016431 RID: 91185 RVA: 0x001F5540 File Offset: 0x001F3740
		public new static vtkImageResliceToColors New()
		{
			vtkImageResliceToColors result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageResliceToColors.vtkImageResliceToColors_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageResliceToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016432 RID: 91186 RVA: 0x001F5594 File Offset: 0x001F3794
		public vtkImageResliceToColors() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageResliceToColors.vtkImageResliceToColors_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016433 RID: 91187 RVA: 0x001F55D8 File Offset: 0x001F37D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016434 RID: 91188
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceToColors_BypassOff_01(HandleRef pThis);

		/// <summary>
		/// Bypass the color mapping operation and output the scalar
		/// values directly.  The output values will be float, rather
		/// than the input data type.
		/// </summary>
		// Token: 0x06016435 RID: 91189 RVA: 0x001F55E3 File Offset: 0x001F37E3
		public void BypassOff()
		{
			vtkImageResliceToColors.vtkImageResliceToColors_BypassOff_01(base.GetCppThis());
		}

		// Token: 0x06016436 RID: 91190
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceToColors_BypassOn_02(HandleRef pThis);

		/// <summary>
		/// Bypass the color mapping operation and output the scalar
		/// values directly.  The output values will be float, rather
		/// than the input data type.
		/// </summary>
		// Token: 0x06016437 RID: 91191 RVA: 0x001F55F2 File Offset: 0x001F37F2
		public void BypassOn()
		{
			vtkImageResliceToColors.vtkImageResliceToColors_BypassOn_02(base.GetCppThis());
		}

		// Token: 0x06016438 RID: 91192
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResliceToColors_GetBypass_03(HandleRef pThis);

		/// <summary>
		/// Bypass the color mapping operation and output the scalar
		/// values directly.  The output values will be float, rather
		/// than the input data type.
		/// </summary>
		// Token: 0x06016439 RID: 91193 RVA: 0x001F5604 File Offset: 0x001F3804
		public int GetBypass()
		{
			return vtkImageResliceToColors.vtkImageResliceToColors_GetBypass_03(base.GetCppThis());
		}

		// Token: 0x0601643A RID: 91194
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResliceToColors_GetLookupTable_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set a lookup table to apply to the data.  Use the Range,
		/// VectorMode, and VectorComponents of the table to control
		/// the mapping of the input data to colors.  If any output
		/// voxel is transformed to a point outside the input volume,
		/// then that voxel will be set to the BackgroundColor.
		/// </summary>
		// Token: 0x0601643B RID: 91195 RVA: 0x001F5624 File Offset: 0x001F3824
		public virtual vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageResliceToColors.vtkImageResliceToColors_GetLookupTable_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		// Token: 0x0601643C RID: 91196
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImageResliceToColors_GetMTime_05(HandleRef pThis);

		/// <summary>
		/// When determining the modified time of the filter,
		/// this checks the modified time of the transform and matrix.
		/// </summary>
		// Token: 0x0601643D RID: 91197 RVA: 0x001F5694 File Offset: 0x001F3894
		public override ulong GetMTime()
		{
			return vtkImageResliceToColors.vtkImageResliceToColors_GetMTime_05(base.GetCppThis());
		}

		// Token: 0x0601643E RID: 91198
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageResliceToColors_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601643F RID: 91199 RVA: 0x001F56B4 File Offset: 0x001F38B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageResliceToColors.vtkImageResliceToColors_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06016440 RID: 91200
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageResliceToColors_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016441 RID: 91201 RVA: 0x001F56D4 File Offset: 0x001F38D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageResliceToColors.vtkImageResliceToColors_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06016442 RID: 91202
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResliceToColors_GetOutputFormat_08(HandleRef pThis);

		/// <summary>
		/// Set the output format, the default is RGBA.
		/// </summary>
		// Token: 0x06016443 RID: 91203 RVA: 0x001F56F0 File Offset: 0x001F38F0
		public virtual int GetOutputFormat()
		{
			return vtkImageResliceToColors.vtkImageResliceToColors_GetOutputFormat_08(base.GetCppThis());
		}

		// Token: 0x06016444 RID: 91204
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResliceToColors_GetOutputFormatMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Set the output format, the default is RGBA.
		/// </summary>
		// Token: 0x06016445 RID: 91205 RVA: 0x001F5710 File Offset: 0x001F3910
		public virtual int GetOutputFormatMaxValue()
		{
			return vtkImageResliceToColors.vtkImageResliceToColors_GetOutputFormatMaxValue_09(base.GetCppThis());
		}

		// Token: 0x06016446 RID: 91206
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResliceToColors_GetOutputFormatMinValue_10(HandleRef pThis);

		/// <summary>
		/// Set the output format, the default is RGBA.
		/// </summary>
		// Token: 0x06016447 RID: 91207 RVA: 0x001F5730 File Offset: 0x001F3930
		public virtual int GetOutputFormatMinValue()
		{
			return vtkImageResliceToColors.vtkImageResliceToColors_GetOutputFormatMinValue_10(base.GetCppThis());
		}

		// Token: 0x06016448 RID: 91208
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResliceToColors_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016449 RID: 91209 RVA: 0x001F5750 File Offset: 0x001F3950
		public override int IsA(string type)
		{
			return vtkImageResliceToColors.vtkImageResliceToColors_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0601644A RID: 91210
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResliceToColors_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601644B RID: 91211 RVA: 0x001F5770 File Offset: 0x001F3970
		public new static int IsTypeOf(string type)
		{
			return vtkImageResliceToColors.vtkImageResliceToColors_IsTypeOf_12(type);
		}

		// Token: 0x0601644C RID: 91212
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResliceToColors_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601644D RID: 91213 RVA: 0x001F578C File Offset: 0x001F398C
		public new vtkImageResliceToColors NewInstance()
		{
			vtkImageResliceToColors result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageResliceToColors.vtkImageResliceToColors_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageResliceToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601644E RID: 91214
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResliceToColors_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601644F RID: 91215 RVA: 0x001F57E8 File Offset: 0x001F39E8
		public new static vtkImageResliceToColors SafeDownCast(vtkObjectBase o)
		{
			vtkImageResliceToColors vtkImageResliceToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageResliceToColors.vtkImageResliceToColors_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageResliceToColors = (vtkImageResliceToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageResliceToColors.Register(null);
				}
			}
			return vtkImageResliceToColors;
		}

		// Token: 0x06016450 RID: 91216
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceToColors_SetBypass_16(HandleRef pThis, int bypass);

		/// <summary>
		/// Bypass the color mapping operation and output the scalar
		/// values directly.  The output values will be float, rather
		/// than the input data type.
		/// </summary>
		// Token: 0x06016451 RID: 91217 RVA: 0x001F5867 File Offset: 0x001F3A67
		public void SetBypass(int bypass)
		{
			vtkImageResliceToColors.vtkImageResliceToColors_SetBypass_16(base.GetCppThis(), bypass);
		}

		// Token: 0x06016452 RID: 91218
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceToColors_SetLookupTable_17(HandleRef pThis, HandleRef table);

		/// <summary>
		/// Set a lookup table to apply to the data.  Use the Range,
		/// VectorMode, and VectorComponents of the table to control
		/// the mapping of the input data to colors.  If any output
		/// voxel is transformed to a point outside the input volume,
		/// then that voxel will be set to the BackgroundColor.
		/// </summary>
		// Token: 0x06016453 RID: 91219 RVA: 0x001F5878 File Offset: 0x001F3A78
		public virtual void SetLookupTable(vtkScalarsToColors table)
		{
			vtkImageResliceToColors.vtkImageResliceToColors_SetLookupTable_17(base.GetCppThis(), (table == null) ? default(HandleRef) : table.GetCppThis());
		}

		// Token: 0x06016454 RID: 91220
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceToColors_SetOutputFormat_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the output format, the default is RGBA.
		/// </summary>
		// Token: 0x06016455 RID: 91221 RVA: 0x001F58A7 File Offset: 0x001F3AA7
		public virtual void SetOutputFormat(int _arg)
		{
			vtkImageResliceToColors.vtkImageResliceToColors_SetOutputFormat_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06016456 RID: 91222
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceToColors_SetOutputFormatToLuminance_19(HandleRef pThis);

		/// <summary>
		/// Set the output format, the default is RGBA.
		/// </summary>
		// Token: 0x06016457 RID: 91223 RVA: 0x001F58B7 File Offset: 0x001F3AB7
		public void SetOutputFormatToLuminance()
		{
			vtkImageResliceToColors.vtkImageResliceToColors_SetOutputFormatToLuminance_19(base.GetCppThis());
		}

		// Token: 0x06016458 RID: 91224
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceToColors_SetOutputFormatToLuminanceAlpha_20(HandleRef pThis);

		/// <summary>
		/// Set the output format, the default is RGBA.
		/// </summary>
		// Token: 0x06016459 RID: 91225 RVA: 0x001F58C6 File Offset: 0x001F3AC6
		public void SetOutputFormatToLuminanceAlpha()
		{
			vtkImageResliceToColors.vtkImageResliceToColors_SetOutputFormatToLuminanceAlpha_20(base.GetCppThis());
		}

		// Token: 0x0601645A RID: 91226
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceToColors_SetOutputFormatToRGB_21(HandleRef pThis);

		/// <summary>
		/// Set the output format, the default is RGBA.
		/// </summary>
		// Token: 0x0601645B RID: 91227 RVA: 0x001F58D5 File Offset: 0x001F3AD5
		public void SetOutputFormatToRGB()
		{
			vtkImageResliceToColors.vtkImageResliceToColors_SetOutputFormatToRGB_21(base.GetCppThis());
		}

		// Token: 0x0601645C RID: 91228
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceToColors_SetOutputFormatToRGBA_22(HandleRef pThis);

		/// <summary>
		/// Set the output format, the default is RGBA.
		/// </summary>
		// Token: 0x0601645D RID: 91229 RVA: 0x001F58E4 File Offset: 0x001F3AE4
		public void SetOutputFormatToRGBA()
		{
			vtkImageResliceToColors.vtkImageResliceToColors_SetOutputFormatToRGBA_22(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400191E RID: 6430
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageResliceToColors";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400191F RID: 6431
		public new static readonly string MRClassNameKey = "class vtkImageResliceToColors";
	}
}
