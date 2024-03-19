using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageMaskBits
	/// </summary>
	/// <remarks>
	///    applies a bit-mask pattern to each component.
	///
	///
	/// vtkImageMaskBits applies a bit-mask pattern to each component.  The
	/// bit-mask can be applied using a variety of boolean bitwise operators.
	/// </remarks>
	// Token: 0x02000257 RID: 599
	public class vtkImageMaskBits : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006E88 RID: 28296 RVA: 0x0009F72F File Offset: 0x0009D92F
		static vtkImageMaskBits()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMaskBits.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMaskBits"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006E89 RID: 28297 RVA: 0x0009F757 File Offset: 0x0009D957
		public vtkImageMaskBits(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006E8A RID: 28298
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMaskBits_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E8B RID: 28299 RVA: 0x0009F768 File Offset: 0x0009D968
		public new static vtkImageMaskBits New()
		{
			vtkImageMaskBits result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMaskBits.vtkImageMaskBits_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMaskBits)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E8C RID: 28300 RVA: 0x0009F7BC File Offset: 0x0009D9BC
		public vtkImageMaskBits() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageMaskBits.vtkImageMaskBits_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006E8D RID: 28301 RVA: 0x0009F800 File Offset: 0x0009DA00
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006E8E RID: 28302
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMaskBits_GetMasks_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the bit-masks. Default is 0xffffffff.
		/// </summary>
		// Token: 0x06006E8F RID: 28303 RVA: 0x0009F80C File Offset: 0x0009DA0C
		public virtual uint[] GetMasks()
		{
			IntPtr intPtr = vtkImageMaskBits.vtkImageMaskBits_GetMasks_01(base.GetCppThis());
			uint[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new uint[4];
				int[] array2 = new int[4];
				Marshal.Copy(intPtr, array2, 0, array.Length);
				for (int i = 0; i < 4; i++)
				{
					array[i] = (uint)array2[i];
				}
			}
			return array;
		}

		// Token: 0x06006E90 RID: 28304
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMaskBits_GetMasks_02(HandleRef pThis, ref uint _arg1, ref uint _arg2, ref uint _arg3, ref uint _arg4);

		/// <summary>
		/// Set/Get the bit-masks. Default is 0xffffffff.
		/// </summary>
		// Token: 0x06006E91 RID: 28305 RVA: 0x0009F879 File Offset: 0x0009DA79
		public virtual void GetMasks(ref uint _arg1, ref uint _arg2, ref uint _arg3, ref uint _arg4)
		{
			vtkImageMaskBits.vtkImageMaskBits_GetMasks_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x06006E92 RID: 28306
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMaskBits_GetMasks_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the bit-masks. Default is 0xffffffff.
		/// </summary>
		// Token: 0x06006E93 RID: 28307 RVA: 0x0009F88D File Offset: 0x0009DA8D
		public virtual void GetMasks(IntPtr _arg)
		{
			vtkImageMaskBits.vtkImageMaskBits_GetMasks_03(base.GetCppThis(), _arg);
		}

		// Token: 0x06006E94 RID: 28308
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMaskBits_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E95 RID: 28309 RVA: 0x0009F8A0 File Offset: 0x0009DAA0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageMaskBits.vtkImageMaskBits_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06006E96 RID: 28310
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMaskBits_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E97 RID: 28311 RVA: 0x0009F8C0 File Offset: 0x0009DAC0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageMaskBits.vtkImageMaskBits_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06006E98 RID: 28312
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMaskBits_GetOperation_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the boolean operator. Default is AND.
		/// </summary>
		// Token: 0x06006E99 RID: 28313 RVA: 0x0009F8DC File Offset: 0x0009DADC
		public virtual int GetOperation()
		{
			return vtkImageMaskBits.vtkImageMaskBits_GetOperation_06(base.GetCppThis());
		}

		// Token: 0x06006E9A RID: 28314
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMaskBits_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E9B RID: 28315 RVA: 0x0009F8FC File Offset: 0x0009DAFC
		public override int IsA(string type)
		{
			return vtkImageMaskBits.vtkImageMaskBits_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06006E9C RID: 28316
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMaskBits_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E9D RID: 28317 RVA: 0x0009F91C File Offset: 0x0009DB1C
		public new static int IsTypeOf(string type)
		{
			return vtkImageMaskBits.vtkImageMaskBits_IsTypeOf_08(type);
		}

		// Token: 0x06006E9E RID: 28318
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMaskBits_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E9F RID: 28319 RVA: 0x0009F938 File Offset: 0x0009DB38
		public new vtkImageMaskBits NewInstance()
		{
			vtkImageMaskBits result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMaskBits.vtkImageMaskBits_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMaskBits)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006EA0 RID: 28320
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMaskBits_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006EA1 RID: 28321 RVA: 0x0009F994 File Offset: 0x0009DB94
		public new static vtkImageMaskBits SafeDownCast(vtkObjectBase o)
		{
			vtkImageMaskBits vtkImageMaskBits = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMaskBits.vtkImageMaskBits_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMaskBits = (vtkImageMaskBits)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMaskBits.Register(null);
				}
			}
			return vtkImageMaskBits;
		}

		// Token: 0x06006EA2 RID: 28322
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMaskBits_SetMask_12(HandleRef pThis, uint mask);

		/// <summary>
		/// Set/Get the bit-masks. Default is 0xffffffff.
		/// </summary>
		// Token: 0x06006EA3 RID: 28323 RVA: 0x0009FA13 File Offset: 0x0009DC13
		public void SetMask(uint mask)
		{
			vtkImageMaskBits.vtkImageMaskBits_SetMask_12(base.GetCppThis(), mask);
		}

		// Token: 0x06006EA4 RID: 28324
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMaskBits_SetMasks_13(HandleRef pThis, uint _arg1, uint _arg2, uint _arg3, uint _arg4);

		/// <summary>
		/// Set/Get the bit-masks. Default is 0xffffffff.
		/// </summary>
		// Token: 0x06006EA5 RID: 28325 RVA: 0x0009FA23 File Offset: 0x0009DC23
		public virtual void SetMasks(uint _arg1, uint _arg2, uint _arg3, uint _arg4)
		{
			vtkImageMaskBits.vtkImageMaskBits_SetMasks_13(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x06006EA6 RID: 28326
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMaskBits_SetMasks_14(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the bit-masks. Default is 0xffffffff.
		/// </summary>
		// Token: 0x06006EA7 RID: 28327 RVA: 0x0009FA37 File Offset: 0x0009DC37
		public virtual void SetMasks(IntPtr _arg)
		{
			vtkImageMaskBits.vtkImageMaskBits_SetMasks_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06006EA8 RID: 28328
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMaskBits_SetMasks_15(HandleRef pThis, uint mask1, uint mask2);

		/// <summary>
		/// Set/Get the bit-masks. Default is 0xffffffff.
		/// </summary>
		// Token: 0x06006EA9 RID: 28329 RVA: 0x0009FA47 File Offset: 0x0009DC47
		public void SetMasks(uint mask1, uint mask2)
		{
			vtkImageMaskBits.vtkImageMaskBits_SetMasks_15(base.GetCppThis(), mask1, mask2);
		}

		// Token: 0x06006EAA RID: 28330
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMaskBits_SetMasks_16(HandleRef pThis, uint mask1, uint mask2, uint mask3);

		/// <summary>
		/// Set/Get the bit-masks. Default is 0xffffffff.
		/// </summary>
		// Token: 0x06006EAB RID: 28331 RVA: 0x0009FA58 File Offset: 0x0009DC58
		public void SetMasks(uint mask1, uint mask2, uint mask3)
		{
			vtkImageMaskBits.vtkImageMaskBits_SetMasks_16(base.GetCppThis(), mask1, mask2, mask3);
		}

		// Token: 0x06006EAC RID: 28332
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMaskBits_SetOperation_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the boolean operator. Default is AND.
		/// </summary>
		// Token: 0x06006EAD RID: 28333 RVA: 0x0009FA6A File Offset: 0x0009DC6A
		public virtual void SetOperation(int _arg)
		{
			vtkImageMaskBits.vtkImageMaskBits_SetOperation_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06006EAE RID: 28334
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMaskBits_SetOperationToAnd_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the boolean operator. Default is AND.
		/// </summary>
		// Token: 0x06006EAF RID: 28335 RVA: 0x0009FA7A File Offset: 0x0009DC7A
		public void SetOperationToAnd()
		{
			vtkImageMaskBits.vtkImageMaskBits_SetOperationToAnd_18(base.GetCppThis());
		}

		// Token: 0x06006EB0 RID: 28336
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMaskBits_SetOperationToNand_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the boolean operator. Default is AND.
		/// </summary>
		// Token: 0x06006EB1 RID: 28337 RVA: 0x0009FA89 File Offset: 0x0009DC89
		public void SetOperationToNand()
		{
			vtkImageMaskBits.vtkImageMaskBits_SetOperationToNand_19(base.GetCppThis());
		}

		// Token: 0x06006EB2 RID: 28338
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMaskBits_SetOperationToNor_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the boolean operator. Default is AND.
		/// </summary>
		// Token: 0x06006EB3 RID: 28339 RVA: 0x0009FA98 File Offset: 0x0009DC98
		public void SetOperationToNor()
		{
			vtkImageMaskBits.vtkImageMaskBits_SetOperationToNor_20(base.GetCppThis());
		}

		// Token: 0x06006EB4 RID: 28340
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMaskBits_SetOperationToOr_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the boolean operator. Default is AND.
		/// </summary>
		// Token: 0x06006EB5 RID: 28341 RVA: 0x0009FAA7 File Offset: 0x0009DCA7
		public void SetOperationToOr()
		{
			vtkImageMaskBits.vtkImageMaskBits_SetOperationToOr_21(base.GetCppThis());
		}

		// Token: 0x06006EB6 RID: 28342
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMaskBits_SetOperationToXor_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the boolean operator. Default is AND.
		/// </summary>
		// Token: 0x06006EB7 RID: 28343 RVA: 0x0009FAB6 File Offset: 0x0009DCB6
		public void SetOperationToXor()
		{
			vtkImageMaskBits.vtkImageMaskBits_SetOperationToXor_22(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009A3 RID: 2467
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMaskBits";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009A4 RID: 2468
		public new static readonly string MRClassNameKey = "class vtkImageMaskBits";
	}
}
