using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageNonMaximumSuppression
	/// </summary>
	/// <remarks>
	///    Performs non-maximum suppression
	///
	/// vtkImageNonMaximumSuppression Sets to zero any pixel that is not a peak.
	/// If a pixel has a neighbor along the vector that has larger magnitude, the
	/// smaller pixel is set to zero.  The filter takes two inputs: a magnitude
	/// and a vector.  Output is magnitude information and is always in doubles.
	/// Typically this filter is used with vtkImageGradient and
	/// vtkImageGradientMagnitude as inputs.
	/// </remarks>
	// Token: 0x0200024C RID: 588
	public class vtkImageNonMaximumSuppression : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006CF1 RID: 27889 RVA: 0x0009D385 File Offset: 0x0009B585
		static vtkImageNonMaximumSuppression()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageNonMaximumSuppression.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageNonMaximumSuppression"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006CF2 RID: 27890 RVA: 0x0009D3AD File Offset: 0x0009B5AD
		public vtkImageNonMaximumSuppression(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006CF3 RID: 27891
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageNonMaximumSuppression_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006CF4 RID: 27892 RVA: 0x0009D3BC File Offset: 0x0009B5BC
		public new static vtkImageNonMaximumSuppression New()
		{
			vtkImageNonMaximumSuppression result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageNonMaximumSuppression)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006CF5 RID: 27893 RVA: 0x0009D410 File Offset: 0x0009B610
		public vtkImageNonMaximumSuppression() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006CF6 RID: 27894 RVA: 0x0009D454 File Offset: 0x0009B654
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006CF7 RID: 27895
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageNonMaximumSuppression_GetDimensionality_01(HandleRef pThis);

		/// <summary>
		/// Determines how the input is interpreted (set of 2d slices or a 3D volume)
		/// </summary>
		// Token: 0x06006CF8 RID: 27896 RVA: 0x0009D460 File Offset: 0x0009B660
		public virtual int GetDimensionality()
		{
			return vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_GetDimensionality_01(base.GetCppThis());
		}

		// Token: 0x06006CF9 RID: 27897
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageNonMaximumSuppression_GetDimensionalityMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Determines how the input is interpreted (set of 2d slices or a 3D volume)
		/// </summary>
		// Token: 0x06006CFA RID: 27898 RVA: 0x0009D480 File Offset: 0x0009B680
		public virtual int GetDimensionalityMaxValue()
		{
			return vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_GetDimensionalityMaxValue_02(base.GetCppThis());
		}

		// Token: 0x06006CFB RID: 27899
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageNonMaximumSuppression_GetDimensionalityMinValue_03(HandleRef pThis);

		/// <summary>
		/// Determines how the input is interpreted (set of 2d slices or a 3D volume)
		/// </summary>
		// Token: 0x06006CFC RID: 27900 RVA: 0x0009D4A0 File Offset: 0x0009B6A0
		public virtual int GetDimensionalityMinValue()
		{
			return vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_GetDimensionalityMinValue_03(base.GetCppThis());
		}

		// Token: 0x06006CFD RID: 27901
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageNonMaximumSuppression_GetHandleBoundaries_04(HandleRef pThis);

		/// <summary>
		/// If "HandleBoundariesOn" then boundary pixels are duplicated
		/// So central differences can get values.
		/// </summary>
		// Token: 0x06006CFE RID: 27902 RVA: 0x0009D4C0 File Offset: 0x0009B6C0
		public virtual int GetHandleBoundaries()
		{
			return vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_GetHandleBoundaries_04(base.GetCppThis());
		}

		// Token: 0x06006CFF RID: 27903
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageNonMaximumSuppression_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D00 RID: 27904 RVA: 0x0009D4E0 File Offset: 0x0009B6E0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06006D01 RID: 27905
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageNonMaximumSuppression_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D02 RID: 27906 RVA: 0x0009D500 File Offset: 0x0009B700
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06006D03 RID: 27907
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageNonMaximumSuppression_HandleBoundariesOff_07(HandleRef pThis);

		/// <summary>
		/// If "HandleBoundariesOn" then boundary pixels are duplicated
		/// So central differences can get values.
		/// </summary>
		// Token: 0x06006D04 RID: 27908 RVA: 0x0009D51A File Offset: 0x0009B71A
		public virtual void HandleBoundariesOff()
		{
			vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_HandleBoundariesOff_07(base.GetCppThis());
		}

		// Token: 0x06006D05 RID: 27909
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageNonMaximumSuppression_HandleBoundariesOn_08(HandleRef pThis);

		/// <summary>
		/// If "HandleBoundariesOn" then boundary pixels are duplicated
		/// So central differences can get values.
		/// </summary>
		// Token: 0x06006D06 RID: 27910 RVA: 0x0009D529 File Offset: 0x0009B729
		public virtual void HandleBoundariesOn()
		{
			vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_HandleBoundariesOn_08(base.GetCppThis());
		}

		// Token: 0x06006D07 RID: 27911
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageNonMaximumSuppression_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D08 RID: 27912 RVA: 0x0009D538 File Offset: 0x0009B738
		public override int IsA(string type)
		{
			return vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06006D09 RID: 27913
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageNonMaximumSuppression_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D0A RID: 27914 RVA: 0x0009D558 File Offset: 0x0009B758
		public new static int IsTypeOf(string type)
		{
			return vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_IsTypeOf_10(type);
		}

		// Token: 0x06006D0B RID: 27915
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageNonMaximumSuppression_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D0C RID: 27916 RVA: 0x0009D574 File Offset: 0x0009B774
		public new vtkImageNonMaximumSuppression NewInstance()
		{
			vtkImageNonMaximumSuppression result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageNonMaximumSuppression)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006D0D RID: 27917
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageNonMaximumSuppression_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D0E RID: 27918 RVA: 0x0009D5D0 File Offset: 0x0009B7D0
		public new static vtkImageNonMaximumSuppression SafeDownCast(vtkObjectBase o)
		{
			vtkImageNonMaximumSuppression vtkImageNonMaximumSuppression = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageNonMaximumSuppression = (vtkImageNonMaximumSuppression)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageNonMaximumSuppression.Register(null);
				}
			}
			return vtkImageNonMaximumSuppression;
		}

		// Token: 0x06006D0F RID: 27919
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageNonMaximumSuppression_SetDimensionality_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Determines how the input is interpreted (set of 2d slices or a 3D volume)
		/// </summary>
		// Token: 0x06006D10 RID: 27920 RVA: 0x0009D64F File Offset: 0x0009B84F
		public virtual void SetDimensionality(int _arg)
		{
			vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_SetDimensionality_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06006D11 RID: 27921
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageNonMaximumSuppression_SetHandleBoundaries_15(HandleRef pThis, int _arg);

		/// <summary>
		/// If "HandleBoundariesOn" then boundary pixels are duplicated
		/// So central differences can get values.
		/// </summary>
		// Token: 0x06006D12 RID: 27922 RVA: 0x0009D65F File Offset: 0x0009B85F
		public virtual void SetHandleBoundaries(int _arg)
		{
			vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_SetHandleBoundaries_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06006D13 RID: 27923
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageNonMaximumSuppression_SetMagnitudeInputData_16(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set the magnitude and vector inputs.
		/// </summary>
		// Token: 0x06006D14 RID: 27924 RVA: 0x0009D670 File Offset: 0x0009B870
		public void SetMagnitudeInputData(vtkImageData input)
		{
			vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_SetMagnitudeInputData_16(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06006D15 RID: 27925
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageNonMaximumSuppression_SetVectorInputData_17(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set the magnitude and vector inputs.
		/// </summary>
		// Token: 0x06006D16 RID: 27926 RVA: 0x0009D6A0 File Offset: 0x0009B8A0
		public void SetVectorInputData(vtkImageData input)
		{
			vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_SetVectorInputData_17(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400098D RID: 2445
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageNonMaximumSuppression";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400098E RID: 2446
		public new static readonly string MRClassNameKey = "class vtkImageNonMaximumSuppression";
	}
}
