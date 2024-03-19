using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageRGBToYIQ
	/// </summary>
	/// <remarks>
	///    Converts RGB components to YIQ.
	///
	/// For each pixel with red, blue, and green components this
	/// filter output the color coded as YIQ.
	/// Output type must be the same as input type. Only signed types should be
	/// used because the YIQ color space uses negative numbers.
	/// </remarks>
	// Token: 0x020003F6 RID: 1014
	public class vtkImageRGBToYIQ : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C1B1 RID: 49585 RVA: 0x0010DD8B File Offset: 0x0010BF8B
		static vtkImageRGBToYIQ()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageRGBToYIQ.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageRGBToYIQ"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C1B2 RID: 49586 RVA: 0x0010DDB3 File Offset: 0x0010BFB3
		public vtkImageRGBToYIQ(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C1B3 RID: 49587
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageRGBToYIQ_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1B4 RID: 49588 RVA: 0x0010DDC4 File Offset: 0x0010BFC4
		public new static vtkImageRGBToYIQ New()
		{
			vtkImageRGBToYIQ result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageRGBToYIQ.vtkImageRGBToYIQ_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageRGBToYIQ)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1B5 RID: 49589 RVA: 0x0010DE18 File Offset: 0x0010C018
		public vtkImageRGBToYIQ() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageRGBToYIQ.vtkImageRGBToYIQ_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C1B6 RID: 49590 RVA: 0x0010DE5C File Offset: 0x0010C05C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C1B7 RID: 49591
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageRGBToYIQ_GetMaximum_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1B8 RID: 49592 RVA: 0x0010DE68 File Offset: 0x0010C068
		public virtual double GetMaximum()
		{
			return vtkImageRGBToYIQ.vtkImageRGBToYIQ_GetMaximum_01(base.GetCppThis());
		}

		// Token: 0x0600C1B9 RID: 49593
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageRGBToYIQ_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1BA RID: 49594 RVA: 0x0010DE88 File Offset: 0x0010C088
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageRGBToYIQ.vtkImageRGBToYIQ_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600C1BB RID: 49595
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageRGBToYIQ_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1BC RID: 49596 RVA: 0x0010DEA8 File Offset: 0x0010C0A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageRGBToYIQ.vtkImageRGBToYIQ_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600C1BD RID: 49597
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageRGBToYIQ_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1BE RID: 49598 RVA: 0x0010DEC4 File Offset: 0x0010C0C4
		public override int IsA(string type)
		{
			return vtkImageRGBToYIQ.vtkImageRGBToYIQ_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600C1BF RID: 49599
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageRGBToYIQ_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1C0 RID: 49600 RVA: 0x0010DEE4 File Offset: 0x0010C0E4
		public new static int IsTypeOf(string type)
		{
			return vtkImageRGBToYIQ.vtkImageRGBToYIQ_IsTypeOf_05(type);
		}

		// Token: 0x0600C1C1 RID: 49601
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageRGBToYIQ_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1C2 RID: 49602 RVA: 0x0010DF00 File Offset: 0x0010C100
		public new vtkImageRGBToYIQ NewInstance()
		{
			vtkImageRGBToYIQ result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageRGBToYIQ.vtkImageRGBToYIQ_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageRGBToYIQ)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C1C3 RID: 49603
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageRGBToYIQ_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1C4 RID: 49604 RVA: 0x0010DF5C File Offset: 0x0010C15C
		public new static vtkImageRGBToYIQ SafeDownCast(vtkObjectBase o)
		{
			vtkImageRGBToYIQ vtkImageRGBToYIQ = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageRGBToYIQ.vtkImageRGBToYIQ_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageRGBToYIQ = (vtkImageRGBToYIQ)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageRGBToYIQ.Register(null);
				}
			}
			return vtkImageRGBToYIQ;
		}

		// Token: 0x0600C1C5 RID: 49605
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageRGBToYIQ_SetMaximum_09(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1C6 RID: 49606 RVA: 0x0010DFDB File Offset: 0x0010C1DB
		public virtual void SetMaximum(double _arg)
		{
			vtkImageRGBToYIQ.vtkImageRGBToYIQ_SetMaximum_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E59 RID: 3673
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageRGBToYIQ";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E5A RID: 3674
		public new static readonly string MRClassNameKey = "class vtkImageRGBToYIQ";
	}
}
