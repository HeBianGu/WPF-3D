using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageThreshold
	/// </summary>
	/// <remarks>
	///     Flexible threshold
	///
	/// vtkImageThreshold can do binary or continuous thresholding for lower, upper
	/// or a range of data.  The output data type may be different than the
	/// output, but defaults to the same type.
	/// </remarks>
	// Token: 0x02000869 RID: 2153
	public class vtkImageThreshold : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601659A RID: 91546 RVA: 0x001F6E27 File Offset: 0x001F5027
		static vtkImageThreshold()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageThreshold.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageThreshold"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601659B RID: 91547 RVA: 0x001F6E4F File Offset: 0x001F504F
		public vtkImageThreshold(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601659C RID: 91548
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageThreshold_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601659D RID: 91549 RVA: 0x001F6E60 File Offset: 0x001F5060
		public new static vtkImageThreshold New()
		{
			vtkImageThreshold result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageThreshold.vtkImageThreshold_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageThreshold)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601659E RID: 91550 RVA: 0x001F6EB4 File Offset: 0x001F50B4
		public vtkImageThreshold() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageThreshold.vtkImageThreshold_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601659F RID: 91551 RVA: 0x001F6EF8 File Offset: 0x001F50F8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060165A0 RID: 91552
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageThreshold_GetInValue_01(HandleRef pThis);

		/// <summary>
		/// Replace the in range pixels with this value.
		/// </summary>
		// Token: 0x060165A1 RID: 91553 RVA: 0x001F6F04 File Offset: 0x001F5104
		public virtual double GetInValue()
		{
			return vtkImageThreshold.vtkImageThreshold_GetInValue_01(base.GetCppThis());
		}

		// Token: 0x060165A2 RID: 91554
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageThreshold_GetLowerThreshold_02(HandleRef pThis);

		/// <summary>
		/// Get the Upper and Lower thresholds.
		/// </summary>
		// Token: 0x060165A3 RID: 91555 RVA: 0x001F6F24 File Offset: 0x001F5124
		public virtual double GetLowerThreshold()
		{
			return vtkImageThreshold.vtkImageThreshold_GetLowerThreshold_02(base.GetCppThis());
		}

		// Token: 0x060165A4 RID: 91556
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageThreshold_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060165A5 RID: 91557 RVA: 0x001F6F44 File Offset: 0x001F5144
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageThreshold.vtkImageThreshold_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060165A6 RID: 91558
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageThreshold_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060165A7 RID: 91559 RVA: 0x001F6F64 File Offset: 0x001F5164
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageThreshold.vtkImageThreshold_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060165A8 RID: 91560
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageThreshold_GetOutValue_05(HandleRef pThis);

		/// <summary>
		/// Replace the in range pixels with this value.
		/// </summary>
		// Token: 0x060165A9 RID: 91561 RVA: 0x001F6F80 File Offset: 0x001F5180
		public virtual double GetOutValue()
		{
			return vtkImageThreshold.vtkImageThreshold_GetOutValue_05(base.GetCppThis());
		}

		// Token: 0x060165AA RID: 91562
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageThreshold_GetOutputScalarType_06(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to
		/// </summary>
		// Token: 0x060165AB RID: 91563 RVA: 0x001F6FA0 File Offset: 0x001F51A0
		public virtual int GetOutputScalarType()
		{
			return vtkImageThreshold.vtkImageThreshold_GetOutputScalarType_06(base.GetCppThis());
		}

		// Token: 0x060165AC RID: 91564
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageThreshold_GetReplaceIn_07(HandleRef pThis);

		/// <summary>
		/// Determines whether to replace the pixel in range with InValue
		/// </summary>
		// Token: 0x060165AD RID: 91565 RVA: 0x001F6FC0 File Offset: 0x001F51C0
		public virtual int GetReplaceIn()
		{
			return vtkImageThreshold.vtkImageThreshold_GetReplaceIn_07(base.GetCppThis());
		}

		// Token: 0x060165AE RID: 91566
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageThreshold_GetReplaceOut_08(HandleRef pThis);

		/// <summary>
		/// Determines whether to replace the pixel out of range with OutValue
		/// </summary>
		// Token: 0x060165AF RID: 91567 RVA: 0x001F6FE0 File Offset: 0x001F51E0
		public virtual int GetReplaceOut()
		{
			return vtkImageThreshold.vtkImageThreshold_GetReplaceOut_08(base.GetCppThis());
		}

		// Token: 0x060165B0 RID: 91568
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageThreshold_GetUpperThreshold_09(HandleRef pThis);

		/// <summary>
		/// Get the Upper and Lower thresholds.
		/// </summary>
		// Token: 0x060165B1 RID: 91569 RVA: 0x001F7000 File Offset: 0x001F5200
		public virtual double GetUpperThreshold()
		{
			return vtkImageThreshold.vtkImageThreshold_GetUpperThreshold_09(base.GetCppThis());
		}

		// Token: 0x060165B2 RID: 91570
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageThreshold_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060165B3 RID: 91571 RVA: 0x001F7020 File Offset: 0x001F5220
		public override int IsA(string type)
		{
			return vtkImageThreshold.vtkImageThreshold_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x060165B4 RID: 91572
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageThreshold_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060165B5 RID: 91573 RVA: 0x001F7040 File Offset: 0x001F5240
		public new static int IsTypeOf(string type)
		{
			return vtkImageThreshold.vtkImageThreshold_IsTypeOf_11(type);
		}

		// Token: 0x060165B6 RID: 91574
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageThreshold_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060165B7 RID: 91575 RVA: 0x001F705C File Offset: 0x001F525C
		public new vtkImageThreshold NewInstance()
		{
			vtkImageThreshold result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageThreshold.vtkImageThreshold_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageThreshold)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060165B8 RID: 91576
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_ReplaceInOff_14(HandleRef pThis);

		/// <summary>
		/// Determines whether to replace the pixel in range with InValue
		/// </summary>
		// Token: 0x060165B9 RID: 91577 RVA: 0x001F70B6 File Offset: 0x001F52B6
		public virtual void ReplaceInOff()
		{
			vtkImageThreshold.vtkImageThreshold_ReplaceInOff_14(base.GetCppThis());
		}

		// Token: 0x060165BA RID: 91578
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_ReplaceInOn_15(HandleRef pThis);

		/// <summary>
		/// Determines whether to replace the pixel in range with InValue
		/// </summary>
		// Token: 0x060165BB RID: 91579 RVA: 0x001F70C5 File Offset: 0x001F52C5
		public virtual void ReplaceInOn()
		{
			vtkImageThreshold.vtkImageThreshold_ReplaceInOn_15(base.GetCppThis());
		}

		// Token: 0x060165BC RID: 91580
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_ReplaceOutOff_16(HandleRef pThis);

		/// <summary>
		/// Determines whether to replace the pixel out of range with OutValue
		/// </summary>
		// Token: 0x060165BD RID: 91581 RVA: 0x001F70D4 File Offset: 0x001F52D4
		public virtual void ReplaceOutOff()
		{
			vtkImageThreshold.vtkImageThreshold_ReplaceOutOff_16(base.GetCppThis());
		}

		// Token: 0x060165BE RID: 91582
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_ReplaceOutOn_17(HandleRef pThis);

		/// <summary>
		/// Determines whether to replace the pixel out of range with OutValue
		/// </summary>
		// Token: 0x060165BF RID: 91583 RVA: 0x001F70E3 File Offset: 0x001F52E3
		public virtual void ReplaceOutOn()
		{
			vtkImageThreshold.vtkImageThreshold_ReplaceOutOn_17(base.GetCppThis());
		}

		// Token: 0x060165C0 RID: 91584
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageThreshold_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060165C1 RID: 91585 RVA: 0x001F70F4 File Offset: 0x001F52F4
		public new static vtkImageThreshold SafeDownCast(vtkObjectBase o)
		{
			vtkImageThreshold vtkImageThreshold = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageThreshold.vtkImageThreshold_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageThreshold = (vtkImageThreshold)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageThreshold.Register(null);
				}
			}
			return vtkImageThreshold;
		}

		// Token: 0x060165C2 RID: 91586
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_SetInValue_19(HandleRef pThis, double val);

		/// <summary>
		/// Replace the in range pixels with this value.
		/// </summary>
		// Token: 0x060165C3 RID: 91587 RVA: 0x001F7173 File Offset: 0x001F5373
		public void SetInValue(double val)
		{
			vtkImageThreshold.vtkImageThreshold_SetInValue_19(base.GetCppThis(), val);
		}

		// Token: 0x060165C4 RID: 91588
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_SetOutValue_20(HandleRef pThis, double val);

		/// <summary>
		/// Replace the in range pixels with this value.
		/// </summary>
		// Token: 0x060165C5 RID: 91589 RVA: 0x001F7183 File Offset: 0x001F5383
		public void SetOutValue(double val)
		{
			vtkImageThreshold.vtkImageThreshold_SetOutValue_20(base.GetCppThis(), val);
		}

		// Token: 0x060165C6 RID: 91590
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_SetOutputScalarType_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the desired output scalar type to cast to
		/// </summary>
		// Token: 0x060165C7 RID: 91591 RVA: 0x001F7193 File Offset: 0x001F5393
		public virtual void SetOutputScalarType(int _arg)
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarType_21(base.GetCppThis(), _arg);
		}

		// Token: 0x060165C8 RID: 91592
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_SetOutputScalarTypeToChar_22(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to
		/// </summary>
		// Token: 0x060165C9 RID: 91593 RVA: 0x001F71A3 File Offset: 0x001F53A3
		public void SetOutputScalarTypeToChar()
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarTypeToChar_22(base.GetCppThis());
		}

		// Token: 0x060165CA RID: 91594
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_SetOutputScalarTypeToDouble_23(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to
		/// </summary>
		// Token: 0x060165CB RID: 91595 RVA: 0x001F71B2 File Offset: 0x001F53B2
		public void SetOutputScalarTypeToDouble()
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarTypeToDouble_23(base.GetCppThis());
		}

		// Token: 0x060165CC RID: 91596
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_SetOutputScalarTypeToFloat_24(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to
		/// </summary>
		// Token: 0x060165CD RID: 91597 RVA: 0x001F71C1 File Offset: 0x001F53C1
		public void SetOutputScalarTypeToFloat()
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarTypeToFloat_24(base.GetCppThis());
		}

		// Token: 0x060165CE RID: 91598
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_SetOutputScalarTypeToInt_25(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to
		/// </summary>
		// Token: 0x060165CF RID: 91599 RVA: 0x001F71D0 File Offset: 0x001F53D0
		public void SetOutputScalarTypeToInt()
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarTypeToInt_25(base.GetCppThis());
		}

		// Token: 0x060165D0 RID: 91600
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_SetOutputScalarTypeToLong_26(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to
		/// </summary>
		// Token: 0x060165D1 RID: 91601 RVA: 0x001F71DF File Offset: 0x001F53DF
		public void SetOutputScalarTypeToLong()
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarTypeToLong_26(base.GetCppThis());
		}

		// Token: 0x060165D2 RID: 91602
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_SetOutputScalarTypeToShort_27(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to
		/// </summary>
		// Token: 0x060165D3 RID: 91603 RVA: 0x001F71EE File Offset: 0x001F53EE
		public void SetOutputScalarTypeToShort()
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarTypeToShort_27(base.GetCppThis());
		}

		// Token: 0x060165D4 RID: 91604
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_SetOutputScalarTypeToSignedChar_28(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to
		/// </summary>
		// Token: 0x060165D5 RID: 91605 RVA: 0x001F71FD File Offset: 0x001F53FD
		public void SetOutputScalarTypeToSignedChar()
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarTypeToSignedChar_28(base.GetCppThis());
		}

		// Token: 0x060165D6 RID: 91606
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_SetOutputScalarTypeToUnsignedChar_29(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to
		/// </summary>
		// Token: 0x060165D7 RID: 91607 RVA: 0x001F720C File Offset: 0x001F540C
		public void SetOutputScalarTypeToUnsignedChar()
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarTypeToUnsignedChar_29(base.GetCppThis());
		}

		// Token: 0x060165D8 RID: 91608
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_SetOutputScalarTypeToUnsignedInt_30(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to
		/// </summary>
		// Token: 0x060165D9 RID: 91609 RVA: 0x001F721B File Offset: 0x001F541B
		public void SetOutputScalarTypeToUnsignedInt()
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarTypeToUnsignedInt_30(base.GetCppThis());
		}

		// Token: 0x060165DA RID: 91610
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_SetOutputScalarTypeToUnsignedLong_31(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to
		/// </summary>
		// Token: 0x060165DB RID: 91611 RVA: 0x001F722A File Offset: 0x001F542A
		public void SetOutputScalarTypeToUnsignedLong()
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarTypeToUnsignedLong_31(base.GetCppThis());
		}

		// Token: 0x060165DC RID: 91612
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_SetOutputScalarTypeToUnsignedShort_32(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to
		/// </summary>
		// Token: 0x060165DD RID: 91613 RVA: 0x001F7239 File Offset: 0x001F5439
		public void SetOutputScalarTypeToUnsignedShort()
		{
			vtkImageThreshold.vtkImageThreshold_SetOutputScalarTypeToUnsignedShort_32(base.GetCppThis());
		}

		// Token: 0x060165DE RID: 91614
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_SetReplaceIn_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Determines whether to replace the pixel in range with InValue
		/// </summary>
		// Token: 0x060165DF RID: 91615 RVA: 0x001F7248 File Offset: 0x001F5448
		public virtual void SetReplaceIn(int _arg)
		{
			vtkImageThreshold.vtkImageThreshold_SetReplaceIn_33(base.GetCppThis(), _arg);
		}

		// Token: 0x060165E0 RID: 91616
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_SetReplaceOut_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Determines whether to replace the pixel out of range with OutValue
		/// </summary>
		// Token: 0x060165E1 RID: 91617 RVA: 0x001F7258 File Offset: 0x001F5458
		public virtual void SetReplaceOut(int _arg)
		{
			vtkImageThreshold.vtkImageThreshold_SetReplaceOut_34(base.GetCppThis(), _arg);
		}

		// Token: 0x060165E2 RID: 91618
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_ThresholdBetween_35(HandleRef pThis, double lower, double upper);

		/// <summary>
		/// The values in a range (inclusive) match
		/// </summary>
		// Token: 0x060165E3 RID: 91619 RVA: 0x001F7268 File Offset: 0x001F5468
		public void ThresholdBetween(double lower, double upper)
		{
			vtkImageThreshold.vtkImageThreshold_ThresholdBetween_35(base.GetCppThis(), lower, upper);
		}

		// Token: 0x060165E4 RID: 91620
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_ThresholdByLower_36(HandleRef pThis, double thresh);

		/// <summary>
		/// The values less than or equal to the value match.
		/// </summary>
		// Token: 0x060165E5 RID: 91621 RVA: 0x001F7279 File Offset: 0x001F5479
		public void ThresholdByLower(double thresh)
		{
			vtkImageThreshold.vtkImageThreshold_ThresholdByLower_36(base.GetCppThis(), thresh);
		}

		// Token: 0x060165E6 RID: 91622
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageThreshold_ThresholdByUpper_37(HandleRef pThis, double thresh);

		/// <summary>
		/// The values greater than or equal to the value match.
		/// </summary>
		// Token: 0x060165E7 RID: 91623 RVA: 0x001F7289 File Offset: 0x001F5489
		public void ThresholdByUpper(double thresh)
		{
			vtkImageThreshold.vtkImageThreshold_ThresholdByUpper_37(base.GetCppThis(), thresh);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001928 RID: 6440
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageThreshold";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001929 RID: 6441
		public new static readonly string MRClassNameKey = "class vtkImageThreshold";
	}
}
