using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageEuclideanToPolar
	/// </summary>
	/// <remarks>
	///    Converts 2D Euclidean coordinates to polar.
	///
	/// For each pixel with vector components x,y, this filter outputs
	/// theta in component0, and radius in component1.
	/// </remarks>
	// Token: 0x02000484 RID: 1156
	public class vtkImageEuclideanToPolar : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D4BB RID: 54459 RVA: 0x00127F79 File Offset: 0x00126179
		static vtkImageEuclideanToPolar()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageEuclideanToPolar.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageEuclideanToPolar"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D4BC RID: 54460 RVA: 0x00127FA1 File Offset: 0x001261A1
		public vtkImageEuclideanToPolar(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D4BD RID: 54461
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageEuclideanToPolar_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D4BE RID: 54462 RVA: 0x00127FB0 File Offset: 0x001261B0
		public new static vtkImageEuclideanToPolar New()
		{
			vtkImageEuclideanToPolar result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageEuclideanToPolar.vtkImageEuclideanToPolar_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageEuclideanToPolar)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D4BF RID: 54463 RVA: 0x00128004 File Offset: 0x00126204
		public vtkImageEuclideanToPolar() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageEuclideanToPolar.vtkImageEuclideanToPolar_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D4C0 RID: 54464 RVA: 0x00128048 File Offset: 0x00126248
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D4C1 RID: 54465
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageEuclideanToPolar_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D4C2 RID: 54466 RVA: 0x00128054 File Offset: 0x00126254
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageEuclideanToPolar.vtkImageEuclideanToPolar_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600D4C3 RID: 54467
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageEuclideanToPolar_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D4C4 RID: 54468 RVA: 0x00128074 File Offset: 0x00126274
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageEuclideanToPolar.vtkImageEuclideanToPolar_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600D4C5 RID: 54469
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageEuclideanToPolar_GetThetaMaximum_03(HandleRef pThis);

		/// <summary>
		/// Theta is an angle. Maximum specifies when it maps back to 0.
		/// ThetaMaximum defaults to 255 instead of 2PI, because unsigned char
		/// is expected as input. The output type must be the same as input type.
		/// </summary>
		// Token: 0x0600D4C6 RID: 54470 RVA: 0x00128090 File Offset: 0x00126290
		public virtual double GetThetaMaximum()
		{
			return vtkImageEuclideanToPolar.vtkImageEuclideanToPolar_GetThetaMaximum_03(base.GetCppThis());
		}

		// Token: 0x0600D4C7 RID: 54471
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageEuclideanToPolar_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D4C8 RID: 54472 RVA: 0x001280B0 File Offset: 0x001262B0
		public override int IsA(string type)
		{
			return vtkImageEuclideanToPolar.vtkImageEuclideanToPolar_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600D4C9 RID: 54473
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageEuclideanToPolar_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D4CA RID: 54474 RVA: 0x001280D0 File Offset: 0x001262D0
		public new static int IsTypeOf(string type)
		{
			return vtkImageEuclideanToPolar.vtkImageEuclideanToPolar_IsTypeOf_05(type);
		}

		// Token: 0x0600D4CB RID: 54475
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageEuclideanToPolar_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D4CC RID: 54476 RVA: 0x001280EC File Offset: 0x001262EC
		public new vtkImageEuclideanToPolar NewInstance()
		{
			vtkImageEuclideanToPolar result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageEuclideanToPolar.vtkImageEuclideanToPolar_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageEuclideanToPolar)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D4CD RID: 54477
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageEuclideanToPolar_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D4CE RID: 54478 RVA: 0x00128148 File Offset: 0x00126348
		public new static vtkImageEuclideanToPolar SafeDownCast(vtkObjectBase o)
		{
			vtkImageEuclideanToPolar vtkImageEuclideanToPolar = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageEuclideanToPolar.vtkImageEuclideanToPolar_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageEuclideanToPolar = (vtkImageEuclideanToPolar)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageEuclideanToPolar.Register(null);
				}
			}
			return vtkImageEuclideanToPolar;
		}

		// Token: 0x0600D4CF RID: 54479
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEuclideanToPolar_SetThetaMaximum_09(HandleRef pThis, double _arg);

		/// <summary>
		/// Theta is an angle. Maximum specifies when it maps back to 0.
		/// ThetaMaximum defaults to 255 instead of 2PI, because unsigned char
		/// is expected as input. The output type must be the same as input type.
		/// </summary>
		// Token: 0x0600D4D0 RID: 54480 RVA: 0x001281C7 File Offset: 0x001263C7
		public virtual void SetThetaMaximum(double _arg)
		{
			vtkImageEuclideanToPolar.vtkImageEuclideanToPolar_SetThetaMaximum_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FB0 RID: 4016
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageEuclideanToPolar";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FB1 RID: 4017
		public new static readonly string MRClassNameKey = "class vtkImageEuclideanToPolar";
	}
}
