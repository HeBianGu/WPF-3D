using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageLogic
	/// </summary>
	/// <remarks>
	///    And, or, xor, nand, nor, not.
	///
	/// vtkImageLogic implements basic logic operations.
	/// SetOperation is used to select the filter's behavior.
	/// The filter can take two or one input. Inputs must have the same type.
	/// </remarks>
	// Token: 0x02000255 RID: 597
	public class vtkImageLogic : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006E4C RID: 28236 RVA: 0x0009F1B7 File Offset: 0x0009D3B7
		static vtkImageLogic()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageLogic.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageLogic"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006E4D RID: 28237 RVA: 0x0009F1DF File Offset: 0x0009D3DF
		public vtkImageLogic(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006E4E RID: 28238
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageLogic_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E4F RID: 28239 RVA: 0x0009F1F0 File Offset: 0x0009D3F0
		public new static vtkImageLogic New()
		{
			vtkImageLogic result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageLogic.vtkImageLogic_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageLogic)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E50 RID: 28240 RVA: 0x0009F244 File Offset: 0x0009D444
		public vtkImageLogic() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageLogic.vtkImageLogic_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006E51 RID: 28241 RVA: 0x0009F288 File Offset: 0x0009D488
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006E52 RID: 28242
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageLogic_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E53 RID: 28243 RVA: 0x0009F294 File Offset: 0x0009D494
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageLogic.vtkImageLogic_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06006E54 RID: 28244
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageLogic_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E55 RID: 28245 RVA: 0x0009F2B4 File Offset: 0x0009D4B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageLogic.vtkImageLogic_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06006E56 RID: 28246
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageLogic_GetOperation_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the Operation to perform.
		/// </summary>
		// Token: 0x06006E57 RID: 28247 RVA: 0x0009F2D0 File Offset: 0x0009D4D0
		public virtual int GetOperation()
		{
			return vtkImageLogic.vtkImageLogic_GetOperation_03(base.GetCppThis());
		}

		// Token: 0x06006E58 RID: 28248
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageLogic_GetOutputTrueValue_04(HandleRef pThis);

		/// <summary>
		/// Set the value to use for true in the output.
		/// </summary>
		// Token: 0x06006E59 RID: 28249 RVA: 0x0009F2F0 File Offset: 0x0009D4F0
		public virtual double GetOutputTrueValue()
		{
			return vtkImageLogic.vtkImageLogic_GetOutputTrueValue_04(base.GetCppThis());
		}

		// Token: 0x06006E5A RID: 28250
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageLogic_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E5B RID: 28251 RVA: 0x0009F310 File Offset: 0x0009D510
		public override int IsA(string type)
		{
			return vtkImageLogic.vtkImageLogic_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06006E5C RID: 28252
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageLogic_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E5D RID: 28253 RVA: 0x0009F330 File Offset: 0x0009D530
		public new static int IsTypeOf(string type)
		{
			return vtkImageLogic.vtkImageLogic_IsTypeOf_06(type);
		}

		// Token: 0x06006E5E RID: 28254
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageLogic_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E5F RID: 28255 RVA: 0x0009F34C File Offset: 0x0009D54C
		public new vtkImageLogic NewInstance()
		{
			vtkImageLogic result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageLogic.vtkImageLogic_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageLogic)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006E60 RID: 28256
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageLogic_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E61 RID: 28257 RVA: 0x0009F3A8 File Offset: 0x0009D5A8
		public new static vtkImageLogic SafeDownCast(vtkObjectBase o)
		{
			vtkImageLogic vtkImageLogic = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageLogic.vtkImageLogic_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageLogic = (vtkImageLogic)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageLogic.Register(null);
				}
			}
			return vtkImageLogic;
		}

		// Token: 0x06006E62 RID: 28258
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageLogic_SetInput1Data_10(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set the Input1 of this filter.
		/// </summary>
		// Token: 0x06006E63 RID: 28259 RVA: 0x0009F428 File Offset: 0x0009D628
		public virtual void SetInput1Data(vtkDataObject input)
		{
			vtkImageLogic.vtkImageLogic_SetInput1Data_10(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06006E64 RID: 28260
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageLogic_SetInput2Data_11(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set the Input2 of this filter.
		/// </summary>
		// Token: 0x06006E65 RID: 28261 RVA: 0x0009F458 File Offset: 0x0009D658
		public virtual void SetInput2Data(vtkDataObject input)
		{
			vtkImageLogic.vtkImageLogic_SetInput2Data_11(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06006E66 RID: 28262
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageLogic_SetOperation_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the Operation to perform.
		/// </summary>
		// Token: 0x06006E67 RID: 28263 RVA: 0x0009F487 File Offset: 0x0009D687
		public virtual void SetOperation(int _arg)
		{
			vtkImageLogic.vtkImageLogic_SetOperation_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06006E68 RID: 28264
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageLogic_SetOperationToAnd_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the Operation to perform.
		/// </summary>
		// Token: 0x06006E69 RID: 28265 RVA: 0x0009F497 File Offset: 0x0009D697
		public void SetOperationToAnd()
		{
			vtkImageLogic.vtkImageLogic_SetOperationToAnd_13(base.GetCppThis());
		}

		// Token: 0x06006E6A RID: 28266
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageLogic_SetOperationToNand_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the Operation to perform.
		/// </summary>
		// Token: 0x06006E6B RID: 28267 RVA: 0x0009F4A6 File Offset: 0x0009D6A6
		public void SetOperationToNand()
		{
			vtkImageLogic.vtkImageLogic_SetOperationToNand_14(base.GetCppThis());
		}

		// Token: 0x06006E6C RID: 28268
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageLogic_SetOperationToNor_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the Operation to perform.
		/// </summary>
		// Token: 0x06006E6D RID: 28269 RVA: 0x0009F4B5 File Offset: 0x0009D6B5
		public void SetOperationToNor()
		{
			vtkImageLogic.vtkImageLogic_SetOperationToNor_15(base.GetCppThis());
		}

		// Token: 0x06006E6E RID: 28270
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageLogic_SetOperationToNot_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the Operation to perform.
		/// </summary>
		// Token: 0x06006E6F RID: 28271 RVA: 0x0009F4C4 File Offset: 0x0009D6C4
		public void SetOperationToNot()
		{
			vtkImageLogic.vtkImageLogic_SetOperationToNot_16(base.GetCppThis());
		}

		// Token: 0x06006E70 RID: 28272
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageLogic_SetOperationToOr_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the Operation to perform.
		/// </summary>
		// Token: 0x06006E71 RID: 28273 RVA: 0x0009F4D3 File Offset: 0x0009D6D3
		public void SetOperationToOr()
		{
			vtkImageLogic.vtkImageLogic_SetOperationToOr_17(base.GetCppThis());
		}

		// Token: 0x06006E72 RID: 28274
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageLogic_SetOperationToXor_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the Operation to perform.
		/// </summary>
		// Token: 0x06006E73 RID: 28275 RVA: 0x0009F4E2 File Offset: 0x0009D6E2
		public void SetOperationToXor()
		{
			vtkImageLogic.vtkImageLogic_SetOperationToXor_18(base.GetCppThis());
		}

		// Token: 0x06006E74 RID: 28276
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageLogic_SetOutputTrueValue_19(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the value to use for true in the output.
		/// </summary>
		// Token: 0x06006E75 RID: 28277 RVA: 0x0009F4F1 File Offset: 0x0009D6F1
		public virtual void SetOutputTrueValue(double _arg)
		{
			vtkImageLogic.vtkImageLogic_SetOutputTrueValue_19(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400099F RID: 2463
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageLogic";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009A0 RID: 2464
		public new static readonly string MRClassNameKey = "class vtkImageLogic";
	}
}
