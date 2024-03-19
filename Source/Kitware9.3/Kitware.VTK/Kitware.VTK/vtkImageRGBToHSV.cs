using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageRGBToHSV
	/// </summary>
	/// <remarks>
	///    Converts RGB components to HSV.
	///
	/// For each pixel with red, blue, and green components this
	/// filter output the color coded as hue, saturation and value.
	/// Output type must be the same as input type.
	/// </remarks>
	// Token: 0x020003F5 RID: 1013
	public class vtkImageRGBToHSV : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C19B RID: 49563 RVA: 0x0010DB2B File Offset: 0x0010BD2B
		static vtkImageRGBToHSV()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageRGBToHSV.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageRGBToHSV"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C19C RID: 49564 RVA: 0x0010DB53 File Offset: 0x0010BD53
		public vtkImageRGBToHSV(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C19D RID: 49565
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageRGBToHSV_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C19E RID: 49566 RVA: 0x0010DB64 File Offset: 0x0010BD64
		public new static vtkImageRGBToHSV New()
		{
			vtkImageRGBToHSV result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageRGBToHSV.vtkImageRGBToHSV_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageRGBToHSV)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C19F RID: 49567 RVA: 0x0010DBB8 File Offset: 0x0010BDB8
		public vtkImageRGBToHSV() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageRGBToHSV.vtkImageRGBToHSV_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C1A0 RID: 49568 RVA: 0x0010DBFC File Offset: 0x0010BDFC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C1A1 RID: 49569
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageRGBToHSV_GetMaximum_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1A2 RID: 49570 RVA: 0x0010DC08 File Offset: 0x0010BE08
		public virtual double GetMaximum()
		{
			return vtkImageRGBToHSV.vtkImageRGBToHSV_GetMaximum_01(base.GetCppThis());
		}

		// Token: 0x0600C1A3 RID: 49571
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageRGBToHSV_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1A4 RID: 49572 RVA: 0x0010DC28 File Offset: 0x0010BE28
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageRGBToHSV.vtkImageRGBToHSV_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600C1A5 RID: 49573
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageRGBToHSV_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1A6 RID: 49574 RVA: 0x0010DC48 File Offset: 0x0010BE48
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageRGBToHSV.vtkImageRGBToHSV_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600C1A7 RID: 49575
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageRGBToHSV_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1A8 RID: 49576 RVA: 0x0010DC64 File Offset: 0x0010BE64
		public override int IsA(string type)
		{
			return vtkImageRGBToHSV.vtkImageRGBToHSV_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600C1A9 RID: 49577
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageRGBToHSV_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1AA RID: 49578 RVA: 0x0010DC84 File Offset: 0x0010BE84
		public new static int IsTypeOf(string type)
		{
			return vtkImageRGBToHSV.vtkImageRGBToHSV_IsTypeOf_05(type);
		}

		// Token: 0x0600C1AB RID: 49579
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageRGBToHSV_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1AC RID: 49580 RVA: 0x0010DCA0 File Offset: 0x0010BEA0
		public new vtkImageRGBToHSV NewInstance()
		{
			vtkImageRGBToHSV result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageRGBToHSV.vtkImageRGBToHSV_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageRGBToHSV)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C1AD RID: 49581
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageRGBToHSV_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1AE RID: 49582 RVA: 0x0010DCFC File Offset: 0x0010BEFC
		public new static vtkImageRGBToHSV SafeDownCast(vtkObjectBase o)
		{
			vtkImageRGBToHSV vtkImageRGBToHSV = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageRGBToHSV.vtkImageRGBToHSV_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageRGBToHSV = (vtkImageRGBToHSV)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageRGBToHSV.Register(null);
				}
			}
			return vtkImageRGBToHSV;
		}

		// Token: 0x0600C1AF RID: 49583
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageRGBToHSV_SetMaximum_09(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1B0 RID: 49584 RVA: 0x0010DD7B File Offset: 0x0010BF7B
		public virtual void SetMaximum(double _arg)
		{
			vtkImageRGBToHSV.vtkImageRGBToHSV_SetMaximum_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E57 RID: 3671
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageRGBToHSV";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E58 RID: 3672
		public new static readonly string MRClassNameKey = "class vtkImageRGBToHSV";
	}
}
